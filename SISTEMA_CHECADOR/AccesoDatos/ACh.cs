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
    public class ACh
    {
        Conexion _conexion;
        public ACh()
        {
            _conexion = new Conexion("localhost", "root", "", "Checador", 3306);
        }
        /*public void EliminarPersonal(string rfc)
        {
            string cadena = string.Format("delete from PERSONAL where RFC = '{0}'", rfc);
            _conexion.EjecutarConsulta(cadena);
        }*/
        public int ObtenerCheck(int idcheck)
        {
            var res = _conexion.Existencia("select count(*) from CHECADAS where IDCHECK='" + idcheck + "'");
            return res;
        }
        /*public int ObtenerFKRFC(string fkrfc)
        {
            var resQ = _conexion.Existencia("select count(*) from  PERSONAL where RFC= '" + fkrfc + "'");
            return resQ;
        }*/
        public void GuardarCheck(ECh check)
        {
            if (ObtenerCheck(check.Idcheck) == 0)
            {                
                string cadena = string.Format("insert into CHECADAS values('{0}','{1}','{2}','{3}')", check.Idcheck, check.Fecha, check.Hora, check.FK_RFC);
                _conexion.EjecutarConsulta(cadena);
            }
            else
            {
                
            }
        }        
    }
}
