using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_Search : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            pnlDanhMuc.Visible = false;
            pnlSanPham.Visible = false;
        }
        string url = HttpContext.Current.Request.Url.AbsolutePath;
        if (url.Substring(url.LastIndexOf("/") + 1) != "search")
        //if (MyUtility.ChuoiHopLe(this.RouteData.Values["key"].ToString()))
        {
            LoadSearchDanhMuc(this.RouteData.Values["key"].ToString());
            LoadSearchSanPham(this.RouteData.Values["key"].ToString());
        }
        else
        {
            Response.Redirect("/admin/sanpham");
        }
    }
    public void LoadSearchDanhMuc(string key)
    {
        var kq = Category.LayDSDM(key);
        if (kq.Count() != 0)
        {
            pnlDanhMuc.Visible = true;
            rptDanhMuc.DataSource = kq;
            rptDanhMuc.DataBind();
        }
        else
            pnlDanhMuc.Visible = false;
    }
    public void LoadSearchSanPham(string key)
    {
        var kq = Product.LayDSSP(key);
        if (kq.Count() != 0)
        {
            pnlSanPham.Visible = true;
            rptSanPham.DataSource = kq;
            rptSanPham.DataBind();
        }
        else
            pnlSanPham.Visible = false;
    }
    protected void lbtnTen_Click(object sender, EventArgs e)
    {
        Response.Redirect("/admin/danhmuc/" + (sender as LinkButton).CommandArgument);
    }
    protected void lbtnTen_Click1(object sender, EventArgs e)
    {
        Response.Redirect("/admin/sanpham/" + (sender as LinkButton).CommandArgument);
    }
}