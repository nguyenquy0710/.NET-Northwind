using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;


public class PL
{
    public static void LoadHD2GV(GridView grv)
    {
        grv.DataSource = Order.DSHD;
        grv.DataBind();
    }
    public static void LoadCTHD2GV(GridView grv, int maHD)
    {
        grv.DataSource = Order_Detail.LayCTHD(maHD);
        grv.DataBind();
    }
    public static void LoadHD2GV(GridView grv, DateTime tu, DateTime den)
    {
        grv.DataSource = Order.LayDSHD(tu,den);
        grv.DataBind();
    }
    public static void LoadDM2GV(GridView grv)
    {
        grv.DataSource = Category.DSDM;
        grv.DataBind();
    }
    public static void LoadSP2GV(GridView grv)
    {
        grv.DataSource = Product.DSSP;
        grv.DataBind();
    }
    public static void LoadSP2GV(GridView grv, int maDM)
    {
        grv.DataSource = Product.LayDSSP(maDM);
        grv.DataBind();
    }
    public static void LoadSP2GV(GridView grv, int maDM, string ten)
    {
        grv.DataSource = Product.LayDSSP(maDM,ten);
        grv.DataBind();
    }
    public static void LoadDM2DDL(DropDownList ddl, bool taCa=false)
    {
        var ds = Category.DSDM;
        //neu co muc tat ca:
        if(taCa)
        {
            ds.Insert(0, new Category()
            {
                CategoryID=0,
                CategoryName = "--Tất cả--"
            });
        }
        ddl.DataSource = ds;
        ddl.DataTextField = "CategoryName";
        ddl.DataValueField = "CategoryID";
        ddl.DataBind();
    }
    public static void LoadNCC2DDL(DropDownList ddl)
    {
        ddl.DataSource = Supplier.DSNCC;
        ddl.DataTextField = "CompanyName";
        ddl.DataValueField = "SupplierID";
        ddl.DataBind();
    }
    public static void LoadSPBanChay(DataList dtl, int soSP)
    {
        dtl.DataSource = Product.SanPhamBanChay(soSP);
        dtl.DataBind();
    }

    public static void LoadVaiTro2DDL(DropDownList ddl)
    {
        ddl.DataSource = Role.DSVT;
        ddl.DataTextField = "RoleName";
        ddl.DataValueField = "RoleID";
        ddl.DataBind();
    }
    public static void LoadTrangWeb2GV(GridView grv)
    {
        grv.DataSource = WebPage.DSTW;
        grv.DataBind();
    }
}