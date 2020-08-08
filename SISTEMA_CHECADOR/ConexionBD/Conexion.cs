using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ConexionBD
{
    public class Conexion
    {
        MySqlConnection _conn;
        public Conexion(string server, string user, string password, string database, uint port)
        {
            MySqlConnectionStringBuilder cadena = new MySqlConnectionStringBuilder();
            cadena.Server = server;
            cadena.UserID = user;
            cadena.Password = password;
            cadena.Database = database;
            cadena.Port = port;


            _conn = new MySqlConnection(cadena.ToString());
        }
        public void EjecutarConsulta(string cadena)
        {
            _conn.Open();
            MySqlCommand cnn = new MySqlCommand(cadena, _conn);
            cnn.ExecuteNonQuery();
            _conn.Close();
        }
        public DataSet ObtenerDatos(string cadena, string tabla)
        {
            var ds = new DataSet();
            MySqlDataAdapter da = new MySqlDataAdapter(cadena, _conn);
            da.Fill(ds, tabla);

            return ds;
        }
        public int Existencia(string cadena)
        {
            var res = 0;
            var inserta = new MySqlCommand(cadena, _conn);
            try
            {
                _conn.Open();
                res = int.Parse(inserta.ExecuteScalar().ToString());
                _conn.Close();
            }
            catch (System.Exception)
            {

                _conn.Close();
            }
            return res;
        }
    }
}