<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/BackEnd.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="Admin_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="cphTitle" runat="Server">
    Drashboard
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphHead" runat="Server">
    <script>
        (function (i, s, o, g, r, a, m) {
            i['GoogleAnalyticsObject'] = r;
            i[r] = i[r] || function () {
                (i[r].q = i[r].q || []).push(arguments)
            }, i[r].l = 1 * new Date();
            a = s.createElement(o),
            m = s.getElementsByTagName(o)[0];
            a.async = 1;
            a.src = g;
            m.parentNode.insertBefore(a, m)
        })
        (window, document, 'script', 'https://www.google-analytics.com/analytics.js', 'ga');

        ga('create', 'UA-75072145-1', 'auto');
        ga('send', 'pageview');

        $(document).ready(function () {
            var div = document.getElementById('new');
        });
    </script>

    <style type="text/css">
        .spbc {
        }
    </style>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="cphContent" runat="Server">
    <asp:UpdatePanel runat="server" ID="udpRight">
        <ContentTemplate>
            <div>
                <div id="analytics">
                    <table id="thongKe">
                    </table>
                </div>
                <div id="SpBanChay">
                    <h1>Sản Phẩm Bán Chạy</h1>
                    <asp:UpdatePanel runat="server">
                        <ContentTemplate>
                            <asp:GridView runat="server" CssClass="table khungChucNang spbc" ID="grvSPBC" AutoGenerateColumns="false" AllowPaging="true" PageSize="5" OnPageIndexChanging="grvSPBC_PageIndexChanging">
                                <Columns>
                                    <asp:TemplateField HeaderText="Tên Sản Phẩm">
                                        <ItemTemplate>
                                            <asp:LinkButton runat="server" ID="lbtnTen" OnClick="lbtnTen_Click" CommandArgument='<%#Eval("ProductID") %>'>
                                        <%#Eval("ProductName") %>
                                            </asp:LinkButton>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField HeaderText="Danh Mục">
                                        <ItemTemplate>
                                            <asp:Label runat="server" ID="lblDM" Text='<%#Category.Tim(int.Parse(Eval("CategoryID").ToString())).CategoryName%>'></asp:Label>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:BoundField HeaderText="Đơn Giá" DataField="UnitPrice" />
                                    <asp:BoundField HeaderText="Số Lượng" DataField="So_Luong_Ban_Ra" />
                                </Columns>
                            </asp:GridView>
                        </ContentTemplate>
                    </asp:UpdatePanel>
                </div>
                <div id="NVXS">
                    Toi nay se lam sau
            viet view trong SQL
                </div>
                <div id="KHThanThiet">
                    toi nay se lam sau
            viet view trong SQL
                </div>

            </div>
        </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>

