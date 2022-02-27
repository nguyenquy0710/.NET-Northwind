<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Ham.aspx.cs" Inherits="Ham" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox runat="server" ID="txtN"></asp:TextBox>
            <asp:Button runat="server" ID="btnTT"
                OnClick="btnTT_Click"
                Text="Tinh tong" />
            <p runat="server" id="pKQ"></p>
        </div>
    </form>
</body>
</html>
