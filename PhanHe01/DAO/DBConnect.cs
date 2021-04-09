using System;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;
namespace DAO
{
    public class DBConnect
    {
        //Connection String
        protected OracleConnection _conn =
            new OracleConnection("Data Source=localhost:1521/xepdb1;Persist Security Info=True;User ID = ot; Password=minhlamv18");
        //Data Source = IP:Port/Database name (SID)
        //UserID = username
        //Password = password
    }
}
