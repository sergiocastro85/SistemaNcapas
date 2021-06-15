using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema.Presentacion
{
    public partial class FrmArqueo : Form
    {
        public FrmArqueo()
        {
            InitializeComponent();

            Calcular();

        }

        private void Calcular()
        {
            int cien= Convert.ToInt32(textBox1.Text) * 100000;
            LblCien.Text = Convert.ToString(cien);

            int cincuenta = Convert.ToInt32(textBox2.Text) * 50000;
            LblCincuenta.Text = Convert.ToString(cincuenta);

            int veinte = Convert.ToInt32(textBox3.Text) * 20000;
            LblVeinte.Text = Convert.ToString(veinte);

            int diez = Convert.ToInt32(textBox4.Text) * 10000;
            LblDiez.Text = Convert.ToString(diez);

            int cincomil = Convert.ToInt32(textBox5.Text) * 5000;
            LblCinco.Text = Convert.ToString(cincomil);

            int cuatromil = Convert.ToInt32(textBox6.Text) * 4000;
            LblCuatro.Text = Convert.ToString(cuatromil);

            int tresmil = Convert.ToInt32(textBox7.Text) * 3000;
            LblTres.Text = Convert.ToString(tresmil);

            int dosmil = Convert.ToInt32(textBox8.Text) * 2000;
            LblDos.Text = Convert.ToString(dosmil);

            int mil = Convert.ToInt32(textBox9.Text) * 1000;
            LblMil.Text = Convert.ToString(mil);

            int quinientos = Convert.ToInt32(textBox10.Text) * 500;
            LblQuinientos.Text = Convert.ToString(quinientos);

            int docientos = Convert.ToInt32(textBox11.Text) * 200;
            LblDocientos.Text = Convert.ToString(docientos);

            int cientepesos = Convert.ToInt32(textBox12.Text) * 100;
            LblcCien.Text = Convert.ToString(cientepesos);

            int cincuentapesos = Convert.ToInt32(textBox13.Text) * 50;
            LblcCincuenta.Text = Convert.ToString(cincuentapesos);

            int subtotal = cien + cincuenta + veinte + diez + cincomil + dosmil + mil + quinientos + docientos + cientepesos + cincuentapesos;

            int total = subtotal - Convert.ToInt32(TxtTotalBanco.Text);

            textBox14.Text = Convert.ToString(total);

        }


        private void textBox14_TabIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {
        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            Calcular();

        }

        private void textBox14_Enter(object sender, EventArgs e)
        {
            Calcular();
        }
    }
}
