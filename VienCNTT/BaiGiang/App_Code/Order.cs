using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


public partial class Order
{
    public string TenCongTy
    {
        get
        {
            return this.Customer.CompanyName;
        }
    }
    private static DBDataContext dc = new DBDataContext();
    public static List<Order> DSHD
    {
        get
        {
            return dc.Orders.ToList();
            
        }
    }
    public static void Them(Order or)
    {
        dc.Orders.InsertOnSubmit(or);
        dc.SubmitChanges();
    }
    static public List<Order> LayDSHD(DateTime tu, DateTime den)
    {
        return DSHD.Where(x =>
            x.OrderDate >= tu && x.OrderDate <= den).ToList();
    }
}