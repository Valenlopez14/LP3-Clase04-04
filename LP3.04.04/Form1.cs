using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace LP3._04._04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            //Creamos el objeto 
            StreamWriter sw = new StreamWriter("SAPITO.txt", true); 
            //WriteLine escribe con salto de linea, Write escribe todo seguido 
            sw.WriteLine(txtFrase.Text);
            sw.Close();
            //elimina los obj para que no queden los archivos en memoria 
            sw.Dispose();
            
        }

        private void btnGrabar2_Click(object sender, EventArgs e)
        {
            String[] frutas = { "PERA", "MANZANA", "SANDIA" };
            //Se usa para recorrer colecciones (Puede ser un vector)
            foreach(String fruta in frutas )
            {
                MessageBox.Show(fruta);

            }
        }

        private void btnGrabar3_Click(object sender, EventArgs e)
        {
            String linea = "";
            StreamReader sr = new StreamReader("SAPITO.txt");
            //Mientras no sea fin de archivo 
            while (sr.EndOfStream != true)
            {
                linea = sr.ReadLine();
                MessageBox.Show(linea);

            }
            sr.Close();
            sr.Dispose();
        }
    }
}
