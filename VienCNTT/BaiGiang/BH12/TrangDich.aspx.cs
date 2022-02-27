using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class BH12_TrangDich : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //lay du lieu duoc truyen bang transfer tu trang CacDTCoBan:
        if (!this.IsPostBack)
        {
            if (Request.Form["txtDuLieu"] != null)
                Response.Write(Request.Form["txtDuLieu"].ToString());
            else Response.Write("Khong co du lieu");
            if (Request.QueryString["name"] != null)
                Response.Write(Request.QueryString["name"]);
            //truy xuat den biet application:
            if (Application["bien"] != null)
                Response.Write("gia tri bien app = " +
                    Application["bien"]);
            //truy xuat bien session:
            if (Session["bienSession"] != null)
                Response.Write("gia tri bien session = " + Session["bienSession"]);
        }
    }
}