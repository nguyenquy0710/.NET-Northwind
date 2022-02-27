<%@ Page Title="" Language="C#" MasterPageFile="~/FrontEnd.master" AutoEventWireup="true" CodeFile="DangKyTK.aspx.cs" Inherits="DangKyTK" %>

<asp:Content ID="Content1" ContentPlaceHolderID="cphTitle" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphHead" runat="Server">
    <style type="text/css">
        .txt {
            width: 1024px;
        }

        .rows {
            height: 10px;
            width: 20%;
            background-color: rgb(128, 128, 128);
            border-radius: 10px 10px;
            -webkit-box-shadow: 0 0 10px rgb(0, 0, 0);            
        }

        #dangKy input[type='text'], input[type='password'], #dangKy textarea {
            width: 90%;           
        }
        #dangKy{
             margin-left:20px;
        }

        .textbox {
            background-color: #8cb6b2;
            border-radius: 10px 10px;
            -webkit-box-shadow: 0 0 10px rgb(67, 11, 111);
            height: 25px;
        }

            .textbox:hover {
                background-color: #56d3d3;
            }

        .captcha {
            float: right;
            clear: both;
        }

        .BDC_CaptchaDiv a img {
            border-radius: 10px 10px; /*css cho captcha*/
        }

        .txt1 {
            margin-left: 19px;
            height: 45px;
        }

        .btnDK {
            background-color: #4ddcc2;
            border-radius: 10px 10px;
            -webkit-box-shadow: 0 0 10px rgb(10, 25, 196);
            margin-top: 20px;
        }

            .btnDK:hover {
                color: black;
                background-color: #03caa6;
            }
    </style>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="cphMiddle" runat="Server">
    <table id="dangKy">
        <tr>
            <td class="rows">
                <h4>Tên đăng nhập:</h4>
            </td>
            <td>
                <asp:TextBox runat="server" CssClass="textbox"
                    ID="txtTenDN"></asp:TextBox>
                <asp:RequiredFieldValidator runat="server" ControlToValidate="txtTenDN" ValidationGroup="Đăng Ký" ErrorMessage="(*)" ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="rows">
                <h4>Tên công ty:</h4>
            </td>
            <td>
                <asp:TextBox runat="server" CssClass="textbox"
                    ID="txtTenCT"></asp:TextBox>
                <asp:RequiredFieldValidator runat="server" ControlToValidate="txtTenCT" ValidationGroup="Đăng Ký" ErrorMessage="(*)" ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="rows">
                <h4>Email:</h4>
            </td>
            <td>
                <asp:TextBox runat="server" CssClass="textbox"
                    ID="txtEmail"></asp:TextBox>
                <asp:RequiredFieldValidator runat="server" ControlToValidate="txtEmail" ValidationGroup="Đăng Ký" ErrorMessage="(*)" ForeColor="Red"></asp:RequiredFieldValidator>
                  <asp:RegularExpressionValidator runat="server" ValidationExpression="\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"
                    ControlToValidate="txtEmail" ErrorMessage="Email không hợp lệ!"></asp:RegularExpressionValidator>
            </td>
        </tr>
        <tr>
            <td class="rows">
                <h4>Mật khẩu:</h4>
            </td>
            <td>
                <asp:TextBox runat="server" CssClass="textbox"
                    TextMode="Password"
                    ID="txtMK"></asp:TextBox>
                 <asp:RequiredFieldValidator runat="server" ControlToValidate="txtMK" ValidationGroup="Đăng Ký" ErrorMessage="(*)" ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
        </tr>

        <tr>
            <td class="rows">
                <h4>Địa chỉ:</h4>
            </td>
            <td>
                <asp:TextBox runat="server" CssClass="textbox"
                    TextMode="MultiLine"
                    Rows="5"
                    ID="txtDC"></asp:TextBox>
                <asp:RequiredFieldValidator runat="server" ControlToValidate="txtDC" ValidationGroup="Đăng Ký" ErrorMessage="(*)" ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="rows">
                <h4>Mã bảo vệ:</h4>
            </td>
            <td>
                <asp:TextBox runat="server" CssClass="textbox txt1" Width="130"
                    ID="txtCaptcha"></asp:TextBox>
                <BotDetect:WebFormsCaptcha ID="ExampleCaptcha" CssClass="captcha" runat="server" />
            </td>
        </tr>
        <tr>
            <td></td>
            <td>
                <asp:Button runat="server"
                    ID="btnDK" CssClass="btnDK"
                    Width="70" Height="40"
                    Font-Bold="true" Font-Size="17px"
                    ValidationGroup="Đăng Ký"
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

