using Oracle.ManagedDataAccess.Client;
using Oracle.ManagedDataAccess.Types;
namespace EWalletSystem
{
    public static class Db
    {
        public static string ConnectionString = "Data Source=localhost:1521/orcl.168.56.1;User Id=scott;Password=SCOTT;";

        public static OracleConnection GetConnection()
        {
            OracleConnection conn = new OracleConnection(ConnectionString);
            conn.Open();   
            return conn;
        }
    }
}