using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

public partial class Admin_QLDM : TrangQuanTri
{

    protected void Page_Load(object sender, EventArgs e)
    {
        MyReset();
        if (!IsPostBack)
        {
            PL.LoadDM2GV(grvDM);
            if (this.NhanVien.RoleID != 1)
                ThucThiQuyen();
        }
    }

    private void ThucThiQuyen()
    {
        //lay cac nut, link tren frmContainer:
        //de hien thuc quyen cho chung.
        MasterPage master = this.Master as MasterPage;
        var frm = master.FindControl("frmContainer") as HtmlForm;
        TrangQuanTri.ApDungPhanQuyen(frm, this.Quyen);
    }

    private void MyReset()
    {
        h3TB.InnerText = string.Empty;
    }
    protected void lbtnTenDM_Click(object sender, EventArgs e)
    {
        var maDM = int.Parse((sender as LinkButton).CommandArgument);
        var kq = Category.Tim(maDM);
        if (kq != null)
        {
            h3Ma.InnerText = kq.CategoryID.ToString();
            txtMoTa.Text = kq.Description;
            txtTen.Text = kq.CategoryName;
        }
    }
    protected void ibtnXoa_Click(object sender, ImageClickEventArgs e)
    {
        var maDM = int.Parse((sender as ImageButton).CommandArgument);
        Category.Xoa(maDM);
        PL.LoadDM2GV(grvDM);

    }
    protected void btnThem_Click(object sender, EventArgs e)
    {
        string ten = string.Empty;
        if (!MyUtility.TextBoxHopLe(txtTen, out ten))
        {
            h3TB.InnerText = "Hãy nhập tên danh mục";
            return;
        }
        Category c = new Category()
        {
            CategoryName = ten,
            Description = txtMoTa.Text
        };
        Category.Them(c);
        PL.LoadDM2GV(grvDM);
    }
    protected void btnCapNhat_Click(object sender, EventArgs e)
    {
        int ma;
        if (!int.TryParse(h3Ma.InnerText, out ma))
        {
            h3TB.InnerText = "Hãy chọn danh mục trong danh sách";
            return;
        }
        string ten = string.Empty;
        if (!MyUtility.TextBoxHopLe(txtTen, out ten))
        {
            h3TB.InnerText = "Hãy nhập tên danh mục";
            return;
        }
        Category c = new Category()
        {
            CategoryID = ma,
            CategoryName = ten,
            Description = txtMoTa.Text
        };
        Category.Sua(c);
        PL.LoadDM2GV(grvDM);
    }
}