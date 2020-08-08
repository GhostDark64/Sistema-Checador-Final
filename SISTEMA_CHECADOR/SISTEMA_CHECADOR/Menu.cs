using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SISTEMA_CHECADOR
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void cATALOGOSToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void tipoDePersonalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TipoPersonal TP = new TipoPersonal();
            TP.ShowDialog();
        }

        private void personalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Personal Per = new Personal();
            Per.ShowDialog();
        }

        private void checadasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Checador Ch = new Checador();
            Ch.ShowDialog();
        }

        private void cATALOGOSToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

        }        
    }
}
