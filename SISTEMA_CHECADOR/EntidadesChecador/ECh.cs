using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesChecador
{
    public class ECh
    {
        private int idcheck;
        private string fecha;
        private string hora;
        private string fkrfc;

        public int Idcheck { get => idcheck; set => idcheck = value; }
        public string Fecha { get => fecha; set => fecha = value; }
        public string Hora { get => hora; set => hora = value; }
        public string FK_RFC { get => fkrfc; set => fkrfc = value; }
    }
}
