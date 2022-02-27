<%@ Page Language="C#" AutoEventWireup="true" CodeFile="TinhTienKH.aspx.cs" Inherits="ADO_TinhTienKH" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Chọn khách hàng<br />
            <asp:DropDownList runat="server"
                ID="ddlKH" AutoPostBack="true"
                OnSelectedIndexChanged="ddlKH_SelectedIndexChanged">
            </asp:DropDownList>
            <h3 runat="server" id="h3TT"></h3>
            Danh sách hóa đơn:
            <br />
            <asp:GridView runat="server" ID="grvHD">
                <Columns>
                    <asp:TemplateField HeaderText="Tong tien">
                        <ItemTemplate>
                            <asp:Label runat="server"
                                 ID="lblTT"></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>
        </div>
    </form>
</body>
</html>
