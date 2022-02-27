using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Order_Detail
/// </summary>
public partial class Order_Detail
{
    private static DBDataContext dc = new DBDataContext();
    public static void Them(Order_Detail od)
    {
        dc.Order_Details.InsertOnSubmit(od);
        dc.SubmitChanges();
    }
    public static List<Order_Detail> DSCTHD
    {
        get
        {
            return dc.Order_Details.ToList();
        }
    }
    public static List<Order_Detail> LayCTHD(int maHD)
    {
        return DSCTHD.Where(x => x.OrderID.Equals(maHD)).ToList();
    }
    public string ProductName
    {
        get
        {
            return Product.ProductName;
        }
    }
    public static Order_Detail Tim (int orID, int proID)
    {
        return dc.Order_Details.FirstOrDefault(x => x.OrderID.Equals(orID) && x.ProductID.Equals(proID));
    }
    public static void Delete(Order or, Product p)
    {
        var kq = Tim(or.OrderID, p.ProductID);
        if(kq!=null)
        {
            dc.Order_Details.DeleteOnSubmit(kq);
            dc.SubmitChanges();
        }
    }
}