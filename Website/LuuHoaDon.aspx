<%@ Page Title="" Language="C#" MasterPageFile="~/FrontEnd.master" AutoEventWireup="true" CodeFile="LuuHoaDon.aspx.cs" Inherits="LuuHoaDon" %>

<asp:Content ID="Content1" ContentPlaceHolderID="cphTitle" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphHead" runat="Server">
    <style type="text/css">
        #thanhToan input[type='text'], #thanhToan textarea {
            width: 90%;
        }
        #thanhToan{
             margin-left:20px;          
        }
        .cot1 {
            height: 10px;
            width: 20%;
            background-color: rgb(128, 128, 128);
            border-radius: 10px 10px;
            -webkit-box-shadow: 0 0 10px rgb(0, 0, 0);
        }
         .button {
            background-color: #4ddcc2;
            border-radius: 10px 10px;
            -webkit-box-shadow: 0 0 10px rgb(10, 25, 196);
        }

            .button:hover {
                color: black;
                background-color: #03caa6;
            }

        .txt {
            width: 1024px;
        }

        .textbox {
            text-align:center;
            background-color: #8cb6b2;
            border-radius: 10px 10px;
            -webkit-box-shadow: 0 0 10px rgb(67, 11, 111);
        }

            .textbox:hover {
                background-color: #56d3d3;
            }
    </style>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="cphMiddle" runat="Server">
    <table id="thanhToan">
        <tr id="tr">
            <td class="cot1">
                <h4>Mã khách hàng</h4>
            </td>
            <td>
                <h3 runat="server" id="h3MaKH" style="color:red;"></h3>
            </td>
        </tr>
        <tr>
            <td class="cot1">
                <h4>Họ tên người nhận</h4>
            </td>
            <td class="txt">
                <asp:TextBox runat="server" CssClass="textbox" Height="25" ID="txtHT"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="cot1">
                <h4>Số điện thoại</h4>
            </td>
            <td class="txt">
                <asp:TextBox runat="server" CssClass="textbox" Height="25" ID="txtDT"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="cot1">
                <h4>Ngày giao hàng</h4>
            </td>
            <td class="txt">
                <asp:TextBox runat="server" CssClass="textbox" Height="25" ID="txtNgayGiao"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="cot1">
                <h4>Địa chỉ giao hàng</h4>
            </td>
            <td class="txt">
                <asp:TextBox runat="server" ID="txtDC"
                    Rows="4"
                    CssClass="textbox"
                    TextMode="MultiLine"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="cot1">
                <h4>Tổng tiền</h4>
            </td>
            <td>
                <h3 runat="server" id="h3TT" style="color:red;"></h3>
            </td>
        </tr>
        <tr>
            <td></td>
            <td>
                <asp:Button runat="server" CssClass="button" ID="btnLuu"
                    OnClick="btnLuu_Click"
                    Font-Size="17px" Width="100" Height="30"
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

