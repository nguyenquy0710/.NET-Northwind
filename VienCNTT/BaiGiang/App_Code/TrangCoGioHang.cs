﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


public class TrangCoGioHang : System.Web.UI.Page
{
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