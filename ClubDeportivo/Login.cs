using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Data;

namespace Dashboard_ClubDeportivo

{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();

        }

        private void txtUser_Enter(object sender, EventArgs e)
        {
            if (txtUser.Text == "Usuario")
            {
                txtUser.Text = "";
            }
        }
        private void txtUser_Leave(object sender, EventArgs e)
        {
            if (txtUser.Text == "")
            {
                txtUser.Text = "Usuario";
            }
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if (txtPassword.Text == "Contraseña")
            {
                txtPassword.Text = "";
                txtPassword.UseSystemPasswordChar = true;
            }
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (txtPassword.Text == "")
            {
                txtPassword.Text = "Contraseña";
                txtPassword.UseSystemPasswordChar = false;
            }
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string usuario = txtUser.Text;
            string password = txtPassword.Text;

            DataTable tablaLogin = new DataTable(); // es la que recibe los datos desde el formulario
            ClubDeportivo.Datos.Usuario dato = new ClubDeportivo.Datos.Usuario(); // variable que contiene todas las caracteristicas de la clase
            tablaLogin = dato.Log_Usu(usuario, password);
            if (tablaLogin.Rows.Count > 0)
            {
                // quiere decir que el resultado tiene 1 fila por lo que el usuario EXISTE
                MessageBox.Show("INGRESO EXITOSO", "AVISO DEL SISTEMA",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
                Form1 dashboardForm = new Form1();
                dashboardForm.Show();
            }
            else
            {
                MessageBox.Show("Usuario y/o password incorrecto", "AVISO DEL SISTEMA",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Login_Shown(object sender, EventArgs e)
        {
            btnLogin.Focus();
        }
    }
}