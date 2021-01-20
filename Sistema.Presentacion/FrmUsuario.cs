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
    public partial class FrmUsuario : Form
    {

        //se declara esta variable, para poder hacer la validación si ya existe el Email.
        private string EmailAnt;

        public FrmUsuario()
        {
            InitializeComponent();
        }
        public void Listar()
        {
            try
            {
                DgvListado.DataSource = NUsuario.Listar();
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
                DgvListado.DataSource = NUsuario.Buscar(TxtBuscar.Text);
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
            DgvListado.Columns[1].Width = 50;
            DgvListado.Columns[3].Width = 100;
            DgvListado.Columns[4].Width = 170;
            DgvListado.Columns[5].Width = 100;
            DgvListado.Columns[5].HeaderText = "Documento";
            DgvListado.Columns[6].Width = 100;
            DgvListado.Columns[6].HeaderText = "Número Doc.";
            DgvListado.Columns[7].Width = 120;
            DgvListado.Columns[7].HeaderText = "Dirección";
            DgvListado.Columns[8].Width = 100;
            DgvListado.Columns[8].HeaderText = "Teléfono";
            DgvListado.Columns[9].Width = 120;
        }

        private void Limpiar()
        {
            TxtBuscar.Clear();
            TxtNombre.Clear();
            TxtId.Clear();
            TxtNumDocumento.Clear();
            TxtDireccion.Clear();
            TxtTelefono.Clear();
            TxtEmail.Clear();
            TxtClave.Clear();
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

        private void CargarRol()
        {
            try
            {
                CboRol.DataSource = NRol.Listar();
                CboRol.ValueMember = "idrol";
                CboRol.DisplayMember = "nombre";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void FrmUsuario_Load(object sender, EventArgs e)
        {
            this.Listar();
            this.CargarRol();

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
                //validar que los campos obligatorios no se encuentren vacios
                if (CboRol.Text ==string.Empty||TxtNombre.Text == string.Empty|| TxtEmail.Text==string.Empty|| TxtClave.Text==string.Empty)
                {
                    this.MensaError("Falta ingresar algunos datos , seran remarcados .");
                    ErrorIcono.SetError(CboRol, "Seleccione un rol.");
                    ErrorIcono.SetError(TxtNombre, "Ingrese el Nombre");
                    ErrorIcono.SetError(TxtEmail, "Ingrese el Email");
                    ErrorIcono.SetError(TxtClave, "Ingrese una clave");
                }
                else
                {
                    Rpta = NUsuario.Insertar(Convert.ToInt32(CboRol.SelectedValue),TxtNombre.Text.Trim(),CboTipoDocumento.Text,TxtNumDocumento.Text.Trim(),TxtDireccion.Text.Trim(),TxtTelefono.Text.Trim(),TxtEmail.Text.Trim(),TxtClave.Text.Trim());
                    if (Rpta.Equals("OK"))
                    {
                        this.MensajeOK("Se inserto de forma correcta el registro");
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

        private void DgvListado_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                //llamar al metodo limpiar
                this.Limpiar();
                BtnActualizar.Visible = true;
                BtnInsertar.Visible = false;
                TxtId.Text = Convert.ToString(DgvListado.CurrentRow.Cells["ID"].Value);
                CboRol.SelectedValue = Convert.ToString(DgvListado.CurrentRow.Cells["idRol"].Value);
                TxtNombre.Text = Convert.ToString(DgvListado.CurrentRow.Cells["Nombre"].Value);
                CboTipoDocumento.Text = Convert.ToString(DgvListado.CurrentRow.Cells["Tipo_Documento"].Value);
                TxtNumDocumento.Text = Convert.ToString(DgvListado.CurrentRow.Cells["Num_Documento"].Value);
                TxtDireccion.Text = Convert.ToString(DgvListado.CurrentRow.Cells["Direccion"].Value);
                TxtTelefono.Text = Convert.ToString(DgvListado.CurrentRow.Cells["Telefono"].Value);
                this.EmailAnt= Convert.ToString(DgvListado.CurrentRow.Cells["Email"].Value);
                TxtEmail.Text = Convert.ToString(DgvListado.CurrentRow.Cells["Email"].Value);

                //mostramos el formulario
                tabGeneral.SelectedIndex = 1;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Seleccione desde la celda nombre." + "|Error:" + ex.Message);
            }
        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                string Rpta = "";
                //validar que los campos obligatorios no se encuentren vacios
                if (TxtId.Text==string.Empty ||CboRol.Text == string.Empty || TxtNombre.Text == string.Empty || TxtEmail.Text == string.Empty)
                {
                    this.MensaError("Falta ingresar algunos datos , seran remarcados .");
                    ErrorIcono.SetError(CboRol, "Seleccione un rol.");
                    ErrorIcono.SetError(TxtNombre, "Ingrese el Nombre");
                    ErrorIcono.SetError(TxtEmail, "Ingrese el Email");
                    ErrorIcono.SetError(TxtClave, "Ingrese una clave");
                }
                else
                {
                    Rpta = NUsuario.Actualizar(Convert.ToInt32(TxtId.Text),Convert.ToInt32(CboRol.SelectedValue), TxtNombre.Text.Trim(), CboTipoDocumento.Text, TxtNumDocumento.Text.Trim(), TxtDireccion.Text.Trim(), TxtTelefono.Text.Trim(), this.EmailAnt,TxtEmail.Text.Trim(), TxtClave.Text.Trim());
                    if (Rpta.Equals("OK"))
                    {
                        this.MensajeOK("Se Actualizo de forma correcta el registro");
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
    }
}
