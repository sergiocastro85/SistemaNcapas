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
        private string Directorio = "D:\\Usuarios\\scastroc\\Pictures";
        private string NombreAnt;


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

        //evento doble click en datagridView
        private void DgvListado_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                this.Limpiar();
                BtnActualizar.Visible = true;
                BtnInsertar.Visible = true;
                //seleccionar el ID del Artículo que se va actualizar
                TxtId.Text = Convert.ToString(DgvListado.CurrentRow.Cells["ID"].Value);
                CboCategoria.SelectedValue = Convert.ToString(DgvListado.CurrentRow.Cells["idcategoria"].Value);
                txtCodigoBarras.Text = Convert.ToString(DgvListado.CurrentRow.Cells["codigo"].Value);
                this.NombreAnt = Convert.ToString(DgvListado.CurrentRow.Cells["Nombre"].Value);
                TxtNombre.Text = Convert.ToString(DgvListado.CurrentRow.Cells["Nombre"].Value);
                txtPrecioVenta.Text = Convert.ToString(DgvListado.CurrentRow.Cells["Precio_venta"].Value);
                txtStock.Text = Convert.ToString(DgvListado.CurrentRow.Cells["Stock"].Value);
                TxtDescripcion.Text = Convert.ToString(DgvListado.CurrentRow.Cells["Descripcion"].Value);
                string Imagen;
                Imagen = Convert.ToString(DgvListado.CurrentRow.Cells["Imagen"].Value);
                if (Imagen != string.Empty)
                {
                    //con la clase image, se selecciona un archivo para almacenar la ruta del directorio
                    PicImagen.Image = Image.FromFile(this.Directorio + Imagen);
                    txtImagen.Text = Imagen;
                }
                else
                {
                    PicImagen.Image = null;
                    txtImagen.Text = "";
                }
                tabGeneral.SelectedIndex = 1;


            }
            catch(Exception ex)
            {
                MessageBox.Show("Seleccione desde la celda nombre." + "| Error: " + ex.Message);
            }
        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                string Rpta = "";
                if (TxtId.Text==string.Empty||CboCategoria.Text == string.Empty || TxtNombre.Text == string.Empty || txtPrecioVenta.Text == string.Empty || txtStock.Text == string.Empty)
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
                    Rpta = NArticulo.Actualizar(Convert.ToInt32(TxtId.Text),Convert.ToInt32(CboCategoria.SelectedValue), txtCodigoBarras.Text.Trim(), this.NombreAnt,TxtNombre.Text.Trim(), Convert.ToDecimal(txtPrecioVenta.Text), Convert.ToInt32(txtStock.Text), TxtDescripcion.Text.Trim(), txtImagen.Text.Trim());
                    //si se recibe un OK de la capa Negocio
                    if (Rpta.Equals("OK"))
                    {
                        //me retorna se inserto de forma correcta el registro
                        this.MensajeOK("Se actualizó de forma correcta el registro");
                        //si la imagen es diferente de vacio
                        if (txtImagen.Text != string.Empty && this.RutaOrigen!=string.Empty)
                        {
                            //establecemos la ruta de destino
                            this.RutaDestino = this.Directorio + txtImagen.Text;
                            //utilizamos la clase File, para copiarlan en la carpeta del directorio
                            File.Copy(this.RutaOrigen, this.RutaDestino);

                        }

                        this.Listar();
                        tabGeneral.SelectedIndex = 0;

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

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Limpiar();
            tabGeneral.SelectedIndex = 0;
        }

        private void DgvListado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //el objeto e, sale del evento private void DgvListado_CellContentClick(object sender, DataGridViewCellEventArgs e)
            if (e.ColumnIndex == DgvListado.Columns["Seleccionar"].Index)
            {
                DataGridViewCheckBoxCell ChkEliminar = (DataGridViewCheckBoxCell)DgvListado.Rows[e.RowIndex].Cells["Seleccionar"];
                ChkEliminar.Value = !Convert.ToBoolean(ChkEliminar.Value);

            }
        }

        private void ChkSeleccionar_CheckedChanged(object sender, EventArgs e)
        {
            //en el evento cheke hago visible la columna 0 de gridview y los botones
            if (ChkSeleccionar.Checked)
            {
                DgvListado.Columns[0].Visible = true;
                BtnActivar.Visible = true;
                BtnDesactivar.Visible = true;
                BtnEliminar.Visible = true;
            }
            else
            {
                DgvListado.Columns[0].Visible = false;
                BtnActivar.Visible = false;
                BtnActivar.Visible = false;
                BtnDesactivar.Visible = false;
                BtnEliminar.Visible = false;
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult Opcion;
                Opcion = MessageBox.Show("Realmente deseas Eliminar el (los) Registro (s) ?", "Sistema de Ventas", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (Opcion == DialogResult.OK)
                {
                    int Codigo;
                    string Rpta = "";
                    string Imagen = "";

                    foreach (DataGridViewRow row in DgvListado.Rows)
                    {
                        //si la celda actual que estoy recorriendo en la posicion 0 es true
                        //indica que se desea Eliminar
                        if (Convert.ToBoolean(row.Cells[0].Value))
                        {
                            //Establesco el valor que voy a eliminar y lo almaceno en la variable Codigo
                            Codigo = Convert.ToInt32(row.Cells[1].Value);
                            //la imagen en el registro seleccionado, que se encuentra en la posición 9
                            Imagen = Convert.ToString(row.Cells[9].Value);
                            Rpta = NArticulo.Eliminar(Codigo);

                            if (Rpta.Equals("OK"))
                            {
                                this.MensajeOK("Se eliminó el registro" + Convert.ToString(row.Cells[5].Value));
                                //utilizamos el File Delete, para borrar la imagen del directorio
                                File.Delete(this.Directorio+Imagen);
                            }
                            else
                            {
                                this.MensaError(Rpta);
                            }
                        }


                    }
                }
                this.Listar();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void BtnDesactivar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult Opcion;
                Opcion = MessageBox.Show("Realmente deseas desacrivar el (los) Registro (s) ?", "Sistema de Ventas", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (Opcion == DialogResult.OK)
                {
                    int Codigo;
                    string Rpta = "";

                    foreach (DataGridViewRow row in DgvListado.Rows)
                    {
                        //si la celda actual que estoy recorriendo en la posicion 0 es true
                        //indica que se desea Eliminar
                        if (Convert.ToBoolean(row.Cells[0].Value))
                        {
                            //Establesco el valor que voy a eliminar y lo almaceno en la variable Codigo
                            Codigo = Convert.ToInt32(row.Cells[1].Value);
                            Rpta = NArticulo.Inactivar(Codigo);

                            if (Rpta.Equals("OK"))
                            {
                                this.MensajeOK("Se desactivó el registro" + Convert.ToString(row.Cells[5].Value));
                            }
                            else
                            {
                                this.MensaError(Rpta);
                            }
                        }


                    }
                }
                this.Listar();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void BtnActivar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult Opcion;
                Opcion = MessageBox.Show("Realmente deseas activar el (los) Registro (s) ?", "Sistema de Ventas", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (Opcion == DialogResult.OK)
                {
                    int Codigo;
                    string Rpta = "";

                    foreach (DataGridViewRow row in DgvListado.Rows)
                    {
                        //si la celda actual que estoy recorriendo en la posicion 0 es true
                        //indica que se desea Eliminar
                        if (Convert.ToBoolean(row.Cells[0].Value))
                        {
                            //Establesco el valor que voy a eliminar y lo almaceno en la variable Codigo
                            Codigo = Convert.ToInt32(row.Cells[1].Value);
                            Rpta = NArticulo.Activar(Codigo);

                            if (Rpta.Equals("OK"))
                            {
                                this.MensajeOK("Se activó el registro" + Convert.ToString(row.Cells[5].Value));
                            }
                            else
                            {
                                this.MensaError(Rpta);
                            }
                        }


                    }
                }
                this.Listar();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
    }
    
    
}
