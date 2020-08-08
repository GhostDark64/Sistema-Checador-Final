using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EntidadesChecador;
using LogicaNegocio;

namespace SISTEMA_CHECADOR
{
    public partial class Checador : Form
    {
        private LCh _lCh;
        private ECh _eCh;

        private bool _isEnablebinding = false;
        public Checador()
        {
            InitializeComponent();
            _lCh = new LCh();
            _eCh = new ECh();
            _isEnablebinding = true;
            BindingCheck();
        }
        public Checador(ECh check)
        {
            _lCh = new LCh();
            _eCh = new ECh();
            _eCh = check;
            BindingCheckReload();
            _isEnablebinding = true;
            BindingCheck();
        }
        private void BindingCheck()
        {
            if (_isEnablebinding)
            {
                if (_eCh.FK_RFC == _eCh.FK_RFC)
                {
                    _eCh.FK_RFC = _eCh.FK_RFC;
                }

                _eCh.Fecha = DateTime.Now.ToLongDateString();
                _eCh.Hora = DateTime.Now.ToLongTimeString();
                _eCh.FK_RFC = txtRFCcheck.Text;                
            }
        }
        private void BindingCheckReload()
        {
            txtRFCcheck.Text = _eCh.FK_RFC;
        }
        private void Add()
        {
            _lCh.GuardarCheck(_eCh);
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            try
            {
                BindingCheck();
                Add();
                txtRFCcheck.Clear();
                MessageBox.Show("Bievenido");
            }
            catch (Exception)
            {

            }
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblFecha.Text = DateTime.Now.ToLongDateString();
            lblHora.Text = DateTime.Now.ToLongTimeString();
        }
    }
}
