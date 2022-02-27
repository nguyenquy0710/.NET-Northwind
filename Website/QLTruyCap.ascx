<%@ Control Language="C#" AutoEventWireup="true" CodeFile="QLTruyCap.ascx.cs" Inherits="QLTruyCap" %>
<style type="text/css">
    #table {
        background-color: #4cff00;
        width: 100%;
        border-radius:5px 5px;
        background: green;
        background: -webkit-linear-gradient(left, green, yellow);
        background: -o-linear-gradient(right, green, yellow);
        background: -moz-linear-gradient(right, green, yellow);
        background: linear-gradient(to right, green, yellow);
    }
</style>
<table id="table">
    <tr>
        <td>Online: &nbsp;
                                <span runat="server" id="spnOnline"></span>
        </td>
    </tr>
    <tr>
        <td>Sum: &nbsp;
                                <span runat="server" id="spnSum"></span>
        </td>
    </tr>
</table>
