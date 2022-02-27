<%@ Page Language="C#" AutoEventWireup="true" CodeFile="BaiTap1.aspx.cs" Inherits="BH3_BaiTap1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    Nhap tuoi<br />
        <asp:TextBox runat="server" ID="txtTuoi">
        </asp:TextBox>
        <br />
        <asp:Button runat="server" ID="btnChao"
             OnClick="btnChao_Click"
             Text = "Chao hoi" />
        <br />
        <asp:Label runat="server" ID="lblChao"></asp:Label>
    </div>
    </form>
</body>
</html>
