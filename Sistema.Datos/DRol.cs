using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Sistema.Datos
{
    public class DRol
    {
        public DataTable listar()
        {
            SqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            SqlConnection Sqlcon = new SqlConnection();

            try
            {
                Sqlcon = Conexion.getInstacia().CrearConexion();
                SqlCommand Comando = new SqlCommand("rol_listar", Sqlcon);
                Comando.CommandType = CommandType.StoredProcedure;
                Sqlcon.Open();
                Resultado = Comando.ExecuteReader();
                Tabla.Load(Resultado);
                return Tabla;


            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (Sqlcon.State == ConnectionState.Open)
                    Sqlcon.Close();

            }

        }
    }
}
