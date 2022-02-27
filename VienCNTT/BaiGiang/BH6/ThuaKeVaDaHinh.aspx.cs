using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class BH6_ThuaKeVaDaHinh : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        XeMay xm = new XeMay();
        xm.SoHieu = "Xe may 001";
        OTo oto = new OTo();
        oto.SoHieu = "Oto 007";
        MayBay mb = new MayBay();
        mb.SoHieu = "MH123";
        
        List<PTGT> lst = new List<PTGT>();
        lst.Add(xm);
        lst.Add(mb);
        lst.Add(oto);
        foreach (PTGT p in lst)
            p.DiChuyen();
    }
}