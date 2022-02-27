using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class ADO_LocSanPham : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!this.IsPostBack)
        {
            LoadDM();
            ddlDM_SelectedIndexChanged(null, null);
        }
    }
    void LoadDM()
    {
        string chuoiKN = @"Data Source=.;Initial Catalog=Northwind;Integrated Security=True";
        SqlConnection ketNoi = new SqlConnection(chuoiKN);
        ketNoi.Open();
        string query = @"select * from categories";
        SqlCommand cmd = new SqlCommand(query, ketNoi);
        ddlDM.DataSource = cmd.ExecuteReader();
        ddlDM.DataTextField = "CategoryName";
        ddlDM.DataValueField = "CategoryID";
        ddlDM.DataBind();
    }
    protected void ddlDM_SelectedIndexChanged(object sender, EventArgs e)
    {
        //lay ma danh muc:
        int maDM = int.Parse(ddlDM.SelectedValue);
        LoadHHTheoDM(maDM);
    }

    private void LoadHHTheoDM(int maDM)
    {
        string chuoiKN = @"Data Source=.;Initial Catalog=Northwind;Integrated Security=True";
        SqlConnection ketNoi = new SqlConnection(chuoiKN);
        ketNoi.Open();
        string query = @"select * from Products where CategoryID = @ma";
        SqlCommand cmd = new SqlCommand(query, ketNoi);
        cmd.Parameters.AddWithValue("@ma", maDM);
        grvSP.DataSource = cmd.ExecuteReader();
        grvSP.DataBind();
        ketNoi.Close();
    }
    private void LoadHHTheoTen(string ten)
    {
        string chuoiKN = @"Data Source=.;Initial Catalog=Northwind;Integrated Security=True";
        SqlConnection ketNoi = new SqlConnection(chuoiKN);
        ketNoi.Open();
        string query = @"select *
                        from Products
                        where ProductName like @ten";
        
        SqlCommand cmd = new SqlCommand(query, ketNoi);
        cmd.Parameters.AddWithValue("@ten", ten);
        grvSP.DataSource = cmd.ExecuteReader();
        grvSP.DataBind();
        ketNoi.Close();
    }
    protected void btnTim_Click(object sender, EventArgs e)
    {
        LoadHHTheoTen(txtTen.Text);
    }

    private void LoadHHTheoGia(double tu, double den)
    {
        string chuoiKN = @"Data Source=.;Initial Catalog=Northwind;Integrated Security=True";
        SqlConnection ketNoi = new SqlConnection(chuoiKN);
        ketNoi.Open();
        string query = @"select *
                        from Products
                        where UnitPrice between @tu and @den";

        SqlCommand cmd = new SqlCommand(query, ketNoi);
        cmd.Parameters.AddWithValue("@tu",tu);
        cmd.Parameters.AddWithValue("@den", den);
        grvSP.DataSource = cmd.ExecuteReader();
        grvSP.DataBind();
        ketNoi.Close();
    }
    protected void btnLoc_Click(object sender, EventArgs e)
    {
        var t = double.Parse(txtTu.Text);
        var d = double.Parse(txtDen.Text);
        LoadHHTheoGia(t, d);
    }
}