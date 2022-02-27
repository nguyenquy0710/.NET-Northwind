<%@ Page Language="C#" AutoEventWireup="true" CodeFile="SuDungWebControl.aspx.cs" Inherits="BH11_SuDungWebControl" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Su dung listbox:<br />
            <asp:ListBox ID="lstNgoaiNgu" runat="server"
                AutoPostBack="true"
                OnSelectedIndexChanged="lstNgoaiNgu_SelectedIndexChanged"></asp:ListBox>

            <br />
            Su dung dropdownlist:<br />
            <asp:DropDownList runat="server"
                ID="ddlNgoaiNgu"
                OnSelectedIndexChanged="ddlNgoaiNgu_SelectedIndexChanged"
                AutoPostBack="true">
            </asp:DropDownList>
            <br />
            Su dung checkboxlist:<br />
            <asp:CheckBoxList runat="server"
                ID="chkNN">
            </asp:CheckBoxList>
            <br />
            <asp:Button runat="server"
                ID="btnPB"
                OnClick="btnPB_Click"
                Text="Post back giup checkboxlist" />
            <br />
            Su dung radiobuttonlist:<br />
            <asp:RadioButtonList runat="server"
                ID="rblNN"
                AutoPostBack="true"
                OnSelectedIndexChanged="rblNN_SelectedIndexChanged">
            </asp:RadioButtonList>
            <br />
            Su dung GridView:
            <br />
            <asp:GridView runat="server" ID="grvNN"
                AutoGenerateColumns="false">
                <Columns>
                    <asp:BoundField HeaderText="Ma ngoai ngu"
                        DataField="Ma" />
                    <asp:BoundField HeaderText="Ten ngoai ngu"
                        DataField="Ten" />
                    <asp:TemplateField HeaderText="Xoa">
                        <ItemTemplate>
                            <asp:Button ID="btnXoa" runat="server"
                                CommandArgument='<%#Eval("Ma") %>'
                                OnClick="btnXoa_Click"
                                Text="Xoa"></asp:Button>
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>
            <br />
            Su dung Repeater<br />
            <asp:Repeater runat="server"
                ID="rptNN">
                <HeaderTemplate>
                    <table>
                        <tr>
                            <th>Ten ngoai ngu</th>
                            <th>Thao tac</th>
                        </tr>

                </HeaderTemplate>
                <ItemTemplate>
                    <tr>
                        <td>
                            <%#Eval("Ten") %>
                        </td>
                        <td>
                            <asp:Button runat="server"
                                ID="btnSua"
                                Text="Sua" />
                        </td>
                    </tr>
                </ItemTemplate>
                <FooterTemplate>
                    </table>
                </FooterTemplate>
            </asp:Repeater>
            <br />
            <asp:Label runat="server" ID="lblKQ"></asp:Label>

        </div>
    </form>
</body>
</html>
