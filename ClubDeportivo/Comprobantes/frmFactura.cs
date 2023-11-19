using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClubDeportivo.Comprobantes
{
    public partial class frmFactura : Form
    {

        public string? nombre;
        public string? apellido;
        public string? dni;
        public string? fechaPago;
        public string? fechaVenc;
        public string? formaDePago;
        public string? monto;
        public string? tipoMiembro;
        public string? actividad;
        public string? interes;


        public frmFactura()
        {
            InitializeComponent();
        }

        // ---------------------------- EVENTOS DEL FORMULARIO ----------------------------

        private void frmFactura_Load(object sender, EventArgs e)
        {
            lblNombreApe.Text = nombre + " " + apellido;
            lblDNI.Text = dni;
            lblFechaPago.Text = fechaPago;
            lblFechaVenc.Text = fechaVenc;
            lblMonto.Text = monto;
            lblFormaPago.Text = formaDePago;
            lblCaracter.Text = tipoMiembro;
            lblActividad.Text = actividad;
            lblInteres.Text = interes;

            if (string.IsNullOrWhiteSpace(actividad))
            {
                lblActividad.Hide();
                lblTituloActividad.Hide();
            }
        }


        // ---------------------------- EVENTOS DE BOTONES ----------------------------

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
