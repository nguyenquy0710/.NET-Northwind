using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


public partial class Order_Detail
{
    private static DBDataContext dc = new DBDataContext();
    public static void Them(Order_Detail od)
    {
        dc.Order_Details.InsertOnSubmit(od);
        dc.SubmitChanges();
    }
    public static List<Order_Detail> LayCTHD(int maHD)
    {
        return dc.Order_Details.Where(
            x => x.OrderID == maHD).ToList();
    }
    public string ProductName
    {
        get
        {
            return Product.ProductName;
        }

    }
}