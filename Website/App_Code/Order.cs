using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Order
/// </summary>
public partial class Order
{
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
    public static List<Order> LayDSHD(DateTime tu, DateTime den)
    {
        return DSHD.Where(x => x.OrderDate >= tu && x.OrderDate <= den).ToList();
    }
    public static Order Tim (int orID)
    {
        return dc.Orders.FirstOrDefault(x => x.OrderID.Equals(orID));
    }
    public static void Delete(Order or)
    {
        var kq = Tim(or.OrderID);
        if(kq!=null)
        {
            if(kq.Order_Details.Count()==0)
            {
                dc.Orders.DeleteOnSubmit(kq);
                dc.SubmitChanges();
                WebMsgBox.Show("Xoá Đơn Hàng Thành Công");
            }
        }
    }

    internal static List<Order> LayDSHD(string maKH)
    {
        return DSHD.Where(x => x.CustomerID.Equals(maKH)).ToList();
    }
}