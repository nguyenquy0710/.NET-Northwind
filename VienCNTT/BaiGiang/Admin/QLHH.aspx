<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/BackEnd.master" AutoEventWireup="true" CodeFile="QLHH.aspx.cs" Inherits="Admin_QLHH" %>

<asp:Content ID="Content1" ContentPlaceHolderID="Header" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="RightContent" runat="Server">
    <h2>Thông tin sản phẩm</h2>
    <table>
        <tr>
            <td class="cot1">Mã sản phẩm
            </td>
            <td>
                <h3 runat="server" id="h3Ma"></h3>
            </td>
        </tr>
        <tr>
            <td>Tên sản phẩm
            </td>
            <td>
                <asp:TextBox runat="server" ID="txtTen"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>Danh mục
            </td>
            <td>
                <asp:DropDownList runat="server" ID="ddlDM"></asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td>Nhà cung cấp
            </td>
            <td>
                <asp:DropDownList runat="server" ID="ddlNCC"></asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td>Giá
            </td>
            <td>
                <asp:TextBox runat="server" ID="txtGia"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>Hình
            </td>
            <td>
                <asp:Image runat="server" ID="imgSP"
                    AlternateText="Không có hình"
                    Width="200" />
                <br />
                <asp:FileUpload runat="server" ID="fulHinh"></asp:FileUpload>
            </td>
        </tr>

        <tr>
            <td></td>
            <td>
                <asp:Button runat="server" ID="btnThem"
                    CommandName="them"
                    OnClick="btnThem_Click"
                    Text="Thêm mới" />
                <asp:Button runat="server" ID="btnCapNhat"
                    CommandName="sua"
                    OnClick="btnCapNhat_Click"
                    Text="Cập nhật" />
            </td>
        </tr>
        <tr>
            <td></td>
            <td>
                <h3 runat="server" id="h3TB"></h3>
            </td>
        </tr>
    </table>
    <h2>Danh sách sản phẩm</h2>
    Chọn danh mục &nbsp;
     <asp:DropDownList runat="server" ID="ddlChonDM"
         AutoPostBack="true"
         OnSelectedIndexChanged="ddlChonDM_SelectedIndexChanged">
     </asp:DropDownList>
    <br />
    Lọc theo tên sản phẩm:<br />
    <asp:TextBox runat="server" ID="txtLocTen"></asp:TextBox>
    <asp:Button runat="server" ID="btnLocTen"
        OnClick="btnLocTen_Click"
        Text="Tìm" />
    <asp:GridView runat="server" ID="grvDS"
        AllowPaging="true"
        PageSize="10"
         OnPageIndexChanging="grvDS_PageIndexChanging"
        AutoGenerateColumns="false">
        <Columns>
            <asp:BoundField DataField="ProductID" HeaderText="Mã" />
            <asp:TemplateField HeaderText="Tên">
                <ItemTemplate>
                    <asp:LinkButton runat="server"
                        CommandArgument='<%#Eval("ProductID") %>'
                        OnClick="lbtnTen_Click"
                        ID="lbtnTen">
                        <%#Eval("ProductName") %>
                    </asp:LinkButton>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:BoundField DataField="UnitPrice" HeaderText="Đơn giá" />
            <asp:TemplateField HeaderText="Hình">
                <ItemTemplate>
                    <asp:Image runat="server"
                        Width="60"
                        AlternateText="Không có hình"
                        ImageUrl='<%#Eval("Image","~/Hinh/SanPham/{0}") %>' />
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Xóa">
                <ItemTemplate>
                    <asp:ImageButton runat="server"
                        Width="30"
                        CommandName="xoa"
                        ImageUrl="~/Hinh/Layout/delete.jpg"
                        CommandArgument='<%#Eval("ProductID") %>'
                        OnClick="ibtnXoa_Click"
                        ID="ibtnXoa"></asp:ImageButton>
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
    </asp:GridView>
</asp:Content>

