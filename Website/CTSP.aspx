<%@ Page Title="" Language="C#" MasterPageFile="~/FrontEnd.master" AutoEventWireup="true" CodeFile="CTSP.aspx.cs" Inherits="CTSP" %>

<asp:Content ID="Content1" ContentPlaceHolderID="cphTitle" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphHead" runat="Server">
    <style type="text/css">
        ul li {
            list-style: none;
        }

        .chitietsp {
            width: 100%;
        }

            .chitietsp li img {
                width: 200px;
                height: 200px;
            }
    </style>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="cphMiddle" runat="Server">

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
                CssClass="ibtn"
                ID="ibtnMua" Width="70"
                title="Thêm vào giỏ hàng"
                OnClick="ibtnMua_Click"
                ImageUrl="~/Image/Layout/cart.png" />
        </li>
    </ul>
</asp:Content>

