function Gio() {
    //mang chua ds hang hoa:
    this.ds = new Array();
    this.tim = function (ma) {
        for (var i = 0; i < this.ds.length; i++)
            if (ma == this.ds[i].ma) return this.ds[i];
        return null;
    }
    this.mua = function (h, n) {
        var kq = this.tim(h.ma);
        if (kq == null)//them moi:
        {
            var kt = this.ds.length++;//kt = gia tri cua length truoc khi ++
            h.soLuong = n;
            this.ds[kt] = h;
        }
        else//cap nhat so luong
            kq.soLuong += n;
    };
    this.tongTien = function () {
        var s = 0;
        for (var i = 0; i < this.ds.length; i++)
            s += this.ds[i].gia * this.ds[i].soLuong;
        return s;
    };
    this.xoa = function (ma) {
        //tim vi tri hang hoa can xoa:
        var vt = -1;
        for(var i=0;i<this.ds.length;i++)
            if (this.ds[i].ma == ma) {
                vt = i;
                break;
            }
        //xoa phan tu o vt bang cach chuyen du lieu & xoa pt cuoi cung:
        if (vt != -1) {
            for (var i = vt; i < this.ds.length - 1; i++)
                this.ds[i] = this.ds[i + 1];
            this.ds.length--;
        }
    }
}