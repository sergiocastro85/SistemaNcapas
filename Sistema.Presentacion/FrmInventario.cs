using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sistema.Negocio;

namespace Sistema.Presentacion
{
    public partial class FrmInventario : Form
    {
        public FrmInventario()
        {
            InitializeComponent();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                string Rpta = "";

                //se mapean todos los parametros que se van almacendar en el metodo insertar
                Rpta = NInventario.Insertar(TxtDescripcion.Text.Trim());
                    //si se recibe un OK de la capa Negocio
                    if (Rpta.Equals("OK"))
                    {
                        //me retorna se inserto de forma correcta el registro
                        MessageBox.Show("Se inserto de forma correcta el registro");
                        TxtDescripcion.Text = string.Empty;
                        //si la imagen es diferente de vacio

                    }

                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
           
        }
    }
}
