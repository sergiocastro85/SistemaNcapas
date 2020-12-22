using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sistema.Negocio;

namespace Sistema.Presentacion
{
    public partial class frmArticulo : Form
    {
        private string RutaOrigen;
        private string RutaDestino;
        private string Directorio = "D:\\sistema\\";


        public frmArticulo()
        {
            InitializeComponent();
        }
        public void Listar()
        {
            try
            {
                DgvListado.DataSource = NArticulo.Listar();
                this.Formato();
                this.Limpiar();
                lblTotal.Text = "Total de Registros es: " + Convert.ToString(DgvListado.Rows.Count);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        public void Buscar()
        {
            try
            {
                DgvListado.DataSource = NArticulo.Buscar(TxtBuscar.Text);
                this.Formato();
                lblTotal.Text = "Total de Registros es: " + Convert.ToString(DgvListado.RowCount);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }


        }

        private void Formato()
        {
            DgvListado.Columns[0].Visible = false;
            DgvListado.Columns[2].Visible = false;
            DgvListado.Columns[0].Width = 100;
            DgvListado.Columns[1].Width = 100;
            DgvListado.Columns[3].Width = 100;
            DgvListado.Columns[3].HeaderText = "Categoría";
            DgvListado.Columns[4].Width = 100;
            DgvListado.Columns[4].HeaderText = "Código";
            DgvListado.Columns[5].Width = 150;
            DgvListado.Columns[6].Width = 100;
            DgvListado.Columns[6].HeaderText = "Precio Venta";
            DgvListado.Columns[7].Width = 100;
            DgvListado.Columns[8].Width = 200;
            DgvListado.Columns[8].HeaderText = "Descripción";
            DgvListado.Columns[9].Width = 100;
            DgvListado.Columns[10].Width = 100;
        }

        private void Limpiar()
        {
            TxtBuscar.Clear();
            TxtNombre.Clear();
            TxtDescripcion.Clear();
            TxtId.Clear();
            txtCodigoBarras.Clear();
            PanelCodigo.BackgroundImage = null;
            btnGuardarCodigo.Enabled = true;
            txtPrecioVenta.Clear();
            txtStock.Clear();
            txtImagen.Clear();
            PicImagen.Image = null;
            BtnInsertar.Visible = true;
            BtnActualizar.Visible = false; //ocultar el boton de actualizar
            ErrorIcono.Clear();

            this.RutaDestino = ""; //dejamos la ruta vacia
            this.RutaOrigen = ""; //dejamos la ruta vacia
            

            DgvListado.Columns[0].Visible = false;
            BtnActivar.Visible = false;
            BtnActivar.Visible = false;
            BtnDesactivar.Visible = false;
            BtnEliminar.Visible = false;
            ChkSeleccionar.Checked = false;
        }

        private void MensaError(string Mensaje)
        {
            MessageBox.Show(Mensaje, "Sistema de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void MensajeOK(string Mensaje)
        {
            MessageBox.Show(Mensaje, "Sistema de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void CargarCategoria()
        {
            try
            {
                CboCategoria.DataSource = NCategoria.Seleccionar();
                CboCategoria.ValueMember = "idcategoria";
                CboCategoria.DisplayMember = "nombre";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
        private void frmArticulo_Load(object sender, EventArgs e)
        {
            this.Listar();
            this.CargarCategoria();
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            this.Buscar();
        }

        private void BtnCargarImagen_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            //filtrar por extenciones de imagen
            file.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.fif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            //si despues de mostrar la ventana para mostrar los archivos en resultado es un OK, entonces significa que se a seleccionado un archivo
            if (file.ShowDialog() == DialogResult.OK)
            {
                //si es ok, entonces el pictUre Image va ser igual a la imagen seleccionada y se obtiene el nombre del directorio con el metodo filename
                PicImagen.Image = Image.FromFile(file.FileName);
                //tambiémn le indico a mi caja de texto el nombre de la imagen
                txtImagen.Text = file.FileName.Substring(file.FileName.LastIndexOf("\\")+1);
                //le indicamos la ruta origenn
                this.RutaOrigen = file.FileName;
            }
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            //tabajar con la libreria barcodelib
            //creamos el objeto y lo instanciamos
            BarcodeLib.Barcode Codigo = new BarcodeLib.Barcode();
            //para que incluya el texto que va debajo del código
            Codigo.IncludeLabel = true;
            //colocamos los parametros que van a ir dentro del panel en el codigo de Barras
            PanelCodigo.BackgroundImage = Codigo.Encode(BarcodeLib.TYPE.CODE128,txtCodigoBarras.Text,Color.Black,Color.White,400,100);
            btnGuardarCodigo.Enabled = true;


        }

        private void btnGuardarCodigo_Click(object sender, EventArgs e)
        {
            //declaramos un objeto de tipo imagen y clonamos lo que se tiene en el panel código
            //es decir se clona el codigo de barras y se almacena en el objeto
            Image ImgFinal = (Image)PanelCodigo.BackgroundImage.Clone();

            //se crea objeto DialogoGuardar de tipo SaveFileDialog
            SaveFileDialog DialogoGuardar = new SaveFileDialog();
            //se le indica que permita guardar la extención
            DialogoGuardar.AddExtension = true;
            //que permita solo extenciones de png
            DialogoGuardar.Filter = "Image PNG (*.png)|*.png";

            DialogoGuardar.ShowDialog();
            //si selecciono un directorio me permite guardarlo en el directorio
            if (!string.IsNullOrEmpty(DialogoGuardar.FileName))
            {
                ImgFinal.Save(DialogoGuardar.FileName, ImageFormat.Png);
            }
            ImgFinal.Dispose();



        }

        private void BtnInsertar_Click(object sender, EventArgs e)
        {
            try
            {
                string Rpta = "";
                if (CboCategoria.Text==string.Empty||TxtNombre.Text == string.Empty||txtPrecioVenta.Text==string.Empty||txtStock.Text==string.Empty)
                {
                    //se mapena los error cuando no digiten datos en los campos obligatorios
                    this.MensaError("Falta ingresar algunos datos , seran remarcados .");
                    ErrorIcono.SetError(CboCategoria, "Ingrese una Categoría");
                    ErrorIcono.SetError(TxtNombre, "Ingrese el Nombre");
                    ErrorIcono.SetError(txtPrecioVenta, "Ingrese Precio de Venta");
                    ErrorIcono.SetError(txtStock, "Ingrese Stock");
                }
                else
                {
                    //se mapean todos los parametros que se van almacendar en el metodo insertar
                    Rpta = NArticulo.Insertar(Convert.ToInt32(CboCategoria.SelectedValue),txtCodigoBarras.Text.Trim(),TxtNombre.Text.Trim(), Convert.ToDecimal(txtPrecioVenta.Text),Convert.ToInt32(txtStock.Text),TxtDescripcion.Text.Trim(),txtImagen.Text.Trim());
                    //si se recibe un OK de la capa Negocio
                    if (Rpta.Equals("OK"))
                    {
                        //me retorna se inserto de forma correcta el registro
                        this.MensajeOK("Se inserto de forma correcta el registro");
                        //si la imagen es diferente de vacio
                        if (txtImagen.Text!=string.Empty)
                        {
                            //establecemos la ruta de destino
                            this.RutaDestino = this.Directorio + txtImagen.Text;
                            //utilizamos la clase File, para copiarla
                            File.Copy(this.RutaOrigen,this.RutaDestino);

                        }
                        
                        this.Listar();
                    }
                    else
                    {
                        this.MensaError(Rpta);
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
