using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


public partial class Role
{
    static private DBDataContext dc = new DBDataContext();
    static public List<Role> DSVT
    {
        get
        {
            return dc.Roles.ToList();
        }
    }
}