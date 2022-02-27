using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ThongBao : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.QueryString["kh"] != null)
        {
            var q = Request.QueryString["kh"];
            Customer.KichHoatTK(q, true);
        }
    }
}