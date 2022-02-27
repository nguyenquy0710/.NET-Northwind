using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ADO_TinhTienKH : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!this.IsPostBack)
        {
            LoadKH();
            ddlKH_SelectedIndexChanged(null, null);
        }
    }
    void LoadKH()
    {
        string chuoiKN = @"Data Source=.;Initial Catalog=Northwind;Integrated Security=True";
        SqlConnection ketNoi = new SqlConnection(chuoiKN);
        ketNoi.Open();
        string query = @"select * from Customers";
        SqlCommand cmd = new SqlCommand(query, ketNoi);
        ddlKH.DataSource = cmd.ExecuteReader();
        ddlKH.DataTextField = "CompanyName";
        ddlKH.DataValueField = "CustomerID";

        ddlKH.DataBind();
        ketNoi.Close();
    }
    protected void ddlKH_SelectedIndexChanged(object sender, EventArgs e)
    {
        string maKH = ddlKH.SelectedValue;
        h3TT.InnerText = TongTien(maKH).ToString();
        LoadDSHD(maKH);
    }
    double TongTien(string maKH)
    {
        string chuoiKN = @"Data Source=.;Initial Catalog=Northwind;Integrated Security=True";
        SqlConnection ketNoi = new SqlConnection(chuoiKN);
        ketNoi.Open();
        string query = @"
            select sum(UnitPrice*Quantity)
            from [Order Details]
            where OrderID in (
	            select OrderID
	            from Orders
	            where CustomerID like @ma
            )
        ";
        SqlCommand cmd = new SqlCommand(query, ketNoi);
        cmd.Parameters.AddWithValue("@ma", maKH);
        var kq = cmd.ExecuteScalar();
        return double.Parse(kq.ToString());
    }

    void LoadDSHD(string maKH)
    {
        string chuoiKN = @"Data Source=.;Initial Catalog=Northwind;Integrated Security=True";
        SqlConnection ketNoi = new SqlConnection(chuoiKN);
        ketNoi.Open();
        string query = @"
            select 
            OrderID
            ,CustomerID
            ,E.EmployeeID
            ,E.FirstName
            from Orders O
            inner join Employees E
            on O.EmployeeID = E.EmployeeID
            where CustomerID like @ma
        ";
        SqlCommand cmd = new SqlCommand(query, ketNoi);
        cmd.Parameters.AddWithValue("@ma", maKH);
        grvHD.DataSource = cmd.ExecuteReader();
        grvHD.DataBind();
        //lay du lieu vao cot tong tien:
        foreach (GridViewRow r in grvHD.Rows)
        {
            Label lbl = r.FindControl("lblTT") as Label;
            var maHD = int.Parse(r.Cells[1].Text);
            lbl.Text = TongTien(maHD).ToString();
        }
    }


    double TongTien(int maHD)
    {
        string chuoiKN = @"Data Source=.;Initial Catalog=Northwind;Integrated Security=True";
        SqlConnection ketNoi = new SqlConnection(chuoiKN);
        ketNoi.Open();
        string query = @"
            select sum(UnitPrice*Quantity)
            from [Order Details]
            where OrderID = @ma
        ";
        SqlCommand cmd = new SqlCommand(query, ketNoi);
        cmd.Parameters.AddWithValue("@ma", maHD);
        var kq = cmd.ExecuteScalar();
        return double.Parse(kq.ToString());
    }
}