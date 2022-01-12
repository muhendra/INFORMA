using DXMNCGUI_INFORMA.Controllers;
using DXMNCGUI_INFORMA.Controllers.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace DXMNCGUI_INFORMA.Transaction.InternalMemo.FreeTextMemo
{
    public class FreeTextMemoSql : FreeTextMemoDB
    {
        object obj;
        bool bIsNew = false;
        private string sQuery = "", strnextapprover = "";
        public override DataTable LoadBrowseTable(bool bViewAll, string userID)
        {
            myBrowseTable.Clear();
            myLocalDBSetting.LoadDataTable(myBrowseTable, "SELECT * FROM [dbo].[FreeTextMemo] ORDER BY DocDate DESC", true);

            DataColumn[] keyHeader = new DataColumn[1];
            keyHeader[0] = myBrowseTable.Columns["DocKey"];
            myBrowseTable.PrimaryKey = keyHeader;
            return myBrowseTable;
        }

        protected override DataSet LoadData(long headerid, string docno)
        {
            SqlConnection myconn = new SqlConnection(myLocalDBSetting.ConnectionString);

            DataSet dataSet = new DataSet();
            DataTable myHeaderTable = new DataTable();
            DataTable myApprovalTable = new DataTable();

            string sSQLHeader = "SELECT * FROM dbo.FreeTextMemo WHERE DocKey=@DocKey";
            string sSQLApproval = @"SELECT * FROM dbo.FreeTextMemoApprovalList WHERE DocKey = @DocKey ORDER BY Seq";

            using (SqlCommand cmdheader = new SqlCommand(sSQLHeader, myconn))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(cmdheader);
                cmdheader.Parameters.Add("@DocKey", SqlDbType.BigInt);
                cmdheader.Parameters["@DocKey"].Value = headerid;
                adapter.Fill(myHeaderTable);
            }

            using (SqlCommand cmdapproval = new SqlCommand(sSQLApproval, myconn))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(cmdapproval);
                cmdapproval.Parameters.Add("@DocKey", SqlDbType.BigInt);
                cmdapproval.Parameters["@DocKey"].Value = headerid;
                adapter.Fill(myApprovalTable);
            }
            
            myHeaderTable.TableName = "Header";
            myApprovalTable.TableName = "Approval";

            DataColumn[] keyHeader = new DataColumn[1];
            keyHeader[0] = myHeaderTable.Columns["DocKey"];
            myHeaderTable.PrimaryKey = keyHeader;

            DataColumn[] keyApproval = new DataColumn[1];
            keyApproval[0] = myApprovalTable.Columns["DtlAppKey"];
            myApprovalTable.PrimaryKey = keyApproval;

            dataSet.Tables.Add(myHeaderTable);
            dataSet.Tables.Add(myApprovalTable);
            return dataSet;
        }

        public override DataTable LoadApprovalList(string strUserID)
        {
            myApprovalListTable.Clear();

            if (strUserID == "2009023")
            { sQuery = "SELECT * FROM [dbo].[WorkList] WHERE DocType = 7"; }
            else
            { sQuery = "SELECT * FROM [dbo].[WorkList] WHERE DocType = 7 AND UserKey=?"; }

            myLocalDBSetting.LoadDataTable(myApprovalListTable, sQuery, true, strUserID);
            DataColumn[] keyHeader = new DataColumn[1];
            keyHeader[0] = myApprovalListTable.Columns["DocKey"];
            myApprovalListTable.PrimaryKey = keyHeader;
            return myApprovalListTable;
        }

        public override void Delete(long headerid)
        {
            SqlLocalDBSetting localdbSetting = this.myLocalDBSetting.StartTransaction();
            try
            {
                localdbSetting.ExecuteNonQuery("DELETE FROM dbo.LateChargesWaive WHERE DocKey=?", (object)headerid);
                localdbSetting.Commit();

            }
            catch (SqlException ex)
            {
                localdbSetting.Rollback();
                throw new ArgumentException(ex.Message);
            }
            catch (HttpUnhandledException ex)
            {
                localdbSetting.Rollback();
                throw new ArgumentException(ex.Message);
            }
            catch (Exception ex)
            {
                localdbSetting.Rollback();
                throw new ArgumentException(ex.Message);
            }
            finally
            {
                localdbSetting.EndTransaction();
            }
        }

        protected override void SaveData(FreeTextMemoEntity FreeTextMemo, DataSet ds, string strDocName, string strUserID, DXISaveAction saveaction, string strApprovalNote)
        {
            SqlLocalDBSetting localdbSetting = this.myLocalDBSetting.StartTransaction();
            SqlConnection con = new SqlConnection(localdbSetting.ConnectionString);
            DateTime Mydate = myDBSetting.GetServerTime();
            DataRow dataRow = ds.Tables["Header"].Rows[0];
            try
            {
                localdbSetting.StartTransaction();
                if (saveaction == DXISaveAction.Cancel)
                {
                    dataRow["Cancelled"] = "T";
                }
                if (saveaction == DXISaveAction.UnCancel)
                {
                    dataRow["Cancelled"] = "F";
                }
                if (saveaction == DXISaveAction.Save && dataRow["DocNo"].ToString().ToUpper().Contains("NEW"))
                {
                    bIsNew = true;
                    dataRow["DocDate"] = Mydate;
                    dataRow["Status"] = "NEED APPROVAL";
                    obj = localdbSetting.ExecuteScalar("SELECT DeptCode FROM dbo.Employee WHERE NIK=?", strUserID);
                    if (obj != null && obj != DBNull.Value)
                    {
                        DataRow[] myrowDocNo = localdbSetting.GetDataTable("select * from DocNoFormat", false, "").Select("DeptCode='" + obj + "'", "", DataViewRowState.CurrentRows);
                        if (myrowDocNo != null)
                        {
                            try
                            {
                                dataRow["DocNo"] = Document.FormatDocumentNo(myrowDocNo[0]["Format"].ToString(), System.Convert.ToInt32(myrowDocNo[0]["NextNo"]), myDBSetting.GetServerTime());
                            }
                            catch (Exception ex)
                            {
                                localdbSetting.Rollback();
                                throw new ArgumentException("Memo tidak bisa di save cabang / CRM Code belum diregistrasi pada master Document Number. Silahkan hubungi sistem Administrator.", ex);
                            }
                            localdbSetting.ExecuteNonQuery("Update DocNoFormat set NextNo=NextNo+1 Where DeptCode=?", obj);
                        }
                    }
                }
                
                if (saveaction == DXISaveAction.Save)
                {
                    if (saveaction == DXISaveAction.Save)
                    {
                        if (bIsNew)
                        {
                            SaveDataApproval(ds, saveaction);
                            SaveWorkingList(ds, FreeTextMemo, saveaction, strUserID);
                        }
                    }
                }

                if (dataRow["NextApprover"] != null)
                {
                    dataRow["NextApprover"] = GetNextApprover(strUserID, FreeTextMemo);
                }
                localdbSetting.SimpleSaveDataTable(ds.Tables["Header"], "SELECT * FROM dbo.FreeTextMemo");

                if (saveaction == DXISaveAction.Approve || saveaction == DXISaveAction.Reject)
                {
                    UpdateApprovalDetail(ds, FreeTextMemo, saveaction, strUserID, strApprovalNote);
                    SaveWorkingList(ds, FreeTextMemo, saveaction, strUserID);
                    DeleteWorkingList(FreeTextMemo, saveaction, strUserID);
                }

                FreeTextMemo.strErrorGenMemo = "null";

                if (FreeTextMemo.strErrorGenMemo == "null")
                {
                    localdbSetting.Commit();
                }
                else
                {
                    localdbSetting.Rollback();
                    throw new ArgumentException(FreeTextMemo.strErrorGenMemo);
                }
            }
            catch (SqlException ex)
            {
                localdbSetting.Rollback();
                throw new ArgumentException(ex.Message);
            }
            catch (HttpUnhandledException ex)
            {
                localdbSetting.Rollback();
                throw new ArgumentException(ex.Message);
            }
            catch (Exception ex)
            {
                localdbSetting.Rollback();
                throw new ArgumentException(ex.Message);
            }
            finally
            {
                localdbSetting.EndTransaction();
            }

            try
            {
                if (saveaction == DXISaveAction.Approve || saveaction == DXISaveAction.Reject)
                {
                    DataRow[] myapprovalrow = ds.Tables["Approval"].Select("Seq=0");
                    DataRow mynextapprovalrow = myLocalDBSetting.GetFirstDataRow("SELECT TOP 1 NIK, Nama, Email FROM [dbo].[FreeTextMemoApprovalList] WHERE IsDecision = 'F' AND NIK <> ? AND DocKey=? ORDER BY Seq", strUserID, FreeTextMemo.DocKey);
                    if (Convert.ToString(myapprovalrow[0]["NIK"]) == strUserID && saveaction == DXISaveAction.Reject)
                    {
                        HasApprove(FreeTextMemo, saveaction);
                        return;
                    }
                    if (mynextapprovalrow == null)
                    {
                        HasApprove(FreeTextMemo, saveaction);
                        return;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new ArgumentException(ex.Message);
            }
        }

        protected override void SaveDataApproval(DataSet ds, DXISaveAction saveaction)
        {
            SqlConnection myconn = new SqlConnection(myLocalDBSetting.ConnectionString);
            myconn.Open();
            SqlTransaction trans = myconn.BeginTransaction();
            try
            {
                foreach (DataRow dataRow in ds.Tables["Approval"].Rows)
                {

                    SqlCommand sqlCommand = new SqlCommand("INSERT INTO [dbo].[FreeTextMemoApprovalList] (DtlAppKey, DocKey, Seq, NIK, Nama, Jabatan, IsDecision, DecisionState, DecisionDate, DecisionNote, Email) VALUES (@DtlAppKey, @DocKey, @Seq, @NIK, @Nama, @Jabatan, @IsDecision, @DecisionState, @DecisionDate, @DecisionNote, @Email)");
                    sqlCommand.Connection = myconn;
                    sqlCommand.Transaction = trans;

                    SqlParameter sqlParameter1 = sqlCommand.Parameters.Add("@DtlAppKey", SqlDbType.Int);
                    sqlParameter1.Value = dataRow.Field<int>("DtlAppKey");
                    sqlParameter1.Direction = ParameterDirection.Input;
                    SqlParameter sqlParameter2 = sqlCommand.Parameters.Add("@DocKey", SqlDbType.Int);
                    sqlParameter2.Value = dataRow.Field<int>("DocKey");
                    sqlParameter2.Direction = ParameterDirection.Input;
                    SqlParameter sqlParameter3 = sqlCommand.Parameters.Add("@Seq", SqlDbType.Int);
                    sqlParameter3.Value = dataRow.Field<int>("Seq");
                    sqlParameter3.Direction = ParameterDirection.Input;
                    SqlParameter sqlParameter4 = sqlCommand.Parameters.Add("@NIK", SqlDbType.NVarChar, 20);
                    sqlParameter4.Value = dataRow.Field<string>("NIK");
                    sqlParameter4.Direction = ParameterDirection.Input;
                    SqlParameter sqlParameter5 = sqlCommand.Parameters.Add("@Nama", SqlDbType.NVarChar, 100);
                    sqlParameter5.Value = dataRow.Field<string>("Nama");
                    sqlParameter5.Direction = ParameterDirection.Input;
                    SqlParameter sqlParameter6 = sqlCommand.Parameters.Add("@Jabatan", SqlDbType.NVarChar, 100);
                    sqlParameter6.Value = dataRow.Field<string>("Jabatan");
                    sqlParameter6.Direction = ParameterDirection.Input;
                    SqlParameter sqlParameter7 = sqlCommand.Parameters.Add("@IsDecision", SqlDbType.NVarChar, 1);
                    sqlParameter7.Value = "F";
                    sqlParameter7.Direction = ParameterDirection.Input;
                    SqlParameter sqlParameter8 = sqlCommand.Parameters.Add("@DecisionState", SqlDbType.NVarChar, 1);
                    sqlParameter8.Value = "";
                    sqlParameter8.Direction = ParameterDirection.Input;
                    SqlParameter sqlParameter9 = sqlCommand.Parameters.Add("@DecisionDate", SqlDbType.DateTime);
                    sqlParameter9.Value = DBNull.Value;
                    sqlParameter9.Direction = ParameterDirection.Input;
                    SqlParameter sqlParameter10 = sqlCommand.Parameters.Add("@DecisionNote", SqlDbType.NVarChar, 250);
                    sqlParameter10.Value = "";
                    sqlParameter10.Direction = ParameterDirection.Input;

                    SqlParameter sqlParameter11 = sqlCommand.Parameters.Add("@Email", SqlDbType.NVarChar, 100);
                    obj = myDBSetting.ExecuteScalar("SELECT Email FROM SYS_TBLEMPLOYEE WHERE CODE=?", dataRow.Field<string>("NIK"));
                    if (obj != null || obj != DBNull.Value)
                    { sqlParameter11.Value = obj; }
                    else
                    { sqlParameter11.Value = "branchsupport.mncleasing@mncgroup.com"; }

                    if (dataRow.Field<string>("NIK") == "1704010")
                    { sqlParameter11.Value += ";khristiana.b@mncgroup.com"; }
                    if (dataRow.Field<string>("NIK") == "1907003")
                    { sqlParameter11.Value += ";khristiana.b@mncgroup.com"; }
                    if (dataRow.Field<string>("NIK") == "U0106546")
                    { sqlParameter11.Value += ";khristiana.b@mncgroup.com"; }
                    if (dataRow.Field<string>("NIK") == "1906024")
                    { sqlParameter11.Value += ";khristiana.b@mncgroup.com"; }

                    sqlParameter11.Direction = ParameterDirection.Input;
                    sqlCommand.ExecuteNonQuery();
                }
                trans.Commit();
            }
            catch (Exception ex)
            {
                trans.Rollback();
                throw new ArgumentException(ex.Message);
            }
            finally
            {
                myconn.Close();
            }
        }

        private void ClearApprovalDetail(FreeTextMemoEntity FreeTextMemo, DXISaveAction saveaction)
        {
            SqlConnection myconn = new SqlConnection(myLocalDBSetting.ConnectionString);
            SqlCommand sqlCommand = new SqlCommand("DELETE [dbo].[FreeTextMemoApprovalList] WHERE DocKey=@DocKey");
            sqlCommand.Connection = myconn;
            try
            {
                myconn.Open();
                SqlParameter sqlParameter1 = sqlCommand.Parameters.Add("@DocKey", SqlDbType.Int);
                sqlParameter1.Value = FreeTextMemo.DocKey;
                sqlCommand.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                throw new ArgumentException(ex.Message);
            }
            catch (HttpUnhandledException ex)
            {
                throw new ArgumentException(ex.Message);
            }
            catch (Exception ex)
            {
                throw new ArgumentException(ex.Message);
            }
            finally
            {
                myconn.Close();
                myconn.Dispose();
            }
        }

        private void SaveWorkingList(DataSet ds, FreeTextMemoEntity FreeTextMemo, DXISaveAction saveaction, string strUserID)
        {
            SqlConnection myconn = new SqlConnection(myLocalDBSetting.ConnectionString);
            myconn.Open();

            SqlTransaction trans = myconn.BeginTransaction();
            DataRow[] myapprovalrow = ds.Tables["Approval"].Select("Seq=0");
            DataRow mynextapprovalrow = myLocalDBSetting.GetFirstDataRow("SELECT TOP 1 NIK, Nama, Email FROM [dbo].[FreeTextMemoApprovalList] WHERE IsDecision = 'F' AND NIK <> ? AND DocKey=? ORDER BY Seq", strUserID, FreeTextMemo.DocKey);
            try
            {
                if (saveaction == DXISaveAction.Save)
                {
                    SqlCommand sqlCommand = new SqlCommand("INSERT INTO [dbo].[WorkList] (SourceKey, DocNo, DocType, UserKey, UserName, CreatedMemoBy) VALUES (@SourceKey, @DocNo, @DocType, @UserKey, @UserName, @CreatedMemoBy)");
                    sqlCommand.Connection = myconn;
                    sqlCommand.Transaction = trans;

                    SqlParameter sqlParameter1 = sqlCommand.Parameters.Add("@SourceKey", SqlDbType.Int);
                    sqlParameter1.Value = FreeTextMemo.DocKey;
                    sqlParameter1.Direction = ParameterDirection.Input;
                    SqlParameter sqlParameter2 = sqlCommand.Parameters.Add("@DocNo", SqlDbType.NVarChar, 50);
                    sqlParameter2.Value = FreeTextMemo.DocNo;
                    sqlParameter2.Direction = ParameterDirection.Input;
                    SqlParameter sqlParameter3 = sqlCommand.Parameters.Add("@DocType", SqlDbType.NVarChar, 100);
                    sqlParameter3.Value = "7";
                    sqlParameter3.Direction = ParameterDirection.Input;
                    SqlParameter sqlParameter4 = sqlCommand.Parameters.Add("@UserKey", SqlDbType.NVarChar, 20);
                    sqlParameter4.Value = myapprovalrow[0]["NIK"];
                    sqlParameter4.Direction = ParameterDirection.Input;
                    SqlParameter sqlParameter5 = sqlCommand.Parameters.Add("@UserName", SqlDbType.NVarChar, 100);
                    sqlParameter5.Value = myapprovalrow[0]["Nama"];
                    sqlParameter5.Direction = ParameterDirection.Input;
                    SqlParameter sqlParameter6 = sqlCommand.Parameters.Add("@CreatedMemoBy", SqlDbType.NVarChar, 100);
                    sqlParameter6.Value = GetMemoFromName(FreeTextMemo.CreatedBy.ToString());
                    sqlParameter6.Direction = ParameterDirection.Input;
                    sqlCommand.ExecuteNonQuery();
                }
                if (saveaction == DXISaveAction.Approve || saveaction == DXISaveAction.Reject)
                {
                    if (Convert.ToString(myapprovalrow[0]["NIK"]) == strUserID && saveaction == DXISaveAction.Reject) { return; }
                    if (mynextapprovalrow == null) { return; }

                    SqlCommand sqlCommand = new SqlCommand("INSERT INTO [dbo].[WorkList] (SourceKey, DocNo, DocType, UserKey, UserName, CreatedMemoBy) VALUES (@SourceKey, @DocNo, @DocType, @UserKey, @UserName, @CreatedMemoBy)");
                    sqlCommand.Connection = myconn;
                    sqlCommand.Transaction = trans;

                    SqlParameter sqlParameter1 = sqlCommand.Parameters.Add("@SourceKey", SqlDbType.Int);
                    sqlParameter1.Value = FreeTextMemo.DocKey;
                    sqlParameter1.Direction = ParameterDirection.Input;
                    SqlParameter sqlParameter2 = sqlCommand.Parameters.Add("@DocNo", SqlDbType.NVarChar, 50);
                    sqlParameter2.Value = FreeTextMemo.DocNo;
                    sqlParameter2.Direction = ParameterDirection.Input;
                    SqlParameter sqlParameter3 = sqlCommand.Parameters.Add("@DocType", SqlDbType.NVarChar, 100);
                    sqlParameter3.Value = "7";
                    sqlParameter3.Direction = ParameterDirection.Input;
                    SqlParameter sqlParameter4 = sqlCommand.Parameters.Add("@UserKey", SqlDbType.NVarChar, 20);
                    sqlParameter4.Value = mynextapprovalrow["NIK"];
                    sqlParameter4.Direction = ParameterDirection.Input;
                    SqlParameter sqlParameter5 = sqlCommand.Parameters.Add("@UserName", SqlDbType.NVarChar, 100);
                    sqlParameter5.Value = mynextapprovalrow["Nama"];
                    sqlParameter5.Direction = ParameterDirection.Input;
                    SqlParameter sqlParameter6 = sqlCommand.Parameters.Add("@CreatedMemoBy", SqlDbType.NVarChar, 100);
                    sqlParameter6.Value = GetMemoFromName(FreeTextMemo.CreatedBy.ToString());
                    sqlParameter6.Direction = ParameterDirection.Input;
                    sqlCommand.ExecuteNonQuery();
                }
                trans.Commit();
            }
            catch (Exception ex)
            {
                trans.Rollback();
                throw new ArgumentException(ex.Message);
            }
            finally
            {
                myconn.Close();
            }

            try
            {
                if (saveaction == DXISaveAction.Save)
                {
                    if (Convert.ToString(myapprovalrow[0]["Email"]) != null)
                    {
                        SendMailNotif(FreeTextMemo, Convert.ToString(myapprovalrow[0]["Email"]), Convert.ToString(myapprovalrow[0]["Nama"]));
                    }

                }
                if (saveaction == DXISaveAction.Approve || saveaction == DXISaveAction.Reject)
                {
                    if (Convert.ToString(mynextapprovalrow["Email"]) != null)
                    {
                        SendMailNotif(FreeTextMemo, Convert.ToString(mynextapprovalrow["Email"]), Convert.ToString(mynextapprovalrow["Nama"]));
                    }
                }
            }
            catch (Exception ex)
            {
                throw new ArgumentException(ex.Message);
            }
        }

        private void DeleteWorkingList(FreeTextMemoEntity FreeTextMemo, DXISaveAction saveaction, string strUserID)
        {
            SqlConnection myconn = new SqlConnection(myLocalDBSetting.ConnectionString);
            myconn.Open();
            SqlTransaction trans = myconn.BeginTransaction();
            try
            {
                if (saveaction == DXISaveAction.Approve || saveaction == DXISaveAction.Reject)
                {
                    SqlCommand sqlCommand = new SqlCommand("DELETE WorkList WHERE SourceKey=@SourceKey AND UserKey=@UserKey");
                    sqlCommand.Connection = myconn;
                    sqlCommand.Transaction = trans;

                    SqlParameter sqlParameter1 = sqlCommand.Parameters.Add("@SourceKey", SqlDbType.Int);
                    sqlParameter1.Value = FreeTextMemo.DocKey;
                    sqlParameter1.Direction = ParameterDirection.Input;
                    SqlParameter sqlParameter2 = sqlCommand.Parameters.Add("@UserKey", SqlDbType.NVarChar, 20);
                    sqlParameter2.Value = strUserID;
                    sqlParameter2.Direction = ParameterDirection.Input;
                    sqlCommand.ExecuteNonQuery();
                }
                trans.Commit();
            }
            catch (Exception ex)
            {
                trans.Rollback();
                throw new ArgumentException(ex.Message);
            }
            finally
            {
                myconn.Close();
            }
        }

        private void UpdateApprovalDetail(DataSet ds, FreeTextMemoEntity FreeTextMemo, DXISaveAction saveaction, string strUserID, string strApprovalNote)
        {
            SqlConnection myconn = new SqlConnection(myLocalDBSetting.ConnectionString);
            myconn.Open();
            SqlTransaction trans = myconn.BeginTransaction();
            try
            {
                if (saveaction == DXISaveAction.Approve)
                {
                    SqlCommand sqlCommand = new SqlCommand("UPDATE [dbo].[FreeTextMemoApprovalList] SET IsDecision=@IsDecision, DecisionState=@DecisionState, DecisionDate=@DecisionDate, DecisionNote=@DecisionNote WHERE DocKey=@DocKey AND NIK=@NIK");
                    sqlCommand.Connection = myconn;
                    sqlCommand.Transaction = trans;

                    SqlParameter sqlParameter1 = sqlCommand.Parameters.Add("@DocKey", SqlDbType.Int);
                    sqlParameter1.Value = FreeTextMemo.DocKey;
                    sqlParameter1.Direction = ParameterDirection.Input;
                    SqlParameter sqlParameter2 = sqlCommand.Parameters.Add("@NIK", SqlDbType.NVarChar, 20);
                    sqlParameter2.Value = strUserID;
                    sqlParameter2.Direction = ParameterDirection.Input;
                    SqlParameter sqlParameter3 = sqlCommand.Parameters.Add("@IsDecision", SqlDbType.NVarChar, 1);
                    sqlParameter3.Value = "T";
                    sqlParameter3.Direction = ParameterDirection.Input;
                    SqlParameter sqlParameter4 = sqlCommand.Parameters.Add("@DecisionState", SqlDbType.NVarChar, 25);
                    sqlParameter4.Value = "APPROVE";
                    sqlParameter4.Direction = ParameterDirection.Input;
                    SqlParameter sqlParameter5 = sqlCommand.Parameters.Add("@DecisionDate", SqlDbType.DateTime);
                    sqlParameter5.Value = myLocalDBSetting.GetServerTime();
                    sqlParameter5.Direction = ParameterDirection.Input;
                    SqlParameter sqlParameter6 = sqlCommand.Parameters.Add("@DecisionNote", SqlDbType.NVarChar, 250);
                    sqlParameter6.Value = strApprovalNote;
                    sqlParameter6.Direction = ParameterDirection.Input;
                    sqlCommand.ExecuteNonQuery();
                }
                if (saveaction == DXISaveAction.Reject)
                {
                    SqlCommand sqlCommand = new SqlCommand("UPDATE [dbo].[FreeTextMemoApprovalList] SET IsDecision=@IsDecision, DecisionState=@DecisionState, DecisionDate=@DecisionDate, DecisionNote=@DecisionNote WHERE DocKey=@DocKey AND NIK=@NIK");
                    sqlCommand.Connection = myconn;
                    sqlCommand.Transaction = trans;

                    SqlParameter sqlParameter1 = sqlCommand.Parameters.Add("@DocKey", SqlDbType.Int);
                    sqlParameter1.Value = FreeTextMemo.DocKey;
                    sqlParameter1.Direction = ParameterDirection.Input;
                    SqlParameter sqlParameter2 = sqlCommand.Parameters.Add("@NIK", SqlDbType.NVarChar, 20);
                    sqlParameter2.Value = strUserID;
                    sqlParameter2.Direction = ParameterDirection.Input;
                    SqlParameter sqlParameter3 = sqlCommand.Parameters.Add("@IsDecision", SqlDbType.NVarChar, 1);
                    sqlParameter3.Value = "T";
                    sqlParameter3.Direction = ParameterDirection.Input;
                    SqlParameter sqlParameter4 = sqlCommand.Parameters.Add("@DecisionState", SqlDbType.NVarChar, 25);
                    sqlParameter4.Value = "REJECT";
                    sqlParameter4.Direction = ParameterDirection.Input;
                    SqlParameter sqlParameter5 = sqlCommand.Parameters.Add("@DecisionDate", SqlDbType.DateTime);
                    sqlParameter5.Value = myLocalDBSetting.GetServerTime();
                    sqlParameter5.Direction = ParameterDirection.Input;
                    SqlParameter sqlParameter6 = sqlCommand.Parameters.Add("@DecisionNote", SqlDbType.NVarChar, 250);
                    sqlParameter6.Value = strApprovalNote;
                    sqlParameter6.Direction = ParameterDirection.Input;
                    sqlCommand.ExecuteNonQuery();
                }
                trans.Commit();
            }
            catch (Exception ex)
            {
                trans.Rollback();
                throw new ArgumentException(ex.Message);
            }
            finally
            {
                myconn.Close();
            }
        }

        private void HasApprove(FreeTextMemoEntity FreeTextMemo, DXISaveAction saveaction)
        {
            SqlConnection myconn = new SqlConnection(myLocalDBSetting.ConnectionString);
            myconn.Open();
            SqlTransaction trans = myconn.BeginTransaction();
            try
            {
                if (saveaction == DXISaveAction.Approve)
                {
                    SqlCommand sqlCommand = new SqlCommand("UPDATE [dbo].[FreeTextMemo] SET IsApprove=@IsApprove, Status=@Status, NextApprover=@NextApprover WHERE DocKey=@DocKey");
                    sqlCommand.Connection = myconn;
                    sqlCommand.Transaction = trans;

                    SqlParameter sqlParameter1 = sqlCommand.Parameters.Add("@DocKey", SqlDbType.Int);
                    sqlParameter1.Value = FreeTextMemo.DocKey;
                    sqlParameter1.Direction = ParameterDirection.Input;
                    SqlParameter sqlParameter2 = sqlCommand.Parameters.Add("@IsApprove", SqlDbType.NVarChar, 1);
                    sqlParameter2.Value = "T";
                    sqlParameter2.Direction = ParameterDirection.Input;
                    SqlParameter sqlParameter3 = sqlCommand.Parameters.Add("@Status", SqlDbType.NVarChar, 20);
                    sqlParameter3.Value = "APPROVE";
                    sqlParameter3.Direction = ParameterDirection.Input;
                    SqlParameter sqlParameter4 = sqlCommand.Parameters.Add("@NextApprover", SqlDbType.NVarChar);
                    sqlParameter4.Value = "";
                    sqlParameter4.Direction = ParameterDirection.Input;
                    sqlCommand.ExecuteNonQuery();
                }
                if (saveaction == DXISaveAction.Reject)
                {
                    SqlCommand sqlCommand = new SqlCommand("UPDATE [dbo].[FreeTextMemo] SET IsApprove=@IsApprove, Status=@Status, NextApprover=@NextApprover WHERE DocKey=@DocKey");
                    sqlCommand.Connection = myconn;
                    sqlCommand.Transaction = trans;

                    SqlParameter sqlParameter1 = sqlCommand.Parameters.Add("@DocKey", SqlDbType.Int);
                    sqlParameter1.Value = FreeTextMemo.DocKey;
                    sqlParameter1.Direction = ParameterDirection.Input;
                    SqlParameter sqlParameter2 = sqlCommand.Parameters.Add("@IsApprove", SqlDbType.NVarChar, 1);
                    sqlParameter2.Value = "F";
                    sqlParameter2.Direction = ParameterDirection.Input;
                    SqlParameter sqlParameter3 = sqlCommand.Parameters.Add("@Status", SqlDbType.NVarChar, 20);
                    sqlParameter3.Value = "REJECT";
                    sqlParameter3.Direction = ParameterDirection.Input;
                    SqlParameter sqlParameter4 = sqlCommand.Parameters.Add("@NextApprover", SqlDbType.NVarChar);
                    sqlParameter4.Value = "";
                    sqlParameter4.Direction = ParameterDirection.Input;
                    sqlCommand.ExecuteNonQuery();
                }
                trans.Commit();
            }
            catch (Exception ex)
            {
                trans.Rollback();
                throw new ArgumentException(ex.Message);
            }
            finally
            {
                myconn.Close();
            }
        }

        private bool bIsExist(FreeTextMemoEntity FreeTextMemo, string strUserID)
        {
            bool isexist = false;
            obj = this.myLocalDBSetting.ExecuteScalar("SELECT COUNT(*) FROM [dbo].[WorkList] WHERE SourceKey=? AND Seq=0", FreeTextMemo.DocKey, strUserID);
            if (obj != null && obj != DBNull.Value)
            {
                if (Convert.ToInt32(obj) > 0)
                {
                    isexist = true;
                }
            }
            return isexist;
        }

        private void SendMailNotif(FreeTextMemoEntity FreeTextMemo, string emailTo, string employeename)
        {
            SqlConnection myconn = new SqlConnection(myDBSetting.ConnectionString);
            myconn.Open();
            try
            {
                SqlCommand sqlCommand = new SqlCommand(@"sp_INFORMA_SendMail");
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Connection = myconn;

                SqlParameter sqlParameter1 = sqlCommand.Parameters.Add("@profile_name", SqlDbType.NVarChar);
                sqlParameter1.Value = "SQLMelisa";

                SqlParameter sqlParameter2 = sqlCommand.Parameters.Add("@recipients", SqlDbType.NVarChar);
                sqlParameter2.Value = emailTo;

                SqlParameter sqlParameter3 = sqlCommand.Parameters.Add("@copy_recipients", SqlDbType.NVarChar);
                sqlParameter3.Value = "branchsupport.mncleasing@mncgroup.com";

                SqlParameter sqlParameter4 = sqlCommand.Parameters.Add("@body", SqlDbType.NVarChar);
                sqlParameter4.Value = "Hi " + employeename + ", this Free Text Internal Memo with no : " + FreeTextMemo.DocNo + " need your approval, please login to INFORMA as soon as posible. Thankyou!";

                SqlParameter sqlParameter5 = sqlCommand.Parameters.Add("@subject", SqlDbType.NVarChar);
                sqlParameter5.Value = "Internal Form Management System - Notification";

                sqlCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new ArgumentException(ex.Message);
            }
            finally
            {
                myconn.Close();
            }
        }

        private string GetNextApprover(string strUserID, FreeTextMemoEntity FreeTextMemo)
        {
            strnextapprover = "";
            DataRow mynextapprovalrow = myLocalDBSetting.GetFirstDataRow("SELECT TOP 1 NIK, Nama, Email FROM [dbo].[FreeTextMemoApprovalList] WHERE IsDecision = 'F' AND NIK <> ? AND DocKey=? ORDER BY Seq", strUserID, FreeTextMemo.DocKey);
            if (mynextapprovalrow != null)
            {
                strnextapprover = Convert.ToString(mynextapprovalrow["NIK"]).ToUpper();
                strnextapprover += " - " + Convert.ToString(mynextapprovalrow["Nama"]).ToUpper();
            }
            return strnextapprover;
        }

        private string GetMemoFromName(string userID)
        {
            string res = userID + " - ";
            object obj = myLocalDBSetting.ExecuteScalar("select top 1 USER_NAME from [SSS].[dbo].MASTER_USER where USER_ID=?", userID);
            if (obj != null && obj != DBNull.Value)
            {
                res += obj.ToString();
            }

            return res;
        }
    }
}