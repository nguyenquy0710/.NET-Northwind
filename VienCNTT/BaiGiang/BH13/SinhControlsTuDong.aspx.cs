using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class BH13_SinhControlsTuDong : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Page_Init(object sender, EventArgs e)
    {
        for (int i = 1; i < 6; i++)
        {
            Button btn = new Button();
            btn.Text = "Button duoc sinh tu dong";
            btn.ID = "btn" + i;
            btn.Click += btn_Click;
            plhTest.Controls.Add(btn);
        }
    }
    
    void btn_Click(object sender, EventArgs e)
    {
        Button btn = sender as Button;
        Response.Write(btn.ID + " bi clicked");
    }
}