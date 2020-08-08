using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDatos;
using EntidadesChecador;

namespace LogicaNegocio
{
    public class LPer
    {
        private APer _aPer;
        public LPer()
        {
            _aPer = new APer();
        }
        public void EliminarPersonal(string rfc)
        {
            _aPer.EliminarPersonal(rfc);
        }
        public void GuardarPersonal(EPer personal)
        {
            _aPer.GuardarPersonal(personal);
        }
        public List<EPer> ObtenerListaPersonal(string filtro)
        {
            var list = new List<EPer>();
            list = _aPer.ObtenerListaPersonal(filtro);
            return list;
        }
    }
}
