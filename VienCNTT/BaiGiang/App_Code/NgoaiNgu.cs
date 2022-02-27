using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


public class NgoaiNgu
{
    public int Ma { set; get; }
    public string Ten { set; get; }

    public static List<NgoaiNgu> DSNN
    {
        get
        {
            List<NgoaiNgu> lst = new List<NgoaiNgu>();
            lst.Add(new NgoaiNgu()
            {
                Ma = 1,
                Ten="Tieng Lao"
            });
            lst.Add(new NgoaiNgu()
            {
                Ma = 2,
                Ten = "Tieng Phap"
            });
            lst.Add(new NgoaiNgu()
            {
                Ma = 3,
                Ten = "Tieng Campuchia"
            });
            lst.Add(new NgoaiNgu()
            {
                Ma = 4,
                Ten = "Tieng Thai"
            });
            return lst;
        }
    }
}