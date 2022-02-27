using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for NguoiXem
/// </summary>
public class NguoiXem
{
    public double SoTien { set; get; }
    public string Ten { set; get; }
    public void DangKy(Galaxy g)
    {
        if (g.DiaChi.Contains("tp hcm"))
            g.PhimMoi += XuLy;//khong duo phep su dung phep gan
    }

    private void XuLy(Object rap, Phim p)
    {
        Galaxy tam = rap as Galaxy;
        
        //xu ly thong tin tren tam neu muon.
        if (SoTien < p.GiaVe)
            HttpContext.Current.Response.Write(Ten + " Di ngu");
        else
            HttpContext.Current.Response.Write(Ten + " Di xem");
    }
}