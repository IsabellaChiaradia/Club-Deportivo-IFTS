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

        public string Pagar(E_Cuota cuota, String dniMiembro)
        {
            string? respuesta;

            try
            {
                MySqlCommand comando = new MySqlCommand("PagarCuota", sqlCon);
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.Add("dni_miembro", MySqlDbType.VarChar).Value = dniMiembro;
                comando.Parameters.Add("monto", MySqlDbType.Double).Value = cuota.Monto;
                comando.Parameters.Add("fecha_pago", MySqlDbType.Date).Value = cuota.FechaPago;

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

    }
}
