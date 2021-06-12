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
    public partial class RegistroComisionesPac : Form
    {
        public RegistroComisionesPac()
        {
            InitializeComponent();
        }

        public void CargarCorresponsalt()
        {
            CboPac.DataSource = NPac.ListadoCorresponsal();
            CboPac.DisplayMember = "Nombre";
            CboPac.ValueMember = "idPac";

            CboTransaccion.DataSource = NPac.ListaTransacciones();
            CboTransaccion.DisplayMember = "Descripcion";
            CboTransaccion.ValueMember = "id";
        }

        private void RegistroComisionesPac_Load(object sender, EventArgs e)
        {
            this.CargarCorresponsalt();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CboPac.Text = "";
            CboTransaccion.Text = "";
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                string Rpta = "";
                if (CboPac.Text == string.Empty || CboTransaccion.Text == string.Empty || TxtCantidad.Text == string.Empty )
                {
                    //se mapena los error cuando no digiten datos en los campos obligatorios
                    MessageBox.Show("Faltan datos por llenar");
                }
                else
                {
                    //se mapean todos los parametros que se van almacendar en el metodo insertar
                    Rpta = NPac.GuardarRegistroComision(Convert.ToInt32(CboPac.SelectedValue), Convert.ToInt32(CboTransaccion.SelectedValue),Convert.ToInt32(TxtCantidad.Text.Trim())) ;
                    //si se recibe un OK de la capa Negocio
                    if (Rpta.Equals("OK"))
                    {
                        //me retorna se inserto de forma correcta el registro
                        MessageBox.Show("Se inserto de forma correcta el registro");
                        //si la imagen es diferente de vacio
                    //    if (txtImagen.Text != string.Empty)
                    //    {
                    //        //establecemos la ruta de destino
                    //        this.RutaDestino = this.Directorio + txtImagen.Text;
                    //        //utilizamos la clase File, para copiarla
                    //        File.Copy(this.RutaOrigen, this.RutaDestino);

                    //    }

                    //    this.Listar();
                    //}
                    //else
                    //{
                    //    this.MensaError(Rpta);
                    //}
                }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
    }
}
