<%@ Control Language="C#" AutoEventWireup="true" CodeFile="DangNhap.ascx.cs" Inherits="DangNhap" %>
<style type="text/css">
    .canhGiua {
        text-align: center;
        width: 100%;
    }
</style>
<asp:Panel runat="server" CssClass="canhGiua"
     GroupingText="Tài khoản khách hàng"
    >
    <asp:MultiView runat="server"
         ActiveViewIndex="0"
         ID="mtvDN">
        <asp:View runat="server" ID="viwDN">
            Tên đăng nhập<br />
            <asp:TextBox runat="server"
                ID="txtTenDN"></asp:TextBox>
            <br />
            Mật khẩu<br />
            <asp:TextBox runat="server"
                ID="txtMK" TextMode="Password"></asp:TextBox>
            <br />
            <asp:CheckBox Text="Ghi nhớ tài khoản" runat="server" ID="chkGN" />
            <br />
            <asp:Button runat="server" ID="btnDN"
                OnClick="btnDN_Click"
                Text="Đăng nhập" />
            <br />
            <asp:LinkButton runat="server"
                 ID="lbntDK"
                 OnClick="lbntDK_Click"
                >Đăng ký tài khoản</asp:LinkButton>
            <br />
            <asp:Label runat="server" ID="lblTB"></asp:Label>
        </asp:View>
        <asp:View runat="server" ID="viwDX">
            <asp:Label runat="server"
                ID="lblChao"></asp:Label>
            <br />
            <asp:Image runat="server"
                AlternateText=""
                Width="150"
                ID="imgKH" />
            <br />
            <asp:LinkButton runat="server"
                 ID="lbtnDX" OnClick="lbtnDX_Click">Đăng xuất</asp:LinkButton>
        </asp:View>
    </asp:MultiView>
</asp:Panel>
