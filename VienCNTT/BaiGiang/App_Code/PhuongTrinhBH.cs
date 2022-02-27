using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


public class PhuongTrinhBH
{
    //cac properties:
    public double HeSoA { set; get; }
    public double HeSoB { set; get; }
    public double HeSoC { set; get; }

    private double Delta
    {
        get
        {
            return Math.Pow(HeSoB, 2) - 4 * HeSoA * HeSoC;
        }
    }
    public Nghiem Giai()
    {
        try
        {
            if (Delta < 0) return null;
            else
            {
                double x1 = (-HeSoB - Math.Sqrt(Delta)) / (2 * HeSoA);
                x1 = Math.Round(x1, 2);//2 chu so thap phan.
                double x2 = (-HeSoB + Math.Sqrt(Delta)) / (2 * HeSoA);
                x2 = Math.Round(x2, 2);
                //tao object dong thoi gan gia tri:
                return new Nghiem()
                {
                    X1 = x1,
                    X2 = x2
                };
            }
        }
        catch
        {
            return null;
        }
    }
}