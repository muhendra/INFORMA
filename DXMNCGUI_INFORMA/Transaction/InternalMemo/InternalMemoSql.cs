using DXMNCGUI_INFORMA.Controllers;
using DXMNCGUI_INFORMA.Controllers.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Mail;
using System.Web;

namespace DXMNCGUI_INFORMA.Transaction.InternalMemo
{
    public class InternalMemoSql : InternalMemoDB
    {
        object obj;
        bool bIsNew = false;
        private string sQuery = "", strnextapprover = "";
        public override DataTable LoadBrowseTable(bool bViewAll, string userID)
        {
            myBrowseTable.Clear();
            myLocalDBSetting.LoadDataTable(myBrowseTable, "SELECT * FROM [dbo].[InternalMemo] ORDER BY DocDate DESC", true);

            DataColumn[] keyHeader = new DataColumn[1];
            keyHeader[0] = myBrowseTable.Columns["DocKey"];
            myBrowseTable.PrimaryKey = keyHeader;
            return myBrowseTable;
        }
        public override DataTable LoadDataKontrak()
        {
            myNoKontrakTable.Clear();

            sQuery = "select b.C_NAME[CABANG], a.LSAGREE[NO KONTRAK], a.NAME[DEBITUR], a.LESSEE[CIF], e.ADDRESS1 + ' ' + e.ADDRESS2 + ' ' + e.ADDRESS3 as [DEBITURADDRESS], a.RENTAL[INSTALLMENT],\n";
            sQuery += "case a.MODULE when 1 then 'Leasing' when 2 then 'Consumer Finance' when 3 then 'IMBT' when 4 then 'Murabahah' when 5 then 'Factoring' when 6 then 'OPL' when 7 then 'Hawalah' end[JENIS PEMBIAYAAN], \n";
            sQuery += "c.DESCRIPTION[PRODUCT FACILITY], LSPERIOD[TENOR], a.AMTLEASE[NTF], a.OUTSTANDING_AR[OUTSTANDING AR], a.OVERDUE, d.valuedate[LAST PAYMENT], a.OS_PERIOD[SISA TENOR], \n";
            sQuery += "case a.OS_PERIOD when 0 then NULL else a.LAST_DUEDATE end[NEXT DUEDATE] from LS_AGREEMENT a \n";
            sQuery += "inner join SYS_COMPANY b on b.C_CODE = a.C_CODE \n";
            sQuery += "inner join SYS_CLIENT e on a.LESSEE = e.CLIENT \n";
            sQuery += "left join PRODUCT_FACILITY c on c.MODULE = a.MODULE and c.CODE = a.PRODUCT_FACILITY_CODE \n";
            sQuery += "left join (select LSAGREE, max(VALUEDATE)[valuedate] from LS_LEDGERRENTAL where PAYMENT < 0 group by LSAGREE) d on d.LSAGREE = a.LSAGREE \n";
            sQuery += "where a.CONTRACT_STATUS = 'GOLIVE' \n";

            myDBSetting.LoadDataTable(myNoKontrakTable, sQuery, true);
            DataColumn[] keyHeader = new DataColumn[1];
            keyHeader[0] = myNoKontrakTable.Columns["NoKontrak"];
            myNoKontrakTable.PrimaryKey = keyHeader;
            return myNoKontrakTable;
        }

        public override DataTable LoadDataDebitur()
        {
            myDebiturTable.Clear();

            sQuery = "SELECT CLIENT AS DEBITUR_CODE, [NAME] AS DEBITUR_NAME FROM SYS_CLIENT ORDER BY NAME";

            myDBSetting.LoadDataTable(myDebiturTable, sQuery, true);
            DataColumn[] keyHeader = new DataColumn[1];
            keyHeader[0] = myDebiturTable.Columns["CLIENT"];
            myDebiturTable.PrimaryKey = keyHeader;
            return myDebiturTable;
        }
        public override DataTable LoadDataDetailAsset(string scontract)
        {
            myDetailAssetTable.Clear();

            sQuery = "select LS_ASSETVEHICLEID, 0[DocKey], 0[Seq], Description[AssetDesc], VHCCHASS[NoRangka], SERIALNO[NoMesin], VHCYEAR[Tahun], 'F'[IsApprove], NULL[ApproveDate]  from [dbo].[LS_ASSETVEHICLE] where LSAGREE=?";

            myDBSetting.LoadDataTable(myDetailAssetTable, sQuery, true, scontract);
            DataColumn[] keyHeader = new DataColumn[1];
            keyHeader[0] = myDetailAssetTable.Columns["LS_ASSETVEHICLEID"];
            myDetailAssetTable.PrimaryKey = keyHeader;
            return myDetailAssetTable;
        }
        public override DataTable LoadDataBranch(string userID)
        {
            myBranchTable.Clear();
            if(userID == "")
            {
                sQuery = "select distinct a.USER_ID, b.C_CODE, b.C_NAME from MASTER_USER_COMPANY_GROUP a inner join SYS_COMPANY b on b.C_CODE=a.C_CODE";
                myDBSetting.LoadDataTable(myBranchTable, sQuery, true);
            }
            else
            {
                sQuery = "select distinct a.USER_ID, b.C_CODE, b.C_NAME from MASTER_USER_COMPANY_GROUP a inner join SYS_COMPANY b on b.C_CODE=a.C_CODE where USER_ID=?";
                myDBSetting.LoadDataTable(myBranchTable, sQuery, true, userID);
            }
            
            return myBranchTable;
        }
        public override DataTable LoadApprovalList(string strUserID)
        {
            myApprovalListTable.Clear();

            if (strUserID == "2009023")
            { sQuery = "SELECT * FROM [dbo].[WorkList] WHERE DocType <> 6"; }
            else
            { sQuery = "SELECT * FROM [dbo].[WorkList] WHERE DocType <> 6 AND UserKey=?"; }

            myLocalDBSetting.LoadDataTable(myApprovalListTable, sQuery, true, strUserID);
            DataColumn[] keyHeader = new DataColumn[1];
            keyHeader[0] = myApprovalListTable.Columns["DocKey"];
            myApprovalListTable.PrimaryKey = keyHeader;
            return myApprovalListTable;
        }
        protected override DataSet LoadData(long headerid, string docno, string debiturname)
        {
            SqlConnection myconn = new SqlConnection(myLocalDBSetting.ConnectionString);

            DataSet dataSet = new DataSet();
            DataTable myHeaderTable = new DataTable();
            DataTable myDetailPemakaianCashCollTable = new DataTable();
            DataTable myDetailPelepasanCrossCollTable = new DataTable();
            DataTable myDetailPendingGiroTable = new DataTable();
            DataTable myDetailPurchaseRequestTable = new DataTable();
            DataTable myDetailBiayaBulananTable = new DataTable();
            DataTable myDetailUploadDoc = new DataTable();
            DataTable myApprovalTable = new DataTable();
            DataTable myApprovalHistoryTable = new DataTable();
            DataTable myDetailFreeTextTable = new DataTable();

            string sSQLHeader = "SELECT * FROM dbo.InternalMemo WHERE DocKey=@DocKey";
            string sSQLDetailPemakaianCashColl = "SELECT * FROM dbo.InternalMemoDetailPemakaianCashColl WHERE DocKey=@DocKey ORDER BY Seq";
            string sSQLDetailPelepasanCrossColl = "SELECT * FROM dbo.InternalMemoDetailPelepasanCrossColl WHERE DocKey=@DocKey ORDER BY Seq";
            string sSQLDetailPendingGiro = "SELECT * FROM dbo.InternalMemoDetailPendingGiro WHERE DocKey=@DocKey ORDER BY Seq";
            string sSQLDetailPurchaseRequest = "SELECT * FROM dbo.InternalMemoDetailPurchaseRequest WHERE DocKey=@DocKey ORDER BY Seq";
            string sSQLDetailBiayaBulanan = "SELECT * FROM dbo.InternalMemoDetailBiayaBulanan WHERE DocKey=@DocKey ORDER BY Seq";
            string sSQLDetailFreeText = "SELECT * FROM [INFORMA].[dbo].[InternalMemoDetailFreeText] WHERE DocKey=@DocKey ORDER BY Seq";
            string sSQLApproval = @"SELECT * FROM dbo.InternalMemoApprovalList WHERE DocKey = @DocKey ORDER BY Seq";
            string sSQLUploadDoc = @"SELECT ROW_NUMBER() OVER (ORDER BY ID) AS No, [ID] ,[Name] ,[Type] ,[Ext] ,[Remarks] ,[FileDoc] ,[AppNo] ,[CreatedBy] ,[CreatedDateTime], [AgreeNo] FROM [SSS].[dbo].[DocumentFile] WHERE MemoNo=@MemoNo";
            string sSQLApprovalHistory = @"select
                                            A.DtlAppKey, 
                                            B.DocNo,
                                            B.DocDate,
                                            B.Status,
                                            A.Nama,
                                            A.DecisionDate,
                                            A.DecisionState,
                                            A.DecisionNote 
                                            from InternalMemoApprovalList A
                                            inner join InternalMemo B on A.DocKey = B.DocKey
                                            where A.DocKey in (select DocKey from InternalMemoDetailPendingGiro where NamaDebitur=@NamaDebitur) AND B.DocValue=3 ORDER BY B.DocDate DESC";

            using (SqlCommand cmdheader = new SqlCommand(sSQLHeader, myconn))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(cmdheader);
                cmdheader.Parameters.Add("@DocKey", SqlDbType.BigInt);
                cmdheader.Parameters["@DocKey"].Value = headerid;
                adapter.Fill(myHeaderTable);
            }

