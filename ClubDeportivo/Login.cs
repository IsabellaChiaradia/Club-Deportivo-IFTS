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

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string usuario = txtUser.Text;
            string password = txtPassword.Text;

            if (AutenticarUser(usuario, password))
            {
                // Las credenciales son correctas. Abre el siguiente formulario.
                Form1 dashboardForm = new Form1();
                dashboardForm.Show();

                
            }
            else
            {
                MessageBox.Show("Credenciales incorrectas. Por favor, inténtalo de nuevo.");
            }
        }

        private bool AutenticarUser(string usuario, string password)
        {
            if (usuario == "asd" && password == "123456")
            {
                return true;
            }

            return false;
        }
    }
}