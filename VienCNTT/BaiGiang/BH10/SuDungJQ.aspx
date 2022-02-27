<%@ Page Language="C#" AutoEventWireup="true" CodeFile="SuDungJQ.aspx.cs" Inherits="BH10_SuDungJQ" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script src="../Scripts/jquery-2.2.2.min.js"></script>
    <script type="text/javascript">
        //$ hoac jQuery = constructor cua jquery.
        $(document).ready(function () {
            //selector = tag:
            //$('p').text('Noi dung moi');//setter.
            //alert($('p').text());//getter.
            //selector = id:
            $('#divJQ')//su dung jq chain
                .css("background-color", "green")
                .attr("style", "border:2px solid red;")
                .click(function () {
                    alert($(this).html());
                });
            //selector = class:
            $('.toDo').css("color", "red");
            //selector = compound (phuc hop: tag, id, class):
            $('p.toDo').text($('p.toDo').text().toUpperCase());
        });
    </script>
</head>
<body>
    <form id="form1" runat="server">
        <div id="divJQ">
            <h2 class="toDo">Tieu de h2</h2>
            <p>doan van ban 1</p>
            <p class="toDo">doan van ban 2</p>
            <p>doan van ban 3</p>
        </div>
    </form>
</body>
</html>
