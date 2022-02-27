using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


public partial class WebPage
{
    static private DBDataContext dc = new DBDataContext();
    static public List<WebPage> DSTW
    {
        get
        {
            return dc.WebPages.ToList();
        }
    }
}