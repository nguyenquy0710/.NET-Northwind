<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/BackEnd.master" AutoEventWireup="true" CodeFile="QLHD.aspx.cs" Inherits="Admin_QLHD" %>

<asp:Content ID="Content1" ContentPlaceHolderID="Header" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="RightContent" runat="Server">
    <h2>Danh sách hóa đơn</h2>
    <asp:Panel runat="server" GroupingText="Lọc hóa đơn theo ngày:">
        <table>
            <tr>
                <td>Từ</td>
                <td>
                    <asp:TextBox
                        CssClass="ngay"
                        runat="server" ID="txtTu"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Đến</td>
                <td>
                    <asp:TextBox
                        CssClass="ngay"
                        runat="server" ID="txtDen"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td></td>
                <td>
                    <asp:Button runat="server" ID="btnLoc"
                        OnClick="btnLoc_Click"
                        Text="Lọc"></asp:Button>
                    <asp:Button runat="server" ID="btnAll"
                        OnClick="btnAll_Click"
                        Text="Chọn tất cả"></asp:Button>
                </td>
            </tr>
        </table>
    </asp:Panel>
    <asp:GridView runat="server"
        AllowPaging="true"
        PageSize="10"
        OnPageIndexChanging="grvHD_PageIndexChanging"
        AutoGenerateColumns="false"
        ID="grvHD">
        <Columns>
            <asp:TemplateField HeaderText="Mã">
                <ItemTemplate>
                    <asp:LinkButton runat="server"
                        ID="lbtnMa"
                        OnClick="lbtnMa_Click"
                        CommandArgument='<%#Eval("OrderID") %>'>
                        <%#Eval("OrderID") %>
                    </asp:LinkButton>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:BoundField HeaderText="Khách hàng" DataField="TenCongTy" />
            <asp:BoundField HeaderText="Ngày đặt"
                DataFormatString='{0:dd/MM/yyyy}'
                DataField="OrderDate" />
            <asp:BoundField HeaderText="Ngày giao"
                DataFormatString='{0:dd/MM/yyyy}'
                DataField="RequiredDate" />
            <asp:BoundField HeaderText="Tổng tiền" DataField="Freight" />
            <asp:BoundField HeaderText="Đỉa chỉ giao" DataField="ShipAddress" />
        </Columns>
    </asp:GridView>
    <h2>Chi tiết hóa đơn</h2>
    <asp:GridView runat="server"
        ID="grvCT">
    </asp:GridView>
</asp:Content>

