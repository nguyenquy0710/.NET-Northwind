using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for HinhCN
/// </summary>
public class HinhCN : IHinh
{
    public double Rong { set; get; }
    public double Dai { set; get; }
    public double ChuVi
    {
        get
        {
            return 2 * (Dai + Rong);
        }
    }

    public string Ten
    {
        get
        {
            return "Hinh Chu Nhat";
        }
    }

    public double DienTich()
    {
        return Dai * Rong;
    }
}