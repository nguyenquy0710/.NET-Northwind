<%@ Page Title="" Language="C#" MasterPageFile="~/FrontEnd.master" AutoEventWireup="true" CodeFile="CTGH.aspx.cs" Inherits="CTGH" %>

<asp:Content ID="Content1" ContentPlaceHolderID="cphHead" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphMiddle" runat="Server">
    <asp:UpdatePanel runat="server">
        <ContentTemplate>
            <asp:GridView runat="server" ID="grvGH" AutoGenerateColumns="false">
                <Columns>
                    <asp:BoundField HeaderText="Tên" DataField="ProductName" />
                    <asp:BoundField HeaderText="Giá" DataField="UnitPrice" />
                    <asp:TemplateField HeaderText="Số lượng">
                        <ItemTemplate>
                            <asp:TextBox runat="server" ID="txtSL"
                                Text='<%#Eval("Quantity") %>' />
                            <asp:ImageButton runat="server"
                                ID="ibtnRefresh"
                                Height="20"
                                CommandArgument='<%#Eval("ProductID") %>'
                                ImageUrl="~/Hinh/Layout/refresh.jpg"
                                OnClick="ibtnRefresh_Click" />
                        </ItemTemplate>
                    </asp:TemplateField>

                    <asp:TemplateField HeaderText="Xóa">
                        <ItemTemplate>
                            <asp:Button runat="server"
                                ID="btnXoa" OnClick="btnXoa_Click"
                                CommandArgument='<%#Eval("ProductID") %>'
                                Text="Xóa" />
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>
            <asp:Button runat="server"
                ID="btnMuaTiep" OnClick="btnMuaTiep_Click"
                Text="Tiếp tục mua hàng" />
            <asp:Button runat="server"
                ID="btnXoaHet" OnClick="btnXoaHet_Click"
                Text="Xóa hết" />
            <asp:Button runat="server"
                ID="btnTT" OnClick="btnTT_Click"
                Text="Thanh toán" />
            <br />
            <h3 runat="server" id="h3TB" style="color: red;"></h3>
        </ContentTemplate>
    </asp:UpdatePanel>

</asp:Content>

