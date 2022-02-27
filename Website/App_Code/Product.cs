using System.IO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Product
/// </summary>
public partial class Product
{
    static DBDataContext dc = new DBDataContext();
    public static List<Product> DSSP
    {
        get
        {
            return dc.Products.ToList();
        }
    }
    public static void Them(Product p)
    {
        dc.Products.InsertOnSubmit(p);
        dc.SubmitChanges();//day data trong datacontect ve lai database
        WebMsgBox.Show("Thêm Sản Phẩm Thành Công!");
    }
    public static Product Tim(int ma)
    {
        return dc.Products.FirstOrDefault(x => x.ProductID == ma);
    }
    public static void Xoa(int ma)
    {
        //try
        //{
        var kq = Tim(ma);
        if (kq != null)
        {
            if (kq.Order_Details.Count() == 0)
            {
                dc.Products.DeleteOnSubmit(kq);
                dc.SubmitChanges();
                WebMsgBox.Show("Xoá Sản Phẩm Thành Công!");
            }
        }
        //}
        //catch(Exception ex)
        //{
        //    //var x = ex.Message;
        //    //var t = x;
        //}
    }
    public static void Sua(Product p)
    {
        var kq = Tim(p.ProductID);
        if (kq != null)
        {
            kq.ProductName = p.ProductName;
            kq.SupplierID = p.SupplierID;
            kq.CategoryID = p.CategoryID;
            kq.QuantityPerUnit = p.QuantityPerUnit;
            kq.UnitPrice = p.UnitPrice;
            kq.ReorderLevel = p.ReorderLevel;
            dc.SubmitChanges();
            //neu co hinh
            if (MyUtility.ChuoiHopLe(p.Image))
            {
                //xoa hinh cu
                string path = HttpContext.Current.Server.MapPath(kq.DuongDanHinh);
                if (File.Exists(path))
                {
                    File.Delete(path);
                }
                //cap nhat ten hinh moi
                kq.Image = p.Image;
            }
            dc.SubmitChanges();
            WebMsgBox.Show("Chỉnh Sửa Sản Phẩm Thành Công!");
        }
    }
    public string DuongDanHinh
    {
        get
        {
            return "~/Image/SanPham/" + this.Image;
        }
    }
    public static List<Product> LayDSSP(int maDM)
    {
        return dc.Products.Where(x => x.CategoryID == maDM).ToList();
    }
    public static List<Product> LayDSSP(string ten)
    {
        return dc.Products.Where(x => x.ProductName.ToLower().Contains(ten.ToLower())).ToList();
    }
    static public List<Product> LayDSSP(int maDM, string ten)
    {
        //if (maDM > 0)
        //{
        //    return dc.Products.Where(x => x.CategoryID == maDM
        //    && x.ProductName.ToLower().Contains(tem.ToLower())).ToList();
        //}
        //else
        //    return dc.Products.Where(x => x.ProductName.ToLower().Contains(tem.ToLower())).ToList();
        var ds = dc.Products.Where(x => x.ProductName.ToLower().Contains(ten.ToLower())).ToList();
        if (maDM > 0)
            ds = ds.Where(x => x.CategoryID == maDM).ToList();
        return ds;
    }
    public static IQueryable SanPhamBanChay(int n)
    {
        //khong su dung!
        //var ds = from sp in dc.Products
        //         join od in dc.Order_Details
        //         on sp.ProductID equals od.ProductID
        //         group sp by sp.ProductID into g
        //         select g;
        var tm = dc.Products.Select(x => new
        {
            x.ProductID,
            x.ProductName,
            x.UnitPrice,
            x.Image,
            DuongDanHinh = "~/Image/SanPham/" + x.Image,
            SoHoaDon = x.Order_Details.Count
        }).OrderByDescending(y => y.SoHoaDon).Take(n);
        return tm;
    }
    public int Quantity { set; get; }
}