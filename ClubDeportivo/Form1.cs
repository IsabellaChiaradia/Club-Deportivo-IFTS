using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Dashboard_ClubDeportivo.pesañas;
using Dashboard_ClubDeportivo.Pages;

namespace Dashboard_ClubDeportivo
{
    public partial class Form1 : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // height of ellipse
            int nHeightEllipse // width of ellipse
        );
        public Form1()
        {
            InitializeComponent();

            GestionMiembos uc = new GestionMiembos();
            agregarPaneles(uc);
            this.BackColor = Color.FromArgb(0x4A, 0x66, 0xAE);


            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        private void btnClose2_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            CenterToScreen();
        }

        private void agregarPaneles(UserControl userControl)
        {
            pnlContainer.Controls.Add(userControl);
            userControl.Dock = DockStyle.Fill;
            userControl.BringToFront();
        }

        private void btnGestion_Click(object sender, EventArgs e)
        {
            GestionMiembos uc = new GestionMiembos();
            agregarPaneles(uc);
        }

        private void btnPagosFactura_Click(object sender, EventArgs e)
        {
            PagosFacturacion uc = new PagosFacturacion();
            agregarPaneles(uc);
        }
    }
}