<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/BackEnd.master" AutoEventWireup="true" CodeFile="QLPQ.aspx.cs" Inherits="Admin_QLPQ" %>

<asp:Content ID="Content1" ContentPlaceHolderID="Header" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="RightContent" Runat="Server">
    <h2>Chọn vai trò</h2>
    <asp:DropDownList runat="server" ID="ddlVT"
         AutoPostBack="true" OnSelectedIndexChanged="ddlVT_SelectedIndexChanged"
        ></asp:DropDownList>
    <h2>Phân quyền cho trang web</h2>
    <asp:GridView runat="server" ID="grvTW"
         AutoGenerateColumns="false"
        >
        <Columns>
            <asp:BoundField DataField="FileName" HeaderText="Trang web"/>
            <asp:BoundField DataField="Description" HeaderText="Mô tả"/>
            <asp:TemplateField HeaderText="Xem">
                <ItemTemplate>
                    <asp:CheckBox runat="server"
                         ID="chkXem" />
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Thêm">
                <ItemTemplate>
                    <asp:CheckBox runat="server"
                         ID="chkThem" />
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Sửa">
                <ItemTemplate>
                    <asp:CheckBox runat="server"
                         ID="chkSua" />
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Xóa">
                <ItemTemplate>
                    <asp:CheckBox runat="server"
                         ID="chkXoa" />
                </ItemTemplate>
            </asp:TemplateField>
              <asp:TemplateField HeaderText="Chọn">
                <ItemTemplate>
                    <asp:LinkButton runat="server"
                         ID="lbtnChon"
                         OnClick="lbtnChon_Click"
                         Text="Chọn" />
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
    </asp:GridView>
    <asp:Button runat="server" Text="Phân quyền" ID="btnQP"
         OnClick="btnQP_Click"
         />
    <asp:Button runat="server" Text="Chọn tất cả" ID="btnChonHet" OnClick="btnChonHet_Click" />
    <asp:Button runat="server" Text="Hủy chọn" ID="btnHuyChon" OnClick="btnHuyChon_Click"/>
    <br />
    <h3 runat="server" id="h3TB"></h3>
</asp:Content>

