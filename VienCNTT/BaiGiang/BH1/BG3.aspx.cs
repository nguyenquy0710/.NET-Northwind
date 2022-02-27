using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class BG3 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnTimSN_Click(object sender, EventArgs e)
    {
        //xem user chon thang may?
        int t = int.Parse(ddlThang.SelectedItem.Text);
        int sn = 0, nam;

        switch (t)
        {
            case 1:
            case 3:
            case 5:
            case 7:
            case 8:
            case 10:
            case 12: sn = 31; break;
            case 4:
            case 6:
            case 9:
            case 11: sn = 30; break;
            case 2:
                nam = int.Parse(txtNam.Text);
                if (nam % 4 == 0) sn = 29;
                else sn = 28;
                break;
        }
        lblSN.Text = "Tong so ngay la: " + sn;
    }
}