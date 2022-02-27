using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


public partial class Customer
{
    static private DBDataContext dc = new DBDataContext();
    static public Customer Tim(string cusID)
    {
        return dc.Customers.FirstOrDefault(
            x => x.CustomerID.Equals(cusID));
    }
    
    static public void Them(Customer cus)
    {
        try
        {
            var kq = Tim(cus.CustomerID);
            if (kq == null)
            {
                dc.Customers.InsertOnSubmit(cus);
                dc.SubmitChanges();
            }
        }
        catch (Exception ex)
        {
            var x = ex.Message;
        }
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
    static public Customer Tim(string cusID, DBDataContext dc)
    {
        return dc.Customers.FirstOrDefault(
            x => x.CustomerID.Equals(cusID));
    }
}