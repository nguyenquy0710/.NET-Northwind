<%@ Page Language="C#" AutoEventWireup="true" CodeFile="DangNhap.aspx.cs" Inherits="Admin_DangNhap" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        ul li {
            list-style:none;
            line-height:30px;
            height:30px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div style="width: 100%; margin: auto; text-align: center;">
            <ul>
                <li>Tên đăng nhập
                </li>
                <li>
                    <asp:TextBox runat="server" ID="txtTen"></asp:TextBox>
                </li>
                <li>Mật khẩu
                </li>
                <li>
                    <asp:TextBox runat="server" ID="txtMK"
                        TextMode="Password"></asp:TextBox>
                </li>
                <li>
                    <asp:Button runat="server" ID="btnDN"
                        OnClick="btnDN_Click"
                        Text="Đăng nhập" />
                </li>
                <li>
                    <h3 runat="server" id="h3TB"></h3>
                </li>
            </ul>
        </div>
    </form>
</body>
</html>
