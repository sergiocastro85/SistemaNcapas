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
    public class DIngreso
    {
        public DataTable listar()
        {
            SqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            SqlConnection Sqlcon = new SqlConnection();

            try
            {
                Sqlcon = Conexion.getInstacia().CrearConexion();
                SqlCommand Comando = new SqlCommand("ingreso_listar", Sqlcon);
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

        public DataTable Buscar(string valor)
        {
            SqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            SqlConnection Sqlcon = new SqlConnection();
            try
            {

                Sqlcon = Conexion.getInstacia().CrearConexion();
                SqlCommand Comando = new SqlCommand("ingreso_buscar", Sqlcon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@valor", SqlDbType.VarChar).Value = valor;
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

        public DataTable ListarDetalles(int IdIngreso)
        {
            SqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            SqlConnection Sqlcon = new SqlConnection();
            try
            {

                Sqlcon = Conexion.getInstacia().CrearConexion();
                SqlCommand Comando = new SqlCommand("ingreso_listar_detalle", Sqlcon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@idingreso", SqlDbType.Int).Value = IdIngreso;
                Sqlcon.Open();
                Resultado = Comando.ExecuteReader();
                Tabla.Load(Resultado);
                return Tabla;

            }
            catch (Exception ex)
            {
                return null;
                throw ex;
            }
            finally
            {
                if (Sqlcon.State == ConnectionState.Open)
                    Sqlcon.Close();
            }


        }

        public string Insertar(Ingreso obj)
        {
            string Rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Conexion.getInstacia().CrearConexion();
                SqlCommand Comando = new SqlCommand("ingreso_insertar", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@idusuario", SqlDbType.Int).Value = obj.IdUsuario;
                Comando.Parameters.Add("@idproveedor", SqlDbType.Int).Value = obj.IdUsuario;
                Comando.Parameters.Add("@tipo_comprobante", SqlDbType.VarChar).Value = obj.TipoComprobante;
                Comando.Parameters.Add("@serie_comprobante", SqlDbType.VarChar).Value = obj.SerieComprobante;
                Comando.Parameters.Add("@num_comprobante", SqlDbType.VarChar).Value = obj.NumComprobante;
                Comando.Parameters.Add("@impuesto", SqlDbType.Decimal).Value = obj.Impuesto;
                Comando.Parameters.Add("@total", SqlDbType.Decimal).Value = obj.Total;
                //tipo de dato estructurado
                Comando.Parameters.Add("@detalle", SqlDbType.Structured).Value = obj.Detalles;
                SqlCon.Open();
                Comando.ExecuteNonQuery();
                Rpta =  "OK" ;


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

        public string Anular(int Id)
        {
            string Rpta = "";
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                SqlCon = Conexion.getInstacia().CrearConexion();
                SqlCommand Comando = new SqlCommand("ingreso_anular", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@idingreso", SqlDbType.Int).Value = Id;
                SqlCon.Open();
                Comando.ExecuteNonQuery();
                Rpta = "OK" ;

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
