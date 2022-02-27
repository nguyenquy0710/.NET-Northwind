using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class DangKyTK : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnDK_Click(object sender, EventArgs e)
    {
        if (IsPostBack)
        {
            bool isHuman = ExampleCaptcha.Validate(txtCaptcha.Text);
            txtCaptcha.Text = null;
            if (!isHuman)
            {
                h3TB.InnerText = "Sai mã bảo vệ";
                return;
            }
            else
            {
                //neu email hop le:
                if (MyGmail.ValidateEmail(txtEmail.Text.Trim()))
                {
                    Customer cus = new Customer()
                    {
                        CustomerID = txtTenDN.Text,
                        CompanyName = txtTenCT.Text,
                        Address = txtDC.Text,
                        Password = txtMK.Text.ToMD5(),
                        Email = txtEmail.Text,
                        Status = false //tai khoan chua kich hoat.
                    };
                    Customer.Them(cus);
                    //gui email de kich hoat tai khoan:
                    var dl = Request.Url.AbsoluteUri;
                    dl = dl.Substring(0,dl.LastIndexOf('/')+1);
                    dl = dl + "ThongBao.aspx?kh=" + cus.CustomerID;
                    MyGmail.Send(txtEmail.Text.Trim(),
                        "Kich hoat tai khoan", dl, null);
                    h3TB.InnerText = "Đã thêm tài khoản";
                }
            }
        }

    }
}