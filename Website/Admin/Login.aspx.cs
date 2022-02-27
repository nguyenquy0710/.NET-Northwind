using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_Login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["nv"] != null)
            Response.Redirect("~/admin");
    }
    protected void btnLogin_Click(object sender, EventArgs e)
    {
        string user, pass;
        if (MyUtility.TextBoxHopLe(txtUser, out user))
        {
            if (MyUtility.TextBoxHopLe(txtPass, out pass))
            {
                var kq = Employee.Tim(user.Trim()); //gọt bỏ đi những khoảng cách dư thừa
                if (kq != null)
                    if (kq.Password.Equals(MyUtility.ToMD5(pass)))
                    {
                        //dang nhao thanh cong
                        //lu session lai
                        //tam thoi:
                        Session["nv"] = kq;
                        if (Session["returnurl"] != null)
                            Response.Redirect(Session["returnurl"].ToString());
                        else
                            Response.Redirect("~/admin");
                    }
            }
        }
        WebMsgBox.Show("Tên đăng nhâp hoặc Mật khẩu không chính xác!");
    }
    protected void hplResetPass_Click(object sender, EventArgs e)
    {

    }
    protected void hplRegister_Click(object sender, EventArgs e)
    {
        pnlRgister.Visible = true;
    }
    protected void btnHuyDangKy_Click(object sender, EventArgs e)
    {
        pnlRgister.Visible = false;
    }
    protected void btnAddDangKy_Click(object sender, EventArgs e)
    {
        if (!txtPassWord.Text.Equals(txtRePassWord.Text))
        {
            lblRePassWord.Visible = true;
            return;
        }
        else
        {
            lblRePassWord.Visible = false;
        }
        Employee emp = new Employee()
        {
            UserName = txtUserName.Text,
            Password = MyUtility.ToMD5(txtPassWord.Text),
            FirstName = txtFistName.Text,
            LastName = txtLastName.Text,
            Country = txtCountry.Text,
            HomePhone = txtPhone.Text,
            Address = txtDiaChi.Text,
            Notes = txtNote.Text,
            RoleID = int.Parse("2"),
            //BirthDate = txtNgaySinh.Text.ToString(),
            Status = false,
        };
        if (MyUtility.HinhHopLe(fulAvt))
        {
            emp.Photo = fulAvt.FileName;
            string path = "~/Image/Avatar/" + emp.Photo;
            path = Server.MapPath(path);//doi duong dan logic thanh duong dan vat ly => luu phuong thuc co san thanh server
            fulAvt.SaveAs(path);
            //load hinh
            imgHinh.ImageUrl = emp.DuongDanHinh;
        }
        Employee.Them(emp);
        MyGmail.Send("nguyenquy.1096@gmail.com","Phân Quyền Cho Tài Khoản Nhân Viên", txtFistName.Text+txtLastName.Text+"đã đăng ký làm nhân viên của bạn. Bạn hãy cấp quyền cho bạn ấy đi nào!", null);
        WebMsgBox.Show("Đăng Ký thành công!");
        btnHuyDangKy_Click(null, null);
    }
}