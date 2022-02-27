using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_QLPQ : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        h3TB.InnerText = string.Empty;
        if (!IsPostBack)
        {
            PL.LoadVaiTro2DDL(ddlVT);
            PL.LoadTrangWeb2GV(grvTW);
            LoadQuyen();
        }
    }
    protected void btnQP_Click(object sender, EventArgs e)
    {
        var roleID = int.Parse(ddlVT.SelectedValue);
        foreach (GridViewRow r in grvTW.Rows)
        {
            //lay trang web:
            var tw = r.Cells[0].Text;
            CheckBox chkXem = r.FindControl("chkXem") as CheckBox;
            CheckBox chkThem = r.FindControl("chkThem") as CheckBox;
            CheckBox chkSua = r.FindControl("chkSua") as CheckBox;
            CheckBox chkXoa = r.FindControl("chkXoa") as CheckBox;
            Authorization au = new Authorization()
            {
                RoleID = roleID,
                PageFile = tw,
                AUSelect = chkXem.Checked,
                AUInsert = chkThem.Checked,
                AUUpdate = chkSua.Checked,
                AUDelete = chkXoa.Checked
            };
            var kq = Authorization.Tim(tw, roleID);
            if (kq == null)
            {
                Authorization.Them(au);
            }
            else
            {
                Authorization.Sua(au);
            }
        }
        h3TB.InnerText = "Phân quyền thành công.";
    }
    protected void btnChonHet_Click(object sender, EventArgs e)
    {
        Chon(true);
    }
    protected void btnHuyChon_Click(object sender, EventArgs e)
    {
        Chon(false);
    }

    private void Chon(bool p)
    {
        foreach (GridViewRow r in grvTW.Rows)
        {
            CheckBox chkXem = r.FindControl("chkXem") as CheckBox;
            CheckBox chkThem = r.FindControl("chkThem") as CheckBox;
            CheckBox chkSua = r.FindControl("chkSua") as CheckBox;
            CheckBox chkXoa = r.FindControl("chkXoa") as CheckBox;
            chkSua.Checked
            = chkThem.Checked
            = chkXoa.Checked
            = chkXem.Checked = p;
        }
    }

    protected void lbtnChon_Click(object sender, EventArgs e)
    {
        var r = (sender as LinkButton).Parent.Parent;
        CheckBox chkXem = r.FindControl("chkXem") as CheckBox;
        CheckBox chkThem = r.FindControl("chkThem") as CheckBox;
        CheckBox chkSua = r.FindControl("chkSua") as CheckBox;
        CheckBox chkXoa = r.FindControl("chkXoa") as CheckBox;
        chkSua.Checked
        = chkThem.Checked
        = chkXoa.Checked
        = chkXem.Checked = true;
    }
    private void LoadQuyen()
    {
        var roleID = int.Parse(ddlVT.SelectedValue);
        foreach (GridViewRow r in grvTW.Rows)
        {
            CheckBox chkXem = r.FindControl("chkXem") as CheckBox;
            CheckBox chkThem = r.FindControl("chkThem") as CheckBox;
            CheckBox chkSua = r.FindControl("chkSua") as CheckBox;
            CheckBox chkXoa = r.FindControl("chkXoa") as CheckBox;

            var tw = r.Cells[0].Text;
            var kq = Authorization.Tim(tw, roleID);
            if (kq != null)
            {
                chkXem.Checked = (bool)kq.AUSelect;
                chkThem.Checked = (bool)kq.AUInsert;
                chkXoa.Checked = (bool)kq.AUDelete;
                chkSua.Checked = (bool)kq.AUUpdate;
            }
            else
            {
                chkSua.Checked
                   = chkThem.Checked
                   = chkXoa.Checked
                   = chkXem.Checked = false;
            }
        }
    }
    protected void ddlVT_SelectedIndexChanged(object sender, EventArgs e)
    {
        LoadQuyen();
    }
}