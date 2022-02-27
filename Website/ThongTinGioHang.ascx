<%@ Control Language="C#" AutoEventWireup="true" CodeFile="ThongTinGioHang.ascx.cs" Inherits="ThongTinGioHang" %>
<style type="text/css">   
    .ttgh table {
        text-align: center;
        width: 100%;
        background-color: white;
        border-radius: 5px 5px 5px 5px;
        margin-top: 4px;
    }
    .ttgh table tr .td {
       padding-right:90px;
    }
</style>
<asp:Panel runat="server" ID="pnTTGH" CssClass="ttgh">
    <table>

        <tr>
            <td class="td">Tổng tiền:</td>
            <td>
                <asp:Label runat="server" ID="lblTT"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="td">Số mặt hàng:</td>
            <td>
                <asp:Label runat="server" ID="lblSMH"></asp:Label>
            </td>
        </tr>
        <tr>
            <td colspan="2">
                <asp:LinkButton runat="server" OnClick="lbtnCT_Click" CssClass="xemCT" ToolTip="xem giỏ hàng" ID="lbtnCT">Xem giỏ hàng</asp:LinkButton>
            </td>
        </tr>
    </table>
</asp:Panel>
