using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Nghiem
/// </summary>
public class Nghiem
{
    public double X1 { set; get; }
    public double X2 { set; get; }

    public override string ToString()
    {
        //su dung string.format:
        return string.Format(@"nghiem 1 = {0}, 
        nghiem 2 = {1}", X1, X2);
    }
}