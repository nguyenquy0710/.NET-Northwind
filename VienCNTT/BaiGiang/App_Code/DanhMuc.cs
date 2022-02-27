using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for DanhMuc
/// </summary>
public class DanhMuc
{
    public int Ma { set; get; }
    public string Ten{ set; get; }
    public static List<DanhMuc> DSDM
    {
        get
        {
            List<DanhMuc> lst = new List<DanhMuc>();
            lst.Add(new DanhMuc()
            {
                Ma = 1,
                Ten = "Tivi"
            });
            lst.Add(new DanhMuc()
            {
                Ma = 2,
                Ten = "Máy tính"
            });
            lst.Add(new DanhMuc()
            {
                Ma = 3,
                Ten = "Điện thoại"
            });
            return lst;
        }
    }
}