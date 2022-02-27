using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class TimKiem : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void ibtnTK_Click(object sender, ImageClickEventArgs e)
    {
        string kq;
        if (MyUtility.TextBoxHopLe(txtTK, out kq))
        {
            Response.Redirect("/sanpham/tk/" + txtTK.Text);
        }
    }
}