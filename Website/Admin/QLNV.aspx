<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/BackEnd.master" AutoEventWireup="true" CodeFile="QLNV.aspx.cs" Inherits="Admin_QLNV" %>

<asp:Content ID="Content1" ContentPlaceHolderID="cphTitle" runat="Server">
    Quản Lý Nhân Viên
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphHead" runat="Server">
    <script type="text/javascript">
        $(document).ready(function () {
            $(function () {
                //nut TOP duoc click se chay cham ve dau trang
                $('.top').click(function () {
                    $('body,html').animate({ scrollTop: 0 }, 'slow');
                });
            });
        });
    </script>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="cphContent" runat="Server">
    <div class="title ql">Quản Lý Nhân Viên</div>
    <table class="khungEdit table">
        <tr>
            <td class="cot1">Mã Nhân Viên:</td>
            <td>
                <h2 runat="server" id="h2Ma"></h2>
            </td>
        </tr>
        <tr>
            <td class="cot1">Tên Đang Nhập:</td>
            <td>
                <h2 runat="server" id="h2User"></h2>
            </td>
        </tr>
        <tr>
            <td class="cot1">Phân Quyền:</td>
            <td>
                <asp:DropDownList runat="server" ID="ddlPhanQuyen"></asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td class="cot1">Họ và Tên Đệm:</td>
            <td>
                <asp:TextBox runat="server" ID="txtFistName" PlaceHolder="Nguyễn Văn"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="cot1">Tên:</td>
            <td>
                <asp:TextBox runat="server" ID="txtLastName" PlaceHolder="Anh"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="cot1">Ngày Sinh:</td>
            <td>
                <asp:TextBox runat="server" ID="txtNgaySinh" TextMode="Date" CssClass="ngay datepicker" PlaceHolder="dd/mm/yyyy"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="cot1">Địa Chỉ:</td>
            <td>
                <asp:TextBox runat="server" ID="txtDiaChi" TextMode="MultiLine" Rows="2" PlaceHolder="Địa Chỉ Của Bạn"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="cot1">Số Điện Thoại:</td>
            <td>
                <asp:TextBox runat="server" ID="txtPhone" PlaceHolder="(+84)974 691 xxx"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="cot1">Quốc Gia:</td>
            <td>
                <asp:TextBox runat="server" ID="txtCountry" PlaceHolder="Việt Nam"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="cot1">Ghi Chú:</td>
            <td>
                <asp:TextBox runat="server" ID="txtNote" TextMode="MultiLine" Rows="5" PlaceHolder="Vài Điều Về Bạn"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="cot1">Hình:</td>
            <td>
                <asp:Image runat="server" ID="imgHinh" Width="40%" AlternateText="Không có hình" />
                <asp:FileUpload runat="server" ID="fulSP" />
            </td>
        </tr>
        <tr>
            <td class="cot1"></td>
            <td>
                <div class="nut">
                    <%--<asp:Button runat="server" ID="btnThem" Text="Thêm" CssClass="btn btn-info" OnClick="btnThem_Click" />--%>
                </div>
                <div class="nut">
                    <asp:Button runat="server" ID="btnCapNhat" Text="Cập nhật" CssClass="btn btn-info" OnClick="btnCapNhat_Click" />
                </div>
                <div class="nut">
                    <asp:Button runat="server" ID="Button1" Text="Xóa" CssClass="btn btn-info" OnClick="btnXoa_Click" />
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
    <h1 style="color: red;">Danh sách sản phẩm</h1>
    <br />
    <asp:Panel runat="server" ID="pnlTim" GroupingText="">
        Quyền Quản lý:&nbsp;<asp:DropDownList runat="server" ID="ddlTimQuyen" OnSelectedIndexChanged="ddlTimQuyen_SelectedIndexChanged" AutoPostBack="true"></asp:DropDownList><br />
        Theo Tên:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:TextBox runat="server" ID="txtTimTen" PlaceHolder="---Nhập tên nhân viên muốn tìm---"></asp:TextBox><br />
        <asp:Button runat="server" ID="btnTim" Text="Tìm Ngay" CssClass="btnTim btn btn-info" OnClick="btnTim_Click" />
    </asp:Panel>
    <asp:GridView runat="server" CssClass="table" ID="grvNV" AutoGenerateColumns="false" AllowPaging="true" PageSize="10" OnPageIndexChanging="grvSP_PageIndexChanging">
        <Columns>
            <asp:TemplateField HeaderText="Avatar">
                <ItemTemplate>
                    <asp:ImageButton runat="server" ID="ibtnAvt" Width="60" ImageUrl='<%#Eval("Photo","~/Image/Avatar/{0}") %>' OnClick="ibtnAvt_Click" CommandArgumen='<%#Eval("EmployeeID") %>' />
                </ItemTemplate>
            </asp:TemplateField>
            <asp:BoundField HeaderText="Tiền Tố" DataField="TitleOfCourtesy" />
            <asp:TemplateField HeaderText="Họ & Tên">
                <ItemTemplate>
                    <asp:Label runat="server" ID="lblHoTen" Text='<%#Eval("LastName") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:BoundField HeaderText="Phone" DataField="HomePhone" />
            <asp:BoundField HeaderText="Địa Chỉ" DataField="Address" />
            <asp:TemplateField HeaderText="Phân Quyền">
                <ItemTemplate>
                    <asp:Label runat="server" ID="lblRole" Text='<%#(Eval("RoleID").Equals(1))?"Administrator":(Eval("RoleID").Equals(2))?"Supervisor":"Employee"%>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="">
                <ItemTemplate>
                    <asp:Button runat="server" ID="btnXem" Text="Xem" CssClass="btn btn-info" CommandArgument='<%#Eval("EmployeeID")%>' OnClick="btnXem_Click" />
                    <asp:Button runat="server" ID="btnXoaGr" Text="Xóa" CssClass="btn btn-info" CommandArgument='<%#Eval("EmployeeID")%>' OnClick="btnXoaGr_Click" />
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
    </asp:GridView>
</asp:Content>

