using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
using MySql.Data.MySqlClient;

namespace SBPA
{
    internal class Conexion
    {
        string usuario, servidor, db, cadena;
        MySqlConnection con;
        public Conexion()
        {
            usuario = "root";
            servidor = "127.0.0.1";
            db = "LatamGames";
            cadena = "server=" + servidor + ";uid=" +
                usuario + ";" + "database=" + db;

            con = new MySqlConnection(cadena);
        }

        public MySqlConnection Conectar()
        {
            return con;
        }
    }
}
