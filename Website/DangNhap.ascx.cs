using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class DangNhap : System.Web.UI.UserControl
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
    }
    public bool GhiNhoTK
    {
        get
        {
            return chkGN.Checked;
        }
        set
        {
            chkGN.Checked = value;
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
    public string Chao
    {
        set
        {
            lblChao.Text = value;
        }
    }
    public event EventHandler evtDangNhap, evtDangXuat,evtDangKy;
    private void OnDangNhap()
    {
        if (evtDangNhap != null) evtDangNhap(this, null);
    }
    public void OnDangXuat()
    {
        if (evtDangXuat != null) evtDangXuat(this, null);
    }
    public void OnDangKy()
    {
        if (evtDangKy != null) evtDangKy(null, null);
    }
    public int ChiSoView
    {
        set
        {
            mtvDN.ActiveViewIndex = value;
        }
    }
    public string DuongDanHinh
    {
        set
        {
            imgKH.ImageUrl = value;
        }
    }
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnDN_Click(object sender, EventArgs e)
    {
        OnDangNhap();
    }
    protected void lbtnDX_Click(object sender, EventArgs e)
    {
        OnDangXuat();
    }
    protected void lbtnDK_Click(object sender, EventArgs e)
    {
        OnDangKy();
    }
}