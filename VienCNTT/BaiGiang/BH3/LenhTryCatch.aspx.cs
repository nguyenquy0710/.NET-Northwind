using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class BH3_LenhTryCatch : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnGiai_Click(object sender, EventArgs e)
    {
        GiaiPT();
    }
    void GiaiPT()
    {
        double a, b, c;
        try
        {
            a = double.Parse(txtHSA.Text);
            b = double.Parse(txtHSB.Text);
            c = double.Parse(txtHSC.Text);
            double d = Math.Pow(b, 2) - 4 * a * c;
            if (d < 0) lblNghiem.Text = "PT vo nghiem";
            else
            {
                double x1 = (-b - Math.Sqrt(d)) / (2 * a);
                x1 = Math.Round(x1, 2);//2 chu so thap phan.
                double x2 = (-b + Math.Sqrt(d)) / (2 * a);
                x2 = Math.Round(x2, 2);
                lblNghiem.Text = "Nghiem 1 = " + x1
                    + ", Nghiem 2 = " + x2;
            }
        }
        catch
        {
            lblNghiem.Text = "Du lieu khong hop le";
        }
    }
}