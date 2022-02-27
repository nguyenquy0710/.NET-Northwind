using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Role
/// </summary>
public partial class Role
{
    static DBDataContext dc = new DBDataContext();
    public static List<Role> DSVT
    {
        get
        {
            return dc.Roles.ToList();
        }
    }
    public static List<Role> LayDSVT(int maPQ)
    {
        return dc.Roles.Where(x => x.RoleID.Equals(maPQ)).ToList();
    }
}