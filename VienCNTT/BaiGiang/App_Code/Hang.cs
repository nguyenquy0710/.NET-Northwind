using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Hang
/// </summary>
public class Hang
{
    public int Ma { set; get; }
    public string Ten { set; get; }
    public double Gia { set; get; }
    public int SoLuong { set; get; }
    public DateTime NgaySX { set; get; }
    public override string ToString()
    {
        return string.Format(@"{0}, {1}, {2}, {3}, {4}", Ma, Ten, Gia, SoLuong, NgaySX.ToString("dd/MM/yyyy"));
    }
    static public List<Hang> LayDSHH()
    {
        List<Hang> lst = new List<Hang>();
        lst.Add(new Hang()
        {
            Ma = 1,
            Ten = "Tivi",
            Gia = 100,
            SoLuong = 0,
            NgaySX = new DateTime(2016, 6, 21),
        });
        lst.Add(new Hang()
        {
            Ma = 2,
            Ten = "Laptop",
            Gia = 100,
            SoLuong = 0,
            NgaySX = new DateTime(2016, 6, 21),
        });
        lst.Add(new Hang()
        {
            Ma = 3,
            Ten = "Iphone",
            Gia = 100,
            SoLuong = 0,
            NgaySX = new DateTime(2016, 6, 21),
        });
        return lst;
    }
    static public string Show()
    {
        string kq = string.Empty;
        foreach (Hang h in LayDSHH())
            kq = kq + "<p>" + h.ToString() + "</p>";
        return kq;
    }
    //viet phuong thuc tim hang hoa khi biet ma:
    static public Hang Tim(int ma)
    {
        foreach(Hang h in LayDSHH())
            if(h.Ma == ma)return h;
        return null;
    }
}