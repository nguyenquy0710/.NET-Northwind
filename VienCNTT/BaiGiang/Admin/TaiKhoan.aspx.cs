using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_TaiKhoan : TrangQuanTri
{
    protected void Page_Load(object sender, EventArgs e)
    {
        h3TB.InnerText = string.Empty;

        if (!IsPostBack)
        {
            LoadTTTK();
        }
    }

    private void LoadTTTK()
    {
        if (this.NhanVien != null)
        {
            h3TenDN.InnerText = NhanVien.Username;
            h3VT.InnerText = NhanVien.Role.RoleName;
            txtHo.Text = NhanVien.LastName;
            txtTen.Text = NhanVien.FirstName;
        }
    }
    protected void btnCapNhat_Click(object sender, EventArgs e)
    {
        if (!this.NhanVien.Password.Equals(txtMKCu.Text))
        {
            h3TB.InnerText = "Mật khẩu cũ không đúng";
            return;
        }
        Employee em = new Employee()
        {
            Username = this.NhanVien.Username,
            FirstName = txtTen.Text,
            LastName = txtHo.Text,
            Password = txtMKMoi.Text
        };
        Employee.CapNhatTheoUsername(em);
        h3TB.InnerText = "Đã cập nhật tài khoản";
    }
}