using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Galaxy
/// </summary>
public class Galaxy
{
    public Phim PhimHienTai { set; get; }
    public string DiaChi { set; get; }
    //cuon so:
    public delegate void PhimMoiHandler(Object sender, Phim p);
    public PhimMoiHandler PhimMoi;
    //ham cho phep phat sinh su kien:
    public void OnPhimMoi()
    {
        if (PhimMoi != null)
            PhimMoi(this, PhimHienTai);
    }
}