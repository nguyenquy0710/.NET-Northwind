using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for IHinh
/// </summary>
public interface IHinh
{
    string Ten { get; }
    double ChuVi { get; }
    double DienTich();
}