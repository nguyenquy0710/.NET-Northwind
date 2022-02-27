using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class BH6_TaoControlDynamic : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Button btn = new Button();
        btn.Text = "Click me";
        //dang ky su kien:
        btn.Click += Btn_Click;
        frmTest.Controls.Add(btn);

    }

    private void Btn_Click(object sender, EventArgs e)
    {
        Response.Write("Button was clicked");
    }
}