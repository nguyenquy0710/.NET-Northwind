using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for IGio
/// </summary>
public interface IGio
{
    double TongTien { get; }
    int SoMatHang { get; }
    void Mua(Product h, int sl);
    void CapNhat(int ma, int sl);
    void Xoa(int ma);
    void Xoa();
}