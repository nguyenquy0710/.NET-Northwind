using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

public partial class ADO_CRUD : System.Web.UI.Page
{
    static string chuoiKN = @"Data Source=.;Initial Catalog=Northwind;Integrated Security=True";
    static SqlConnection ketNoi = new SqlConnection(chuoiKN);

    protected void Page_Load(object sender, EventArgs e)
    {
        h3TB.InnerText = string.Empty;
        if (!this.IsPostBack)
        {
            LoadDM();
        }
    }
    void LoadDM()
    {
        string query = @"select * from Categories";
        if (ketNoi.State == ConnectionState.Closed)
            ketNoi.Open();
        SqlCommand cmd = new SqlCommand(query, ketNoi);
        grvDM.DataSource = cmd.ExecuteReader();
        grvDM.DataBind();
        ketNoi.Close();
    }
    protected void btnChon_Click(object sender, EventArgs e)
    {
        //tim danh muc:
        var btn = sender as Button;
        int maDM = int.Parse(btn.CommandArgument);

        string query = @"select * from Categories 
                        where CategoryID = @dm";
        ketNoi.Open();
        SqlCommand cmd = new SqlCommand(query, ketNoi);
        cmd.Parameters.AddWithValue("@dm", maDM);
        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
        DataTable t = new DataTable();
        adapter.Fill(t);
        if (t.Rows.Count == 1)
        {
            h3Ma.InnerText = t.Rows[0]["CategoryID"].ToString();
            txtTen.Text = t.Rows[0]["CategoryName"].ToString();
            txtMoTa.Text = t.Rows[0]["Description"].ToString();
        }
        ketNoi.Close();
    }
    void ThemDM()
    {
        string query = @"insert into Categories
                        (
                            CategoryName
                            ,Description
                        )
                        values
                        (
                            @CategoryName
                            ,@Description
                        )";
        if (ketNoi.State == ConnectionState.Closed)
            ketNoi.Open();
        SqlCommand cmd = new SqlCommand(query, ketNoi);
        cmd.Parameters.AddWithValue("@CategoryName", txtTen.Text);
        cmd.Parameters.AddWithValue("@Description", txtMoTa.Text);
        var kq = cmd.ExecuteNonQuery();//thuc thi insert, update hoac delete (tra ve so dong bi tac dong)
        if (kq != 1)
        {
            h3TB.InnerText = "Lỗi thêm danh mục";
        }
        else
        {
            LoadDM();
        }
        ketNoi.Close();
    }
    protected void btnThem_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrEmpty(txtTen.Text))
        {
            h3TB.InnerText = "Tên danh mục là bắt buộc";
            return;
        }
        ThemDM();
    }
    void SuaDM()
    {
        string query = @"update Categories
                        set                         
                            CategoryName=@CategoryName
                            ,Description=@Description
                        where CategoryID = @CategoryID";

        if (ketNoi.State == ConnectionState.Closed)
            ketNoi.Open();
        SqlCommand cmd = new SqlCommand(query, ketNoi);
        cmd.Parameters.AddWithValue("@CategoryName", txtTen.Text);
        cmd.Parameters.AddWithValue("@Description", txtMoTa.Text);
        cmd.Parameters.AddWithValue("@CategoryID", h3Ma.InnerText);

        var kq = cmd.ExecuteNonQuery();//thuc thi insert, update hoac delete (tra ve so dong bi tac dong)
        if (kq != 1)
        {
            h3TB.InnerText = "Lỗi cập nhật danh mục";
        }
        else
        {
            LoadDM();
        }
        ketNoi.Close();
    }
    protected void btnCapNhat_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrEmpty(txtTen.Text))
        {
            h3TB.InnerText = "Tên danh mục là bắt buộc";
            return;
        }
        SuaDM();
    }
    protected void btnXoa_Click(object sender, EventArgs e)
    {
        var btn = sender as Button;
        int maDM = int.Parse(btn.CommandArgument);
        if (DemSP(maDM) > 0)
        {
            h3TB.InnerText = "Không thể xoa danh mục này, vì có sản phẩm";
            return;
        }
        XoaDM(maDM);
    }
    void XoaDM(int maDM)
    {
        string query = @"delete from Categories
                        where CategoryID = @CategoryID";

        if (ketNoi.State == ConnectionState.Closed)
            ketNoi.Open();
        SqlCommand cmd = new SqlCommand(query, ketNoi);
        
        cmd.Parameters.AddWithValue("@CategoryID", maDM);

        var kq = cmd.ExecuteNonQuery();//thuc thi insert, update hoac delete (tra ve so dong bi tac dong)
        if (kq != 1)
        {
            h3TB.InnerText = "Lỗi xóa danh mục";
        }
        else
        {
            LoadDM();
        }
        ketNoi.Close();
    }

    int DemSP(int maDM)
    {
        string query = @"select count(*) from Categories
                        where CategoryID = @CategoryID";

        if (ketNoi.State == ConnectionState.Closed)
            ketNoi.Open();
        SqlCommand cmd = new SqlCommand(query, ketNoi);

        cmd.Parameters.AddWithValue("@CategoryID", maDM);

        var kq = int.Parse(cmd.ExecuteScalar().ToString());
        ketNoi.Close();
        return kq;
    }
}
