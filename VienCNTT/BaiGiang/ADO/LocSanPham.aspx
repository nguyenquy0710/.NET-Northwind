<%@ Page Language="C#" AutoEventWireup="true" CodeFile="LocSanPham.aspx.cs" Inherits="ADO_LocSanPham" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Chọn danh muc:<br />
            <asp:DropDownList 
                 AutoPostBack="true"
                 OnSelectedIndexChanged="ddlDM_SelectedIndexChanged"
                runat="server" ID="ddlDM">
            </asp:DropDownList>
            <br />
            Tìm kiếm sản phẩm: &nbsp;
            <asp:TextBox runat="server" ID="txtTen"></asp:TextBox>
            <asp:Button runat="server" ID="btnTim" Text="Tìm"
                 OnClick="btnTim_Click"
                 />
            <br />
            Lọc sản phẩm theo giá: &nbsp;
            Từ : <asp:TextBox runat="server" ID="txtTu"></asp:TextBox>
            Đến: <asp:TextBox runat="server" ID="txtDen"></asp:TextBox>
            <asp:Button runat="server" ID="btnLoc"
                 OnClick="btnLoc_Click"
                 Text="Lọc" />
            <br />Danh sách sản phẩm:<br />
            <asp:GridView runat="server" ID="grvSP"></asp:GridView>
        </div>
    </form>
</body>
</html>