            using (SqlCommand cmddetailpemakaiancashcoll = new SqlCommand(sSQLDetailPemakaianCashColl, myconn))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(cmddetailpemakaiancashcoll);
                cmddetailpemakaiancashcoll.Parameters.Add("@DocKey", SqlDbType.BigInt);
                cmddetailpemakaiancashcoll.Parameters["@DocKey"].Value = headerid;
                adapter.Fill(myDetailPemakaianCashCollTable);
            }

            using (SqlCommand cmddetailpelepasancrosscoll = new SqlCommand(sSQLDetailPelepasanCrossColl, myconn))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(cmddetailpelepasancrosscoll);
                cmddetailpelepasancrosscoll.Parameters.Add("@DocKey", SqlDbType.BigInt);
                cmddetailpelepasancrosscoll.Parameters["@DocKey"].Value = headerid;
                adapter.Fill(myDetailPelepasanCrossCollTable);
            }

            using (SqlCommand cmddetailpendinggiro = new SqlCommand(sSQLDetailPendingGiro, myconn))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(cmddetailpendinggiro);
                cmddetailpendinggiro.Parameters.Add("@DocKey", SqlDbType.BigInt);
                cmddetailpendinggiro.Parameters["@DocKey"].Value = headerid;
                adapter.Fill(myDetailPendingGiroTable);
            }

            using (SqlCommand cmddetailpurchaserequest = new SqlCommand(sSQLDetailPurchaseRequest, myconn))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(cmddetailpurchaserequest);
                cmddetailpurchaserequest.Parameters.Add("@DocKey", SqlDbType.BigInt);
                cmddetailpurchaserequest.Parameters["@DocKey"].Value = headerid;
                adapter.Fill(myDetailPurchaseRequestTable);
            }

            using (SqlCommand cmddetailbiayabulanan = new SqlCommand(sSQLDetailBiayaBulanan, myconn))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(cmddetailbiayabulanan);
                cmddetailbiayabulanan.Parameters.Add("@DocKey", SqlDbType.BigInt);
                cmddetailbiayabulanan.Parameters["@DocKey"].Value = headerid;
                adapter.Fill(myDetailBiayaBulananTable);
            }

            using (SqlCommand cmddetailfreetext = new SqlCommand(sSQLDetailFreeText, myconn))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(cmddetailfreetext);
                cmddetailfreetext.Parameters.Add("@DocKey", SqlDbType.BigInt);
                cmddetailfreetext.Parameters["@DocKey"].Value = headerid;
                adapter.Fill(myDetailFreeTextTable);
            }

            using (SqlCommand cmdapproval = new SqlCommand(sSQLApproval, myconn))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(cmdapproval);
                cmdapproval.Parameters.Add("@DocKey", SqlDbType.BigInt);
                cmdapproval.Parameters["@DocKey"].Value = headerid;
                adapter.Fill(myApprovalTable);
            }

            using (SqlCommand cmduploaddoc = new SqlCommand(sSQLUploadDoc, myconn))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(cmduploaddoc);
                cmduploaddoc.Parameters.Add("@MemoNo", SqlDbType.NVarChar, 50);
                cmduploaddoc.Parameters["@MemoNo"].Value = docno;
                adapter.Fill(myDetailUploadDoc);
            }

            using (SqlCommand cmdapprovalhistory = new SqlCommand(sSQLApprovalHistory, myconn))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(cmdapprovalhistory);
                cmdapprovalhistory.Parameters.Add("@NamaDebitur", SqlDbType.NVarChar, 150);
                cmdapprovalhistory.Parameters["@NamaDebitur"].Value = debiturname;
                adapter.Fill(myApprovalHistoryTable);
            }

            myHeaderTable.TableName = "Header";
            myDetailPemakaianCashCollTable.TableName = "DetailPemakaianCashColl";
            myDetailPelepasanCrossCollTable.TableName = "DetailPelepasanCrossColl";
            myDetailPendingGiroTable.TableName = "DetailPendingGiro";
            myDetailPurchaseRequestTable.TableName = "DetailPurchaseRequest";
            myDetailBiayaBulananTable.TableName = "DetailBiayaBulanan";
            myDetailFreeTextTable.TableName = "DetailFreeText";
            myApprovalTable.TableName = "Approval";
            myDetailUploadDoc.TableName = "UploadDoc";
            myApprovalHistoryTable.TableName = "ApprovalHistory";

            DataColumn[] keyHeader = new DataColumn[1];
            keyHeader[0] = myHeaderTable.Columns["DocKey"];
            myHeaderTable.PrimaryKey = keyHeader;

            DataColumn[] keyDetailPemakaianCashColl = new DataColumn[1];
            keyDetailPemakaianCashColl[0] = myDetailPemakaianCashCollTable.Columns["DtlKey"];
            myDetailPemakaianCashCollTable.PrimaryKey = keyDetailPemakaianCashColl;

            DataColumn[] keyDetailPelepasanCrossColl = new DataColumn[1];
            keyDetailPelepasanCrossColl[0] = myDetailPelepasanCrossCollTable.Columns["DtlKey"];
            myDetailPelepasanCrossCollTable.PrimaryKey = keyDetailPelepasanCrossColl;

            DataColumn[] keyDetailPendingGiro = new DataColumn[1];
            keyDetailPendingGiro[0] = myDetailPendingGiroTable.Columns["DtlKey"];
            myDetailPendingGiroTable.PrimaryKey = keyDetailPendingGiro;

            DataColumn[] keyDetailPurchaseRequest = new DataColumn[1];
            keyDetailPurchaseRequest[0] = myDetailPurchaseRequestTable.Columns["DtlKey"];
            myDetailPurchaseRequestTable.PrimaryKey = keyDetailPurchaseRequest;

            DataColumn[] keyDetailBiayaBulanan = new DataColumn[1];
            keyDetailBiayaBulanan[0] = myDetailBiayaBulananTable.Columns["DtlKey"];
            myDetailBiayaBulananTable.PrimaryKey = keyDetailBiayaBulanan;

            DataColumn[] keyDetailFreeText = new DataColumn[1];
            keyDetailFreeText[0] = myDetailFreeTextTable.Columns["DtlKey"];
            myDetailFreeTextTable.PrimaryKey = keyDetailFreeText;

            DataColumn[] keyApproval = new DataColumn[1];
            keyApproval[0] = myApprovalTable.Columns["DtlAppKey"];
            myApprovalTable.PrimaryKey = keyApproval;

            DataColumn[] keyUploadDoc = new DataColumn[1];
            keyUploadDoc[0] = myDetailUploadDoc.Columns["ID"];
            myDetailUploadDoc.PrimaryKey = keyUploadDoc;

            DataColumn[] keyApprovalHistory = new DataColumn[1];
            keyApprovalHistory[0] = myApprovalHistoryTable.Columns["DtlAppKey"];
            myApprovalHistoryTable.PrimaryKey = keyApprovalHistory;

            dataSet.Tables.Add(myHeaderTable);
            dataSet.Tables.Add(myDetailPemakaianCashCollTable);
            dataSet.Tables.Add(myDetailPelepasanCrossCollTable);
            dataSet.Tables.Add(myDetailPendingGiroTable);
            dataSet.Tables.Add(myDetailPurchaseRequestTable);
            dataSet.Tables.Add(myDetailBiayaBulananTable);
            dataSet.Tables.Add(myApprovalTable);
            dataSet.Tables.Add(myDetailUploadDoc);
            dataSet.Tables.Add(myApprovalHistoryTable);
            dataSet.Tables.Add(myDetailFreeTextTable);
            return dataSet;
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

        protected override void SaveData(InternalMemoEntity InternalMemo, DataSet ds, string strDocName, string strUserID,  DXISaveAction saveaction, string strApprovalNote)
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

                    //obj = localdbSetting.ExecuteScalar("SELECT DeptCode FROM dbo.Employee WHERE NIK=?", strUserID);

                    ////get dept code by cabang
                    //try
                    //{
                    //    object getRO = myDBSetting.ExecuteScalar("cc", dataRow["MemoBranch"].ToString());
                    //    if (getRO != null && getRO != DBNull.Value)
                    //    {
                    //        obj = getRO;
                    //    }
                    //}
                    //catch (Exception ex)
                    //{
                    //    localdbSetting.Rollback();
                    //    throw new ArgumentException(ex.Message);
                    //}

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
                if (dataRow["DocValue"] != null)
                {

                    switch (dataRow["DocValue"].ToString())
                    {
                        case "1":
                            dataRow["DocType"] = "PEMAKAIAN CASH COLLATERAL";
                            break;
                        case "2":
                            dataRow["DocType"] = "PELEPASAN CROSS COLLATERAL";
                            break;
                        case "3":
                            dataRow["DocType"] = "PENDING GIRO";
                            break;
                        case "4":
                            dataRow["DocType"] = "PERMOHONAN PENGADAAN BARANG & JASA";
                            break;
                        case "5":
                            dataRow["DocType"] = "BIAYA BULANAN";
                            break;
                        case "7":
                            dataRow["DocType"] = "FREE TEXT MEMO";
                            break;
                    }
                }
                if (saveaction == DXISaveAction.Save)
                {

                    //if (InternalMemo.DocKey != null)
                    //{
                    //    ClearApprovalDetail(InternalMemo, saveaction);
                    //}

                    switch (dataRow["DocValue"].ToString())
                    {

                        case "1":
                            SaveDataDetailPemakaianCashColl(ds, saveaction);
                            break;
                        case "2":
                            ClearPelepasanCrossCollDetail(InternalMemo, saveaction);
                            SaveDataDetailPelepasanCrossColl(ds, saveaction);
                            break;
                        case "3":
                            ClearPendingGiroDetail(InternalMemo, saveaction);
                            SaveDataDetailPendingGiro(ds, saveaction);
                            break;
                        case "4":
                            ClearPurchaseRequestDetail(InternalMemo, saveaction);
                            SaveDataDetailPurchaseRequest(ds, saveaction);
                            break;
                        case "5":
                            ClearBiayaBulananDetail(InternalMemo, saveaction);
                            SaveDataDetailBiayaBulanan(ds, saveaction);
                            break;
                        case "7":
                            ClearFreeTextDetail(InternalMemo, saveaction);
                            SaveDataDetailFreeText(ds, saveaction);
                            break;
                    }                   

                    if (saveaction == DXISaveAction.Save)
                    {
                        if (bIsNew)
                        {
                            SaveDataApproval(ds, saveaction);
                            SaveWorkingList(ds, InternalMemo, saveaction, strUserID);
                        }
                    }
                }

                if (dataRow["NextApprover"] != null)
                {
                    dataRow["NextApprover"] = GetNextApprover(strUserID, InternalMemo);
                }
                localdbSetting.SimpleSaveDataTable(ds.Tables["Header"], "SELECT * FROM dbo.InternalMemo");

                if (saveaction == DXISaveAction.Approve || saveaction == DXISaveAction.Reject)
                {
                    UpdateApprovalDetail(ds, InternalMemo, saveaction, strUserID, strApprovalNote);
                    SaveWorkingList(ds, InternalMemo, saveaction, strUserID);
                    DeleteWorkingList(InternalMemo, saveaction, strUserID);
                }

                InternalMemo.strErrorGenMemo = "null";

                if (InternalMemo.strErrorGenMemo == "null")
                {
                    localdbSetting.Commit();
                }
                else
                {
                    localdbSetting.Rollback();
                    throw new ArgumentException(InternalMemo.strErrorGenMemo);
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
                    DataRow mynextapprovalrow = myLocalDBSetting.GetFirstDataRow("SELECT TOP 1 NIK, Nama, Email FROM [dbo].[InternalMemoApprovalList] WHERE IsDecision = 'F' AND NIK <> ? AND DocKey=? ORDER BY Seq", strUserID, InternalMemo.DocKey);
                    if (Convert.ToString(myapprovalrow[0]["NIK"]) == strUserID && saveaction == DXISaveAction.Reject)
                    {
                        HasApprove(InternalMemo, saveaction);
                        return;
                    }
                    if (mynextapprovalrow == null)
                    {
                        HasApprove(InternalMemo, saveaction);
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

                    SqlCommand sqlCommand = new SqlCommand("INSERT INTO [dbo].[InternalMemoApprovalList] (DtlAppKey, DocKey, Seq, NIK, Nama, Jabatan, IsDecision, DecisionState, DecisionDate, DecisionNote, Email) VALUES (@DtlAppKey, @DocKey, @Seq, @NIK, @Nama, @Jabatan, @IsDecision, @DecisionState, @DecisionDate, @DecisionNote, @Email)");
                    sqlCommand.Connection = myconn;
                    sqlCommand.Transaction = trans;

                    SqlParameter sqlParameter1 = sqlCommand.Parameters.Add("@DtlAppKey", SqlDbType.Int);
                    sqlParameter1.Value = dataRow.Field<int>("DtlAppKey");
                    //sqlParameter1.Value = this.DtlAppKeyUniqueKey();
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
                    {sqlParameter11.Value += "; khristiana.b@mncgroup.com";}
                    if (dataRow.Field<string>("NIK") == "1907003")
                    { sqlParameter11.Value += "; khristiana.b@mncgroup.com"; }
                    if (dataRow.Field<string>("NIK") == "U0106546")
                    { sqlParameter11.Value += "; khristiana.b@mncgroup.com"; }
                    if (dataRow.Field<string>("NIK") == "1906024")
                    { sqlParameter11.Value += "; khristiana.b@mncgroup.com"; }

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

        protected override void SaveDataDetailPemakaianCashColl(DataSet ds, DXISaveAction saveaction)
        {
            SqlConnection myconn = new SqlConnection(myLocalDBSetting.ConnectionString);
            myconn.Open();
            SqlTransaction trans = myconn.BeginTransaction();
            try
            {
                foreach (DataRow dataRow in ds.Tables["MyTempDetailPemakaianCashColl"].Rows)
                {

                    SqlCommand sqlCommand = new SqlCommand("INSERT INTO [dbo].[InternalMemoDetailPemakaianCashColl] (DocKey, Seq, AssetDesc, NoRangka, NoMesin, Tahun) VALUES (@DocKey, @Seq, @AssetDesc, @NoRangka, @NoMesin, @Tahun)");
                    sqlCommand.Connection = myconn;
                    sqlCommand.Transaction = trans;

                    SqlParameter sqlParameter1 = sqlCommand.Parameters.Add("@DocKey", SqlDbType.Int);
                    sqlParameter1.Value = dataRow.Field<int>("DocKey");
                    sqlParameter1.Direction = ParameterDirection.Input;
                    SqlParameter sqlParameter2 = sqlCommand.Parameters.Add("@Seq", SqlDbType.Int);
                    sqlParameter2.Value = dataRow.Field<int>("Seq");
                    sqlParameter2.Direction = ParameterDirection.Input;
                    SqlParameter sqlParameter3= sqlCommand.Parameters.Add("@AssetDesc", SqlDbType.NVarChar, 250);
                    sqlParameter3.Value = dataRow.Field<string>("AssetDesc");
                    sqlParameter3.Direction = ParameterDirection.Input;
                    SqlParameter sqlParameter4 = sqlCommand.Parameters.Add("@NoRangka", SqlDbType.NVarChar, 100);
                    sqlParameter4.Value = dataRow.Field<string>("NoRangka");
                    sqlParameter4.Direction = ParameterDirection.Input;
                    SqlParameter sqlParameter5 = sqlCommand.Parameters.Add("@NoMesin", SqlDbType.NVarChar, 100);
                    sqlParameter5.Value = dataRow.Field<string>("NoMesin");
                    sqlParameter5.Direction = ParameterDirection.Input;
                    SqlParameter sqlParameter6 = sqlCommand.Parameters.Add("@Tahun", SqlDbType.NVarChar, 5);
                    sqlParameter6.Value = dataRow.Field<string>("Tahun");
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
        protected override void SaveDataDetailPelepasanCrossColl(DataSet ds, DXISaveAction saveaction)
        {
            SqlConnection myconn = new SqlConnection(myLocalDBSetting.ConnectionString);
            myconn.Open();
            SqlTransaction trans = myconn.BeginTransaction();
            try
            {
                foreach (DataRow dataRow in ds.Tables["DetailPelepasanCrossColl"].Rows)
                {

                    SqlCommand sqlCommand = new SqlCommand("INSERT INTO [dbo].[InternalMemoDetailPelepasanCrossColl] (DtlKey, DocKey, Seq, AgreementNo, AssetDesc, ValueAsset, OSPH, CicilanTenor, DendaBerjalan) VALUES (@DtlKey, @DocKey, @Seq, @AgreementNo, @AssetDesc, @ValueAsset, @OSPH, @CicilanTenor, @DendaBerjalan)");
                    sqlCommand.Connection = myconn;
                    sqlCommand.Transaction = trans;

                    SqlParameter sqlParameter1 = sqlCommand.Parameters.Add("@DtlKey", SqlDbType.Int);
                    sqlParameter1.Value = dataRow.Field<int>("DtlKey");
                    sqlParameter1.Direction = ParameterDirection.Input;
                    SqlParameter sqlParameter2 = sqlCommand.Parameters.Add("@DocKey", SqlDbType.Int);
                    sqlParameter2.Value = dataRow.Field<int>("DocKey");
                    sqlParameter2.Direction = ParameterDirection.Input;
                    SqlParameter sqlParameter3 = sqlCommand.Parameters.Add("@Seq", SqlDbType.Int);
                    sqlParameter3.Value = dataRow.Field<int>("Seq");
                    sqlParameter3.Direction = ParameterDirection.Input;
                    SqlParameter sqlParameter4 = sqlCommand.Parameters.Add("@AgreementNo", SqlDbType.NVarChar, 30);
                    sqlParameter4.Value = dataRow.Field<string>("AgreementNo");
                    sqlParameter4.Direction = ParameterDirection.Input;
                    SqlParameter sqlParameter5 = sqlCommand.Parameters.Add("@AssetDesc", SqlDbType.NVarChar, 250);
                    sqlParameter5.Value = dataRow.Field<string>("AssetDesc");
                    sqlParameter5.Direction = ParameterDirection.Input;
                    SqlParameter sqlParameter6 = sqlCommand.Parameters.Add("@ValueAsset", SqlDbType.Decimal, 2);
                    sqlParameter6.Value = dataRow.Field<decimal>("ValueAsset");
                    sqlParameter6.Direction = ParameterDirection.Input;
                    SqlParameter sqlParameter7 = sqlCommand.Parameters.Add("@OSPH", SqlDbType.Decimal, 2);
                    sqlParameter7.Value = dataRow.Field<decimal>("OSPH");
                    sqlParameter7.Direction = ParameterDirection.Input;
                    SqlParameter sqlParameter8 = sqlCommand.Parameters.Add("@CicilanTenor", SqlDbType.NVarChar, 10);
                    sqlParameter8.Value = dataRow.Field<string>("CicilanTenor");
                    sqlParameter8.Direction = ParameterDirection.Input;

                    SqlParameter sqlParameter9 = sqlCommand.Parameters.Add("@DendaBerjalan", SqlDbType.Decimal, 2);
                    sqlParameter9.Value = dataRow.Field<decimal>("DendaBerjalan");
                    sqlParameter9.Direction = ParameterDirection.Input;
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
        protected override void SaveDataDetailPendingGiro(DataSet ds, DXISaveAction saveaction)
        {
            SqlConnection myconn = new SqlConnection(myLocalDBSetting.ConnectionString);
            myconn.Open();
            SqlTransaction trans = myconn.BeginTransaction();
            try
            {
                foreach (DataRow dataRow in ds.Tables["DetailPendingGiro"].Rows)
                {

                    SqlCommand sqlCommand = new SqlCommand("INSERT INTO [dbo].[InternalMemoDetailPendingGiro] (DtlKey, DocKey, Seq, NamaDebitur, AgreementNo, NamaBank, NoGiro, NominalGiro, AngsuranDariKe, TglJatuhTempo, LamaPenundaan, TglDiJalankanKembali) VALUES (@DtlKey, @DocKey, @Seq, @NamaDebitur, @AgreementNo, @NamaBank, @NoGiro, @NominalGiro, @AngsuranDariKe, @TglJatuhTempo, @LamaPenundaan, @TglDiJalankanKembali)");
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
                    SqlParameter sqlParameter3 = sqlCommand.Parameters.Add("@NamaDebitur", SqlDbType.NVarChar, 250);
                    sqlParameter3.Value = dataRow.Field<string>("NamaDebitur");
                    sqlParameter3.Direction = ParameterDirection.Input;
                    SqlParameter sqlParameter4 = sqlCommand.Parameters.Add("@AgreementNo", SqlDbType.NVarChar, 30);
                    sqlParameter4.Value = dataRow.Field<string>("AgreementNo");
                    sqlParameter4.Direction = ParameterDirection.Input;
                    SqlParameter sqlParameter5 = sqlCommand.Parameters.Add("@NamaBank", SqlDbType.NVarChar, 100);
                    sqlParameter5.Value = dataRow.Field<string>("NamaBank");
                    sqlParameter5.Direction = ParameterDirection.Input;
                    SqlParameter sqlParameter6 = sqlCommand.Parameters.Add("@NoGiro", SqlDbType.NVarChar, 100);
                    sqlParameter6.Value = dataRow.Field<string>("NoGiro");
                    sqlParameter6.Direction = ParameterDirection.Input;
                    SqlParameter sqlParameter7 = sqlCommand.Parameters.Add("@NominalGiro", SqlDbType.Decimal, 2);
                    sqlParameter7.Value = dataRow.Field<decimal>("NominalGiro");
                    sqlParameter7.Direction = ParameterDirection.Input;
                    SqlParameter sqlParameter8 = sqlCommand.Parameters.Add("@AngsuranDariKe", SqlDbType.NVarChar, 20);
                    sqlParameter8.Value = dataRow.Field<string>("AngsuranDariKe");
                    sqlParameter8.Direction = ParameterDirection.Input;
                    SqlParameter sqlParameter9 = sqlCommand.Parameters.Add("@TglJatuhTempo", SqlDbType.DateTime);
                    sqlParameter9.Value = dataRow.Field<DateTime>("TglJatuhTempo");
                    sqlParameter9.Direction = ParameterDirection.Input;
                    SqlParameter sqlParameter10 = sqlCommand.Parameters.Add("@LamaPenundaan", SqlDbType.Decimal, 2);
                    sqlParameter10.Value = dataRow.Field<decimal>("LamaPenundaan");
                    sqlParameter10.Direction = ParameterDirection.Input;
                    SqlParameter sqlParameter11 = sqlCommand.Parameters.Add("@TglDiJalankanKembali", SqlDbType.DateTime);
                    sqlParameter11.Value = dataRow.Field<DateTime>("TglDiJalankanKembali");
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
        protected override void SaveDataDetailPurchaseRequest(DataSet ds, DXISaveAction saveaction)
        {
            SqlConnection myconn = new SqlConnection(myLocalDBSetting.ConnectionString);
            myconn.Open();
            SqlTransaction trans = myconn.BeginTransaction();
            try
            {
                foreach (DataRow dataRow in ds.Tables["DetailPurchaseRequest"].Rows)
                {

                    SqlCommand sqlCommand = new SqlCommand(@"INSERT INTO [dbo].[InternalMemoDetailPurchaseRequest] 
                                                            (DtlKey, DocKey, Seq, NamaBarang, Kategori, Qty, Spesifikasi, Keterangan, IsBudget) 
                                                                VALUES 
                                                                    (@DtlKey, @DocKey, @Seq, @NamaBarang, @Kategori, @Qty, @Spesifikasi, @Keterangan, @IsBudget)");
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
                    SqlParameter sqlParameter3 = sqlCommand.Parameters.Add("@NamaBarang", SqlDbType.NVarChar, 250);
                    sqlParameter3.Value = dataRow.Field<string>("NamaBarang");
                    sqlParameter3.Direction = ParameterDirection.Input;
                    SqlParameter sqlParameter4 = sqlCommand.Parameters.Add("@Kategori", SqlDbType.NVarChar, 25);
                    sqlParameter4.Value = dataRow.Field<string>("Kategori");
                    sqlParameter4.Direction = ParameterDirection.Input;
                    SqlParameter sqlParameter5 = sqlCommand.Parameters.Add("@Qty", SqlDbType.Decimal, 2);
                    sqlParameter5.Value = dataRow.Field<decimal>("Qty");
                    sqlParameter5.Direction = ParameterDirection.Input;
                    SqlParameter sqlParameter6 = sqlCommand.Parameters.Add("@Spesifikasi", SqlDbType.NVarChar);
                    sqlParameter6.Value = dataRow.Field<string>("Spesifikasi");
                    sqlParameter6.Direction = ParameterDirection.Input;
                    SqlParameter sqlParameter7 = sqlCommand.Parameters.Add("@Keterangan", SqlDbType.NVarChar);
                    sqlParameter7.Value = dataRow.Field<string>("Keterangan");
                    sqlParameter7.Direction = ParameterDirection.Input;
                    SqlParameter sqlParameter8 = sqlCommand.Parameters.Add("@IsBudget", SqlDbType.NVarChar, 1);
                    sqlParameter8.Value = dataRow.Field<string>("IsBudget");
                    sqlParameter8.Direction = ParameterDirection.Input;
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
        protected override void SaveDataDetailBiayaBulanan(DataSet ds, DXISaveAction saveaction)
        {
            SqlConnection myconn = new SqlConnection(myLocalDBSetting.ConnectionString);
            myconn.Open();
            SqlTransaction trans = myconn.BeginTransaction();
            try
            {
                foreach (DataRow dataRow in ds.Tables["DetailBiayaBulanan"].Rows)
                {

                    SqlCommand sqlCommand = new SqlCommand(@"INSERT INTO [dbo].[InternalMemoDetailBiayaBulanan] 
                                                            (DtlKey, DocKey, Seq, Keterangan, Periode, Remark1, Remark2, Total) 
                                                                VALUES 
                                                                    (@DtlKey, @DocKey, @Seq, @Keterangan, @Periode, @Remark1, @Remark2, @Total)");
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
                    SqlParameter sqlParameter3 = sqlCommand.Parameters.Add("@Keterangan", SqlDbType.NVarChar, -1);
                    sqlParameter3.Value = dataRow.Field<string>("Keterangan");
                    sqlParameter3.Direction = ParameterDirection.Input;
                    SqlParameter sqlParameter4 = sqlCommand.Parameters.Add("@Periode", SqlDbType.NVarChar, 50);
                    sqlParameter4.Value = dataRow.Field<string>("Periode");
                    sqlParameter4.Direction = ParameterDirection.Input;
                    SqlParameter sqlParameter5 = sqlCommand.Parameters.Add("@Remark1", SqlDbType.NVarChar, -1);
                    sqlParameter5.Value = dataRow.Field<string>("Remark1");
                    sqlParameter5.Direction = ParameterDirection.Input;
                    SqlParameter sqlParameter6 = sqlCommand.Parameters.Add("@Remark2", SqlDbType.NVarChar, -1);
                    sqlParameter6.Value = dataRow.Field<string>("Remark2");
                    sqlParameter6.Direction = ParameterDirection.Input;
                    SqlParameter sqlParameter7 = sqlCommand.Parameters.Add("@Total", SqlDbType.Decimal, 2);
                    sqlParameter7.Value = dataRow.Field<decimal>("Total");
                    sqlParameter7.Direction = ParameterDirection.Input;
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
        protected override void SaveDataDetailFreeText(DataSet ds, DXISaveAction saveaction)
        {
            SqlConnection myconn = new SqlConnection(myLocalDBSetting.ConnectionString);
            myconn.Open();
            SqlTransaction trans = myconn.BeginTransaction();
            try
            {
                foreach (DataRow dataRow in ds.Tables["DetailFreeText"].Rows)
                {

                    SqlCommand sqlCommand = new SqlCommand(@"INSERT INTO [dbo].[InternalMemoDetailFreeText] 
                                                            (DtlKey, DocKey, Seq, FreeTextFile) 
                                                                VALUES 
                                                                    (@DtlKey, @DocKey, @Seq, @FreeTextFile)");
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
                    SqlParameter sqlParameter3 = sqlCommand.Parameters.Add("@FreeTextFile", SqlDbType.VarBinary);
                    sqlParameter3.Value = dataRow["FreeTextFile"];
                    sqlParameter3.Direction = ParameterDirection.Input;
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

        private void ClearApprovalDetail(InternalMemoEntity InternalMemo, DXISaveAction saveaction)
        {
            SqlConnection myconn = new SqlConnection(myLocalDBSetting.ConnectionString);
            SqlCommand sqlCommand = new SqlCommand("DELETE [dbo].[InternalMemoApprovalList] WHERE DocKey=@DocKey");
            sqlCommand.Connection = myconn;
            try
            {
                myconn.Open();
                SqlParameter sqlParameter1 = sqlCommand.Parameters.Add("@DocKey", SqlDbType.Int);
                sqlParameter1.Value = InternalMemo.DocKey;
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
        private void ClearPelepasanCrossCollDetail(InternalMemoEntity InternalMemo, DXISaveAction saveaction)
        {
            SqlConnection myconn = new SqlConnection(myLocalDBSetting.ConnectionString);
            SqlCommand sqlCommand = new SqlCommand("DELETE [dbo].[InternalMemoDetailPelepasanCrossColl] WHERE DocKey=@DocKey");
            sqlCommand.Connection = myconn;
            try
            {
                myconn.Open();
                SqlParameter sqlParameter1 = sqlCommand.Parameters.Add("@DocKey", SqlDbType.Int);
                sqlParameter1.Value = InternalMemo.DocKey;
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
        private void ClearPendingGiroDetail(InternalMemoEntity InternalMemo, DXISaveAction saveaction)
        {
            SqlConnection myconn = new SqlConnection(myLocalDBSetting.ConnectionString);
            SqlCommand sqlCommand = new SqlCommand("DELETE [dbo].[InternalMemoDetailPendingGiro] WHERE DocKey=@DocKey");
            sqlCommand.Connection = myconn;
            try
            {
                myconn.Open();
                SqlParameter sqlParameter1 = sqlCommand.Parameters.Add("@DocKey", SqlDbType.Int);
                sqlParameter1.Value = InternalMemo.DocKey;
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
        private void ClearPurchaseRequestDetail(InternalMemoEntity InternalMemo, DXISaveAction saveaction)
        {
            SqlConnection myconn = new SqlConnection(myLocalDBSetting.ConnectionString);
            SqlCommand sqlCommand = new SqlCommand("DELETE [dbo].[InternalMemoDetailPurchaseRequest] WHERE DocKey=@DocKey");
            sqlCommand.Connection = myconn;
            try
            {
                myconn.Open();
                SqlParameter sqlParameter1 = sqlCommand.Parameters.Add("@DocKey", SqlDbType.Int);
                sqlParameter1.Value = InternalMemo.DocKey;
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
        private void ClearBiayaBulananDetail(InternalMemoEntity InternalMemo, DXISaveAction saveaction)
        {
            SqlConnection myconn = new SqlConnection(myLocalDBSetting.ConnectionString);
            SqlCommand sqlCommand = new SqlCommand("DELETE [dbo].[InternalMemoDetailBiayaBulanan] WHERE DocKey=@DocKey");
            sqlCommand.Connection = myconn;
            try
            {
                myconn.Open();
                SqlParameter sqlParameter1 = sqlCommand.Parameters.Add("@DocKey", SqlDbType.Int);
                sqlParameter1.Value = InternalMemo.DocKey;
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
        private void ClearFreeTextDetail(InternalMemoEntity InternalMemo, DXISaveAction saveaction)
        {
            SqlConnection myconn = new SqlConnection(myLocalDBSetting.ConnectionString);
            SqlCommand sqlCommand = new SqlCommand("DELETE [dbo].[InternalMemoDetailFreeText] WHERE DocKey=@DocKey");
            sqlCommand.Connection = myconn;
            try
            {
                myconn.Open();
                SqlParameter sqlParameter1 = sqlCommand.Parameters.Add("@DocKey", SqlDbType.Int);
                sqlParameter1.Value = InternalMemo.DocKey;
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

        private void SaveWorkingList(DataSet ds, InternalMemoEntity InternalMemo, DXISaveAction saveaction, string strUserID)
        {
            SqlConnection myconn = new SqlConnection(myLocalDBSetting.ConnectionString);
            myconn.Open();

            SqlTransaction trans = myconn.BeginTransaction();
            DataRow[] myapprovalrow = ds.Tables["Approval"].Select("Seq=0");
            DataRow mynextapprovalrow = myLocalDBSetting.GetFirstDataRow("SELECT TOP 1 NIK, Nama, Email FROM [dbo].[InternalMemoApprovalList] WHERE IsDecision = 'F' AND NIK <> ? AND DocKey=? ORDER BY Seq", strUserID, InternalMemo.DocKey);
            try
            {
                if (saveaction == DXISaveAction.Save)
                {
                    SqlCommand sqlCommand = new SqlCommand("INSERT INTO [dbo].[WorkList] (SourceKey, DocNo, DocType, UserKey, UserName, CreatedMemoBy) VALUES (@SourceKey, @DocNo, @DocType, @UserKey, @UserName, @CreatedMemoBy)");
                    sqlCommand.Connection = myconn;
                    sqlCommand.Transaction = trans;

                    SqlParameter sqlParameter1 = sqlCommand.Parameters.Add("@SourceKey", SqlDbType.Int);
                    sqlParameter1.Value = InternalMemo.DocKey;
                    sqlParameter1.Direction = ParameterDirection.Input;
                    SqlParameter sqlParameter2 = sqlCommand.Parameters.Add("@DocNo", SqlDbType.NVarChar, 50);
                    sqlParameter2.Value = InternalMemo.DocNo;
                    sqlParameter2.Direction = ParameterDirection.Input;
                    SqlParameter sqlParameter3 = sqlCommand.Parameters.Add("@DocType", SqlDbType.NVarChar, 100);
                    sqlParameter3.Value = InternalMemo.DocValue;
                    sqlParameter3.Direction = ParameterDirection.Input;
                    SqlParameter sqlParameter4 = sqlCommand.Parameters.Add("@UserKey", SqlDbType.NVarChar, 20);
                    sqlParameter4.Value = myapprovalrow[0]["NIK"];
                    sqlParameter4.Direction = ParameterDirection.Input;
                    SqlParameter sqlParameter5 = sqlCommand.Parameters.Add("@UserName", SqlDbType.NVarChar, 100);
                    sqlParameter5.Value = myapprovalrow[0]["Nama"];
                    sqlParameter5.Direction = ParameterDirection.Input;
                    SqlParameter sqlParameter6 = sqlCommand.Parameters.Add("@CreatedMemoBy", SqlDbType.NVarChar, 100);
                    sqlParameter6.Value = InternalMemo.MemoFrom;
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
                    sqlParameter1.Value = InternalMemo.DocKey;
                    sqlParameter1.Direction = ParameterDirection.Input;
                    SqlParameter sqlParameter2 = sqlCommand.Parameters.Add("@DocNo", SqlDbType.NVarChar, 50);
                    sqlParameter2.Value = InternalMemo.DocNo;
                    sqlParameter2.Direction = ParameterDirection.Input;
                    SqlParameter sqlParameter3 = sqlCommand.Parameters.Add("@DocType", SqlDbType.NVarChar, 100);
                    sqlParameter3.Value = InternalMemo.DocValue;
                    sqlParameter3.Direction = ParameterDirection.Input;
                    SqlParameter sqlParameter4 = sqlCommand.Parameters.Add("@UserKey", SqlDbType.NVarChar, 20);
                    sqlParameter4.Value = mynextapprovalrow["NIK"];
                    sqlParameter4.Direction = ParameterDirection.Input;
                    SqlParameter sqlParameter5 = sqlCommand.Parameters.Add("@UserName", SqlDbType.NVarChar, 100);
                    sqlParameter5.Value = mynextapprovalrow["Nama"];
                    sqlParameter5.Direction = ParameterDirection.Input;
                    SqlParameter sqlParameter6 = sqlCommand.Parameters.Add("@CreatedMemoBy", SqlDbType.NVarChar, 100);
                    sqlParameter6.Value = InternalMemo.MemoFrom;
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
                    object objEmailWorkingList = myDBSetting.ExecuteScalar("SELECT Email FROM SYS_TBLEMPLOYEE WHERE CODE=?", myapprovalrow[0]["NIK"]);
                    if (objEmailWorkingList != null || objEmailWorkingList != DBNull.Value)
                    {
                        SendMailNotif(InternalMemo, Convert.ToString(objEmailWorkingList), Convert.ToString(myapprovalrow[0]["Nama"]));
                    }
                    else
                    {
                    }

                    //if (Convert.ToString(myapprovalrow[0]["Email"]) != null)
                    //{
                    //    SendMailNotif(InternalMemo, Convert.ToString(myapprovalrow[0]["Email"]), Convert.ToString(myapprovalrow[0]["Nama"]));
                    //}

                }
                if (saveaction == DXISaveAction.Approve || saveaction == DXISaveAction.Reject)
                {
                    if (Convert.ToString(mynextapprovalrow["Email"]) != null)
                    {
                        SendMailNotif(InternalMemo, Convert.ToString(mynextapprovalrow["Email"]), Convert.ToString(mynextapprovalrow["Nama"]));
                    } 
                }
            }
            catch (Exception ex)
            {
                throw new ArgumentException(ex.Message);
            }
        }
        private void DeleteWorkingList(InternalMemoEntity InternalMemo, DXISaveAction saveaction, string strUserID)
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
                    sqlParameter1.Value = InternalMemo.DocKey;
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
        private void UpdateApprovalDetail(DataSet ds, InternalMemoEntity InternalMemo, DXISaveAction saveaction, string strUserID, string strApprovalNote)
        {
            SqlConnection myconn = new SqlConnection(myLocalDBSetting.ConnectionString);
            myconn.Open();
            SqlTransaction trans = myconn.BeginTransaction();
            try
            {
                if (saveaction == DXISaveAction.Approve)
                {
                    SqlCommand sqlCommand = new SqlCommand("UPDATE [dbo].[InternalMemoApprovalList] SET IsDecision=@IsDecision, DecisionState=@DecisionState, DecisionDate=@DecisionDate, DecisionNote=@DecisionNote WHERE DocKey=@DocKey AND NIK=@NIK");
                    sqlCommand.Connection = myconn;
                    sqlCommand.Transaction = trans;

                    SqlParameter sqlParameter1 = sqlCommand.Parameters.Add("@DocKey", SqlDbType.Int);
                    sqlParameter1.Value = InternalMemo.DocKey;
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
                    SqlCommand sqlCommand = new SqlCommand("UPDATE [dbo].[InternalMemoApprovalList] SET IsDecision=@IsDecision, DecisionState=@DecisionState, DecisionDate=@DecisionDate, DecisionNote=@DecisionNote WHERE DocKey=@DocKey AND NIK=@NIK");
                    sqlCommand.Connection = myconn;
                    sqlCommand.Transaction = trans;

                    SqlParameter sqlParameter1 = sqlCommand.Parameters.Add("@DocKey", SqlDbType.Int);
                    sqlParameter1.Value = InternalMemo.DocKey;
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
        private void HasApprove(InternalMemoEntity InternalMemo, DXISaveAction saveaction)
        {
            SqlConnection myconn = new SqlConnection(myLocalDBSetting.ConnectionString);
            myconn.Open();
            SqlTransaction trans = myconn.BeginTransaction();
            try
            {
                if (saveaction == DXISaveAction.Approve)
                {
                    SqlCommand sqlCommand = new SqlCommand("UPDATE [dbo].[InternalMemo] SET IsApprove=@IsApprove, Status=@Status, NextApprover=@NextApprover WHERE DocKey=@DocKey");
                    sqlCommand.Connection = myconn;
                    sqlCommand.Transaction = trans;

                    SqlParameter sqlParameter1 = sqlCommand.Parameters.Add("@DocKey", SqlDbType.Int);
                    sqlParameter1.Value = InternalMemo.DocKey;
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
                    SqlCommand sqlCommand = new SqlCommand("UPDATE [dbo].[InternalMemo] SET IsApprove=@IsApprove, Status=@Status, NextApprover=@NextApprover WHERE DocKey=@DocKey");
                    sqlCommand.Connection = myconn;
                    sqlCommand.Transaction = trans;

                    SqlParameter sqlParameter1 = sqlCommand.Parameters.Add("@DocKey", SqlDbType.Int);
                    sqlParameter1.Value = InternalMemo.DocKey;
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
        private bool bIsExist(InternalMemoEntity InternalMemo, string strUserID)
        {
            bool isexist = false;
            obj = this.myLocalDBSetting.ExecuteScalar("SELECT COUNT(*) FROM [dbo].[WorkList] WHERE SourceKey=? AND Seq=0", InternalMemo.DocKey, strUserID);
            if (obj != null && obj != DBNull.Value)
            {
                if (Convert.ToInt32(obj) > 0)
                {
                    isexist = true;
                }
            }
            return isexist;
        }

        private void SendMailNotif(InternalMemoEntity InternalMemo, string emailTo, string employeename)
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
                sqlParameter4.Value = "Hi " + employeename + ", this Internal Memo with no : " + InternalMemo.DocNo + " need your approval, please login to INFORMA as soon as posible. Thankyou!";

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

        private string GetNextApprover(string strUserID, InternalMemoEntity InternalMemo)
        {
            strnextapprover = "";
            DataRow mynextapprovalrow = myLocalDBSetting.GetFirstDataRow("SELECT TOP 1 NIK, Nama, Email FROM [dbo].[InternalMemoApprovalList] WHERE IsDecision = 'F' AND NIK <> ? AND DocKey=? ORDER BY Seq", strUserID, InternalMemo.DocKey);
            if (mynextapprovalrow != null)
            {
                strnextapprover = Convert.ToString(mynextapprovalrow["NIK"]).ToUpper();
                strnextapprover += " - " + Convert.ToString(mynextapprovalrow["Nama"]).ToUpper();
            }
            return strnextapprover;
        }
    }
}