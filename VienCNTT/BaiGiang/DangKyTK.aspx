<%@ Page Title="" Language="C#" MasterPageFile="~/FrontEnd.master" AutoEventWireup="true" CodeFile="DangKyTK.aspx.cs" Inherits="DangKyTK" %>

<asp:Content ID="Content1" ContentPlaceHolderID="cphHead" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphMiddle" runat="Server">
    <table class="dinhdangbang">
        <tr>
            <td>Tên đăng nhập
            </td>
            <td>
                <asp:TextBox runat="server"
                    ID="txtTenDN"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>Tên công ty
            </td>
            <td>
                <asp:TextBox runat="server"
                    ID="txtTenCT"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>Email
            </td>
            <td>
                <asp:TextBox runat="server"
                    ID="txtEmail"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>Mật khẩu
            </td>
            <td>
                <asp:TextBox runat="server"
                    TextMode="Password"
                    ID="txtMK"></asp:TextBox>
            </td>
        </tr>

        <tr>
            <td>Địa chỉ
            </td>
            <td>
                <asp:TextBox runat="server"
                    TextMode="MultiLine"
                    Rows="5"
                    ID="txtDC"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>Mã bảo vệ
            </td>
            <td>
                <asp:TextBox runat="server"
                    ID="txtCaptcha"></asp:TextBox>
                <BotDetect:WebFormsCaptcha ID="ExampleCaptcha" runat="server" />
            </td>
        </tr>
        <tr>
            <td></td>
            <td>
                <asp:Button runat="server"
                    ID="btnDK"
                    OnClick="btnDK_Click"
                    Text="Đăng ký" />
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

