using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class BG1 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        #region xuat du lieu ra browser
        //txtTest.Text = "Xin chao";//setter
        //Response.Write(txtTest.Text);//getter
        #endregion

    }
    protected void btnCL_Click(object sender, EventArgs e)
    {
        #region bien (variable) va kieu du lieu (data type)
        var so = int.Parse(txtTest.Text);
        if (so % 2 == 0)
            Response.Write("so chan");
        else
            Response.Write("so le");
        #endregion
    }
}