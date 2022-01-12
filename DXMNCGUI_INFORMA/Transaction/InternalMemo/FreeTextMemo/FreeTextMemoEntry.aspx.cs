
using DevExpress.Web;
using DevExpress.Web.Internal;
using DevExpress.XtraRichEdit;
using DXMNCGUI_INFORMA.Controllers;
using DXMNCGUI_INFORMA.Controllers.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DXMNCGUI_INFORMA.Transaction.InternalMemo.FreeTextMemo
{
    public partial class FreeTextMemoEntry : BasePage
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
        protected FreeTextMemoDB myFreeTextMemoDB
        {
            get { isValidLogin(false); return (FreeTextMemoDB)HttpContext.Current.Session["myFreeTextMemoDB" + this.ViewState["_PageID"]]; }
            set { HttpContext.Current.Session["myFreeTextMemoDB" + this.ViewState["_PageID"]] = value; }
        }
        protected FreeTextMemoEntity myFreeTextMemoEntity
        {
            get { isValidLogin(false); return (FreeTextMemoEntity)HttpContext.Current.Session["myFreeTextMemoEntity" + this.ViewState["_PageID"]]; }
            set { HttpContext.Current.Session["myFreeTextMemoEntity" + this.ViewState["_PageID"]] = value; }
        }
        protected DataSet myds
        {
            get { isValidLogin(false); return (DataSet)HttpContext.Current.Session["myds" + this.ViewState["_PageID"]]; }
            set { HttpContext.Current.Session["myds" + this.ViewState["_PageID"]] = value; }
        }
        protected MemoryStream myFs
        {
            get { isValidLogin(false); return (MemoryStream)HttpContext.Current.Session["myFs" + this.ViewState["_PageID"]]; }
            set { HttpContext.Current.Session["myFs" + this.ViewState["_PageID"]] = value; }
        }
        protected DataTable myHeaderTable
        {
            get { isValidLogin(false); return (DataTable)HttpContext.Current.Session["myHeadeTable" + this.ViewState["_PageID"]]; }
            set { HttpContext.Current.Session["myHeadeTable" + this.ViewState["_PageID"]] = value; }
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
        protected string myDocName
        {
            get { isValidLogin(false); return (string)HttpContext.Current.Session["myDocName" + this.ViewState["_PageID"]]; }
            set { HttpContext.Current.Session["myDocName" + this.ViewState["_PageID"]] = value; }
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

                if (this.Request.QueryString["SourceKey"] != null)
                {
                    this.myFreeTextMemoDB = FreeTextMemoDB.Create(myDBSetting, myLocalDBSetting, myDBSession);
                    this.myFreeTextMemoEntity = this.myFreeTextMemoDB.View(Convert.ToInt32(this.Request.QueryString["SourceKey"]), Convert.ToString(this.Request.QueryString["DocNo"]), myAction);
                }

                myFs = new MemoryStream();
                myds = new DataSet();
                myApprovalTable = new DataTable();

                this.myFreeTextMemoDB = FreeTextMemoDB.Create(myDBSetting, myLocalDBSetting, myDBSession);
                strKey = Request.QueryString["Key"];
                SetApplication((FreeTextMemoEntity)HttpContext.Current.Session["myFreeTextMemoEntity" + strKey]);

                

            }
                
        }

        private void SetApplication(FreeTextMemoEntity FreeTextMemoEntity)
        {
            if (this.myFreeTextMemoEntity != FreeTextMemoEntity)
            {
                if (FreeTextMemoEntity != null)
                {
                    this.myFreeTextMemoEntity = FreeTextMemoEntity;
                }
                
                myAction = this.myFreeTextMemoEntity.Action;
                myds = myFreeTextMemoEntity.myDataSet;
                myStatus = this.myFreeTextMemoEntity.Status.ToString();

                myHeaderTable = myds.Tables["Header"];
                myApprovalTable = myds.Tables["Approval"];
                myds.Tables[1].DefaultView.Sort = "Seq";

                gvApproval.DataSource = myApprovalTable;
                gvApproval.DataBind();

                setuplookupedit();
                BindingMaster();
                Accessable();
            }
        }

        private void setuplookupedit()
        {
            //txtDari.Value = this.UserID + " - " + this.UserName;

            //object obj = dbsetting.ExecuteScalar("select top 1 b.C_NAME from SYS_TBLEMPLOYEE a inner join SYS_COMPANY b on a.C_CODE=b.C_CODE WHERE a.CODE=?", this.UserID);
            //if (obj != null && obj != DBNull.Value)
            //{
            //    txtCabang.Value = obj;
            //}

            deTanggal.Value = myDBSetting.GetServerTime();
        }

        private void BindingMaster()
        {
            txtMemo.Value = "Free Text Memo";
            txtStatus.Value = myFreeTextMemoEntity.Status;

            if (myAction != DXIAction.New)
            {
                lblDocNo.Value = myFreeTextMemoEntity.DocNo;
                //txtKepada.Value = myFreeTextMemoEntity.MemoTo;
                //txtTembusan.Value = myFreeTextMemoEntity.MemoCC;
                //txtDari.Value = myFreeTextMemoEntity.MemoFrom;
                //txtCabang.Value = myFreeTextMemoEntity.MemoBranch;
                //deTanggal.Value = myFreeTextMemoEntity.DocDate;
                //mmPerihal.Value = myFreeTextMemoEntity.MemoPerihal;

                if(myFreeTextMemoEntity.DocFile != DBNull.Value)
                {
                    reMemo.Open(myFreeTextMemoEntity.DocNo.ToString(), DocumentFormat.Rtf, () => { return (byte[])myFreeTextMemoEntity.DocFile; });
                }
                
            }
        }

        private void Accessable()
        {
            txtMemo.ReadOnly = true;
            txtMemo.BackColor = System.Drawing.ColorTranslator.FromHtml("#f0f0f0");

            txtStatus.ReadOnly = true;
            txtStatus.BackColor = System.Drawing.ColorTranslator.FromHtml("#f0f0f0");

            if (myAction == DXIAction.New)
            {
                gvApproval.Columns["colNo"].Visible = false;
            }
            if (myAction == DXIAction.View || myAction == DXIAction.Approve || Convert.ToString(myFreeTextMemoEntity.Status) == "APPROVE" || Convert.ToString(myFreeTextMemoEntity.Status) == "REJECT")
            {
                
                gvApproval.Columns["ClmnCommand"].Visible = false;
                

                lblDocNo.Visible = true;

                deTanggal.ReadOnly = true;
                deTanggal.BackColor = System.Drawing.ColorTranslator.FromHtml("#f0f0f0");

                
                reMemo.ReadOnly = true;
                reMemo.RibbonMode = DevExpress.Web.ASPxRichEdit.RichEditRibbonMode.None;
                reMemo.Settings.HorizontalRuler.Visibility = RichEditRulerVisibility.Hidden;

                btnSave.ClientEnabled = false;
                btnSave.BackColor = System.Drawing.ColorTranslator.FromHtml("#f0f0f0");
            }
            if (myAction == DXIAction.Edit)
            {
                gvApproval.Columns["ClmnCommand"].Visible = false;
            }
            if (myAction == DXIAction.Approve)
            {
                btnReject.ClientVisible = true;
                btnApprove.ClientVisible = true;
            }
        }

        protected void btnExport_Click(object sender, EventArgs e)
        {
            reMemo.ExportToPdf(myFs);
            HttpUtils.WriteFileToResponse(Page, myFs, "PDFMemo", true, "pdf");
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            reMemo.SaveCopy(myFs, DocumentFormat.Rtf);

            byte[] arr = myFs.ToArray();

            SqlConnection myconn = new SqlConnection(localdbsetting.ConnectionString);
            myconn.Open();
            SqlTransaction trans = myconn.BeginTransaction();
            try
            {
                string[] luValue = { null, null, null, null };
                string sQuery = @"INSERT INTO table_1
                                    VALUES (@DocFile)";
                SqlCommand sqlCommand = new SqlCommand(sQuery);
                sqlCommand.CommandType = CommandType.Text;
                sqlCommand.Connection = myconn;
                sqlCommand.Transaction = trans;

                SqlParameter sqlParameter1 = sqlCommand.Parameters.Add("@DocFile", SqlDbType.Binary);
                sqlParameter1.Value = arr;

                sqlCommand.ExecuteNonQuery();
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

        protected void btnLoad_Click(object sender, EventArgs e)
        {
            DataTable loadDoc = new DataTable();
            loadDoc = localdbsetting.GetDataTable("SELECT * FROM Table_1 WHERE id = 1",false);

            foreach (DataRow dr in loadDoc.Rows)
            {
                reMemo.Open(dr["id"].ToString(),DocumentFormat.Rtf,() => { return (byte[])dr["DocFile"]; });
            }
        }

        protected void gvApproval_DataBinding(object sender, EventArgs e)
        {
            (sender as ASPxGridView).DataSource = myds.Tables["Approval"];
        }

        protected void gvApproval_RowInserting(object sender, DevExpress.Web.Data.ASPxDataInsertingEventArgs e)
        {
            string StrErrorMsg = "";
            if (e.NewValues["Nama"] == null) throw new Exception("Column 'Nama' is mandatory.");
            if (StrErrorMsg == "")
            {
                gvApproval.JSProperties["cpCmd"] = "INSERT";

                int i = gvApproval.VisibleRowCount;

                myApprovalTable.Rows.Add(myFreeTextMemoEntity.FreeTextMemoDBcommand.DtlAppKeyUniqueKey(),
                    myFreeTextMemoEntity.DocKey, i,
                    Convert.ToString(e.NewValues["NIK"]),
                    Convert.ToString(e.NewValues["Nama"]),
                    Convert.ToString(e.NewValues["Jabatan"])
                    );

                ASPxGridView grid = sender as ASPxGridView;
                grid.CancelEdit();
                e.Cancel = true;
            }
        }

        protected void gvApproval_RowUpdating(object sender, DevExpress.Web.Data.ASPxDataUpdatingEventArgs e)
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

        protected void gvApproval_RowDeleting(object sender, DevExpress.Web.Data.ASPxDataDeletingEventArgs e)
        {
            gvApproval.JSProperties["cpCmd"] = "DELETE";
            int id = (int)e.Keys["DtlAppKey"];
            DataRow dr = myApprovalTable.Rows.Find(id);

            myApprovalTable.Rows.Remove(dr);

            ASPxGridView grid = sender as ASPxGridView;
            grid.CancelEdit();
            e.Cancel = true;
        }

        protected void gvApproval_CustomCallback(object sender, DevExpress.Web.ASPxGridViewCustomCallbackEventArgs e)
        {

        }

        protected void gvApproval_AutoFilterCellEditorInitialize(object sender, DevExpress.Web.ASPxGridViewEditorEventArgs e)
        {

        }

        protected void gvApproval_CellEditorInitialize(object sender, DevExpress.Web.ASPxGridViewEditorEventArgs e)
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

        protected void gvApproval_CustomColumnDisplayText(object sender, DevExpress.Web.ASPxGridViewColumnDisplayTextEventArgs e)
        {
            if (e.Column.Caption == "No")
            {
                e.DisplayText = (e.VisibleIndex + 1).ToString();
            }
        }

        protected void cplMain_Callback(object source, DevExpress.Web.CallbackEventArgs e)
        {
            string urlsave = "";
            string[] callbackParam = e.Parameter.ToString().Split(';');
            urlsave = "~/Transaction/InternalMemo/FreeTextMemo/FreeTextMemoMaint.aspx";
            var nameValues = HttpUtility.ParseQueryString(Request.QueryString.ToString());
            nameValues.Set("DocKey", myFreeTextMemoEntity.DocKey.ToString());
            string updatedQueryString = "?" + nameValues.ToString();
            cplMain.JSProperties["cpCallbackParam"] = callbackParam[0].ToUpper();
            SqlDBSetting dbSetting = this.myDBSetting;
            SqlLocalDBSetting dbLocalSetting = this.myLocalDBSetting;
            string strmessageError = "";

            switch (callbackParam[0].ToUpper())
            {
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
            }
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

        protected void btnBack_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Transaction/InternalMemo/FreeTextMemo/FreeTextMemoMaint.aspx");
        }

        private bool Save(DXISaveAction saveAction)
        {
            bool bSave = true;
            myDocName = "IM";

            //myFreeTextMemoEntity.MemoTo = txtKepada.Value;
            //myFreeTextMemoEntity.MemoCC = txtTembusan.Value;
            //myFreeTextMemoEntity.MemoFrom = txtDari.Value;
            //myFreeTextMemoEntity.MemoBranch = txtCabang.Value;
            myFreeTextMemoEntity.DocDate = deTanggal.Value;
            //myFreeTextMemoEntity.MemoPerihal = mmPerihal.Value;
            myFreeTextMemoEntity.NextApprover = "";


            reMemo.SaveCopy(myFs, DocumentFormat.Rtf);
            byte[] arr = myFs.ToArray();
            myFreeTextMemoEntity.DocFile = arr;

            if (myAction == DXIAction.New)
            {
                myFreeTextMemoEntity.CreatedBy = UserID;
                myFreeTextMemoEntity.CreatedDate = myLocalDBSetting.GetServerTime();
                myFreeTextMemoEntity.LastModifiedBy = UserID;
                myFreeTextMemoEntity.LastModifiedDate = myLocalDBSetting.GetServerTime();
            }
            string strApprovalNote = "";
            if (myAction == DXIAction.Approve)
            {
                strApprovalNote = Convert.ToString(mmDecisionNote.Value);
            }
            myFreeTextMemoEntity.Save(this.UserID, this.UserName, myDocName, saveAction, strApprovalNote);
            return bSave;
        }

        protected void btnexport_Click1(object sender, EventArgs e)
        {
            reMemo.ExportToPdf(myFs);
            HttpUtils.WriteFileToResponse(Page, myFs, "PDFMemo", true, "pdf");
        }
    }
}