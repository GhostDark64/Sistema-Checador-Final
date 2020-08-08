using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConexionBD;
using EntidadesChecador;
using System.Data;

namespace AccesoDatos
{
    public class APer
    {
        Conexion _conexion;
        public APer()
        {
            _conexion = new Conexion("localhost", "root", "", "Checador", 3306);
        }
        public void EliminarPersonal(string rfc)
        {
            string cadena = string.Format("delete from PERSONAL where RFC = '{0}'", rfc);
            _conexion.EjecutarConsulta(cadena);
        }
        public int ObtenerRfc(string rfc)
        {
            var res = _conexion.Existencia("select count(*) from PERSONAL where RFC='" + rfc + "'");
            return res;
        }
        public void GuardarPersonal(EPer personal)
        {
            if (ObtenerRfc(personal.RFC) == 0)
            {
                string cadena = string.Format("insert into PERSONAL values('{0}','{1}','{2}','{3}','{4}',{5})", personal.RFC, personal.Nombre, personal.ApellidoP, personal.ApellidoM, personal.Fechadenacimiento, personal.Fktipopersonal);
                _conexion.EjecutarConsulta(cadena);
            }
            else
            {
                string cadena = string.Format("update PERSONAL set NOMBRE = '{0}', APELLIDOP = '{1}', APELLIDOM = '{2}', FECHADENACIMIENTO = '{3}', FKTIPOPERSONAL = {4} where RFC = '{5}'", personal.Nombre, personal.ApellidoP, personal.ApellidoM, personal.Fechadenacimiento, personal.Fktipopersonal, personal.RFC);
                _conexion.EjecutarConsulta(cadena);
            }
        }
        public List<EPer> ObtenerListaPersonal(string filtro)
        {
            var list = new List<EPer>();
            string consulta = string.Format("Select * from PERSONAL where RFC like '%{0}%'", filtro);
            var ds = _conexion.ObtenerDatos(consulta, "PERSONAL");
            var dt = ds.Tables[0];

            foreach (DataRow row in dt.Rows)
            {
                var personal = new EPer
                {
                    RFC = row["RFC"].ToString(),
                    Nombre = row["NOMBRE"].ToString(),
                    ApellidoP = row["APELLIDOP"].ToString(),
                    ApellidoM = row["APELLIDOM"].ToString(),
                    Fechadenacimiento = Convert.ToDateTime(row["FECHADENACIMIENTO"].ToString()),
                    Fktipopersonal = Convert.ToInt32(row["FKTIPOPERSONAL"].ToString()),
                };
                list.Add(personal);
            }
            return list;
        }
    }
}
