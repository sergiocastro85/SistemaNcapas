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
    }
}
