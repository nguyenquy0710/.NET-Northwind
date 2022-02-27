using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class BH3_BaiTap2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnGiai_Click(object sender, EventArgs e)
    {
        PhuongTrinhBH pt = new PhuongTrinhBH();
        pt.HeSoA = double.Parse(txtHSA.Text);
        pt.HeSoB = double.Parse(txtHSB.Text);
        pt.HeSoC = double.Parse(txtHSC.Text);
        Nghiem n = pt.Giai();
        if (n == null)
            lblNghiem.Text = "vo nghiem";
        else
            lblNghiem.Text = n.ToString();
    }
}
