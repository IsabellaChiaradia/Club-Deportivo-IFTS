using ClubDeportivo.Entidades;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubDeportivo.Datos
{
    public class Cuota
    {
        private MySqlConnection sqlCon;

        public Cuota()
        {
            this.sqlCon = Conexion.getInstancia().CrearConexion();
        }

        public string Pagar(E_Cuota cuota, String dniMiembro, int tipo_pago)
        {
            string? respuesta;

            try
            {
                MySqlCommand comando = new MySqlCommand("Pagar", sqlCon);
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.Add("dni_miembro", MySqlDbType.VarChar).Value = dniMiembro;
                comando.Parameters.Add("monto", MySqlDbType.Double).Value = cuota.Monto;
                comando.Parameters.Add("fecha_pago", MySqlDbType.Date).Value = cuota.FechaPago;
                comando.Parameters.Add("tipo_pago", MySqlDbType.Int32).Value = tipo_pago;

                //creamos una variable para usarla como parametro de salida del procedimiento
                MySqlParameter rtaParameter = new MySqlParameter();
                rtaParameter.ParameterName = "rta";
                rtaParameter.MySqlDbType = MySqlDbType.Int32;
                rtaParameter.Direction = ParameterDirection.Output;
                comando.Parameters.Add(rtaParameter);

                sqlCon.Open();
                comando.ExecuteNonQuery();
                respuesta = Convert.ToString(rtaParameter.Value);

            }
            catch (Exception ex)
            {
                respuesta = ex.Message; 
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open)
                { sqlCon.Close(); };
            }
            return respuesta;
        }

        public void mostrarPagoExitoso(DataGridView tablaPago, string dni)
        {
            try
            {
                tablaPago.DataSource = null;
                string query = "SELECT m.Nombre AS Nombre, m.Apellido AS Apellido, c.Monto AS Monto, " 
                    + " c.FechaVenc AS 'Fecha de Vencimiento' " 
                    + " FROM miembro m " 
                    + " INNER JOIN cuota c ON c.IDMiembro = m.IDMiembro " 
                    + " WHERE m.DNI = " + dni
                    + " ORDER BY c.FechaPago DESC "
                    + " LIMIT 1;";
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, sqlCon);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                tablaPago.DataSource = dt;
            }
            catch (Exception error)
            {
                MessageBox.Show("Ups! Hubo un error al cargar la tabla con el último pago miembro " + error);
            }
        }

    }
}
