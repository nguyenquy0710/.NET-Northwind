using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


public class KhachHang
{
    public string TenDN { set; get; }
    public string HoTen { set; get; }
    public string MatKhau { set; get; }
    public string Hinh { set; get; }//ten file hinh
    public string DuongDanHinh
    {
        get
        {
            return string.Format(@"~/Hinh/KhachHang/{0}",this.Hinh);
        }
    }

    public static List<KhachHang> DSKH
    {
        get
        {
            List<KhachHang> lst = new List<KhachHang>();
            lst.Add(new KhachHang()
            {
                TenDN="kh1",
                MatKhau="123",
                HoTen="Trần Văn Một",
                Hinh="kh1.jpg"
            });
            lst.Add(new KhachHang()
            {
                TenDN = "kh2",
                MatKhau = "123",
                HoTen = "Jet Lee",
                Hinh = "kh2.jpg"
            });
            return lst;
        }
    }
    public static KhachHang Tim(string tenDN)
    {
        foreach (var k in DSKH)
            if (k.TenDN.Equals(tenDN)) return k;
        return null;
    }
}
