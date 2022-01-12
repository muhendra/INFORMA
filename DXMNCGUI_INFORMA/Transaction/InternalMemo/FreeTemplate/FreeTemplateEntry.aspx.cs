using DevExpress.Web;
using DevExpress.Web.ASPxRichEdit;
using DevExpress.XtraRichEdit;
using DXMNCGUI_INFORMA.Controllers;
using DXMNCGUI_INFORMA.Controllers.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DXMNCGUI_INFORMA.Transaction.InternalMemo.FreeTemplate
{
    public partial class FreeTemplateEntry : BasePage
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
        protected FreeTemplateDB myFreeTemplateDB
        {
            get { isValidLogin(false); return (FreeTemplateDB)HttpContext.Current.Session["myFreeTemplateDB" + this.ViewState["_PageID"]]; }
            set { HttpContext.Current.Session["myFreeTemplateDB" + this.ViewState["_PageID"]] = value; }
        }
        protected FreeTemplateEntity myFreeTemplateEntity
        {
            get { isValidLogin(false); return (FreeTemplateEntity)HttpContext.Current.Session["myFreeTemplateEntity" + this.ViewState["_PageID"]]; }
            set { HttpContext.Current.Session["myFreeTemplateEntity" + this.ViewState["_PageID"]] = value; }
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
        protected string myDocName
        {
            get { isValidLogin(false); return (string)HttpContext.Current.Session["myDocName" + this.ViewState["_PageID"]]; }
            set { HttpContext.Current.Session["myDocName" + this.ViewState["_PageID"]] = value; }
        }
        protected int iDocValue
        {
            get { isValidLogin(false); return (int)HttpContext.Current.Session["iDocValue" + this.ViewState["_PageID"]]; }
            set { HttpContext.Current.Session["iDocValue" + this.ViewState["_PageID"]] = value; }
        }
        private int FileDocID
        {
            get { var value = ViewState["FileDocID"]; return null != value ? (int)value : 0; }
            set { ViewState["FileDocID"] = value; }
        }
        protected string DocValueDesc
        {
            get { isValidLogin(false); return (string)HttpContext.Current.Session["DocValueDesc" + this.ViewState["_PageID"]]; }
            set { HttpContext.Current.Session["DocValueDesc" + this.ViewState["_PageID"]] = value; }
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
                    this.myFreeTemplateDB = FreeTemplateDB.Create(myDBSetting, myLocalDBSetting, myDBSession);
                    this.myFreeTemplateEntity = this.myFreeTemplateDB.View(Convert.ToInt32(this.Request.QueryString["SourceKey"]), Convert.ToString(this.Request.QueryString["DocNo"]), myAction);
                }
                myds = new DataSet();
                myHeaderTable = new DataTable();
                myApprovalTable = new DataTable();
                this.myFreeTemplateDB = FreeTemplateDB.Create(myDBSetting, myLocalDBSetting, myDBSession);
                strKey = Request.QueryString["Key"];
                SetApplication((FreeTemplateEntity)HttpContext.Current.Session["myFreeTemplateEntity" + strKey]);
            }
            if (!IsCallback)
            {

            }
        }
        private void SetApplication(FreeTemplateEntity FreeTemplateEntity)
        {
            if (this.myFreeTemplateEntity != FreeTemplateEntity)
            {
                if (FreeTemplateEntity != null)
                {
                    this.myFreeTemplateEntity = FreeTemplateEntity;
                }

                switch (Convert.ToInt32(myFreeTemplateEntity.DocValue))
                {
                    case 99:
                        DocValueDesc = "PEMAKAIAN CASH COLLATERAL";
                        break;
                }

                iDocValue = Convert.ToInt32(this.myFreeTemplateEntity.DocValue);
                myAction = this.myFreeTemplateEntity.Action;
                myDocType = this.myFreeTemplateEntity.DocType;
                myds = myFreeTemplateEntity.myDataSet;
                myStatus = this.myFreeTemplateEntity.Status.ToString();

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
            txtDocNo.Value = (object)"NEW";
            txtDari.Value = this.UserID + " - " + this.UserName;

            object obj = dbsetting.ExecuteScalar("select top 1 b.C_NAME from SYS_TBLEMPLOYEE a inner join SYS_COMPANY b on a.C_CODE=b.C_CODE WHERE a.CODE=?", this.UserID);
            if (obj != null && obj != DBNull.Value)
            {
                txtCabang.Value = obj;
            }

            deDocDate.Value = myDBSetting.GetServerTime();
        }
        private void Accessable()
        {
            txtDocNo.ReadOnly = true;
            txtDocNo.BackColor = ColorTranslator.FromHtml("#f0f0f0");

            deDocDate.Enabled = false;
            deDocDate.BackColor = ColorTranslator.FromHtml("#f0f0f0");

            txtStatus.ReadOnly = true;
            txtStatus.BackColor = ColorTranslator.FromHtml("#f0f0f0");

            txtDari.ReadOnly = true;
            txtDari.BackColor = ColorTranslator.FromHtml("#f0f0f0");

            txtCabang.ReadOnly = true;
            txtCabang.BackColor = ColorTranslator.FromHtml("#f0f0f0");

            btnReject.ClientVisible = false;
            btnApprove.ClientVisible = false;

            if (myAction == DXIAction.New)
            {
                gvApproval.Columns["colNo"].Visible = false;
            }
            if (myAction == DXIAction.View || myAction == DXIAction.Approve || Convert.ToString(myFreeTemplateEntity.Status) == "APPROVE" || Convert.ToString(myFreeTemplateEntity.Status) == "REJECT")
            {
                lblHeader.Text = "View Internal Memo";
                gvApproval.Columns["ClmnCommand"].Visible = false;
                DemoRichEdit.ReadOnly = true;

                mmRemark.ReadOnly = true;
                mmRemark.ForeColor = ColorTranslator.FromHtml("#a6a6a6");
                mmRemark.BackColor = ColorTranslator.FromHtml("#f0f0f0");

                btnSave.ClientVisible = false;
            }
            if (myAction == DXIAction.Edit)
            {
                lblHeader.Text = "Edit Internal Memo";
                gvApproval.Columns["ClmnCommand"].Visible = false;
            }
            if (myAction == DXIAction.Approve)
            {
                btnSave.ClientVisible = false;
                btnReject.ClientVisible = true;
                btnApprove.ClientVisible = true;
            }
        }
        private void BindingMaster()
        {
            if (myAction == DXIAction.New){ NewDocument(); }

            txtDocNo.Value = myFreeTemplateEntity.DocNo;
            deDocDate.Value = myFreeTemplateEntity.DocDate;
            txtStatus.Value = myFreeTemplateEntity.Status;

            if (myAction != DXIAction.New)
            {
                txtDari.Value = myFreeTemplateEntity.MemoFrom;
                txtCabang.Value = myFreeTemplateEntity.MemoBranch;
                DemoRichEdit.Open
                (
                    Guid.NewGuid().ToString(),
                    DocumentFormat.Doc,
                    () =>
                        {
                            byte[] docBytes = (byte[])myFreeTemplateEntity.DocBinary;
                            return new MemoryStream(docBytes);
                        }
                );
            }
            mmRemark.Value = myFreeTemplateEntity.Remark1;
        }
        private bool Save(DXISaveAction saveAction)
        {
            bool bSave = true;
            myDocName = "IM_FREE";
            myFreeTemplateEntity.DocNo = txtDocNo.Value;
            myFreeTemplateEntity.DocDate = deDocDate.Value;
            myFreeTemplateEntity.MemoFrom = txtDari.Value;
            myFreeTemplateEntity.MemoBranch = txtCabang.Value;
            myFreeTemplateEntity.NextApprover = "";
            myFreeTemplateEntity.Remark1 = mmRemark.Value;

            using (MemoryStream ms = new MemoryStream())
            {
                DemoRichEdit.SaveCopy(ms, DocumentFormat.Doc);
                byte[] arr = ms.ToArray();
                myFreeTemplateEntity.DocBinary = arr;
            }
            
            if (myAction == DXIAction.New)
            {
                myFreeTemplateEntity.CreatedBy = UserID;
                myFreeTemplateEntity.CreatedDateTime = myLocalDBSetting.GetServerTime();
                myFreeTemplateEntity.LastModifiedBy = UserID;
                myFreeTemplateEntity.LastModifiedDateTime = myLocalDBSetting.GetServerTime();
            }
            string strApprovalNote = "";
            if (myAction == DXIAction.Approve)
            {
                strApprovalNote = Convert.ToString(mmDecisionNote.Value);
            }
            myFreeTemplateEntity.Save(this.UserID, this.UserName, myDocName, saveAction, strApprovalNote);
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

        void NewDocument()
        {
            MemoryStream memoryStream = null;
            DemoRichEdit.Open("document" + Guid.NewGuid().ToString(), DocumentFormat.Doc, () => {
                RichEditDocumentServer server = new RichEditDocumentServer();
                server.Document.Sections[0].Page.Landscape = false;
                server.Document.Unit = DevExpress.Office.DocumentUnit.Millimeter;
                server.Document.Sections[0].Margins.Left = 1f;
                server.Document.Sections[0].Margins.Right = 1f;
                server.Document.Sections[0].Margins.Top = 2f;
                server.Document.Sections[0].Margins.Bottom = 2f;

                server.Document.DefaultCharacterProperties.FontName = "Calibri";
                server.Document.DefaultCharacterProperties.FontSize = 12f;
                server.Document.DefaultCharacterProperties.ForeColor = Color.AliceBlue;
                server.Document.AppendText("This content is created programmatically\n");
                server.Document.Paragraphs.Append();

                server.Document.Sections[0].Page.PaperKind = System.Drawing.Printing.PaperKind.A4;

                memoryStream = new MemoryStream();
                server.SaveDocument(memoryStream, DocumentFormat.Doc);
                return memoryStream.ToArray();
            });
            if (memoryStream != null)
                memoryStream.Dispose();

            //DemoRichEdit.Open(Server.MapPath(@"~\App_Data\IMFreeTemplate\DefaultTemplate\DefaultTemplateI.docx"));
        }

        protected void DemoRichEdit_PreRender(object sender, EventArgs e)
        {
            DemoRichEdit.Focus();
        }

        protected void DemoRichEdit_Init(object sender, EventArgs e)
        {
            ASPxRichEdit richEdit = (ASPxRichEdit)sender;
            richEdit.CreateDefaultRibbonTabs(true);
            //richEdit.RibbonTabs.Find(p => p.Text == "Mail Merge").Visible = false;
            //richEdit.Settings.Behavior.Open = DocumentCapability.Disabled;
            //richEdit.Settings.DocumentCapabilities.Hyperlinks = DocumentCapability.Hidden;
            //richEdit.Settings.DocumentCapabilities.InlinePictures = DocumentCapability.Hidden;

            richEdit.Settings.Behavior.CreateNew = DocumentCapability.Disabled;
            richEdit.Settings.Behavior.Open = DocumentCapability.Disabled;
            richEdit.Settings.Behavior.Save = DocumentCapability.Disabled;
            richEdit.Settings.Behavior.SaveAs = DocumentCapability.Disabled;
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

                myApprovalTable.Rows.Add(myFreeTemplateEntity.InternalFreeTemplateDBCommand.DtlAppKeyUniqueKey(),
                    myFreeTemplateEntity.DocKey, i,
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
        protected void gvApproval_CustomCallback(object sender, ASPxGridViewCustomCallbackEventArgs e)
        {

        }
        protected void gvApproval_AutoFilterCellEditorInitialize(object sender, ASPxGridViewEditorEventArgs e)
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

        protected void cplMain_Callback(object source, CallbackEventArgs e)
        {
            string urlsave = "";
            string[] callbackParam = e.Parameter.ToString().Split(';');
            urlsave = "~/Transaction/InternalMemo/FreeTemplate/FreeTemplateMaint.aspx";
            var nameValues = HttpUtility.ParseQueryString(Request.QueryString.ToString());
            nameValues.Set("DocKey", myFreeTemplateEntity.DocKey.ToString());
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
    }
}