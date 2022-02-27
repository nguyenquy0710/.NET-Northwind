using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ADO_TestDAL : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            //ThemDanhMuc();
            //SuaDanhMuc();
            //XoaDanhMuc();
            DemSoSanPham();
            LoadDanhMuc();
        }
    }
    void LoadSanPham()
    {
        int maDM = int.Parse(ddlDM.SelectedValue);
        double tu = double.Parse(txtTu.Text);
        double den = double.Parse(txtDen.Text);
        string query = @"select * from Products where CategoryID = @cat
and UnitPrice between @tu and @den";
        grvTest.DataSource = DAL.DocTable(query, "@cat", maDM, "@tu", tu, "@den", den);
        grvTest.DataBind();
    }
    protected void btnTim_Click(object sender, EventArgs e)
    {
        LoadSanPham();
    }
    void LoadDanhMuc()
    {
        string query = @"select * from Categories";
        ddlDM.DataSource = DAL.DocTable(query);
        ddlDM.DataTextField = "CategoryName";
        ddlDM.DataValueField = "CategoryID";
        ddlDM.DataBind();
    }
    void ThemDanhMuc()
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
        var kq = DAL.ExecuteNonQuery(query, "@CategoryName", "Danh muc nao do", "@Description", "khong mo ta gi ca");
    }
    void SuaDanhMuc()
    {
        string query = @"update Categories
                        set
                            CategoryName =@CategoryName
                            ,Description =@Description
                        where CategoryID=@CategoryID";

        var kq = DAL.ExecuteNonQuery(query, "@CategoryName", "Danh muc ABC", "@Description", "asdfksalf", "@CategoryID",2009);
    }
    void XoaDanhMuc()
    {
        string query = @"delete from Categories
                        where CategoryID=@CategoryID";

        var kq = DAL.ExecuteNonQuery(query,"@CategoryID", 2009);
    }
    void DemSoSanPham()
    {
        string query = @"select count(*)
                        from Products
                        where CategoryID=@CategoryID";

        var kq = DAL.ExecuteScalar(query, "@CategoryID", 8);
        Response.Write(kq);
    }
}