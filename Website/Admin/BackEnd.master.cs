using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_BackEnd : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            //if (Session["nv"] == null)
            //    Response.Redirect("~/admin/dangnhap");
        }
    }
    protected void lbtnTaiKhoan_Click(object sender, EventArgs e)
    {
        Response.Redirect("/admin/taikhoan");
    }
    protected void lbtnDangXuat_Click(object sender, EventArgs e)
    {
        Session.Remove("nv");
        Response.Redirect("/admin/dangnhap");
    }
    protected void lbtnView_Click(object sender, EventArgs e)
    {
        Response.Redirect("~");
    }
    protected void ibtnSearch_Click(object sender, ImageClickEventArgs e)
    {
        string key;
        if(MyUtility.TextBoxHopLe(txtSeach, out key))
        {
            Response.Redirect("/admin/search/" + txtSeach.Text);
        }
        else
        {
            Response.Redirect("/admin/sanpham");
        }
    }
}
