using DXMNCGUI_INFORMA.Controllers;
using DXMNCGUI_INFORMA.Controllers.Application;
using DXMNCGUI_INFORMA.Controllers.Data;
using System;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;

namespace DXMNCGUI_INFORMA
{
    public partial class MainMaster : System.Web.UI.MasterPage
    {
        protected SqlDBSetting myDBSetting
        {
            get { return (SqlDBSetting)HttpContext.Current.Session["HomeSqlDBSetting" + this.ViewState["_PageID"]]; }
            set { HttpContext.Current.Session["HomeSqlDBSetting" + this.ViewState["_PageID"]] = value; }
        }
        protected SqlLocalDBSetting myLocalDBSetting
        {
            get { return (SqlLocalDBSetting)HttpContext.Current.Session["HomeSqlLocalDBSetting" + this.ViewState["_PageID"]]; }
            set { HttpContext.Current.Session["HomeSqlLocalDBSetting" + this.ViewState["_PageID"]] = value; }
        }
        protected SqlDBSession myDBSession
        {
            get { return (SqlDBSession)HttpContext.Current.Session["HomeSqlDBSession" + this.ViewState["_PageID"]]; }
            set { HttpContext.Current.Session["HomeSqlDBSession" + this.ViewState["_PageID"]] = value; }
        }
        protected DataTable mytable
        {
            get { return (DataTable)HttpContext.Current.Session["mytable" + this.ViewState["_PageID"]]; }
            set { HttpContext.Current.Session["mytable" + this.ViewState["_PageID"]] = value; }
        }
        protected DataTable myparenttable
        {
            get { return (DataTable)HttpContext.Current.Session["myparenttable" + this.ViewState["_PageID"]]; }
            set { HttpContext.Current.Session["myparenttable" + this.ViewState["_PageID"]] = value; }
        }
        protected AccesRight accessright
        {
            get { return (AccesRight)HttpContext.Current.Session["accessright"]; }
            set { HttpContext.Current.Session["accessright"] = value; }
        }
        protected string UserID
        {
            get { return (string)HttpContext.Current.Session["UserID"]; }
            set { HttpContext.Current.Session["UserID"] = value; }
        }

        public object MessageBox { get; private set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                mytable = new DataTable();
                myparenttable = new DataTable();
                if (HttpContext.Current.Session["SessionID"] == null)
                {
                    HttpContext.Current.Session.Abandon();
                    FormsAuthentication.SignOut();
                    Response.Redirect("~/Login.aspx");
                }
                myDBSetting = (SqlDBSetting)HttpContext.Current.Session["SqlDBSetting"];
                myLocalDBSetting = (SqlLocalDBSetting)HttpContext.Current.Session["SqlLocalDBSetting"];
                myDBSession = (SqlDBSession)HttpContext.Current.Session["SqlDBSession"];
            }
        }
    }
}