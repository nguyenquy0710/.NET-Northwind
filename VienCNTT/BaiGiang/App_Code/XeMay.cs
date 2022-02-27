using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for XeMay
/// </summary>
public class XeMay : PTGT
{
    public override void DiChuyen()
    {
        HttpContext.Current.Response.Write(this.SoHieu+
            " Danh vong<br/>"
            );
    }
}