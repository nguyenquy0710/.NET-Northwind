<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Layout.aspx.cs" Inherits="BH7_Layout" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="Common.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div id="container">
            <div id="header"></div>
            <div id="menu">
                <ul>
                    <li>
                        <a href="#">Trang chu</a>
                    </li>
                    <li>
                        <a href="SanPham.aspx">San pham</a>
                    </li>
                    <li>
                        <a href="#">Dich vu</a>
                    </li>
                    <li>
                        <a href="#">Lien he</a>
                    </li>
                    <li>
                        <a href="#">Tin tuc</a>
                    </li>
                </ul>
            </div>
            <div id="content">
                <div id="left"></div>
                <div id="middle"></div>
                <div id="right"></div>
            </div>
            <div id="footer">
                <ul>
                    <li>Địa chỉ: Ngõ 70, Tô Ký, TCH, Q.12, Tp.HCM
                    </li>
                    <li>Điện thoại: 08123456; Fax: 08654321
                    </li>
                    <li>Email: khongbiet.gmail.com
                    </li>
                    <li>Website: <a href='http://danglam.com.vn'>
                        danglam.com.vn
                    </a>
                    </li>
                </ul>
            </div>
        </div>
    </form>
</body>
</html>
