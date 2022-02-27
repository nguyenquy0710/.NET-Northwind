using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class CTGH : TrangCoGioHang
{
    protected void Page_PreRender(object sender, EventArgs e)
    {
        loadGioHang();
    }

    private void loadGioHang()
    {
        Gio g = Session["gh"] as Gio;
        grvGH.DataSource = g;
        grvGH.DataBind();
    }
    protected void ibtnRefresh_Click(object sender, ImageClickEventArgs e)
    {
        ImageButton reFresh = sender as ImageButton;
        int maSP = int.Parse(reFresh.CommandArgument);
        var sp = this.GioHang.Tim(maSP);
        if (sp != null)
        {
            var row = reFresh.Parent.Parent;
            var txt = row.FindControl("txtSL") as TextBox;
            int soLuong;
            if (int.TryParse(txt.Text, out soLuong))
            {
                if (soLuong > 0)
                {
                    this.GioHang.CapNhat(maSP, soLuong);
                }
            }
        }
    }
    protected void btnXoa_Click(object sender, EventArgs e)
    {
        Button xoa = sender as Button;
        int maSP = int.Parse(xoa.CommandArgument);
        Gio g = Session["gh"] as Gio;
        g.Xoa(maSP);

    }
    protected void btnMuaTiep_Click(object sender, EventArgs e)
    {
        Response.Redirect("/sanpham");
    }
    protected void btnXoaHet_Click(object sender, EventArgs e)
    {
        this.GioHang.Xoa();
    }
    protected void btnTT_Click(object sender, EventArgs e)
    {
        Response.Redirect("/hoadon");
    }
}