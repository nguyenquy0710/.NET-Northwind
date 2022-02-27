using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for OTo
/// </summary>
public class OTo:PTGT
{
    public override void DiChuyen()
    {
        HttpContext.Current.Response.Write(this.SoHieu+" Chay tren bo<br/>");
    }
}