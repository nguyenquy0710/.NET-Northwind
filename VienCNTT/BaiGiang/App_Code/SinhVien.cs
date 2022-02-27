using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for SinhVien
/// </summary>
public class SinhVien
{
    public string Ten { set; get; }
    public List<string> dshpNo = new List<string>();
    //public void DangKy(Truong t)
    //{
    //    //t.MoLop += XuLy;
    //    //su kien mo lop da duoc hien thuc theo huong "Noi bo"
    //}

    public void XuLy(Truong t)
    {
        foreach (string hp in this.dshpNo)
            if (t.dshpMo.Contains(hp.ToLower()))
                HttpContext.Current.Response
                    .Write(Ten + " dang ky hoc phan " + hp+"<br/>");
    }
}