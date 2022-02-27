using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

public partial class Admin_QLNV : TrangQuanTri
{
    protected void Page_Load(object sender, EventArgs e)
    {
        h3TB.InnerText = string.Empty;
        if (!IsPostBack)
        {
            LoadQLNV();
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
    //Ham load thong tin nhan vien len vung edit
    private void LoadKhungEdit(Employee e)
    {
        h2Ma.InnerText = e.EmployeeID.ToString();
        h2User.InnerText = e.UserName;
        txtFistName.Text = e.FirstName;
        txtLastName.Text = e.LastName;
        txtNgaySinh.Text = e.BirthDate.ToString();
        txtNote.Text = e.Notes;
        txtPhone.Text = e.HomePhone;
        txtDiaChi.Text = e.Address;
        txtCountry.Text = e.Country;
        imgHinh.ImageUrl = e.DuongDanHinh;
    }
    //Ham load khi trang moi load
    private void LoadQLNV()
    {
        //load nhan vien vao gridview
        PL.LoadNVToGridiew(grvNV);
        //load phan quyen
        PL.LoadVuiTro2DDL(ddlPhanQuyen);
        PL.LoadVuiTro2DDL(ddlTimQuyen, true);
    }
    protected void btnCapNhat_Click(object sender, EventArgs e)
    {
        Employee p = new Employee()
        {
            EmployeeID = int.Parse(h2Ma.InnerText.ToString()),
            UserName = h2User.InnerText,
            FirstName = txtFistName.Text,
            LastName = txtLastName.Text,
            Address = txtDiaChi.Text,
            HomePhone = txtPhone.Text,
            Notes = txtNote.Text,
            Country = txtCountry.Text,
            //BirthDate=ns,
            RoleID = int.Parse(ddlPhanQuyen.SelectedValue),
        };
        if (MyUtility.HinhHopLe(fulSP))
        {
            p.Photo = fulSP.FileName;
            string path = "~/Image/Avatar/" + p.Photo;
            path = Server.MapPath(path);//doi duong dan logic thanh duong dan vat ly => luu phuong thuc co san thanh server
            fulSP.SaveAs(path);
            //load hinh
            imgHinh.ImageUrl = p.DuongDanHinh;
        }
        Employee.Sua(p);
        WebMsgBox.Show("Chỉnh Sửa Thành Công");
        PL.LoadNVToGridiew(grvNV);
    }
    protected void grvSP_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {

    }
    protected void btnTim_Click(object sender, EventArgs e)
    {
        var search = txtTimTen.Text;
        int maRole = int.Parse(ddlTimQuyen.SelectedValue);
        PL.LoadNVToGridiew(grvNV, maRole, search);
    }
    protected void ibtnAvt_Click(object sender, ImageClickEventArgs e)
    {
        Response.Redirect("~/admin/nhanvien/" + (sender as ImageButton).CommandArgument);
    }
    protected void btnXem_Click(object sender, EventArgs e)
    {
        int ma = int.Parse((sender as Button).CommandArgument);
        var kq = Employee.Tim(ma);
        LoadKhungEdit(kq);

    }
    protected void btnXoa_Click(object sender, EventArgs e)
    {
        int maNV = int.Parse(h2Ma.InnerText);
        //goi ham xoa
        Employee.Xoa(maNV);
        WebMsgBox.Show("Xóa Thành Công");
    }
    protected void ddlTimQuyen_SelectedIndexChanged(object sender, EventArgs e)
    {
        int ma = int.Parse(ddlTimQuyen.SelectedValue);
        PL.LoadNVToGridiew(grvNV, ma);
    }
    //protected void btnThem_Click(object sender, EventArgs e)
    //{
    //    //dieu huong toi dang ky tai khoan nhan vien
    //}
    protected void btnXoaGr_Click(object sender, EventArgs e)
    {
        Employee.Xoa(int.Parse((sender as Button).CommandArgument));
        WebMsgBox.Show("Xóa Thành Công");
    }
}