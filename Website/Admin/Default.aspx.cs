using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

public partial class Admin_Default : TrangQuanTri
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            LoadSanPhamBanChay();
            //if (this.NhanVien.RoleID != 1)
            //    ThucThiQuyen();
        }
    }
    private void ThucThiQuyen()
    {
        //lay cac nut, link tren frmContainer:
        //de hien thuc quyen cho chung.
        MasterPage master = this.Master as MasterPage;
        var frm = master.FindControl("frmContent") as HtmlForm;
        TrangQuanTri.ApDungPhanQuyen(frm, this.Quyen);
    }
    protected void grvSPBC_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        grvSPBC.PageIndex = e.NewPageIndex;
        LoadSanPhamBanChay();
    }

    private void LoadSanPhamBanChay()
    {
        using (DBDataContext dc = new DBDataContext())
        {
            //var ds = dc.SanPhamBanChay.OrderByDescending(x=>x.So_Luong_Ban_Ra).ToList();
            //grvSPBC.DataSource = ds;
            //grvSPBC.DataBind();
        }
    }
    protected void lbtnTen_Click(object sender, EventArgs e)
    {
        Response.Redirect("/chitiet/" + int.Parse((sender as LinkButton).CommandArgument));
    }
}