using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coladera_Eratostenes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Coladera_Eratostenes vector = new Coladera_Eratostenes();
        private void button1_Click(object sender, EventArgs e)
        {
            vector.Llenar();
            vector.Coladera();


        }

        private void BtnMostrar_Click(object sender, EventArgs e)
        {
            listBox1.Text = vector.Mostrar();
        }
    }
}
