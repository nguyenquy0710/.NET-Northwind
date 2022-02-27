<%@ Page Title="" Language="C#" MasterPageFile="~/FrontEnd.master" AutoEventWireup="true" CodeFile="LienHe.aspx.cs" Inherits="LienHe" %>

<asp:Content ID="Content1" ContentPlaceHolderID="cphHead" runat="Server">
    <style type="text/css">
        .txt {
            width: 1024px;
        }

        #lienHe input[type='text'], #lienHe textarea {
            width: 90%;
        }
         #lienHe{
             margin-left:20px;
        }

        .cot1 {
            height: 10px;
            width: 20%;
            background-color: rgb(128, 128, 128);
            border-radius: 10px 10px;
            -webkit-box-shadow: 0 0 10px rgb(0, 0, 0);
        }

        #tb {
            font-size: 17px;
            font-weight: bolder;
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

        #huy {
            background-color: #4ddcc2;
            border-radius: 10px 10px;
            -webkit-box-shadow: 0 0 10px rgb(10, 25, 196);
        }

            #huy:hover {
                color: black;
                background-color: #03caa6;
            }

        .textbox {
            background-color: #8cb6b2;
            border-radius: 10px 10px;
            -webkit-box-shadow: 0 0 10px rgb(67, 11, 111);
        }

            .textbox:hover {
                background-color: #56d3d3;
            }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphMiddle" runat="Server">
    <table id="lienHe">
        <tr>
            <td class="cot1">
                <h4>Tiêu đề:</h4>
            </td>
            <td class="txt">
                <asp:TextBox runat="server" CssClass="textbox" Height="25" ID="txtTieuDe"></asp:TextBox>
                <asp:RequiredFieldValidator runat="server" ControlToValidate="txtTieuDe" ValidationGroup="Gửi" ErrorMessage="(*)" ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="cot1">
                <h4>Họ và tên:</h4>
            </td>
            <td class="txt">
                <asp:TextBox runat="server" Height="25" CssClass="textbox" ID="txtHT"></asp:TextBox>
                <asp:RequiredFieldValidator runat="server" ControlToValidate="txtHT" ValidationGroup="Gửi" ErrorMessage="(*)" ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="cot1">
                <h4>Số điện thoại:</h4>
            </td>
            <td class="txt">
                <asp:TextBox runat="server" CssClass="textbox" Height="25" ID="txtSDT"></asp:TextBox>
                <asp:RequiredFieldValidator runat="server" ControlToValidate="txtSDT" ValidationGroup="Gửi" ErrorMessage="(*)" ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="cot1">
                <h4>Email:</h4>
            </td>
            <td class="txt">
                <asp:TextBox runat="server" CssClass="textbox" Height="25" ID="txtEmail"></asp:TextBox>
                <asp:RequiredFieldValidator runat="server" ControlToValidate="txtEmail" ValidationGroup="Gửi" ErrorMessage="(*)" ForeColor="Red"></asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator runat="server" ValidationExpression="\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"
                    ControlToValidate="txtEmail" ErrorMessage="Email không hợp lệ!"></asp:RegularExpressionValidator>
                <%--ControlToValidate="txtEmail" bao ve cho cai id cua email--%>
            </td>
        </tr>
        <tr>
            <td class="cot1">
                <h4>Nội dung:</h4>
            </td>
            <td class="txt">
                <asp:TextBox runat="server" TextMode="MultiLine" CssClass="textbox" Rows="8" ID="txtND"></asp:TextBox>
                <asp:RequiredFieldValidator runat="server" ControlToValidate="txtND" ValidationGroup="Gửi" ErrorMessage="(*)" ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td></td>
            <td id="btn">
                <asp:Button runat="server" ID="btnGui" CssClass="button" Font-Bold="true" Font-Size="17px" Width="50" Height="30" ValidationGroup="Gửi" OnClick="btnGui_Click" Text="Gửi" />
                <input type="reset" id="huy" style="width: 50px; height: 30px; font-weight: bold; font-size: 17px;" value="Hủy" />
            </td>
        </tr>
        <tr>
            <td></td>
            <td id="tb">Thông báo</td>
            <td>
                <ul runat="server" id="thongBao"></ul>
            </td>
        </tr>
    </table>
</asp:Content>

