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
        
    }
    protected void lbtnQLDM_Click(object sender, EventArgs e)
    {
        Response.Redirect("QLDM.aspx");
    }
    protected void lbtnQLSP_Click(object sender, EventArgs e)
    {
        Response.Redirect("QLHH.aspx");

    }
    protected void lbtnDX_Click(object sender, EventArgs e)
    {
        Session.Remove("nv");
        Response.Redirect("DangNhap.aspx");
    }
    protected void lbtnTK_Click(object sender, EventArgs e)
    {
        Response.Redirect("TaiKhoan.aspx");
    }
}
