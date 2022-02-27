using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;


public partial class Admin_QLHH : TrangQuanTri
{
    protected void Page_Load(object sender, EventArgs e)
    {
        MyReset();
        if (!IsPostBack)
        {
            PL.LoadDM2DDL(ddlDM);
            PL.LoadDM2DDL(ddlChonDM, true);
            PL.LoadNCC2DDL(ddlNCC);
            PL.LoadSP2GV(grvDS);
            ThucThiQuyen();
        }
    }
    private void ThucThiQuyen()
    {
        //lay cac nut, link tren frmContainer:
        //de hien thuc quyen cho chung.
        MasterPage master = this.Master as MasterPage;
        var frm = master.FindControl("frmContainer") as HtmlForm;
        if (this.NhanVien.RoleID != 1)
            TrangQuanTri.ApDungPhanQuyen(frm, this.Quyen);
    }
    private void MyReset()
    {
        h3TB.InnerText = string.Empty;
    }

    protected void btnCapNhat_Click(object sender, EventArgs e)
    {
        int ma;
        if (!int.TryParse(h3Ma.InnerText, out ma))
        {
            h3TB.InnerText = "Hãy chọn sản phẩm trong danh sách";
            return;
        }
        string ten;
        if (!MyUtility.TextBoxHopLe(txtTen, out ten))
        {
            h3TB.InnerText = "Hãy nhập tên sản phẩm";
            return;
        }
        double gia;
        if (!double.TryParse(txtGia.Text, out gia))
        {
            h3TB.InnerText = "Đơn giá không hợp lệ";
            return;
        }
        Product p = new Product()
        {
            ProductID = ma,
            ProductName = ten,
            UnitPrice = (decimal)gia,
            CategoryID = int.Parse(ddlDM.SelectedValue),
            SupplierID = int.Parse(ddlNCC.SelectedValue),
        };
        if (MyUtility.HinhHopLe(fulHinh))
        {
            //them hinh moi:
            p.Image = fulHinh.FileName;
            string path = "~/Hinh/SanPham/" + p.Image;
            path = Server.MapPath(path);
            fulHinh.SaveAs(path);
            //load hinh:
            imgSP.ImageUrl = p.DuongDanHinh;
        }
        Product.Sua(p);
        PL.LoadSP2GV(grvDS);

    }
    protected void btnThem_Click(object sender, EventArgs e)
    {
        string ten;
        if (!MyUtility.TextBoxHopLe(txtTen, out ten))
        {
            h3TB.InnerText = "Hãy nhập tên sản phẩm";
            return;
        }
        double gia;
        if (!double.TryParse(txtGia.Text, out gia))
        {
            h3TB.InnerText = "Đơn giá không hợp lệ";
            return;
        }
        Product p = new Product()
        {
            ProductName = ten,
            UnitPrice = (decimal)gia,
            CategoryID = int.Parse(ddlDM.SelectedValue),
            SupplierID = int.Parse(ddlNCC.SelectedValue),
        };
        if (MyUtility.HinhHopLe(fulHinh))
        {
            p.Image = fulHinh.FileName;
            string path = "~/Hinh/SanPham/" + p.Image;
            path = Server.MapPath(path);
            fulHinh.SaveAs(path);
            //load hinh:
            imgSP.ImageUrl = p.DuongDanHinh;
        }
        Product.Them(p);
        PL.LoadSP2GV(grvDS);
    }
    protected void lbtnTen_Click(object sender, EventArgs e)
    {
        var ma = int.Parse((sender as LinkButton).CommandArgument);
        var kq = Product.Tim(ma);
        if (kq != null)
        {
            h3Ma.InnerText = kq.ProductID.ToString();
            txtGia.Text = kq.UnitPrice.ToString();
            txtTen.Text = kq.ProductName;
            ddlNCC.SelectedValue = kq.SupplierID.ToString();//active muc tuong ung
            ddlDM.SelectedValue = kq.CategoryID.ToString();
            imgSP.ImageUrl = kq.DuongDanHinh;
        }

    }
    protected void ibtnXoa_Click(object sender, ImageClickEventArgs e)
    {
        var ma = int.Parse((sender as ImageButton).CommandArgument);
        Product.Xoa(ma);
        ddlChonDM_SelectedIndexChanged(null, null);
    }
    protected void ddlChonDM_SelectedIndexChanged(object sender, EventArgs e)
    {
        var ma = int.Parse(ddlChonDM.SelectedValue);
        if (ma == 0)
            PL.LoadSP2GV(grvDS);
        else
            //load san pham theo danh muc:
            PL.LoadSP2GV(grvDS, ma);
    }
    protected void btnLocTen_Click(object sender, EventArgs e)
    {
        var ma = int.Parse(ddlChonDM.SelectedValue);
        PL.LoadSP2GV(grvDS, ma, txtLocTen.Text.Trim());
    }
    protected void grvDS_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        grvDS.PageIndex = e.NewPageIndex;
        var maLoai = int.Parse(ddlChonDM.SelectedValue);
        if (maLoai == 0)
            PL.LoadSP2GV(grvDS);
        else if (maLoai > 0)
            PL.LoadSP2GV(grvDS, maLoai);

        string ten;
        if (MyUtility.TextBoxHopLe(txtLocTen, out ten))
            PL.LoadSP2GV(grvDS, maLoai, ten);
    }
}