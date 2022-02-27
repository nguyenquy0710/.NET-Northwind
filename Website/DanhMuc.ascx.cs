using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class DanhMuc : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            loadDM();
        }
    }

    private void loadDM()
    {
        rptDM.DataSource = Category.DMCoSP;
        rptDM.DataBind();
    }
    protected void lbtnDM_Click(object sender, EventArgs e)
    {
        var maDM = (sender as LinkButton).CommandArgument;
        Response.Redirect("/sanpham/cat/" + maDM);
    }
}