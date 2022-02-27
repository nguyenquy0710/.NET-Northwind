using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_DangNhap : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnDN_Click(object sender, EventArgs e)
    {
        var nv = Employee.Tim(txtTen.Text.Trim());
        if (nv == null)
        {
            h3TB.InnerText = "Sai tên đăng nhập";
            return;
        }
        if (!nv.Password.Equals(txtMK.Text))
        {
            h3TB.InnerText = "Sai mật khẩu";
            return;
        }
        //tam thoi:
        Session["nv"] = nv;
        if (Session["returnurl"] != null)
            Response.Redirect(Session["returnurl"].ToString());
        else
            Response.Redirect("TaiKhoan.aspx");
    }
}