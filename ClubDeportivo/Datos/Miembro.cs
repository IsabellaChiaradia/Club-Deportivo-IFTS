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
    public class Miembro
    {
        public string Nuevo_Miembro(E_Miembro miembro)
        {
            string? salida;
            MySqlConnection sqlCon = new MySqlConnection();
            try
            {
                sqlCon = Conexion.getInstancia().CrearConexion();
                MySqlCommand comando = new MySqlCommand("NuevoMiembro",
                sqlCon);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("Nom", MySqlDbType.VarChar).Value = miembro.Nombre;
                comando.Parameters.Add("Ape", MySqlDbType.VarChar).Value = miembro.Apellido;
                comando.Parameters.Add("Dni", MySqlDbType.VarChar).Value = miembro.DNI;
                comando.Parameters.Add("EsSocio", MySqlDbType.Byte).Value = miembro.EsSocio ? 1 : 0;
                comando.Parameters.Add("Correo", MySqlDbType.VarChar).Value = miembro.Correo;
                comando.Parameters.Add("Direccion", MySqlDbType.VarChar).Value = miembro.Direccion;
                comando.Parameters.Add("FNac", MySqlDbType.VarChar).Value = miembro.FechaNac;
                comando.Parameters.Add("AlDia", MySqlDbType.Byte).Value = miembro.EstaAlDia ? 1 : 0;
                comando.Parameters.Add("AptoM", MySqlDbType.Byte).Value = miembro.AptoMedico ? 1 : 0;
                MySqlParameter ParCodigo = new MySqlParameter();
                ParCodigo.ParameterName = "rta";
                ParCodigo.MySqlDbType = MySqlDbType.Int32;
                ParCodigo.Direction = ParameterDirection.Output;
                comando.Parameters.Add(ParCodigo);
                sqlCon.Open();
                comando.ExecuteNonQuery();
                salida = Convert.ToString(ParCodigo.Value);
            }
            catch (Exception ex)
            {
                salida = ex.Message;
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open)
                { sqlCon.Close(); };
            }
            return salida;

        }
    }
}
