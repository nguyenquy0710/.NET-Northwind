<%@ Page Language="C#" AutoEventWireup="true" CodeFile="BG2.aspx.cs" Inherits="BG2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            So ngay thue xe:
        <asp:TextBox runat="server"
            ID="txtSN"></asp:TextBox>
            <br />
            Loai xe:
        <asp:TextBox runat="server"
            ID="txtLoaiXe"></asp:TextBox>
            <br />
            <asp:Button runat="server"
                ID="btnTT" 
                 OnClick="btnTT_Click"
                Text="Tinh tien" />
        </div>
    </form>
</body>
</html>
