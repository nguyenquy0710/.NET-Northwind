using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

public partial class ADO_DocDuLieu : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            //DocBangReader();
            //DocBangAdapter();
            DocBangCommand();
        }
    }
    void DocBangReader()
    {
        string chuoiKN = @"Data Source=.;Initial Catalog=Northwind;Integrated Security=True";
        SqlConnection ketNoi = new SqlConnection(chuoiKN);
        try
        {
            ketNoi.Open();
            //doc du lieu:
            SqlDataReader reader = null;
            SqlCommand cmd = new SqlCommand("select * from Products", ketNoi);
            reader = cmd.ExecuteReader();
            
            while (reader.Read())
            {
                Response.Write("asdfasd");
                Response.Write(reader.GetString(1)+"<br/>");
            }
        }
        catch
        {
            Response.Write("ket noi that bai");
        }
        finally
        {
            ketNoi.Close();
        }   
    }
    void DocBangAdapter()
    {
        string chuoiKN = @"Data Source=.;Initial Catalog=Northwind;Integrated Security=True";
        SqlConnection ketNoi = new SqlConnection(chuoiKN);
        try
        {
            ketNoi.Open();
            //doc du lieu:
            string query = @"select * from Categories";
            SqlCommand cmd = new SqlCommand(query,ketNoi);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable tb = new DataTable();
            adapter.Fill(tb);
            grvHH.DataSource = tb;
            grvHH.DataBind();
        }
        catch
        {
            Response.Write("ket noi that bai");
        }
        finally
        {
            ketNoi.Close();
        }   
    }
    void DocBangCommand()
    {
        string chuoiKN = @"Data Source=.;Initial Catalog=Northwind;Integrated Security=True";
        SqlConnection ketNoi = new SqlConnection(chuoiKN);
        try
        {
            ketNoi.Open();
            //doc du lieu:
            string query = @"select * from Categories";
            SqlCommand cmd = new SqlCommand(query, ketNoi);
            grvHH.DataSource = cmd.ExecuteReader();
            grvHH.DataBind();
        }
        catch
        {
            Response.Write("ket noi that bai");
        }
        finally
        {
            ketNoi.Close();
        }
    }
}