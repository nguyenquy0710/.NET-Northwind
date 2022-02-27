<%@ Control Language="C#" AutoEventWireup="true" CodeFile="ThongTinGH.ascx.cs" Inherits="ThongTinGH" %>
<style type="text/css">
    .ttgh table {
        text-align: center;
        width: 100%;
    }
</style>
<asp:Panel runat="server" ID="pnlTTGH" CssClass="ttgh"
    GroupingText="Thông tin giỏ hàng">
    <table>
        <tr>
            <td>Tổng tiền</td>
            <td>
                <asp:Label runat="server" ID="lblTT"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>Số mặt hàng</td>
            <td>
                <asp:Label runat="server" ID="lblSoMH"></asp:Label>
            </td>
        </tr>
        <tr>
            <td colspan="2">
                <asp:LinkButton runat="server" ID="lbtnCT"
                    OnClick="lbtnCT_Click">Xem chi tiết</asp:LinkButton>
            </td>
        </tr>
    </table>
</asp:Panel>
