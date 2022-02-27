<%@ Page Title="" Language="C#" MasterPageFile="~/FrontEnd.master" AutoEventWireup="true" CodeFile="SanPham.aspx.cs" Inherits="SanPham" %>

<asp:Content ID="Content1" ContentPlaceHolderID="cphHead" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphMiddle" runat="Server">

    <h2 runat="server" id="h2TB"></h2>
    <asp:UpdatePanel runat="server">
        <ContentTemplate>
            <asp:DataList runat="server" ID="dtlSP"
                RepeatColumns="2">

                <ItemTemplate>
                    <ul class="sanpham">
                        <li>
                               <a href="/chitiet/<%#Eval("ProductID") %>">
                                <%#Eval("ProductName") %>
                            </a>
                        </li>
                        <li>
                            <asp:Image runat="server"
                                ImageUrl='<%#Eval("DuongDanHinh") %>' />
                        </li>
                        <li>
                            <%#Eval("UnitPrice") %>

                            <asp:ImageButton runat="server"
                                ID="ibtnMua" Width="30"
                                OnClick="ibtnMua_Click"
                                CommandArgument='<%#Eval("ProductID") %>'
                                ImageUrl="~/Hinh/Layout/cart.png" />

                        </li>
                    </ul>
                </ItemTemplate>
            </asp:DataList>
            <ul class="phantrang">
                <li>
                    <asp:LinkButton runat="server"
                        ID="lbtnTruoc"
                        OnClick="lbtnTruoc_Click">Trang trước</asp:LinkButton>
                </li>
                <li>
                    <asp:Label runat="server"
                        ID="lblHienTai"></asp:Label>
                </li>
                <li>
                    <asp:LinkButton runat="server"
                        ID="lbtnTiep"
                        OnClick="lbtnTiep_Click">Trang tiếp</asp:LinkButton>
                </li>
            </ul>
        </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>

