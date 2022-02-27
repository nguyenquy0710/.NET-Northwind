<%@ Page Language="C#" AutoEventWireup="true" CodeFile="SuDungAjaxExtension.aspx.cs" Inherits="HDSDAjax_SuDungAjaxExtension" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:ScriptManager runat="server"
            ID="srmTest">
        </asp:ScriptManager>
        <asp:UpdatePanel ID="udpTest" runat="server"
            UpdateMode="Conditional">
            <ContentTemplate>
                <h2 runat="server" id="h2Time"></h2>
                <asp:Button runat="server" ID="btnLoad"
                    OnClick="btnLoad_Click"
                    Text="Load" />
            </ContentTemplate>
            <Triggers>
                <asp:AsyncPostBackTrigger ControlID="btn23"
                     EventName="click" />
            </Triggers>
        </asp:UpdatePanel>
        <h2 runat="server" id="h2Ngoai"></h2>
        <asp:Button runat="server" ID="btnNgoai"
            Text="Nut ben ngoai" />
        <asp:UpdatePanel ID="udpHai" runat="server">
            <ContentTemplate>
                <h2 runat="server" id="h22"></h2>
                <asp:Button runat="server" ID="btn22"
                    Text="Load 2" />
                <asp:Button runat="server" ID="btn23"
                    Text="Load 2 trigger" />
            </ContentTemplate>
        </asp:UpdatePanel>
        <div>
        </div>
    </form>
</body>
</html>
