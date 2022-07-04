using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DocumentFormat.OpenXml.Drawing.Diagrams;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace NanoSoftGreenMark.Controller
{
   
    public partial class ExportdbController : ExportController
    {
        [HttpGet("/export/csv/category")]
        public FileStreamResult ExportWebSiteOrdersToCSV(IEnumerable<Category> obj)
        {
            return ToCSV(ApplyQuery(obj.AsQueryable()));
        }

        [HttpGet("/export/excel/category")]
        public FileStreamResult ExportWebSiteOrdersToExcel(IEnumerable<Category> obj)
        {
            return ToExcel(ApplyQuery(obj.AsQueryable()));
        }
    }
}