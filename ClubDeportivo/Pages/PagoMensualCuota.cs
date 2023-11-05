using ClubDeportivo.Datos;
using ClubDeportivo.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
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



        // -------------------- COMPORTAMIENTO BASICO DE LOS INPUTS --------------------



        private void txtDni_Enter(object sender, EventArgs e)
        {
            if (txtDni.Text == "Documento")
            {
                txtDni.Text = "";
            }
        }

        private void txtDni_Leave(object sender, EventArgs e)
        {
            if (txtDni.Text == "")
            {
                txtDni.Text = "Documento";
            }
        }

        private void txtMonto_Enter(object sender, EventArgs e)
        {
            if (txtMonto.Text == "Monto")
            {
                txtMonto.Text = "";
            }
        }

        private void txtMonto_Leave(object sender, EventArgs e)
        {
            if (txtMonto.Text == "")
            {
                txtMonto.Text = "Monto";
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



        // -------------------- FUNCIONALIDAD PRINCIPAL DEL FORMULARIO --------------------



        private void btnPagar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDni.Text) || txtDni.Text == "Documento" ||
                string.IsNullOrWhiteSpace(txtMonto.Text) || txtMonto.Text == "Monto")
            {
                MessageBox.Show("Por favor, complete todos los campos obligatorios.", "AVISO DEL SISTEMA",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string respuesta;
            E_Cuota cuota = new E_Cuota();

            string monto = txtMonto.Text.Replace('.', ',');
            cuota.Monto = Math.Round(double.Parse(monto), 2);
            cuota.FechaPago = dtpPago.Value;
            string dniMiembro = txtDni.Text;

            Cuota cuotaDB = new Cuota();
            respuesta = cuotaDB.Pagar(cuota, dniMiembro, 1); // el parametro 1 indica que el pago es de tipo mensual

            bool esnumero = int.TryParse(respuesta, out int codigo);
            if (esnumero)
            {
                if (codigo == 1)
                {
                    MessageBox.Show("Se realizó el pago correctamente", "AVISO DEL SISTEMA",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                    //Cargamos los datos del pago en la grilla
                    cuotaDB.mostrarPagoExitoso(dgtvPagoRealizado, dniMiembro);
                }
                else if (codigo == 0)
                {
                    MessageBox.Show("Sólo los socios pueden pagar la cuota mensual", "AVISO DEL SISTEMA",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("El miembro no está registrado en el sistema ", "AVISO DEL SISTEMA",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Ups! Hubo un error en el pago: " + respuesta, "AVISO DEL SISTEMA",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }

        }
    }
}
