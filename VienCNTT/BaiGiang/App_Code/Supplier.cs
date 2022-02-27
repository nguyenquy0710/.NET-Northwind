using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


public partial class Supplier
{
    static DBDataContext dc = new DBDataContext();
    static public List<Supplier> DSNCC
    {
        get
        {
            return dc.Suppliers.ToList();
        }
    }
}