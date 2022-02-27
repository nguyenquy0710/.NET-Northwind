<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AppKhacSession.aspx.cs" Inherits="BH12_AppKhacSession" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Gia tri cua bien:
        <asp:Label runat="server" ID="lblGT"></asp:Label>
            <asp:Button runat="server" ID="btnTang"
                OnClick="btnTang_Click"
                Text="Tang gia tri" />
        </div>
    </form>
</body>
</html>
