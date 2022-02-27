using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Gio
/// </summary>
public class Gio : List<Product>, IGio
{

    public int Tam { set; get; }
    public double TongTien
    {
        get
        {
            var tong = 0.0;
            foreach (Product h in this)
                tong += (double)h.UnitPrice * h.Quantity;
            return tong;
        }
    }
    public int SoMatHang
    {
        get
        {
            return this.Count;
        }
    }
    public Product Tim(int ma)
    {
        foreach (Product h in this)
            if (h.ProductID == ma) return h;
        return null;
    }
    public void Mua(Product h, int sl)
    {
        var kq = Tim(h.ProductID);
        if (kq == null)//them moi
        {
            h.Quantity = sl;
            this.Add(h);
        }
        else//cap nhat so luong
        {
            kq.Quantity += sl;
        }
    }
    public override string ToString()
    {
        string kq = string.Empty;
        foreach (Product h in this)
            kq = kq + "<p>" + h.ToString() + "</p>";
        return kq;
    }
    public void Xoa(int ma)
    {
        var kq = Tim(ma);
        if (kq != null)
            if (kq.Quantity > 1)
                kq.Quantity--;
            else
                this.Remove(kq);
    }
    public void Xoa()//xoa het hang hoa trong gio
    {
        this.Clear();
    }
    //viet property tong so luong hang hoa trong gio:
    public int TongSoLuong
    {
        get
        {
            var tong = 0;
            foreach (Product h in this)
                tong += h.Quantity;
            HttpContext.Current.Response.Write("ben trong = " + tong);
            return tong;
        }
    }

    public void CapNhat(int ma, int sl)
    {
        var kq = Tim(ma);
        if (kq != null)//them moi
        {
            kq.Quantity = sl;
        }
    }
}