using DevExpress.Web;
using DevExpress.Web.Data;
using DXMNCGUI_INFORMA.Controllers;
using DXMNCGUI_INFORMA.Controllers.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DXMNCGUI_INFORMA.Transaction.PeminjamanDokumen
{
    public partial class PeminjamanDokumenEntry : BasePage
    {
        protected SqlDBSetting myDBSetting
        {
            get { isValidLogin(false); return (SqlDBSetting)HttpContext.Current.Session["myDBSetting" + this.ViewState["_PageID"]]; }
            set { HttpContext.Current.Session["myDBSetting" + this.ViewState["_PageID"]] = value; }
        }
        protected SqlLocalDBSetting myLocalDBSetting
        {
            get { isValidLogin(false); return (SqlLocalDBSetting)HttpContext.Current.Session["myLocalDBSetting" + this.ViewState["_PageID"]]; }
            set { HttpContext.Current.Session["myLocalDBSetting" + this.ViewState["_PageID"]] = value; }
        }
        protected SqlDBSession myDBSession
        {
            get { isValidLogin(false); return (SqlDBSession)HttpContext.Current.Session["myDBSession" + this.ViewState["_PageID"]]; }
            set { HttpContext.Current.Session["myDBSession" + this.ViewState["_PageID"]] = value; }
        }
        protected PeminjamanDokumenDB myPeminjamanDokumenDB
        {
            get { isValidLogin(false); return (PeminjamanDokumenDB)HttpContext.Current.Session["myPeminjamanDokumenDB" + this.ViewState["_PageID"]]; }
            set { HttpContext.Current.Session["myPeminjamanDokumenDB" + this.ViewState["_PageID"]] = value; }
        }
        protected PeminjamanDokumenEntity myPeminjamanDokumenEntity
        {
            get { isValidLogin(false); return (PeminjamanDokumenEntity)HttpContext.Current.Session["myPeminjamanDokumenEntity" + this.ViewState["_PageID"]]; }
            set { HttpContext.Current.Session["myPeminjamanDokumenEntity" + this.ViewState["_PageID"]] = value; }
        }
        protected DataSet myds
        {
            get { isValidLogin(false); return (DataSet)HttpContext.Current.Session["myds" + this.ViewState["_PageID"]]; }
            set { HttpContext.Current.Session["myds" + this.ViewState["_PageID"]] = value; }
        }
        protected DataTable myHeaderTable
        {
            get { isValidLogin(false); return (DataTable)HttpContext.Current.Session["myHeadeTable" + this.ViewState["_PageID"]]; }
            set { HttpContext.Current.Session["myHeadeTable" + this.ViewState["_PageID"]] = value; }
        }
        protected DataTable myDetailTable
        {
            get { isValidLogin(false); return (DataTable)HttpContext.Current.Session["myDetailTable" + this.ViewState["_PageID"]]; }
            set { HttpContext.Current.Session["myDetailTable" + this.ViewState["_PageID"]] = value; }
        }
        protected DataTable myDocumentDetailTable
        {
            get { isValidLogin(false); return (DataTable)HttpContext.Current.Session["myDocumentDetailTable" + this.ViewState["_PageID"]]; }
            set { HttpContext.Current.Session["myDocumentDetailTable" + this.ViewState["_PageID"]] = value; }
        }
        protected DataTable myApprovalTable
        {
            get { isValidLogin(false); return (DataTable)HttpContext.Current.Session["myApprovalTable" + this.ViewState["_PageID"]]; }
            set { HttpContext.Current.Session["myApprovalTable" + this.ViewState["_PageID"]] = value; }
        }
        protected DXIAction myAction
        {
            get { isValidLogin(false); return (DXIAction)HttpContext.Current.Session["myAction" + this.ViewState["_PageID"]]; }
            set { HttpContext.Current.Session["myAction" + this.ViewState["_PageID"]] = value; }
        }
        protected DXIType myDocType
        {
            get { isValidLogin(false); return (DXIType)HttpContext.Current.Session["myDocType" + this.ViewState["_PageID"]]; }
            set { HttpContext.Current.Session["myDocType" + this.ViewState["_PageID"]] = value; }
        }
        protected string strKey
        {
            get { isValidLogin(false); return (string)HttpContext.Current.Session["strKey" + this.ViewState["_PageID"]]; }
            set { HttpContext.Current.Session["strKey" + this.ViewState["_PageID"]] = value; }
        }
        protected string myStatus
        {
            get { isValidLogin(false); return (string)HttpContext.Current.Session["myStatus" + this.ViewState["_PageID"]]; }
            set { HttpContext.Current.Session["myStatus" + this.ViewState["_PageID"]] = value; }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            isValidLogin(false);
            if (!Page.IsPostBack)
            {
                this.ViewState["_PageID"] = Guid.NewGuid();
                myDBSetting = dbsetting;
                myLocalDBSetting = localdbsetting;
                myDBSession = dbsession;

                if (this.Request.QueryString["SourceKey"] != null && this.Request.QueryString["Type"] != null)
                {
                    this.myPeminjamanDokumenDB = PeminjamanDokumenDB.Create(myDBSetting, myLocalDBSetting, myDBSession);
                    this.myPeminjamanDokumenEntity = this.myPeminjamanDokumenDB.View(Convert.ToInt32(this.Request.QueryString["SourceKey"]), Convert.ToString(this.Request.QueryString["DocNo"]), myAction);
                }
                myds = new DataSet();
                myHeaderTable = new DataTable();
                myDetailTable = new DataTable();
                myDocumentDetailTable = new DataTable();
                myApprovalTable = new DataTable();

                this.myPeminjamanDokumenDB = PeminjamanDokumenDB.Create(myDBSetting, myLocalDBSetting, myDBSession);
                strKey = Request.QueryString["Key"];
                SetApplication((PeminjamanDokumenEntity)HttpContext.Current.Session["myPeminjamanDokumenEntity" + strKey]);
            }
            if (!IsCallback)
            {

            }
        }

        private void SetApplication(PeminjamanDokumenEntity PeminjamanDokumenEntity)
        {
            if (this.myPeminjamanDokumenEntity != PeminjamanDokumenEntity)
            {
                if (PeminjamanDokumenEntity != null)
                {
                    this.myPeminjamanDokumenEntity = PeminjamanDokumenEntity;
                }

                myAction = this.myPeminjamanDokumenEntity.Action;
                myDocType = this.myPeminjamanDokumenEntity.DocType;
                myds = myPeminjamanDokumenEntity.myDataSet;
                myStatus = this.myPeminjamanDokumenEntity.Status.ToString();

                myHeaderTable = myds.Tables["Header"];
                myDetailTable = myds.Tables["Detail"];
                myApprovalTable = myds.Tables["Approval"];
                myds.Tables[1].DefaultView.Sort = "Seq";

                gvDetail.DataSource = myDetailTable;
                gvDetail.DataBind();

                gvApproval.DataSource = myApprovalTable;
                gvApproval.DataBind();

                setuplookupedit();
                BindingMaster();
                Accessable();
            }
        }
        private void setuplookupedit()
        {

        }
        private void Accessable()
        {
            txtDocNo.ReadOnly = true;
            txtDocNo.BackColor = System.Drawing.ColorTranslator.FromHtml("#f0f0f0");

            txtStatus.ReadOnly = true;
            txtStatus.BackColor = System.Drawing.ColorTranslator.FromHtml("#f0f0f0");

            txtDepartment.ReadOnly = true;
            txtDepartment.BackColor = System.Drawing.ColorTranslator.FromHtml("#f0f0f0");

            

            if (myAction == DXIAction.New)
            {
                gvApproval.Columns["colNo"].Visible = false;
            }
            if (myAction == DXIAction.View || myAction == DXIAction.Approve || Convert.ToString(myPeminjamanDokumenEntity.Status) == "APPROVE" || Convert.ToString(myPeminjamanDokumenEntity.Status) == "REJECT")
            {
                gvApproval.Columns["ClmnCommand"].Visible = false;
                gvDetail.Columns["ClmnCommand"].Visible = false;

                deDocDate.ReadOnly = true;
                deDocDate.BackColor = System.Drawing.ColorTranslator.FromHtml("#f0f0f0");

                dePengembalian.ReadOnly = true;
                dePengembalian.BackColor = System.Drawing.ColorTranslator.FromHtml("#f0f0f0");

                luCategory.ReadOnly = true;
                luCategory.BackColor = System.Drawing.ColorTranslator.FromHtml("#f0f0f0");

                mmKeperluan.ReadOnly = true;
                mmKeperluan.BackColor = System.Drawing.ColorTranslator.FromHtml("#f0f0f0");

                mmRemark.ReadOnly = true;
                mmRemark.BackColor = System.Drawing.ColorTranslator.FromHtml("#f0f0f0");

                btnSave.ClientVisible = false;
            }
            if (myAction == DXIAction.Edit)
            {
                gvApproval.Columns["ClmnCommand"].Visible = false;
                gvDetail.Columns["ClmnCommand"].Visible = false;
            }
            if (myAction == DXIAction.Approve)
            {
                btnReject.ClientVisible = true;
                btnApprove.ClientVisible = true;
            }
        }
        private void BindingMaster()
        {
            if (myAction == DXIAction.New)
            {
                object obj = dbsetting.ExecuteScalar("select top 1 b.C_NAME from SYS_TBLEMPLOYEE a inner join SYS_COMPANY b on a.C_CODE=b.C_CODE WHERE a.CODE=?", this.UserID);
                if (obj != null && obj != DBNull.Value)
                {
                    myPeminjamanDokumenEntity.Department = obj;
                }
            }
            txtDocNo.Value = myPeminjamanDokumenEntity.DocNo;
            txtStatus.Value = myPeminjamanDokumenEntity.Status;
            txtDepartment.Value = myPeminjamanDokumenEntity.Department;
            deDocDate.Value = myPeminjamanDokumenEntity.DocDate;
            dePengembalian.Value = myPeminjamanDokumenEntity.TglPengembalian;
            mmKeperluan.Value = myPeminjamanDokumenEntity.Keperluan;
            mmRemark.Value = myPeminjamanDokumenEntity.Remark;
            luCategory.Text = Convert.ToString(myPeminjamanDokumenEntity.DocCategory);
        }
        private bool Save(DXISaveAction saveAction)
        {
            bool bSave = true;

            myPeminjamanDokumenEntity.DocNo = txtDocNo.Value;
            myPeminjamanDokumenEntity.DocDate = deDocDate.Value;
            myPeminjamanDokumenEntity.Status = txtStatus.Value;
            myPeminjamanDokumenEntity.Department = txtDepartment.Value;
            myPeminjamanDokumenEntity.DocCategory = luCategory.Text;
            myPeminjamanDokumenEntity.TglPeminjaman = deDocDate.Value;
            myPeminjamanDokumenEntity.TglPengembalian = dePengembalian.Value;
            myPeminjamanDokumenEntity.Remark = mmRemark.Value;
            myPeminjamanDokumenEntity.Keperluan = mmKeperluan.Value;

            if (myAction == DXIAction.New)
            {
                myPeminjamanDokumenEntity.CreatedBy = UserID;
                myPeminjamanDokumenEntity.CreatedDateTime = myLocalDBSetting.GetServerTime();
                myPeminjamanDokumenEntity.LastModifiedBy = UserID;
                myPeminjamanDokumenEntity.LastModifiedDateTime = myLocalDBSetting.GetServerTime();
            }
            string strApprovalNote = "";
            if (myAction == DXIAction.Approve)
            {
                strApprovalNote = Convert.ToString(mmDecisionNote.Value);
            }
            myPeminjamanDokumenEntity.Save(this.UserID, this.UserName, "", saveAction, strApprovalNote);

            insertLog();

            return bSave;
        }
        protected bool ErrorInField(out string strmessageError, DXISaveAction saveaction)
        {
            bool errorF = false;
            bool focusF = false;
            strmessageError = "";
            cplMain.JSProperties["cplActiveTabIndex"] = 0;

            if (myApprovalTable.Rows.Count == 0)
            {
                errorF = true;
                if (!focusF)
                {
                    gvApproval.Focus();
                    focusF = true;
                    strmessageError = "Please add approval list, empty list approval is not allowed.";
                    cplMain.JSProperties["cplActiveTabIndex"] = 1;
                }
            }

            return errorF;
        }

        protected void cplMain_Callback(object source, CallbackEventArgs e)
        {
            string urlsave = "";
            string[] callbackParam = e.Parameter.ToString().Split(';');
            urlsave = "~/Transaction/PeminjamanDokumen/PeminjamanDokumenList.aspx";
            var nameValues = HttpUtility.ParseQueryString(Request.QueryString.ToString());
            nameValues.Set("DocKey", myPeminjamanDokumenEntity.DocKey.ToString());
            string updatedQueryString = "?" + nameValues.ToString();
            cplMain.JSProperties["cpCallbackParam"] = callbackParam[0].ToUpper();
            SqlDBSetting dbSetting = this.myDBSetting;
            SqlLocalDBSetting dbLocalSetting = this.myLocalDBSetting;
            string strmessageError = "";

            switch (callbackParam[0].ToUpper())
            {
                case "SAVE_CONFIRM":
                    cplMain.JSProperties["cplblmessageError"] = "";
                    cplMain.JSProperties["cplblmessage"] = "are you sure want to save this memo?";
                    cplMain.JSProperties["cplblActionButton"] = "SAVE";
                    if (ErrorInField(out strmessageError, DXISaveAction.Save))
                    {
                        cplMain.JSProperties["cplblmessageError"] = strmessageError;
                    }
                    break;
                case "SAVE":
                    Save(DXISaveAction.Save);
                    cplMain.JSProperties["cpAlertMessage"] = "Memo has been save...";
                    cplMain.JSProperties["cplblActionButton"] = "SAVE";
                    ASPxWebControl.RedirectOnCallback(urlsave);
                    break;
                case "REJECT_CONFIRM":
                    cplMain.JSProperties["cplblmessageError"] = "";
                    cplMain.JSProperties["cplblmessage"] = "are you sure want to Reject this memo?";
                    cplMain.JSProperties["cplblActionButton"] = "REJECT";
                    if (ErrorInField(out strmessageError, DXISaveAction.Save))
                    {
                        cplMain.JSProperties["cplblmessageError"] = strmessageError;
                    }
                    break;
                case "REJECT":
                    Save(DXISaveAction.Reject);
                    cplMain.JSProperties["cpAlertMessage"] = "Memo has been rejected...";
                    cplMain.JSProperties["cplblActionButton"] = "REJECT";
                    ASPxWebControl.RedirectOnCallback(urlsave);
                    break;
                case "APPROVE_CONFIRM":
                    cplMain.JSProperties["cplblmessageError"] = "";
                    cplMain.JSProperties["cplblmessage"] = "are you sure want to Approve this memo?";
                    cplMain.JSProperties["cplblActionButton"] = "APPROVE";
                    if (ErrorInField(out strmessageError, DXISaveAction.Save))
                    {
                        cplMain.JSProperties["cplblmessageError"] = strmessageError;
                    }
                    break;
                case "APPROVE":
                    Save(DXISaveAction.Approve);
                    cplMain.JSProperties["cpAlertMessage"] = "Memo has been approved...";
                    cplMain.JSProperties["cplblActionButton"] = "APPROVE";
                    ASPxWebControl.RedirectOnCallback(urlsave);
                    break;
            }
        }

        protected void luCategory_DataBinding(object sender, EventArgs e)
        {

        }

        protected void gvDetail_DataBinding(object sender, EventArgs e)
        {
            (sender as ASPxGridView).DataSource = myds.Tables["Detail"];
        }
        protected void gvDetail_RowInserting(object sender, ASPxDataInsertingEventArgs e)
        {
            string StrErrorMsg = "";
            if (e.NewValues["DocID"] == null) throw new Exception("Column 'Document' is mandatory.");
            if (StrErrorMsg == "")
            {
                gvDetail.JSProperties["cpCmd"] = "INSERT";

                int i = gvDetail.VisibleRowCount;

                myDetailTable.Rows.Add(
                    myPeminjamanDokumenEntity.PeminjamanDokumenDBcommand.DtlKeyUniqueKey(),
                    myPeminjamanDokumenEntity.DocKey,
                    i,
                    Convert.ToString(e.NewValues["DocID"]),
                    Convert.ToString(e.NewValues["Description"]),
                    Convert.ToString(e.NewValues["Status"])
                    );

                ASPxGridView grid = sender as ASPxGridView;
                grid.CancelEdit();
                e.Cancel = true;
            }
        }
        protected void gvDetail_RowUpdating(object sender, ASPxDataUpdatingEventArgs e)
        {
            string StrErrorMsg = "";
            if (e.NewValues["DocID"] == null) throw new Exception("Column 'Document' is mandatory.");

            if (StrErrorMsg == "")
            {
                gvDetail.JSProperties["cpCmd"] = "UPDATE";
                int editingRowVisibleIndex = gvDetail.EditingRowVisibleIndex;
                int id = (int)gvDetail.GetRowValues(editingRowVisibleIndex, "DtlKey");
                DataRow dr = myDetailTable.Rows.Find(id);

                dr["DocID"] = Convert.ToString(e.NewValues["DocID"]);
                dr["Description"] = Convert.ToString(e.NewValues["Description"]);
                dr["Status"] = Convert.ToString(e.NewValues["DocStatus"]);

                ASPxGridView grid = sender as ASPxGridView;
                grid.CancelEdit();
                e.Cancel = true;
            }
        }
        protected void gvDetail_RowDeleting(object sender, ASPxDataDeletingEventArgs e)
        {
            gvDetail.JSProperties["cpCmd"] = "DELETE";
            int id = (int)e.Keys["DtlKey"];
            DataRow dr = myDetailTable.Rows.Find(id);

            myDetailTable.Rows.Remove(dr);

            ASPxGridView grid = sender as ASPxGridView;
            grid.CancelEdit();
            e.Cancel = true;
        }
        protected void gvDetail_CustomCallback(object sender, ASPxGridViewCustomCallbackEventArgs e)
        {

        }
        protected void gvDetail_CellEditorInitialize(object sender, ASPxGridViewEditorEventArgs e)
        {
            ASPxGridView gridView = sender as ASPxGridView;
            if (e.Column.FieldName == "DocID")
            {
                isValidLogin(false);
                if (Page.IsCallback)
                {
                    DataTable myitem = new DataTable();
                    //myitem = myDBSetting.GetDataTable(@"SELECT *, 'New' DocStatus FROM [SSS].[dbo].[mstDocLocation] WHERE Status = 'Close'", false, "");
                    string ssql = "select *, 'New' DocStatus from [SSS].[dbo].[mstDocLocation]";
                    myitem = myLocalDBSetting.GetDataTable(ssql, false, "");
                    ASPxComboBox cmb = (ASPxComboBox)e.Editor;
                    cmb.DataSource = myitem;
                    cmb.DataBindItems();
                }
            }
        }
        protected void gvDetail_CustomColumnDisplayText(object sender, ASPxGridViewColumnDisplayTextEventArgs e)
        {
            if (e.Column.Caption == "No")
            {
                e.DisplayText = (e.VisibleIndex + 1).ToString();
            }
        }

        //protected void updateMasterDocLoc(string docID, string docStatus)
        //{
        //    string ssql = "UPDATE [SSS].[dbo].[mstDocLocation] SET Status = ?, MOD_BY = ?, MOD_DATE = GETDATE() WHERE DocID = ?";
        //    myLocalDBSetting.ExecuteNonQuery(ssql, docStatus, UserID, docID);
        //}

        protected void insertLog()
        {
            if(myDetailTable.Rows.Count > 0)
            {
                foreach(DataRow dr in myDetailTable.Rows)
                {
                    string ssql = @"INSERT INTO [INFORMA].[dbo].[PeminjamanDokumenHistory] ([DocKey],[DocNo],[DocDate],[DocCategory],[Department],[PengajuanStatus],[Keperluan],[Remarks], 
                        [TglPeminjaman],[TglPengembalian],[DocID],[DocDesc],[DocStatus],[CreatedBy],[CreatedDate])
                        VALUES(@DocKey,@DocNo,@DocDate,@DocCategory,@Department,@PengajuanStatus,@Keperluan,@Remarks,@TglPeminjaman,@TglPengembalian,@DocID,@DocDesc,@DocStatus,@CreatedBy,GETDATE())";

                    SqlConnection myconn = new SqlConnection(myLocalDBSetting.ConnectionString);
                    SqlCommand sqlCommand = new SqlCommand(ssql);
                    sqlCommand.Connection = myconn;
                    myconn.Open();

                    SqlParameter sqlParameter1 = sqlCommand.Parameters.Add("@DocKey", SqlDbType.Int);
                    sqlParameter1.Value = myPeminjamanDokumenEntity.DocKey;
                    sqlParameter1.Direction = ParameterDirection.Input;
                    SqlParameter sqlParameter2 = sqlCommand.Parameters.Add("@DocNo", SqlDbType.VarChar);
                    sqlParameter2.Value = myPeminjamanDokumenEntity.DocNo;
                    sqlParameter2.Direction = ParameterDirection.Input;
                    SqlParameter sqlParameter3 = sqlCommand.Parameters.Add("@DocDate", SqlDbType.DateTime);
                    sqlParameter3.Value = myPeminjamanDokumenEntity.DocDate;
                    sqlParameter3.Direction = ParameterDirection.Input;
                    SqlParameter sqlParameter4 = sqlCommand.Parameters.Add("@DocCategory", SqlDbType.VarChar);
                    sqlParameter4.Value = myPeminjamanDokumenEntity.DocCategory;
                    sqlParameter4.Direction = ParameterDirection.Input;
                    SqlParameter sqlParameter5 = sqlCommand.Parameters.Add("@Department", SqlDbType.VarChar);
                    sqlParameter5.Value = myPeminjamanDokumenEntity.Department;
                    sqlParameter5.Direction = ParameterDirection.Input;
                    SqlParameter sqlParameter6 = sqlCommand.Parameters.Add("@PengajuanStatus", SqlDbType.VarChar);
                    sqlParameter6.Value = myPeminjamanDokumenEntity.Status;
                    sqlParameter6.Direction = ParameterDirection.Input;
                    SqlParameter sqlParameter7 = sqlCommand.Parameters.Add("@Keperluan", SqlDbType.VarChar);
                    sqlParameter7.Value = myPeminjamanDokumenEntity.Keperluan;
                    sqlParameter7.Direction = ParameterDirection.Input;
                    SqlParameter sqlParameter8 = sqlCommand.Parameters.Add("@Remarks", SqlDbType.VarChar);
                    sqlParameter8.Value = myPeminjamanDokumenEntity.Remark;
                    sqlParameter8.Direction = ParameterDirection.Input;
                    SqlParameter sqlParameter9 = sqlCommand.Parameters.Add("@TglPeminjaman", SqlDbType.DateTime);
                    sqlParameter9.Value = myPeminjamanDokumenEntity.TglPeminjaman;
                    sqlParameter9.Direction = ParameterDirection.Input;
                    SqlParameter sqlParameter10 = sqlCommand.Parameters.Add("@TglPengembalian", SqlDbType.DateTime);
                    sqlParameter10.Value = myPeminjamanDokumenEntity.TglPengembalian;
                    sqlParameter10.Direction = ParameterDirection.Input;

                    //Detail
                    SqlParameter sqlParameter11 = sqlCommand.Parameters.Add("@DocID", SqlDbType.VarChar);
                    sqlParameter11.Value = dr["DocID"].ToString();
                    sqlParameter11.Direction = ParameterDirection.Input;
                    SqlParameter sqlParameter12 = sqlCommand.Parameters.Add("@DocDesc", SqlDbType.VarChar);
                    sqlParameter12.Value = dr["Description"].ToString();
                    sqlParameter12.Direction = ParameterDirection.Input;
                    SqlParameter sqlParameter13 = sqlCommand.Parameters.Add("@DocStatus", SqlDbType.VarChar);
                    sqlParameter13.Value = dr["Status"].ToString();
                    sqlParameter13.Direction = ParameterDirection.Input;

                    SqlParameter sqlParameter14 = sqlCommand.Parameters.Add("@CreatedBy", SqlDbType.VarChar);
                    sqlParameter14.Value = UserID;
                    sqlParameter14.Direction = ParameterDirection.Input;

                    sqlCommand.ExecuteNonQuery();

                    myconn.Close();
                }
            }
        }

        protected void btnBack_Click(object sender, EventArgs e)
        {
            Response.Redirect("PeminjamanDokumenList.aspx");
        }

        protected DataTable getDataApproval(string value)
        {
            DataTable res = new DataTable();
            string ssql = "select * from [INFORMA].[dbo].[PeminjamanDokumenApprovalList] where DocKey = ?";
            res = myLocalDBSetting.GetDataTable(ssql, false, value);

            return res;
        }

        protected void gvApproval_DataBinding(object sender, EventArgs e)
        {
            (sender as ASPxGridView).DataSource = myds.Tables["Approval"];
        }

        protected void gvApproval_RowInserting(object sender, ASPxDataInsertingEventArgs e)
        {
            string StrErrorMsg = "";
            if (e.NewValues["Nama"] == null) throw new Exception("Column 'Nama' is mandatory.");
            if (StrErrorMsg == "")
            {
                gvApproval.JSProperties["cpCmd"] = "INSERT";

                int i = gvApproval.VisibleRowCount;

                myApprovalTable.Rows.Add(myPeminjamanDokumenEntity.PeminjamanDokumenDBcommand.DtlAppKeyUniqueKey(),
                    myPeminjamanDokumenEntity.DocKey, i,
                    Convert.ToString(e.NewValues["NIK"]),
                    Convert.ToString(e.NewValues["Nama"]),
                    Convert.ToString(e.NewValues["Jabatan"])
                    );

                ASPxGridView grid = sender as ASPxGridView;
                grid.CancelEdit();
                e.Cancel = true;
            }
        }

        protected void gvApproval_RowUpdating(object sender, ASPxDataUpdatingEventArgs e)
        {
            string StrErrorMsg = "";
            if (e.NewValues["Nama"] == null) throw new Exception("Nama is null are not allowed.");

            if (StrErrorMsg == "")
            {
                gvApproval.JSProperties["cpCmd"] = "UPDATE";
                int editingRowVisibleIndex = gvApproval.EditingRowVisibleIndex;
                int id = (int)gvApproval.GetRowValues(editingRowVisibleIndex, "DtlAppKey");
                DataRow dr = myApprovalTable.Rows.Find(id);

                dr["NIK"] = Convert.ToString(e.NewValues["NIK"]);
                dr["Nama"] = Convert.ToString(e.NewValues["Nama"]);
                dr["Jabatan"] = Convert.ToString(e.NewValues["Jabatan"]);

                ASPxGridView grid = sender as ASPxGridView;
                grid.CancelEdit();
                e.Cancel = true;
            }
        }

        protected void gvApproval_RowDeleting(object sender, ASPxDataDeletingEventArgs e)
        {
            gvApproval.JSProperties["cpCmd"] = "DELETE";
            int id = (int)e.Keys["DtlAppKey"];
            DataRow dr = myApprovalTable.Rows.Find(id);

            myApprovalTable.Rows.Remove(dr);

            ASPxGridView grid = sender as ASPxGridView;
            grid.CancelEdit();
            e.Cancel = true;
        }

        protected void gvApproval_CustomCallback(object sender, ASPxGridViewCustomCallbackEventArgs e)
        {

        }

        protected void gvApproval_CellEditorInitialize(object sender, ASPxGridViewEditorEventArgs e)
        {
            if (e.Column.FieldName == "Nama")
            {
                isValidLogin(false);
                if (Page.IsCallback)
                {
                    DataTable myitem = new DataTable();
                    myitem = myLocalDBSetting.GetDataTable("SELECT NIK, Nama, '' as Jabatan FROM Employee", false);
                    ASPxComboBox cmb = (ASPxComboBox)e.Editor;
                    cmb.DataSource = myitem;
                    cmb.DataBindItems();
                }
            }
        }

        protected void gvApproval_CustomColumnDisplayText(object sender, ASPxGridViewColumnDisplayTextEventArgs e)
        {
            if (e.Column.Caption == "No")
            {
                e.DisplayText = (e.VisibleIndex + 1).ToString();
            }
        }

        protected void gvApproval_AutoFilterCellEditorInitialize(object sender, ASPxGridViewEditorEventArgs e)
        {

        }
    }
}