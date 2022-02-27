//constructor:
//function HangHoa() {
//    this.ma = 0;
//    this.ten = "khong biet";
//    this.gia = 0;
//    //override method tostring cua class Object:
//    this.toString = function () {
//        return this.ma + ", "
//        + this.ten + ", " + this.gia;
//    }
//}
function HangHoa(ma, ten, gia) {
    this.soLuong = 0;//thuoc tinh so luong se duoc su dung trong gio hang.
    this.ma = ma;
    this.ten = ten;
    this.gia = gia;
    this.toString = function () {
        return this.ma + ", "
        + this.ten + ", " + this.gia;
    }
}

