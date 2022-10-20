using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp1
{
    class DBUtils
    {
        public static MySqlConnection GetDBConnection()
        {
            string host = "localhost";
            int port = 3306;
            string database = "xuanhoang";
            string username = "root";
            string password = "dreambig1234";

            return DBMySQLUtils.GetDBConnection(host, port, database, username, password);
        }

    }
}

