<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Admin_Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Đăng Nhập</title>

    <script src="../Scripts/jquery-2.2.2.min.js"></script>
    <script src="../Scripts/bootstrap.min.js"></script>
    <script src="../Scripts/bootstrap-datepicker.min.js"></script>
    <script src="../Scripts/locales/bootstrap-datepicker.vi.min.js"></script>
    <link href="../Content/bootstrap.min.css" rel="stylesheet" />
    <link href="../Content/bootstrap-datepicker.min.css" rel="stylesheet" />

    <link rel="shortcut icon" type="image/x-icon" href="../img/favicon.ico" />
    <link rel="icon" type="image/x-icon" href="../img/favicon.ico" />

    <script type="text/javascript">
        $(document).ready(function () {
            //dinh dang lua chon ngay gio
            $('.ngay').datepicker(
                {
                    'language': 'vi',
                    'format': 'dd/mm/yyyy'
                });
        });
    </script>

    <style type="text/css">
        body {
            margin: 0px;
            padding: 0px;
            width: 100%;
            height: 100%;
            background-image: url(../Image/background.png);
        }

        #root {
            margin: auto;
            text-align: center;
            position: absolute;
            top: 20%;
            left: 35%;
            width: 30%;
            color: rgba(255, 0, 0, 0.79);
            border-radius: 4px;
            font-weight: bold;
            background-color: rgba(255, 255, 255, 0.72);
        }

        t {
            font-size: 18px;
        }

        .khung {
            margin: auto;
            width: 65%;
            text-align: left;
        }

        input[type="text"], input[type="password"], input[type="date"], textarea {
            width: 86%;
            height: 30px;
            font-size: 20px;
        }

        rm {
            font-size: 17px;
        }

        .login {
            margin-left: 31%;
            margin-top: 2%;
            margin-bottom: 5%;
            width: 30%;
            font-size: 25px;
            line-height: 30px;
        }

        .register {
            width: 200%;
            /*background-color:saddlebrown;*/
            background-image: url(/Image/background.png);
            position: absolute;
            top: -23%;
            left: -50%;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <asp:ScriptManager runat="server" ID="scmCommon"></asp:ScriptManager>
        <div id="root">
            <h1>Đăng Nhập</h1>
            <br />
            <asp:Panel runat="server" CssClass="khung">

                <t>Tên Đăng Nhâp:</t>
                <br />
                <asp:TextBox runat="server" ID="txtUser" PlaceHolder="UserName"></asp:TextBox>
                <asp:RequiredFieldValidator runat="server" ControlToValidate="txtUser" ValidationGroup="login" ErrorMessage="(*)" ForeColor="Red"></asp:RequiredFieldValidator>
                <br />
                <t>Mật Khẩu:</t>
                <br />
                <asp:TextBox runat="server" ID="txtPass" TextMode="Password" PlaceHolder="PassWord"></asp:TextBox>
                <asp:RequiredFieldValidator runat="server" ControlToValidate="txtPass" ValidationGroup="login" ErrorMessage="(*)" ForeColor="Red"></asp:RequiredFieldValidator>
                <br />
                <br />
                <asp:Button runat="server" ID="btnLogin" Text="Login" ValidationGroup="login" CssClass="login btn btn-info" OnClick="btnLogin_Click" /><br />
                <asp:LinkButton runat="server" ID="hplResetPass" Text="Reset PassWord" OnClick="hplResetPass_Click"></asp:LinkButton>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:LinkButton runat="server" ID="hplRegister" Text="Register" OnClick="hplRegister_Click"></asp:LinkButton>

            </asp:Panel>
            <asp:Panel runat="server" ID="pnlRgister" CssClass="register" Visible="false">
                <table class="khungEdit table">
                    <tr>
                        <td class="cot1">Tên Đang Nhập:</td>
                        <td>
                            <asp:TextBox runat="server" ID="txtUserName" PlaceHolder="UserName"></asp:TextBox>
                            <asp:RequiredFieldValidator runat="server" ControlToValidate="txtUserName" ValidationGroup="Đăng ký" ErrorMessage="(*)" ForeColor="Red"></asp:RequiredFieldValidator>
                        </td>
                    </tr>
                    <tr>
                        <td class="cot1">Mật Khẩu:</td>
                        <td>
                            <asp:TextBox runat="server" ID="txtPassWord" TextMode="Password" PlaceHolder="PassWord"></asp:TextBox>
                            <asp:RequiredFieldValidator runat="server" ControlToValidate="txtPassWord" ValidationGroup="Đăng ký" ErrorMessage="(*)" ForeColor="Red"></asp:RequiredFieldValidator>
                        </td>
                    </tr>
                    <tr>
                        <td class="cot1">Nhập Lại Mật Khẩu:</td>
                        <td>
                            <asp:TextBox runat="server" ID="txtRePassWord" TextMode="Password" PlaceHolder="RePassWord"></asp:TextBox>
                            <asp:RequiredFieldValidator runat="server" ControlToValidate="txtRePassWord" ValidationGroup="Đăng ký" ErrorMessage="(*)" ForeColor="Red"></asp:RequiredFieldValidator><br />
                            <asp:Label runat="server" ID="lblRePassWord" Visible="false">Mật Khẩu không khớp!</asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td class="cot1">Phân Quyền:</td>
                        <td>
                            <asp:Label runat="server" ForeColor="Black">Employee</asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td class="cot1">Họ và Tên Đệm:</td>
                        <td>
                            <asp:TextBox runat="server" ID="txtFistName" PlaceHolder="Nguyễn Văn"></asp:TextBox>
                            <asp:RequiredFieldValidator runat="server" ControlToValidate="txtFistName" ValidationGroup="Đăng ký" ErrorMessage="(*)" ForeColor="Red"></asp:RequiredFieldValidator>
                        </td>
                    </tr>
                    <tr>
                        <td class="cot1">Tên:</td>
                        <td>
                            <asp:TextBox runat="server" ID="txtLastName" PlaceHolder="Anh"></asp:TextBox>
                            <asp:RequiredFieldValidator runat="server" ControlToValidate="txtLastName" ValidationGroup="Đăng ký" ErrorMessage="(*)" ForeColor="Red"></asp:RequiredFieldValidator>
                        </td>
                    </tr>
                    <tr>
                        <td class="cot1">Ngày Sinh:</td>
                        <td>
                            <asp:TextBox runat="server" ID="txtNgaySinh" TextMode="Date" CssClass="ngay datepicker" PlaceHolder="dd/mm/yyyy"></asp:TextBox>
                            <asp:RequiredFieldValidator runat="server" ControlToValidate="txtNgaySinh" ValidationGroup="Đăng ký" ErrorMessage="(*)" ForeColor="Red"></asp:RequiredFieldValidator>
                        </td>
                    </tr>
                    <tr>
                        <td class="cot1">Địa Chỉ:</td>
                        <td>
                            <asp:TextBox runat="server" ID="txtDiaChi" TextMode="MultiLine" Rows="2" PlaceHolder="Địa Chỉ Của Bạn"></asp:TextBox>
                            <asp:RequiredFieldValidator runat="server" ControlToValidate="txtDiaChi" ValidationGroup="Đăng ký" ErrorMessage="(*)" ForeColor="Red"></asp:RequiredFieldValidator>
                        </td>
                    </tr>
                    <tr>
                        <td class="cot1">Số Điện Thoại:</td>
                        <td>
                            <asp:TextBox runat="server" ID="txtPhone" PlaceHolder="(+84)974 691 xxx"></asp:TextBox>
                            <asp:RequiredFieldValidator runat="server" ControlToValidate="txtPhone" ValidationGroup="Đăng ký" ErrorMessage="(*)" ForeColor="Red"></asp:RequiredFieldValidator>
                        </td>
                    </tr>
                    <tr>
                        <td class="cot1">Quốc Gia:</td>
                        <td>
                            <asp:TextBox runat="server" ID="txtCountry" PlaceHolder="Việt Nam"></asp:TextBox>
                            <asp:RequiredFieldValidator runat="server" ControlToValidate="txtCountry" ValidationGroup="Đăng ký" ErrorMessage="(*)" ForeColor="Red"></asp:RequiredFieldValidator>
                        </td>
                    </tr>
                    <tr>
                        <td class="cot1">Ghi Chú:</td>
                        <td>
                            <asp:TextBox runat="server" ID="txtNote" TextMode="MultiLine" Rows="5" PlaceHolder="Vài Điều Về Bạn"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="cot1">Hình:</td>
                        <td>
                            <asp:Image runat="server" ID="imgHinh" Width="40%" AlternateText="Không có hình" />
                            <asp:FileUpload runat="server" ID="fulAvt" />
                        </td>
                    </tr>
                    <tr>
                        <td class="cot1"></td>
                        <td>
                            <div class="nut">
                                <asp:Button runat="server" ID="btnAddDangKy" Text="Đăng Ký" ValidationGroup="Đăng ký" CssClass="btn btn-info" OnClick="btnAddDangKy_Click"/>
                                <input type="reset" value="Reset" class="btn btn-info" />
                                <asp:Button runat="server" ID="btnHuyDangKy" Text="Hủy" CssClass="btn btn-info" OnClick="btnHuyDangKy_Click"/>
                            </div>
                        </td>
                    </tr>
                </table>
            </asp:Panel>
        </div>
    </form>
</body>
</html>
