using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class LINQ_LINQ2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            ThemDanhMuc();
            LoadDM();
        }
    }
    void LoadDM()
    {
        using (DBDataContext dc = new DBDataContext())
        {
            ddlDM.DataSource = dc.Categories;
            ddlDM.DataTextField = "CategoryName";
            ddlDM.DataValueField = "CategoryID";
            ddlDM.DataBind();
        }
    }
    protected void ddlDM_SelectedIndexChanged(object sender, EventArgs e)
    {
        var maDM = int.Parse(ddlDM.SelectedValue);
        using (DBDataContext dc = new DBDataContext())
        {
            grvSP.DataSource = dc.Products.Where(x => x.CategoryID.Equals(maDM));
            grvSP.DataBind();
        }
    }
    void ThemDanhMuc()
    {
        //using (DBDataContext dc = new DBDataContext())
        //{
        //    Category cat = new Category()
        //    {
        //        CategoryName = "danh muc moi",
        //        Description = "khong biet"
        //    };
        //    dc.Categories.InsertOnSubmit(cat);
        //    dc.SubmitChanges();
        //}
        Category cat = new Category()
        {
            CategoryName = "danh muc ABC",
            Description = "khong biet"
        };
        Category.Them(cat);
    }
}