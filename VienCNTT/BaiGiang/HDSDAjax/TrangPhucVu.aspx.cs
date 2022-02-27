using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class HDSDAjax_TrangPhucVu : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //load ten san pham:
        using (DBDataContext dc = new DBDataContext())
        {
            rptSP.DataSource = dc.Products.ToList();
            rptSP.DataBind();
        }
    }
}