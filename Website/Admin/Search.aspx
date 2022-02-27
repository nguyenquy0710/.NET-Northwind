<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/BackEnd.master" AutoEventWireup="true" CodeFile="Search.aspx.cs" Inherits="Admin_Search" %>

<asp:Content ID="Content1" ContentPlaceHolderID="cphTitle" runat="Server">
    Trang Tìm Kiếm
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphHead" runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="cphContent" runat="Server">
    <asp:Panel runat="server" ID="pnlDanhMuc" GroupingText="Cac Danh Muc Tim Thay">
        <asp:Repeater runat="server" ID="rptDanhMuc">
            <HeaderTemplate>
                <ul>
            </HeaderTemplate>
            <ItemTemplate>
                <li>
                    <asp:LinkButton runat="server" ID="lbtnTen" CommandArgument='<%#Eval("CategoryID") %>' OnClick="lbtnTen_Click"><%#Eval("CategoryName") %></asp:LinkButton>
                </li>
            </ItemTemplate>
            <FooterTemplate></ul></FooterTemplate>
        </asp:Repeater>
        <br />
        <hr />
        <br />
    </asp:Panel>
    <asp:Panel runat="server" ID="pnlSanPham" GroupingText="Cac San Pham Tim Thay">
        <asp:Repeater runat="server" ID="rptSanPham">
            <HeaderTemplate>
                <ul>
            </HeaderTemplate>
            <ItemTemplate>
                <li>
                    <asp:LinkButton runat="server" ID="lbtnTen" CommandArgument='<%#Eval("ProductID") %>' OnClick="lbtnTen_Click1"><%#Eval("ProductName") %></asp:LinkButton>
                </li>
            </ItemTemplate>
            <FooterTemplate></ul></FooterTemplate>
        </asp:Repeater>
    </asp:Panel>
</asp:Content>

