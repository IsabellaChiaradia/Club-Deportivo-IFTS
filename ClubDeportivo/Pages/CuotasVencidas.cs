using ClubDeportivo.Datos;
using MySql.Data.MySqlClient;
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
    public partial class CuotasVencidas : UserControl
    {
        public CuotasVencidas()
        {
            InitializeComponent();
        }

        private void CuotasVencidas_Load(object sender, EventArgs e)
        {
            Cuota cuotaDB = new Cuota();
            cuotaDB.mostrarSociosMorosos(dtgvCuotasVenc);
        }
    }
}
