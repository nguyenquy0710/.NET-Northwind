using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Gio
/// </summary>
public class Gio
{
    //field:
    List<Hang> dshh = new List<Hang>();
    public double TongTien
    {
        get
        {
            var tong = 0.0;
            foreach (Hang h in this.dshh)
                tong += h.Gia * h.SoLuong;
            return tong;
        }
    }
    public int SoMatHang
    {
        get
        {
            return this.dshh.Count;
        }
    }
    private Hang Tim(int ma)
    {
        foreach (Hang h in this.dshh)
            if (h.Ma == ma) return h;
        return null;
    }
    public void Mua(Hang h, int sl)
    {
        var kq = Tim(h.Ma);
        if (kq == null)//them moi
        {
            h.SoLuong = sl;
            this.dshh.Add(h);
        }
        else//cap nhat so luong
        {
            kq.SoLuong += sl;
        }
    }
    public override string ToString()
    {
        string kq = string.Empty;
        foreach (Hang h in this.dshh)
            kq = kq + "<p>" + h.ToString() + "</p>";
        return kq;
    }
    public void Xoa(int ma)
    {
        var kq = Tim(ma);
        if (kq != null) this.dshh.Remove(kq);
    }
    public void Xoa()//xoa het hang hoa trong gio
    {
        this.dshh.Clear();
    }
    //viet property tong so luong hang hoa trong gio:
    public int TongSoLuong
    {
        get
        {
            var tong = 0;
            foreach (Hang h in this.dshh)
                tong += h.SoLuong;
            HttpContext.Current.Response.Write("ben trong = " + tong);
            return tong;
        }
    }
}