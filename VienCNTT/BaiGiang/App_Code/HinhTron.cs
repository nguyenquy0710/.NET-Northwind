using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


public class HinhTron : IHinh
{
    public double BanKinh { set; get; }
    public double ChuVi
    {
        get
        {
            return 2 * BanKinh * Math.PI;
        }
    }

    public string Ten
    {
        get
        {
            return "Hinh Tron";
        }
    }

    public double DienTich()
    {
        return Math.PI * Math.Pow(BanKinh, 2);
    }
}