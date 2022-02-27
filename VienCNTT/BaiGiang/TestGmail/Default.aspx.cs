using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class TestGmail_Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        var kq = MyGmail.Send("tranvanteo1111@gmail.com", "test", "noi dung gi do", null);
        if (kq) Response.Write("ok");
        else Response.Write("not ok");
    }
}