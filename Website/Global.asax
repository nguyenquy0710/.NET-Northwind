 <%@ Application Language="C#" %>

<%@ Import Namespace="System.IO" %>
<%@ Import Namespace="System.Web.Routing" %>
<script RunAt="server">

    void DangKyRoute(RouteCollection r)
    {
        //Dang ky Route BackEnd
        r.MapPageRoute("AdHome", "admin", "~/Admin/Default.aspx");
        r.MapPageRoute("AdDM", "admin/danhmuc", "~/Admin/QLDM.aspx");
        r.MapPageRoute("AdSearchDM", "admin/danhmuc/{id}", "~/Admin/QLDM.aspx");
        r.MapPageRoute("AdSP", "admin/sanpham", "~/Admin/QLSP.aspx");
        r.MapPageRoute("AdSearchSP", "admin/sanpham/{id}", "~/Admin/QLSP.aspx");
        r.MapPageRoute("AdHD", "admin/hoadon", "~/Admin/QLHD.aspx");
        r.MapPageRoute("AdPQ", "admin/phanquyen", "~/Admin/QLPQ.aspx");
        r.MapPageRoute("AdNV", "admin/nhanvien", "~/Admin/QLNV.aspx");
        r.MapPageRoute("AdCTNV", "admin/nhanvien/{user}", "~/Admin/QLNV.aspx");
        //r.MapPageRoute("AdKH", "admin/khachhang", "~/Admin/QLKH.aspx");
        //r.MapPageRoute("AdNCC", "admin/nhacungcap", "~/Admin/QLNCC.aspx");
        r.MapPageRoute("AdCTHD", "admin/hoadon/chitiet/{id}", "~/Admin/CTHD.aspx");
        r.MapPageRoute("AdLogin", "admin/dangnhap", "~/Admin/Login.aspx");
        r.MapPageRoute("AdAcc", "admin/taikhoan", "~/Admin/Account.aspx");
        r.MapPageRoute("AdSearch", "admin/search/{key}", "~/Admin/Search.aspx");
        //Dang Ky FrontEnd
        r.MapPageRoute("trangchu", "trangchu", "~/Default.aspx");
        r.MapPageRoute("lienhe", "lienhe", "~/LienHe.aspx");
        r.MapPageRoute("dangky", "dangky", "~/DangKyTK.aspx");
        r.MapPageRoute("chitiet", "chitiet/{id}", "~/CTSP.aspx");
        r.MapPageRoute("sanpham", "sanpham", "~/SanPham.aspx");
        r.MapPageRoute("sptheodm", "sanpham/cat/{cat}", "~/SanPham.aspx");
        r.MapPageRoute("sptheotk", "sanpham/tk/{tk}", "~/SanPham.aspx");
        r.MapPageRoute("gioithieu", "gioithieu", "~/GioiThieu.aspx");
        r.MapPageRoute("gio", "gio", "~/CTGH.aspx");
    }

    void Application_Start(object sender, EventArgs e)
    {
        // Code that runs on application startup
        DangKyRoute(RouteTable.Routes);
        // luu so lan view
        string path = @"~/App_Data/Count.txt";
        path = HttpContext.Current.Server.MapPath(path);
        if (!File.Exists(path))
        {
            File.WriteAllText(path, "0");
        }
        Application["sum"] = File.ReadAllText(path);
    }

    void Application_End(object sender, EventArgs e)
    {
        //  Code that runs on application shutdown

    }

    void Application_Error(object sender, EventArgs e)
    {
        // Code that runs when an unhandled error occurs

    }

    void Session_Start(object sender, EventArgs e)
    {
        // Code that runs when a new session is started
        // thong ke truy cap
        if (Application["online"] == null) Application["online"] = 0;
        Application["online"] = int.Parse(Application["online"].ToString()) + 1;
        Application["sum"] = int.Parse(Application["sum"].ToString()) + 1;
        string path = @"~/App_Data/Count.txt";
        path = HttpContext.Current.Server.MapPath(path);
        File.WriteAllText(path, Application["sum"].ToString());
        
        ///
        Session["gh"] = new Gio();
    }

    void Session_End(object sender, EventArgs e)
    {
        // Code that runs when a session ends. 
        // Note: The Session_End event is raised only when the sessionstate mode
        // is set to InProc in the Web.config file. If session mode is set to StateServer 
        // or SQLServer, the event is not raised.

    }
       
</script>
