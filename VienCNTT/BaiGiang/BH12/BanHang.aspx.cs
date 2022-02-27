using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class BH12_BanHang : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!this.IsPostBack)
        {
            //tao gioa hang:
            if (Session["gh"] == null)
                Session["gh"] = new Gio();
            Gio g = Session["gh"] as Gio;
          

            LoadDSDM();
            //load tat ca hang hoa:
            LoadTatCaHH();
            //load hang hoa theo ten:
            if (Request.QueryString["ten"] != null)
            {
                LoadHangHoaTheoTen(Request.QueryString["ten"]);
            }
        }
        //load hang hoa theo ma danh muc
        //duoc gui toi trong query string:
        if (Request.QueryString["dm"] != null)
        {
            int maDM = int.Parse(Request.QueryString["dm"]);
            LoadHangHoa(maDM);
        }
    }

    protected void Page_PreRender(object sender, EventArgs e)
    {
        //thuc hien cong viec load gio hang o day:
        //load gio hang o day vi: PRERENDER CHAY SAU CLICK!
        if (Session["gh"] != null)
        {
            Gio g = Session["gh"] as Gio;
            LoadGioHang(g);
        }
    }

    protected void btnMua_Click(object sender, EventArgs e)
    {
        Button btn = sender as Button;
        int maHH = int.Parse(btn.CommandArgument);
        //tham chieu den gio hang de mua hang:
        Gio g = Session["gh"] as Gio;
        var h = Hang.Tim(maHH);
        if (h != null)
        {
            //g.Mua(h, 1);

        }
    }
    private void LoadHangHoaTheoTen(string tenHH)
    {
        grvHH.DataSource = Hang.LayDSHH(tenHH);
        grvHH.DataBind();
    }

    private void LoadTatCaHH()
    {
        grvHH.DataSource = Hang.LayDSHH();
        grvHH.DataBind();
    }

    private void LoadDSDM()
    {
        rptDM.DataSource = DanhMuc.DSDM;
        rptDM.DataBind();
    }
    protected void lbtnDM_Click(object sender, EventArgs e)
    {
        LinkButton lbtn = sender as LinkButton;
        int maDM = int.Parse(lbtn.CommandArgument);
        //gui ma danh muc den trang phu trach
        //viec load hang hoa theo danh muc:
        Response.Redirect("BanHang.aspx?dm=" + maDM);
    }

    private void LoadHangHoa(int maDM)
    {
        grvHH.DataSource = Hang.LayDSHH(maDM);
        grvHH.DataBind();
    }
    protected void btnTim_Click(object sender, EventArgs e)
    {
        Response.Redirect("BanHang.aspx?ten=" + txtTim.Text);

    }
    

    private void LoadGioHang(Gio gh)
    {
        grvGH.DataSource = gh;
        grvGH.DataBind();
        //load tong tien:
        spnTT.InnerText = gh.TongTien + " VND";
    }
    protected void btnXoa_Click(object sender, EventArgs e)
    {
        Button btn = sender as Button;
        int maHH = int.Parse(btn.CommandArgument);
        Gio g = Session["gh"] as Gio;
        g.Xoa(maHH);
    }
    protected void btnXoaHet_Click(object sender, EventArgs e)
    {
        Gio g = Session["gh"] as Gio;
        g.Xoa();
     
    }
   
}