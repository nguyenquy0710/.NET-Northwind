using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class BH4_TinhDTTG : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnTinhDT_Click(object sender, EventArgs e)
    {
        //tao object & khoi tao cac gia tri
        TamGiac t = new TamGiac()
        {
            CanhA = double.Parse(txtCanhA.Text),
            CanhB = double.Parse(txtCanhB.Text),
            CanhC = double.Parse(txtCanhC.Text),
        };
        if (!t.LaTamGiac)
            lblKQ.Text = "Khong la tam giac";
        else
            lblKQ.Text=string.Format("Dien tich = {0}",t.DienTich);
    }
}