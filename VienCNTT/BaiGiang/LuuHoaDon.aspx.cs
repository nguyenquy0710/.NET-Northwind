using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class LuuHoaDon : TrangCoGioHang
{
    protected void Page_Init(object sender, EventArgs e)
    {
        h3TB.InnerText = string.Empty;
        if (this.KhachHang == null)
        {
            Response.Redirect("~/");
        }
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            LoadTTKH();
        }
    }

    private void LoadTTKH()
    {
        h3MaKH.InnerText = KhachHang.CustomerID;
        txtHT.Text = KhachHang.CompanyName;
        h3TT.InnerText = this.GioHang.TongTien.ToString();
    }
    protected void btnLuu_Click(object sender, EventArgs e)
    {
        if (!MyUtility.ChuoiHopLe(h3MaKH.InnerText))
        {
            h3TB.InnerText = "Bạn chưa đăng nhập";
            return;
        }
        DateTime ngayGiao;
        if (!DateTime.TryParseExact(txtNgayGiao.Text, "dd/MM/yyyy", null,
             System.Globalization.DateTimeStyles.None, out ngayGiao))
        {
            h3TB.InnerText = "Ngày giao không hợp lệ";
            return;
        }
        if (ngayGiao < DateTime.Today.AddDays(1))
        {
            h3TB.InnerText = "Hãy chọn ngày hợp lệ";
            return;
        }
        Order o = new Order()
        {
            CustomerID = h3MaKH.InnerText,
            OrderDate = DateTime.Today,
            Freight = (decimal)this.GioHang.TongTien,
            ShipAddress = txtDC.Text,
            RequiredDate = ngayGiao,
            Status = false//hoa don nay chua thu tien!
        };
        //voi moi dong trong gio hang, se them 1 chi tiet hoa don trong o:
        foreach (Product p in this.GioHang)
        {
            Order_Detail od = new Order_Detail()
            {
                ProductID = p.ProductID,
                UnitPrice = (decimal)p.UnitPrice,
                Quantity = (short)p.Quantity,
                Discount = 0//giam gia

            };
            //them od => o:
            o.Order_Details.Add(od);
        }
        //luu hoa don:
        Order.Them(o);
        h3TB.InnerText = "Đã lưu hóa đơn";
        this.GioHang.Xoa();//xoa rong gio hang.
    }
}