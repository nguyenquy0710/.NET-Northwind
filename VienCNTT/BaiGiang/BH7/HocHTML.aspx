<%@ Page Language="C#" AutoEventWireup="true" CodeFile="HocHTML.aspx.cs" Inherits="BH7_HocHTML" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Mot so the HTML</title>
    <style type="text/css">
        li { /*chon tat cac cac the li*/
            text-transform: uppercase;
            text-decoration: underline;
        }
        /*chon tat cac the co class="muc1"*/
        .muc1 {
            font-weight: bold;
            font-style: italic;
            font-size: large;
        }
        /*chon tag co id='timKiem'*/
        #timKiem {
            color: white;
            background-color: blue;
            text-decoration: none;
            width: 500px;
            height: 50px;
            line-height: 50px;
        }
        /*slector dang phuc hop (vi du: gom tag+class)*/
        ol li.muc1 {
            background-color: yellow;
        }

        input[type='button'] {
            color: green;
            background-color: yellow;
        }

        img {
            border-radius: 5px;
            top:20px;
            left:30px;
            position:absolute;
        }
        div {
            margin:100px;
            padding-top:100px;
            border:1px dotted black;
        }
    </style>
</head>
<body>
    <h1><font color="red"> Tieu de cap 1</font>
    </h1>
    <!--heading-->
    <hr />
    <h3>Tieu de cap 3</h3>
    <p style="border: 1px solid blue; text-align: center; color: red;">
        Noi dung doan van ban
        <br />
        <!--break-->
        Noi dung doan van ban
    </p>
    <table>
        <tr>
            <!--table row-->
            <th>Cot 1</th>
            <!--table header-->
            <th>Cot 2</th>
        </tr>
        <tr>
            <td>O 11</td>
            <!--table data-->
            <td>O 12</td>
        </tr>
    </table>
    <ol>
        <!--order list-->
        <li class="muc1">muc 1
        </li>
        <li>muc 2
        </li>
    </ol>
    <ul>
        <!--unorder list-->
        <li class="muc1">muc 1
        </li>
        <li>muc 2
        </li>
    </ul>
    <br />
    <span>Noi dung van ban don gian</span>
    <div>
        mot vung noi dung gi do
    </div>
    <a id="timKiem" href="http://google.com.vn" target="_blank">
        <!--a = anchor-->
        Tim kiem bang google
    </a>

    <%--mot so the input:--%>
    <input type="text" value="asdfasdf" />
    <input type="button" value="Dang nhap" />
    <input type="checkbox" checked="checked" />
    &nbsp;Nam
    <input type="radio" />Dai hoc
    <%--the hinh anh (image)--%>
    <img src="bavi.jpg" width="500" alt="khong co hinh" />
</body>
</html>
