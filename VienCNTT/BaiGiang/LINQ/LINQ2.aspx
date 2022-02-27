<%@ Page Language="C#" AutoEventWireup="true" CodeFile="LINQ2.aspx.cs" Inherits="LINQ_LINQ2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    Chon danh muc
        <br />
        <asp:DropDownList runat="server" ID="ddlDM"
             AutoPostBack="true"
             OnSelectedIndexChanged="ddlDM_SelectedIndexChanged"
            ></asp:DropDownList>
        <br />
        Danh sach san pham<br />
        <asp:GridView runat="server" ID="grvSP"></asp:GridView>
    </div>
    </form>
</body>
</html>
