using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for PhanSo
/// </summary>
public class PhanSo
{
    public int Tu { set; get; }
    public int Mau { set; get; }
	public PhanSo()
	{
        Tu = 0; Mau = 1;
	}
    public PhanSo(int t, int m)
    {
        Tu = t;
        Mau = m;
    }
    public PhanSo(PhanSo t)
    {
        HttpContext.Current.Response.Write("copy constructor");
        Tu = t.Tu;
        Mau = t.Mau;
    }
    static public PhanSo operator +(PhanSo p, PhanSo q)
    {
        PhanSo kq = new PhanSo(1,2);
        return kq;
    }
}