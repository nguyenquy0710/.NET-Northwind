using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class SuDungDateTime : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //lay ngay gio hien tai:
        //Response.Write(DateTime.Now);
        //lay ngay hien tai:
        //dd/MM/yyyy = dinh dang ngay thang
        //Response.Write(DateTime.Today.ToString("dd/MM/yyyy"));
        //lay nam hien tai:
        //Response.Write(DateTime.Today.Year);
        //tao 1 doi tuong ngay thang:
        //DateTime n = new DateTime(1995, 3, 16);
        //Response.Write(n.Day);
        //tim so ngay tu n den hom nay:
        //var kq = DateTime.Today - n;
        //Response.Write(kq.Days);
        //parse 1 string thanh datetime:
        string strNgay = "toi khong biet";
        DateTime kq;
        if (DateTime.TryParseExact(strNgay, "dd/MM/yyyy", null
            , System.Globalization.DateTimeStyles.None
            , out kq))
            Response.Write(kq.ToString("dd/MM/yyyy"));
        else
            Response.Write("khong dung dinh dang");

    }
}