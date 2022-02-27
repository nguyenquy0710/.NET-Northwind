using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class LenhLap : System.Web.UI.Page
{
    string[] hotens = { "tuan", "binh", "thanh", "nham", "tuyen" };
    protected void Page_Load(object sender, EventArgs e)
    {
        #region su dung lenh while:
        //liet ke nhung ten bat dau bang chu n:
        //int i = 0;
        //while (i < hotens.Length)
        //{
        //    //su dung ham substring de lay chuoi con.
        //    if (hotens[i].Substring(0, 1) == "n")
        //        Response.Write(hotens[i] + "<br/>");
        //    i++;
        //}
        #endregion
        #region su dung lenh do...while:
        //liet ke nhung ho ten gom it nhat 5 ki tu:
        int i = 0;
        do{
            if (hotens[i].Length > 4) Response.Write(hotens[i] + "<br/>");
            i++;
        }while(i<hotens.Length);
        #endregion
    }
}