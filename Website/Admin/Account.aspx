<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/BackEnd.master" AutoEventWireup="true" CodeFile="Account.aspx.cs" Inherits="Admin_Account" %>

<asp:Content ID="Content1" ContentPlaceHolderID="cphTitle" runat="Server">
    Tài Khoản
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphHead" runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="cphContent" runat="Server">
    <asp:UpdatePanel runat="server" ID="udpRight">
        <ContentTemplate>
            day la trang ca nhan
        </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>

