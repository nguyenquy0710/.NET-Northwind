<%@ Page Language="C#" AutoEventWireup="true" CodeFile="TruyXuatDuLieuBangAJAX.aspx.cs" Inherits="HDSDAjax_TruyXuatDuLieuBangAJAX" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script type="text/javascript">
        window.onload = function () {
            var httpRequest;
            if (window.XMLHttpRequest) { // Mozilla, Safari, IE7+ ...
                httpRequest = new XMLHttpRequest();
            } else if (window.ActiveXObject) { // IE 6 and older
                httpRequest = new ActiveXObject("Microsoft.XMLHTTP");
            }
            httpRequest.open("GET", "TrangPhucVu.aspx", true);
            httpRequest.onreadystatechange = function () {
                if (httpRequest.status == 200
                     && httpRequest.readyState == 4) {
                    var div = document.getElementById('kq');
                    div.innerHTML = httpRequest.responseText;
                }
            }
            httpRequest.send();
        }
    </script>
</head>
<body>
    <form id="form1" runat="server">
        <div id="kq">
        </div>
    </form>
</body>
</html>
