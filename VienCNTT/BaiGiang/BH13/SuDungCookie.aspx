<%@ Page Language="C#" AutoEventWireup="true" CodeFile="SuDungCookie.aspx.cs" Inherits="BH13_SuDungCookie" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <asp:Panel runat="server"
         GroupingText ="Dang nhap">
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
             Text = "Dang nhap" />
    </asp:Panel>
    </div>
    </form>
</body>
</html>
