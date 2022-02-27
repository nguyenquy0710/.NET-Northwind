using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


public partial class Employee
{
    private static DBDataContext dc = new DBDataContext();
    public static Employee Tim(string username)
    {
        return dc.Employees.FirstOrDefault(x => x.Username == username);
    }
    public static void CapNhatTheoUsername(Employee e)
    {
        var kq = Tim(e.Username);
        if (kq != null)
        {
            kq.LastName = e.LastName;
            kq.FirstName = e.FirstName;
            kq.Password = e.Password;

            dc.SubmitChanges();
        }
    }
}