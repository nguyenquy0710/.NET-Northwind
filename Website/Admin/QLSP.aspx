<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/BackEnd.master" AutoEventWireup="true" CodeFile="QLSP.aspx.cs" Inherits="Admin_QLSP" %>

<asp:Content ID="Content1" ContentPlaceHolderID="cphTitle" runat="Server">
    Quản Lý Sản Phẩm
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphHead" runat="Server">
    <style type="text/css">
        .btnTim{
            padding:0 5%;
            margin-left:12%;
            line-height:200%;
        }
        .btnTim:hover{
            background-color:yellow;
            color:red;
            font-weight:bold;
        }
    </style>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="cphContent" runat="Server">
    <div class="title ql">Quản Lý Sản Phẩm</div>
    <table class="khungEdit table">
        <tr>
            <td class="cot1">Mã sản phẩm:</td>
            <td>
                <h2 runat="server" id="h2Ma"></h2>
            </td>
        </tr>
        <tr>
            <td class="cot1">Tên sản phẩm:</td>
            <td>
                <asp:TextBox runat="server" ID="txtTen" PlaceHolder="Tên Sản Phẩm"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="cot1">Nhà cung cấp:</td>
            <td>
                <asp:DropDownList runat="server" ID="ddlSup"></asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td class="cot1">Danh mục:</td>
            <td>
                <asp:DropDownList runat="server" ID="ddlDM"></asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td class="cot1">Đơn giá:</td>
            <td>
                <asp:TextBox runat="server" ID="txtDonGia" PlaceHolder="Đơn Giá"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="cot1">Số lượng:</td>
            <td>
                <asp:TextBox runat="server" ID="txtSoLuong" PlaceHolder="Số Lượng"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="cot1">Hình:</td>
            <td>
                <asp:Image runat="server" ID="imgHinh" Width="40%" AlternateText="Không có hình" />
                <asp:FileUpload runat="server" ID="fulHinhSP"></asp:FileUpload>
            </td>
        </tr>
        <tr>
            <td class="cot1"></td>
            <td>
                <div class="nut">
                    <asp:Button runat="server" ID="btnThem" CssClass="btn btn-info" Text="Thêm mới" OnClick="btnThem_Click" />
                </div>
                <div class="nut">
                    <asp:Button runat="server" ID="btnCapNhat" CssClass="btn btn-info" Text="Cập nhật" OnClick="btnCapNhat_Click" />
                </div>
                <div class="nut">
                    <input type="reset" value="Reset" class="btn btn-info"/>
                </div>
            </td>
        </tr>
    </table>
    <h3 runat="server" id="h3TB"></h3>
    <br />
    <hr />
    <br />
    <h1 style="color: red;">Danh sách sản phẩm</h1>
    <br />
    <asp:Panel runat="server" ID="pnlTim" GroupingText=" ">
        Danh Mục:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:DropDownList runat="server" ID="ddlTimDM"></asp:DropDownList><br />
        Theo Tên:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:TextBox runat="server" ID="txtTimTen" PlaceHolder="---Nhập tên sản phẩm muốn tìm---"></asp:TextBox><br />
        <asp:Button runat="server" ID="btnTim" Text="Tìm Ngay" CssClass="btnTim btn btn-info" OnClick="btnTim_Click"/>
    </asp:Panel>
    <asp:GridView runat="server" CssClass="table" ID="grvSP" AutoGenerateColumns="false" AllowPaging="true" PageSize="10" OnPageIndexChanging="grvSP_PageIndexChanging">
        <Columns>
            <asp:TemplateField HeaderText="Tên Sản Phẩm">
                <ItemTemplate>
                    <asp:LinkButton runat="server" ID="lbtnMa" CommandArgument='<%#Eval("ProductID") %>' OnClick="lbtnMa_Click">
                        <%#Eval("ProductName") %>
                    </asp:LinkButton>
                </ItemTemplate>
            </asp:TemplateField>
            <%--<asp:BoundField HeaderText="Nhà cung cấp" DataField="SupplierID" />--%>
            <%--<asp:BoundField HeaderText="Danh mục" DataField="SupplierID" />--%>
            <asp:BoundField HeaderText="Đơn Giá" DataField="UnitPrice" />
            <asp:BoundField HeaderText="Số Lượng" DataField="Quantity" />
            <asp:TemplateField HeaderText="Hình">
                <ItemTemplate>
                    <asp:Image runat="server" ID="imgSP" Width="60" ImageUrl='<%#Eval("Image","~/Image/SanPham/{0}") %>' />
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Xoá" ItemStyle-CssClass="xoa">
                <ItemTemplate>
                    <asp:ImageButton runat="server" ID="lbtnXoa" AlternateText="del" CommandArgument='<%#Eval("ProductID") %>' ImageUrl="~/Image/Layout/Delete_icon.png" CssClass="iconDel" OnClick="lbtnXoa_Click" Width="65%" />
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
    </asp:GridView>
</asp:Content>

