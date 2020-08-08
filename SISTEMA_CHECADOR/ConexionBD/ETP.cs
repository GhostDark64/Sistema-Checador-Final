using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConexionBD
{
    class ETP
    {
        private int idpersonal;
        private string nombre;

        public int IdPersonal { get => idpersonal; set => idpersonal = value; }
        public string Nombre { get => nombre; set => nombre = value; }
    }
}
