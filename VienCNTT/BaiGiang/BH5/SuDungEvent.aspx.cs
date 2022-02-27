using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class BH5_SuDungEvent : System.Web.UI.Page
{
    //tao event tren delegate co san cua .net:
    private event EventHandler TestSuKien;

    protected void Page_Load(object sender, EventArgs e)
    {
        //nap method (dong 19) => event:
        TestSuKien += BH5_SuDungEvent_TestSuKien;//dang ky
        TestSuKien(null, null);//phat sinh

        //dang ky su kien cho button test event:
        this.btnTest.Click += btnTest_Click;
    }

    void btnTest_Click(object sender, EventArgs e)
    {
        Response.Write("Click cai gi the");
    }

    void BH5_SuDungEvent_TestSuKien(object sender, EventArgs e)
    {//ham dap ung su kien
        Response.Write("Su kien TestSuKien da duoc phat sinh");
    }
}