using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Dashboard_ClubDeportivo.pesañas;
using Dashboard_ClubDeportivo.Pages;
using ClubDeportivo.Datos;
using ClubDeportivo.Pages;

namespace Dashboard_ClubDeportivo
{
    public partial class Form1 : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
        );
        //----------------------------SEGUNDA PANTALLA-----------------------------//
        //-------------------------------------------------------------------------//
        // En este sector se encontrara con el codigo de la segunda ventana en la cual prodrá visualizar
        // los distintos botones de interaccion que conforman los PROCESOS requeridos por la cliente, según el análisis 
        //previo, por el momento el unico activo es Gestion de miembros y Pagos y facturacion, es importante mencionar que
        //la sección de gestion de miembros es la que contiene funcionalidad no asi la de pagos y facturacion, debido a que 
        //solo se utilizo para chequear la navegacion interna de paginas dentro del componente contenedor main.
        //A continuación se detalla en el código:
        //-------------------------------------------------------------------------//
        public Form1()
        {
            InitializeComponent();

            GestionMiembros uc = new GestionMiembros();
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
        //Navegacion entre paneles que se encuentra en la carpeta Pages//
        private void agregarPaneles(UserControl userControl)
        {
            pnlContainer.Controls.Add(userControl);
            userControl.Dock = DockStyle.Fill;
            userControl.BringToFront();
        }

        private void btnGestion_Click(object sender, EventArgs e)
        {
            GestionMiembros uc = new GestionMiembros();
            agregarPaneles(uc);
        }

        private void btnPagosFactura_Click(object sender, EventArgs e)
        {
            PagoMensualCuota uc = new PagoMensualCuota();
            agregarPaneles(uc);
        }

        private void btnPagoActividad_Click(object sender, EventArgs e)
        {
            PagoActividad uc = new PagoActividad();
            agregarPaneles(uc);
        }

        private void btnCuotasVencidas_Click(object sender, EventArgs e)
        {
            CuotasVencidas uc = new CuotasVencidas();
            agregarPaneles(uc);
        }
    }
}