<%@ Application Language="C#" %>
<%@ Import Namespace="System.IO" %>
<%@ Import Namespace="System.Web.Routing" %>
<script RunAt="server">
    void DangKyRoute(RouteCollection r)
    {
        r.MapPageRoute("sanpham", "sanpham", "~/SanPham.aspx");
        r.MapPageRoute("lienhe", "lienhe", "~/LienHe.aspx");
        r.MapPageRoute("dichvu", "dichvu", "~/DichVu.aspx");
        r.MapPageRoute("tintuc", "tintuc", "~/TinTuc.aspx");
        r.MapPageRoute("gio", "gio", "~/CTGH.aspx");
        r.MapPageRoute("dangky", "dangky", "~/DangKyTK.aspx");
        r.MapPageRoute("hoadon", "hoadon", "~/LuuHoaDon.aspx");

        r.MapPageRoute("sptheodm", "sanpham/cat/{cat}", "~/SanPham.aspx");
        r.MapPageRoute("sptheotk", "sanpham/tk/{tk}", "~/SanPham.aspx");
        r.MapPageRoute("chitiet", "chitiet/{id}", "~/CTSP.aspx");
    }
    void Application_Start(object sender, EventArgs e)
    {
        DangKyRoute(RouteTable.Routes);
        
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
        Session["gh"] = new Gio();
        //thong ke:
        if (Application["online"] == null)
            Application["online"] = 0;
        Application["online"] = int.Parse(Application["online"].ToString()) + 1;
        Application["sum"] = int.Parse(Application["sum"].ToString()) + 1;
        string path = @"~/App_Data/Count.txt";
        path = HttpContext.Current.Server.MapPath(path);
        File.WriteAllText(path, Application["sum"].ToString());
    }

    void Session_End(object sender, EventArgs e)
    {
        //so online giam 1:
        if (Application["online"] != null)
            Application["online"] = int.Parse(Application["online"].ToString()) - 1;
    }
       
</script>
