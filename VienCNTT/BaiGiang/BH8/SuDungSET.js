//set = tap hop:
function suDungSet() {
    var s = new Set();
    s.add("anh");
    s.add("cuong");
    s.add("quy");
    s.add("tai");
    //xoa bo phan tu:
    s.delete("anh");
    //xoa het:
    s.clear();
    //duyet:
    s.forEach(function (e) {
        document.write(e + "<br/>");
    });
    if (s.has("van quy")) document.write("tim thay<br/>");
    else document.write("khong tim thay");
}