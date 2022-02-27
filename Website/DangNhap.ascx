<%@ Control Language="C#" AutoEventWireup="true" CodeFile="DangNhap.ascx.cs" Inherits="DangNhap" %>

<style type="text/css">
    .canhGiua{
        background-color:white;
        border-radius:5px 5px 5px 5px;
        margin-top:4px;
    }
</style>
<asp:Panel runat="server" CssClass="canhGiua">
    <asp:MultiView runat="server" ActiveViewIndex="0" ID="mtvDN">
        <asp:View runat="server" ID="viwDN">
            Tên đăng nhập<br />
            <asp:TextBox runat="server" ID="txtTenDN"></asp:TextBox>
            <br />
            Mật khẩu<br />
            <asp:TextBox runat="server" ID="txtMK" TextMode="Password"></asp:TextBox>
            <br />
            <asp:CheckBox runat="server" ID="chkGN" Text="Ghi nhớ tài khoản" />
            <br />
            <asp:Button runat="server" ID="btnDN" OnClick="btnDN_Click" ToolTip="đăng nhập" Text="Đăng nhập" />
            <br />
            <asp:LinkButton runat="server" ID="lbtnDK" OnClick="lbtnDK_Click" ToolTip="đăng ký tài khoản" Text="Đăng ký tài khoản" />
            <asp:Label runat="server" ID="lblTB"></asp:Label>
        </asp:View>
        <asp:View runat="server" ID="viwDX">
            <asp:Label runat="server" ID="lblChao"></asp:Label>
            <br />
            <asp:Image runat="server" AlternateText="not found" Width="150" ID="imgKH" />
            <br />
            <asp:LinkButton runat="server" ID="lbtnDX" OnClick="lbtnDX_Click" ToolTip="đăng xuất" Text="Đăng xuất"></asp:LinkButton>
        </asp:View>
    </asp:MultiView>

</asp:Panel>