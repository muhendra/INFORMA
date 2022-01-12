using DXMNCGUI_INFORMA.Controllers;
using DXMNCGUI_INFORMA.Controllers.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace DXMNCGUI_INFORMA.Transaction.PeminjamanDokumen
{
    public class PeminjamanDokumenSql : PeminjamanDokumenDB
    {
        object obj;
        bool bIsNew = false;
        private string sQuery = "", strnextapprover = "";
        public override DataTable LoadBrowseTable(bool bViewAll, string userID)
        {
            myBrowseTable.Clear();
            myLocalDBSetting.LoadDataTable(myBrowseTable, "SELECT * FROM [dbo].[PeminjamanDokumen] ORDER BY DocDate DESC", false);

            DataColumn[] keyHeader = new DataColumn[1];
            keyHeader[0] = myBrowseTable.Columns["DocKey"];
            myBrowseTable.PrimaryKey = keyHeader;
            return myBrowseTable;
        }

        public override DataTable LoadApprovalList(string strUserID)
        {
            myApprovalListTable.Clear();

            if (strUserID == "2009023")
            { sQuery = "SELECT * FROM [dbo].[WorkList] WHERE DocType = 6"; }
            else
            { sQuery = "SELECT * FROM [dbo].[WorkList] WHERE DocType = 6 AND UserKey=?"; }

            myLocalDBSetting.LoadDataTable(myApprovalListTable, sQuery, true, strUserID);
            DataColumn[] keyHeader = new DataColumn[1];
            keyHeader[0] = myApprovalListTable.Columns["DocKey"];
            myApprovalListTable.PrimaryKey = keyHeader;
            return myApprovalListTable;
        }

        protected override DataSet LoadData(long headerid, string docno)
        {
            SqlConnection myconn = new SqlConnection(myLocalDBSetting.ConnectionString);

            DataSet dataSet = new DataSet();
            DataTable myHeaderTable = new DataTable();
            DataTable myDetailTable= new DataTable();
            DataTable myApprovalTable = new DataTable();

            string sSQLHeader = "SELECT * FROM dbo.PeminjamanDokumen WHERE DocKey=@DocKey";
            string sSQLDetail = "SELECT * FROM dbo.PeminjamanDokumenDetail WHERE DocKey=@DocKey ORDER BY Seq";
            string sSQLApproval = @"SELECT * FROM dbo.PeminjamanDokumenApprovalList WHERE DocKey = @DocKey ORDER BY Seq";

            using (SqlCommand cmdheader = new SqlCommand(sSQLHeader, myconn))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(cmdheader);
                cmdheader.Parameters.Add("@DocKey", SqlDbType.BigInt);
                cmdheader.Parameters["@DocKey"].Value = headerid;
                adapter.Fill(myHeaderTable);
            }

            using (SqlCommand cmddetail = new SqlCommand(sSQLDetail, myconn))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(cmddetail);
                cmddetail.Parameters.Add("@DocKey", SqlDbType.BigInt);
                cmddetail.Parameters["@DocKey"].Value = headerid;
                adapter.Fill(myDetailTable);
            }

            using (SqlCommand cmdapproval = new SqlCommand(sSQLApproval, myconn))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(cmdapproval);
                cmdapproval.Parameters.Add("@DocKey", SqlDbType.BigInt);
                cmdapproval.Parameters["@DocKey"].Value = headerid;
                adapter.Fill(myApprovalTable);
            }

            myHeaderTable.TableName = "Header";
            myDetailTable.TableName = "Detail";
            myApprovalTable.TableName = "Approval";

            DataColumn[] keyHeader = new DataColumn[1];
            keyHeader[0] = myHeaderTable.Columns["DocKey"];
            myHeaderTable.PrimaryKey = keyHeader;

            DataColumn[] keyDetail = new DataColumn[1];
            keyDetail[0] = myDetailTable.Columns["DtlKey"];
            myDetailTable.PrimaryKey = keyDetail;

            DataColumn[] keyApproval = new DataColumn[1];
            keyApproval[0] = myApprovalTable.Columns["DtlAppKey"];
            myApprovalTable.PrimaryKey = keyApproval;

            dataSet.Tables.Add(myHeaderTable);
            dataSet.Tables.Add(myDetailTable);
            dataSet.Tables.Add(myApprovalTable);
            return dataSet;
        }
        public override void Delete(long headerid)
        {
            SqlLocalDBSetting localdbSetting = this.myLocalDBSetting.StartTransaction();
            try
            {

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

        protected override void SaveData(PeminjamanDokumenEntity PeminjamanDokumen, DataSet ds, string strDocName, string strUserID, DXISaveAction saveaction, string strApprovalNote)
        {
            SqlLocalDBSetting localdbSetting = this.myLocalDBSetting.StartTransaction();
            SqlConnection con = new SqlConnection(localdbSetting.ConnectionString);
            DateTime Mydate = myDBSetting.GetServerTime();
            DataRow dataRow = ds.Tables["Header"].Rows[0];
            try
            {
                localdbSetting.StartTransaction();
                if (saveaction == DXISaveAction.Save && dataRow["DocNo"].ToString().ToUpper().Contains("NEW"))
                {
                    bIsNew = true;
                    dataRow["Status"] = "NEED APPROVAL";
                    obj = localdbSetting.ExecuteScalar("SELECT DeptCode FROM dbo.Employee WHERE NIK=?", strUserID);

                    dataRow["DocDate"] = Mydate;
                    DataRow[] myrowDocNo = localdbSetting.GetDataTable("select * from DocNoFormat", false, "").Select("DocType='PJMDOC'", "", DataViewRowState.CurrentRows);
                    if (myrowDocNo != null)
                    {

                        dataRow["DocNo"] = Document.FormatDocumentNo(myrowDocNo[0]["Format"].ToString(), Convert.ToInt32(myrowDocNo[0]["NextNo"]), myDBSetting.GetServerTime());
                        localdbSetting.ExecuteNonQuery("Update DocNoFormat set NextNo=NextNo+1 Where DocType='PJMDOC'");
                    }
                }

                if (saveaction == DXISaveAction.Save)
                {
                    ClearDetail(PeminjamanDokumen, saveaction);
                    SaveDataDetail(ds, saveaction);
                    
                    if (bIsNew)
                    {
                        SaveDataApproval(ds, saveaction);
                        SaveWorkingList(ds, PeminjamanDokumen, saveaction, strUserID);
                    }
                    
                }
                if (dataRow["NextApprover"] != null)
                {
                    dataRow["NextApprover"] = GetNextApprover(strUserID, PeminjamanDokumen);
                }
                localdbSetting.SimpleSaveDataTable(ds.Tables["Header"], "SELECT * FROM dbo.PeminjamanDokumen");

                if (saveaction == DXISaveAction.Approve || saveaction == DXISaveAction.Reject)
                {
                    UpdateApprovalDetail(ds, PeminjamanDokumen, saveaction, strUserID, strApprovalNote);
                    SaveWorkingList(ds, PeminjamanDokumen, saveaction, strUserID);
                    DeleteWorkingList(PeminjamanDokumen, saveaction, strUserID);
                }

                PeminjamanDokumen.strErrorGenMemo = "null";

                if (PeminjamanDokumen.strErrorGenMemo == "null")
                {
                    localdbSetting.Commit();
                }
                else
                {
                    localdbSetting.Rollback();
                    throw new ArgumentException(PeminjamanDokumen.strErrorGenMemo);
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
                    DataRow mynextapprovalrow = myLocalDBSetting.GetFirstDataRow("SELECT TOP 1 NIK, Nama, Email FROM [dbo].[PeminjamanDokumenApprovalList] WHERE IsDecision = 'F' AND NIK <> ? AND DocKey=? ORDER BY Seq", strUserID, PeminjamanDokumen.DocKey);
                    if (Convert.ToString(myapprovalrow[0]["NIK"]) == strUserID && saveaction == DXISaveAction.Reject)
                    {
                        HasApprove(PeminjamanDokumen, saveaction);
                        return;
                    }
                    if (mynextapprovalrow == null)
                    {
                        HasApprove(PeminjamanDokumen, saveaction);
                        return;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new ArgumentException(ex.Message);
            }
        }

        protected void SaveDataApproval(DataSet ds, DXISaveAction saveaction)
        {
            SqlConnection myconn = new SqlConnection(myLocalDBSetting.ConnectionString);
            myconn.Open();
            SqlTransaction trans = myconn.BeginTransaction();
            try
            {
                foreach (DataRow dataRow in ds.Tables["Approval"].Rows)
                {

                    SqlCommand sqlCommand = new SqlCommand("INSERT INTO [dbo].[PeminjamanDokumenApprovalList] (DtlAppKey, DocKey, Seq, NIK, Nama, Jabatan, IsDecision, DecisionState, DecisionDate, DecisionNote, Email) VALUES (@DtlAppKey, @DocKey, @Seq, @NIK, @Nama, @Jabatan, @IsDecision, @DecisionState, @DecisionDate, @DecisionNote, @Email)");
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

        protected override void SaveDataDetail(DataSet ds, DXISaveAction saveaction)
        {
            SqlConnection myconn = new SqlConnection(myLocalDBSetting.ConnectionString);
            myconn.Open();
            SqlTransaction trans = myconn.BeginTransaction();
            try
            {
                foreach (DataRow dataRow in ds.Tables["Detail"].Rows)
                {
                    SqlCommand sqlCommand = new SqlCommand("INSERT INTO [dbo].[PeminjamanDokumenDetail] (DtlKey, DocKey, Seq, DocID, Description, Status) VALUES (@DtlKey, @DocKey, @Seq, @DocID, @Description, @Status)");
                    sqlCommand.Connection = myconn;
                    sqlCommand.Transaction = trans;

                    SqlParameter sqlParameter0 = sqlCommand.Parameters.Add("@DtlKey", SqlDbType.Int);
                    sqlParameter0.Value = dataRow.Field<int>("DtlKey");
                    sqlParameter0.Direction = ParameterDirection.Input;
                    SqlParameter sqlParameter1 = sqlCommand.Parameters.Add("@DocKey", SqlDbType.Int);
                    sqlParameter1.Value = dataRow.Field<int>("DocKey");
                    sqlParameter1.Direction = ParameterDirection.Input;
                    SqlParameter sqlParameter2 = sqlCommand.Parameters.Add("@Seq", SqlDbType.Int);
                    sqlParameter2.Value = dataRow.Field<int>("Seq");
                    sqlParameter2.Direction = ParameterDirection.Input;
                    SqlParameter sqlParameter3 = sqlCommand.Parameters.Add("@DocID", SqlDbType.NVarChar, 20);
                    sqlParameter3.Value = dataRow.Field<string>("DocID");
                    sqlParameter3.Direction = ParameterDirection.Input;
                    SqlParameter sqlParameter4 = sqlCommand.Parameters.Add("@Description", SqlDbType.NVarChar, 50);
                    sqlParameter4.Value = dataRow.Field<string>("Description");
                    sqlParameter4.Direction = ParameterDirection.Input;
                    SqlParameter sqlParameter5 = sqlCommand.Parameters.Add("@Status", SqlDbType.NVarChar, 50);
                    sqlParameter5.Value = dataRow.Field<string>("Status");
                    sqlParameter5.Direction = ParameterDirection.Input;
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
        private void ClearDetail(PeminjamanDokumenEntity PeminjamanDokumen, DXISaveAction saveaction)
        {
            SqlConnection myconn = new SqlConnection(myLocalDBSetting.ConnectionString);
            SqlCommand sqlCommand = new SqlCommand("DELETE [dbo].[PeminjamanDokumenDetail] WHERE DocKey=@DocKey");
            sqlCommand.Connection = myconn;
            try
            {
                myconn.Open();
                SqlParameter sqlParameter1 = sqlCommand.Parameters.Add("@DocKey", SqlDbType.Int);
                sqlParameter1.Value = PeminjamanDokumen.DocKey;
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

        private void SaveWorkingList(DataSet ds, PeminjamanDokumenEntity PeminjamanDokumen, DXISaveAction saveaction, string strUserID)
        {
            SqlConnection myconn = new SqlConnection(myLocalDBSetting.ConnectionString);
            myconn.Open();

            SqlTransaction trans = myconn.BeginTransaction();
            DataRow[] myapprovalrow = ds.Tables["Approval"].Select("Seq=0");
            DataRow mynextapprovalrow = myLocalDBSetting.GetFirstDataRow("SELECT TOP 1 NIK, Nama, Email FROM [dbo].[PeminjamanDokumenApprovalList] WHERE IsDecision = 'F' AND NIK <> ? AND DocKey=? ORDER BY Seq", strUserID, PeminjamanDokumen.DocKey);
            try
            {
                if (saveaction == DXISaveAction.Save)
                {
                    SqlCommand sqlCommand = new SqlCommand("INSERT INTO [dbo].[WorkList] (SourceKey, DocNo, DocType, UserKey, UserName, CreatedMemoBy) VALUES (@SourceKey, @DocNo, @DocType, @UserKey, @UserName, @CreatedMemoBy)");
                    sqlCommand.Connection = myconn;
                    sqlCommand.Transaction = trans;

                    SqlParameter sqlParameter1 = sqlCommand.Parameters.Add("@SourceKey", SqlDbType.Int);
                    sqlParameter1.Value = PeminjamanDokumen.DocKey;
                    sqlParameter1.Direction = ParameterDirection.Input;
                    SqlParameter sqlParameter2 = sqlCommand.Parameters.Add("@DocNo", SqlDbType.NVarChar, 50);
                    sqlParameter2.Value = PeminjamanDokumen.DocNo;
                    sqlParameter2.Direction = ParameterDirection.Input;
                    SqlParameter sqlParameter3 = sqlCommand.Parameters.Add("@DocType", SqlDbType.NVarChar, 100);
                    sqlParameter3.Value = "6";
                    sqlParameter3.Direction = ParameterDirection.Input;
                    SqlParameter sqlParameter4 = sqlCommand.Parameters.Add("@UserKey", SqlDbType.NVarChar, 20);
                    sqlParameter4.Value = myapprovalrow[0]["NIK"];
                    sqlParameter4.Direction = ParameterDirection.Input;
                    SqlParameter sqlParameter5 = sqlCommand.Parameters.Add("@UserName", SqlDbType.NVarChar, 100);
                    sqlParameter5.Value = myapprovalrow[0]["Nama"];
                    sqlParameter5.Direction = ParameterDirection.Input;
                    SqlParameter sqlParameter6 = sqlCommand.Parameters.Add("@CreatedMemoBy", SqlDbType.NVarChar, 100);
                    sqlParameter6.Value = getPeminjamanCreatedName(PeminjamanDokumen.CreatedBy.ToString());
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
                    sqlParameter1.Value = PeminjamanDokumen.DocKey;
                    sqlParameter1.Direction = ParameterDirection.Input;
                    SqlParameter sqlParameter2 = sqlCommand.Parameters.Add("@DocNo", SqlDbType.NVarChar, 50);
                    sqlParameter2.Value = PeminjamanDokumen.DocNo;
                    sqlParameter2.Direction = ParameterDirection.Input;
                    SqlParameter sqlParameter3 = sqlCommand.Parameters.Add("@DocType", SqlDbType.NVarChar, 100);
                    sqlParameter3.Value = "6";
                    sqlParameter3.Direction = ParameterDirection.Input;
                    SqlParameter sqlParameter4 = sqlCommand.Parameters.Add("@UserKey", SqlDbType.NVarChar, 20);
                    sqlParameter4.Value = mynextapprovalrow["NIK"];
                    sqlParameter4.Direction = ParameterDirection.Input;
                    SqlParameter sqlParameter5 = sqlCommand.Parameters.Add("@UserName", SqlDbType.NVarChar, 100);
                    sqlParameter5.Value = mynextapprovalrow["Nama"];
                    sqlParameter5.Direction = ParameterDirection.Input;
                    SqlParameter sqlParameter6 = sqlCommand.Parameters.Add("@CreatedMemoBy", SqlDbType.NVarChar, 100);
                    sqlParameter6.Value = getPeminjamanCreatedName(PeminjamanDokumen.CreatedBy.ToString());
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
                        SendMailNotif(PeminjamanDokumen, Convert.ToString(myapprovalrow[0]["Email"]), Convert.ToString(myapprovalrow[0]["Nama"]));
                    }

                }
                if (saveaction == DXISaveAction.Approve || saveaction == DXISaveAction.Reject)
                {
                    if (Convert.ToString(mynextapprovalrow["Email"]) != null)
                    {
                        SendMailNotif(PeminjamanDokumen, Convert.ToString(mynextapprovalrow["Email"]), Convert.ToString(mynextapprovalrow["Nama"]));
                    }
                }
            }
            catch (Exception ex)
            {
                throw new ArgumentException(ex.Message);
            }
        }

        private string getPeminjamanCreatedName(string userID)
        {
            string res = userID + " - ";
            object obj = myLocalDBSetting.ExecuteScalar("select top 1 USER_NAME from [SSS].[dbo].MASTER_USER where USER_ID=?", userID);
            if (obj != null && obj != DBNull.Value)
            {
                res += obj.ToString();
            }
            return res;
        }

        private void DeleteWorkingList(PeminjamanDokumenEntity PeminjamanDokumen, DXISaveAction saveaction, string strUserID)
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
                    sqlParameter1.Value = PeminjamanDokumen.DocKey;
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

        private void UpdateApprovalDetail(DataSet ds, PeminjamanDokumenEntity PeminjamanDokumen, DXISaveAction saveaction, string strUserID, string strApprovalNote)
        {
            SqlConnection myconn = new SqlConnection(myLocalDBSetting.ConnectionString);
            myconn.Open();
            SqlTransaction trans = myconn.BeginTransaction();
            try
            {
                if (saveaction == DXISaveAction.Approve)
                {
                    SqlCommand sqlCommand = new SqlCommand("UPDATE [dbo].[PeminjamanDokumenApprovalList] SET IsDecision=@IsDecision, DecisionState=@DecisionState, DecisionDate=@DecisionDate, DecisionNote=@DecisionNote WHERE DocKey=@DocKey AND NIK=@NIK");
                    sqlCommand.Connection = myconn;
                    sqlCommand.Transaction = trans;

                    SqlParameter sqlParameter1 = sqlCommand.Parameters.Add("@DocKey", SqlDbType.Int);
                    sqlParameter1.Value = PeminjamanDokumen.DocKey;
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
                    SqlCommand sqlCommand = new SqlCommand("UPDATE [dbo].[PeminjamanDokumenApprovalList] SET IsDecision=@IsDecision, DecisionState=@DecisionState, DecisionDate=@DecisionDate, DecisionNote=@DecisionNote WHERE DocKey=@DocKey AND NIK=@NIK");
                    sqlCommand.Connection = myconn;
                    sqlCommand.Transaction = trans;

                    SqlParameter sqlParameter1 = sqlCommand.Parameters.Add("@DocKey", SqlDbType.Int);
                    sqlParameter1.Value = PeminjamanDokumen.DocKey;
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

        private void HasApprove(PeminjamanDokumenEntity PeminjamanDokumen, DXISaveAction saveaction)
        {
            SqlConnection myconn = new SqlConnection(myLocalDBSetting.ConnectionString);
            myconn.Open();
            SqlTransaction trans = myconn.BeginTransaction();
            try
            {
                if (saveaction == DXISaveAction.Approve)
                {
                    //SqlCommand sqlCommand = new SqlCommand("UPDATE [dbo].[PeminjamanDokumen] SET IsApprove=@IsApprove, Status=@Status, NextApprover=@NextApprover WHERE DocKey=@DocKey");
                    SqlCommand sqlCommand = new SqlCommand("UPDATE [dbo].[PeminjamanDokumen] SET IsApprove=@IsApprove, Status=@Status, NextApprover=@NextApprover, CustodianApprover=@CustodianApproval WHERE DocKey=@DocKey");
                    sqlCommand.Connection = myconn;
                    sqlCommand.Transaction = trans;

                    SqlParameter sqlParameter1 = sqlCommand.Parameters.Add("@DocKey", SqlDbType.Int);
                    sqlParameter1.Value = PeminjamanDokumen.DocKey;
                    sqlParameter1.Direction = ParameterDirection.Input;
                    SqlParameter sqlParameter2 = sqlCommand.Parameters.Add("@IsApprove", SqlDbType.NVarChar, 1);
                    sqlParameter2.Value = "T";
                    sqlParameter2.Direction = ParameterDirection.Input;
                    SqlParameter sqlParameter3 = sqlCommand.Parameters.Add("@Status", SqlDbType.NVarChar, 20);
                    //sqlParameter3.Value = "APPROVE";
                    sqlParameter3.Value = "WAITING CUSTODIAN";
                    sqlParameter3.Direction = ParameterDirection.Input;
                    SqlParameter sqlParameter4 = sqlCommand.Parameters.Add("@CustodianApproval", SqlDbType.NVarChar);
                    sqlParameter4.Value = GetCustodianApproval(PeminjamanDokumen.DocCategory.ToString());
                    sqlParameter4.Direction = ParameterDirection.Input;
                    SqlParameter sqlParameter5 = sqlCommand.Parameters.Add("@NextApprover", SqlDbType.NVarChar);
                    sqlParameter5.Value = "";
                    sqlParameter5.Direction = ParameterDirection.Input;
                    sqlCommand.ExecuteNonQuery();

                    //string CustodianApproverEmail = "";
                    //obj = myDBSetting.ExecuteScalar("SELECT Email FROM SYS_TBLEMPLOYEE WHERE CODE=?", GetCustodianApproval(PeminjamanDokumen.DocCategory.ToString()));
                    //if (obj != null || obj != DBNull.Value)
                    //{ CustodianApproverEmail = obj.ToString(); }
                    //else
                    //{ CustodianApproverEmail = "branchsupport.mncleasing@mncgroup.com"; }
                    //SendMailNotif(PeminjamanDokumen, CustodianApproverEmail, "Custodian Approver");

                }
                if (saveaction == DXISaveAction.Reject)
                {
                    SqlCommand sqlCommand = new SqlCommand("UPDATE [dbo].[PeminjamanDokumen] SET IsApprove=@IsApprove, Status=@Status, NextApprover=@NextApprover WHERE DocKey=@DocKey");
                    sqlCommand.Connection = myconn;
                    sqlCommand.Transaction = trans;

                    SqlParameter sqlParameter1 = sqlCommand.Parameters.Add("@DocKey", SqlDbType.Int);
                    sqlParameter1.Value = PeminjamanDokumen.DocKey;
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

        private void SendMailNotif(PeminjamanDokumenEntity PeminjamanDokumen, string emailTo, string employeename)
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
                sqlParameter4.Value = "Hi " + employeename + ", this Peminjaman Dokumen with no : " + PeminjamanDokumen.DocNo + " need your approval, please login to INFORMA as soon as posible. Thankyou!";

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

        private string GetNextApprover(string strUserID, PeminjamanDokumenEntity PeminjamanDok)
        {
            strnextapprover = "";
            DataRow mynextapprovalrow = myLocalDBSetting.GetFirstDataRow("SELECT TOP 1 NIK, Nama, Email FROM [dbo].[PeminjamanDokumenApprovalList] WHERE IsDecision = 'F' AND NIK <> ? AND DocKey=? ORDER BY Seq", strUserID, PeminjamanDok.DocKey);
            if (mynextapprovalrow != null)
            {
                strnextapprover = Convert.ToString(mynextapprovalrow["NIK"]).ToUpper();
                strnextapprover += " - " + Convert.ToString(mynextapprovalrow["Nama"]).ToUpper();
            }
            return strnextapprover;
        }

        private string GetCustodianApproval(string value)
        {
            string custodianApproval = "";
            DataRow mycustodianapprovalrow = myLocalDBSetting.GetFirstDataRow("select TOP 1 UserApproval from [dbo].[PeminjamanDokumenCategory] where Category = ?", value);
            if (mycustodianapprovalrow != null)
            {
                custodianApproval = Convert.ToString(mycustodianapprovalrow["UserApproval"]).ToUpper();
            }
            return custodianApproval;
        }
    }
}