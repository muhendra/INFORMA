using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace DXMNCGUI_INFORMA.Shared
{
    /// <summary>
    /// Summary description for FreeTextPDF
    /// </summary>
    public class FreeTextPDF : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            System.Web.HttpRequest request = System.Web.HttpContext.Current.Request;
            string userID = request.QueryString["userID"];

            MemoryStream PDFStream = new MemoryStream();
            PDFStream = (MemoryStream)HttpContext.Current.Session["myFreeTextDownload" + userID];

            //MemoryStream PDFStream = new MemoryStream();
            byte[] FileBuffer = PDFStream.ToArray();

            System.Web.HttpResponse response = System.Web.HttpContext.Current.Response;
            response.ContentType = "application/pdf";
            response.AddHeader("content-length", FileBuffer.Length.ToString());
            response.AppendHeader("content-disposition", string.Format("inline;FileName=\"{0}\"", "FreeTextMemo" + ".pdf"));
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