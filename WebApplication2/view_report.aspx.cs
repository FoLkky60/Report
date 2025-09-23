using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using System.Net;
using System.IO;

namespace WebApplication2
{
    public partial class view_report : System.Web.UI.Page
    {
        private ReportDocument crpt = new ReportDocument();
        protected void Page_Load(object sender, EventArgs e)
        {
            getDateReportMachineListCI();
        }

        private void getDateReportMachineListCI()
        {
            crpt.Load(Server.MapPath("/Report/MachineList.rpt"));
            deleteFolderLast();
            ConvertToPDF_preview();
        }
        private void ConvertToPDF_preview()
        {
            // Export File To PDF
            string sysDateCurrent = DateTime.Now.ToString("yyyyMMdd");
            checkFolderToDayCurrent(sysDateCurrent);
            string folderPath = Server.MapPath("~/tempPDF/" + sysDateCurrent + "/");
            string FilePath = folderPath + "Report_MT" + sysDateCurrent + ".pdf";
            crpt.ExportOptions.ExportFormatType = ExportFormatType.PortableDocFormat;
            crpt.ExportOptions.ExportDestinationType = ExportDestinationType.DiskFile;
            var objDiskOpt = new DiskFileDestinationOptions();
            objDiskOpt.DiskFileName = FilePath;
            crpt.ExportOptions.DestinationOptions = objDiskOpt;
            crpt.Export();

            var User = new WebClient();
            byte[] FileBuffer = User.DownloadData(FilePath);

            Context.Response.Clear();
            Context.Response.Buffer = true;
            Context.Response.Cache.SetCacheability(HttpCacheability.NoCache);
            Context.Response.AppendHeader("title", "Report");
            Context.Response.ContentType = "application/pdf";
            Context.Response.AddHeader("content-disposition", "inline; filename=MachineListCI_" + sysDateCurrent + ".pdf");
            Context.Response.BinaryWrite(FileBuffer);
            Context.Response.Flush();
            Context.Response.End();


        }
        private void deleteFolderLast()
        {
            string folderPath = Server.MapPath("~/tempPDF/");
            var di = new DirectoryInfo(folderPath);
            foreach (FileInfo file in di.GetFiles())
                file.Delete();
            int sToDay = Convert.ToInt32(DateTime.Now.ToString("yyyyMMdd"));
            foreach (DirectoryInfo dir in di.GetDirectories())
            {
                string _dr = dir.Name;
                if ((_dr.ToString() ?? "") != (sToDay.ToString() ?? ""))
                {
                    dir.Delete(true);
                }
            }
        }
        private void checkFolderToDayCurrent(string sysDateCurrent)
        {

            string folderDayCurrent = Server.MapPath("~/tempPDF/" + sysDateCurrent);
            if (!Directory.Exists(folderDayCurrent))
            {
                Directory.CreateDirectory(folderDayCurrent);
            }
        }
    }
}