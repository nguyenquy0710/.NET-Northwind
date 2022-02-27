using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Configuration;

public class DAL
{
    static string ChuoiKN
    {
        get
        {
            return ConfigurationManager.ConnectionStrings["MyCN"].ConnectionString;
        }
    }
    static SqlConnection ketNoi = new SqlConnection(ChuoiKN);
    static private SqlCommand TaoCommand(string query,params object[] thamSo)
    {
        if (ketNoi.State == System.Data.ConnectionState.Closed)
            ketNoi.Open();
        var cmd = new SqlCommand(query, ketNoi);
        //add cac tham so:
        for (var i = 0; i < thamSo.Length - 1; i+=2)
        {
            cmd.Parameters.AddWithValue(thamSo[i].ToString(), thamSo[i + 1]);
        }
        return cmd;
    }
    static public DataTable DocTable(string query,params object[] thamSo)
    {
        var cmd = TaoCommand(query,thamSo);
        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
        DataTable t = new DataTable();
        adapter.Fill(t);
        ketNoi.Close();
        return t;
    }
    static public int ExecuteNonQuery(string query, params object[] thamSo)
    {
        if (ketNoi.State == ConnectionState.Closed)
            ketNoi.Open();
        var cmd = TaoCommand(query, thamSo);
        var kq = cmd.ExecuteNonQuery();
        ketNoi.Close();
        return kq;
    }
    static public object ExecuteScalar(string query, params object[] thamSo)
    {
        if (ketNoi.State == ConnectionState.Closed)
            ketNoi.Open();
        var cmd = TaoCommand(query, thamSo);
        var kq = cmd.ExecuteScalar();
        ketNoi.Close();
        return kq;
    }
}