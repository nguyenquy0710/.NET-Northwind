<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/BackEnd.master" AutoEventWireup="true" CodeFile="QLHD.aspx.cs" Inherits="Admin_QLHD" %>

<asp:Content ID="Content1" ContentPlaceHolderID="cphTitle" runat="Server">
    Quản Lý Hoá Đơn
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphHead" runat="Server">
    <style type="text/css">
        #timNgay input[type="text"] {
            width: 43%;
        }

        .khungEdit tr td label {
            display: inline;
        }
    </style>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="cphContent" runat="Server">
    <asp:UpdatePanel runat="server" ID="udpRight">
        <ContentTemplate>
            <div class="title ql">Quản Lý Hoá Đơn</div>
            <table class="khungEdit table">
                <tr>
                    <td class="cot1">Tên Khách Hàng:</td>
                    <td>
                        <asp:TextBox runat="server" ID="txtTenKH" PlaceHolder="Tên khách hàng là"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="cot1">Tên Nhân Viên:</td>
                    <td>
                        <asp:TextBox runat="server" ID="txtTenNV" PlaceHolder="Tên nhân viên là"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="cot1">Tìm Theo Ngày:</td>
                    <td colspan="2" id="timNgay">
                        <asp:TextBox runat="server" ID="txtTu" CssClass="ngay" PlaceHolder="Từ ngày"></asp:TextBox>
                        <asp:TextBox runat="server" ID="txtDen" CssClass="ngay" PlaceHolder="Đến ngày"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="cot1">Trạng Thái:</td>
                    <td>
                        <asp:CheckBox runat="server" ID="chkStatus" Text="Đã giao hàng"></asp:CheckBox>
                    </td>
                </tr>
                <tr>
                    <td class="cot1"></td>
                    <td>
                        <div class="nut">
                            <asp:Button runat="server" ID="btnTim" Text="Tìm Kiếm" CssClass="btn btn-info" OnClick="btnTim_Click" />
                        </div>
                        <div class="nut">
                            <input type="reset" value="Reset" class="btn btn-info" />
                        </div>
                    </td>
                </tr>
            </table>
            <h3 runat="server" id="h3TB"></h3>
            <br />
            <hr />
            <br />
            <h1 style="color: red;">Danh sách hoá đơn</h1>
            <br />
            <asp:UpdatePanel runat="server">
                <ContentTemplate>
                    <asp:GridView runat="server" CssClass="table" ID="grvHD" AutoGenerateColumns="false" AllowPaging="true" PageSize="10" OnPageIndexChanging="grvHD_PageIndexChanging">
                        <Columns>
                            <asp:TemplateField HeaderText="Mã Hoá Đơn">
                                <ItemTemplate>
                                    <asp:LinkButton runat="server" ID="lbtnMa" CommandArgument='<%#Eval("OrderID") %>' OnClick="lbtnMa_Click">
                        <%#Eval("OrderID") %>
                                    </asp:LinkButton>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Khách Hàng">
                                <ItemTemplate>
                                    <asp:Label runat="server" ID="lblTenKH" Text='<%#Order.Tim(int.Parse(Eval("OrderID").ToString())).Customer.CompanyName %>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Nhân Viên">
                                <ItemTemplate>
                                    <asp:Label runat="server" ID="lblTenNV" Text='<%#Order.Tim(int.Parse(Eval("OrderID").ToString())).Employee.LastName +" "+ Order.Tim(int.Parse(Eval("OrderID").ToString())).Employee.FirstName%>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:BoundField HeaderText="Ngày Đặt" DataField="OrderDate" DataFormatString='{0:dd/MM/yyyy}' />
                            <asp:BoundField HeaderText="Ngày Giao" DataField="ShippedDate" DataFormatString='{0:dd/MM/yyyy}' />
                            <%--<asp:BoundField HeaderText="Hạn Cuối" DataField="RequiredDate" DataFormatString='{0:dd/MM/yyyy}' />--%>
                            <asp:BoundField HeaderText="Tổng Tiền" DataField="Freight" />
                            <asp:BoundField HeaderText="Tên Người Nhận" DataField="ShipName" />
                            <asp:BoundField HeaderText="Địa Điểm Giao Hàng" DataField="ShipAddress" />
                            <asp:TemplateField HeaderText="Đã Giao Hàng" ItemStyle-CssClass="chkHD">
                                <ItemTemplate>
                                    <asp:CheckBox runat="server" ID="chkOK" Checked='<%#Eval("Status") == null ? false : Eval("Status") %>' />
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Xoá" ItemStyle-CssClass="xoa">
                                <ItemTemplate>
                                    <asp:ImageButton runat="server" ID="ibtnXoa" AlternateText="del" CommandArgument='<%#Eval("OrderID") %>' ImageUrl="~/Image/Layout/Delete_icon.png" CssClass="iconDel" OnClick="ibtnXoa_Click" Width="100%" />
                                </ItemTemplate>
                            </asp:TemplateField>
                        </Columns>
                    </asp:GridView>
                </ContentTemplate>
            </asp:UpdatePanel>
        </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>

