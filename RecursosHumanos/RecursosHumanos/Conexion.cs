using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace RecursosHumanos
{
    class Conexion
    {
        public static SqlConnection Conectar()
        {
            SqlConnection conn = new SqlConnection("Data Source=DMORILLO\\MORILLOSQL;Initial Catalog=RecursosHumanos;Integrated Security=True");
            conn.Open();
            return conn;
        }
    }
}
