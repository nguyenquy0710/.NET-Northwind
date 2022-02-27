using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class BH14_SuDungUserControl : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        ucTest.NoiDung = "tao lao";
        ucTest.NutDuocClick += XuLy;
        ////tim textbox nam tren usercontrol:
        //TextBox txt = ucTest.FindControl("txtND") as TextBox;
        //txt.Text = "Noi dung nay duoc gan tu ben ngoai";
        ////tim button:
        //Button btn = ucTest.FindControl("btnClick") as Button;
        //btn.Click += btn_Click;
    }
    protected void XuLy(object sender, EventArgs e)
    {
        Response.Write("asdfsdf");

    }
    //void btn_Click(object sender, EventArgs e)
    //{
    //    Response.Write("asdfsdf");
    //}
    //dung o ben ngoai muon lam viec voi cac phan tu thuoc user control thi co 2 cach:
    //cach1 (it duoc su dung): su dung phuong thuc FindControl("id????")
    //cach 2: truyen du lieu thong qua cac thuoc tinh
    //va su kien cua chinh user control do!
    protected void Page_PreLoad(object sender, EventArgs e)
    {
        ucDangNhap.GhiNho = true;
        ucDangNhap.DangNhap += ucDangNhap_DangNhap;
    }

    void ucDangNhap_DangNhap(object sender, EventArgs e)
    {
        if (!ucDangNhap.TenDN.Equals("gtvt"))
        {
            ucDangNhap.ThongBao = "Sai ten dang nhap";
            return;
        }
        if (!ucDangNhap.MatKhau.Equals("123"))
        {
            ucDangNhap.ThongBao = "Sai mat khau";
            return;
        }
        ucDangNhap.ThongBao = "Dang nhap thanh cong";
    }
}