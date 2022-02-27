using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for WebPage
/// </summary>
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
    public static WebPage Tim(string filename)
    {
        return dc.WebPages.FirstOrDefault(x => x.FileName.ToLower().Equals(filename.ToLower()));
    }
    public static void Sua(WebPage wp)
    {
        var kq = Tim(wp.FileName);
        if (kq != null)
        {
            kq.FileName = wp.FileName;
            kq.Description = wp.Description;
            dc.SubmitChanges();
        }
    }
    public static void Them(WebPage wp)
    {
        dc.WebPages.InsertOnSubmit(wp);
        dc.SubmitChanges();
    }
    public static void Xoa(string FileName)
    {
        var kq = Tim(FileName);
        if(kq!=null)
        {
            dc.WebPages.DeleteOnSubmit(kq);
            dc.SubmitChanges();
        }
    }
}