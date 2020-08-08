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
    public class ATP
    {
        Conexion _conexion;
        public ATP()
        {
            _conexion = new Conexion("localhost", "root", "", "Checador", 3306);
        }
        public void EliminarPersona(int idtipopersonal)
        {
            string cadena = string.Format("delete from TIPOPERSONAL where IDTIPOPERSONAL = {0} ", idtipopersonal);
            _conexion.EjecutarConsulta(cadena);
        }
        public void GuardarPersona(ETP persona)
        {
            if (persona.Idtipopersonal == 0)
            {
                string cadena = string.Format("insert into TIPOPERSONAL values(null, '{0}')", persona.Tipo_Personal);
                _conexion.EjecutarConsulta(cadena);
            }
            else
            {
                string cadena = string.Format("update TIPOPERSONAL set TIPO_PERSONAL = '{0}' where IDTIPOPERSONAL = {1}", persona.Tipo_Personal, persona.Idtipopersonal);
                _conexion.EjecutarConsulta(cadena);
            }
        }
        public List<ETP> ObtenerListaPersona(string filtro)
        {
            var list = new List<ETP>();
            string consulta = string.Format("Select * from TIPOPERSONAL where TIPO_PERSONAL like '%{0}%'", filtro);
            var ds = _conexion.ObtenerDatos(consulta, "TIPOPERSONAL");
            var dt = ds.Tables[0];

            foreach (DataRow row in dt.Rows)
            {
                var personal = new ETP
                {
                    Idtipopersonal = Convert.ToInt32(row["IDTIPOPERSONAL"]),
                    Tipo_Personal = row["TIPO_PERSONAL"].ToString(),
                };
                list.Add(personal);
            }
            return list;
        }
    }
}