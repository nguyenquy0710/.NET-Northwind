<%@ Control Language="C#" AutoEventWireup="true" CodeFile="TimKiem.ascx.cs" Inherits="TimKiem" %>
<style type="text/css">
    .timkiem {
        width: 95%;
        text-align: center;
         border-radius:5px 5px;
         box-shadow:2px 2px 2px #640d71;
    }
</style>
<asp:Panel DefaultButton="ibtnTK" runat="server">
    <table id="timkiem">
        <tr>
            <td style="width: 90%;">
                <asp:TextBox runat="server" ID="txtTK" CssClass="timkiem"
                    Height="30"
                    placeholder="Nhập từ khóa tìm kiếm"
                    ></asp:TextBox>
            </td>
            <td>
                <asp:ImageButton runat="server"
                    ID="ibtnTK" ImageUrl="~/Image/Layout/search.png"
                    OnClick="ibtnTK_Click"
                    Height="40"
                    ToolTip="tìm kiếm"
                    AlternateText="" />
            </td>
        </tr>
    </table>
</asp:Panel>