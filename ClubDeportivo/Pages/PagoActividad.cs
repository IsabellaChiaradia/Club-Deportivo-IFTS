﻿using ClubDeportivo.Comprobantes;
using ClubDeportivo.Datos;
using ClubDeportivo.Entidades;
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
        private Cuota cuotaDB;
        private Actividad actividadBD;
        private string dniMiembro;
        private List<E_Actividad> actividades;
        public PagoActividad()
        {
            InitializeComponent();
            this.cuotaDB = new Cuota();
            this.actividadBD = new Actividad();
        }



        // -------------------- FUNCIONALIDAD PRINCIPAL DEL FORMULARIO --------------------

        private void PagoActividad_Load(object sender, EventArgs e)
        {
            this.actividades = actividadBD.traerActividades();

            cboActividad.Items.Add("Seleccionar Actividad");
            foreach (E_Actividad a in actividades)
            {
                cboActividad.Items.Add(a.Nombre);
            }
            cboActividad.SelectedIndex = 0;
        }

        private void cboActividad_SelectedIndexChanged(object sender, EventArgs e)
        {
            string actSeleccionada = cboActividad.SelectedItem.ToString();
            foreach (E_Actividad a in actividades)
            {
                if (actSeleccionada == "Seleccionar Actividad")
                {
                    txtMontoPA.Text = "Monto";
                    break;
                } 
                else if (actSeleccionada == a.Nombre)
                {
                    txtMontoPA.Text = a.Costo.ToString();
                    break;
                }
            }
        }

        private void btnPagarPA_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDocumentoPA.Text) || txtDocumentoPA.Text == "Documento" ||
                string.IsNullOrWhiteSpace(txtMontoPA.Text) || txtMontoPA.Text == "Monto")
            {
                MessageBox.Show("Por favor, complete todos los campos obligatorios.", "AVISO DEL SISTEMA",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string respuesta;
            E_Cuota cuota = new E_Cuota();

            string monto = txtMontoPA.Text.Replace('.', ',');
            cuota.Monto = Math.Round(double.Parse(monto), 2);
            cuota.FechaPago = dtpPA.Value;
            dniMiembro = txtDocumentoPA.Text;


            respuesta = cuotaDB.Pagar(cuota, dniMiembro, 2); // el parametro 2 indica que el pago es de tipo actividad

            bool esnumero = int.TryParse(respuesta, out int codigo);
            if (esnumero)
            {
                if (codigo == 1)
                {
                    MessageBox.Show("Se realizó el pago correctamente", "AVISO DEL SISTEMA",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                    //Cargamos los datos del pago en la grilla
                    cuotaDB.mostrarPagoExitoso(dtgvActividad, dniMiembro);
                    btnComprobantePA.Enabled = true;
                }
                else if (codigo == 0)
                {
                    MessageBox.Show("Sólo los NO socios deben pagar por la actividad a realizar", "AVISO DEL SISTEMA",
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

        private void btnComprobantePA_Click(object sender, EventArgs e)
        {
            frmFactura factura = new frmFactura();
            cuotaDB.emitirFactura(dniMiembro, factura);
            factura.Show();
        }



        // -------------------- COMPORTAMIENTO BASICO DE LOS INPUTS --------------------


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


    }
}
