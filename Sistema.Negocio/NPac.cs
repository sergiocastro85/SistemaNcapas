using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Sistema.Datos;
using Sistema.Entidades;

namespace Sistema.Negocio
{
    public class NPac
    {
        public static List<Pac> ListadoCorresponsal()
        {
            Dpac datosPac = new Dpac();
            return datosPac.ListadoPac();
        }

        public static List<Transaccion> ListaTransacciones()
        {
            Dpac datosPac = new Dpac();
            return datosPac.ListadoTransaccion();
        }

        public static string GuardarRegistroComision(int idPac, int idTransaccion, int Cantidad)
        {
            Dpac Datos = new Dpac();
            RegistroComision obj = new RegistroComision();

            obj.idPac = idPac;
            obj.idTransaccion = idTransaccion;
            obj.Cantidad = Cantidad;
            return Datos.GuardarRegistroComision(obj);
        }
    }
}
