<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/BackEnd.master" AutoEventWireup="true" CodeFile="TaiKhoan.aspx.cs" Inherits="Admin_TaiKhoan" %>

<asp:Content ID="Content1" ContentPlaceHolderID="Header" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="RightContent" runat="Server">
    <h2>Thông tin tài khoản</h2>
    <table>
        <tr>
            <td>Tên đăng nhập</td>
            <td>
                <h3 runat="server" id="h3TenDN"></h3>
            </td>
        </tr>
         <tr>
            <td>Vai trò</td>
            <td>
                <h3 runat="server" id="h3VT"></h3>
            </td>
        </tr>
        <tr>
            <td>Họ</td>
            <td>
                <asp:TextBox runat="server" ID="txtHo"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>Tên</td>
            <td>
                <asp:TextBox runat="server" ID="txtTen"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>Mật khẩu cũ</td>
            <td>
                <asp:TextBox runat="server" ID="txtMKCu"
                    TextMode="Password"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>Mật khẩu mới</td>
            <td>
                <asp:TextBox runat="server" ID="txtMKMoi"
                    TextMode="Password"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td></td>
            <td>
                <asp:Button runat="server" ID="btnCapNhat"
                     OnClick="btnCapNhat_Click"
                    Text="Cập nhật"></asp:Button>
                
            </td>
        </tr>
        <tr>
            <td>Thông báo</td>
            <td>
                <h3 runat="server" id="h3TB"></h3>
            </td>
        </tr>
    </table>
</asp:Content>

