<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CRUD.aspx.cs" Inherits="ADO_CRUD" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table>
                <tr>
                    <td>Mã danh mục</td>
                    <td>
                        <h3 runat="server" id="h3Ma"></h3>
                    </td>
                </tr>
                <tr>
                    <td>Tên danh mục
                    </td>
                    <td>
                        <asp:TextBox runat="server"
                            ID="txtTen"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Mô tả
                    </td>
                    <td>
                        <asp:TextBox runat="server"
                            TextMode="MultiLine"
                            Rows="5"
                            ID="txtMoTa"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td></td>
                    <td>
                        <asp:Button runat="server"
                            ID="btnThem" 
                             OnClick="btnThem_Click"
                            Text="Thêm" />
                        <asp:Button runat="server"
                            ID="btnCapNhat"
                             OnClick="btnCapNhat_Click"
                             Text="Cập nhật" />
                        <h3 runat="server" id="h3TB"></h3>
                    </td>
                </tr>
            </table>
            <h3>Danh sách danh mục</h3>
            <asp:GridView runat="server" ID="grvDM"
                 AutoGenerateColumns="false"
                >
                <Columns>
                    <asp:BoundField HeaderText="Mã"
                         DataField="CategoryID" />
                    <asp:BoundField HeaderText="Tên"
                         DataField="CategoryName" />
                    <asp:BoundField HeaderText="Mô tả"
                         DataField="Description" />
                    <asp:TemplateField HeaderText="Chọn">
                        <ItemTemplate>
                            <asp:Button runat="server" ID="btnChon"
                                 OnClick="btnChon_Click"
                                 CommandArgument='<%#Eval("CategoryID") %>'
                                 Text="Chọn" />
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Xóa">
                        <ItemTemplate>
                            <asp:Button runat="server" ID="btnXoa"
                                 OnClick="btnXoa_Click"
                                 CommandArgument='<%#Eval("CategoryID") %>'
                                 Text="Xóa" />
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>
        </div>
    </form>
</body>
</html>
