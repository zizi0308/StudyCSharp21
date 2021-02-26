using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.OracleClient;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBConnTestApp
{

    class DBhelper
    {
        public IDbConnection GetDbConnection() // IDbConnection을 구현했으므로 아래 swich문의 case들에 연결할 수 있다.
        {
            IDbConnection dbConn = null;
            string connString = ConfigurationManager.AppSettings["Connection"];
            var DBType = ConfigurationManager.AppSettings["DbType"];
            switch (DBType)
            {
                case "SQLServer":
                    dbConn = new SqlConnection(connString);
                    break;
                case "Oracle":
                    dbConn = new OracleConnection(connString);
                    break;
                case "OleDB":
                    dbConn = new OleDBConnection(connString);
                    break;
                default:
                    break;
            }
            return dbConn;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
