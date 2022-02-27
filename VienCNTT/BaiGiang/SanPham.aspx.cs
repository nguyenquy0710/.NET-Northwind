using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class SanPham : TrangCoGioHang
{
    private int TrangHienTai
    {
        get
        {
            //if (ViewState["ht"] == null)
            //    ViewState["ht"] = 0;
            return int.Parse(ViewState["ht"].ToString());
        }
        set
        {
            ViewState["ht"] = value;
        }
    }
    private int TongSoTrang
    {
        set
        {
            ViewState["tong"] = value;
        }
        get
        {
            return int.Parse(ViewState["tong"].ToString());
        }
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        h2TB.Visible = false;
        if (!this.IsPostBack)
        {
            TrangHienTai = 0;
        }
    }
    protected void Page_PreRender(object sender, EventArgs e)
    {
        //if (Request.QueryString["cat"] == null)
        //    if (Request.QueryString["tk"] == null)
        if (this.RouteData.Values["cat"] == null)
            if (this.RouteData.Values["tk"] == null)
            {

                LoadSPPhanTrang();
            }
            else
                LoadHHTheoTen();
        else
            LoadHHTheoDM();
    }

    private void LoadHHTheoTen()
    {
        //var ten = Request.QueryString["tk"];
        var ten = this.RouteData.Values["tk"].ToString();
        PagedDataSource pd = new PagedDataSource();
        pd.DataSource = Product.LayDSSP(ten);

        XuLyPT(pd);

        dtlSP.DataSource = pd;
        dtlSP.DataBind();
        if (dtlSP.Items.Count == 0)
        {
            h2TB.Visible = true;
            h2TB.InnerText = "Không có sản phẩm nào được tìm thấy!";
        }
    }

    private void LoadHHTheoDM()
    {
        //var maDM = int.Parse(Request.QueryString["cat"]);
        var maDM = int.Parse(this.RouteData.Values["cat"].ToString());
        PagedDataSource pd = new PagedDataSource();
        pd.DataSource = Product.LayDSSP(maDM);

        XuLyPT(pd);

        dtlSP.DataSource = pd;
        dtlSP.DataBind();
    }

    private void LoadHH()
    {
        dtlSP.DataSource = Product.DSSP;
        dtlSP.DataBind();
    }
   
    protected void ibtnMua_Click(object sender, ImageClickEventArgs e)
    {
        var ma = int.Parse((sender as ImageButton).CommandArgument);
        var sp = Product.Tim(ma);
        if (sp != null)
        {
            this.GioHang.Mua(sp, 1);
        }
    }

    private void LoadSPPhanTrang()
    {
        PagedDataSource pd = new PagedDataSource();
        pd.DataSource = Product.DSSP;

        XuLyPT(pd);

        dtlSP.DataSource = pd;
        dtlSP.DataBind();
    }

    private void XuLyPT(PagedDataSource pd)
    {
        pd.AllowPaging = true;
        pd.PageSize = 8;
        pd.CurrentPageIndex = this.TrangHienTai;

        this.TongSoTrang = pd.PageCount;
        //hien thi trang hien tai:
        lblHienTai.Text = (TrangHienTai + 1) + "/" + TongSoTrang;
        //disable cac linkbutton truoc/tiep:
        lbtnTruoc.Enabled = !(TrangHienTai == 0);
        lbtnTiep.Enabled = !(TrangHienTai == (TongSoTrang - 1));
    }
    protected void lbtnTruoc_Click(object sender, EventArgs e)
    {
        if (TrangHienTai > 0)
            this.TrangHienTai--;
    }
    protected void lbtnTiep_Click(object sender, EventArgs e)
    {
        if (TrangHienTai < TongSoTrang - 1)
            this.TrangHienTai++;
    }
}