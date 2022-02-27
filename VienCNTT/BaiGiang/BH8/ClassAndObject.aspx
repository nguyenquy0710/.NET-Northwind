<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ClassAndObject.aspx.cs" Inherits="BH8_ClassAndObject" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script src="HangHoa.js"></script>
    <script src="KhoHang.js"></script>
    <script type="text/javascript">
        window.onload = function () {
            //tao object:
            //cach 1 (tao obj don le khong can class):
            //var sv = {
            //    hoTen: 'Tran Van Tuan',
            //    diem: 10,
            //    ngaySinh: new Date(1999, 3, 7),//3 = co nghia la thang 4 http://www.w3schools.com/js/js_date_methods.asp
            //    doiTen: function (tenMoi) {
            //        this.hoTen = tenMoi;
            //    },
            //    sinhNhat: function () {
            //        //lay ngay hien tai:
            //        var ht = new Date();
            //        return this.ngaySinh.getDate() == ht.getDate()
            //        && this.ngaySinh.getMonth() == ht.getMonth();
            //    }
            //};
            //sv.doiTen("Le Quoc Teo");
            //if (sv.sinhNhat())
            //    document.write("chuc mung sinh nhat " + sv.hoTen);
            //else
            //    document.write("khong phai sinh nhat " + sv.hoTen);

            //cach 2: khong can class ma su dung class Object co san:
            //var p = new Object();
            //p.tu = 1;
            //p.mau = 2;
            ////tao method:
            //p.hienThi = function () {
            //    document.write(this.tu + "/" + this.mau);
            //}
            ////goi method:
            //p.hienThi();
            //cach 3: tao class de co the sinh ra nhieu object
            //var h = new HangHoa(1, "tivi", 100);
            //document.write(h.toString());
            var kho = new KhoHang();
            kho.hienThiDSHH();
            var kq = kho.tim(1);
            alert(kq.toString());
        }
    </script>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
    </form>
</body>
</html>
