using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class BH12_AppKhacSession : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!this.IsPostBack)
        {
            //Session["test"] = 1;
            //lblGT.Text = Session["test"].ToString();
            if (Application["test"] == null)Application["test"] = 1;
            lblGT.Text = Application["test"].ToString();
        }
    }
    protected void btnTang_Click(object sender, EventArgs e)
    {
        //Session["test"] = int.Parse(Session["test"].ToString()) + 2;
        //lblGT.Text = Session["test"].ToString();
        Application["test"] = int.Parse(Application["test"].ToString()) + 2;
        lblGT.Text = Application["test"].ToString();
    }
}