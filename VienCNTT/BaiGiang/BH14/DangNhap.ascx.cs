using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class BH14_DangNhap : System.Web.UI.UserControl
{
    public string TenDN
    {
        get
        {
            return txtTenDN.Text;
        }
        set
        {
            txtTenDN.Text = value;
        }
    }
    public string MatKhau
    {
        get
        {
            return txtMK.Text;
        }
        set
        {
            txtMK.Text = value;
        }
    }
    public string ThongBao
    {
        get
        {
            return lblTB.Text;
        }
        set
        {
            lblTB.Text = value;
        }
    }
    public bool GhiNho
    {
        set
        {
            chkGN.Checked = value;
        }
        get
        {
            return chkGN.Checked;
        }
    }
    public event EventHandler DangNhap;
    void OnDangNhap()
    {
        if (DangNhap != null) DangNhap(this, null);
    }
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnDN_Click(object sender, EventArgs e)
    {
        OnDangNhap();
    }
}