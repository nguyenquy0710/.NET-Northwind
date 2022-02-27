using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Customer
/// </summary>
public partial class Customer
{
    private static DBDataContext dc = new DBDataContext();
    static public Customer Tim(string cusID)
    {
        return dc.Customers.FirstOrDefault(x => x.CustomerID.Equals(cusID));
    }
    public static void Them(Customer cus)
    {
        var kq = Tim(cus.CustomerID);
        if(kq == null)
        {
            dc.Customers.InsertOnSubmit(cus);
            dc.SubmitChanges();
        }
    }
    public static List<Customer> DSKH
    {
        get
        {
            return dc.Customers.ToList();
        }
    }
    public static void Delete(Customer cus)
    {
        var kq = Tim(cus.CustomerID);
        if(kq!=null)
        {
            if (kq.Orders.Count() == 0)
                dc.Customers.DeleteOnSubmit(kq);
            dc.SubmitChanges();
        }
    }
    static public Customer Tim(string cusID, DBDataContext dc)
    {
        return dc.Customers.FirstOrDefault(x => x.CustomerID.Equals(cusID));
    }
    static public void KichHoatTK(string cusID, bool status)
    {
        var kq = Tim(cusID);
        if (kq != null)
        {
            kq.Status = status;
            dc.SubmitChanges();
        }
    }
}