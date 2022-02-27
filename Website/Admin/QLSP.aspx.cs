using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

public partial class Admin_QLSP : TrangQuanTri
{
    protected void Page_Load(object sender, EventArgs e)
    {
        MyReset();
        if (!IsPostBack)
        {
            LoadQLSP();
            string url = HttpContext.Current.Request.Url.AbsolutePath;
            //if(MyUtility.ChuoiHopLe(this.RouteData.Values["id"].ToString()))
            if (url.Substring(url.LastIndexOf("/") + 1) != "sanpham")
            {
                LoadSanPham(int.Parse(this.RouteData.Values["id"].ToString()));
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
    private void MyReset()
    {
        h3TB.InnerText = string.Empty;
    }
    private void LoadQLSP()
    {
        PL.LoadSPToGridView(grvSP);
        PL.LoadDM2DDL(ddlDM);
        PL.LoadNhaCungCap(ddlSup);
        PL.LoadDM2DDL(ddlTimDM, true);
    }
    protected void grvSP_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        grvSP.PageIndex = e.NewPageIndex;
        PL.LoadSPToGridView(grvSP);
    }
    protected void btnThem_Click(object sender, EventArgs e)
    {
        string ten;
        if (MyUtility.TextBoxHopLe(txtTen, out ten))
        {
            decimal gia;
            if (!decimal.TryParse(txtDonGia.Text, out gia) && gia < 0)
            {
                h3TB.InnerText = "Giá không hợp lệ";
                return;
            }
            int sl;
            if (!int.TryParse(txtSoLuong.Text, out sl) && sl < 0)
            {
                h3TB.InnerText = "Số lượng không hợp lệ";
                return;
            }
            Product p = new Product()
            {
                ProductName = ten,
                SupplierID = int.Parse(ddlSup.SelectedValue),
                CategoryID = int.Parse(ddlDM.SelectedValue),
                UnitPrice = gia,
                Quantity = sl,
            };
            if (MyUtility.HinhHopLe(fulHinhSP))
            {
                p.Image = fulHinhSP.FileName;
                string path = "~/Image/SanPham/" + p.Image;
                path = Server.MapPath(path);//doi duong dan logic thanh duong dan vat ly => luu phuong thuc co san thanh server
                fulHinhSP.SaveAs(path);
                //load hinh
                imgHinh.ImageUrl = p.DuongDanHinh;
            }
            Product.Them(p);
            PL.LoadSPToGridView(grvSP);
        }
    }
    protected void btnCapNhat_Click(object sender, EventArgs e)
    {
        string ten;
        string tb = string.Empty;
        if (!MyUtility.TextBoxHopLe(txtTen, out ten))
        {
            tb = tb + "tên sản phẩm không được để trống <br />";
        }
        decimal gia;
        if (!decimal.TryParse(txtDonGia.Text, out gia) && gia < 0)
        {
            tb = tb + "Giá không hợp lệ <br />";
        }
        int sl;
        if (!int.TryParse(txtSoLuong.Text, out sl) && sl < 0)
        {
            tb = tb + "Số lượng không hợp lệ <br />";
        }
        if (!string.IsNullOrEmpty(tb))
        {
            h3TB.InnerText = tb;
            tb = string.Empty;
            return;
        }
        Product p = new Product()
        {
            ProductID = int.Parse(h2Ma.InnerText.ToString()),
            ProductName = ten,
            UnitPrice = gia,
            Quantity = sl,
            CategoryID = int.Parse(ddlDM.SelectedValue.ToString()),
            SupplierID = int.Parse(ddlSup.SelectedValue.ToString()),
        };
        if (MyUtility.HinhHopLe(fulHinhSP))
        {
            p.Image = fulHinhSP.FileName;
            string path = "~/Image/SanPham/" + p.Image;
            path = Server.MapPath(path);//doi duong dan logic thanh duong dan vat ly => luu phuong thuc co san thanh server
            fulHinhSP.SaveAs(path);
            //load hinh
            imgHinh.ImageUrl = p.DuongDanHinh;
        }
        Product.Sua(p);
        PL.LoadSPToGridView(grvSP);
    }
    protected void lbtnXoa_Click(object sender, ImageClickEventArgs e)
    {
        var kq = Product.Tim(int.Parse((sender as ImageButton).CommandArgument.ToString()));
        if (kq != null)
        {
            if (kq.Order_Details.Count() == 0)
            {
                Product.Xoa(kq.ProductID);
                PL.LoadSPToGridView(grvSP);
            }
            else
            {
                WebMsgBox.Show("Sản Phẩm Xoá Phải Là Sản Phẩm Không Có Chi Tiết Đơn Đặt Hàng Nào!");
            }
            PL.LoadSPToGridView(grvSP);
        }
    }
    protected void lbtnMa_Click(object sender, EventArgs e)
    {
        int ma = int.Parse((sender as LinkButton).CommandArgument);
        LoadSanPham(ma);
    }
    //load SanPham vao Gridview de edit
    private void LoadSanPham(int ma)
    {
        var kq = Product.Tim(ma);
        if (kq != null)
        {
            h2Ma.InnerText = kq.ProductID.ToString();
            txtTen.Text = kq.ProductName;
            ddlSup.DataValueField = (kq.SupplierID.ToString());
            ddlDM.DataValueField = (kq.CategoryID.ToString());
            txtDonGia.Text = kq.UnitPrice.ToString();
            txtSoLuong.Text = kq.Quantity.ToString();
            imgHinh.ImageUrl = kq.DuongDanHinh;
        }
    }
    protected void btnTim_Click(object sender, EventArgs e)
    {
        int maDm = int.Parse(ddlTimDM.SelectedValue);
        PL.LoadSPToGridView(grvSP, maDm, txtTimTen.Text);
    }
}