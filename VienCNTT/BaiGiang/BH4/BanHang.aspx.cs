using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class BH4_BanHang : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!this.IsPostBack)
        {
            Gio g = new Gio();
            g.Xoa();
            var h = Hang.Tim(1);
            g.Mua(h, 5);
            //g.Mua(h, -2);
            h = Hang.Tim(3);
            g.Mua(h, 2);
            Response.Write(g.ToString());
            Response.Write("Tong tien = "+g.TongTien + "<br/>");
            Response.Write(g.TongSoLuong + "<br/>");
        }
    }
}