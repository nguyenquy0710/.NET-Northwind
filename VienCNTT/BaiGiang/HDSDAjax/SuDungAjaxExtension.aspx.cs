using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class HDSDAjax_SuDungAjaxExtension : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        h2Time.InnerText = DateTime.Now.ToString();
        h2Ngoai.InnerText = DateTime.Now.ToString();
        h22.InnerText = DateTime.Now.ToString();
    }
    protected void btnLoad_Click(object sender, EventArgs e)
    {

    }
}