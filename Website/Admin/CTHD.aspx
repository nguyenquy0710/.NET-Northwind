<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/BackEnd.master" AutoEventWireup="true" CodeFile="CTHD.aspx.cs" Inherits="Admin_CTHD" %>

<asp:Content ID="Content1" ContentPlaceHolderID="cphTitle" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphHead" runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="cphContent" runat="Server">
    <asp:UpdatePanel runat="server" ID="udpRight">
        <ContentTemplate>
            <h3 runat="server" id="h3TB"></h3>
        </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>

