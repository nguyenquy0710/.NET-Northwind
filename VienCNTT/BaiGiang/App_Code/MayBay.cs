using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for MayBay
/// </summary>
public class MayBay:PTGT
{
    public override void DiChuyen()
    {
        HttpContext.Current.Response.Write(this.SoHieu+" Bay<br/>");
    }
}