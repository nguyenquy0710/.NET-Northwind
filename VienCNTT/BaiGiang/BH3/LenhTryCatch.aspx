<%@ Page Language="C#" AutoEventWireup="true" CodeFile="LenhTryCatch.aspx.cs" Inherits="BH3_LenhTryCatch" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table>
                <thead>
                    <tr>
                        <th>Giai phuong trinh bac 2 ax^2+bx+c=0
                        </th>
                    </tr>
                </thead>
                <tbody>
                    <tr>
                        <td>He so a</td>
                        <td>
                            <asp:TextBox runat="server"
                                ID="txtHSA"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>He so b</td>
                        <td>
                            <asp:TextBox runat="server"
                                ID="txtHSB"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>He so c</td>
                        <td>
                            <asp:TextBox runat="server"
                                ID="txtHSC"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td></td>
                        <td>
                            <asp:Button runat="server"
                                ID="btnGiai"
                                OnClick="btnGiai_Click"
                                Text="Giai pt" />
                        </td>
                    </tr>
                    <tr>
                        <td>Nghiem</td>
                        <td>
                            <asp:Label runat="server"
                                 ID="lblNghiem"></asp:Label>
                        </td>
                    </tr>
                </tbody>
            </table>
        </div>
    </form>
</body>
</html>
