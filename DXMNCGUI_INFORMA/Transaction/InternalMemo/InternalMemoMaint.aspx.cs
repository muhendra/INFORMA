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
using System.ComponentModel;
using DXMNCGUI_INFORMA.Transaction.InternalMemo.FreeTemplate;

namespace DXMNCGUI_INFORMA.Transaction.InternalMemo
{
    public partial class InternalMemoMaint : BasePage
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
        protected InternalMemoDB myInternalMemoDB
        {
            get { isValidLogin(false); return (InternalMemoDB)HttpContext.Current.Session["myInternalMemoDB" + HttpContext.Current.Session["UserID"]]; }
            set { HttpContext.Current.Session["myInternalMemoDB" + HttpContext.Current.Session["UserID"]] = value; }
        }
        protected InternalMemoEntity myInternalMemoEntity
        {
            get { isValidLogin(false); return (InternalMemoEntity)HttpContext.Current.Session["myInternalMemoEntity" + HttpContext.Current.Session["UserID"]]; }
            set { HttpContext.Current.Session["myInternalMemoEntity" + HttpContext.Current.Session["UserID"]] = value; }
        }
        protected FreeTemplateDB myFreeTemplateDB
        {
            get { isValidLogin(false); return (FreeTemplateDB)HttpContext.Current.Session["myFreeTemplateDB" + HttpContext.Current.Session["UserID"]]; }
            set { HttpContext.Current.Session["myFreeTemplateDB" + HttpContext.Current.Session["UserID"]] = value; }
        }
        protected FreeTemplateEntity myFreeTemplateEntity
        {
            get { isValidLogin(false); return (FreeTemplateEntity)HttpContext.Current.Session["myFreeTemplateEntity" + HttpContext.Current.Session["UserID"]]; }
            set { HttpContext.Current.Session["myFreeTemplateEntity" + HttpContext.Current.Session["UserID"]] = value; }
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
        protected IContainer components
        {
            get { isValidLogin(false); return (IContainer)HttpContext.Current.Session["components" + HttpContext.Current.Session["UserID"]]; }
            set { HttpContext.Current.Session["components" + HttpContext.Current.Session["UserID"]] = value; }
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
                this.myInternalMemoDB = InternalMemoDB.Create(myDBSetting, myLocalDBSetting, myDBSession);
                this.myFreeTemplateDB = FreeTemplateDB.Create(myDBSetting, myLocalDBSetting, myDBSession);

                mytableSearch = this.myInternalMemoDB.LoadBrowseTable(true, myDBSession.LoginUserID);
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

                object obj = this.myLocalDBSetting.ExecuteScalar("SELECT COUNT(*) FROM [dbo].[WorkList] WHERE DocType <> 6 AND UserKey=?", this.UserID);
                if (obj != null && obj != DBNull.Value)
                {
                    if (Convert.ToInt32(obj) != 0)
                        btnApprovalList.Text += " (" + Convert.ToString(obj) + ")";
                }
            }
        }
        protected void EditData()
        {
            string DebiturName = "";
            string updatedQueryString = "";
            try
            {
                DataRow myrow = gvMain.GetDataRow(gvMain.FocusedRowIndex);
                if (myrow != null)
                {
                    //Check Validasi Edit FreeTextMEMO
                    string rowDocType = myrow["DocType"].ToString();
                    string rowMemoFrom = myrow["MemoFrom"].ToString();
                    //if (rowDocType == "FREE TEXT MEMO")
                    //{
                    //    string GetCreatorName = GetMemoFromName();
                    //    if(rowMemoFrom != GetCreatorName)
                    //    {
                    //        ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + "only creator memo can edit.." + "');", true);
                    //        return;
                    //    }

                    //    int rowDocKey = Convert.ToInt32(myrow["DocKey"]);
                    //    bool isApprove = GetFirstApprovalIsApprove(rowDocKey);
                    //    if(isApprove == true)
                    //    {
                    //        ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + "you cannot edit this memo because is already approved.." + "');", true);
                    //        return;
                    //    }
                    //}

                    var nameValues = HttpUtility.ParseQueryString(Request.QueryString.ToString());
                    nameValues.Set("Key", HttpContext.Current.Session["UserID"].ToString());
                    updatedQueryString = "?" + nameValues.ToString();

                    object obj = myLocalDBSetting.ExecuteScalar("SELECT TOP 1 NamaDebitur FROM InternalMemoDetailPendingGiro WHERE DocKey=?", Convert.ToInt32(myrow["DocKey"]));
                    if (obj != null && obj != DBNull.Value)
                    {
                        DebiturName = obj.ToString();
                    }

                    myInternalMemoEntity = myInternalMemoDB.Edit(Convert.ToInt32(myrow["DocKey"]), Convert.ToString(myrow["DocNo"]), DebiturName, DXIAction.Edit);
                    Response.Redirect("~/Transaction/InternalMemo/InternalMemoEntry.aspx" + updatedQueryString);
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
            string DebiturName = "";
            string updatedQueryString = "";
            try
            {
                DataRow myrow = gvMain.GetDataRow(gvMain.FocusedRowIndex);
                if (myrow != null)
                {
                    var nameValues = HttpUtility.ParseQueryString(Request.QueryString.ToString());
                    nameValues.Set("Key", HttpContext.Current.Session["UserID"].ToString());
                    updatedQueryString = "?" + nameValues.ToString();

                    object obj = myLocalDBSetting.ExecuteScalar("SELECT TOP 1 NamaDebitur FROM InternalMemoDetailPendingGiro WHERE DocKey=?", Convert.ToInt32(myrow["DocKey"]));
                    if (obj != null && obj != DBNull.Value)
                    {
                        DebiturName = obj.ToString();
                    }

                    myInternalMemoEntity = myInternalMemoDB.View(Convert.ToInt32(myrow["DocKey"]), Convert.ToString(myrow["DocNo"]), DebiturName, DXIAction.View);
                    Response.Redirect("~/Transaction/InternalMemo/InternalMemoEntry.aspx" + updatedQueryString);
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

        protected void btnNew_Click(object sender, EventArgs e)
        {

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
                    mytableSearch = this.myInternalMemoDB.LoadBrowseTable(false, myDBSession.LoginUserID);
                }
                else
                {
                    mytableSearch = this.myInternalMemoDB.LoadBrowseTable(true, myDBSession.LoginUserID);
                }
                gvMain.DataSource = mytableSearch;
                gvMain.DataBind();

                myApprovalTable = this.myInternalMemoDB.LoadApprovalList(myDBSession.LoginUserID);
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
            myApprovalTable = this.myInternalMemoDB.LoadApprovalList(myDBSession.LoginUserID);
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
                                mytableSearch = this.myInternalMemoDB.LoadBrowseTable(false, myDBSession.LoginUserID);
                            }
                            else
                            {
                                mytableSearch = this.myInternalMemoDB.LoadBrowseTable(true, myDBSession.LoginUserID);
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
                                myInternalMemoEntity = myInternalMemoDB.Edit(Convert.ToInt32(myrow["DocKey"]), Convert.ToString(myrow["DocNo"]), "", DXIAction.Edit);
                                ASPxWebControl.RedirectOnCallback("~/Transactions/InternalMemo/InternalMemoEntry.aspx" + updatedQueryString);
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

        protected void cplMain_Callback(object source, CallbackEventArgs e)
        {
            string updatedQueryString = "";
            string[] callbackParam = e.Parameter.ToString().Split(';');
            cplMain.JSProperties["cpCallbackParam"] = callbackParam[0].ToUpper();
            cplMain.JSProperties["cpDocType"] = cbDocType.Value;

            DataRow myrow = gvMain.GetDataRow(gvMain.FocusedRowIndex);

            switch (callbackParam[0].ToUpper())
            {
                case "PRINT":
                    cplMain.JSProperties["cpDocNo"] = myrow["DocNo"].ToString();
                    cplMain.JSProperties["cpDocKey"] = myrow["DocKey"].ToString();
                    cplMain.JSProperties["cpDocType"] = myrow["DocType"].ToString();
                    break;
                case "NEW":
                    break;
                case "NEW_ENTRY_CONFIRM":
                    if (Page.IsCallback)
                    {
                        if (Convert.ToString(cbDocType.Value) == (object)"99")
                        {
                            try
                            {
                                myFreeTemplateEntity = myFreeTemplateDB.Entity(DXIType.IM_FREE, Convert.ToString(cbDocType.Value));
                                var nameValues = HttpUtility.ParseQueryString(Request.QueryString.ToString());
                                nameValues.Set("Key", HttpContext.Current.Session["UserID"].ToString());
                                updatedQueryString = "?" + nameValues.ToString();
                            }
                            catch (Exception ex)
                            {
                                ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + ex.Message + "');", true);
                                return;
                            }
                            ASPxWebControl.RedirectOnCallback("~/Transaction/InternalMemo/FreeTemplate/FreeTemplateEntry.aspx" + updatedQueryString);
                        }
                        else
                        {
                            try
                            {
                                myInternalMemoEntity = myInternalMemoDB.Entity(DXIType.IM, Convert.ToString(cbDocType.Value));
                                var nameValues = HttpUtility.ParseQueryString(Request.QueryString.ToString());
                                nameValues.Set("Key", HttpContext.Current.Session["UserID"].ToString());
                                updatedQueryString = "?" + nameValues.ToString();
                            }
                            catch (Exception ex)
                            {
                                ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + ex.Message + "');", true);
                                return;
                            }
                            ASPxWebControl.RedirectOnCallback("~/Transaction/InternalMemo/InternalMemoEntry.aspx" + updatedQueryString);
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
                        myInternalMemoDB = InternalMemoDB.Create(myDBSetting, myLocalDBSetting, dbsession);

                        string DebiturName = "";
                        object obj = myLocalDBSetting.ExecuteScalar("SELECT TOP 1 NamaDebitur FROM InternalMemoDetailPendingGiro WHERE DocKey=?", Convert.ToInt32(myapprovalrow["SourceKey"]));
                        if (obj != null && obj != DBNull.Value)
                        {
                            DebiturName = obj.ToString();
                        }

                        myInternalMemoEntity = myInternalMemoDB.Approve(Convert.ToInt32(myapprovalrow["SourceKey"]), Convert.ToString(myapprovalrow["DocNo"]), DebiturName);
                        ASPxWebControl.RedirectOnCallback("~/Transaction/InternalMemo/InternalMemoEntry.aspx" + updatedQueryString);
                    }
                    catch (Exception ex)
                    {
                        ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + ex.Message + "');", true);
                        return;
                    }
                    break;
            }
        }

        protected void gvMain_CustomColumnDisplayText(object sender, ASPxGridViewColumnDisplayTextEventArgs e)
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

        private bool GetFirstApprovalIsApprove(int dockey)
        {
            bool boolRes = false;
            object obj = myLocalDBSetting.ExecuteScalar("select top 1 * from InternalMemoApprovalList where ISNULL(DecisionState,'')<>'' and DocKey=?", dockey);
            if (obj != null && obj != DBNull.Value)
            {
                boolRes = true;
            }

            return boolRes;
        }

        private string GetMemoFromName()
        {
            string res = this.UserID + " - ";
            object obj = myLocalDBSetting.ExecuteScalar("select top 1 USER_NAME from [SSS].[dbo].MASTER_USER where USER_ID=?", this.UserID);
            if (obj != null && obj != DBNull.Value)
            {
                res += obj.ToString();
            }

            return res;
        }
    }
}