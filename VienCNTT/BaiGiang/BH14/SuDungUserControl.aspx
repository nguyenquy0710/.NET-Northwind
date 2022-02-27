<%@ Page Language="C#" AutoEventWireup="true" CodeFile="SuDungUserControl.aspx.cs" Inherits="BH14_SuDungUserControl" %>

<%@ Register Src="~/BH14/Test.ascx"
    TagPrefix="uc1"
    TagName="Test" %>
<%@ Register Src="~/BH14/DangNhap.ascx"
    TagPrefix="uc1" TagName="DangNhap" %>





<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <uc1:Test runat="server" ID="ucTest" />
            <br />
            <uc1:DangNhap runat="server" ID="ucDangNhap" />
        </div>
    </form>
</body>
</html>
