using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_03_Area_y_Perimetro_de_un_Circulo
{
    public partial class Form1 : Form
    {
        Double Radio;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtRadio_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void lblArea_Click(object sender, EventArgs e)
        {

        }

        private void lblPeri_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Radio = Math.Pow(Convert.ToDouble(txtRadio.Text), 2) * Math.PI;
            lblArea.Text = Convert.ToString(Radio);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Radio = (Convert.ToDouble(txtRadio.Text) * 2) * Math.PI;
            lblPeri.Text = Convert.ToString(Radio);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
