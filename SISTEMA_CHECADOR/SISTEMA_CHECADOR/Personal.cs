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
    public partial class Personal : Form
    {
        private LPer _lPer;
        private EPer _ePer;

        private bool _isEnablebinding = false;
        public Personal()
        {
            InitializeComponent();
            _lPer = new LPer();
            _ePer = new EPer();
            _isEnablebinding = true;
            BindingPersonal();
            btnUpdateP.Enabled = false;
        }
        public Personal(EPer personal)
        {
            _lPer = new LPer();
            _ePer = new EPer();
            _ePer = personal;
            BindingPersonalReload();
            _isEnablebinding = true;
            BindingPersonal();
        }
        private void BindingPersonal()
        {
            if (_isEnablebinding)
            {
                if (_ePer.RFC == _ePer.RFC)
                {
                    _ePer.RFC = _ePer.RFC;
                }
                try
                {
                    _ePer.RFC = txtRFC.Text;
                    _ePer.Nombre = txtName.Text;
                    _ePer.ApellidoP = txtApellidoP.Text;
                    _ePer.ApellidoM = txtApellidoM.Text;
                    _ePer.Fechadenacimiento = Convert.ToDateTime(dtpFechaNac.Text);
                    _ePer.Fktipopersonal = Convert.ToInt32(txtFKTP.Text);
                }
                catch (Exception ex)
                {

                }
            }
        }
        private void BindingPersonalReload()
        {
            txtRFC.Text = _ePer.RFC;
            txtName.Text = _ePer.Nombre;
            txtApellidoP.Text = _ePer.ApellidoP;
            txtApellidoM.Text = _ePer.ApellidoM;
            dtpFechaNac.Text = Convert.ToString(_ePer.Fechadenacimiento);
            txtFKTP.Text = Convert.ToString(_ePer.Fktipopersonal);
        }
        private void BindingPersonal1()
        {
            _ePer.RFC = dtgPer.CurrentRow.Cells["RFC"].Value.ToString();
            _ePer.Nombre = dtgPer.CurrentRow.Cells["NOMBRE"].Value.ToString();
            _ePer.ApellidoP = dtgPer.CurrentRow.Cells["APELLIDOP"].Value.ToString();
            _ePer.ApellidoM = dtgPer.CurrentRow.Cells["APELLIDOM"].Value.ToString();
            _ePer.Fechadenacimiento = Convert.ToDateTime(dtgPer.CurrentRow.Cells["FECHADENACIMIENTO"].Value.ToString());
            _ePer.Fktipopersonal = Convert.ToInt32(dtgPer.CurrentRow.Cells["FKTIPOPERSONAL"].Value.ToString());
        }
        private void Add_Update()
        {
            _lPer.GuardarPersonal(_ePer);
        }
        private void Delete()
        {
            string numero = dtgPer.CurrentRow.Cells["RFC"].Value.ToString();
            _lPer.EliminarPersonal(numero);
        }
        private void SendPer(string filtro)
        {
            dtgPer.DataSource = _lPer.ObtenerListaPersonal(filtro);
        }

        private void Personal_Load(object sender, EventArgs e)
        {
            SendPer("");
        }
        private void btnAddP_Click(object sender, EventArgs e)
        {
            BindingPersonal();
            Add_Update();
            txtRFC.Clear();
            txtName.Clear();
            txtApellidoP.Clear();
            txtApellidoM.Clear();
            txtFKTP.Clear();
            dtpFechaNac.ResetText();
            SendPer("");
        }
        private void btnUpdateP_Click(object sender, EventArgs e)
        {
            BindingPersonal();
            Add_Update();
            txtRFC.Clear();
            txtName.Clear();
            txtApellidoP.Clear();
            txtApellidoM.Clear();
            dtpFechaNac.ResetText();
            txtFKTP.Clear();
            SendPer("");
            btnAddP.Enabled = true;
            btnUpdateP.Enabled = false;
        }
        private void btnDeleteP_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Estas seguro que deseas eliminar ese registro", "Eliminar Registro", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    Delete();
                    SendPer("");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }
        private void dtgPer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
        private void dtgPer_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            BindingPersonal1();
            DataGridViewRow fila = dtgPer.Rows[e.RowIndex];
            txtRFC.Text = Convert.ToString(fila.Cells[0].Value);
            txtName.Text = Convert.ToString(fila.Cells[1].Value);
            txtApellidoP.Text = Convert.ToString(fila.Cells[2].Value);
            txtApellidoM.Text = Convert.ToString(fila.Cells[3].Value);
            dtpFechaNac.Text = Convert.ToString(fila.Cells[4].Value);
            txtFKTP.Text = Convert.ToString(fila.Cells[5].Value);
            SendPer("");
            btnUpdateP.Enabled = true;
            btnAddP.Enabled = false;
        }

        private void txtSendPer_TextChanged(object sender, EventArgs e)
        {
            SendPer(txtSendP.Text);
        }
    }
}
