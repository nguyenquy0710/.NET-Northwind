<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="HuongDanPhanTrang_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Repeater runat="server" ID="repSP">
                <ItemTemplate>
                    <p>
                        <%#Eval("ProductName") %>
                    </p>
                </ItemTemplate>
            </asp:Repeater>
            <ul>
                <li>
                    <asp:LinkButton runat="server"
                         ID="lbtnTruoc"
                         OnClick="lbtnTruoc_Click"
                        >Truoc</asp:LinkButton>
                </li>
                <li>
                    <asp:Label runat="server"
                         ID="lblHienTai"></asp:Label>
                </li>
                <li>
                    <asp:LinkButton runat="server"
                         ID="lbtnTiep"
                          OnClick="lbtnTiep_Click"
                        >Tiep</asp:LinkButton>
                </li>
            </ul>
        </div>
    </form>
</body>
</html>
