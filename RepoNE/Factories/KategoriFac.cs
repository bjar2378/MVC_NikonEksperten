using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace RepoNE
{
    public class KategoriFac : AutoFac<Kategori>
    {
        Mapper<Kategori> mapper = new Mapper<Kategori>();

        public List<Kategori> GetAllOrderList()
        {
            using (var cmd = new SqlCommand("SELECT * FROM Kategori", Conn.CreateConnection()))
            {
                return mapper.MapList(cmd.ExecuteReader());
            }
        }
    }
}
