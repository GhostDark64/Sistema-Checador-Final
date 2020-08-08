using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDatos;
using EntidadesChecador;

namespace LogicaNegocio
{
    public class LCh
    {
        private ACh _aCh;
        public LCh()
        {
            _aCh = new ACh();
        }
        /*public void EliminarPersonal(string rfc)
        {
            _aPer.EliminarPersonal(rfc);
        }*/
        public void GuardarCheck(ECh check)
        {
            _aCh.GuardarCheck(check);
        }
        /*public List<EPer> ObtenerListaPersonal(string filtro)
        {
            var list = new List<EPer>();
            list = _aPer.ObtenerListaPersonal(filtro);
            return list;
        }*/
    }
}
