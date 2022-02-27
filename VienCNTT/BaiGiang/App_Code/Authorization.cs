using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


public partial class Authorization
{
    static private DBDataContext dc = new DBDataContext();

    static public Authorization Tim(string trang, int maVT)
    {
        return dc.Authorizations.FirstOrDefault(x =>
            x.RoleID == maVT && x.PageFile == trang);
    }
    static public Authorization Tim(string trang, string username)
    {
        //tim nhan vien:
        var nv = dc.Employees.FirstOrDefault(x => x.Username == username);
        if (nv == null) return null;

        return Tim(trang, (int)nv.RoleID);
    }

    static public void Them(Authorization au)
    {
        var kq = Tim(au.PageFile, au.RoleID);
        if (kq == null)
        {
            dc.Authorizations.InsertOnSubmit(au);
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
    static public void Xoa(string trang, int roleID)
    {
        var kq = Tim(trang, roleID);
        if (kq != null)
        {
            dc.Authorizations.DeleteOnSubmit(kq);
            dc.SubmitChanges();
        }
    }
}