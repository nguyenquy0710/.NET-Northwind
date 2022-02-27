using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class BH6_SuDungDataTable : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        TestDataTable();
    }

    private void TestDataTable()
    {
        DataTable t = new DataTable();
        //dinh nghia cac column:
        t.Columns.Add("MaSV", typeof(string));
        t.Columns.Add("TenSV", typeof(string));
        t.Columns.Add("NgaySinh", typeof(DateTime));
        //dinh nghia khoa chinh (primary key):
        t.PrimaryKey = new DataColumn[] { t.Columns["MaSV"] };
        //them cac dong du lieu:
        DataRow dong = t.NewRow();
        dong["MaSV"] = "sv1";
        dong["TenSV"] = "Tran Van Mot";
        dong["NgaySinh"] = new DateTime(1999, 1, 12);
        t.Rows.Add(dong);
        dong = t.NewRow();
        dong["MaSV"] = "sv2";
        dong["TenSV"] = "Le Thi Hai";
        dong["NgaySinh"] = new DateTime(1998, 1, 12);
        t.Rows.Add(dong);
        //xoa 1 dong:
        t.Rows.Remove(t.Rows.Find("sv1"));
        //hien thi table:
        foreach (DataRow d in t.Rows)
        {
            Response.Write(d["MaSV"] + ", " + d["TenSV"].ToString()
                + ", " 
                + DateTime.Parse(d["NgaySinh"].ToString())
                .ToString("dd/MM/yyyy")
                + "<br/>");
        }
        //su dung primary key de tim kiem:
        var kq = t.Rows.Find("sv11");
        if (kq != null)
        {
            Response.Write("ket qua tim kiem<br/>");
            Response.Write(kq["MaSV"] + ", " + kq["TenSV"].ToString()
                    + ", "
                    + DateTime.Parse(kq["NgaySinh"].ToString())
                    .ToString("dd/MM/yyyy")
                    + "<br/>");
        }
        else
            Response.Write("khong tim thay");
       

    }
}