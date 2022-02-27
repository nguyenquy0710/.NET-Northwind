<%@ Control Language="C#" AutoEventWireup="true" CodeFile="DangNhap.ascx.cs" Inherits="BH14_DangNhap" %>
<asp:Panel runat="server"
    GroupingText="Dang nhap">
    Ten dang nhap<br />
    <asp:TextBox runat="server"
        ID="txtTenDN"></asp:TextBox>
    <br />
    Mat khau<br />
    <asp:TextBox runat="server"
        ID="txtMK" TextMode="Password"></asp:TextBox>
    <br />
    <asp:CheckBox Text="Ghi nho tai khoan" runat="server" ID="chkGN" />
    <br />
    <asp:Button runat="server" ID="btnDN"
        OnClick="btnDN_Click"
        Text="Dang nhap" />
    <br />
    <asp:Label runat="server" ID="lblTB"></asp:Label>
</asp:Panel>
