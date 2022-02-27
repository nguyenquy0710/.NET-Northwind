using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Data.SqlClient;
using System.Configuration;

/// <summary>
/// Summary description for wsTimSP
/// </summary>
[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
// [System.Web.Script.Services.ScriptService]
public class wsTimSP : System.Web.Services.WebService
{

    public wsTimSP()
    {

        //Uncomment the following line if using designed components 
        //InitializeComponent(); 
    }

    [WebMethod]
    public string HelloWorld()
    {
        return "Hello World";
    }
    [WebMethod]
    public int TinhTong(int n)
    {
        var s = 0;
        for (int i = 1; i <= n; i++) s += i;
        return s;
    }
    [WebMethod]
    public string TimHH(int masp)
    {
        using (DBDataContext dc = new DBDataContext())
        {
            var kq = dc.Products.FirstOrDefault(
                x => x.ProductID == masp);
            return string.Format(@"{0} - {1} - {2}",
                kq.ProductID, kq.ProductName, kq.UnitPrice);
        }
    }
    [WebMethod]
    public DataSet LayHHTheoLoai(int maLoai)
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["MyCN"].ConnectionString);
        if (con.State == ConnectionState.Closed)
            con.Open();
        string query = "select * from Products where CategoryID = @maLoai";
        SqlDataAdapter adapter = new SqlDataAdapter(query, con);
        adapter.SelectCommand.Parameters.AddWithValue("@maLoai", maLoai);
        DataSet ds = new DataSet();
        adapter.Fill(ds);
        return ds;
    }
}
