using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDatos;
using EntidadesChecador;

namespace LogicaNegocio
{
    public class LTP
    {
        private ATP _aTP;
        public LTP()
        {
            _aTP = new ATP();
        }
        public void EliminarTipopersona(int idtipopersonal)
        {
            _aTP.EliminarPersona(idtipopersonal);
        }
        public void GuardarTipopersona(ETP persona)
        {
            _aTP.GuardarPersona(persona);
        }
        public List<ETP> ObtenerListaTipopersona(string filtro)
        {
            var list = new List<ETP>();
            list = _aTP.ObtenerListaPersona(filtro);
            return list;
        }
    }
}
