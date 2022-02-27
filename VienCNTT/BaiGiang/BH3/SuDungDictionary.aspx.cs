using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class BH3_SuDungDictionary : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        SuDungDic();
    }
    void SuDungDic()
    {
        //khai bao:
        Dictionary<int, string> dic = new Dictionary<int, string>();
        //bo sung phan tu:
        dic.Add(1, "Tran Van Tuan");
        dic.Add(2, "Le Lang Thang");
        dic.Add(3, "Ly Van Kiet");
        //xoa:
        dic.Remove(10);
        //duyet tren dic:
        foreach (var x in dic)
            Response.Write("khoa = " + x.Key + " Gia tri = " + x.Value
                +"<br/>");
    }
}