using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

namespace WebApplication2
{
    public class PDFConverter
    {


        public void ConvertToPDF(DataTable dataTable)
        {

            _Default d = new _Default();

            d.ExportPDF(dataTable);
        
        
        
        }


    }
}