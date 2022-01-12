using DevExpress.Web;
using DevExpress.Web.ASPxRichEdit;
using DevExpress.XtraRichEdit;
using DevExpress.XtraRichEdit.API.Native;
using DXMNCGUI_INFORMA.Controllers;
using DXMNCGUI_INFORMA.Controllers.Data;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DXMNCGUI_INFORMA.Transaction.InternalMemo
{
    public partial class InternalMemoEntry : BasePage
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
        protected InternalMemoDB myInternalMemoDB
        {
            get { isValidLogin(false); return (InternalMemoDB)HttpContext.Current.Session["myInternalMemoDB" + this.ViewState["_PageID"]]; }
            set { HttpContext.Current.Session["myInternalMemoDB" + this.ViewState["_PageID"]] = value; }
        }
        protected InternalMemoEntity myInternalMemoEntity
        {
            get { isValidLogin(false); return (InternalMemoEntity)HttpContext.Current.Session["myInternalMemoEntity" + this.ViewState["_PageID"]]; }
            set { HttpContext.Current.Session["myInternalMemoEntity" + this.ViewState["_PageID"]] = value; }
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
        protected DataTable myAgreementTable
        {
            get { isValidLogin(false); return (DataTable)HttpContext.Current.Session["myAgreementTable" + this.ViewState["_PageID"]]; }
            set { HttpContext.Current.Session["myAgreementTable" + this.ViewState["_PageID"]] = value; }
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
        protected DataTable myContractTable
        {
            get { isValidLogin(false); return (DataTable)HttpContext.Current.Session["myContractTable" + this.ViewState["_PageID"]]; }
            set { HttpContext.Current.Session["myContractTable" + this.ViewState["_PageID"]] = value; }
        }
        protected DataTable myBranchTable
        {
            get { isValidLogin(false); return (DataTable)HttpContext.Current.Session["myBranchTable" + this.ViewState["_PageID"]]; }
            set { HttpContext.Current.Session["myBranchTable" + this.ViewState["_PageID"]] = value; }
        }
        protected DataTable myDebiturTable
        {
            get { isValidLogin(false); return (DataTable)HttpContext.Current.Session["myDebiturTable" + this.ViewState["_PageID"]]; }
            set { HttpContext.Current.Session["myDebiturTable" + this.ViewState["_PageID"]] = value; }
        }
        protected DataTable myDetailAssetTable
        {
            get { isValidLogin(false); return (DataTable)HttpContext.Current.Session["myDetailAssetTable" + this.ViewState["_PageID"]]; }
            set { HttpContext.Current.Session["myDetailAssetTable" + this.ViewState["_PageID"]] = value; }
        }
        protected DataTable myDetailPelepasanCrossCollTable
        {
            get { isValidLogin(false); return (DataTable)HttpContext.Current.Session["myDetailPelepasanCrossCollTable" + this.ViewState["_PageID"]]; }
            set { HttpContext.Current.Session["myDetailPelepasanCrossCollTable" + this.ViewState["_PageID"]] = value; }
        }
        protected DataTable myDetailPendingGiroTable
        {
            get { isValidLogin(false); return (DataTable)HttpContext.Current.Session["myDetailPendingGiroTable" + this.ViewState["_PageID"]]; }
            set { HttpContext.Current.Session["myDetailPendingGiroTable" + this.ViewState["_PageID"]] = value; }
        }
        protected DataTable myDetailPurchaseRequestTable
        {
            get { isValidLogin(false); return (DataTable)HttpContext.Current.Session["myDetailPurchaseRequestTable" + this.ViewState["_PageID"]]; }
            set { HttpContext.Current.Session["myDetailPurchaseRequestTable" + this.ViewState["_PageID"]] = value; }
        }
        protected DataTable myDetailBiayaBulananTable
        {
            get { isValidLogin(false); return (DataTable)HttpContext.Current.Session["myDetailBiayaBulananTable" + this.ViewState["_PageID"]]; }
            set { HttpContext.Current.Session["myDetailBiayaBulananTable" + this.ViewState["_PageID"]] = value; }
        }
        protected DataTable myDetailFreeTextTable
        {
            get { isValidLogin(false); return (DataTable)HttpContext.Current.Session["myDetailFreeTextTable" + this.ViewState["_PageID"]]; }
            set { HttpContext.Current.Session["myDetailFreeTextTable" + this.ViewState["_PageID"]] = value; }
        }
        protected DataTable myTempDetailAssetTable
        {
            get { isValidLogin(false); return (DataTable)HttpContext.Current.Session["myTempDetailAssetTable" + this.ViewState["_PageID"]]; }
            set { HttpContext.Current.Session["myTempDetailAssetTable" + this.ViewState["_PageID"]] = value; }
        }
        protected DataTable myApprovalTable
        {
            get { isValidLogin(false); return (DataTable)HttpContext.Current.Session["myApprovalTable" + this.ViewState["_PageID"]]; }
            set { HttpContext.Current.Session["myApprovalTable" + this.ViewState["_PageID"]] = value; }
        }
        protected DataTable myUploadDocTable
        {
            get { isValidLogin(false); return (DataTable)HttpContext.Current.Session["myUploadDocTable" + this.ViewState["_PageID"]]; }
            set { HttpContext.Current.Session["myUploadDocTable" + this.ViewState["_PageID"]] = value; }
        }
        protected DataTable myApprovalHistoryTable
        {
            get { isValidLogin(false); return (DataTable)HttpContext.Current.Session["myApprovalHistoryTable" + this.ViewState["_PageID"]]; }
            set { HttpContext.Current.Session["myApprovalHistoryTable" + this.ViewState["_PageID"]] = value; }
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
        protected string myAgreeNo
        {
            get { isValidLogin(false); return (string)HttpContext.Current.Session["myAgreeNo" + this.ViewState["_PageID"]]; }
            set { HttpContext.Current.Session["myAgreeNo" + this.ViewState["_PageID"]] = value; }
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
        protected string strRitchEditorKey
        {
            get { isValidLogin(false); return (string)HttpContext.Current.Session["strRitchEditorKey" + this.ViewState["_PageID"]]; }
            set { HttpContext.Current.Session["strRitchEditorKey" + this.ViewState["_PageID"]] = value; }
        }
        public List<int> MergedIndexList = new List<int>();

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
                    this.myInternalMemoDB = InternalMemoDB.Create(myDBSetting, myLocalDBSetting, myDBSession);
                    this.myInternalMemoEntity = this.myInternalMemoDB.View(Convert.ToInt32(this.Request.QueryString["SourceKey"]), Convert.ToString(this.Request.QueryString["DocNo"]), Convert.ToString(this.Request.QueryString["DebiturName"]), myAction);
                }
                myds = new DataSet();
                myContractTable = new DataTable();
                myDebiturTable = new DataTable();
                myDetailAssetTable = new DataTable();
                myDetailPelepasanCrossCollTable = new DataTable();
                myDetailPendingGiroTable = new DataTable();
                myDetailPurchaseRequestTable = new DataTable();
                myDetailBiayaBulananTable = new DataTable();
                myDetailFreeTextTable = new DataTable();
                myTempDetailAssetTable = new DataTable();
                myApprovalTable = new DataTable();
                myUploadDocTable = new DataTable();
                myApprovalHistoryTable = new DataTable();
                myBranchTable = new DataTable();
                myFs = new MemoryStream();

                this.myInternalMemoDB = InternalMemoDB.Create(myDBSetting, myLocalDBSetting, myDBSession);
                strKey = Request.QueryString["Key"];
                SetApplication((InternalMemoEntity)HttpContext.Current.Session["myInternalMemoEntity" + strKey]);

                if (Convert.ToInt32(this.Request.QueryString["ID"]) != 0)
                {
                    SqlConnection myconn = new SqlConnection(ConfigurationManager.ConnectionStrings["SqlLocalConnectionString"].ConnectionString);
                    SqlCommand sqlCommand = new SqlCommand("SELECT * FROM [SSS].[dbo].[DocumentFile] WHERE ID=@ID", myconn);
                    sqlCommand.Parameters.AddWithValue("@ID", Convert.ToInt32(this.Request.QueryString["ID"]));
                    myconn.Open();
                    SqlDataReader dr = sqlCommand.ExecuteReader();
                    if (dr.Read())
                    {
                        HttpContext.Current.Response.Clear();
                        HttpContext.Current.Response.Buffer = true;
                        HttpContext.Current.Response.ContentType = dr["Type"].ToString() + dr["Ext"].ToString();
                        HttpContext.Current.Response.AddHeader("content-disposition", "attachment;filename=" + dr["Name"].ToString() + dr["AppNo"].ToString() + dr["Ext"].ToString());
                        HttpContext.Current.Response.Charset = "";
                        HttpContext.Current.Response.Cache.SetCacheability(HttpCacheability.NoCache);
                        HttpContext.Current.Response.BinaryWrite((byte[])dr["FileDoc"]);
                        HttpContext.Current.Response.Flush();
                        HttpContext.Current.Response.End();
                    }
                    myconn.Close();
                }
            }
            if (!IsCallback)
            {

            }
        }
        private void SetApplication(InternalMemoEntity InternalMemoEntity)
        {
            if (this.myInternalMemoEntity != InternalMemoEntity)
            {
                if (InternalMemoEntity != null)
                {
                    this.myInternalMemoEntity = InternalMemoEntity;
                }

                switch (Convert.ToInt32(myInternalMemoEntity.DocValue))
                {
                    case 1:
                        DocValueDesc = "PEMAKAIAN CASH COLLATERAL";
                        break;
                    case 2:
                        DocValueDesc = "PELEPASAN CROSS COLLATERAL";
                        break;
                    case 3:
                        DocValueDesc = "PENDING GIRO";
                        break;
                    case 4:
                        DocValueDesc = "PERMOHONAN PENGADAAN BARANG & JASA";
                        break;
                    case 5:
                        DocValueDesc = "BIAYA BULANAN";
                        break;
                    case 7:
                        DocValueDesc = "FREE TEXT MEMO";
                        HiddenField["isFreeText"] = "1";
                        //lblDocNo.Text = GenerateDocNumb();
                        break;
                }

                iDocValue = Convert.ToInt32(this.myInternalMemoEntity.DocValue);
                myAction = this.myInternalMemoEntity.Action;
                myDocType = this.myInternalMemoEntity.DocType;
                myds = myInternalMemoEntity.myDataSet;
                myStatus = this.myInternalMemoEntity.Status.ToString();

                myHeaderTable = myds.Tables["Header"];
                myDetailAssetTable = myds.Tables["DetailPemakaianCashColl"];
                myDetailPelepasanCrossCollTable = myds.Tables["DetailPelepasanCrossColl"];
                myDetailPendingGiroTable = myds.Tables["DetailPendingGiro"];
                myDetailPurchaseRequestTable = myds.Tables["DetailPurchaseRequest"];
                myDetailBiayaBulananTable = myds.Tables["DetailBiayaBulanan"];
                myDetailFreeTextTable = myds.Tables["DetailFreeText"];
                myApprovalTable = myds.Tables["Approval"];
                myUploadDocTable = myds.Tables["UploadDoc"];
                myApprovalHistoryTable = myds.Tables["ApprovalHistory"];
                myds.Tables[1].DefaultView.Sort = "Seq";

                gvDetailCashColl.DataSource = myDetailAssetTable;
                gvDetailCashColl.DataBind();

                gvDetailCrossColl.DataSource = myDetailPelepasanCrossCollTable;
                gvDetailCrossColl.DataBind();

                gvDetailPendingGiro.DataSource = myDetailPendingGiroTable;
                gvDetailPendingGiro.DataBind();

                gvPurchaseRequest.DataSource = myDetailPurchaseRequestTable;
                gvPurchaseRequest.DataBind();

                gvBiayaBulanan.DataSource = myDetailBiayaBulananTable;
                gvBiayaBulanan.DataBind();

                gvApproval.DataSource = myApprovalTable;
                gvApproval.DataBind();

                gvUploadDoc.DataSource = myUploadDocTable;
                gvUploadDoc.DataBind();

                gvPendGiroHist.DataSource = myApprovalHistoryTable;
                gvPendGiroHist.DataBind();

                deTglPengajuanSebelumnya.Value = myDBSetting.GetServerTime();

                setuplookupedit();
                BindingMaster();
                Accessable();
            }
        }
        private void setuplookupedit()
        {
            txtDari.Value = this.UserID.Trim() + " - " + this.UserName.Trim();

            object obj = dbsetting.ExecuteScalar("select top 1 b.C_NAME from SYS_TBLEMPLOYEE a inner join SYS_COMPANY b on a.C_CODE=b.C_CODE WHERE a.CODE=?", this.UserID);
            if (obj != null && obj != DBNull.Value)
            {
                txtCabang.Value = obj;
            }

            //myBranchTable = myInternalMemoDB.LoadDataBranch(this.UserID.Trim());
            //luCabang.DataSource = myBranchTable;
            //luCabang.DataBind();

            //object obj = dbsetting.ExecuteScalar("select top 1 b.C_CODE from SYS_TBLEMPLOYEE a inner join SYS_COMPANY b on a.C_CODE=b.C_CODE WHERE a.CODE=?", this.UserID);
            //if (obj != null && obj != DBNull.Value)
            //{
            //    luCabang.Value = obj;
            //}

            deTanggal.Value = myDBSetting.GetServerTime();

            myContractTable = myInternalMemoDB.LoadDataKontrak();
            luKontrakNo.DataSource = myContractTable;
            luKontrakNo.DataBind();

            myDebiturTable = myInternalMemoDB.LoadDataDebitur();
        }
        private void Accessable()
        {
            txtMemo.ReadOnly = true;
            txtMemo.BackColor = System.Drawing.ColorTranslator.FromHtml("#f0f0f0");

            txtStatus.ReadOnly = true;
            txtStatus.BackColor = System.Drawing.ColorTranslator.FromHtml("#f0f0f0");

            txtDari.ReadOnly = true;
            txtDari.BackColor = System.Drawing.ColorTranslator.FromHtml("#f0f0f0");

            txtCabang.ReadOnly = true;
            txtCabang.BackColor = System.Drawing.ColorTranslator.FromHtml("#f0f0f0");

            txtDebitur.ReadOnly = true;
            txtDebitur.BackColor = System.Drawing.ColorTranslator.FromHtml("#f0f0f0");

            txtCIF.ReadOnly = true;
            txtCIF.BackColor = System.Drawing.ColorTranslator.FromHtml("#f0f0f0");

            mmAlamat.ReadOnly = true;
            mmAlamat.BackColor = System.Drawing.ColorTranslator.FromHtml("#f0f0f0");

            seAngsuran.ReadOnly = true;
            seAngsuran.BackColor = System.Drawing.ColorTranslator.FromHtml("#f0f0f0");

            switch (iDocValue)
            {
                case 1:
                    FormLayout.FindItemOrGroupByName("lgDetailAssetCashColl").Visible = true;
                    break;
                case 2:
                    FormLayout.FindItemOrGroupByName("lgDetailAssetCrossColl").Visible = true;
                    FormLayout.FindItemOrGroupByName("liNoKontrak").Visible = false;
                    break;
                case 3:
                    FormLayout.FindItemOrGroupByName("lgDetailPendingGiro").Visible = true;
                    FormLayout.FindItemOrGroupByName("lgDetailPendGiroHist").Visible = true;
                    FormLayout.FindItemOrGroupByName("liNoKontrak").Visible = false;
                    break;
                case 4:
                    FormLayout.FindItemOrGroupByName("lgDetailPurchaseRequest").Visible = true;
                    FormLayout.FindItemOrGroupByName("liNoKontrak").Visible = false;
                    break;
                case 5:
                    FormLayout.FindItemOrGroupByName("lgDetailBiayaBulanan").Visible = true;
                    FormLayout.FindItemOrGroupByName("liNoKontrak").Visible = false;
                    break;
                case 7:
                    FormLayout.FindItemOrGroupByName("lgFreeTextMemo").Visible = true;
                    FormLayout.FindItemOrGroupByName("liNoKontrak").Visible = false;
                    deTanggal.ReadOnly = true;
                    deTanggal.BackColor = System.Drawing.ColorTranslator.FromHtml("#f0f0f0");
                    
                    break;
            }

            if (myAction == DXIAction.New)
            {
                gvApproval.Columns["colNo"].Visible = false;
                gvDetailPendingGiro.Columns["colNo"].Visible = false;
                gvPurchaseRequest.Columns["colNo"].Visible = false;
                gvBiayaBulanan.Columns["colNo"].Visible = false;

                HiddenField["FreeTextViewMode"] = "New";
            }
            if (myAction == DXIAction.View || myAction == DXIAction.Approve || Convert.ToString(myInternalMemoEntity.Status) == "APPROVE" || Convert.ToString(myInternalMemoEntity.Status) == "REJECT")
            {
                FormLayout.FindItemOrGroupByName("lgDetailUploadDoc").Visible = true;

                gvApproval.Columns["ClmnCommand"].Visible = false;
                gvDetailPendingGiro.Columns["ClmnCommand"].Visible = false;
                gvPurchaseRequest.Columns["ClmnCommand"].Visible = false;
                gvBiayaBulanan.Columns["ClmnCommand"].Visible = false;

                lblDocNo.Visible = true;

                txtKepada.ReadOnly = true;
                txtKepada.BackColor = System.Drawing.ColorTranslator.FromHtml("#f0f0f0");

                txtTembusan.ReadOnly = true;
                txtTembusan.BackColor = System.Drawing.ColorTranslator.FromHtml("#f0f0f0");

                deTanggal.ReadOnly = true;
                deTanggal.BackColor = System.Drawing.ColorTranslator.FromHtml("#f0f0f0");

                mmPerihal.ReadOnly = true;
                mmPerihal.BackColor = System.Drawing.ColorTranslator.FromHtml("#f0f0f0");

                luKontrakNo.ReadOnly = true;
                luKontrakNo.BackColor = System.Drawing.ColorTranslator.FromHtml("#f0f0f0");

                txtCabang.ReadOnly = true;
                txtCabang.BackColor = System.Drawing.ColorTranslator.FromHtml("#f0f0f0");

                //luCabang.ReadOnly = true;
                //luCabang.BackColor = System.Drawing.ColorTranslator.FromHtml("#f0f0f0");

                mmBackground.ReadOnly = true;
                mmBackground.BackColor = System.Drawing.ColorTranslator.FromHtml("#f0f0f0");

                mmCostAndBenefit.ReadOnly = true;
                mmCostAndBenefit.BackColor = System.Drawing.ColorTranslator.FromHtml("#f0f0f0");

                txtNoSuratDebitur.ReadOnly = true;
                txtNoSuratDebitur.BackColor = System.Drawing.ColorTranslator.FromHtml("#f0f0f0");

                txtTolakanKe.ReadOnly = true;
                txtTolakanKe.BackColor = System.Drawing.ColorTranslator.FromHtml("#f0f0f0");

                deTglPengajuanSebelumnya.ReadOnly = true;
                deTglPengajuanSebelumnya.BackColor = System.Drawing.ColorTranslator.FromHtml("#f0f0f0");

                mmAlasanPenundaan.ReadOnly = true;
                mmAlasanPenundaan.BackColor = System.Drawing.ColorTranslator.FromHtml("#f0f0f0");

                txtBiayaBulananPVNo.ReadOnly = true;
                txtBiayaBulananPVNo.BackColor = System.Drawing.ColorTranslator.FromHtml("#f0f0f0");

                mmBiayaBulananHeader.ReadOnly = true;
                mmBiayaBulananHeader.BackColor = System.Drawing.ColorTranslator.FromHtml("#f0f0f0");

                mmBiayaBulananFooter.ReadOnly = true;
                mmBiayaBulananFooter.BackColor = System.Drawing.ColorTranslator.FromHtml("#f0f0f0");


                reTemplate.RibbonMode = RichEditRibbonMode.None;
                reTemplate.Settings.HorizontalRuler.Visibility = RichEditRulerVisibility.Hidden;
                //reMemo.ReadOnly = true;
                //reMemo.EnableViewState = false;

                HiddenField["FreeTextViewMode"] = "View";
                //reMemo.Visible = false;
                //reTemplate.Visible = true;

                if (iDocValue == 7)
                {
                    btnExportPDF.Visible = true;
                    btnSave.BackColor = System.Drawing.ColorTranslator.FromHtml("#f0f0f0");
                    btnSave.Enabled = false;
                }

            }
            if (myAction == DXIAction.Edit)
            {
                gvApproval.Columns["ClmnCommand"].Visible = false;
                gvDetailPendingGiro.Columns["ClmnCommand"].Visible = false;
                gvPurchaseRequest.Columns["ClmnCommand"].Visible = false;
                gvBiayaBulanan.Columns["ClmnCommand"].Visible = false;

                HiddenField["FreeTextViewMode"] = "Edit";
                //reMemo.Visible = true;
                //reTemplate.Visible = false;
            }
            if (myAction == DXIAction.Approve)
            {
                btnReject.ClientVisible = true;
                btnApprove.ClientVisible = true;
            }
        }
        private void BindingMaster()
        {
            txtMemo.Value = DocValueDesc;
            txtStatus.Value = myInternalMemoEntity.Status;
            if (myAction != DXIAction.New)
            {
                lblDocNo.Value = myInternalMemoEntity.DocNo;
                txtKepada.Value = myInternalMemoEntity.MemoTo;
                txtTembusan.Value = myInternalMemoEntity.MemoCC;
                txtDari.Value = myInternalMemoEntity.MemoFrom;

                txtCabang.Value = myInternalMemoEntity.MemoBranch;
                //luCabang.Text = myInternalMemoEntity.MemoBranch.ToString();


                deTanggal.Value = myInternalMemoEntity.DocDate;
                mmPerihal.Value = myInternalMemoEntity.MemoPerihal;

                switch (iDocValue)
                {
                    case 1:
                        luKontrakNo.Value = myInternalMemoEntity.MemoRefNo;
                        txtCIF.Value = myInternalMemoEntity.DebiturCIF;
                        txtDebitur.Value = myInternalMemoEntity.DebiturName;
                        mmAlamat.Value = myInternalMemoEntity.DebiturAddress;
                        seAngsuran.Value = myInternalMemoEntity.DebiturAngsuran;
                        mmBackground.Value = myInternalMemoEntity.BackgroundText;
                        mmCostAndBenefit.Value = myInternalMemoEntity.CostBenefitAnalysisText;
                        break;
                    case 2:
                        mmHeader.Value = myInternalMemoEntity.HeaderText;
                        mmFooter.Value = myInternalMemoEntity.FooterText;
                        break;
                    case 3:
                        txtNoSuratDebitur.Value = myInternalMemoEntity.MemoRefNo;
                        txtTolakanKe.Value = myInternalMemoEntity.GiroTolakanKe;
                        deTglPengajuanSebelumnya.Value = myInternalMemoEntity.GiroPreviousApplyDate;
                        mmAlasanPenundaan.Value = myInternalMemoEntity.GiroReason;
                        break;
                    case 4:
                        break;
                    case 5:
                        txtBiayaBulananPVNo.Value = myInternalMemoEntity.MemoRefNo;
                        mmBiayaBulananHeader.Value = myInternalMemoEntity.HeaderText;
                        mmBiayaBulananFooter.Value = myInternalMemoEntity.FooterText;
                        break;
                    case 7:
                        //LoadApprovalFreeText(myInternalMemoEntity.DocKey.ToString());

                        break;
                }
            }
        }
        private bool Save(DXISaveAction saveAction)
        {
            bool bSave = true;
            myDocName = "IM";

            myInternalMemoEntity.MemoTo = txtKepada.Value;
            myInternalMemoEntity.MemoCC = txtTembusan.Value;
            myInternalMemoEntity.MemoFrom = txtDari.Value;
            myInternalMemoEntity.MemoBranch = txtCabang.Value;
            //myInternalMemoEntity.MemoBranch = luCabang.Text;
            myInternalMemoEntity.DocDate = deTanggal.Value;
            myInternalMemoEntity.MemoPerihal = mmPerihal.Value.ToString().ToUpper();
            myInternalMemoEntity.NextApprover = "";

            switch (iDocValue)
            {
                case 1:
                    myTempDetailAssetTable.TableName = "MyTempDetailPemakaianCashColl";
                    myds.Tables.Add(myTempDetailAssetTable);

                    myInternalMemoEntity.MemoRefNo = luKontrakNo.Value;
                    myInternalMemoEntity.DebiturCIF = txtCIF.Value;
                    myInternalMemoEntity.DebiturName = txtDebitur.Value;
                    myInternalMemoEntity.DebiturAddress = mmAlamat.Value;
                    myInternalMemoEntity.DebiturAngsuran = seAngsuran.Value;
                    myInternalMemoEntity.BackgroundText = mmBackground.Value;
                    myInternalMemoEntity.CostBenefitAnalysisText = mmCostAndBenefit.Value;
                    break;
                case 2:
                    myInternalMemoEntity.HeaderText = mmHeader.Value;
                    myInternalMemoEntity.FooterText = mmFooter.Value;
                    break;
                case 3:
                    myInternalMemoEntity.MemoRefNo = txtNoSuratDebitur.Value;
                    myInternalMemoEntity.GiroTolakanKe = txtTolakanKe.Value;
                    myInternalMemoEntity.GiroPreviousApplyDate = deTglPengajuanSebelumnya.Value;
                    myInternalMemoEntity.GiroReason = mmAlasanPenundaan.Value;
                    break;
                case 4:
                    break;
                case 5:
                    myInternalMemoEntity.MemoRefNo = txtBiayaBulananPVNo.Value;
                    myInternalMemoEntity.HeaderText = mmBiayaBulananHeader.Value;
                    myInternalMemoEntity.FooterText = mmBiayaBulananFooter.Value;
                    break;
                case 7:
                    reTemplate.SaveCopy(myFs, DocumentFormat.Rtf);
                    byte[] arr = myFs.ToArray();
                    
                    if (myAction == DXIAction.New)
                    {
                        myDetailFreeTextTable.Rows.Add(
                        myInternalMemoEntity.InternalMemoDBcommand.FreeTextDtlKeyUniqueKey(),
                        myInternalMemoEntity.DocKey,
                        0, arr);
                    }
                    else if(myAction == DXIAction.Edit)
                    {
                        if(Convert.ToString(myInternalMemoEntity.Status) == "APPROVE" || Convert.ToString(myInternalMemoEntity.Status) == "REJECT")
                        {
                            //myDetailFreeTextTable.Rows[0]["FreeTextFile"] = arr;
                        }else
                        {
                            myDetailFreeTextTable.Rows[0]["FreeTextFile"] = arr;
                        }
                    }

                    break;
            }
            if (myAction == DXIAction.New)
            {
                myInternalMemoEntity.CreatedBy = UserID;
                myInternalMemoEntity.CreatedDateTime = myLocalDBSetting.GetServerTime();
                myInternalMemoEntity.LastModifiedBy = UserID;
                myInternalMemoEntity.LastModifiedDateTime = myLocalDBSetting.GetServerTime();
            }
            string strApprovalNote = "";
            if (myAction == DXIAction.Approve)
            {
                strApprovalNote = Convert.ToString(mmDecisionNote.Value);
            }
            myInternalMemoEntity.Save(this.UserID, this.UserName, myDocName, saveAction, strApprovalNote);

            return bSave;
        }

        protected bool ErrorInField(out string strmessageError, DXISaveAction saveaction)
        {
            bool errorF = false;
            bool focusF = false;
            strmessageError = "";
            cplMain.JSProperties["cplActiveTabIndex"] = 0;
            switch (iDocValue)
            {
                case 1:
                    break;
                case 2:
                    if (myDetailPelepasanCrossCollTable.Rows.Count == 0)
                    {
                        errorF = true;
                        if (!focusF)
                        {
                            gvDetailCrossColl.Focus();
                            focusF = true;
                            strmessageError = "Please add Cross Coll detail, empty detail is not allowed.";
                            cplMain.JSProperties["cplActiveTabIndex"] = 1;
                        }
                    }
                    break;
                case 3:
                    if (myDetailPendingGiroTable.Rows.Count == 0)
                    {
                        errorF = true;
                        if (!focusF)
                        {
                            gvDetailPendingGiro.Focus();
                            focusF = true;
                            strmessageError = "Please add Pending Giro detail, empty detail is not allowed.";
                            cplMain.JSProperties["cplActiveTabIndex"] = 1;
                        }
                    }
                    break;
                case 4:
                    if (myDetailPurchaseRequestTable.Rows.Count == 0)
                    {
                        errorF = true;
                        if (!focusF)
                        {
                            gvPurchaseRequest.Focus();
                            focusF = true;
                            strmessageError = "Please add Purchase Request detail, empty detail is not allowed.";
                            cplMain.JSProperties["cplActiveTabIndex"] = 1;
                        }
                    }
                    break;
                case 5:
                    if (myDetailBiayaBulananTable.Rows.Count == 0)
                    {
                        errorF = true;
                        if (!focusF)
                        {
                            gvBiayaBulanan.Focus();
                            focusF = true;
                            strmessageError = "Please add Biaya Bulanan detail, empty detail is not allowed.";
                            cplMain.JSProperties["cplActiveTabIndex"] = 1;
                        }
                    }
                    break;
            }
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

            if(txtDari.Text.Length > 150)
            {
                errorF = true;
                if (!focusF)
                {
                    txtDari.Focus();
                    focusF = true;
                    strmessageError = "Input field Dari is more than 150 character.";
                }
            }

            if (txtKepada.Text.Length > 150)
            {
                errorF = true;
                if (!focusF)
                {
                    txtKepada.Focus();
                    focusF = true;
                    strmessageError = "Input field Kepada is more than 150 character.";
                }
            }

            if (mmPerihal.Text.Length > 150)
            {
                errorF = true;
                if (!focusF)
                {
                    mmPerihal.Focus();
                    focusF = true;
                    strmessageError = "Input field Perihal is more than 150 character.";
                }
            }
            return errorF;
        }

        protected void cplMain_Callback(object source, CallbackEventArgs e)
        {
            isValidLogin();
            string urlsave = "";
            string[] callbackParam = e.Parameter.ToString().Split(';');
            urlsave = "~/Transaction/InternalMemo/InternalMemoMaint.aspx";
            var nameValues = HttpUtility.ParseQueryString(Request.QueryString.ToString());
            nameValues.Set("DocKey", myInternalMemoEntity.DocKey.ToString());
            string updatedQueryString = "?" + nameValues.ToString();
            cplMain.JSProperties["cpCallbackParam"] = callbackParam[0].ToUpper();
            SqlDBSetting dbSetting = this.myDBSetting;
            SqlLocalDBSetting dbLocalSetting = this.myLocalDBSetting;
            string strmessageError = "";

            switch (callbackParam[0].ToUpper())
            {
                case "CONTRACT_ONCHANGE":
                    myTempDetailAssetTable.Clear();
                    myTempDetailAssetTable = myInternalMemoDB.LoadDataDetailAsset(Convert.ToString(luKontrakNo.Value));
                    foreach (DataColumn col in myTempDetailAssetTable.Columns)
                        col.ReadOnly = false;
                    foreach (DataRow dr in myTempDetailAssetTable.Rows)
                    {
                        DataRow[] ValidLinesRows = myTempDetailAssetTable.Select("", "Seq", DataViewRowState.Unchanged | DataViewRowState.Added | DataViewRowState.ModifiedCurrent);
                        int seq = SeqUtils.GetLastSeq(ValidLinesRows);

                        dr["DocKey"] = myInternalMemoEntity.DocKey;
                        dr["Seq"] = seq;
                        dr["IsApprove"] = "F";
                        dr["ApproveDate"] = DBNull.Value;
                    }
                    myDetailAssetTable = myTempDetailAssetTable;
                    gvDetailCashColl.DataSource = myTempDetailAssetTable;
                    gvDetailCashColl.DataBind();
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
                case "RETURN_CONFIRM":
                    cplMain.JSProperties["cplblmessageError"] = "";
                    cplMain.JSProperties["cplblmessage"] = "are you sure want to Return this memo to creator?";
                    cplMain.JSProperties["cplblActionButton"] = "RETURN";
                    if (ErrorInField(out strmessageError, DXISaveAction.Save))
                    {
                        cplMain.JSProperties["cplblmessageError"] = strmessageError;
                    }
                    break;
                case "RETURN":
                    //Save(DXISaveAction.Reject);
                    cplMain.JSProperties["cpAlertMessage"] = "Memo has been return to creator...";
                    cplMain.JSProperties["cplblActionButton"] = "RETURN";
                    ASPxWebControl.RedirectOnCallback(urlsave);
                    break;
                case "FREETEXT":
                    if (myAction == DXIAction.View || myAction == DXIAction.Approve || Convert.ToString(myInternalMemoEntity.Status) == "APPROVE" || Convert.ToString(myInternalMemoEntity.Status) == "REJECT")
                    {
                        reTemplate.ReadOnly = true;
                    }
                    break;
            }
        }

        protected void gvDetailCashColl_DataBinding(object sender, EventArgs e)
        {
            (sender as ASPxGridView).DataSource = myDetailAssetTable;
        }
        protected void gvDetailCashColl_CustomCallback(object sender, ASPxGridViewCustomCallbackEventArgs e)
        {

        }
        protected void gvDetailCashColl_CustomColumnDisplayText(object sender, ASPxGridViewColumnDisplayTextEventArgs e)
        {
            if (e.Column.Caption == "No")
            {
                e.DisplayText = (e.VisibleIndex + 1).ToString();
            }
        }

        protected void gvDetailCrossColl_RowInserting(object sender, DevExpress.Web.Data.ASPxDataInsertingEventArgs e)
        {
            string StrErrorMsg = "";
            if (e.NewValues["AgreementNo"] == null) throw new Exception("Column 'Agreement No.' is mandatory.");
            if (e.NewValues["AssetDesc"] == null) throw new Exception("Column 'Asset Description' is mandatory.");
            if (StrErrorMsg == "")
            {
                gvDetailCrossColl.JSProperties["cpCmd"] = "INSERT";

                int i = gvDetailCrossColl.VisibleRowCount;

                myDetailPelepasanCrossCollTable.Rows.Add(
                    myInternalMemoEntity.InternalMemoDBcommand.PelepasanCrossCollDtlKeyUniqueKey(),
                    myInternalMemoEntity.DocKey, i,
                    Convert.ToString(e.NewValues["AgreementNo"]),
                    Convert.ToString(e.NewValues["AssetDesc"]),
                    Double.Parse(Convert.ToString(e.NewValues["ValueAsset"])),
                    Double.Parse(Convert.ToString(e.NewValues["OSPH"])),
                    Convert.ToString(e.NewValues["CicilanTenor"]),
                    Double.Parse(Convert.ToString(e.NewValues["DendaBerjalan"]))
                    );

                ASPxGridView grid = sender as ASPxGridView;
                grid.CancelEdit();
                e.Cancel = true;
            }
        }
        protected void gvDetailCrossColl_RowUpdating(object sender, DevExpress.Web.Data.ASPxDataUpdatingEventArgs e)
        {
            string StrErrorMsg = "";
            if (e.NewValues["AgreementNo"] == null) throw new Exception("Column 'Agreement No.' is mandatory.");
            if (e.NewValues["AssetDesc"] == null) throw new Exception("Column 'Asset Description' is mandatory.");

            if (StrErrorMsg == "")
            {
                gvDetailCrossColl.JSProperties["cpCmd"] = "UPDATE";
                int editingRowVisibleIndex = gvDetailCrossColl.EditingRowVisibleIndex;
                int id = (int)gvDetailCrossColl.GetRowValues(editingRowVisibleIndex, "DtlKey");
                DataRow dr = myDetailPelepasanCrossCollTable.Rows.Find(id);

                dr["AgreementNo"] = Convert.ToString(e.NewValues["AgreementNo"]);
                dr["AssetDesc"] = Convert.ToString(e.NewValues["AssetDesc"]);
                dr["ValueAsset"] = Double.Parse(Convert.ToString(e.NewValues["ValueAsset"]));
                dr["OSPH"] = Double.Parse(Convert.ToString(e.NewValues["OSPH"]));
                dr["CicilanTenor"] = Convert.ToString(e.NewValues["CicilanTenor"]);
                dr["DendaBerjalan"] = Double.Parse(Convert.ToString(e.NewValues["DendaBerjalan"]));

                ASPxGridView grid = sender as ASPxGridView;
                grid.CancelEdit();
                e.Cancel = true;
            }
        }
        protected void gvDetailCrossColl_RowDeleting(object sender, DevExpress.Web.Data.ASPxDataDeletingEventArgs e)
        {
            gvDetailCrossColl.JSProperties["cpCmd"] = "DELETE";
            int id = (int)e.Keys["DtlKey"];
            DataRow dr = myDetailPelepasanCrossCollTable.Rows.Find(id);

            myDetailPelepasanCrossCollTable.Rows.Remove(dr);

            ASPxGridView grid = sender as ASPxGridView;
            grid.CancelEdit();
            e.Cancel = true;
        }
        protected void gvDetailCrossColl_DataBinding(object sender, EventArgs e)
        {
            (sender as ASPxGridView).DataSource = myds.Tables["DetailPelepasanCrossColl"];
        }
        protected void gvDetailCrossColl_CustomCallback(object sender, ASPxGridViewCustomCallbackEventArgs e)
        {
            isValidLogin(false);
            myAgreeNo = "";
            string[] callbackParam = e.Parameters.ToString().Split(';');
            (sender as ASPxGridView).JSProperties["cpCallbackParam"] = callbackParam[0].ToUpper();
            object paramName = callbackParam[0].ToUpper();
            object paramValue = callbackParam[1];
            switch (callbackParam[0].ToUpper())
            {
                case "ON_AGREEMENT_CHANGED":
                    myAgreeNo = Convert.ToString(paramValue);
                    break;
            }
        }
        protected void gvDetailCrossColl_CellEditorInitialize(object sender, ASPxGridViewEditorEventArgs e)
        {
            ASPxGridView gridView = sender as ASPxGridView;
            if (e.Column.FieldName == "AgreementNo")
            {
                isValidLogin(false);
                if (Page.IsCallback)
                {
                    DataTable myitem = new DataTable();
                    myitem = myInternalMemoDB.LoadDataKontrak();
                    ASPxComboBox cmb = (ASPxComboBox)e.Editor;
                    cmb.DataSource = myitem;
                    cmb.DataBindItems();
                }
            }

            if (gvDetailCrossColl.IsEditing && e.Column.FieldName == "AssetDesc")
            {
                ASPxComboBox comboboxAssetDesc = e.Editor as ASPxComboBox;
                comboboxAssetDesc.Callback += comboboxAssetDesc_OnCallback;
                comboboxAssetDesc.DataSourceID = null;
                comboboxAssetDesc.Items.Clear();

                if (e.KeyValue != DBNull.Value && e.KeyValue != null)
                {
                    var currentagreementno = gridView.GetRowValuesByKeyValue(e.KeyValue, "AgreementNo");
                    if (currentagreementno != null && currentagreementno != DBNull.Value)
                    {
                        FillAssetDescCombo(comboboxAssetDesc, currentagreementno.ToString());
                    }
                }
            }
        }
        protected void FillAssetDescCombo(ASPxComboBox cmb, string agreementno)
        {
            if (string.IsNullOrEmpty(agreementno)) return;

            cmb.DataSourceID = null;
            cmb.DataSource = myDBSetting.GetDataTable("SELECT Description FROM [dbo].[LS_ASSETVEHICLE] WHERE LSAGREE=?", false, agreementno);
            cmb.DataBindItems();
        }
        void comboboxAssetDesc_OnCallback(object source, CallbackEventArgsBase e)
        {
            FillAssetDescCombo(source as ASPxComboBox, e.Parameter);
        }

        protected void luKontrakNo_DataBinding(object sender, EventArgs e)
        {
            (sender as ASPxGridLookup).DataSource = myContractTable;
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

                myApprovalTable.Rows.Add(myInternalMemoEntity.InternalMemoDBcommand.DtlAppKeyUniqueKey(),
                    myInternalMemoEntity.DocKey, i,
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
        protected void gvApproval_CustomColumnDisplayText(object sender, ASPxGridViewColumnDisplayTextEventArgs e)
        {
            if (e.Column.Caption == "No")
            {
                e.DisplayText = (e.VisibleIndex + 1).ToString();
            }
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

        protected void btnBack_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Transaction/InternalMemo/InternalMemoMaint.aspx");
        }

        protected void gvDetailPendingGiro_DataBinding(object sender, EventArgs e)
        {
            (sender as ASPxGridView).DataSource = myds.Tables["DetailPendingGiro"];
        }
        protected void gvDetailPendingGiro_RowInserting(object sender, DevExpress.Web.Data.ASPxDataInsertingEventArgs e)
        {
            string StrErrorMsg = "";
            if (e.NewValues["AgreementNo"] == null) throw new Exception("Column 'Agreement No' is mandatory.");
            if (StrErrorMsg == "")
            {
                gvApproval.JSProperties["cpCmd"] = "INSERT";

                int i = gvDetailPendingGiro.VisibleRowCount;

                myDetailPendingGiroTable.Rows.Add(
                    myInternalMemoEntity.InternalMemoDBcommand.PendingGiroDtlKeyUniqueKey(),
                    myInternalMemoEntity.DocKey,
                    i,
                    Convert.ToString(e.NewValues["NamaDebitur"]),
                    Convert.ToString(e.NewValues["AgreementNo"]),
                    Convert.ToString(e.NewValues["NamaBank"]),
                    Convert.ToString(e.NewValues["NoGiro"]),
                    Double.Parse(Convert.ToString(e.NewValues["NominalGiro"])),
                    Convert.ToString(e.NewValues["AngsuranDariKe"]),
                    DateTime.Parse(Convert.ToString(e.NewValues["TglJatuhTempo"])),
                    Double.Parse(Convert.ToString(e.NewValues["LamaPenundaan"])),
                    DateTime.Parse(Convert.ToString(e.NewValues["TglDiJalankanKembali"]))
                    );

                ASPxGridView grid = sender as ASPxGridView;
                grid.CancelEdit();
                e.Cancel = true;
            }
        }
        protected void gvDetailPendingGiro_RowUpdating(object sender, DevExpress.Web.Data.ASPxDataUpdatingEventArgs e)
        {
            string StrErrorMsg = "";
            if (e.NewValues["AgreementNo"] == null) throw new Exception("Column 'Agreement No.' is mandatory.");

            if (StrErrorMsg == "")
            {
                gvDetailPendingGiro.JSProperties["cpCmd"] = "UPDATE";
                int editingRowVisibleIndex = gvDetailPendingGiro.EditingRowVisibleIndex;
                int id = (int)gvDetailPendingGiro.GetRowValues(editingRowVisibleIndex, "DtlKey");
                DataRow dr = myDetailPendingGiroTable.Rows.Find(id);

                dr["NamaDebitur"] = Convert.ToString(e.NewValues["NamaDebitur"]);
                dr["AgreementNo"] = Convert.ToString(e.NewValues["AgreementNo"]);
                dr["NamaBank"] = Convert.ToString(e.NewValues["NamaBank"]);
                dr["NoGiro"] = Convert.ToString(e.NewValues["NoGiro"]);
                dr["NominalGiro"] = Double.Parse(Convert.ToString(e.NewValues["NominalGiro"]));
                dr["AngsuranDariKe"] = Convert.ToString(e.NewValues["AngsuranDariKe"]);
                dr["TglJatuhTempo"] = DateTime.Parse(Convert.ToString(e.NewValues["TglJatuhTempo"]));
                dr["LamaPenundaan"] = Double.Parse(Convert.ToString(e.NewValues["LamaPenundaan"]));
                dr["TglDiJalankanKembali"] = DateTime.Parse(Convert.ToString(e.NewValues["TglDiJalankanKembali"]));

                ASPxGridView grid = sender as ASPxGridView;
                grid.CancelEdit();
                e.Cancel = true;
            }
        }
        protected void gvDetailPendingGiro_RowDeleting(object sender, DevExpress.Web.Data.ASPxDataDeletingEventArgs e)
        {
            gvDetailPendingGiro.JSProperties["cpCmd"] = "DELETE";
            int id = (int)e.Keys["DtlKey"];
            DataRow dr = myDetailPendingGiroTable.Rows.Find(id);

            myDetailPendingGiroTable.Rows.Remove(dr);

            ASPxGridView grid = sender as ASPxGridView;
            grid.CancelEdit();
            e.Cancel = true;
        }
        protected void gvDetailPendingGiro_CustomCallback(object sender, ASPxGridViewCustomCallbackEventArgs e)
        {

        }
        protected void gvDetailPendingGiro_CustomColumnDisplayText(object sender, ASPxGridViewColumnDisplayTextEventArgs e)
        {
            if (e.Column.Caption == "No")
            {
                e.DisplayText = (e.VisibleIndex + 1).ToString();
            }
        }
        protected void gvDetailPendingGiro_CellEditorInitialize(object sender, ASPxGridViewEditorEventArgs e)
        {
            ASPxGridView gridView = sender as ASPxGridView;
            if (e.Column.FieldName == "AgreementNo")
            {
                isValidLogin(false);
                if (Page.IsCallback)
                {
                    DataTable myitem = new DataTable();
                    myitem = myInternalMemoDB.LoadDataKontrak();
                    ASPxComboBox cmb = (ASPxComboBox)e.Editor;
                    cmb.DataSource = myitem;
                    cmb.DataBindItems();
                }
            }

            if (gvDetailPendingGiro.IsEditing && e.Column.FieldName == "NoGiro")
            {
                ASPxComboBox comboboxNoGiro = e.Editor as ASPxComboBox;
                comboboxNoGiro.Callback += comboboxNoGiro_OnCallback;
                comboboxNoGiro.DataSourceID = null;
                comboboxNoGiro.Items.Clear();

                if (e.KeyValue != DBNull.Value && e.KeyValue != null)
                {
                    var currentagreementno = gridView.GetRowValuesByKeyValue(e.KeyValue, "AgreementNo");
                    if (currentagreementno != null && currentagreementno != DBNull.Value)
                    {
                        FillGiroNoCombo(comboboxNoGiro, currentagreementno.ToString());
                    }
                }
            }
        }
        protected void FillGiroNoCombo(ASPxComboBox cmb, string agreementno)
        {
            if (string.IsNullOrEmpty(agreementno)) return;

            cmb.DataSourceID = null;
            cmb.DataSource = myDBSetting.GetDataTable(@"select B.CHEQNO, B.CHEQBANKPDC, B.CHEQAMOUNT, B.EFFECT_DATE as CHEQDATE from ACC_PDCLEASING_REGIS A
                                                            inner join ACC_PDCLEASING B on A.REGIS_NO=B.REGIS_NO and A.C_CODE=B.C_CODE
                                                            where a.LSAGREE=?", false, agreementno);
            cmb.DataBindItems();
        }
        void comboboxNoGiro_OnCallback(object source, CallbackEventArgsBase e)
        {
            FillGiroNoCombo(source as ASPxComboBox, e.Parameter);
        }

        protected void gvPurchaseRequest_DataBinding(object sender, EventArgs e)
        {
            (sender as ASPxGridView).DataSource = myds.Tables["DetailPurchaseRequest"];
        }
        protected void gvPurchaseRequest_RowInserting(object sender, DevExpress.Web.Data.ASPxDataInsertingEventArgs e)
        {
            string StrErrorMsg = "";
            if (e.NewValues["NamaBarang"] == null) throw new Exception("Column 'Nama Barang' is mandatory.");
            if (e.NewValues["Kategori"] == null) throw new Exception("Column 'Kategori' is mandatory.");
            if (e.NewValues["Qty"] == null) throw new Exception("Column 'Jumlah' is mandatory.");
            if (e.NewValues["Spesifikasi"] == null) throw new Exception("Column 'Spesifikasi' is mandatory.");
            if (StrErrorMsg == "")
            {
                gvPurchaseRequest.JSProperties["cpCmd"] = "INSERT";

                int i = gvPurchaseRequest.VisibleRowCount;

                myDetailPurchaseRequestTable.Rows.Add(
                    myInternalMemoEntity.InternalMemoDBcommand.PurchaseRequestDtlKeyUniqeKey(),
                    myInternalMemoEntity.DocKey,
                    i,
                    Convert.ToString(e.NewValues["NamaBarang"]),
                    Convert.ToString(e.NewValues["Kategori"]),
                    Double.Parse(Convert.ToString(e.NewValues["Qty"])),
                    Convert.ToString(e.NewValues["Spesifikasi"]),
                    Convert.ToString(e.NewValues["Keterangan"]),
                    Convert.ToString(e.NewValues["IsBudget"])
                    );

                ASPxGridView grid = sender as ASPxGridView;
                grid.CancelEdit();
                e.Cancel = true;
            }
        }
        protected void gvPurchaseRequest_RowUpdating(object sender, DevExpress.Web.Data.ASPxDataUpdatingEventArgs e)
        {
            string StrErrorMsg = "";
            if (e.NewValues["NamaBarang"] == null) throw new Exception("Column 'Nama Barang' is mandatory.");
            if (e.NewValues["Kategori"] == null) throw new Exception("Column 'Kategori' is mandatory.");
            if (e.NewValues["Qty"] == null) throw new Exception("Column 'Jumlah' is mandatory.");
            if (e.NewValues["Spesifikasi"] == null) throw new Exception("Column 'Spesifikasi' is mandatory.");

            if (StrErrorMsg == "")
            {
                gvPurchaseRequest.JSProperties["cpCmd"] = "UPDATE";
                int editingRowVisibleIndex = gvPurchaseRequest.EditingRowVisibleIndex;
                int id = (int)gvPurchaseRequest.GetRowValues(editingRowVisibleIndex, "DtlKey");
                DataRow dr = myDetailPurchaseRequestTable.Rows.Find(id);

                dr["NamaBarang"] = Convert.ToString(e.NewValues["NamaBarang"]);
                dr["Kategori"] = Convert.ToString(e.NewValues["Kategori"]);
                dr["Qty"] = Double.Parse(Convert.ToString(e.NewValues["Qty"]));
                dr["Spesifikasi"] = Convert.ToString(e.NewValues["Spesifikasi"]);
                dr["Keterangan"] = Convert.ToString(e.NewValues["Keterangan"]);
                dr["IsBudget"] = Convert.ToString(e.NewValues["IsBudget"]);

                ASPxGridView grid = sender as ASPxGridView;
                grid.CancelEdit();
                e.Cancel = true;
            }
        }
        protected void gvPurchaseRequest_RowDeleting(object sender, DevExpress.Web.Data.ASPxDataDeletingEventArgs e)
        {
            gvPurchaseRequest.JSProperties["cpCmd"] = "DELETE";
            int id = (int)e.Keys["DtlKey"];
            DataRow dr = myDetailPurchaseRequestTable.Rows.Find(id);

            myDetailPurchaseRequestTable.Rows.Remove(dr);

            ASPxGridView grid = sender as ASPxGridView;
            grid.CancelEdit();
            e.Cancel = true;
        }
        protected void gvPurchaseRequest_CustomCallback(object sender, ASPxGridViewCustomCallbackEventArgs e)
        {

        }
        protected void gvPurchaseRequest_CustomColumnDisplayText(object sender, ASPxGridViewColumnDisplayTextEventArgs e)
        {
            if (e.Column.Caption == "No")
            {
                e.DisplayText = (e.VisibleIndex + 1).ToString();
            }
        }
        protected void gvPurchaseRequest_CellEditorInitialize(object sender, ASPxGridViewEditorEventArgs e)
        {

        }

        protected void gvBiayaBulanan_DataBinding(object sender, EventArgs e)
        {
            (sender as ASPxGridView).DataSource = myds.Tables["DetailBiayaBulanan"];
        }
        protected void gvBiayaBulanan_RowInserting(object sender, DevExpress.Web.Data.ASPxDataInsertingEventArgs e)
        {
            string StrErrorMsg = "";
            if (e.NewValues["Keterangan"] == null) throw new Exception("Column 'Keterangan' is mandatory.");
            if (e.NewValues["Periode"] == null) throw new Exception("Column 'Periode' is mandatory.");
            if (StrErrorMsg == "")
            {
                gvBiayaBulanan.JSProperties["cpCmd"] = "INSERT";

                int i = gvBiayaBulanan.VisibleRowCount;

                myDetailBiayaBulananTable.Rows.Add(
                    myInternalMemoEntity.InternalMemoDBcommand.BiayaBulananDtlKeyUniqeKey(),
                    myInternalMemoEntity.DocKey,
                    i,
                    Convert.ToString(e.NewValues["Keterangan"]),
                    Convert.ToString(e.NewValues["Periode"]),
                    Convert.ToString(e.NewValues["Remark1"]),
                    Convert.ToString(e.NewValues["Remark2"]),
                    Double.Parse(Convert.ToString(e.NewValues["Total"])));

                ASPxGridView grid = sender as ASPxGridView;
                grid.CancelEdit();
                e.Cancel = true;
            }
        }
        protected void gvBiayaBulanan_RowUpdating(object sender, DevExpress.Web.Data.ASPxDataUpdatingEventArgs e)
        {
            string StrErrorMsg = "";
            if (e.NewValues["Keterangan"] == null) throw new Exception("Column 'Keterangan' is mandatory.");
            if (e.NewValues["Periode"] == null) throw new Exception("Column 'Periode' is mandatory.");

            if (StrErrorMsg == "")
            {
                gvBiayaBulanan.JSProperties["cpCmd"] = "UPDATE";
                int editingRowVisibleIndex = gvBiayaBulanan.EditingRowVisibleIndex;
                int id = (int)gvBiayaBulanan.GetRowValues(editingRowVisibleIndex, "DtlKey");
                DataRow dr = myDetailBiayaBulananTable.Rows.Find(id);

                dr["Keterangan"] = Convert.ToString(e.NewValues["Keterangan"]);
                dr["Periode"] = Convert.ToString(e.NewValues["Periode"]);
                dr["Remark1"] = Convert.ToString(e.NewValues["Remark1"]);
                dr["Remark2"] = Convert.ToString(e.NewValues["Remark2"]);
                dr["Total"] = Double.Parse(Convert.ToString(e.NewValues["Total"]));

                ASPxGridView grid = sender as ASPxGridView;
                grid.CancelEdit();
                e.Cancel = true;
            }
        }
        protected void gvBiayaBulanan_RowDeleting(object sender, DevExpress.Web.Data.ASPxDataDeletingEventArgs e)
        {
            gvBiayaBulanan.JSProperties["cpCmd"] = "DELETE";
            int id = (int)e.Keys["DtlKey"];
            DataRow dr = myDetailBiayaBulananTable.Rows.Find(id);

            myDetailBiayaBulananTable.Rows.Remove(dr);

            ASPxGridView grid = sender as ASPxGridView;
            grid.CancelEdit();
            e.Cancel = true;
        }
        protected void gvBiayaBulanan_CustomCallback(object sender, ASPxGridViewCustomCallbackEventArgs e)
        {

        }
        protected void gvBiayaBulanan_CustomColumnDisplayText(object sender, ASPxGridViewColumnDisplayTextEventArgs e)
        {
            if (e.Column.Caption == "No")
            {
                e.DisplayText = (e.VisibleIndex + 1).ToString();
            }
        }
        protected void gvBiayaBulanan_CellEditorInitialize(object sender, ASPxGridViewEditorEventArgs e)
        {

        }

        protected void gvUploadDoc_DataBinding(object sender, EventArgs e)
        {
            (sender as ASPxGridView).DataSource = myds.Tables["UploadDoc"];
        }
        protected void gvUploadDoc_CustomCallback(object sender, ASPxGridViewCustomCallbackEventArgs e)
        {

        }
        protected void gvUploadDoc_CustomButtonCallback(object sender, ASPxGridViewCustomButtonCallbackEventArgs e)
        {
            if (e.ButtonID == "btnDownload")
            {
                try
                {
                    object obj = gvUploadDoc.GetRowValues(e.VisibleIndex, gvUploadDoc.KeyFieldName);
                    if (obj != null && obj != DBNull.Value)
                    {
                        FileDocID = Convert.ToInt32(obj);
                    }
                    ASPxWebControl.RedirectOnCallback(string.Format("InternalMemoEntry.aspx?ID=" + FileDocID.ToString()));
                }
                catch (Exception ex)
                {
                    ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + ex.Message + "');", true);
                    return;
                }
            }
        }

        protected void gvPendGiroHist_DataBinding(object sender, EventArgs e)
        {
            (sender as ASPxGridView).DataSource = myds.Tables["ApprovalHistory"];
        }
        protected void gvPendGiroHist_CustomCallback(object sender, ASPxGridViewCustomCallbackEventArgs e)
        {

        }
        protected void gvPendGiroHist_CustomButtonCallback(object sender, ASPxGridViewCustomButtonCallbackEventArgs e)
        {

        }
        protected void gvPendGiroHist_CustomCellMerge(object sender, ASPxGridViewCustomCellMergeEventArgs e)
        {
            if (e.Column.FieldName == "DocNo")
            {
                e.Handled = true;
                if ((string)e.Value1 == (string)e.Value2)
                {
                    MergedIndexList.Add(e.RowVisibleIndex1);
                    e.Merge = true;
                }
            }
            else
            { e.Handled = true; e.Merge = false; }
        }

        protected void btnExportPDF_Click(object sender, EventArgs e)
        {
            MemoryStream PDFStream = new MemoryStream();
            reTemplate.ExportToPdf(PDFStream);
            byte[] FileBuffer = PDFStream.ToArray();
            if (FileBuffer != null)
            {
                Response.ContentType = "application/pdf";
                Response.AddHeader("content-length", FileBuffer.Length.ToString());
                Response.AppendHeader("content-disposition", string.Format("attachment;FileName=\"{0}\"", "FreeTextMemo" + ".pdf"));
                Response.BinaryWrite(FileBuffer);
            }
        }

        protected void btnSaveTemplate_Click(object sender, EventArgs e)
        {
            reTemplate.SaveCopy(myFs, DocumentFormat.Rtf);
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

        protected void btnOpenTemplate_Click(object sender, EventArgs e)
        {
            LoadTemplate();
        }

        protected void LoadTemplate()
        {
            DataTable loadDoc = new DataTable();
            loadDoc = localdbsetting.GetDataTable("SELECT * FROM [INFORMA].[dbo].[FreeTextTemplate] WHERE id = 25", false);
            strRitchEditorKey = Guid.NewGuid().ToString();

            foreach (DataRow dr in loadDoc.Rows)
            {
                reTemplate.Open(strRitchEditorKey, DocumentFormat.Rtf, () => { return (byte[])dr["docFile"]; });
            }
        }

        protected void LoadDataFreeText()
        {
            if(myInternalMemoEntity.DataTableDetailFreeText.Rows.Count > 0)
            {
                strRitchEditorKey = Guid.NewGuid().ToString();
                reTemplate.Open(strRitchEditorKey, DocumentFormat.Rtf, () => { return (byte[])myInternalMemoEntity.DataTableDetailFreeText.Rows[0]["FreeTextFile"]; });
            }
            
        }
        
        protected void reTemplate_PreRender(object sender, EventArgs e)
        {
            reTemplate.Focus();
        }

        protected void reTemplate_CalculateDocumentVariable(object sender, CalculateDocumentVariableEventArgs e)
        {
            int seqApproval = 0;
            switch (e.VariableName)
            {
                case "Isi":
                    //load db
                    if(myInternalMemoEntity.DataTableDetailFreeText.Rows.Count > 0)
                    {
                        byte[] arr = (byte[])myInternalMemoEntity.DataTableDetailFreeText.Rows[0]["FreeTextFile"];
                        Stream stream = new MemoryStream(arr);

                        RichEditDocumentServer srv = new RichEditDocumentServer();
                        srv.LoadDocument(stream, DocumentFormat.Rtf);

                        e.Value = srv.Document;
                        e.Handled = true;
                    }
                    break;
                case "DocNo":
                    e.Value = myInternalMemoEntity.DocNo.ToString();
                    e.Handled = true;
                    break;
                case "Header":
                    string hdrVal = e.Arguments[0].Value.ToString();
                    if(hdrVal == "Kepada")
                    {
                        e.Value = myInternalMemoEntity.MemoTo.ToString();
                        e.Handled = true;
                    }

                    if (hdrVal == "Tembusan")
                    {
                        e.Value = myInternalMemoEntity.MemoCC.ToString();
                        e.Handled = true;
                    }

                    if (hdrVal == "Dari")
                    {
                        e.Value = myInternalMemoEntity.MemoFrom.ToString();
                        e.Handled = true;
                    }

                    if (hdrVal == "Tanggal")
                    {
                        e.Value = Convert.ToDateTime(myInternalMemoEntity.DocDate).ToString("dd/MM/yyyy");
                        //e.Value = myInternalMemoEntity.DocDate.ToString();
                        e.Handled = true;
                    }

                    if (hdrVal == "Perihal")
                    {
                        e.Value = myInternalMemoEntity.MemoPerihal.ToString();
                        e.Handled = true;
                    }

                    break;
                case "Name":
                    string nameVal = e.Arguments[0].Value.ToString();
                    if(myApprovalTable.Rows.Count > 0)
                    {
                        seqApproval = 0;
                        foreach (DataRow dr in myApprovalTable.Rows)
                        {
                            seqApproval += 1;
                            string hfieldName = "App" + seqApproval.ToString();
                            
                            if(nameVal == "Pemohon")
                            {
                                e.Value = myInternalMemoEntity.MemoFrom.ToString();
                                e.Handled = true;
                            }
                            if (nameVal == hfieldName)
                            {
                                e.Value = dr["Nama"].ToString();
                                e.Handled = true;
                            }
                        }
                    }
                    break;
                case "Jabatan":
                    string jabatanVal = e.Arguments[0].Value.ToString();
                    if (myApprovalTable.Rows.Count > 0)
                    {
                        seqApproval = 0;
                        foreach (DataRow dr in myApprovalTable.Rows)
                        {
                            seqApproval += 1;
                            string hfieldJabatan = "App" + seqApproval.ToString();

                            if (jabatanVal == hfieldJabatan)
                            {
                                e.Value = dr["Jabatan"].ToString();
                                e.Handled = true;
                            }
                        }
                    }
                    break;
                case "Sign":
                    string signVal = e.Arguments[0].Value.ToString();
                    if (myApprovalTable.Rows.Count > 0)
                    {
                        //Pemohon
                        string filePath = Server.MapPath("~/Content/Images/mysign.png");
                        DocumentImageSource img = DocumentImageSource.FromFile(filePath);
                        RichEditDocumentServer srv = new RichEditDocumentServer();

                        if (signVal == "Pemohon")
                        {
                            srv.Document.Images.Append(img);
                            e.Value = srv.Document;
                            e.Handled = true;
                        }

                        seqApproval = 0;
                        foreach (DataRow dr in myApprovalTable.Rows)
                        {
                            seqApproval += 1;
                            string hfieldSign = "App" + seqApproval.ToString();

                            if (signVal == hfieldSign)
                            {
                                string decState = dr["DecisionState"].ToString();
                                if (decState == "APPROVE")
                                {
                                    filePath = Server.MapPath("~/Content/Images/approve.png");
                                    img = DocumentImageSource.FromFile(filePath);
                                    srv = new RichEditDocumentServer();
                                    srv.Document.Images.Append(img);
                                    e.Value = srv.Document;
                                    e.Handled = true;
                                }

                                if (decState == "REJECT")
                                {
                                    filePath = Server.MapPath("~/Content/Images/reject.png");
                                    img = DocumentImageSource.FromFile(filePath);
                                    srv = new RichEditDocumentServer();
                                    srv.Document.Images.Append(img);
                                    e.Value = srv.Document;
                                    e.Handled = true;
                                }
                            }
                        }
                    }
                    break;
                case "Date":
                    string dateVal = e.Arguments[0].Value.ToString();
                    seqApproval = 0;
                    foreach (DataRow dr in myApprovalTable.Rows)
                    {
                        seqApproval += 1;
                        string hfieldDate = "App" + seqApproval.ToString();
                        if (dateVal == hfieldDate)
                        {
                            string decState = dr["DecisionState"].ToString();
                            string decDate = "";
                            if (dr["DecisionDate"] != DBNull.Value && dr["DecisionDate"] != null)
                            {
                                decDate = Convert.ToDateTime(dr["DecisionDate"]).ToString("dd/MM/yyyy");
                            }
                            
                            //string decDate = dr["DecisionDate"].ToString();
                            if (decState == "APPROVE" || decState == "REJECT")
                            {
                                e.Value = "Date: " +decDate;
                                e.Handled = true;
                            }
                        }
                    }
                    break;
                case "Note":
                    string noteVal = e.Arguments[0].Value.ToString();
                    seqApproval = 0;
                    foreach (DataRow dr in myApprovalTable.Rows)
                    {
                        seqApproval += 1;
                        string hfieldNote = "App" + seqApproval.ToString();
                        if (noteVal == hfieldNote)
                        {
                            string decState = dr["DecisionState"].ToString();
                            string decNote = dr["DecisionNote"].ToString();
                            if (decState == "APPROVE" || decState == "REJECT")
                            {
                                e.Value = "Note: " + decNote;
                                e.Handled = true;
                            }
                        }
                    }
                    break;
                default:
                    break;
            }
        }

        protected void reTemplate_Init(object sender, EventArgs e)
        {
            if(myAction == DXIAction.View || myAction == DXIAction.Approve || Convert.ToString(myInternalMemoEntity.Status) == "APPROVE" || Convert.ToString(myInternalMemoEntity.Status) == "REJECT")
            {
                if (myInternalMemoEntity.DataTableDetailFreeText.Rows.Count > 0)
                {
                    LoadTemplate();
                }
            }
            else
            {
                LoadDataFreeText();
            }
            
        }

        protected void luCabang_DataBinding(object sender, EventArgs e)
        {
            (sender as ASPxGridLookup).DataSource = myBranchTable;
        }
    }
}