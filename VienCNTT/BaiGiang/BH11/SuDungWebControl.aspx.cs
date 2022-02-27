using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class BH11_SuDungWebControl : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //chi load du lieu khi load trang lan dau tien:
        if (!this.IsPostBack)
        {
            //loadDSNgoaiNgu();
            loadDSNgoaiNguNew();
        }
    }

    private void loadDSNgoaiNguNew()
    {
        //bind => consumer:
        lstNgoaiNgu.DataSource = NgoaiNgu.DSNN;
        lstNgoaiNgu.DataTextField = "Ten";
        lstNgoaiNgu.DataValueField = "Ma";
        lstNgoaiNgu.DataBind();

        ddlNgoaiNgu.DataSource = NgoaiNgu.DSNN;
        ddlNgoaiNgu.DataTextField = "Ten";
        ddlNgoaiNgu.DataValueField = "Ma";
        ddlNgoaiNgu.DataBind();

        //load to gridview:
        grvNN.DataSource = NgoaiNgu.DSNN;
        grvNN.DataBind();
        //load to repeater:
        rptNN.DataSource = NgoaiNgu.DSNN;
        rptNN.DataBind();
    }

    private void loadDSNgoaiNgu()
    {
        //tao provider chua du lieu:
        List<ListItem> duLieu = new List<ListItem>();
        duLieu.Add(new ListItem()
        {
            Text = "Tieng Anh",
            Value = "1",
            Selected = true
        });
        duLieu.Add(new ListItem()
        {
            Text = "Tieng Trung",
            Value = "2",
        });

        duLieu.Add(new ListItem()
        {
            Text = "Tieng Phap",
            Value = "3",
        });
        //bind provider => consumer:
        //load to listbox:
        lstNgoaiNgu.DataSource = duLieu;
        lstNgoaiNgu.DataTextField = "Text";
        lstNgoaiNgu.DataValueField = "Value";
        lstNgoaiNgu.DataBind();
        lstNgoaiNgu.Items[2].Selected = true;
        //load to dropdownlist:
        ddlNgoaiNgu.DataSource = duLieu;
        ddlNgoaiNgu.DataTextField = "Text";
        ddlNgoaiNgu.DataValueField = "Value";
        ddlNgoaiNgu.DataBind();
        //load to checkboxlist:
        chkNN.DataSource = duLieu;
        chkNN.DataTextField = "Text";
        chkNN.DataValueField = "Value";
        chkNN.DataBind();
        //load to radiobuttonlist:
        rblNN.DataSource = duLieu;
        rblNN.DataTextField = "Text";
        rblNN.DataValueField = "Value";
        rblNN.DataBind();
    }

    protected void lstNgoaiNgu_SelectedIndexChanged(object sender, EventArgs e)
    {
        lblKQ.Text = lstNgoaiNgu.SelectedItem.Text;
    }
    protected void ddlNgoaiNgu_SelectedIndexChanged(object sender, EventArgs e)
    {
        lblKQ.Text = ddlNgoaiNgu.SelectedItem.Text;
    }
    protected void btnPB_Click(object sender, EventArgs e)
    {
        var kq = string.Empty;
        foreach (ListItem i in chkNN.Items)
            if (i.Selected) kq += i.Text + " ";
        lblKQ.Text = kq;
    }
    protected void rblNN_SelectedIndexChanged(object sender, EventArgs e)
    {
        lblKQ.Text = rblNN.SelectedItem.Value;
    }
    protected void btnXoa_Click(object sender, EventArgs e)
    {
        //sender la button ma nguoi dung click
        //lay button duoc click:
        Button tam = sender as Button;
        int ma = int.Parse(tam.CommandArgument);
        Response.Write(ma);
    }
}