using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.IO;
using System.Text;
using iTextSharp;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.text.html;
using iTextSharp.text.html.simpleparser;
using System.Collections.Generic;
using Excel = Microsoft.Office.Interop.Excel;
using System.Reflection;
using System.Web;
using System.Net;

namespace PDFWork
{
    class Program
    {
        void ExportPDF()
        {
            DataTable dt = passportData;


            Response.ContentType = "application/pdf";
            Response.AddHeader("content-disposition",

                "attachment;filename=DataTable.pdf");

            Response.Cache.SetCacheability(HttpCacheability.NoCache);

            StringWriter sw = new StringWriter();

            StringBuilder hw = new StringBuilder();
            hw.Append(sw);

            //HtmlTextWriter hw = new HtmlTextWriter(sw);



            StringReader sr = new StringReader(sw.ToString());

            Document pdfDoc = new Document(PageSize.A4, 10f, 10f, 10f, 0f);

            HTMLWorker htmlparser = new HTMLWorker(pdfDoc);

            PdfWriter.GetInstance(pdfDoc, Response.GetResponseStream());

            pdfDoc.Open();

            htmlparser.Parse(sr);

            pdfDoc.Close();


            //response.Write(pdfDoc);

            //Response.End();

        }


        static void Main(string[] args)
        {
        }
    }
}
