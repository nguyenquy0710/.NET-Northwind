using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class BH6_SuDungEvent : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        CayXang cx = new CayXang();
        NguoiDan dan = new NguoiDan();
        dan.DangKy(cx);
        //cx.OnTangGia();
        cx.OnGiamGia();
        cx.TaoLao += Cx_TaoLao;
    }

    private void Cx_TaoLao(object sender, EventArgs e)
    {
        
    }
}
public class CayXang
{
    public delegate void TangGiaHandler();
    public event TangGiaHandler TangGia;//khai bao su kien
    //event su dung delegate co san:
    public event EventHandler GiamGia, TaoLao;
    public void OnGiamGia()
    {
        if (GiamGia != null) GiamGia(this, null);
    }
    public void OnTangGia()
    {
        if (TangGia != null) TangGia();
    }
}
public class NguoiDan
{
    public void DangKy(CayXang cx)
    {
        cx.TangGia += Cx_TangGia;
        cx.GiamGia += Cx_GiamGia;
    }

    private void Cx_GiamGia(object sender, EventArgs e)
    {
        //co the lay thong tin trong sender (cay xang) neu muon
        HttpContext.Current.Response.Write("Di xe");
    }

    private void Cx_TangGia()
    {
        HttpContext.Current.Response.Write("Di bo");
    }
}