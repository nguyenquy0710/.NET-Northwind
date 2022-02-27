using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class BH13_CacSuKienCuaPage : System.Web.UI.Page
{
    protected void Page_PreInit(object sender, EventArgs e)
    {
        Response.Write("Page_PreInit<br/>");
    }
    protected void Page_Init(object sender, EventArgs e)
    {
        Response.Write("Page_Init<br/>");

    }
    protected void Page_PreLoad(object sender, EventArgs e)
    {
        Response.Write("Page_PreLoad<br/>");

    }
    protected void Page_Load(object sender, EventArgs e)
    {
        Response.Write("Page_Load<br/>");

    }
    protected void Page_PreRender(object sender, EventArgs e)
    {
        Response.Write("Page_PreRender<br/>");

    }

    protected void btnClick_Click(object sender, EventArgs e)
    {
        Response.Write("btnClick_Click<br/>");
    }
}