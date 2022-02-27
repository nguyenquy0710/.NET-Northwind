using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Supplier
/// </summary>
public partial class Supplier
{
    static DBDataContext dc = new DBDataContext();
    public static List<Supplier> DSNCC
    {
        get
        {
            return dc.Suppliers.ToList();
        }
    }
}