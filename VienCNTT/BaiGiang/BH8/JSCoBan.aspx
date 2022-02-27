<%@ Page Language="C#" AutoEventWireup="true" CodeFile="JSCoBan.aspx.cs" Inherits="BH8_JSCoBan" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script src="JSCoBan.js"></script>
     <script src="SuDungSET.js"></script>
    <script type="text/javascript">
        //khai bao mang:
        var daySo = [];
        window.onload = function () {
            //goi ham fnTest:
            //fnTest();
            //alert(tinhTong(10));
            //var thang = parseInt(prompt("nhap thang"));
            //if (isNaN(thang)) {
            //    alert('thang khong hop le');
            //    return;
            //}
            //var nam = parseInt(prompt("nhap nam"));
            //if (isNaN(nam)) {
            //    alert('nam khong hop le');
            //    return;
            //}
            //var kq = timSoNgay(thang, nam);
            //document.write('thang '+thang+', nam '+nam+' co '+ kq + ' ngay');
            //them du lieu vao mang:
            var cs = 0;
            for (var i = 1; i <= 10; i++)
                if (i % 2 > 0) daySo[cs++] = i;
            //xoa phan tu co chi so = 2:
            for (var i = 2; i < daySo.length - 1; i++)
                daySo[i] = daySo[i + 1];
            daySo.length--;

            //hien thi mang:
            var kq = "";
            for (var i = 0; i < daySo.length; i++)
                kq += daySo[i] + ", ";
            document.write(kq + "<br/>");
            
            //tinh tong cac phan tu trong mang:
            var tong = 0;
            for (var i = 0; i < daySo.length; i++)
                tong += daySo[i];
            document.write('tong = ' + tong + "<br/>");

            suDungSet();
        }
    </script>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <input type="button"
                onclick="alert('ban da click');"
                value="test" />
        </div>
    </form>

</body>
</html>
