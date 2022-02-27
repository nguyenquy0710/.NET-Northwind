using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class HDSDAjax_SuDungTimer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void timTest_Tick(object sender, EventArgs e)
    {
        using (DBDataContext dc = new DBDataContext())
        {
            grvSP.DataSource = dc.spLaySPNgauNhien(10);
            grvSP.DataBind();
        }
    }
}