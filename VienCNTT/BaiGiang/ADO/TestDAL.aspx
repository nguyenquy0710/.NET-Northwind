<%@ Page Language="C#" AutoEventWireup="true" CodeFile="TestDAL.aspx.cs" Inherits="ADO_TestDAL" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            chon danh muc:<br />
            <asp:DropDownList runat="server" ID="ddlDM"></asp:DropDownList>
            <br />
            Don gia tu 
            <asp:TextBox runat="server" ID="txtTu"></asp:TextBox>
            den 
            <asp:TextBox runat="server" ID="txtDen"></asp:TextBox>
            <asp:Button runat="server" ID="btnTim"
                  OnClick="btnTim_Click"
                  Text="Tim" />
            <h3>Danh sach san pham tim duoc</h3>
            <asp:GridView runat="server" ID="grvTest"></asp:GridView>
        </div>
    </form>
</body>
</html>
