using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class BH5_SuDungDelegate : System.Web.UI.Page
{
    //hay xay dung 1 delegate phu phop
    //voi ham sqrt.
    public delegate double CBHDelegate(double d);
    //khai bao kieu delegate:
    public delegate void TestDelegate();
    //ham co signature phu phop voi delegate
    void Test()
    {
        Response.Write("test delegate");
    }
    void OtherTest()
    {
        Response.Write("another test delegate");
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        //khai bao doi tuong co kieu delegate:
        TestDelegate t = Test;
        //delegate co kha nang chua CAC methods
        //co cung signature voi no.
        t += OtherTest;
        //t -= Test;
        //t -= OtherTest;
        //thi hanh delegate: can kiem tra xem no co chua cac method ko?
        //if(t != null)t();
        CBHDelegate can = Math.Sqrt;
        Response.Write(can(15));
    }
}