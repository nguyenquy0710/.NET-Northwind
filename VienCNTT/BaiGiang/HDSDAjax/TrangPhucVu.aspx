<%@ Page Language="C#" AutoEventWireup="true" CodeFile="TrangPhucVu.aspx.cs" Inherits="HDSDAjax_TrangPhucVu" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Repeater runat="server" ID="rptSP">
                <ItemTemplate>
                    <p>
                        <%#Eval("ProductName") %>
                    </p>
                </ItemTemplate>
            </asp:Repeater>
        </div>
    </form>
</body>
</html>
