<%@ Page Language="C#" AutoEventWireup="true" CodeFile="SuDungTimer.aspx.cs" Inherits="HDSDAjax_SuDungTimer" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:ScriptManager runat="server"
            ID="srmCommon">
        </asp:ScriptManager>
        <div>
            <asp:UpdatePanel runat="server"
                ID="udpSP">
                <ContentTemplate>
                    <asp:GridView runat="server"
                        ID="grvSP">
                    </asp:GridView>
                    <asp:Timer runat="server"
                        Interval="3000"
                        OnTick="timTest_Tick"
                        ID="timTest">
                    </asp:Timer>
                </ContentTemplate>
            </asp:UpdatePanel>

        </div>
    </form>
</body>
</html>
