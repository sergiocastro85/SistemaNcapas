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
    public partial class FrmCategoria : Form
    {
        private string NombreAnt;

        public FrmCategoria()
        {
            InitializeComponent();
        }

        public void Listar()
        {
            try
            {
                DgvListado.DataSource = NCategoria.Listar();
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
                DgvListado.DataSource = NCategoria.Buscar(TxtBuscar.Text);
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
            DgvListado.Columns[1].Visible = false;
            DgvListado.Columns[2].Width = 150;
            DgvListado.Columns[3].Width = 400;
            DgvListado.Columns[3].HeaderText = "Descripción";
        }

        private void Limpiar()
        {
            TxtBuscar.Clear();
            TxtNombre.Clear();
            TxtDescripcion.Clear();
            TxtId.Clear();
            BtnInsertar.Visible = true;
            BtnActualizar.Visible = false; //ocultar el boton de actualizar
            ErrorIcono.Clear();

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

        private void FrmCategoria_Load(object sender, EventArgs e)
        {
            this.Listar();

        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            this.Buscar();

        }

        private void BtnInsertar_Click(object sender, EventArgs e)
        {
            try
            {
                string Rpta = "";
                if (TxtNombre.Text == string.Empty)
                {
                    this.MensaError("Falta ingresar algunos datos , seran remarcados .");
                    ErrorIcono.SetError(TxtNombre, "Ingrese el Nombre");
                }
                else
                {
                    Rpta = NCategoria.Insertar(TxtNombre.Text.Trim(), TxtDescripcion.Text.Trim());
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
            catch(Exception ex)
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
                this.Limpiar(); //se llama al metodo limpiar antes de hacer el proceso
                BtnActualizar.Visible = true;//hacer visible el boton de actulizar
                BtnInsertar.Visible = false; //ocultar el boton de insertar
                TxtId.Text = Convert.ToString(DgvListado.CurrentRow.Cells["ID"].Value); //condo se de doble clic sobre el registro se lleve al control textbox para su edición
                this.NombreAnt = Convert.ToString(DgvListado.CurrentRow.Cells["Nombre"].Value); //condo se de doble clic sobre el registro se lleve al control textbox para su edición
                TxtNombre.Text = Convert.ToString(DgvListado.CurrentRow.Cells["Nombre"].Value); //condo se de doble clic sobre el registro se lleve al control textbox para su edición
                TxtDescripcion.Text = Convert.ToString(DgvListado.CurrentRow.Cells["Descripcion"].Value); //condo se de doble clic sobre el registro se lleve al control textbox para su edición
                tabGeneral.SelectedIndex = 1; //pasar de manera automatica a la pagina para editar el registro
            }
            catch (Exception)
            {
                MessageBox.Show("Selecciones desde la celda Nombre.");
            }
            

        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                string Rpta = "";
                if (TxtNombre.Text==string.Empty || TxtId.Text == string.Empty) // si los campos de texto estan vacios marcar error
                {
                    this.MensaError("Falta ingresar algunos campos, se remarcaran");
                    ErrorIcono.SetError(TxtNombre, "Ingrese Nombre");
                }
                else
                {
                    Rpta = NCategoria.Actualizar(Convert.ToInt32(TxtId.Text), this.NombreAnt,TxtNombre.Text.Trim(), TxtDescripcion.Text.Trim());
                    if (Rpta.Equals("OK")) // si me regrega un OK, se muestra el mensaje que el resgitro se guardo correctamente
                    {
                        this.MensajeOK("Se actulizo el registro correctamente");
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

        private void DgvListado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //el objeto e, sale del evento private void DgvListado_CellContentClick(object sender, DataGridViewCellEventArgs e)
            if (e.ColumnIndex==DgvListado.Columns["Seleccionar"].Index)
            {
                DataGridViewCheckBoxCell ChkEliminar = (DataGridViewCheckBoxCell)DgvListado.Rows[e.RowIndex].Cells["Seleccionar"];
                ChkEliminar.Value = !Convert.ToBoolean(ChkEliminar.Value);

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

                    foreach(DataGridViewRow row in DgvListado.Rows)
                    {
                        //si la celda actual que estoy recorriendo en la posicion 0 es true
                        //indica que se desea Eliminar
                        if (Convert.ToBoolean(row.Cells[0].Value))
                        {
                            //Establesco el valor que voy a eliminar y lo almaceno en la variable Codigo
                            Codigo = Convert.ToInt32(row.Cells[1].Value);
                            Rpta = NCategoria.Eliminar(Codigo);
                            
                            if (Rpta.Equals("OK"))
                            {
                                this.MensajeOK("Se eliminó el registro" + Convert.ToString(row.Cells[2].Value));
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
