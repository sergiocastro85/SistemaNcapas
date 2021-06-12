using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Sistema.Entidades;


namespace Sistema.Datos
{
    public class Dpac
    {


        SqlDataReader Resultado;
        DataTable Tabla = new DataTable();
        SqlConnection Sqlcon = new SqlConnection();


        public List<Pac> ListadoPac()
        {
            try
            {

  
            
            List<Pac> ListadoPac = new List<Pac>();
            Pac objpac;

                SqlDataReader Resultado;
                DataTable Tabla = new DataTable();
                SqlConnection Sqlcon = new SqlConnection();

                Sqlcon = Conexion.getInstacia().CrearConexion();
            SqlCommand comando = new SqlCommand("pac_listar",Sqlcon);
            comando.CommandType = CommandType.StoredProcedure;
            Sqlcon.Open();
            Resultado = comando.ExecuteReader();

            while (Resultado.Read())
            {
                objpac = new Pac();
                objpac.Nombre = Resultado["strNombre"].ToString();
                objpac.IdPac = Convert.ToInt32(Resultado["idPac"].ToString());
                ListadoPac.Add(objpac);

            }
            return ListadoPac;

            }
            catch (Exception ex)
            {
                throw (ex);
            }




        }

        public List<Transaccion> ListadoTransaccion()
        {
            try
            {
                List<Transaccion> ListadoTransaccion = new List<Transaccion>();
                Transaccion objtransaccion;

                SqlDataReader ResultadoT;
                DataTable TablaT = new DataTable();
                SqlConnection Sqlcon = new SqlConnection();

                Sqlcon = Conexion.getInstacia().CrearConexion();
                SqlCommand comando = new SqlCommand("Trnsac_listar", Sqlcon);
                comando.CommandType = CommandType.StoredProcedure;
                Sqlcon.Open();
                ResultadoT = comando.ExecuteReader();

                while (ResultadoT.Read())
                {
                    objtransaccion = new Transaccion();
                    objtransaccion.Descripcion = ResultadoT["Descripcion"].ToString();
                    objtransaccion.id = Convert.ToInt32(ResultadoT["id"].ToString());
                    ListadoTransaccion.Add(objtransaccion);
                }
                return ListadoTransaccion;
       

            }
            catch (Exception ex)
            {
                throw ex;

            }
        }


        public string GuardarRegistroComision(RegistroComision obj)
        {
            string Rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Conexion.getInstacia().CrearConexion();
                SqlCommand Comando = new SqlCommand("comisiones_insertar", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@idPac", SqlDbType.Int).Value = obj.idPac;
                Comando.Parameters.Add("@idTransaccion", SqlDbType.Int).Value = obj.idTransaccion;
                Comando.Parameters.Add("@cantidad", SqlDbType.Int).Value = obj.Cantidad;
                SqlCon.Open();
                Rpta = Comando.ExecuteNonQuery() == 1 ? "OK" : "NO SE PUDO INGRESAR EL REGISTRO";


            }
            catch (Exception ex)
            {
                Rpta = ex.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return Rpta;

        }






    }
}
