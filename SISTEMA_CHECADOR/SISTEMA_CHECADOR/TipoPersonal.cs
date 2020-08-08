using EntidadesChecador;
using LogicaNegocio;
using System;
using System.Windows.Forms;

namespace SISTEMA_CHECADOR
{
    public partial class TipoPersonal : Form
    {
        private LTP _lTP;
        private ETP _eTP;

        private bool _isEnablebinding = false;
        public TipoPersonal()
        {
            InitializeComponent();
            _lTP = new LTP();
            _eTP = new ETP();
            _isEnablebinding = true;
            BindingTipoPersonal();
            btnUpdateTP.Enabled = false;
        }
        public TipoPersonal(ETP persona)
        {
            InitializeComponent();
            _lTP = new LTP();
            _eTP = new ETP();
            BindingTipoPersonalReload();
            _eTP = persona;
            _isEnablebinding = true;
        }
        private void BindingTipoPersonalReload()
        {
            txtTP.Text = _eTP.Tipo_Personal;
        }
        private void BindingTipoPersonal()
        {
            if (_isEnablebinding)
            {
                if (_eTP.Tipo_Personal == _eTP.Tipo_Personal)
                {
                    _eTP.Tipo_Personal = _eTP.Tipo_Personal;
                }

                _eTP.Tipo_Personal = txtTP.Text;

            }
        }
        private void Bindingpersona()
        {
            _eTP.Idtipopersonal = Convert.ToInt32(dtgTP.CurrentRow.Cells["IDTIPOPERSONAL"].Value.ToString());
            _eTP.Tipo_Personal = dtgTP.CurrentRow.Cells["TIPO_PERSONAL"].Value.ToString();
        }
        private void Add_Update()
        {
            _lTP.GuardarTipopersona(_eTP);
        }
        private void Delete()
        {
            int numero = Convert.ToInt32(dtgTP.CurrentRow.Cells["IDTIPOPERSONAL"].Value.ToString());
            _lTP.EliminarTipopersona(numero);
        }
        private void SendTP(string filtro)
        {
            dtgTP.DataSource = _lTP.ObtenerListaTipopersona(filtro);
        }

        private void TipoPersonal_Load(object sender, EventArgs e)
        {
            SendTP("");
        }
        private void btnAddTP_Click(object sender, EventArgs e)
        {
            BindingTipoPersonal();
            Add_Update();
            txtTP.Clear();
            SendTP("");
        }

        private void btnUpdateTP_Click(object sender, EventArgs e)
        {
            BindingTipoPersonal();
            Add_Update();
            txtTP.Clear();
            SendTP("");
            btnAddTP.Enabled = true;
            btnUpdateTP.Enabled = false;
        }

        private void btnDeleteTP_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Estas seguro que deseas eliminar este campo", "Eliminar registro", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    Delete();
                    SendTP("");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }

        private void dtgTP_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
        private void dtgTP_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Bindingpersona();
            DataGridViewRow fila = dtgTP.Rows[e.RowIndex];
            txtTP.Text = Convert.ToString(fila.Cells[1].Value);
            SendTP("");
            btnUpdateTP.Enabled = true;
            btnAddTP.Enabled = false;
        }

        private void txtSend_TextChanged(object sender, EventArgs e)
        {
            SendTP(txtSend.Text);
        }

        private void btnSend_Click(object sender, EventArgs e)
        {

        }        
    }
}
