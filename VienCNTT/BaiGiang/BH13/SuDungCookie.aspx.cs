using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class BH13_SuDungCookie : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!this.IsPostBack)
        {
            chkGN.Checked = true;
        }
        //doc cookie neu co:
        HttpCookie ckDoc = Request.Cookies["TenDN"];
        if (ckDoc != null)
        {
            txtTenDN.Text = ckDoc.Value;
        }
    }
    protected void btnDN_Click(object sender, EventArgs e)
    {
        if (chkGN.Checked)
        {//tao cookie:
            HttpCookie ckTen = new HttpCookie("TenDN");
            ckTen.Value = txtTenDN.Text;
            ckTen.Expires = DateTime.Now.AddDays(2);
            Response.Cookies.Add(ckTen);
        }
        else
        {//huy cookie (neu co)
            HttpCookie ckDoc = Request.Cookies["TenDN"];
            if (ckDoc != null)
            {
                ckDoc.Expires = DateTime.Today.AddDays(-1);
                Response.Cookies.Add(ckDoc);
            }
        }
    }
}