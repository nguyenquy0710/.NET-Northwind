using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class QLTruyCap : System.Web.UI.UserControl
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
}