using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class SuDungDVW_Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        localhost.wsTimSP ws = new localhost.wsTimSP();
        //Response.Write(ws.TinhTong(10));
        //Response.Write(ws.TimSP(1));
    }
}