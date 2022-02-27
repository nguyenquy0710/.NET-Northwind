using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Employees
/// </summary>
public partial class Employee
{
    private static DBDataContext dc = new DBDataContext();
    public string DuongDanHinh
    {
        get
        {
            return "~/Image/Avatar/" + this.Photo;
        }
    }
    public static Employee Tim(string username)
    {
        return dc.Employees.FirstOrDefault(x => x.UserName == username);
    }
    public static Employee Tim(int ma)
    {
        return dc.Employees.FirstOrDefault(x => x.EmployeeID == ma);
    }
    public static void CapNhatTheoUsername(Employee e)
    {
        var kq = Tim(e.UserName);
        if (kq != null)
        {
            kq.LastName = e.LastName;
            kq.FirstName = e.FirstName;
            kq.Password = e.Password;

            dc.SubmitChanges();
        }
    }
    public static List<Employee> DSNV
    {
        get
        {
            return dc.Employees.ToList();
        }
    }
    //tim danh sách nhan vien co quyen truong ung
    public static List<Employee> LayDSNV(int ma)
    {
        return dc.Employees.Where(x => x.RoleID.Equals(ma)).ToList();
    }
    public static List<Employee> LayDSNV(int ma, string ten)
    {
        return dc.Employees.Where(x => x.RoleID.Equals(ma) && x.LastName.ToLower().Equals(ten.ToLower())).ToList();
    }

    public static List<Employee> LayDSNV(string ten)
    {
        return dc.Employees.Where(x => x.LastName.ToLower().Equals(ten.ToLower())).ToList();
    }
    //Update data
    public static void Sua(Employee e)
    {
        var kq = Tim(e.EmployeeID);
        if (kq != null)
        {
            kq.EmployeeID = e.EmployeeID;
            kq.UserName = e.UserName;
            kq.FirstName = e.FirstName;
            kq.LastName = e.LastName;
            kq.BirthDate = e.BirthDate;
            kq.Address = e.Address;
            kq.HomePhone = e.HomePhone;
            kq.Country = e.Country;
            kq.Notes = e.Notes;
            kq.RoleID = e.RoleID;
            dc.SubmitChanges();
            //neu co hinh
            if (MyUtility.ChuoiHopLe(e.Photo))
            {
                //xoa hinh cu
                string path = HttpContext.Current.Server.MapPath(kq.DuongDanHinh);
                if (File.Exists(path))
                {
                    File.Delete(path);
                }
                //cap nhat ten hinh moi
                kq.Photo = e.Photo;
            }
            dc.SubmitChanges();
            WebMsgBox.Show("Chỉnh Sửa Sản Phẩm Thành Công!");
        }
    }
    public static void Xoa(int ma)
    {
        //try
        //{
        var kq = Tim(ma);
        if (kq != null)
        {
            if (kq.Orders.Count() == 0)
            {
                dc.Employees.DeleteOnSubmit(kq);
                dc.SubmitChanges();
                WebMsgBox.Show("Xoá Sản Phẩm Thành Công!");
            }
        }
        //}
        //catch(Exception ex)
        //{
        //    //var x = ex.Message;
        //    //var t = x;
        //}
    }
    public static void Them(Employee e)
    {
        if (Tim(e.UserName) == null)
        {
            dc.Employees.InsertOnSubmit(e);
            dc.SubmitChanges();
        }
    }
}