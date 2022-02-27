function fnTest() {
    var x, y;
    x = y = 10;
    var kq = x + y;
    alert('tong = ' + kq);
}
//ham tinh tong tu 1 den n:
function tinhTong(n) {
    var s = 0;
    for (var i = 1; i <= n; i++)
        s += i;
    return s;
}
//ham tim UCLN cua 2 so nguyen
function UCLN(a, b) {
    while (a * b > 0)
        if (a > b) a = a - b;
        else b = b - a;
    return a + b;
}
//ham tim so ngay cua thang bat ky, nam bat ky:
//nam nhuan la nam chia het cho 4 nhung khong chia het 100
//hoac la nam chia het cho 400.
var timSoNgay = function (t, n) {
    var sn = 0;
    switch (t) {
        case 1:case 3: case 5: case 7: case 8: case 10: case 12:
            sn = 31; break;
        case 4: case 6: case 9: case 11:
            sn = 30; break;
        case 2:
            switch (n % 4) {
                case 0: sn = 29; break;
                default: sn = 28; break;
            }
            break;
    }
    
    return sn;
}