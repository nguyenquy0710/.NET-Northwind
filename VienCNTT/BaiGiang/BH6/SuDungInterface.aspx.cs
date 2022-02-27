using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class BH6_SuDungInterface : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        List<IHinh> lst = new List<IHinh>();
        lst.Add(new HinhTron()
        {
            BanKinh = 10
        });
        lst.Add(new HinhCN()
        {
            Dai = 4,
            Rong = 5
        });
        foreach (var i in lst)
            Response.Write(i.ChuVi + "<br/>");
    }
}
//trong App_Code hay thiet ke 1 interface
//IGio sao cho no phu hop voi class Gio