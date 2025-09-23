<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication2.Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
     <div class="container-fluid py-4">
    
    <div class="card border-0 shadow-sm" style="background-color: #FFFFFB;">
        <div class="card-body p-4">
            <div class="row mb-4">
                <div class="col-12">
                    <h5 class="text-dark mb-3">
                        <i class="fas fa-file-alt me-2"></i>
                        เลือก รายงานเครื่องจักรเครื่องมือและอุปกรณ์
                    </h5>
                    
                    <div class="report-selection">
                        <asp:RadioButtonList ID="rbBtnListTypeReport" runat="server" 
                            CssClass="report-list" CellPadding="8" 
                            AutoPostBack="True">
                            <asp:ListItem Value="1" Selected="True">บัญชีรายชื่อเครื่องมือเครื่องจักร (CI-F-PD-01)</asp:ListItem>
                            <asp:ListItem Value="5">ตัดเครื่องจักรออกจากทะเบียนประวัติ (CI-F-PD-06)</asp:ListItem>
                            <asp:ListItem Value="2" Selected="True">แบบฟอร์มการตรวจเครื่องมือเครื่องจักร (PB-F-PD-36)</asp:ListItem>
                            <asp:ListItem Value="10">ประวัติเครื่องจักร (CI-F-PD-38)</asp:ListItem>
                            <asp:ListItem Value="9">ใบขออนุมัติการตัดทรัพย์สินออกจากทะเบียน (CI-F-PD-39)</asp:ListItem>
                            <asp:ListItem Value="12">ใบแจ้งซ่อม (CI-F-PD-40)</asp:ListItem>
                            <asp:ListItem Value="7">รายการตรวจสอบ/การบำรุงรักษา เครื่องมือ/เครื่องจักร (CI-F-PD-41)</asp:ListItem>
                            <asp:ListItem Value="6">บัญชีทรายชื่อลายเครื่องจักร/เครื่องจักรจดทะเบียน (CI-F-PD-42)</asp:ListItem>
                            <asp:ListItem Value="8">แผนการบำรุงรักษาเครื่องมือ/เครื่องจักรประจำเดือน (CI-F-PD-43)</asp:ListItem>
                            <asp:ListItem Value="11">ใบตรวจสอบและส่งมอบเครื่องจักร (CI-F-PD-45)</asp:ListItem>
                        </asp:RadioButtonList>
                    </div>
                </div>
            </div>
            <asp:LinkButton ID="btnPrint" runat="server" CssClass="btn btn-light btn-lg" ToolTip="Print"
                OnClick="btnPrint_Click"><i class="fas fa-file-export me-2"></i> พิมพ์</asp:LinkButton>
            
        </div>
    </div>
</div>


</asp:Content>
