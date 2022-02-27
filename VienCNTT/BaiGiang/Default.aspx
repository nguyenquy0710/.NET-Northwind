<%@ Page Title="" Language="C#" MasterPageFile="~/FrontEnd.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="cphHead" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphMiddle" runat="Server">
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
                    <asp:UpdatePanel runat="server">
                        <ContentTemplate>
                            <%#Eval("UnitPrice") %>
                            <asp:ImageButton runat="server"
                                ID="ibtnMua" Width="30"
                                CommandArgument='<%#Eval("ProductID") %>'
                                OnClick="ibtnMua_Click"
                                ImageUrl="~/Hinh/Layout/cart.png" />
                        </ContentTemplate>
                    </asp:UpdatePanel>
                </li>
            </ul>
        </ItemTemplate>
    </asp:DataList>
</asp:Content>

