using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace DXMNCGUI_INFORMA.Transaction.InternalMemo
{
    /// <summary>
    /// Summary description for FreeTextDownload
    /// </summary>
    public class FreeTextDownload : IHttpHandler
    {
        public void ProcessRequest(HttpContext context)
        {
            System.Web.HttpRequest request = System.Web.HttpContext.Current.Request;
            string userID = request.QueryString["userID"];

            var arr = (MemoryStream)HttpContext.Current.Session["myFreeTextDownload" + userID];

            //MemoryStream PDFStream = new MemoryStream();
            byte[] FileBuffer = arr.ToArray();

            System.Web.HttpResponse response = System.Web.HttpContext.Current.Response;
            response.ContentType = "application/pdf";
            response.AddHeader("content-length", FileBuffer.Length.ToString());
            response.AppendHeader("content-disposition", string.Format("attachment;FileName=\"{0}\"", "FreeTextMemo" + ".pdf"));
            response.BinaryWrite(FileBuffer);
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}