<%@ Page Language="C#" AutoEventWireup="true" CodeFile="GiaiPTBH.aspx.cs" Inherits="BH10_GiaiPTBH" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        input[type='text'] {
            margin-left:20px;
            width:300px;
        }
        input[type='button'] {
            margin-top:20px;
        }
    </style>
    <script src="../Scripts/jquery-2.2.2.min.js"></script>
    <script src="Nghiem.js"></script>
    <script src="PTBH.js"></script>
    <script type="text/javascript">
        $(document).ready(function () {
            $('#btnGiai').click(function () {
                var a = parseFloat($('#txtHSA').val());
                var b = parseFloat($('#txtHSB').val());
                var c = parseFloat($('#txtHSC').val());
                var pt = new PTBH(a, b, c);
                var n = pt.giai();
                var kq = $('#spnKQ');
                if (n == null) kq.text("Phuong trinh vo nghiem");
                else kq.text("Nghiem la: "+n.toString());
            });
        });
    </script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <h2>Giai phuong trinh bac 2:</h2>
        He so a <input type="text" id="txtHSA" /><br />
        He so a <input type="text" id="txtHSB" /><br />
        He so a <input type="text" id="txtHSC" /><br />
        <input id="btnGiai" type="button" value="Giai pt" />
        <span id="spnKQ"></span>
    </div>
    </form>
</body>
</html>
