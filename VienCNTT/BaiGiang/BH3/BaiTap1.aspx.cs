using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class BH3_BaiTap1 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnChao_Click(object sender, EventArgs e)
    {
        lblChao.Text = ChaoHoi();
    }
    string ChaoHoi()
    {
        try
        {
            int tuoi = int.Parse(txtTuoi.Text);
            if (tuoi < 0) throw new Exception();//chu dong nem 1 exception
            else if (tuoi <= 25) return "Chao em";
            else if (tuoi <= 40) return "Chao anh/chi";
            else if (tuoi <= 60) return "Chao co/bac";
            else return "Chao ong/ba";
        }
        catch
        {
            return "Tuoi khong hop le";
        }
    }
}