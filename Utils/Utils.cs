using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace MoveLegRef.Utils
{
     public static class Utils
    {
        public static readonly SqlConnectionStringBuilder GlobalConnectionString = BuildDBString();
         // $@"Server=HP\MSSQLSERVER_DEV; Database=DB_MoveLeg; User Id=sa;Password=arkus@123;"
        private static SqlConnectionStringBuilder BuildDBString()
        {
            SqlConnectionStringBuilder stringBuilder = new SqlConnectionStringBuilder();

            stringBuilder.DataSource = @"HP\MSSQLSERVER_DEV";
            stringBuilder.InitialCatalog = "DB_MoveLeg";
            stringBuilder.UserID = "sa";
            stringBuilder.Password = "arkus@123";

            return stringBuilder;
        }
    }
}
