using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


public class TrangQuanTri : System.Web.UI.Page
{
    protected void Page_PreInit(object sender, EventArgs e)
    {
        if (this.NhanVien == null)
        {
            //luu url ma admin muon toi:
            Session["returnurl"] = this.TrangHienTai;
            Response.Redirect("DangNhap.aspx");
        }
        else if ((NhanVien.RoleID != 1)
            && (this.Quyen == null || !(bool)this.Quyen.AUSelect)
            && (!this.TrangHienTai.Equals("TaiKhoan.aspx"))
            )
        {
            Response.Redirect("ThongBao.aspx");
        }
    }
    public Employee NhanVien
    {
        get
        {
            if (Session["nv"] == null) return null;
            return Session["nv"] as Employee;
        }
    }
    public string TrangHienTai
    {
        get
        {
            //lay ten trang web hien tai:
            var site = Request.Url.ToString();
            var slash = site.LastIndexOf('/');
            return site.Substring(slash + 1);
        }
    }
    public Authorization Quyen
    {
        get
        {
            if (this.NhanVien == null) return null;

            using (DBDataContext dc = new DBDataContext())
            {
                return dc.Authorizations.FirstOrDefault(
                    x => x.RoleID == this.NhanVien.RoleID
                    && x.PageFile == this.TrangHienTai);
            }
        }
    }

    static public void ApDungPhanQuyen(Control ctrl, Authorization q)
    {
        foreach (Control c in ctrl.Controls)
        {
            if (c is Button)
            {
                var t = (c as Button);
                if (t.CommandName.Contains("them"))
                    t.Enabled = (bool)q.AUInsert;
                if (t.CommandName.Contains("sua"))
                    t.Enabled = (bool)q.AUUpdate;
                if (t.CommandName.Contains("xoa"))
                    t.Enabled = (bool)q.AUDelete;
            }
            if (c is LinkButton)
            {
                var t = (c as LinkButton);
                if (t.CommandName.Contains("them"))
                    t.Enabled = (bool)q.AUInsert;
                if (t.CommandName.Contains("sua"))
                    t.Enabled = (bool)q.AUUpdate;
                if (t.CommandName.Contains("xoa"))
                    t.Enabled = (bool)q.AUDelete;
            }
            if (c is ImageButton)
            {
                var t = (c as ImageButton);
                if (t.CommandName.Contains("them"))
                    t.Enabled = (bool)q.AUInsert;
                if (t.CommandName.Contains("sua"))
                    t.Enabled = (bool)q.AUUpdate;
                if (t.CommandName.Contains("xoa"))
                    t.Enabled = (bool)q.AUDelete;
            }
            ApDungPhanQuyen(c, q);
        }
    }


}