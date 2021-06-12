using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema.Entidades
{
    public class RegistroComision
    {
        public int idPac { get; set; }
        public int idTransaccion { get; set; }

        public DateTime Fecha { get; set; }

        public int Cantidad { get; set; }


    }
}
