using System;
using System.Web;
using System.Web.UI.WebControls;
using DevExpress.Web;
using Microsoft.AspNet.Identity;
using DXMNCGUI_INFORMA.Controllers.Data;
using DXMNCGUI_INFORMA.Controllers.Application;
using DXMNCGUI_INFORMA.Controllers;
using System.Web.Security;

namespace DXMNCGUI_INFORMA {
    public partial class RootMaster : System.Web.UI.MasterPage
    {
        protected SqlDBSetting myDBSetting
        {
            get { return (SqlDBSetting)HttpContext.Current.Session["HomeSqlDBSetting" + this.ViewState["_PageID"]]; }
            set { HttpContext.Current.Session["HomeSqlDBSetting" + this.ViewState["_PageID"]] = value; }
        }
        protected SqlDBSession myDBSession
        {
            get { return (SqlDBSession)HttpContext.Current.Session["HomeSqlDBSession" + this.ViewState["_PageID"]]; }
            set { HttpContext.Current.Session["HomeSqlDBSession" + this.ViewState["_PageID"]] = value; }
        }
        protected string UserID
        {
            get { return (string)HttpContext.Current.Session["UserID"]; }
            set { HttpContext.Current.Session["UserID"] = value; }
        }
        protected AccesRight accessright
        {
            get { return (AccesRight)HttpContext.Current.Session["accessright"]; }
            set { HttpContext.Current.Session["accessright"] = value; }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            ASPxLabel2.Text = DateTime.Now.Year + Server.HtmlDecode(" &copy; Copyright by Corporate Digital and System Information Div - PT. MNC Guna Usaha Indonesia");
            try
            {
                var lblUserName = this.HeadLoginView.FindControl("lblUserName") as ASPxLabel;
                if (lblUserName != null)
                {
                    lblUserName.Text = "Welcome, " + myDBSetting.ExecuteScalar("SELECT USER_NAME FROM MASTER_USER WHERE USER_ID=?", HttpContext.Current.Session["UserID"].ToString());
                }
            }
            catch (Exception ex)
            {
                ex.ToString();
                HttpContext.Current.Session.Abandon();
                FormsAuthentication.SignOut();
                DevExpress.Web.ASPxWebControl.RedirectOnCallback("~/Login.aspx");
            }
        }
        protected void HeadLoginStatus_LoggingOut(object sender, LoginCancelEventArgs e)
        {
            HttpContext.Current.Session.Abandon();
            Context.GetOwinContext().Authentication.SignOut(DefaultAuthenticationTypes.ApplicationCookie);
            myDBSession.Logout();
        }

        protected void ASPxCallback_Callback(object source, CallbackEventArgs e)
        {
            if (e.Parameter == "LogOut")
            {
                myDBSession.Logout();
                HttpContext.Current.Session.Abandon();
                Context.GetOwinContext().Authentication.SignOut(DefaultAuthenticationTypes.ApplicationCookie);
                DevExpress.Web.ASPxWebControl.RedirectOnCallback("~/Login.aspx");
            }
        }
    }
}