<%@ Control Language="C#" AutoEventWireup="true" CodeFile="TimKiem.ascx.cs" Inherits="TimKiem" %>
<style type="text/css">
    .timkiem {
        width: 100%;
        text-align: center;
    }
</style>
<asp:Panel DefaultButton="ibtnTK" runat="server">
    <table>
        <tr>
            <td style="width: 90%;">
                <asp:TextBox runat="server" ID="txtTK" CssClass="timkiem"
                    Height="30"
                    placeholder="Gõ tên hàng hóa"></asp:TextBox>
            </td>
            <td>
                <asp:ImageButton runat="server"
                    ID="ibtnTK" ImageUrl="~/Hinh/Layout/search.png"
                    OnClick="ibtnTK_Click"
                    Height="30"
                    AlternateText="" />
            </td>
        </tr>
    </table>
</asp:Panel>
