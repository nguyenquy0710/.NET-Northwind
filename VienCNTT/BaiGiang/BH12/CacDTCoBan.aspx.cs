using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class BH12_CacDTCoBan : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!this.IsPostBack)
        {
            SuDungDoiTuongRequest();
        }
    }

    private void SuDungDoiTuongRequest()
    {
        //su dung duong dan:
        lblURL.Text = "URL hien tai la: " + Request.Url;
        lblRawURL.Text = "Raw URL hien tai la: " + Request.RawUrl;
        //su dung query string:
        if (Request.QueryString["id"] == null)
            lblQS.Text = "QS id khong ton tai";
        else
            lblQS.Text = Request.QueryString["id"].ToString();
    }
    protected void btnTF_Click(object sender, EventArgs e)
    {
        //dieu huong bang transfer cua doi tuong server:
        //chu y: transfer van bao luu request hien tai (khong tao request moi).
        Server.Transfer("TrangDich.aspx");
    }
    protected void btnRedirect_Click(object sender, EventArgs e)
    {
        //chu y: redirect tao request moi => request.form khong co du lieu.
        //thay the bang cach su dung query string.

        Response.Redirect("TrangDich.aspx?name="+txtDuLieu.Text);
    }
}