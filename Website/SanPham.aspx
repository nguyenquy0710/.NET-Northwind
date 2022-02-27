<%@ Page Title="" Language="C#" MasterPageFile="~/FrontEnd.master" AutoEventWireup="true" CodeFile="SanPham.aspx.cs" Inherits="SanPham" %>

<asp:Content ID="Content1" ContentPlaceHolderID="cphTitle" runat="Server">
    San Pham
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphHead" runat="Server">
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

        .phantrang {
            margin-top: 30px;
            width: 100%;
            text-align: center;
        }

            .phantrang li {
                float: left;
                width: 33%;
            }
    </style>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="cphMiddle" runat="Server">
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
            <ul class="phantrang">
                <li>
                    <asp:LinkButton runat="server"
                        ID="lbtnTruoc"
                        OnClick="lbtnTruoc_Click">Previou</asp:LinkButton>
                </li>
                <li>
                    <asp:Label runat="server"
                        ID="lblHienTai"></asp:Label>
                </li>
                <li>
                    <asp:LinkButton runat="server"
                        ID="lbtnTiep"
                        OnClick="lbtnTiep_Click">Next</asp:LinkButton>
                </li>
            </ul>
        </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>

