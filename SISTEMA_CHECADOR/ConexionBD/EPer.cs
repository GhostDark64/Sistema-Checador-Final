using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConexionBD
{
    public class EPer
    {
        private string rfc;
        private string nombre;
        private string apellidoP;
        private string apellidoM;
        private DateTime fechadenacimiento;
        private int fktipopersonal;

        public string RFC { get => rfc; set => rfc = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string ApellidoP { get => apellidoP; set => apellidoP = value; }
        public string ApellidoM { get => apellidoM; set => apellidoM = value; }
        public DateTime FechadeNacimiento { get => fechadenacimiento; set => fechadenacimiento = value; }
        public int Fktipopersonal { get => fktipopersonal; set => fktipopersonal = value; }
    }
}
