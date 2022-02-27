using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for TrangMua
/// </summary>
public class TrangCoGioHang : System.Web.UI.Page
{
    //trang mua la trang chua gio hang
    protected Gio GioHang
    {
        get
        {
            if (HttpContext.Current.Session["gh"] == null)
                HttpContext.Current.Session["gh"] = new Gio();
            return HttpContext.Current.Session["gh"] as Gio;
        }
    }
    protected Customer KhachHang
    {
        get
        {
            if (Session["kh"] == null) return null;
            return Session["kh"] as Customer;
        }
    }
}