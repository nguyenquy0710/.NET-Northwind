<%@ Page Title="" Language="C#" MasterPageFile="~/FrontEnd.master" AutoEventWireup="true" CodeFile="CTGH.aspx.cs" Inherits="CTGH" %>

<asp:Content ID="Content1" ContentPlaceHolderID="cphTitle" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphHead" Runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="cphMiddle" Runat="Server">
    <asp:UpdatePanel runat="server">
        <ContentTemplate>
            <asp:GridView runat="server" ID="grvGH" AutoGenerateColumns="false">
                <Columns>
                    <asp:BoundField HeaderText="Tên" DataField="ProductName" />
                    <asp:BoundField HeaderText="Giá" DataField="UnitPrice" />
                    <asp:TemplateField HeaderText="Số lượng">
                        <ItemTemplate>
                            <asp:TextBox runat="server" ID="txtSL"
                                ToolTip="nhập số lượng sản phẩm"
                                Text='<%#Eval("Quantity") %>' />
                            <asp:ImageButton runat="server"
                                ID="ibtnRefresh"
                                Height="20"
                                ToolTip="cập nhật"
                                CommandArgument='<%#Eval("ProductID") %>'
                                ImageUrl="~/Image/Layout/refresh.png"
                                OnClick="ibtnRefresh_Click" />
                        </ItemTemplate>
                    </asp:TemplateField>

                    <asp:TemplateField HeaderText="Xóa">
                        <ItemTemplate>
                            <asp:Button runat="server"
                                ID="btnXoa" OnClick="btnXoa_Click"
                                ToolTip="xóa"
                                CommandArgument='<%#Eval("ProductID") %>'
                                Text="Xóa" />
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>
            <asp:Button runat="server"
                ID="btnMuaTiep" OnClick="btnMuaTiep_Click"
                ToolTip="tiếp tục mua hàng"
                Text="Tiếp tục mua hàng" />
            <asp:Button runat="server"
                ID="btnXoaHet" OnClick="btnXoaHet_Click"
                ToolTip="xóa hết"
                Text="Xóa hết" />
            <asp:Button runat="server"
                ID="btnTT" OnClick="btnTT_Click"
                ToolTip="thanh toán"
                Text="Thanh toán" />
            <br />
            <h3 runat="server" id="h3TB" style="color: red;"></h3>
        </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>

