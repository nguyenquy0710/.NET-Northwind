using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for PTGT
/// </summary>
public abstract class PTGT
{
    public string SoHieu { set; get; }
    //virtual public void DiChuyen()//virtual = khai bao phuong thuc ao.
    //{
    //    HttpContext.Current.Response.Write(this.SoHieu + " di chuyen <br/>");
    //}
    abstract public void DiChuyen();//phuong thuc truu tuong (ko co cai dat)
    
}