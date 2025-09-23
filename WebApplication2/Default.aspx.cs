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
    public partial class Default : Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnPrint_Click(object sender, EventArgs e)
        {
            if (this.rbBtnListTypeReport.SelectedValue == "1") // ประวัติเครื่องจักรและอุปกรณ์
            {
               //ReportMachineHository();
            }
            else if (this.rbBtnListTypeReport.SelectedValue == "2") // บัญชีรายชื่อเครื่องมือเครื่องจักร (CI-F-PD-01)
            {
                ReportMachineList();
            }
            else if (this.rbBtnListTypeReport.SelectedValue == "3") // การบำรุงรักษาเครื่องจักร (CI-F-PD-08)
            {
                ReportMachineList();
            }
            else if (this.rbBtnListTypeReport.SelectedValue == "4") // แผนการบำรุงเครื่องจักร (CI-F-PD-07)
            {
                ReportMachineList();
            }
            else if (this.rbBtnListTypeReport.SelectedValue == "5") // ตัดเครื่องจักรออกจากทะเบียนประวัติ (CI-F-PD-06)
            {
                ReportMachineList();
            }
            else if (this.rbBtnListTypeReport.SelectedValue == "6") // การตรวจสอบดูแลเครื่องมือเครื่องจักรประจำวัน Daily Check Sheet (CI-F-PD-03)
            {
                Report1();
            }
            else if (this.rbBtnListTypeReport.SelectedValue == "7") // การตรวจสอบดูแลเครื่องมือเครื่องจักรประจำวัน Daily Check Sheet (CI-F-PD-03)
            {
                ReportMachineList();
            }
            else if (this.rbBtnListTypeReport.SelectedValue == "8") // การตรวจสอบดูแลเครื่องมือเครื่องจักรประจำวัน Daily Check Sheet (CI-F-PD-03)
            {
                ReportMachineList();
            }
            else if (this.rbBtnListTypeReport.SelectedValue == "9") // การตรวจสอบดูแลเครื่องมือเครื่องจักรประจำวัน Daily Check Sheet (CI-F-PD-03)
            {
                ReportMachineList();
            }
            else if (this.rbBtnListTypeReport.SelectedValue == "10") // การตรวจสอบดูแลเครื่องมือเครื่องจักรประจำวัน Daily Check Sheet (CI-F-PD-03)
            {
                ReportMachineList();
            }
            else if (this.rbBtnListTypeReport.SelectedValue == "11") // การตรวจสอบดูแลเครื่องมือเครื่องจักรประจำวัน Daily Check Sheet (CI-F-PD-03)
            {
                ReportMachineList();
            }
            else if (this.rbBtnListTypeReport.SelectedValue == "12") // การตรวจสอบดูแลเครื่องมือเครื่องจักรประจำวัน Daily Check Sheet (CI-F-PD-03)
            {
                ReportMachineList();
            }
            else if (this.rbBtnListTypeReport.SelectedValue == "WI") // WI วิธีการปฎิบัติงาน Work Instruction (CI-F-PD-09)
            {
               // ReportMachineWI();
            }
        }

        private void ReportMachineList()
        {

            string pageUrl = "view_report.aspx?";
            string pMachineType = "";
            string pDept = "";
            string pMachineCode = "";
            string parameter = pageUrl + "pMachineType=" + pMachineType + "&pMachineCode=" + pMachineCode + "&pDept=" + pDept;
            ScriptManager.RegisterStartupScript(this, this.GetType(), "Report", String.Format("window.open({0});", "'" + parameter + "'"), true);
        }
        private void Report1()
        {
            string pageUrl = "view_report.aspx?";
            string pMachineType = "6";
            string pDept = "";
            string pMachineCode = "";
            string parameter = pageUrl + "pMachineType=" + pMachineType + "&pMachineCode=" + pMachineCode + "&pDept=" + pDept;
            ScriptManager.RegisterStartupScript(this, this.GetType(), "Report", String.Format("window.open({0});", "'" + parameter + "'"), true);
        }

    }
}