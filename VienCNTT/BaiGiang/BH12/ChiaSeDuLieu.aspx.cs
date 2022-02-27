using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class BH12_ChiaSeDuLieu : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void lbtnApp_Click(object sender, EventArgs e)
    {
        //tao bien application:
        Application["bien"] = "day la bien toan cuc";
        Response.Redirect("TrangDich.aspx");
    }
    protected void lbtnSession_Click(object sender, EventArgs e)
    {
        Session["bienSession"] = "bien nay ton tai trong 1 phien giao dich";
        Response.Redirect("TrangDich.aspx");
    }
}