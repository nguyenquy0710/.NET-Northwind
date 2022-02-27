using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class BG4 : System.Web.UI.Page
{
    //khai bao mang (dung chung - toan cuc - global):
    int[] a = { -5, 12, 4, 6, 45, 8, -14 };
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnTT_Click(object sender, EventArgs e)
    {
        int tong = 0;
        //for (int i = 0; i < a.Length - 1; i++)
        //    tong += a[i];
        foreach (int p in a)tong += p;
        Response.Write("tong = " + tong);
    }
    protected void btnDem_Click(object sender, EventArgs e)
    {
        int dem = 0;
        //for (int i = 0; i < a.Length - 1; i++)
        //    if (a[i] > 0)dem++;
        //su dung lenh foreach (voi moi):
        foreach (int pt in a)
            if (pt > 0) dem++;
        Response.Write("so pt > 0 = " + dem);
    }
    protected void btnTim_Click(object sender, EventArgs e)
    {
        int so = int.Parse(txtTim.Text);
        //su dung phuong phap dat co hieu
        bool thay = false;//bat co
        foreach(int p in a)
            if (p == so)
            {
                thay = true;//ha co
                break;
            }
        if (thay) lblTim.Text = "Tim thay";
        else lblTim.Text = "Tim khong thay";
    }
   
}