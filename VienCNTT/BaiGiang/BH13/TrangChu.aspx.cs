using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class BH13_TrangChu : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //thao tac voi lblTest dang nam tren masterpage:
        //b1: tim master page tuong ung voi trang content:
        MasterPage mtp = this.Master as MasterPage;
        //b2: findcontrol thuoc master o buoc 1:
        Label lbl = mtp.FindControl("lblTest") as Label;
        lbl.Text = "Noi dung nay duoc gan tu trang content";
    }
}