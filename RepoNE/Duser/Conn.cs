using System.Data.SqlClient;

namespace RepoNE
{
    public static class Conn
    {
        
        public static SqlConnection GetCon()
        {
            SqlConnection con = new SqlConnection("server=194.255.108.50;database=dbnikon_web115_9;uid=nikon_web115_9;pwd=eG6d4TQ3;MultipleActiveResultSets=True");
            return con;
        }

        public static SqlConnection CreateConnection()
        {
            var cn = GetCon();
            cn.Open();
            return cn;
        }
    }
}
