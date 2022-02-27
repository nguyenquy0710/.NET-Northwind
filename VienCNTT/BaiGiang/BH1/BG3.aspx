<%@ Page Language="C#" AutoEventWireup="true" CodeFile="BG3.aspx.cs" Inherits="BG3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h3>Tim so ngay cua thang, nam</h3>
            Nhap nam:
        <asp:TextBox runat="server"
            ID="txtNam"></asp:TextBox>
            <br />
            Chon thang:
        <asp:DropDownList runat="server"
            ID="ddlThang">
            <asp:ListItem Text="1" Selected="True"></asp:ListItem>
            <asp:ListItem Text="2"></asp:ListItem>
            <asp:ListItem Text="3"></asp:ListItem>
            <asp:ListItem Text="4"></asp:ListItem>
            <asp:ListItem Text="5"></asp:ListItem>
            <asp:ListItem Text="6"></asp:ListItem>
            <asp:ListItem Text="7"></asp:ListItem>
            <asp:ListItem Text="8"></asp:ListItem>
            <asp:ListItem Text="9"></asp:ListItem>
            <asp:ListItem Text="10" ></asp:ListItem>
            <asp:ListItem Text="11"></asp:ListItem>
            <asp:ListItem Text="12"></asp:ListItem>
        </asp:DropDownList>
            <br />
            <asp:Button runat="server"
                ID="btnTimSN"
                OnClick="btnTimSN_Click"
                Text="Tim so ngay" />
            <br />
            <asp:Label runat="server"
                 ID="lblSN"></asp:Label>
        </div>
    </form>
</body>
</html>
