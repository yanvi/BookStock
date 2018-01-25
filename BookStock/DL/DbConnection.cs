using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace BookStock.DL
{
    public class DbConnection
    {
        public     IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionStr"].ConnectionString);
        public DbConnection()
        {

        }

    }
}