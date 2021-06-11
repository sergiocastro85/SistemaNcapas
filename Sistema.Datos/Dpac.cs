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




    }
}
