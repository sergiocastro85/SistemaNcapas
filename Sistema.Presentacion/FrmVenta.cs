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
    public partial class FrmVenta : Form
    {
        private DataTable DtDetalle = new DataTable();

        public FrmVenta()
        {
            InitializeComponent();
        }
        public void Listar()
        {
            try
            {
                DgvListado.DataSource = NVenta.Listar();
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
                DgvListado.DataSource = NVenta.Buscar(TxtBuscar.Text);
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
            //datos de la columna del grid, formato
            DgvListado.Columns[0].Visible = false;
            DgvListado.Columns[1].Visible = false;
            DgvListado.Columns[2].Visible = false;
            DgvListado.Columns[0].Width = 100;
            DgvListado.Columns[1].Width = 60;
            DgvListado.Columns[3].Width = 150;
            DgvListado.Columns[4].Width = 150;
            DgvListado.Columns[5].Width = 100;
            DgvListado.Columns[5].HeaderText = "Documento";
            DgvListado.Columns[6].Width = 70;
            DgvListado.Columns[6].HeaderText = "Serie";
            DgvListado.Columns[7].Width = 70;
            DgvListado.Columns[7].HeaderText = "Número";
            DgvListado.Columns[8].Width = 60;
            DgvListado.Columns[9].Width = 100;
            DgvListado.Columns[10].Width = 10;
            DgvListado.Columns[11].Width = 100;
        }

        private void FormatoArticulos()
        {
            DgvArticulos.Columns[1].Visible = false;
            DgvArticulos.Columns[2].Width = 100;
            DgvArticulos.Columns[2].HeaderText = "Categoría";
            DgvArticulos.Columns[3].Width = 100;
            DgvArticulos.Columns[3].HeaderText = "Código";
            DgvArticulos.Columns[4].Width = 150;
            DgvArticulos.Columns[5].Width = 100;
            DgvArticulos.Columns[5].HeaderText = "Precio Venta";
            DgvArticulos.Columns[6].Width = 60;
            DgvArticulos.Columns[7].Width = 200;
            DgvArticulos.Columns[7].HeaderText = "Descripción";
            DgvArticulos.Columns[8].Width = 100;
        }

        private void Limpiar()
        {
            TxtBuscar.Clear();
            TxtId.Clear();
            TxtCodigo.Clear();
            TxtIdCliente.Clear();
            TxtSerie.Clear();
            TxtNumeroComprobante.Clear();
            DtDetalle.Clear();
            TxtSubTotal.Text = "0.000";
            TxtTotalImpuesto.Text = "0.000";
            TxtTotal.Text = "0.000";



            DgvListado.Columns[0].Visible = false;
            BtnAnular.Visible = false;
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

        private void CrearTabla()
        {
            //este metodo estpera dos parametros: el nombre de la columna y el tipo de dato de la columna
            this.DtDetalle.Columns.Add("idarticulo", System.Type.GetType("System.Int32"));
            this.DtDetalle.Columns.Add("codigo", System.Type.GetType("System.String"));
            this.DtDetalle.Columns.Add("articulo", System.Type.GetType("System.String"));
            this.DtDetalle.Columns.Add("stock", System.Type.GetType("System.Int32"));
            this.DtDetalle.Columns.Add("cantidad", System.Type.GetType("System.Int32"));
            this.DtDetalle.Columns.Add("precio", System.Type.GetType("System.Decimal"));
            this.DtDetalle.Columns.Add("descuento", System.Type.GetType("System.Decimal"));
            this.DtDetalle.Columns.Add("importe", System.Type.GetType("System.Decimal"));

            //Indicar la fuente de datos de datagridview
            DgvDetalle.DataSource = this.DtDetalle;

            DgvDetalle.Columns[0].Visible = false;
            DgvDetalle.Columns[1].HeaderText = "CODIGO";
            DgvDetalle.Columns[1].Width = 100;
            DgvDetalle.Columns[2].HeaderText = "ARTICULO";
            DgvDetalle.Columns[2].Width = 200;
            DgvDetalle.Columns[3].HeaderText = "STOCK";
            DgvDetalle.Columns[3].Width = 80;
            DgvDetalle.Columns[4].HeaderText = "CANTIDAD";
            DgvDetalle.Columns[4].Width = 70;
            DgvDetalle.Columns[5].HeaderText = "PRECIO";
            DgvDetalle.Columns[5].Width = 70;
            DgvDetalle.Columns[6].HeaderText = "DESCUENTO";
            DgvDetalle.Columns[6].Width = 80;
            DgvDetalle.Columns[7].HeaderText = "IMPORTE";
            DgvDetalle.Columns[7].Width = 80;

            //Indicamos que la columna 1,2,5 sean de solo lectura
            DgvDetalle.Columns[1].ReadOnly = true;
            DgvDetalle.Columns[2].ReadOnly = true;
            DgvDetalle.Columns[3].ReadOnly = true;
            DgvDetalle.Columns[7].ReadOnly = true;



        }

        private void FrmVenta_Load(object sender, EventArgs e)
        {
            this.Listar();
            //llamar metodo crear tabla
            this.CrearTabla();
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            this.Buscar();

        }

        private void BtnBuscarCliente_Click(object sender, EventArgs e)
        {
            //crear un objeto tipo vista de la clase FrmvistaClientevenata
            FrmVista_ClienteVenta vista = new FrmVista_ClienteVenta();
            vista.ShowDialog();
            TxtIdCliente.Text = Convert.ToString(Variables.IdCliente);
            TxtNombreCliente.Text = Variables.NombreCliente;
        }

        private void TxtCodigo_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtCodigo_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                //si la tecla enter es presionada, se hace la consulta enviando el parametro valor
                if (e.KeyCode == Keys.Enter)
                {
                    DataTable Tabla = new DataTable();
                    Tabla = NArticulo.BuscarcodigoVenta(TxtCodigo.Text.Trim());

                    if (Tabla.Rows.Count <= 0)
                    {
                        this.MensaError("No existe artículo con ese códgio de barras o no hay stock de ese artículo.");
                    }
                    else
                    {
                        //agregar detalle
                        //crear nuevo metodo
                        //Indice de los parametros que va recibir 
                        this.AgregarDetalle(Convert.ToInt32(Tabla.Rows[0][0]), Convert.ToString(Tabla.Rows[0][1]), Convert.ToString(Tabla.Rows[0][2]), Convert.ToInt32(Tabla.Rows[0][4]), Convert.ToDecimal(Tabla.Rows[0][3]));

                    }
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void AgregarDetalle(int IdArticulo, string Codigo, string Nombre, int Stock, decimal Precio)
        {
            bool Agregar = true;

            //recorrer todas las filas que se tienen en el gridview dgDetalle
            foreach (DataRow FilaTem in DtDetalle.Rows)
            {
                if (Convert.ToInt32(FilaTem["idarticulo"]) == IdArticulo)
                {
                    Agregar = false;
                    this.MensaError("El Articulo ya ha sido agredado");
                }
            }

            //si agregar el verdadero me permite agregar

            if (Agregar)
            {
                DataRow Fila = DtDetalle.NewRow();
                Fila["idarticulo"] = IdArticulo;
                Fila["codigo"] = Codigo;
                Fila["articulo"] = Nombre;
                Fila["stock"] = Stock;
                Fila["Cantidad"] = 1;
                Fila["precio"] = Precio;
                Fila["descuento"] = 0;
                Fila["importe"] = Precio;
                this.DtDetalle.Rows.Add(Fila);
                this.CalcularTotales();

            }

        }
        private void CalcularTotales()
        {
            decimal Total = 0;
            decimal Subtotal = 0;

            if (DgvDetalle.Rows.Count == 0)
            {
                Total = 0;
            }
            else
            {
                foreach (DataRow FilaTemp in DtDetalle.Rows)
                {
                    Total = Total + Convert.ToDecimal(FilaTemp["importe"]);
                }

            }

            Subtotal = Total / (1 + Convert.ToDecimal(TxtImpuesto.Text));
            TxtTotal.Text = Total.ToString("#0.00#");
            TxtTotalImpuesto.Text = (Total - Subtotal).ToString("#0.00#");
        }

        private void BtnVerArticulos_Click(object sender, EventArgs e)
        {
            PanelArticulos.Visible = true;
        }

        private void BtnCerrarArticulos_Click(object sender, EventArgs e)
        {
            PanelArticulos.Visible = false;
        }

        private void BtnFiltrarArticulo_Click(object sender, EventArgs e)
        {
            try
            {
                //llenar el datagrid con lo que hay en la clase narticulo
                DgvArticulos.DataSource = NArticulo.BuscaVenta(TxtBuscarArticulo.Text);
                //llamamos el metodo formato articulos
                this.FormatoArticulos();
                LblTotalArticulos.Text = "Total Registros: " + Convert.ToString(DgvArticulos.Rows.Count);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void DgvArticulos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int IdArticulo;
            string Codigo, Nombre;
            decimal Precio;
            int Stock;
            IdArticulo = Convert.ToInt32(DgvArticulos.CurrentRow.Cells["ID"].Value);
            Codigo = Convert.ToString(DgvArticulos.CurrentRow.Cells["Codigo"].Value);
            Nombre = Convert.ToString(DgvArticulos.CurrentRow.Cells["Nombre"].Value);
            Stock = Convert.ToInt32(DgvArticulos.CurrentRow.Cells["Stock"].Value);
            Precio = Convert.ToDecimal(DgvArticulos.CurrentRow.Cells["Precio_Venta"].Value);
            //se llama al metodo agregar detalle
            this.AgregarDetalle(IdArticulo, Codigo, Nombre, Stock, Precio);
        }

        private void DgvDetalle_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            //encibtra la fila de la celda que se esta modificando
            DataRow Fila = (DataRow)DtDetalle.Rows[e.RowIndex];

            string Articulo = Convert.ToString(Fila["articulo"]);
            int Cantidad = Convert.ToInt32(Fila["cantidad"]);
            int Stock = Convert.ToInt32(Fila["stock"]);
            decimal Precio = Convert.ToDecimal(Fila["precio"]);
            decimal Descuento = Convert.ToDecimal(Fila["descuento"]);

            if (Cantidad > Stock)
            {
                Cantidad = Stock;
                this.MensaError("La cantidad de venta del artículo" + Articulo + "Supera la cantidad del stock" + Stock);
                Fila["cantidad"] = Cantidad;
            }
            Fila["importe"] = (Precio * Cantidad) - Descuento;

            this.CalcularTotales();

        }

        private void BtnInsertar_Click(object sender, EventArgs e)
        {
            try
            {
                string Rpta = "";
                //validar el idproveedor, validar el impuesto, número de comprobante, que contenga al menos 1 fila, de lo contrario muestre un error
                if (TxtIdCliente.Text == string.Empty || TxtImpuesto.Text == string.Empty || TxtNumeroComprobante.Text == string.Empty || DtDetalle.Rows.Count == 0)
                {
                    this.MensaError("Falta ingresar algunos datos , seran remarcados .");
                    ErrorIcono.SetError(TxtIdCliente, "Seleccione algun Cliente.");
                    ErrorIcono.SetError(TxtImpuesto, "Ingrese un Impuesto.");
                    ErrorIcono.SetError(TxtNumeroComprobante, "Ingres un número de comprobante.");
                    ErrorIcono.SetError(DgvDetalle, "Ingres al menos un detalle.");
                }
                else
                {
                    Rpta = NVenta.Insertar(Convert.ToInt32(TxtIdCliente.Text), Variables.IdUsuario, CboComprobante.Text, TxtSerie.Text.Trim(), TxtNumeroComprobante.Text.Trim(), Convert.ToDecimal(TxtImpuesto.Text), Convert.ToDecimal(TxtTotal.Text), DtDetalle);
                    if (Rpta.Equals("OK"))
                    {
                        this.MensajeOK("Se inserto de forma correcta el registro");
                        this.Limpiar();
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

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Limpiar();
            tabGeneral.SelectedIndex = 0;
        }

        private void DgvListado_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DgvMostrarDetalles.DataSource = NVenta.ListarDetalle(Convert.ToInt32(DgvListado.CurrentRow.Cells["ID"].Value));

                decimal Total, Subtotal;
                decimal Impuesto = Convert.ToDecimal(DgvListado.CurrentRow.Cells["Impuesto"].Value);
                Total = Convert.ToDecimal(DgvListado.CurrentRow.Cells["Total"].Value);
                Subtotal = Total / (1 + Impuesto);

                TxtSubtotalD.Text = Subtotal.ToString("#0.00#");
                TxtTotalD.Text = Total.ToString("#0.00#");
                TxtImpuestoD.Text = (Total - Subtotal).ToString("#0.00#");

                PnMostrarDestalles.Visible = true;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnCerrarD_Click(object sender, EventArgs e)
        {
            PnMostrarDestalles.Visible = false;
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
            if (ChkSeleccionar.Checked)
            {
                DgvListado.Columns[0].Visible = true;
                BtnAnular.Visible = true;

            }
            else
            {
                DgvListado.Columns[0].Visible = false;
                BtnAnular.Visible = false;

            }
        }

        private void BtnAnular_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult Opcion;
                Opcion = MessageBox.Show("Realmente deseas Anular el (los) Registro (s) ?", "Sistema de Ventas", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

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
                            Rpta = NVenta.Anular(Codigo);

                            if (Rpta.Equals("OK"))
                            {
                                this.MensajeOK("Se Anuló el registro" + Convert.ToString(row.Cells[6].Value) + "-" + Convert.ToString(row.Cells[7].Value));
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

