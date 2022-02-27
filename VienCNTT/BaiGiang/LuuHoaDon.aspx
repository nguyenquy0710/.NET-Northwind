<%@ Page Title="" Language="C#" MasterPageFile="~/FrontEnd.master" AutoEventWireup="true" CodeFile="LuuHoaDon.aspx.cs" Inherits="LuuHoaDon" %>

<asp:Content ID="Content1" ContentPlaceHolderID="cphHead" runat="Server">
    <style type="text/css">
        #thanhToan input[type='text'], #thanhToan textarea {
            width: 90%;
        }

    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphMiddle" runat="Server">
    <table id="thanhToan">
        <tr>
            <td style="width: 25%;">Mã khách hàng
            </td>
            <td>
                <h3 runat="server" id="h3MaKH"></h3>
            </td>
        </tr>
        <tr>
            <td>Họ tên người nhận
            </td>
            <td>
                <asp:TextBox runat="server" ID="txtHT"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>Số điện thoại
            </td>
            <td>
                <asp:TextBox runat="server" ID="txtDT"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>Ngày giao hàng
            </td>
            <td>
                <asp:TextBox runat="server" ID="txtNgayGiao"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>Địa chỉ giao hàng
            </td>
            <td>
                <asp:TextBox runat="server" ID="txtDC"
                    Rows="4"
                    TextMode="MultiLine"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>Tổng tiền
            </td>
            <td>
                <h3 runat="server" id="h3TT"></h3>
            </td>
        </tr>
        <tr>
            <td></td>
            <td>
                <asp:Button runat="server" ID="btnLuu"
                    OnClick="btnLuu_Click"
                    Text="Lưu hóa đơn" />
            </td>
        </tr>
         <tr>
            <td></td>
            <td>
             <h3 runat="server" id="h3TB"></h3>
            </td>
        </tr>
    </table>
</asp:Content>


