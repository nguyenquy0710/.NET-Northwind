using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Authorization
/// </summary>
public partial class Authorization
{
    static DBDataContext dc = new DBDataContext();
    static public void Them(Authorization au)
    {
        var kq = Tim(au.PageFile, au.RoleID);
        if (kq == null)
        {
            dc.Authorizations.InsertOnSubmit(au);
            dc.SubmitChanges();
        }
    }
    static public Authorization Tim(string trang, int maVT)
    {
        return dc.Authorizations.FirstOrDefault(x => x.RoleID == maVT && x.PageFile == trang);
    }
    static public Authorization Tim(string trang, string username)
    {
        //tim nv
        var nv = dc.Employees.FirstOrDefault(x => x.UserName == username);
        if (nv == null)
            return null;
        return Tim(trang, (int)nv.RoleID);
    }
    static public void Xoa(string trang, int id)
    {
        var kq = Tim(trang, id);
        if (kq != null)
        {
            dc.Authorizations.DeleteOnSubmit(kq);
            dc.SubmitChanges();
        }
    }
    static public void Sua(Authorization au)
    {
        var kq = Tim(au.PageFile, au.RoleID);
        if (kq != null)
        {
            kq.AUInsert = au.AUInsert;
            kq.AUDelete = au.AUDelete;
            kq.AUUpdate = au.AUUpdate;
            kq.AUSelect = au.AUSelect;
            dc.SubmitChanges();

        }
    }
    public static Boolean AuthorizedToAddEdit()
    {
        return false;
    }
}