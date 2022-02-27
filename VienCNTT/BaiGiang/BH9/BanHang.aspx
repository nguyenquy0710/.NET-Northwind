<%@ Page Language="C#" AutoEventWireup="true" CodeFile="BanHang.aspx.cs" Inherits="BH9_BanHang" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        table {
            border-collapse:collapse;
            width:100%;
        }
        table tr td{
            border:1px solid green;
        }
    </style>
    <script src="../BH8/HangHoa.js"></script>
    <script src="../BH8/KhoHang.js"></script>
    <script src="Gio.js"></script>

    <script type="text/javascript">
        var kho = new KhoHang();
        var g = new Gio();
        function xoaTableGH() {
            var t = document.getElementById('tblTTGH');
            while (t.childNodes.length > 0)
                t.removeChild(t.childNodes[0]);
        }
        function loadGioHang() {
            var t = document.getElementById('tblTTGH');
            //xoa rong gio:
            xoaTableGH();
            //hien thi gio:
            document.getElementById('spnTT').innerText = "Tong tien = " + g.tongTien() + " VND";
            var tr, tdTen, tdGia, tdSoLuong, tdXoa, nutXoa;
            for (var i = 0; i < g.ds.length; i++) {
                tr = document.createElement('tr');
                //ten:
                tdTen = document.createElement('td');
                tdTen.innerText = g.ds[i].ten;
                //gia:
                tdGia = document.createElement('td');
                tdGia.innerText = g.ds[i].gia;
                //so luong:
                tdSoLuong = document.createElement('td');
                tdSoLuong.innerText = g.ds[i].soLuong;
                //cot xoa:
                tdXoa = document.createElement('td');
                //nut xoa:
                nutXoa = document.createElement('input');
                nutXoa.value = "Xoa";
                nutXoa.type = "button";
                nutXoa.name = g.ds[i].ma;
                nutXoa.onclick = function () {
                    var maHH = parseInt(this.name);
                    g.xoa(maHH);
                    //load lai gio hang sau khi xoa:
                    loadGioHang();
                };
                tdXoa.appendChild(nutXoa);

                tr.appendChild(tdTen);
                tr.appendChild(tdGia);
                tr.appendChild(tdSoLuong);
                tr.appendChild(tdXoa);

                t.appendChild(tr);
            }
        }
        function loadDSHH() {
            var ds = kho.layDSHH();
            //lay table hien thi hang hoa:
            var tHH = document.getElementById('tblDSHH');
            //them du lieu vao tHH:
            ds.forEach(function (h) {
                var tr = document.createElement('tr');
                //ma:
                var tdMa = document.createElement('td');
                tdMa.innerText = h.ma;
                tr.appendChild(tdMa);
                //ten:
                var tdTen = document.createElement('td');
                tdTen.innerText = h.ten;
                tr.appendChild(tdTen);

                //gia:
                var tdGia = document.createElement('td');
                tdGia.innerText = h.gia;
                tr.appendChild(tdGia);
                //cot mua:
                var tdMua = document.createElement('td');
                //tao nut mua:
                var nutMua = document.createElement('input');
                nutMua.type = "button";
                nutMua.value = "Mua";
                //gui ma hang hoa vao thuoc tinh cua nut:
                nutMua.name = h.ma;
                //anonymous function (ham vo danh) de xu ly su kien onlick:
                nutMua.onclick = function () {
                    //tim hang muon mua trong kho:
                    var hMua = kho.tim(parseInt(this.name));
                    if (hMua != null) {
                        g.mua(hMua, 1);
                        loadGioHang();
                    }
                };

                tdMua.appendChild(nutMua);
                tr.appendChild(tdMua);

                tHH.appendChild(tr);
            });
        }
        window.onload = function () {
            loadDSHH();
        }
    </script>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Danh sach hang hoa:</h2>
            <table id="tblDSHH"></table>
            <h2>Thong tin gio hang:</h2>
            <table id="tblTTGH"></table>
            <br />
            <span id="spnTT"></span>
        </div>
    </form>
</body>
</html>
