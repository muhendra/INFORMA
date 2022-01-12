using DevExpress.Web;
using DXMNCGUI_INFORMA.Controllers;
using DXMNCGUI_INFORMA.Controllers.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DXMNCGUI_INFORMA.Transaction.PeminjamanDokumen
{
    public partial class PeminjamanDokumenList : BasePage
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
        //protected PeminjamanDokumenEntity myPeminjamanDokumenEntity
        //{
        //    get { isValidLogin(false); return (PeminjamanDokumenEntity)HttpContext.Current.Session["myPeminjamanDokumenEntity" + this.ViewState["_PageID"]]; }
        //    set { HttpContext.Current.Session["myPeminjamanDokumenEntity" + this.ViewState["_PageID"]] = value; }
        //}
        protected PeminjamanDokumenEntity myPeminjamanDokumenEntity
        {
            get { isValidLogin(false); return (PeminjamanDokumenEntity)HttpContext.Current.Session["myPeminjamanDokumenEntity" + HttpContext.Current.Session["UserID"]]; }
            set { HttpContext.Current.Session["myPeminjamanDokumenEntity" + HttpContext.Current.Session["UserID"]] = value; }
        }

        protected DataTable mytableSearch
        {
            get { isValidLogin(false); return (DataTable)HttpContext.Current.Session["mytableSearch" + this.ViewState["_PageID"]]; }
            set { HttpContext.Current.Session["mytableSearch" + this.ViewState["_PageID"]] = value; }
        }

        protected DataTable myApprovalTable
        {
            get { return (DataTable)HttpContext.Current.Session["myApprovalTable" + HttpContext.Current.Session["UserID"]]; }
            set { HttpContext.Current.Session["myApprovalTable" + HttpContext.Current.Session["UserID"]] = value; }
        }

        protected IContainer components
        {
            get { isValidLogin(false); return (IContainer)HttpContext.Current.Session["components" + this.ViewState["_PageID"]]; }
            set { HttpContext.Current.Session["components" + this.ViewState["_PageID"]] = value; }
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                this.ViewState["_PageID"] = Guid.NewGuid();
                isValidLogin();
                myDBSetting = dbsetting;
                myLocalDBSetting = localdbsetting;
                myDBSession = dbsession;
                this.myPeminjamanDokumenDB = PeminjamanDokumenDB.Create(myDBSetting, myLocalDBSetting, myDBSession);
                
                mytableSearch = this.myPeminjamanDokumenDB.LoadBrowseTable(true, "");
                gvMain.DataSource = mytableSearch;
                gvMain.DataBind();

                accessable();

                if (this.Request.QueryString["DocKey"] != null)
                {
                    int indexVal = gvMain.FindVisibleIndexByKeyValue(this.Request.QueryString["DocKey"]);
                    gvMain.FocusedRowIndex = indexVal;
                }
                else
                {
                    gvMain.FocusedRowIndex = -1;
                }

                object obj = this.myLocalDBSetting.ExecuteScalar("SELECT COUNT(*) FROM [dbo].[WorkList] WHERE DocType = 6 AND UserKey=?", this.UserID);
                if (obj != null && obj != DBNull.Value)
                {
                    if (Convert.ToInt32(obj) != 0)
                        btnApprovalList.Text += " (" + Convert.ToString(obj) + ")";
                }
            }
        }
        protected void EditData()
        {
            string updatedQueryString = "";
            try
            {
                DataRow myrow = gvMain.GetDataRow(gvMain.FocusedRowIndex);
                if (myrow != null)
                {
                    var nameValues = HttpUtility.ParseQueryString(Request.QueryString.ToString());
                    nameValues.Set("Key", HttpContext.Current.Session["UserID"].ToString());
                    updatedQueryString = "?" + nameValues.ToString();

                    myPeminjamanDokumenEntity = myPeminjamanDokumenDB.Edit(Convert.ToInt32(myrow["DocKey"]), Convert.ToString(myrow["DocNo"]), DXIAction.Edit);
                    Response.Redirect("~/Transaction/PeminjamanDokumen/PeminjamanDokumenEntry.aspx" + updatedQueryString);
                }
                else
                {
                    ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + "please select row first.." + "');", true);
                    return;
                }
            }
            catch (Exception ex)
            {
                ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + ex.Message + "');", true);
                return;
            }
        }
        protected void ViewData()
        {
            string updatedQueryString = "";
            try
            {
                DataRow myrow = gvMain.GetDataRow(gvMain.FocusedRowIndex);
                if (myrow != null)
                {
                    var nameValues = HttpUtility.ParseQueryString(Request.QueryString.ToString());
                    nameValues.Set("Key", HttpContext.Current.Session["UserID"].ToString());
                    updatedQueryString = "?" + nameValues.ToString();

                    myPeminjamanDokumenEntity = myPeminjamanDokumenDB.View(Convert.ToInt32(myrow["DocKey"]), Convert.ToString(myrow["DocNo"]), DXIAction.Edit);
                    Response.Redirect("~/Transaction/PeminjamanDokumen/PeminjamanDokumenEntry.aspx" + updatedQueryString);
                }
                else
                {
                    ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + "please select row first.." + "');", true);
                    return;
                }
            }
            catch (Exception ex)
            {
                ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + ex.Message + "');", true);
                return;
            }
        }
        protected void Dispose(bool disposing)
        {
            if (disposing && this.components != null)
                this.components.Dispose();
            base.Dispose();
        }

        protected void accessable()
        {
        }

        protected void cplMain_Callback(object source, CallbackEventArgs e)
        {
            string updatedQueryString = "";
            string[] callbackParam = e.Parameter.ToString().Split(';');
            cplMain.JSProperties["cpCallbackParam"] = callbackParam[0].ToUpper();

            DataRow myrow = gvMain.GetDataRow(gvMain.FocusedRowIndex);

            switch (callbackParam[0].ToUpper())
            {

                case "NEW":
                    if (Page.IsCallback)
                    {
                            try
                            {  
                                var nameValues = HttpUtility.ParseQueryString(Request.QueryString.ToString());
                                nameValues.Set("Key", HttpContext.Current.Session["UserID"].ToString());
                                updatedQueryString = "?" + nameValues.ToString();

                                myPeminjamanDokumenEntity = myPeminjamanDokumenDB.Entity(DXIType.IM_PJM, "PJMDOC");
                                ASPxWebControl.RedirectOnCallback("~/Transaction/PeminjamanDokumen/PeminjamanDokumenEntry.aspx" + updatedQueryString);
                            }
                            catch (Exception ex)
                            {
                                ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + ex.Message + "');", true);
                                return;
                            }
                    }
                    break;
                case "SHOW":
                    try
                    {
                        DataRow myapprovalrow = gvApprovalList.GetDataRow(gvApprovalList.FocusedRowIndex);
                        var nameValues = HttpUtility.ParseQueryString(Request.QueryString.ToString());
                        nameValues.Set("Key", HttpContext.Current.Session["UserID"].ToString());
                        updatedQueryString = "?" + nameValues.ToString();
                        myPeminjamanDokumenDB = PeminjamanDokumenDB.Create(myDBSetting, myLocalDBSetting, dbsession);

                        myPeminjamanDokumenEntity = myPeminjamanDokumenDB.Approve(Convert.ToInt32(myapprovalrow["SourceKey"]), Convert.ToString(myapprovalrow["DocNo"]));
                        ASPxWebControl.RedirectOnCallback("~/Transaction/PeminjamanDokumen/PeminjamanDokumenEntry.aspx" + updatedQueryString);
                    }
                    catch (Exception ex)
                    {
                        ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + ex.Message + "');", true);
                        return;
                    }
                    break;
            }
        }

        protected void btnView_Click(object sender, EventArgs e)
        {
            ViewData();
        }
        protected void btnEdit_Click(object sender, EventArgs e)
        {
            EditData();
        }
        protected void btnRefresh_Click(object sender, EventArgs e)
        {
            try
            {
                isValidLogin();
                if (!accessright.IsAccessibleByUserID(UserID, "WLC_VIEW_ALL"))
                {
                    mytableSearch = this.myPeminjamanDokumenDB.LoadBrowseTable(false, myDBSession.LoginUserID);
                }
                else
                {
                    mytableSearch = this.myPeminjamanDokumenDB.LoadBrowseTable(true, myDBSession.LoginUserID);
                }
                gvMain.DataSource = mytableSearch;
                gvMain.DataBind();

                myApprovalTable = this.myPeminjamanDokumenDB.LoadApprovalList(myDBSession.LoginUserID);
                gvApprovalList.DataSource = myApprovalTable;
                gvApprovalList.DataBind();
            }
            catch (Exception ex)
            {
                ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + ex.Message + "');", true);
                return;
            }
        }
        protected void btnApprovalList_Click(object sender, EventArgs e)
        {
            myApprovalTable = this.myPeminjamanDokumenDB.LoadApprovalList(myDBSession.LoginUserID);
            gvApprovalList.DataSource = myApprovalTable;
            gvApprovalList.DataBind();

            apcApproval.ShowOnPageLoad = true;
        }

        protected void gvMain_DataBinding(object sender, EventArgs e)
        {
            (sender as ASPxGridView).DataSource = mytableSearch;
        }
        protected void gvMain_FocusedRowChanged(object sender, EventArgs e)
        {

        }
        protected void gvMain_CustomColumnDisplayText(object sender, ASPxGridViewColumnDisplayTextEventArgs e)
        {

        }
        protected void gvMain_Init(object sender, EventArgs e)
        {

        }
        protected void gvMain_CustomCallback(object sender, ASPxGridViewCustomCallbackEventArgs e)
        {

        }

        protected void gvApprovalList_Init(object sender, EventArgs e)
        {

        }
        protected void gvApprovalList_DataBinding(object sender, EventArgs e)
        {
            (sender as ASPxGridView).DataSource = myApprovalTable;
        }
        protected void gvApprovalList_FocusedRowChanged(object sender, EventArgs e)
        {

        }
        protected void gvApprovalList_CustomCallback(object sender, ASPxGridViewCustomCallbackEventArgs e)
        {

        }
        protected void gvApprovalList_Load(object sender, EventArgs e)
        {

        }
    }
}