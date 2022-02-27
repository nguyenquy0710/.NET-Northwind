<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AjaxCoBan.aspx.cs" Inherits="HDSDAjax_AjaxCoBan" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script type="text/javascript">
        window.onload = function () {
            var httpRequest;
            //tao request:
            if (window.XMLHttpRequest) { // Mozilla, Safari, IE7+ ...
                httpRequest = new XMLHttpRequest();
            } else if (window.ActiveXObject) { // IE 6 and older
                httpRequest = new ActiveXObject("Microsoft.XMLHTTP");
            }
            //mo ket noi den server
            //httpRequest.open("GET", "DuLieu.xml", true);
            httpRequest.open("GET", "BaiTho.txt", true);
            //callback function
            httpRequest.onreadystatechange = function () {
                if (httpRequest.status == 200
                     && httpRequest.readyState == 4) {
                    //alert(httpRequest.responseText);
                    var div = document.getElementById('kq');
                    div.innerHTML = httpRequest.responseText;
                }
            }
            //gui request:
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
