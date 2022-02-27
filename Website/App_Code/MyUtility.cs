using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

/// <summary>
/// Summary description for MyUtility
/// </summary>
public static class MyUtility
{//ham cua toi
    public static bool TextBoxHopLe(TextBox txt, out string kq)
    {
        kq = string.Empty;
        if (!string.IsNullOrEmpty(txt.Text) &&
            !string.IsNullOrWhiteSpace(txt.Text))
        {
            kq = txt.Text.Trim();//Trim cat bo cach thua 2 dau
            return true;
        }
        return false;
    }
    public static bool HinhHopLe(FileUpload ful)
    {
        if (ful.HasFile)
        {
            //them hinh
            string[] ds = { "jpg", "gif", "png", "bmp" };
            string extension = ful.FileName.Substring(ful.FileName.LastIndexOf('.') + 1).ToLower();//Substring lay tu dau | LastIndexOf gia tri cuoi cung
            return ds.Contains(extension);
        }
        else
        {
            return false;
        }
    }
    public static bool ChuoiHopLe( string str)
    {

        return !string.IsNullOrEmpty(str) && !string.IsNullOrWhiteSpace(str);
    }
    public static string ToMD5(this string str)
    {
        MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
        byte[] bHash = md5.ComputeHash(Encoding.UTF8.GetBytes(str));
        StringBuilder sbHash = new StringBuilder();
        foreach (byte b in bHash)
            sbHash.Append(String.Format("{0:x2}", b));
        return sbHash.ToString();
    }
}