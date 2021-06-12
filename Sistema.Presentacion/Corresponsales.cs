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
    public partial class Corresponsales : Form
    {
        public Corresponsales()
        {
            InitializeComponent();
        }

        public void CargarCorresponsal()
        {
            CboCorresponsales.DataSource = NPac.ListadoCorresponsal();
            CboCorresponsales.DisplayMember = "Nombre";
            CboCorresponsales.ValueMember = "idPac";
        }

        private void Corresponsales_Load(object sender, EventArgs e)
        {
            this.CargarCorresponsal();
        }
    }
}
