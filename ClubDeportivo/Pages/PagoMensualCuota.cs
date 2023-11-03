using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dashboard_ClubDeportivo.Pages
{
    public partial class PagoMensualCuota : UserControl
    {
        public PagoMensualCuota()
        {
            InitializeComponent();
        }

        private void txtDocumentoPMC_Enter(object sender, EventArgs e)
        {
            if (txtDocumentoPMC.Text == "Documento")
            {
                txtDocumentoPMC.Text = "";
            }
        }

        private void txtDocumentoPMC_Leave(object sender, EventArgs e)
        {
            if (txtDocumentoPMC.Text == "")
            {
                txtDocumentoPMC.Text = "Documento";
            }
        }

        private void txtMontoPMC_Enter(object sender, EventArgs e)
        {
            if (txtMontoPMC.Text == "Monto")
            {
                txtMontoPMC.Text = "";
            }
        }

        private void txtMontoPMC_Leave(object sender, EventArgs e)
        {
            if (txtMontoPMC.Text == "")
            {
                txtMontoPMC.Text = "Monto";
            }
        }

        private void cbxEfectivo_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxEfectivo.Checked)
            {
                cboCuotas.Enabled = false;
                cbxTarjeta.Checked = false;
            }
        }

        private void cbxTarjeta_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxTarjeta.Checked)
            {
                cbxEfectivo.Checked = false;
                cboCuotas.Enabled = true;
            }
        }

        private void cbxTarjeta_CheckStateChanged(object sender, EventArgs e)
        {
            cboCuotas.SelectedItem = null;
            cboCuotas.Text = "Cantidad de cuotas";
            if (!(cbxEfectivo.Checked) && !(cbxTarjeta.Checked))
            {
                cboCuotas.Enabled = false;
            }
        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDocumentoPMC.Text) || txtDocumentoPMC.Text == "Documento" ||
                string.IsNullOrWhiteSpace(txtMontoPMC.Text) || txtMontoPMC.Text == "Monto" ||
                (!cbxTarjeta.Checked && !cbxEfectivo.Checked))
            {
                MessageBox.Show("Por favor, complete todos los campos obligatorios.", "AVISO DEL SISTEMA",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}
