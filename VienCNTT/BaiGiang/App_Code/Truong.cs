using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Truong
/// </summary>
public class Truong
{
    public List<SinhVien> dssv = new List<SinhVien>();
    public List<string> dshpMo = new List<string>();
    public delegate void MoLopHPHandler(Truong t);
    private MoLopHPHandler MoLop;
    public void OnMoLop()
    {
        //if (MoLop != null) MoLop(this);
        foreach (SinhVien s in dssv)
            MoLop += s.XuLy;
        if (MoLop != null) MoLop(this);
    }
    private SinhVien TimSV(string ten)
    {
        foreach (var h in dssv)
            if (h.Ten == ten) return h;
        return null;
    }
    public void ThemSV(SinhVien s)
    {
        if (TimSV(s.Ten) == null)
            dssv.Add(s);
    }
}