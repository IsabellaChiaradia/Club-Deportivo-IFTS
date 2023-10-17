using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;


namespace Dashboard_ClubDeportivo

{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();

            Boton btnLogin = new Boton();
            btnLogin.Text = "Iniciar Sesión";
            btnLogin.Location = new Point(443, 386);
            btnLogin.Size = new Size(180, 40);
            btnLogin.BackColor = Color.FromArgb(0x4A, 0x66, 0xAE);
            btnLogin.ForeColor = Color.White;
            btnLogin.Padding = new Padding(10, 5, 5, 10);
            btnLogin.TextAlign = ContentAlignment.MiddleCenter;
            btnLogin.Font = new Font("Avenir Next", 12f, FontStyle.Regular);
            btnLogin.Cursor = Cursors.Hand;

            btnLogin.Click += btnLogin_Click;
            // Agrega el Boton al formulario.
            Controls.Add(btnLogin);
            btnLogin.Select();
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

            Form1 dashboardForm = new Form1();
            dashboardForm.Show();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}