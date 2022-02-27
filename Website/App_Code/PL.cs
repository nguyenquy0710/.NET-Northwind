using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

/// <summary>
/// Summary description for PL
/// </summary>
public class PL //tang trinh vien
{
    public static void LoadDMToGridView(GridView grv)
    {
        grv.DataSource = Category.DSDM;
        grv.DataBind();
    }
    public static void LoadDM2DDL(DropDownList ddl, bool tatCa = false)
    {
        var ds = Category.DSDM;
        //neu co muc tat ca
        if (tatCa)
        {
            ds.Insert(0, new Category()
            {
                CategoryID = 0,
                CategoryName = "--Tất cả danh mục--"
            });
        }
        ddl.DataSource = ds;
        ddl.DataTextField = "CategoryName";
        ddl.DataValueField = "CategoryID";
        ddl.DataBind();
    }
    public static void LoadNhaCungCap(DropDownList ddl, bool tatCa = false)
    {
        var ds = Supplier.DSNCC;
        //neu co muc tat ca
        if (tatCa)
        {
            ds.Insert(0, new Supplier()
            {
                SupplierID = 0,
                CompanyName = "--Tất cả nhà cung cấp--"
            });
        }
        ddl.DataSource = ds;
        ddl.DataTextField = "CompanyName";
        ddl.DataValueField = "SupplierID";
        ddl.DataBind();
    }

    //ham load san pham theo ma Danh Muc va ma Nha Cung Cap vao GridView
    public static void LoadSPToGridView(GridView grv)
    {
        grv.DataSource = Product.DSSP;
        grv.DataBind();
    }
    public static void LoadSPToGridView(GridView grv, int maDM)
    {
        grv.DataSource = Product.LayDSSP(maDM);
        grv.DataBind();
    }
    public static void LoadSPToGridView(GridView grv, int maDM, string ten)
    {
        grv.DataSource = Product.LayDSSP(maDM, ten);
        grv.DataBind();
    }
    public static void SanPhamBanChay(DataList dliw, int n)//IQueryable mot namespace cho phep cac cau truy van bang LINQ
    {
        dliw.DataSource = Product.SanPhamBanChay(n);
        dliw.DataBind();
    }
    //load danh sach quyen han
    public static void LoadVuiTro2DDL(DropDownList ddl, bool tatCa = false)
    {
        var ds = Role.DSVT;
        //neu co muc tat ca
        if (tatCa)
        {
            ds.Insert(0, new Role()
            {
                RoleID = 0,
                RoleName = "--Tất cả quyền--"
            });
        }
        ddl.DataSource = ds;
        ddl.DataTextField = "RoleName";
        ddl.DataValueField = "RoleID";
        ddl.DataBind();
    }
    //load trang web
    public static void LoadTrangWeb2GV(GridView grv)
    {
        grv.DataSource = WebPage.DSTW;
        grv.DataBind();
    }
    public static void LoadTrangWeb2Rpt(Repeater rpt)
    {
        rpt.DataSource = WebPage.DSTW;
        rpt.DataBind();
    }

    //load hoa don
    public static void LoadHDToGridView(GridView grv)
    {
        grv.DataSource = Order.DSHD;
        grv.DataBind();
    }
    public static void LoadHDToGridView(GridView grv, DateTime tu, DateTime den)
    {
        grv.DataSource = Order.LayDSHD(tu, den);
        grv.DataBind();
    }

    //load chi tiet hoa don
    public static void LoadCTHDToGridView(GridView grv, int maHD)
    {
        grv.DataSource = Order_Detail.LayCTHD(maHD);
        grv.DataBind();
    }
    public static void LoadHDToGridView(GridView grv, string maKH)
    {
        grv.DataSource = Order.LayDSHD(maKH);
        grv.DataBind();
    }

    //load khach hang
    public static void LoadKHToGridView(GridView grv)
    {
        grv.DataSource = Customer.DSKH;
        grv.DataBind();
    }
    
    //load nhan vien
    public static void LoadNVToGridiew(GridView grv)
    {
        grv.DataSource = Employee.DSNV;
        grv.DataBind();
    }
    public static void LoadNVToGridiew(GridView grv, int maRole)
    {
        grv.DataSource = Employee.LayDSNV(maRole);
        grv.DataBind();
    }
    public static void LoadNVToGridiew(GridView grv, int maRole, string ten)
    {
        List<Employee> ds;
        if (maRole == 0) ds = Employee.LayDSNV(ten);
        else ds = Employee.LayDSNV(maRole, ten);
        grv.DataSource = ds;
        grv.DataBind();
    }
}