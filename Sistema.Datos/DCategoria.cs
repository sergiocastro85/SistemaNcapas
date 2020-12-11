﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Sistema.Entidades;

namespace Sistema.Datos
{
    public class DCategoria
    {
        public DataTable listar()
        {
            SqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            SqlConnection Sqlcon = new SqlConnection();

            try
            {
                Sqlcon = Conexion.getInstacia().CrearConexion();
                SqlCommand Comando = new SqlCommand("categoria_listar", Sqlcon);
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
                SqlCommand Comando = new SqlCommand("categoria_buscar", Sqlcon);
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

        public DataTable Seleccionar()
        {
            SqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            SqlConnection Sqlcon = new SqlConnection();

            try
            {
                Sqlcon = Conexion.getInstacia().CrearConexion();
                SqlCommand Comando = new SqlCommand("categoria_seleccionar", Sqlcon);
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

        public string Existe(string Valor)
        {
            string Rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Conexion.getInstacia().CrearConexion();
                SqlCommand Comando = new SqlCommand("categoria_existe", SqlCon);
                Comando.Parameters.Add("@valor", SqlDbType.VarChar).Value = Valor;
                SqlParameter ParExiste = new SqlParameter();
                ParExiste.ParameterName = "@existe";
                ParExiste.SqlDbType = SqlDbType.Int;
                ParExiste.Direction = ParameterDirection.Output;
                Comando.Parameters.Add(ParExiste);
                SqlCon.Open();
                Comando.ExecuteNonQuery();
                Rpta = Convert.ToString(ParExiste.Value);
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

        public string Insertar(Categoria obj)
        {
            string Rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Conexion.getInstacia().CrearConexion();
                SqlCommand Comando = new SqlCommand("categoria_insertar", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@nombre", SqlDbType.VarChar).Value = obj.Nombre;
                Comando.Parameters.Add("@descripcion", SqlDbType.VarChar).Value = obj.Descripcion;
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

        public string Actualizar(Categoria obj)
        {
            string Rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Conexion.getInstacia().CrearConexion();
                SqlCommand Comando = new SqlCommand("categoria_actualizar", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@idcategoria", SqlDbType.Int).Value = obj.IdCategoria;
                Comando.Parameters.Add("@nombre", SqlDbType.VarChar).Value = obj.Nombre;
                Comando.Parameters.Add("@descripcion", SqlDbType.VarChar).Value = obj.Descripcion;
                SqlCon.Open();
                Rpta = Comando.ExecuteNonQuery() == 1 ? "OK" : "No se pudo actualizar el registro";
            }
            catch(Exception ex)
            {
                Rpta = ex.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return Rpta;
        }

        public string Eliminar(int Id)
        {
            string Rpta = "";
            SqlConnection Sqlcon = new SqlConnection();
            try
            {
                Sqlcon = Conexion.getInstacia().CrearConexion();
                SqlCommand Comando = new SqlCommand("categoria_eliminar", Sqlcon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@idcategoria", SqlDbType.Int).Value = Id;
                Sqlcon.Open();
                Rpta = Comando.ExecuteNonQuery() == 1 ? "OK" : "No se pudo eliminar el registro";
            }
            catch (Exception ex)
            {
                Rpta = ex.Message;
            }
            finally
            {
                if (Sqlcon.State == ConnectionState.Open) Sqlcon.Close();
            }
            return Rpta;
        }

        public string Activar(int Id)
        {
            string Rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Conexion.getInstacia().CrearConexion();
                SqlCommand Comando = new SqlCommand("categoria_activar", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@idcategoria", SqlDbType.Int).Value = Id;
                SqlCon.Open();
                Rpta = Comando.ExecuteNonQuery() == 1 ? "OK" : "No se pudo activar el registro";
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

        public string Inactivar(int Id)
        {
            string Rpta = "";
            SqlConnection SqlCon = new SqlConnection();

            try 
            { 
             SqlCon = Conexion.getInstacia().CrearConexion();
             SqlCommand Comando = new SqlCommand("categoria_desactivar", SqlCon);
             Comando.CommandType = CommandType.StoredProcedure;
             Comando.Parameters.Add("@idcategoria", SqlDbType.Int).Value = Id;
             SqlCon.Open();
             Rpta = Comando.ExecuteNonQuery() == 1 ? "OK" : "No se pudo desactivar el registro";

            }
            catch(Exception ex)
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

