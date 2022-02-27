<%@ Page Language="C#" AutoEventWireup="true" CodeFile="SlideShow.aspx.cs" Inherits="BH10_SlideShow" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script src="../Scripts/jquery-2.2.2.min.js"></script>
    <script type="text/javascript">
        var hienTai = 1;
        function loadHinh() {
            var url = "hinh/" + hienTai + ".jpg";
            $('#hinh').attr("src", url);
        }
        $(document).ready(function () {
            loadHinh();
            $('#next').click(function () {
                hienTai++;
                if (hienTai > 4) hienTai = 1;
                loadHinh();
            });
            $('#pre').click(function () {
                hienTai--;
                if (hienTai < 1) hienTai = 4;
                loadHinh();
            });
        });
    </script>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <img id="hinh" alt="not found" />
            <br />
            <input id="pre" type="button" value="Previous" />
            <input id="next" type="button" value="Next" />
        </div>
    </form>
</body>
</html>
