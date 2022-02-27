using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Category
/// </summary>
public partial class Category
{
    static DBDataContext dc = new DBDataContext();
    public static void Them(Category cat)
    {
        dc.Categories.InsertOnSubmit(cat);
        dc.SubmitChanges();
    }
    public static Category Tim(int ma)
    {
        return dc.Categories.FirstOrDefault(x => x.CategoryID == ma);
    }
    public static void Xoa(int ma)
    {
        var kq = Tim(ma);
        if (kq != null)
        {
            if (kq.Products.Count == 0)
            {
                dc.Categories.DeleteOnSubmit(kq);
                dc.SubmitChanges();
            }
        }
    }
    public static void Sua(Category cat)
    {
        var kq = Tim(cat.CategoryID);
        if (kq != null)
        {
            kq.CategoryName = cat.CategoryName;
            kq.Description = cat.Description;
            dc.SubmitChanges();
        }
    }
    static public List<Category> DSDM
    {
        get
        {
            return dc.Categories.ToList();
        }
    }
    static public List<Category> DMCoSP
    {
        get
        {
            return DSDM.Where(x => x.Products.Count > 0).ToList();
        }
    }
}