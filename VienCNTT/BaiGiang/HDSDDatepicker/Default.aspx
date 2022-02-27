<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="HDSDDatepicker_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script src="../Scripts/jquery-2.2.2.min.js"></script>
    <script src="../Scripts/bootstrap.min.js"></script>
    <script src="../Scripts/bootstrap-datepicker.min.js"></script>

    <script src="../Scripts/locales/bootstrap-datepicker.vi.min.js"></script>


    <link href="../Content/bootstrap.min.css" rel="stylesheet" />
    <link href="../Content/bootstrap-datepicker.min.css" rel="stylesheet" />
    <script type="text/javascript">
        $(document).ready(function () {
            $('.ngay').datepicker(
                {
                    'language': 'vi',
                    'format': 'dd/mm/yyyy'
                }
                );
        });
    </script>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox
                CssClass="ngay"
                runat="server" ID="txtDate"></asp:TextBox>
        </div>
    </form>
</body>
</html>
