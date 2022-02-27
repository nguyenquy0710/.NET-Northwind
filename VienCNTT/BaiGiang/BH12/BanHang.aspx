<%@ Page Language="C#" AutoEventWireup="true"
    EnableEventValidation="false"
    CodeFile="BanHang.aspx.cs" Inherits="BH12_BanHang" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #container {
            width: 1024px;
            margin: auto;
        }

        #left {
            width: 25%;
            float: left;
        }

        #right {
            width: 75%;
            float: left;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div id="container">
            <div id="left">
                <asp:Repeater runat="server"
                    ID="rptDM">
                    <HeaderTemplate>
                        <ul>
                    </HeaderTemplate>
                    <ItemTemplate>
                        <li>
                            <asp:LinkButton runat="server"
                                CommandArgument='<%#Eval("Ma") %>'
                                ID="lbtnDM"
                                OnClick="lbtnDM_Click">
                                <%#Eval("Ten") %>
                            </asp:LinkButton>
                        </li>
                    </ItemTemplate>
                    <FooterTemplate>
                        </ul>
                    </FooterTemplate>
                </asp:Repeater>

                <div id="tim">
                    <asp:TextBox runat="server"
                        ID="txtTim"></asp:TextBox>
                    <asp:Button runat="server"
                        ID="btnTim"
                        OnClick="btnTim_Click"
                        Text="Tim" />
                </div>

                <asp:Panel runat="server" ID="pnlTT"
                    GroupingText="Tong tien">
                    <span runat="server"
                         id="spnTT"></span>
                </asp:Panel>
            </div>
            <div id="right">
                <h3>Danh sach hang hoa</h3>
                <asp:GridView runat="server"
                    AutoGenerateColumns="false"
                    ID="grvHH">
                    <Columns>
                        <asp:BoundField HeaderText="Ma" DataField="Ma" />
                        <asp:BoundField HeaderText="Ten hang hoa" DataField="Ten" />
                        <asp:BoundField HeaderText="Gia" DataField="Gia" />
                        <asp:TemplateField HeaderText="Mua">
                            <ItemTemplate>
                                <asp:Button runat="server"
                                    ID="btnMua"
                                    CommandArgument='<%#Eval("Ma") %>'
                                    OnClick="btnMua_Click"
                                    Text="Mua" />
                            </ItemTemplate>
                        </asp:TemplateField>
                    </Columns>
                </asp:GridView>

                <h3>Thong tin gio hang</h3>
                <asp:GridView runat="server"
                    AutoGenerateColumns="false"
                    ID="grvGH">
                    <Columns>
                        <asp:BoundField HeaderText="Ma"
                            DataField="Ma" />
                        <asp:BoundField HeaderText="Ten"
                            DataField="Gia" />
                        <asp:BoundField HeaderText="Gia"
                            DataField="Gia" />
                        <asp:BoundField HeaderText="So luong"
                            DataField="SoLuong" />
                        <asp:TemplateField HeaderText="Xoa">
                            <ItemTemplate>
                                <asp:Button runat="server"
                                    CommandArgument='<%#Eval("Ma") %>'
                                    Text="Xoa"
                                    OnClick="btnXoa_Click"
                                    ID="btnXoa" />
                            </ItemTemplate>
                        </asp:TemplateField>
                    </Columns>
                </asp:GridView>
                <asp:Button runat="server"
                    ID="btnXoaHet"
                    Text="Xoa het"
                    OnClick="btnXoaHet_Click" />
            </div>
        </div>
    </form>
</body>
</html>
