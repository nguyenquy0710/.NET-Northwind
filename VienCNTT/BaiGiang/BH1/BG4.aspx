<%@ Page Language="C#" AutoEventWireup="true" CodeFile="BG4.aspx.cs" Inherits="BG4" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Su dung cac lenh lap de lam viec voi mang</h2>
            <asp:Button
                runat="server"
                ID="btnTT"
                OnClick="btnTT_Click"
                Text="Tinh tong" />

            <asp:Button
                runat="server"
                ID="btnDem"
                OnClick="btnDem_Click"
                Text="Dem phan tu duong" />
            <br />
            <asp:TextBox runat="server"
                 ID="txtTim"></asp:TextBox>
            <asp:Button
                runat="server"
                ID="btnTim"
                OnClick="btnTim_Click"
                Text="Tim kiem" />
            <br />
            <asp:Label runat="server"
                 ID="lblTim"></asp:Label>
        </div>
    </form>
</body>
</html>
