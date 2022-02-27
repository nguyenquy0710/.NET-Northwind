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

    public string CauChao
    {
        set
        {
            lblChao.Text = value;
        }
    }
    public string DuongDanHinh
    {
        set
        {
            imgKH.ImageUrl = value;
        }
    }
    //thuoc tinh xac dinh chi so cua view se hien thi:
    //chi so view tinh tu 0.
    public int ChiSoView
    {
        set
        {
            mtvDN.ActiveViewIndex = value;
        }
    }

    public event EventHandler evtDangNhap, evtDangXuat, evtDangKy;
    void OnDangKy()
    {
        if (evtDangKy != null) evtDangKy(null, null);
    }
    void OnDangXuat()
    {
        if (evtDangXuat != null) evtDangXuat(this, null);
    }
    void OnDangNhap()
    {
        if (evtDangNhap != null) evtDangNhap(this, null);
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
    protected void lbntDK_Click(object sender, EventArgs e)
    {
        OnDangKy();
    }
}