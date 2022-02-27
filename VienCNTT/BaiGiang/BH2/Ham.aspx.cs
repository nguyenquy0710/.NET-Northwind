using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Ham : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //Response.Write(TinhTong(10));
        //su dung tham so ngam dinh, tinh tong so chan:
        //Response.Write(TongChanLe(2, 7));
        //tinh tong so le:
        //Response.Write(TongChanLe(2, 7, false));
        //double x = 5, y = 7;
        ////HoanVi(x, y);//goi ham hoan vi thu 1
        //HoanVi(ref x, ref y);//goi ham hoan vi thu 2
        //Response.Write("x = " + x);
        //int a = 1, b = 2;
        //int tong, tich;
        //TongTich(a, b, out tong, out tich);
        //Response.Write("tong = " + tong);
        //su dung ham params:
        //Response.Write(TongParams());
        //Response.Write(TongParams(1, 2, 3));
        //Response.Write(TongParams(1));
        //su dung ham de quy:
        //Response.Write(GiaiThua(4));
        int[] a = { 1, 2, 37 };
        Response.Write(MaxTrongMang(a, a.Length));
    }
    int TinhTong(int n)//head
    {//body
        //tinh tong cac so chan tu 1 den n:
        int ketQua = 0;
        for (int i = 1; i <= n; i++) ketQua += i;
        return ketQua;
    }
    protected void btnTT_Click(object sender, EventArgs e)
    {
        //hay su dung ham TinhTong o day:
        //int so = int.Parse(txtN.Text);
        int so;
        if (int.TryParse(txtN.Text, out so))
            pKQ.InnerHtml = "Ket qua la: " + TinhTong(so);
        else
            pKQ.InnerHtml = "Du lieu nhap vao khong hop le";
    }
    //ham tinh tong cac so chan hoac le tu a => b:
    //su dung tham so ngam dinh (default parameter)
    int TongChanLe(int a, int b, bool chan = true)
    {//chan co gia tri ngam dinh la true
        int s = 0;
        if (a > b) { int t = a; a = b; b = t; }
        for (int i = a; i <= b; i++)
            if (chan)
            {
                if (i % 2 == 0) s += i;
            }
            else
            {
                if (i % 2 == 1) s += i;
            }
        return s;
    }
    //ham su dung tham so la tham chieu (reference):
    //ham hoan vi gia tri cua 2 tham so a,b:
    void HoanVi(double a, double b)
    {
        //se khong the hoan vi (vi sao?)
        double t = a; a = b; b = t;
    }
    void HoanVi(ref double a, ref double b)
    {//ref = reference
        double t = a; a = b; b = t;
    }
    //tham so ra (out):
    //ham su dung tham so out de tra tong & tich:
    void TongTich(int a, int b, out int tong, out int tich)
    {
        tong = a + b; tich = a * b;
    }
    //tham so params:
    //dap ung nhung ham kieu sau day
    //Ham(a);Ham(a,b);Ham(a,b,c,d,e,f);Ham();
    //tham so la params phai nam o vi tri CUOI CUNG trong ds tham so!
    int TongParams(int x, params int[] a)
    {
        var s = x;
        foreach (int pt in a) s += pt;
        return s;
    }
    //ham de quy:
    //tinh giai thua:
    int GiaiThua(int x)
    {
        //th1 khong de quy
        //int kq = 1;
        //for (int i = 1; i < x + 1; i++)
        //    kq *= i;
        //return kq;
        //th2: de quy
        if (x == 0) return 1;
        return x * GiaiThua(x - 1);
    }
    //viet ham de quy tim UCLN(x,y)
    /*
     * 1: x>y => x = x-y
     * 2: y>=x => y = y-x
     * int kq = UCLN(678,10);
     * long_cn@hcmutrans.edu.vn
     */
    int UCLN(int x, int y)
    {
        //khong de quy:
        //while (x * y > 0)
        //    if (x > y) x = x - y;
        //    else y = y - x;
        //return x + y;
        //de quy:
        if (x * y == 0) return x + y;
        else if (x > y) return UCLN(x - y, y);
        else return UCLN(x, y - x);
    }
    //tim phan tu lon nhat trong mang bang de quy:
    int MaxTrongMang(int[] a, int n)//n=so phan tu cua mang.
    {
        if (n == 1) return a[0];
        else
        {
            var maxTam = MaxTrongMang(a, n - 1);
            if (maxTam > a[n - 1]) return maxTam;
            else return a[n - 1];
        }
    }
}