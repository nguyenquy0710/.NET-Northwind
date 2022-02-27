using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class CTSP : TrangCoGioHang
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!this.IsPostBack)
        {
            LoadCTSP();
        }
    }

    private void LoadCTSP()
    {
        //if (Request.QueryString["id"] != null)
        if (this.RouteData.Values["id"] != null)
        {
            //var ma = int.Parse(Request.QueryString["id"]);
            var ma = int.Parse(this.RouteData.Values["id"].ToString());
            var kq = Product.Tim(ma);
            if (kq != null)
            {
                h4Ten.InnerText = kq.ProductName;
                h4Gia.InnerText = kq.UnitPrice.ToString();
                imgSP.ImageUrl = kq.DuongDanHinh;
                //hien thi thong tin danh muc:
                var dm = Category.Tim((int)kq.CategoryID);
                aDM.InnerText = dm.CategoryName + " (" + dm.Products.Count + ")";

            }
        }
    }
    protected void ibtnMua_Click(object sender, ImageClickEventArgs e)
    {

        if (Request.QueryString["id"] != null)
        {
            var ma = int.Parse(Request.QueryString["id"]);

            var sp = Product.Tim(ma);
            if (sp != null)
            {
                this.GioHang.Mua(sp, 1);
            }
        }
    }
    protected void aDM_ServerClick(object sender, EventArgs e)
    {
        if (Request.QueryString["id"] != null)
        {
            var ma = int.Parse(Request.QueryString["id"]);
            var kq = Product.Tim(ma);
            Response.Redirect("SanPham.aspx?cat=" + kq.CategoryID);
        }
    }
}