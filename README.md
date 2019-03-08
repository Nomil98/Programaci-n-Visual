# Programaci-n-Visual
Actividades 
namespace Carrera_liebre_tortuga
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
      
        Liebre liebre = new Liebre(1);
        Tortuga tortuga = new Tortuga(2);
       

        private void btnCarrera_Click(object sender, EventArgs e)
        {
            do
            {
                liebre.Correr();
                tortuga.Correr();
                tablero.Text += liebre.Posicion + Environment.NewLine + tortuga.Posicion + Environment.NewLine;

            }
            while (liebre.Posicion <= 100 && tortuga.Posicion <= 100);
            if (liebre.Posicion == 99 && tortuga.Posicion == 99)
            {
                tablero.Text = "Es un empate.";
            }

            if (liebre.Posicion > 100)
                tablero.Text = "La liebre " + "en la posición" + liebre.Posicion.ToString() + " es la ganadora";

            else
                tablero.Text = "La tortuga" + "en la posición" + tortuga.Posicion.ToString() + " es la ganadora";


        }

        private void tablero_TextChanged(object sender, EventArgs e)
        {
            
        }
