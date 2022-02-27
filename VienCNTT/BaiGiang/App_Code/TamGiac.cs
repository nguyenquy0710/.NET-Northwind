using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


public class TamGiac
{
    public double CanhA { set; get; }
    public double CanhB { set; get; }
    public double CanhC { set; get; }

    //thuoc tinh kiem tra co la tam giac khong?
    public bool LaTamGiac
    {
        get
        {
            return CanhA + CanhB > CanhC
                && CanhB + CanhC > CanhA
                && CanhC + CanhA > CanhB;
        }
    }
    public double DienTich
    {
        get
        {
            if (!LaTamGiac) return -1;//quy uoc.
            var p = (CanhA + CanhB + CanhC) / 2;
            return Math.Sqrt(p * (p - CanhA) * (p - CanhB) * (p - CanhC));
        }
    }
}