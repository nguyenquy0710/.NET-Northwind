<%@ Page Language="C#" AutoEventWireup="true" CodeFile="BG1.aspx.cs" Inherits="BG1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox runat="server" ID="txtTest"></asp:TextBox>
            <asp:Button runat="server"
                OnClick="btnCL_Click"
                ID="btnCL" Text="Kiem tra chan le" />
        </div>
    </form>
</body>
</html>
