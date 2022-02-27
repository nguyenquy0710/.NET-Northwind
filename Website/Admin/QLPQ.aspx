<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/BackEnd.master" AutoEventWireup="true" CodeFile="QLPQ.aspx.cs" Inherits="Admin_QLPQ" %>

<asp:Content ID="Content1" ContentPlaceHolderID="cphTitle" runat="Server">
    Quản Lý Phân Quyền
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphHead" runat="Server">
    <style type="text/css">
        .cn {
            margin-left: 5%;
        }
    </style>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="cphContent" runat="Server">
    <asp:UpdatePanel runat="server" ID="udpRight">
        <ContentTemplate>
            <div class="title ql">Quản Lý Phân Quyền</div>
            <br />
            Danh sách quyền:
    <asp:DropDownList runat="server" ID="ddlPhanQuyen" AutoPostBack="true" OnSelectedIndexChanged="ddlPhanQuyen_SelectedIndexChanged"></asp:DropDownList><br />
            <asp:GridView runat="server" ID="grvDSQuyen" CssClass="khungChucNang table" AutoGenerateColumns="false">
                <Columns>
                    <asp:BoundField HeaderText="FileName" DataField="FileName" />
                    <asp:BoundField HeaderText="Mô Tả" DataField="Description" />
                    <asp:TemplateField HeaderText="Xem">
                        <ItemTemplate>
                            <asp:CheckBox runat="server" ID="chkXem" />
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Thêm">
                        <ItemTemplate>
                            <asp:CheckBox runat="server" ID="chkThem" />
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Sửa">
                        <ItemTemplate>
                            <asp:CheckBox runat="server" ID="chkSua" />
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Xóa">
                        <ItemTemplate>
                            <asp:CheckBox runat="server" ID="chkXoa" />
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Chức năng">
                        <ItemTemplate>
                            <asp:Button runat="server" ID="btnChon" Text="Chọn" OnClick="btnChon_Click" CssClass="btn btn-info nut cn" />
                            <asp:Button runat="server" ID="btnHuy" Text="Hủy" OnClick="btnHuy_Click" CssClass="btn btn-info nut cn" />
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>
            <asp:Button runat="server" ID="btnPQ" Text="Phân Quyền" OnClick="btnPQ_Click" CssClass="btn btn-info nut cn" />
            <br />
            <hr />
            <br />
            <div class="title ql">Danh Sách WebPage</div>
            <br />
            <asp:GridView runat="server" ID="grvWebPage" CssClass="khungChucNang table" AutoGenerateColumns="false">
                <Columns>
                    <asp:TemplateField HeaderText="FileName">
                        <ItemTemplate>
                            <asp:Label runat="server" ID="lblNamePage"><%#Eval("FileName") %></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Mô Tả">
                        <ItemTemplate>
                            <asp:Label runat="server" ID="lblMoTa"><%#Eval("Description") %></asp:Label>
                            <asp:TextBox runat="server" ID="txtMoTa" PlaceHolder="Mô tả về trang này" Visible="false"></asp:TextBox>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Chức năng">
                        <ItemTemplate>
                            <asp:Button runat="server" ID="btnSua" Text="Sửa" CssClass="btn btn-info cn" OnClick="btnSua_Click" CommandArgument='<%#Eval("FileName") %>' />
                            <asp:Button runat="server" ID="btnOK" Text="OK" CssClass="btn btn-info cn" OnClick="btnOK_Click" Visible="false" />
                            <asp:Button runat="server" ID="btnXoa" Text="Xóa" CssClass="btn btn-info cn" OnClick="btnXoa_Click" CommandArgument='<%#Eval("FileName") %>' />
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>
            <asp:Button runat="server" ID="btnThem" Text="Thêm" CssClass="btn btn-info cn" OnClick="btnThem_Click" />
            <asp:Panel runat="server" ID="pnlThemPage" Visible="false">
                <table class="table">
                    <tr>
                        <td>Tên Trang</td>
                        <td>
                            <asp:TextBox runat="server" ID="txtThemNamePage" PlaceHolder="FileName.aspx"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>Mô Tả</td>
                        <td>
                            <asp:TextBox runat="server" ID="txtThemMoTa" PlaceHolder="Mô tả chi tiết về trang"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td></td>
                        <td>
                            <asp:Button runat="server" ID="btnThemOK" Text="OK" CssClass="btn btn-info cn" OnClick="btnThemOK_Click" />
                            <asp:Button runat="server" ID="btnThemHuy" Text="Hủy" CssClass="btn btn-info cn" OnClick="btnThemHuy_Click" />
                        </td>
                    </tr>
                </table>
            </asp:Panel>
            <h3 runat="server" id="h3TB"></h3>
        </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>

