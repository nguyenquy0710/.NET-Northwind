using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        localhost.wsTimSP ws = new localhost.wsTimSP();
        Response.Write(ws.TimHH(1));
        grvHH.DataSource = ws.LayHHTheoLoai(8);
        grvHH.DataBind();
    }
}