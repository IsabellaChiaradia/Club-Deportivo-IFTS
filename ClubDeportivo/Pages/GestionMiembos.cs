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
            //string nombre = txtNombre.Text;
            //string apellido = txtApellido.Text;
            //string dni = txtDni.Text;
            //string correo = txtCorreo.Text;
            //string domicilio = txtDomicilio.Text;
            //string fechanac = txtFechaNacimiento.Text;
            //string fechains = txtFechaInscripcion.Text;
            //bool esSocio = cbxEsSocio.Checked; 

            //DataTable tablaLogin = new DataTable(); // es la que recibe los datos desde el formulario
            //ClubDeportivo.Datos.Usuario dato = new ClubDeportivo.Datos.Usuario(); // variable que contiene todas las caracteristicas de la clase
            //tablaLogin = dato.Log_Usu(usuario, password);
            //if (tablaLogin.Rows.Count > 0)
            //{
            //    // quiere decir que el resultado tiene 1 fila por lo que el usuario EXISTE
            //    MessageBox.Show("Ingreso exitoso");
            //    Form1 dashboardForm = new Form1();
            //    dashboardForm.Show();
            //}
            //else
            //{
            //    MessageBox.Show("Usuario y/o password incorrecto");
            //}
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
