function KhoHang() {
    this.layDSHH = function () {
        var ds = new Set();
        var h1 = new HangHoa(1, "tivi", 100);
        var h2 = new HangHoa(2, "laptop", 100);
        var h3 = new HangHoa(3, "iphone", 100);
        ds.add(h1);
        ds.add(h2);
        ds.add(h3);
        return ds;
    }
    this.hienThiDSHH = function () {
        var ds = this.layDSHH();
        ds.forEach(function (h) {
            document.write(h.toString() + "<br/>");
        });
    }
    this.tim = function (ma) {
        var kq = null;
        this.layDSHH().forEach(function (h) {
            if (h.ma == ma) kq = h;
        });
        return kq;
    }
}