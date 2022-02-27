<%@ Control Language="C#" AutoEventWireup="true" CodeFile="DanhMuc.ascx.cs" Inherits="DanhMuc" %>
<asp:Repeater runat="server" ID="rptDM">
    <HeaderTemplate>
        <ul>
    </HeaderTemplate>
    <ItemTemplate>
        <li>
            <asp:LinkButton runat="server" ID="lbtnDM" CssClass="lbtnDM" ToolTip='<%#Eval("CategoryName") %>' OnClick="lbtnDM_Click" CommandArgument='<%#Eval("CategoryID") %>'><%#Eval("CategoryName") %></asp:LinkButton>
        </li>
    </ItemTemplate>
    <FooterTemplate>
        </ul>
    </FooterTemplate>
</asp:Repeater>
