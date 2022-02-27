using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class BG2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnTT_Click(object sender, EventArgs e)
    {
        double gia = 0;
        int soNgay;
        //soNgay = int.Parse(txtSN.Text);
        bool laSoNguyen = int.TryParse(txtSN.Text
            ,out soNgay);
        if (laSoNguyen)
        {
            string loaiXe = txtLoaiXe.Text;

            loaiXe = loaiXe.ToUpper();

            if (loaiXe == "A") gia = 500;
            else if (loaiXe == "B") gia = 400;
            else if (loaiXe == "C") gia = 300;
            if (gia > 0)
            {
                double tien = gia * soNgay;
                Response.Write("tong tien = " + tien);
            }
            else
                Response.Write("Khong co loai xe nay!");
        }
        else
            Response.Write("so ngay khong hop le");
    }
}