using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ThongTinGioHang : System.Web.UI.UserControl
{
    public double TongTien
    {
        set
        {
            lblTT.Text = value.ToString();
        }
    }
    public int SoMatHang
    {
        set
        {
            lblSMH.Text = value.ToString();
        }
    }
    public event EventHandler evtXemChiTiet;
    private void OnXemChiTiet()
    {
        if (evtXemChiTiet != null) evtXemChiTiet(this, null);
    }
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void lbtnCT_Click(object sender, EventArgs e)
    {
        OnXemChiTiet();
    }
}