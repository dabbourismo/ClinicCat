using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace ClinicCat.DataAccessLayer
{
    public class ConnectionSettings
    {
        //public static string Connection = @"Data Source=ClownClubDB.db;MultipleActiveResultSets=true;";
        public static string connection = @"Data Source=DESKTOP-T5QPJG2;Initial Catalog=ClinicCatDB;Integrated Security=True;MultipleActiveResultSets=True";
        public static SqlConnection cn = new SqlConnection();
    }
}
