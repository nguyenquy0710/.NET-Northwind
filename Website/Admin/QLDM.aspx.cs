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
        h3TB.InnerText = string.Empty;
        if (!IsPostBack)
        {
            PL.LoadDMToGridView(grvDM);
            string url = HttpContext.Current.Request.Url.AbsolutePath;
            if (url.Substring(url.LastIndexOf("/") + 1) != "danhmuc")
            //if(MyUtility.ChuoiHopLe(this.RouteData.Values["id"].ToString()))
            {
                LoadDanhMuc(int.Parse(this.RouteData.Values["id"].ToString()));
            }
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
    protected void grvDM_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        grvDM.PageIndex = e.NewPageIndex;
        PL.LoadDMToGridView(grvDM);
    }
    protected void lbtnMa_Click(object sender, EventArgs e)
    {
        int ma = int.Parse((sender as LinkButton).CommandArgument);
        LoadDanhMuc(ma);
    }
    //ham laod thong tin DanhMuc vao Gridview de edit
    private void LoadDanhMuc(int ma)
    {
        var kq = Category.Tim(ma);
        if (kq != null)
        {
            h2Ma.InnerText = kq.CategoryID.ToString();
            txtTen.Text = kq.CategoryName;
            txtMoTa.Text = kq.Description;
        }
    }
    protected void btnThem_Click(object sender, EventArgs e)
    {
        string ten;
        if (MyUtility.TextBoxHopLe(txtTen, out ten))
        {
            Category cat = new Category()
            {
                CategoryName = ten,
                Description = txtMoTa.Text,
            };
            Category.Them(cat);
            PL.LoadDMToGridView(grvDM);
            h3TB.InnerText = "Thêm danh mục thành công!";
        }
        else
        {
            h3TB.InnerText = "Bạn phải nhập danh mục vào trước khi Click Thêm mới";
        }
    }
    protected void btnCapNhat_Click(object sender, EventArgs e)
    {
        int ma;
        bool ok = int.TryParse(h2Ma.InnerText, out ma);
        if (ok)
        {
            var kq = Category.Tim(ma);
            Category cat = new Category()
            {
                CategoryID = int.Parse(h2Ma.InnerText),
                CategoryName = txtTen.Text,
                Description = txtMoTa.Text,
            };
            if (kq != null)
            {
                Category.Sua(cat);
                PL.LoadDMToGridView(grvDM);
                h3TB.InnerText = "Cập nhật danh mục thành công!";
                return;
            }
            else
                h3TB.InnerText = "Không thể cập nhật danh mục này!";
        }
        else
        {
            h3TB.InnerText = "Bạn phải chọn danh mục trước";
        }
    }
    protected void lbtnXoa_Click(object sender, ImageClickEventArgs e)
    {
        int ma = int.Parse((sender as ImageButton).CommandArgument);
        var kq = Category.Tim(ma);
        if (kq != null)
        {
            if (kq.Products.Count() == 0)
            {
                Category.Xoa(kq.CategoryID);
                PL.LoadDMToGridView(grvDM);
                h3TB.InnerText = "Xoá danh mục thành công!";
            }
            else
            {
                h3TB.InnerText = "Danh mục này đang có sản phẩm";
            }
        }
    }
}