using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vectores_SegundaParcial
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        miVector vector;
        private void BtnCrear_Click(object sender, EventArgs e)
        {
            vector = new miVector(Convert.ToInt32(TxtTam.Text));

        }
        
        private void BtnLlenar_Click(object sender, EventArgs e)
        {
            vector.Llenar(Convert.ToInt32(TxtVal.Text));


        }

        private void BtnMostrar_Click(object sender, EventArgs e)
        {
            TxtVec.Text = Convert.ToString(vector.Mostrar());

        }

        private void BtnInvertir_Click(object sender, EventArgs e)
        {
            vector.GirarArriba();
            TxtVec.Text = vector.Mostrar();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            vector.GirarAbajo();
            TxtVec.Text = vector.Mostrar();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            vector.Invertir();
            TxtVec.Text = vector.Mostrar();
        }
    }
}
