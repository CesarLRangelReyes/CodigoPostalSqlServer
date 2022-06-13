using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CodigoPostalSqlServer
{
    public partial class Form1 : Form
    {
        BusquedasCP cp = new BusquedasCP();
        public Form1()
        {
            InitializeComponent();
            MostrarEstados();
        }

        public void MostrarEstados() {
            //Hay que agregar la columna que vamos a usar para el combobox, ya que si no especificamos la columna nos va arroja como dato System.Data.DataRowView
            txtEstados.ValueMember = "Estado";
            txtEstados.DisplayMember = "Estado";
            txtEstados.DataSource = cp.CpEstado();
        }

        private void txtEstados_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txtEstados.SelectedValue.ToString() != null) {
                cp.Estado = txtEstados.Text;
                txtMunicipios.ValueMember = "Municipio";
                txtMunicipios.DisplayMember = "Municipio";
                txtMunicipios.DataSource = cp.CpMunicipio();
            }
        }

        private void txtMunicipios_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter)) {
                cp.Estado = txtEstados.Text;
                cp.Municipio = txtMunicipios.Text;
                dgvCodigosPostales.DataSource = cp.EstadoPorMunicipio();
            }
        }

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter)) {
                cp.Cp = Convert.ToInt32(txtCodigo.Text);
                dgvCodigosPostales.DataSource = cp.CodigoPostal();
            }
        }

        private void txtAsentamiento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter)) {

                string estado = "--------SELECCIONAR ESTADO---------";
                string municipio = "--------SELECCIONAR MUNICIPIO---------";
                cp.Estado = txtEstados.Text;
                cp.Municipio = txtMunicipios.Text;
                cp.Asentamiento = txtAsentamiento.Text;

                if (estado != txtEstados.Text && municipio != txtMunicipios.Text && txtAsentamiento.Text == txtAsentamiento.Text) {
                    dgvCodigosPostales.DataSource = cp.MunicipioEstado();
                }
                else {
                    dgvCodigosPostales.DataSource = cp.CpAsentamiento();
                }
            }
        }
    }
}
