<%@ Page Title="" Language="C#" MasterPageFile="~/FrontEnd.master" AutoEventWireup="true" CodeFile="CTSP.aspx.cs" Inherits="CTSP" %>

<asp:Content ID="Content1" ContentPlaceHolderID="cphHead" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphMiddle" runat="Server">
    <ul class="chitietsp">
        <li>
            <a href="#" runat="server" id="aDM"
                onserverclick="aDM_ServerClick"></a>
        </li>
        <li>
            <h4 runat="server" id="h4Ten"></h4>
        </li>
        <li>
            <h4 runat="server" id="h4Gia"></h4>
        </li>
        <li>
            <asp:Image runat="server" ID="imgSP" />
        </li>
        <li>
            <asp:ImageButton runat="server"
                ID="ibtnMua" Width="30"
                OnClick="ibtnMua_Click"
                ImageUrl="~/Hinh/Layout/cart.png" />
        </li>
    </ul>
</asp:Content>

