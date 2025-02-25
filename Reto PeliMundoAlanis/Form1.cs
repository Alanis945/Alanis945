using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reto_PeliMundoAlanis
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRentar_Click(object sender, EventArgs e)
        {
            // Crear una instancia del formulario 2 (que es donde mandara a "Rentar Película")
            Form2 form2 = new Form2();

            // Ocultar el formulario actual (Form1)
            this.Hide();

            // Mostrar el formulario 2
            form2.Show();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            // Crear una instancia del formulario 4 (que es donde mandara a "Regresar Película")
            Form4 form4 = new Form4();

            // Ocultar el formulario actual (Form1)
            this.Hide();

            // Mostrar el formulario 4
            form4.Show();
        }
    }
}
