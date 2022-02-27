<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ChiaSeDuLieu.aspx.cs" Inherits="BH12_ChiaSeDuLieu" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:LinkButton runat="server"
                ID="lbtnApp"
                OnClick="lbtnApp_Click"
                Text="Su dung bien application"></asp:LinkButton>

            <asp:LinkButton runat="server"
                ID="lbtnSession"
                OnClick="lbtnSession_Click">
                Su dung bien session
            </asp:LinkButton>
        </div>
    </form>
</body>
</html>
