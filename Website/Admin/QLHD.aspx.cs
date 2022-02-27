using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

public partial class Admin_QLHD : TrangQuanTri
{
    protected void Page_Load(object sender, EventArgs e)
    {
        h3TB.InnerText = string.Empty;
        if (!IsPostBack)
        {
            PL.LoadHDToGridView(grvHD);
            if (this.NhanVien.RoleID != 1)
                ThucThiQuyen();
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
    protected void grvHD_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        grvHD.PageIndex = e.NewPageIndex;
        PL.LoadHDToGridView(grvHD);
    }
    protected void btnTim_Click(object sender, EventArgs e)
    {
        string tenKH, tenNV;
        if (!MyUtility.TextBoxHopLe(txtTenKH, out tenKH))
        {

        }
        if (!MyUtility.TextBoxHopLe(txtTenNV, out tenNV))
        {

        }

    }
    protected void lbtnMa_Click(object sender, EventArgs e)
    {
        int maHD = int.Parse((sender as LinkButton).CommandArgument);
        Response.Redirect("/admin/hoadon/chitiet/" + maHD);
    }
    protected void ibtnXoa_Click(object sender, ImageClickEventArgs e)
    {
        var kq = Order.Tim(int.Parse((sender as ImageButton).CommandArgument));
        if (kq != null)
        {
            if (kq.Order_Details.Count() == 0)
            {
                Order.Delete(kq);
                PL.LoadHDToGridView(grvHD);
            }
            else
            {
                WebMsgBox.Show("Hoá Đơn Muốn Xoá Phải Là Hoá Đơn Rỗng");
            }
        }
    }
}