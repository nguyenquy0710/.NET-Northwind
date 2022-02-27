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
            return int.Parse(ViewState["ht"].ToString());
        }
        set
        {
            ViewState["ht"] = value;
        }
    }
    private int TongSoTrang
    {
        get
        {
            return int.Parse(ViewState["tong"].ToString());
        }
        set
        {
            ViewState["tong"] = value;
        }
    }
    protected void Page_PreRender(object sender, EventArgs e)
    {
        if (this.RouteData.Values["cat"] == null)
            if (this.RouteData.Values["tk"] == null)
            {

                loadSPPhanTrang();
            }
            else
                LoadSPTheoTen();
        else
            LoadSPTheoDM();
    }

    private void LoadSPTheoDM()
    {
        var maDM = int.Parse(this.RouteData.Values["cat"].ToString());
        PagedDataSource pd = new PagedDataSource();
        pd.DataSource = Product.LayDSSP(maDM);
        pd.AllowPaging = true;
        pd.PageSize = 8;
        pd.CurrentPageIndex = this.TrangHienTai;
        this.TongSoTrang = pd.PageCount;
        dtlSP.DataSource = pd;
        dtlSP.DataBind();
        lblHienTai.Text = (TrangHienTai + 1) + "/" + TongSoTrang;
        lbtnTruoc.Enabled = !(TrangHienTai == 0);
        lbtnTiep.Enabled = !(TrangHienTai == (TongSoTrang - 1));
        if (TongSoTrang == 1)
        {
            lbtnTiep.Visible = false;
            lbtnTruoc.Visible = false;
            lblHienTai.Visible = false;
        }
    }
    private void loadSPPhanTrang()
    {
        PagedDataSource pd = new PagedDataSource();
        pd.DataSource = Product.DSSP;
        pd.AllowPaging = true;
        pd.PageSize = 8;
        pd.CurrentPageIndex = this.TrangHienTai;
        this.TongSoTrang = pd.PageCount;
        dtlSP.DataSource = pd;
        dtlSP.DataBind();

        lblHienTai.Text = (TrangHienTai + 1) + "/" + TongSoTrang;
        lbtnTruoc.Enabled = !(TrangHienTai == 0);
        lbtnTiep.Enabled = !(TrangHienTai == (TongSoTrang - 1));
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        h2TB.Visible = false;
        if (!this.IsPostBack)
        {
            this.TrangHienTai = 0;
        }
    }
    private void LoadSPTheoTen()
    {
        var ten = this.RouteData.Values["tk"].ToString();
        PagedDataSource pd = new PagedDataSource();
        pd.DataSource = Product.LayDSSP(ten);
        pd.AllowPaging = true;
        pd.PageSize = 8;
        pd.CurrentPageIndex = this.TrangHienTai;
        this.TongSoTrang = pd.PageCount;
        dtlSP.DataSource = pd;
        dtlSP.DataBind();

        lblHienTai.Text = (TrangHienTai + 1) + "/" + TongSoTrang;
        lbtnTruoc.Enabled = !(TrangHienTai == 0);
        lbtnTiep.Enabled = !(TrangHienTai == (TongSoTrang - 1));
        //
        if (dtlSP.Items.Count == 0)
        {
            h2TB.Visible = true;
            h2TB.InnerText = "Không có sản phẩm nào được tìm thấy";
            lbtnTiep.Visible = false;
            lbtnTruoc.Visible = false;
        }
        if (dtlSP.Items.Count < 8)
        {
            lbtnTiep.Visible = false;
            lbtnTruoc.Visible = false;
            lblHienTai.Visible = false;
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