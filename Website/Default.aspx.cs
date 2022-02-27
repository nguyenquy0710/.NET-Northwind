using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : TrangCoGioHang
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            PL.SanPhamBanChay(dtlSP, 8);
        }
    }
    protected void ibtnMua_Click(object sender, ImageClickEventArgs e)
    {
        int ma = int.Parse((sender as ImageButton).CommandArgument);
        var sp = Product.Tim(ma);
        if (sp != null)
        {
            this.GioHang.Mua(sp, 1);
        }
    }
}