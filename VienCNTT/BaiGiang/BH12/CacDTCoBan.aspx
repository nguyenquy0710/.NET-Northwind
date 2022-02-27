<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CacDTCoBan.aspx.cs" Inherits="BH12_CacDTCoBan" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label runat="server"
                ID="lblRawURL"></asp:Label>
            <br />
            <asp:Label runat="server"
                ID="lblURL"></asp:Label>
            <br />
            <asp:Label runat="server"
                ID="lblQS"></asp:Label>
            <br />
            <asp:TextBox runat="server"
                 ID="txtDuLieu"></asp:TextBox>
            <asp:Button runat="server"
                ID="btnTF"
                OnClick="btnTF_Click"
                Text="Transfer" />
             <asp:Button runat="server"
                ID="btnRedirect"
                OnClick="btnRedirect_Click"
                Text="Redirect" />
        </div>
    </form>
</body>
</html>
