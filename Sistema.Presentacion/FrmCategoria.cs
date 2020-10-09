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
            this.Limpiar(); //se llama al metodo limpiar antes de hacer el proceso
            BtnActualizar.Visible = true;//hacer visible el boton de actulizar
            BtnInsertar.Visible = false; //ocultar el boton de insertar
            TxtId.Text = Convert.ToString(DgvListado.CurrentRow.Cells["ID"].Value); //condo se de doble clic sobre el registro se lleve al control textbox para su edición
            TxtNombre.Text = Convert.ToString(DgvListado.CurrentRow.Cells["Nombre"].Value); //condo se de doble clic sobre el registro se lleve al control textbox para su edición
            TxtDescripcion.Text = Convert.ToString(DgvListado.CurrentRow.Cells["Descripcion"].Value); //condo se de doble clic sobre el registro se lleve al control textbox para su edición
            tabGeneral.SelectedIndex = 1; //pasar de manera automatica a la pagina para editar el registro
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
                    Rpta = NCategoria.Actualizar(Convert.ToInt32(TxtId.Text), TxtNombre.Text.Trim(), TxtDescripcion.Text.Trim());
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
    }
}
