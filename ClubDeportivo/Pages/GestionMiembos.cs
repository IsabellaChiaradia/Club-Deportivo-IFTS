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

namespace Dashboard_ClubDeportivo.pesañas
{
    public partial class GestionMiembos : UserControl
    {
        public GestionMiembos()
        {
            InitializeComponent();

        }

        public void txtNombre_Enter(object sender, EventArgs e)
        {
            if (txtNombre.Text == "Nombre")
            {
                txtNombre.Text = "";
            }
        }

        private void txtNombre_Leave(object sender, EventArgs e)
        {
            if (txtNombre.Text == "")
            {
                txtNombre.Text = "Nombre";
            }
        }

        private void txtApellido_Enter(object sender, EventArgs e)
        {
            if (txtApellido.Text == "Apellido")
            {
                txtApellido.Text = "";
            }
        }

        private void txtApellido_Leave(object sender, EventArgs e)
        {
            if (txtApellido.Text == "")
            {
                txtApellido.Text = "Apellido";
            }
        }

        private void txtDni_Enter(object sender, EventArgs e)
        {
            if (txtDni.Text == "DNI")
            {
                txtDni.Text = "";
            }
        }

        private void txtDni_Leave(object sender, EventArgs e)
        {
            if (txtDni.Text == "")
            {
                txtDni.Text = "DNI";
            }
        }

        private void txtCorreo_Enter(object sender, EventArgs e)
        {
            if (txtCorreo.Text == "Correo")
            {
                txtCorreo.Text = "";
            }
        }

        private void txtCorreo_Leave(object sender, EventArgs e)
        {
            if (txtCorreo.Text == "")
            {
                txtCorreo.Text = "Correo";
            }
        }

        private void txtDomicilio_Enter(object sender, EventArgs e)
        {
            if (txtDomicilio.Text == "Domicilio")
            {
                txtDomicilio.Text = "";
            }
        }

        private void txtDomicilio_Leave(object sender, EventArgs e)
        {
            if (txtDomicilio.Text == "")
            {
                txtDomicilio.Text = "Domicilio";
            }
        }

        private void txtFechaNacimiento_Enter(object sender, EventArgs e)
        {
            if (txtFechaNacimiento.Text == "Fecha N.")
            {
                txtFechaNacimiento.Text = "";
            }
        }

        private void txtFechaNacimiento_Leave(object sender, EventArgs e)
        {
            if (txtFechaNacimiento.Text == "")
            {
                txtFechaNacimiento.Text = "Fecha N.";
            }
        }

        private void txtFechaInscripcion_Enter(object sender, EventArgs e)
        {
            if (txtFechaInscripcion.Text == "Fecha I.")
            {
                txtFechaInscripcion.Text = "";
            }
        }

        private void txtFechaInscripcion_Leave(object sender, EventArgs e)
        {
            if (txtFechaInscripcion.Text == "")
            {
                txtFechaInscripcion.Text = "Fecha I.";
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string respuesta;
            E_Miembro miembro = new E_Miembro();
            miembro.Nombre = txtNombre.Text;
            miembro.Apellido = txtApellido.Text;
            miembro.DNI = txtDni.Text;
            miembro.EsSocio = cbxEsSocio.Checked;
            miembro.Correo = txtCorreo.Text;
            miembro.Direccion = txtDomicilio.Text;
            miembro.FechaNac = txtFechaNacimiento.Text;
            miembro.EstaAlDia = false;
            miembro.AptoMedico = true;
           

            // instanciamos para usar el metodo dentro de postulantes
            ClubDeportivo.Datos.Miembro altaMiembro = new ClubDeportivo.Datos.Miembro();
            respuesta = altaMiembro.Nuevo_Miembro(miembro);
            
            bool esnumero = int.TryParse(respuesta, out int codigo);
            if (esnumero)
            {
                if (codigo == 1)
                {
                    MessageBox.Show("EL MIEMBRO YA EXISTE", "AVISO DEL SISTEMA",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Se dió de alta con éxito el miembro con el codigo Nro " + respuesta, "AVISO DEL SISTEMA",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Question);
                }
            }
            else
            {
                MessageBox.Show("Ups! Hubo un error con la alta del miembro", "AVISO DEL SISTEMA",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Question);
            }
        }

        private void LIMPIAR_Click(object sender, EventArgs e)
        {
            //Limpiamos todos los campos
            txtNombre.Text = "Nombre";
            txtApellido.Text = "Apellido";
            txtDni.Text = "DNI";
            txtCorreo.Text = "Correo";
            txtDomicilio.Text = "Domicilio";
            txtFechaNacimiento.Text = "Fecha N.";
            txtFechaInscripcion.Text = "Fecha I.";
            cbxEsSocio.Checked = false;
        }       
    }
}
