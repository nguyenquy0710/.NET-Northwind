<%@ Page Title="" Language="C#" MasterPageFile="~/FrontEnd.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="cphTitle" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphHead" Runat="Server">
    <style type="text/css">
        ul li {
            list-style: none;
        }

        .sanpham li a {
            text-decoration: none;
            font-size: 16px;
        }

        .sanpham li img {
            width: 110px;
            height: 110px;
            list-style: none;
            border-radius: 10px 10px;
            border: 1px solid green;
        }
    </style>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="cphMiddle" Runat="Server">
     <h2 runat="server" id="h2TB"></h2>
    <asp:UpdatePanel runat="server">
        <ContentTemplate>
            <asp:DataList runat="server" ID="dtlSP"
                RepeatColumns="4">

                <ItemTemplate>
                    <ul class="sanpham">
                        <li>
                            <a href="/chitiet/<%#Eval("ProductID") %>" title="<%#Eval("ProductName") %>"><%#Eval("ProductName") %></a>
                        </li>
                        <li>
                            <asp:Image runat="server"
                                ImageUrl='<%#Eval("DuongDanHinh") %>' />
                        </li>
                        <li>
                            <%#Eval("UnitPrice") %>

                            <asp:ImageButton runat="server"
                                ID="ibtnMua" Width="30"
                                title="Thêm vào giỏ hàng"
                                OnClick="ibtnMua_Click"
                                CommandArgument='<%#Eval("ProductID") %>'
                                ImageUrl="~/Image/Layout/cart.png" />

                        </li>
                    </ul>
                </ItemTemplate>
            </asp:DataList>           
        </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>

