using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class BH3_SuDungList : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //TaoDS();
        //string kq = TimKiem(TaoDS(), "t");
        //if (kq == null) Response.Write("khong tim thay");
        //else Response.Write(kq);
        var l = TaoDS();
        Response.Write(l.Contains("tuan"));
    }
    List<string> TaoDS()
    {
        //khai bao danh chua string
        List<string> lst = new List<string>();
        //them phan tu vao danh sach:
        lst.Add("tuan");
        lst.Add("lan");
        lst.Add("binh");
        lst.Add("hue");
        lst.Add("thu");
        //xoa phan tu khoi danh sach:
        //lst.Remove("binh");
        ////hien thi danh sach:
        //foreach (string s in lst)
        //    Response.Write("<p>" + s + "</p>");
        return lst;
    }
    //tim kiem tren danh sach:
    string TimKiem(List<string> ds, string txt)
    {//tim ho ten chua chuoi txt:
        foreach (string s in ds)
            if (s.ToLower().Contains(txt.ToLower()))
                return s;
        return null;
    }
}