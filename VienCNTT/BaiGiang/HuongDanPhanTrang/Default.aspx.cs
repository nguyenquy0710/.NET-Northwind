using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class HuongDanPhanTrang_Default : System.Web.UI.Page
{
    //tao thuoc tinh su dung bien viewstate de luu tru gia tri cua trang hien tai
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
    protected void Page_PreRender(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            this.TrangHienTai = 0;
        }
        //LoadSP();
        LoadSPPhanTrang();
    }

    private void LoadSPPhanTrang()
    {
        PagedDataSource pd = new PagedDataSource();
        pd.DataSource = Product.DSSP;

        pd.AllowPaging = true;
        pd.PageSize = 8;
        pd.CurrentPageIndex = this.TrangHienTai;

        this.TongSoTrang = pd.PageCount;

        repSP.DataSource = pd;
        repSP.DataBind();

        //hien thi trang hien tai:
        lblHienTai.Text = (TrangHienTai + 1) + "/" + TongSoTrang;
        //disable cac linkbutton truoc/tiep:
        lbtnTruoc.Enabled = !(TrangHienTai == 0);
        lbtnTiep.Enabled = !(TrangHienTai == (TongSoTrang - 1));
    }

    private void LoadSP()
    {
        repSP.DataSource = Product.DSSP;
        repSP.DataBind();
    }
    protected void lbtnTiep_Click(object sender, EventArgs e)
    {
        if (TrangHienTai < TongSoTrang - 1)
            this.TrangHienTai++;
    }
    protected void lbtnTruoc_Click(object sender, EventArgs e)
    {
        if (TrangHienTai > 0)
            this.TrangHienTai--;
    }
}