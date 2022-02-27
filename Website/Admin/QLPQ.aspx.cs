using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

public partial class Admin_QLPQ : TrangQuanTri
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            PL.LoadVuiTro2DDL(ddlPhanQuyen, false);
            PL.LoadTrangWeb2GV(grvDSQuyen);
            LoadQuyen();
            PL.LoadTrangWeb2GV(grvWebPage);
            if (this.NhanVien.RoleID != 1)
                ThucThiQuyen();
        }
    }
    private void ThucThiQuyen()
    {
        //lay cac nut, link tren frmContainer:
        //de hien thuc quyen cho chung.
        MasterPage master = this.Master as MasterPage;
        var frm = master.FindControl("frmContent") as HtmlForm;
        TrangQuanTri.ApDungPhanQuyen(frm, this.Quyen);
    }
    private void LoadQuyen()
    {
        var roleID = int.Parse(ddlPhanQuyen.SelectedValue);
        foreach (GridViewRow r in grvDSQuyen.Rows)
        {
            //lay trang web
            var trangWeb = r.Cells[0].Text;
            CheckBox chkXem = r.FindControl("chkXem") as CheckBox;
            CheckBox chkThem = r.FindControl("chkThem") as CheckBox;
            CheckBox chkSua = r.FindControl("chkSua") as CheckBox;
            CheckBox chkXoa = r.FindControl("chkXoa") as CheckBox;

            var kq = Authorization.Tim(trangWeb, roleID);
            if (kq != null)
            {
                chkXem.Checked = (bool)kq.AUSelect;
                chkXoa.Checked = (bool)kq.AUDelete;
                chkSua.Checked = (bool)kq.AUUpdate;
                chkThem.Checked = (bool)kq.AUInsert;
            }
            else
            {
                chkSua.Checked = chkThem.Checked = chkXem.Checked = chkXoa.Checked = false;
            }
        }

    }
    protected void ddlPhanQuyen_SelectedIndexChanged(object sender, EventArgs e)
    {
        LoadQuyen();
    }
    protected void btnHuy_Click(object sender, EventArgs e)
    {
        var r = (sender as Button).Parent.Parent;
        CheckBox chkXem = r.FindControl("chkXem") as CheckBox;
        CheckBox chkThem = r.FindControl("chkThem") as CheckBox;
        CheckBox chkSua = r.FindControl("chkSua") as CheckBox;
        CheckBox chkXoa = r.FindControl("chkXoa") as CheckBox;
        chkSua.Checked = chkThem.Checked = chkXem.Checked = chkXoa.Checked = false;
    }
    protected void btnChon_Click(object sender, EventArgs e)
    {
        var r = (sender as Button).Parent.Parent;
        CheckBox chkXem = r.FindControl("chkXem") as CheckBox;
        CheckBox chkThem = r.FindControl("chkThem") as CheckBox;
        CheckBox chkSua = r.FindControl("chkSua") as CheckBox;
        CheckBox chkXoa = r.FindControl("chkXoa") as CheckBox;
        chkSua.Checked = chkThem.Checked = chkXem.Checked = chkXoa.Checked = true;
    }
    protected void btnPQ_Click(object sender, EventArgs e)
    {
        var roleID = int.Parse(ddlPhanQuyen.SelectedValue);
        foreach (GridViewRow r in grvDSQuyen.Rows)
        {
            //lay trang web
            var trangWeb = r.Cells[0].Text;
            CheckBox chkXem = r.FindControl("chkXem") as CheckBox;
            CheckBox chkThem = r.FindControl("chkThem") as CheckBox;
            CheckBox chkSua = r.FindControl("chkSua") as CheckBox;
            CheckBox chkXoa = r.FindControl("chkXoa") as CheckBox;
            Authorization au = new Authorization()
            {
                RoleID = roleID,
                PageFile = trangWeb,
                AUSelect = chkXem.Checked,
                AUUpdate = chkSua.Checked,
                AUDelete = chkXoa.Checked,
                AUInsert = chkThem.Checked,
            };
            var kq = Authorization.Tim(trangWeb, roleID);
            if (kq == null)
            {
                Authorization.Them(au);
            }
            else
            {
                Authorization.Sua(au);
            }
        }
        WebMsgBox.Show("Phân quyền thành công!");
    }
    protected void btnOK_Click(object sender, EventArgs e)
    {
        //lay su dieu khien
        var r = (sender as Button).Parent.Parent;
        Label lblMoTa = r.FindControl("lblMoTa") as Label;
        Label lblNamePage = r.FindControl("lblNamePage") as Label;
        TextBox txtMoTa = r.FindControl("txtMoTa") as TextBox;
        Button btnOK = r.FindControl("btnOK") as Button;
        Button btnSua = r.FindControl("btnSua") as Button;
        //xu ly su kien
        if (!string.IsNullOrEmpty(txtMoTa.Text) && !string.IsNullOrWhiteSpace(txtMoTa.Text))
        {
            WebPage wp = new WebPage() {
                FileName=btnSua.CommandArgument,
                Description=txtMoTa.Text,
            };
            WebPage.Sua(wp);
        }
        //an hien nhung gi can thiet
        lblMoTa.Visible = btnSua.Visible = true;
        txtMoTa.Visible = btnOK.Visible = false;
        PL.LoadTrangWeb2GV(grvWebPage);
        PL.LoadTrangWeb2GV(grvDSQuyen);
    }
    protected void btnSua_Click(object sender, EventArgs e)
    {
        //lay su dieu khien
        var r = (sender as Button).Parent.Parent;
        Label lblMoTa = r.FindControl("lblMoTa") as Label;
        TextBox txtMoTa = r.FindControl("txtMoTa") as TextBox;
        Button btnOK = r.FindControl("btnOK") as Button;
        Button btnSua = r.FindControl("btnSua") as Button;
        //an va hien nhung the can thiet
        lblMoTa.Visible = btnSua.Visible = false;
        txtMoTa.Visible = btnOK.Visible = true;
    }

    //them trang moi vao danh muc quan ly
    protected void btnThem_Click(object sender, EventArgs e)
    {
        pnlThemPage.Visible = true;
    }
    protected void btnThemOK_Click(object sender, EventArgs e)
    {
        //lay data nhap
        if (string.IsNullOrEmpty(txtThemNamePage.Text) || string.IsNullOrWhiteSpace(txtThemNamePage.Text) || string.IsNullOrEmpty(txtThemMoTa.Text) || string.IsNullOrWhiteSpace(txtThemMoTa.Text))
        {
            WebMsgBox.Show("Tên trang web hoặc Mô tả trang web không phải là nội dung trắng.");
            btnThemHuy_Click(null, null);
        }
        WebPage wp = new WebPage()
        {
            FileName = txtThemNamePage.Text,
            Description = txtThemMoTa.Text,
        };
        WebPage.Them(wp);
        PL.LoadTrangWeb2GV(grvWebPage);
        PL.LoadTrangWeb2GV(grvDSQuyen);
        pnlThemPage.Visible = false;
    }
    protected void btnThemHuy_Click(object sender, EventArgs e)
    {
        txtThemMoTa.Text = string.Empty;
        txtThemNamePage.Text = string.Empty;
        pnlThemPage.Visible = false;
    }
    protected void btnXoa_Click(object sender, EventArgs e)
    {
        var kq = WebPage.Tim((sender as Button).CommandArgument);
        if(kq!=null)
        {
            WebPage.Xoa(kq.FileName);
            PL.LoadTrangWeb2GV(grvWebPage);
            PL.LoadTrangWeb2GV(grvDSQuyen);
        }
    }
}