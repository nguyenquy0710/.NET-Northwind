<%@ Page Language="C#" AutoEventWireup="true" CodeFile="DomAndEvent.aspx.cs" Inherits="BH9_DomAndEvent" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script type="text/javascript">
        window.onload = function () {
            //lay phan tu theo tag name:
            //ip la mot array:
            var ip = document.getElementsByTagName('input');

            ip[1].onclick = function () {
                alert(this.name);
            }
            //lay phan tu theo id:
            //ket qua la 1 object
            var idIP = document.getElementById('idTest');
            idIP.onmouseover = function () {
                this.value = "Da thay doi";
            }
            idIP.onmouseout = function () {
                this.value = "Dua chuot di dau the";
            }
            //lay phan tu theo class name:
            //ket qua tra ve la 1 array
            var clsIP = document.getElementsByClassName('classTest');
            clsIP[0].style.backgroundColor = "blue";
            //them phan tu moi:
            var pTag = document.createElement('p');
            pTag.innerHTML = "khi ta o chi la noi dat o";
            //them thuoc tinh:
            pTag.setAttribute("style", "color:red; font-size:large; background-color:green;");
            document.getElementById('divTest').appendChild(pTag);

            //xoa phan tu:
            //var cacTheP = document.getElementsByTagName('p');
            //document.getElementById('divTest').removeChild(cacTheP[0]);
        }
    </script>
</head>
<body>
    <form id="form1" runat="server">
        <div id="divTest">
            <p>day la mot doan van ban</p>
            <input
                name="nameTest"
                id="idTest"
                class="classTest"
                type="button" value="Click me" />
        </div>
    </form>
</body>
</html>
