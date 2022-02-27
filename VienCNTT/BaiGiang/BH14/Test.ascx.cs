using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class BH14_Test : System.Web.UI.UserControl
{
    //truyen du lieu ra ngoai
    public string NoiDung
    {
        set
        {
            txtND.Text = value;
        }
        get
        {
            return txtND.Text;
        }
    }
    //truyen su kien ra ngoai:
    public event EventHandler NutDuocClick;
    private void OnNutDuocClick()
    {
        if (NutDuocClick != null) NutDuocClick(btnClick, null);
    }
    protected void Page_Load(object sender, EventArgs e)
    {
    }
    protected void btnClick_Click(object sender, EventArgs e)
    {
        OnNutDuocClick();
    }
    
}