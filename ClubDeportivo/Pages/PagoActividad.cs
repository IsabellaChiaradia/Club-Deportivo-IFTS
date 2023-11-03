using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClubDeportivo.Pages
{
    public partial class PagoActividad : UserControl
    {
        public PagoActividad()
        {
            InitializeComponent();
        }

        private void txtDocumentoPA_Enter(object sender, EventArgs e)
        {
            if (txtDocumentoPA.Text == "Documento")
            {
                txtDocumentoPA.Text = "";
            }
        }

        private void txtDocumentoPA_Leave(object sender, EventArgs e)
        {
            if (txtDocumentoPA.Text == "")
            {
                txtDocumentoPA.Text = "Documento";
            }
        }

        private void txtMontoPA_Enter(object sender, EventArgs e)
        {
            if (txtMontoPA.Text == "Monto")
            {
                txtMontoPA.Text = "";
            }
        }

        private void txtMontoPA_Leave(object sender, EventArgs e)
        {
            if (txtMontoPA.Text == "")
            {
                txtMontoPA.Text = "Monto";
            }
        }
        private void cbxEfectivoPA_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxEfectivoPA.Checked)
            {
                cboCuotasPA.Enabled = false;
                cbxTarjetaPA.Checked = false;
            }
        }

        private void cbxTarjetaPA_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxTarjetaPA.Checked)
            {
                cbxEfectivoPA.Checked = false;
                cboCuotasPA.Enabled = true;
            }
        }

        private void cbxTarjetaPA_CheckStateChanged(object sender, EventArgs e)
        {
            cboCuotasPA.SelectedItem = null;
            cboCuotasPA.Text = "Cantidad de cuotas";
            if (!(cbxEfectivoPA.Checked) && !(cbxTarjetaPA.Checked))
            {
                cboCuotasPA.Enabled = false;
            }
        }

        private void btnPagarPA_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDocumentoPA.Text) || txtDocumentoPA.Text == "Documento" ||
                string.IsNullOrWhiteSpace(txtMontoPA.Text) || txtMontoPA.Text == "Monto" ||
                (!cbxTarjetaPA.Checked && !cbxEfectivoPA.Checked))
            {
                MessageBox.Show("Por favor, complete todos los campos obligatorios.", "AVISO DEL SISTEMA",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}
