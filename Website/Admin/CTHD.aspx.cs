using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

public partial class Admin_CTHD : TrangQuanTri
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if(!IsPostBack)
        {
            if (this.NhanVien.RoleID != 1)
                ThucThiQuyen();
        }
        if (this.RouteData.Values["id"] == null)
        {
            Response.Redirect("/admin/hoadon");
        }
        int ma = int.Parse(this.RouteData.Values["id"].ToString());

        h3TB.InnerText = ma.ToString();
    }
    private void ThucThiQuyen()
    {
        //lay cac nut, link tren frmContainer:
        //de hien thuc quyen cho chung.
        MasterPage master = this.Master as MasterPage;
        var frm = master.FindControl("frmContent") as HtmlForm;
        TrangQuanTri.ApDungPhanQuyen(frm, this.Quyen);
    }
}