using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class LINQ_LINQ1 : System.Web.UI.Page
{
    int[] a = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
    List<string> DSHT
    {
        get
        {
            List<string> t = new List<string>();
            t.Add("teo");
            t.Add("bin");
            t.Add("tuan");
            t.Add("tu");
            t.Add("lan");
            t.Add("cuc");
            return t;
        }

    }
    protected void Page_Load(object sender, EventArgs e)
    {
        TinhTongCacPhanTuChan();
        DemNhungHoTenChuaChuT();
    }
    void TinhTongCacPhanTuChan()
    {
        //var ds = from i in a
        //         where i % 2 == 0
        //         select i;
        //Response.Write(ds.Sum());
        //lambda expression:
        Response.Write(a.Where(x => x % 2 == 0).Sum());
    }
    void DemNhungHoTenChuaChuT()
    {
        //linq:
        //var dem = (from t in DSHT
        //          where t.Contains("t")
        //          select t).Count();
        //Response.Write(dem);
        //lambda expression:
        var dem = DSHT.Count(x => x.Contains("t"));
        Response.Write(dem);
    }
}