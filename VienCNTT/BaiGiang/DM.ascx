<%@ Control Language="C#" AutoEventWireup="true" CodeFile="DM.ascx.cs" Inherits="DM" %>
<asp:Repeater runat="server" ID="rptDM">
    <HeaderTemplate>
        <ul>
    </HeaderTemplate>
    <ItemTemplate>
        <li>
            <asp:LinkButton runat="server"
                 CommandArgument='<%#Eval("CategoryID") %>'
                 ID="lbtnDM" OnClick="lbtnDM_Click">
                <%#Eval("CategoryName") %>
            </asp:LinkButton>
        </li>
    </ItemTemplate>
    <FooterTemplate>
        </ul>
    </FooterTemplate>
</asp:Repeater>
