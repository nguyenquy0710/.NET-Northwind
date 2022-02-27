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
        LoadGioHang();
    }

    private void LoadGioHang()
    {
        Gio g = Session["gh"] as Gio;
        grvGH.DataSource = g;
        grvGH.DataBind();
    }
    protected void btnXoa_Click(object sender, EventArgs e)
    {
        Button xoa = sender as Button;
        int maHH = int.Parse(xoa.CommandArgument);
        Gio g = Session["gh"] as Gio;
        g.Xoa(maHH);
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
        if (this.KhachHang == null)
        {
            h3TB.InnerText = "Bạn phải đăng nhập để mua hàng!";
            return;
        }
        if(this.GioHang.SoMatHang == 0)
        {
            h3TB.InnerText = "Bạn chưa mua hàng!";
            return;
        }
        Response.Redirect("/hoadon");
    }
    protected void ibtnRefresh_Click(object sender, ImageClickEventArgs e)
    {
        ImageButton capNhat = sender as ImageButton;
        int maHH = int.Parse(capNhat.CommandArgument);
        var sp = this.GioHang.Tim(maHH);
        if (sp != null)
        {
            //lay textbox chua so luong:
            var dong = capNhat.Parent.Parent;
            var txt = dong.FindControl("txtSL") as TextBox;
            int soLuong;
            if (int.TryParse(txt.Text, out soLuong))
            {
                if (soLuong > 0)
                {
                    this.GioHang.CapNhat(maHH, soLuong);
                    //da load trong prerender.
                }
            }
        }
    }
}