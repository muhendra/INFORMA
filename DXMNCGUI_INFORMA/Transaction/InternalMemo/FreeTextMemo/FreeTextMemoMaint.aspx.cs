using DevExpress.Web;
using DXMNCGUI_INFORMA.Controllers;
using DXMNCGUI_INFORMA.Controllers.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DXMNCGUI_INFORMA.Transaction.InternalMemo.FreeTextMemo
{
    public partial class FreeTextMemoMaint : BasePage
    {
        protected SqlDBSetting myDBSetting
        {
            get { isValidLogin(false); return (SqlDBSetting)HttpContext.Current.Session["myDBSetting" + HttpContext.Current.Session["UserID"]]; }
            set { HttpContext.Current.Session["myDBSetting" + HttpContext.Current.Session["UserID"]] = value; }
        }
        protected SqlLocalDBSetting myLocalDBSetting
        {
            get { isValidLogin(false); return (SqlLocalDBSetting)HttpContext.Current.Session["myLocalDBSetting" + HttpContext.Current.Session["UserID"]]; }
            set { HttpContext.Current.Session["myLocalDBSetting" + HttpContext.Current.Session["UserID"]] = value; }
        }
        protected SqlDBSession myDBSession
        {
            get { isValidLogin(false); return (SqlDBSession)HttpContext.Current.Session["myDBSession" + HttpContext.Current.Session["UserID"]]; }
            set { HttpContext.Current.Session["myDBSession" + HttpContext.Current.Session["UserID"]] = value; }
        }
        protected FreeTextMemoDB myFreeTextMemoDB
        {
            get { isValidLogin(false); return (FreeTextMemoDB)HttpContext.Current.Session["myFreeTextMemoDB" + HttpContext.Current.Session["UserID"]]; }
            set { HttpContext.Current.Session["myFreeTextMemoDB" + HttpContext.Current.Session["UserID"]] = value; }
        }
        protected FreeTextMemoEntity myFreeTextMemoEntity
        {
            get { isValidLogin(false); return (FreeTextMemoEntity)HttpContext.Current.Session["myFreeTextMemoEntity" + HttpContext.Current.Session["UserID"]]; }
            set { HttpContext.Current.Session["myFreeTextMemoEntity" + HttpContext.Current.Session["UserID"]] = value; }
        }
        protected DataTable mytableSearch
        {
            get { isValidLogin(false); return (DataTable)HttpContext.Current.Session["mytableSearch" + HttpContext.Current.Session["UserID"]]; }
            set { HttpContext.Current.Session["mytableSearch" + HttpContext.Current.Session["UserID"]] = value; }
        }
        protected DataTable mytableDetailSearch
        {
            get { isValidLogin(false); return (DataTable)HttpContext.Current.Session["mytableDetailSearch" + HttpContext.Current.Session["UserID"]]; }
            set { HttpContext.Current.Session["mytableDetailSearch" + HttpContext.Current.Session["UserID"]] = value; }
        }
        protected DataTable myApprovalTable
        {
            get { return (DataTable)HttpContext.Current.Session["myApprovalTable" + HttpContext.Current.Session["UserID"]]; }
            set { HttpContext.Current.Session["myApprovalTable" + HttpContext.Current.Session["UserID"]] = value; }
        }

        protected void Page_Init(object sender, EventArgs e)
        {
            isValidLogin(false);
            if (!Page.IsPostBack)
            {
                this.ViewState["_PageID"] = Guid.NewGuid();

                myDBSetting = dbsetting;
                myLocalDBSetting = localdbsetting;
                myDBSession = dbsession;
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                this.myFreeTextMemoDB = FreeTextMemoDB.Create(myDBSetting, myLocalDBSetting, myDBSession);

                mytableSearch = this.myFreeTextMemoDB.LoadBrowseTable(true, myDBSession.LoginUserID);
                gvMain.DataSource = mytableSearch;
                gvMain.DataBind();

                //accessable();

                if (this.Request.QueryString["DocKey"] != null)
                {
                    int indexVal = gvMain.FindVisibleIndexByKeyValue(this.Request.QueryString["DocKey"]);
                    gvMain.FocusedRowIndex = indexVal;
                }
                else
                {
                    gvMain.FocusedRowIndex = -1;
                }

                object obj = this.myLocalDBSetting.ExecuteScalar("SELECT COUNT(*) FROM [dbo].[WorkList] WHERE DocType = 7 AND UserKey=?", this.UserID);
                if (obj != null && obj != DBNull.Value)
                {
                    if (Convert.ToInt32(obj) != 0)
                        btnApprovalList.Text += " (" + Convert.ToString(obj) + ")";
                }
            }
        }

        protected void btnNew_Click(object sender, EventArgs e)
        {
            //string updatedQueryString = "";
            //try
            //{
            //    myFreeTextMemoEntity = myFreeTextMemoDB.Entity();
            //    var nameValues = HttpUtility.ParseQueryString(Request.QueryString.ToString());
            //    nameValues.Set("Key", HttpContext.Current.Session["UserID"].ToString());
            //    updatedQueryString = "?" + nameValues.ToString();
            //}
            //catch (Exception ex)
            //{
            //    ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + ex.Message + "');", true);
            //    return;
            //}
            ////ASPxWebControl.RedirectOnCallback("~/Transaction/InternalMemo/FreeTextMemo/FreeTextMemoEntry.aspx" + updatedQueryString);
            //Response.Redirect("~/Transaction/InternalMemo/FreeTextMemo/FreeTextMemoEntry.aspx" + updatedQueryString);
        }

        protected void cplMain_Callback(object source, CallbackEventArgs e)
        {
            string updatedQueryString = "";
            string[] callbackParam = e.Parameter.ToString().Split(';');
            cplMain.JSProperties["cpCallbackParam"] = callbackParam[0].ToUpper();

            switch (callbackParam[0].ToUpper())
            {
                case "NEW_ENTRY":
                    if (Page.IsCallback)
                    {
                        try
                        {
                            myFreeTextMemoEntity = myFreeTextMemoDB.Entity();
                            var nameValues = HttpUtility.ParseQueryString(Request.QueryString.ToString());
                            nameValues.Set("Key", HttpContext.Current.Session["UserID"].ToString());
                            updatedQueryString = "?" + nameValues.ToString();
                        }
                        catch (Exception ex)
                        {
                            ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + ex.Message + "');", true);
                            return;
                        }
                        ASPxWebControl.RedirectOnCallback("~/Transaction/InternalMemo/FreeTextMemo/FreeTextMemoEntry.aspx" + updatedQueryString);
                    }
                    break;
                case "SHOW":
                    try
                    {
                        DataRow myapprovalrow = gvApprovalList.GetDataRow(gvApprovalList.FocusedRowIndex);
                        var nameValues = HttpUtility.ParseQueryString(Request.QueryString.ToString());
                        nameValues.Set("Key", HttpContext.Current.Session["UserID"].ToString());
                        updatedQueryString = "?" + nameValues.ToString();
                        myFreeTextMemoDB = FreeTextMemoDB.Create(myDBSetting, myLocalDBSetting, dbsession);
                        
                        myFreeTextMemoEntity = myFreeTextMemoDB.Approve(Convert.ToInt32(myapprovalrow["SourceKey"]), Convert.ToString(myapprovalrow["DocNo"]));
                        ASPxWebControl.RedirectOnCallback("~/Transaction/InternalMemo/FreeTextMemo/FreeTextMemoEntry.aspx" + updatedQueryString);
                    }
                    catch (Exception ex)
                    {
                        ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + ex.Message + "');", true);
                        return;
                    }
                    break;
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

                    myFreeTextMemoEntity = myFreeTextMemoDB.Edit(Convert.ToInt32(myrow["DocKey"]), Convert.ToString(myrow["DocNo"]),  DXIAction.Edit);
                    Response.Redirect("~/Transaction/InternalMemo/FreeTextMemo/FreeTextMemoEntry.aspx" + updatedQueryString);
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
                    
                    myFreeTextMemoEntity = myFreeTextMemoDB.View(Convert.ToInt32(myrow["DocKey"]), Convert.ToString(myrow["DocNo"]), DXIAction.View);
                    Response.Redirect("~/Transaction/InternalMemo/FreeTextMemo/FreeTextMemoEntry.aspx" + updatedQueryString);
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
                    mytableSearch = this.myFreeTextMemoDB.LoadBrowseTable(false, myDBSession.LoginUserID);
                }
                else
                {
                    mytableSearch = this.myFreeTextMemoDB.LoadBrowseTable(true, myDBSession.LoginUserID);
                }
                gvMain.DataSource = mytableSearch;
                gvMain.DataBind();

                myApprovalTable = this.myFreeTextMemoDB.LoadApprovalList(myDBSession.LoginUserID);
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
            myApprovalTable = this.myFreeTextMemoDB.LoadApprovalList(myDBSession.LoginUserID);
            gvApprovalList.DataSource = myApprovalTable;
            gvApprovalList.DataBind();

            apcApproval.ShowOnPageLoad = true;
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

        protected void gvMain_DataBinding(object sender, EventArgs e)
        {
            (sender as ASPxGridView).DataSource = mytableSearch;
        }

        protected void gvMain_FocusedRowChanged(object sender, EventArgs e)
        {

        }

        protected void gvMain_CustomCallback(object sender, ASPxGridViewCustomCallbackEventArgs e)
        {
            string updatedQueryString = "";
            ASPxGridView gridView = (ASPxGridView)sender;
            string[] callbackParam = e.Parameters.ToString().Split(';');
            (sender as ASPxGridView).JSProperties["cpNewWindowUrl"] = null;
            gvMain.JSProperties["cpCallbackParam"] = callbackParam[0].ToUpper();
            if (callbackParam.Length > 1)
            {
                object paramName = callbackParam[0].ToUpper();
                object paramValue = callbackParam[1].ToUpper();
                gridView.JSProperties["cplblmessageError"] = "";
                gridView.JSProperties["cplblActionButton"] = "";

                DataRow myrow = gvMain.GetDataRow(gvMain.FocusedRowIndex);

                switch (callbackParam[0].ToUpper())
                {
                    case "INDEX":
                        int ivisibleindex = 0;
                        ivisibleindex = System.Convert.ToInt16(paramValue);
                        gvMain.JSProperties["cpVisibleIndex"] = ivisibleindex;
                        gridView.KeyFieldName = "DocNo";
                        break;
                    case "OPEN":
                        break;
                    case "REFRESH":
                        try
                        {
                            isValidLogin();
                            if (!accessright.IsAccessibleByUserID(UserID, "WLC_VIEW_ALL"))
                            {
                                mytableSearch = this.myFreeTextMemoDB.LoadBrowseTable(false, myDBSession.LoginUserID);
                            }
                            else
                            {
                                mytableSearch = this.myFreeTextMemoDB.LoadBrowseTable(true, myDBSession.LoginUserID);
                            }
                            gvMain.DataSource = mytableSearch;
                            gvMain.DataBind();
                        }
                        catch (Exception ex)
                        {
                            ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + ex.Message + "');", true);
                            return;
                        }
                        break;
                    case "DOUBLECLICK":
                        try
                        {
                            if (myrow != null)
                            {
                                var nameValues = HttpUtility.ParseQueryString(Request.QueryString.ToString());
                                nameValues.Set("Key", HttpContext.Current.Session["UserID"].ToString());
                                updatedQueryString = "?" + nameValues.ToString();
                                myFreeTextMemoEntity = myFreeTextMemoDB.Edit(Convert.ToInt32(myrow["DocKey"]), Convert.ToString(myrow["DocNo"]), DXIAction.Edit);
                                ASPxWebControl.RedirectOnCallback("~/Transaction/InternalMemo/FreeTextMemo/FreeTextMemoEntry.aspx" + updatedQueryString);
                            }
                        }
                        catch (Exception ex)
                        {
                            ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + ex.Message + "');", true);
                            return;
                        }
                        break;
                }
            }
        }

        protected void gvMain_CustomColumnDisplayText(object sender, ASPxGridViewColumnDisplayTextEventArgs e)
        {

        }
    }
}