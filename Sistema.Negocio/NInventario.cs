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
    public class NInventario
    {
        public static string Insertar(string descripcion)
        {
            DInventario Datos = new DInventario();

  
                Inventario obj = new Inventario();
                obj.Descripcion = descripcion;
                return Datos.Insertar(obj);

           

        }

    }
}
