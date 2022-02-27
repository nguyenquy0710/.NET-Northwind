using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class BH5_HocPhanHe : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        SinhVien s = new SinhVien();
        s.Ten = "Tuan";
        s.dshpNo.Add("ctdl");
        s.dshpNo.Add("csdl");
        SinhVien s1 = new SinhVien();
        s1.Ten = "Lan";
        s1.dshpNo.Add("lap trinh web");
        s1.dshpNo.Add("csdl");
        SinhVien s2 = new SinhVien();
        s2.Ten = "Binh";
        s2.dshpNo.Add("toan");
        s2.dshpNo.Add("ktlt");
        Truong gtvt = new Truong();
        gtvt.dshpMo.Add("lap trinh web");
        gtvt.dshpMo.Add("ctdl");
        gtvt.dshpMo.Add("mang may tinh");
        //s.DangKy(gtvt);
        //s1.DangKy(gtvt);
        //s2.DangKy(gtvt);
        gtvt.ThemSV(s);
        gtvt.ThemSV(s1);
        //gtvt.ThemSV(s2);
        gtvt.OnMoLop();
    }
}