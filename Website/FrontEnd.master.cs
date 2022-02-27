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

    }


    protected void Page_Init(object sender, EventArgs e)
    {
        ucDangNhap.evtDangNhap += ucDangNhap_evtDangNhap;
        ucDangNhap.evtDangXuat += ucDangNhap_evtDangXuat;
        ucThongTinGioHang.evtXemChiTiet += ucThongTinGioHang_evtXemChiTiet;
    }

    void ucThongTinGioHang_evtXemChiTiet(object sender, EventArgs e)
    {
        Response.Redirect("/gio");
    }
    protected void Page_PreRender(object sender, EventArgs e)
    {
        LoadTTKH();
        LoadTTGH();
    }
    void ucDangNhap_evtDangXuat(object sender, EventArgs e)
    {
        Session.Remove("kh");
    }

    private void ucDangNhap_evtDangNhap(object sender, EventArgs e)
    {
        var k = Customer.Tim(ucDangNhap.TenDN, new DBDataContext());
        if (k == null)
        {
            ucDangNhap.ThongBao = "<br />Sai tên đăng nhập.";
            return;
        }
        if (!k.Password.Equals(ucDangNhap.MatKhau.ToMD5()))
        {
            ucDangNhap.ThongBao = "<br />Sai mật khẩu.";
            return;
        }
        if (k.Status == null || !(bool)k.Status)
        {
            ucDangNhap.ThongBao = "Tài khoản chưa được kích hoạt, hãy kiểm ra lại email của bạn !";
            return;
        }
        Session["kh"] = k; //luu thong tin khach hang da dang nhap
        //ghi nho tai khoan:
        if (ucDangNhap.GhiNhoTK)
        {
            HttpCookie ckTenDN = new HttpCookie("TenDN");
            ckTenDN.Value = ucDangNhap.TenDN;
            ckTenDN.Expires = DateTime.Now.AddMonths(2);
            Response.Cookies.Add(ckTenDN);
        }
        else
        {
            HttpCookie ck = Request.Cookies["TenDN"];
            if (ck != null)
            {
                ck.Expires = DateTime.Now.AddMonths(-2);
                Response.Cookies.Add(ck);
            }
        }
    }
    void LoadTTKH()
    {
        if (Session["kh"] != null)
        {
            ucDangNhap.ChiSoView = 1;
            var k = Session["kh"] as Customer;
            ucDangNhap.Chao = "Xin chào: " + k.CompanyName;
            //ucDangNhap.DuongDanHinh = k.DuongDanHinh;
            ucDangNhap.DuongDanHinh = string.Empty;
        }
        else
        {
            ucDangNhap.ChiSoView = 0;
            //load cookie(neu co)
            HttpCookie ck = Request.Cookies["TenDN"];
            if (ck != null)
            {
                ucDangNhap.TenDN = ck.Value;
            }
        }
    }
    void LoadTTGH()
    {
        Gio g = Session["gh"] as Gio;
        ucThongTinGioHang.TongTien = g.TongTien;
        ucThongTinGioHang.SoMatHang = g.SoMatHang;
    }
    protected void ucDangNhap_evtDangKy(object sender, EventArgs e)
    {
        Response.Redirect("/dangky");
    }
}
