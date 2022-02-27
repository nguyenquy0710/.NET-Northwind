<%@ Page Language="C#" AutoEventWireup="true" CodeFile="TinhDTTG.aspx.cs" Inherits="BH4_TinhDTTG" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h3>Tinh dien tich tam giac</h3>
            Canh a
        <asp:TextBox runat="server"
            ID="txtCanhA"></asp:TextBox>
            <br />
            Canh b
        <asp:TextBox runat="server"
            ID="txtCanhB"></asp:TextBox>
            <br />
            Canh c
        <asp:TextBox runat="server"
            ID="txtCanhC"></asp:TextBox>
            <br />
            <asp:Button runat="server"
                ID="btnTinhDT"
                OnClick="btnTinhDT_Click"
                Text="Tinh dien tich" />
            <br />
            <asp:Label runat="server"
                 ID="lblKQ"></asp:Label>
        </div>
    </form>
</body>
</html>
