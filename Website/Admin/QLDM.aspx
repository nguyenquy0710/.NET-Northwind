<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/BackEnd.master" AutoEventWireup="true" CodeFile="QLDM.aspx.cs" Inherits="Admin_QLDM" %>

<asp:Content ID="Content1" ContentPlaceHolderID="cphTitle" runat="Server">
    Quản Lý Danh Mục
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="cphHead" runat="Server">
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="cphContent" runat="Server">
    <asp:UpdatePanel runat="server" ID="udpRight">
        <ContentTemplate>
            <div class="title ql">Quản Lý Danh Mục</div>
            <table class="khungEdit table">
                <tr>
                    <td class="cot1">Mã danh mục:</td>
                    <td>
                        <h2 runat="server" id="h2Ma"></h2>
                    </td>
                </tr>
                <tr>
                    <td class="cot1">Tên danh mục:</td>
                    <td>
                        <asp:TextBox runat="server" ID="txtTen"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="cot1">Mô tả:</td>
                    <td>
                        <asp:TextBox runat="server" ID="txtMoTa" TextMode="MultiLine" Rows="5"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="cot1"></td>
                    <td>
                        <div class="nut">
                            <asp:Button runat="server" ID="btnThem" Text="Thêm mới" CssClass="btn btn-info" OnClick="btnThem_Click" />
                        </div>
                        <div class="nut">
                            <asp:Button runat="server" ID="btnCapNhat" Text="Cập nhật" CssClass="btn btn-info" OnClick="btnCapNhat_Click" />
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
            <h1 style="color: red;">Danh sách danh mục</h1>
            <br />
            <asp:GridView runat="server" ID="grvDM" AutoGenerateColumns="false" CssClass="table" AllowPaging="true" PageSize="5" OnPageIndexChanging="grvDM_PageIndexChanging">
                <Columns>
                    <asp:TemplateField HeaderText="Tên Danh Mục">
                        <ItemTemplate>
                            <asp:LinkButton runat="server" ID="lbtnMa" CommandArgument='<%#Eval("CategoryID") %>' OnClick="lbtnMa_Click">
                        <%#Eval("CategoryName") %>
                            </asp:LinkButton>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:BoundField HeaderText="Mô tả" DataField="Description" />
                    <asp:TemplateField HeaderText="Xoá" ItemStyle-CssClass="xoa">
                        <ItemTemplate>
                            <asp:ImageButton runat="server" ID="lbtnXoa" AlternateText="del" CommandArgument='<%#Eval("CategoryID") %>' ImageUrl="~/Image/Layout/Delete_icon.png" OnClick="lbtnXoa_Click" CssClass="iconDel" Width="65%" />
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>
        </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>

