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
        dc.SubmitChanges();//day data trong datacontect ve lai database
    }
    public static Category Tim(int ma)
    {
        return dc.Categories.FirstOrDefault(x => x.CategoryID == ma);
    }
    //tim sanh muc theo ten
    public static Category Tim(string ten)
    {
        return dc.Categories.FirstOrDefault(x => x.CategoryName.Equals(ten));
    }
    public static void Xoa(int ma)
    {
        var kq = Tim(ma);
        if (kq != null)
        {
            if (kq.Products.Count() == 0)
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
    //lay DSDM theo ten
    public static List<Category> LayDSDM(string ten)
    {
        return dc.Categories.Where(x => x.CategoryName.ToLower().Contains(ten.ToLower())).ToList();
    }
    static public List<Category> DMCoSP
    {
        get
        {
            return DSDM.Where(x => x.Products.Count() > 0).ToList();
        }
    }
}