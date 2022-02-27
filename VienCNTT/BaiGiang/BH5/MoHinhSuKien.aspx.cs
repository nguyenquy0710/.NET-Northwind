using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class BH5_MoHinhSuKien : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Galaxy qt = new Galaxy();
        //qt.DiaChi = "Tay Ho, Ha Noi";
        qt.DiaChi = "Binh Thanh, tp hcm";
        NguoiXem ai = new NguoiXem();
        ai.Ten = "Le Thi Ai";
        ai.SoTien = 10;
        NguoiXem toi = new NguoiXem();
        toi.Ten = "Tran Van Toi";
        toi.SoTien = 0;
        Phim p = new Phim()
        {
            TenDV = "Chanh Tin",
            GiaVe = 123
        };
        qt.PhimHienTai = p;

        ai.DangKy(qt);
        toi.DangKy(qt);
        //rat lau sau do
        qt.OnPhimMoi();
    }
}
