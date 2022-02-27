using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


public partial class FrontEnd : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            ThongKe();
        }
    }

    private void ThongKe()
    {
        if (Application["online"] != null)
        {
            spnOnline.InnerText = Application["online"].ToString();
        }
        if (Application["sum"] != null)
        {
            spnSum.InnerText = Application["sum"].ToString();
        }
    }
    protected void Page_PreRender(object sender, EventArgs e)
    {
        LoadTTKH();
        LoadTTGH();
    }
    protected void Page_Init(object sender, EventArgs e)
    {
        //dang ky su kien cho user control:
        ucDangNhap.evtDangNhap += ucDangNhap_evtDangNhap;
        ucDangNhap.evtDangXuat += ucDangNhap_evtDangXuat;
        ucThongTinGH.XemChiTiet += ucThongTinGH_XemChiTiet;
    }

    void ucThongTinGH_XemChiTiet(object sender, EventArgs e)
    {
        Response.Redirect("/gio");
    }

    void ucDangNhap_evtDangXuat(object sender, EventArgs e)
    {
        Session.Remove("kh");
    }

    void ucDangNhap_evtDangNhap(object sender, EventArgs e)
    {
        var k = Customer.Tim(ucDangNhap.TenDN, new DBDataContext());
        if (k == null)
        {
            ucDangNhap.ThongBao = "Sai tên đăng nhập";
            return;
        }
        if (!k.Password.Equals(ucDangNhap.MatKhau.ToMD5()))
        {
            ucDangNhap.ThongBao = "Sai mật khẩu";
            return;
        }

        if (k.Status == null || !(bool)k.Status)
        {
            ucDangNhap.ThongBao = "Tài khoản chưa được kích hoạt, hãy kiểm tra email.";
            return;
        }
        //luu thong tin khach hang da dang nhap:
        Session["kh"] = k;
    }
    void LoadTTKH()
    {
        if (Session["kh"] != null)
        {
            ucDangNhap.ChiSoView = 1;
            var k = Session["kh"] as Customer;
            ucDangNhap.CauChao = "Xin chào " + k.CompanyName;
            ucDangNhap.DuongDanHinh = string.Empty;
        }
        else
        {
            ucDangNhap.ChiSoView = 0;
        }
    }
    void LoadTTGH()
    {
        Gio g = Session["gh"] as Gio;
        ucThongTinGH.TongTien = g.TongTien;
        ucThongTinGH.SoMatHang = g.SoMatHang;
    }
    protected void ucDangNhap_evtDangKy(object sender, EventArgs e)
    {
        Response.Redirect("/dangky");
    }
}
