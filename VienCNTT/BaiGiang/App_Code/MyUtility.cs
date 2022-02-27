using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


public static class MyUtility
{
    public static bool TextBoxHopLe(TextBox txt, out string kq)
    {

        kq = string.Empty;
        if (!string.IsNullOrEmpty(txt.Text) && !string.IsNullOrWhiteSpace(txt.Text))
        {
            kq = txt.Text.Trim();
            return true;
        }
        return false;
    }
    public static bool HinhHopLe(FileUpload ful)
    {
        if (ful.HasFile)
        {
            string[] ds = { "jpg", "png", "gif", "bmp" };
            string extension = ful.FileName.Substring(ful.FileName.LastIndexOf('.') + 1).ToLower();

            return ds.Contains(extension);
        }
        else
        {
            return false;
        }
    }
    public static bool ChuoiHopLe(string str)
    {
        return !string.IsNullOrWhiteSpace(str)
            && !string.IsNullOrEmpty(str);
    }
    //extension method
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