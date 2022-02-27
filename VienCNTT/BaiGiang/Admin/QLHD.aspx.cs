using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_QLHD : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            PL.LoadHD2GV(grvHD);
        }
    }
    protected void grvHD_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        grvHD.PageIndex = e.NewPageIndex;
        //neu co ngay thang thi se loc theo ngay thang:
        DateTime tu, den;
        if (DateTime.TryParseExact(txtTu.Text, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out tu)
            &&
        DateTime.TryParseExact(txtDen.Text, "dd/MM/yyyy", null,
         System.Globalization.DateTimeStyles.None, out den))
        {
            PL.LoadHD2GV(grvHD, tu, den);
        }
        else
            PL.LoadHD2GV(grvHD);
    }
    protected void btnLoc_Click(object sender, EventArgs e)
    {
        DateTime tu, den;
        if (DateTime.TryParseExact(txtTu.Text, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out tu)
            &&
        DateTime.TryParseExact(txtDen.Text, "dd/MM/yyyy", null,
         System.Globalization.DateTimeStyles.None, out den))
        {
            PL.LoadHD2GV(grvHD, tu, den);
        }

    }
    protected void btnAll_Click(object sender, EventArgs e)
    {
        PL.LoadHD2GV(grvHD);
    }
    protected void lbtnMa_Click(object sender, EventArgs e)
    {
        var maHD = int.Parse((sender as LinkButton).CommandArgument);
        //lay chi tiet hoa don theo ma hoa don maHD:
        PL.LoadCTHD2GV(grvCT, maHD);
    }
}