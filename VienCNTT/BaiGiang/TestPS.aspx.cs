using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class TestPS : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        PhanSo p = new PhanSo(1, 2);
        PhanSo q = new PhanSo(p);
        PhanSo kq = p + q;
    }
}