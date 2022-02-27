using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class BH3_LopVaDoiTuong : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //tao object:
        SinhVien s = new SinhVien();
        s.ma = 1;
        s.ten = "tran van tuan";
        s.DoiTen("vu dinh long");
        s.ngaySinh = new DateTime(1995, 3, 26);
        if (s.LaSinhNhat)
            Response.Write("Happy Birthday to you!");
        //Response.Write(s.ToChuoi());
        Response.Write(s.ToString());

    }
}
//co the viet class o day:
public class SinhVien
{
    //thanh phan du lieu:
    public int ma;
    public string ten;
    public DateTime ngaySinh;
    //phuong thuc:
    public string ToChuoi()
    {
        return ma + ", " + ten + ", "
            + ngaySinh.ToString("dd/MM/yyyy");
    }
    public override string ToString()
    {
        return ma + ", " + ten + ", "
          + ngaySinh.ToString("dd/MM/yyyy");
    }
    public void DoiTen(string tenMoi)
    {
        this.ten = tenMoi;
    }
    //xay dung method kiem tra xem hom nay co
    //la ngay sinh nhat cua sv nay khong?
    public bool LaSinhNhat //property = thuoc tinh
    {
        get //vs. set
        {
            return DateTime.Today.Day == this.ngaySinh.Day
                 && DateTime.Today.Month == this.ngaySinh.Month;
        }
    }
}