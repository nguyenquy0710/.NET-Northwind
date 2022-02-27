<%@ Page Language="C#" AutoEventWireup="true" CodeFile="SuKienVaHieuUng.aspx.cs" Inherits="BH9_SuKienVaHieuUng" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script src="../Scripts/jquery-2.2.2.min.js"></script>
    <script type="text/javascript">
        $(document).ready(function () {
            //cach 1: su dung truoc tiep:
            $('#google').click(function () {
                $(this).attr("href", "http://google.com.vn")
                .attr("target", "_blank");
            });
            //cach 2: su dung su kien thong qua ham bind:
            $('p').bind("mouseover", function () {
                $(this).text("noi dung moi");
            }).bind("mouseout", function () {
                $(this).text("Noi dung se thay doi");
            });
            //xu ly hieu ung cho doi tuong JQ:
            var hien = true;
            $('#btnHU').click(function () {
                if (hien)
                    //$('img').slideUp(2000);//2 giay
                    $('img').fadeOut(2000);
                else
                    //$('img').slideDown(2000);
                    $('img').fadeIn(2000);
                hien = !hien;
            });
        });
    </script>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <a id="google">Tim kiem bang google</a>
            <p>Noi dung se thay doi</p>
            <img src="nhatrang.jpg" />
            <br />
            <input id="btnHU" type="button" value="Hieu ung" />
        </div>
    </form>
</body>
</html>
