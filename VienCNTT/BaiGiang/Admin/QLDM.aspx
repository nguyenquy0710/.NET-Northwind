<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/BackEnd.master" AutoEventWireup="true" CodeFile="QLDM.aspx.cs" Inherits="Admin_QLDM" %>

<asp:Content ID="Content1" ContentPlaceHolderID="Header" runat="Server">
    
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="RightContent" runat="Server">
    <h2>Thông tin danh mục</h2>
    <table>
        <tr>
            <td class="cot1">Mã danh mục
            </td>
            <td>
                <h3 runat="server" id="h3Ma"></h3>
            </td>
        </tr>
        <tr>
            <td>Tên danh mục
            </td>
            <td>
                <asp:TextBox runat="server" ID="txtTen"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>Mô tả
            </td>
            <td>
                <asp:TextBox runat="server" ID="txtMoTa"
                    TextMode="MultiLine"
                    Rows="5"></asp:TextBox>
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
                     OnClick="btnCapNhat_Click"
                     CommandName="sua"
                     Text="Cập nhật" />
            </td>
        </tr>
        <tr>
            <td>
            </td>
            <td>
                <h3 runat="server" id="h3TB"></h3>
            </td>
        </tr>
    </table>
    <h2>Danh sách danh mục</h2>
    <asp:GridView runat="server" ID="grvDM"
         AutoGenerateColumns="false"
        >
        <Columns>
            <asp:BoundField DataField="CategoryID" HeaderText="Mã" />
            <asp:TemplateField HeaderText="Tên">
                <ItemTemplate>
                    <asp:LinkButton runat="server"
                         CommandArgument='<%#Eval("CategoryID") %>'
                         OnClick="lbtnTenDM_Click"
                         ID="lbtnTenDM">
                        <%#Eval("CategoryName") %>
                    </asp:LinkButton>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:BoundField DataField="Description" HeaderText="Mô tả" />
             <asp:TemplateField HeaderText="Xóa">
                <ItemTemplate>
                    <asp:ImageButton runat="server"
                          Width="30"
                         CommandName="xoa"
                         ImageUrl="~/Hinh/Layout/delete.jpg"
                         CommandArgument='<%#Eval("CategoryID") %>'
                         OnClick="ibtnXoa_Click"
                         ID="ibtnXoa">
                        
                    </asp:ImageButton>
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
    </asp:GridView>
</asp:Content>

