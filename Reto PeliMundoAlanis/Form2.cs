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

namespace Reto_PeliMundoAlanis
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            this.Load += new EventHandler(Form2_Load);
        }

        private void ComGenero_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

            // Agregar los géneros al ComboBox
            ComGenero1.Items.Add("Terror");
            ComGenero1.Items.Add("Infantil");
            ComGenero1.Items.Add("Romance");

            // Establecer un valor predeterminado
            ComGenero1.SelectedIndex = 0; //seleciono uno 
        }

        private void btnRentar_Click(object sender, EventArgs e)
        {

            // Obtener el género seleccionado del ComboBox
            string generoSeleccionado = ComGenero1.SelectedItem.ToString();
            // Obtener el nombre de la película desde el TextBox
            string nombrePelicula = txtNomPeli1.Text;
            // Obtener la fecha seleccionada en el DateTimePicker
            DateTime fechaSeleccionada = FechaInicio1.Value; 
            // Sumar 7 días (1 semana) a la fecha seleccionada
            DateTime fechaNueva = fechaSeleccionada.AddDays(7);

            // Crear una instancia de Form3 y pasar el género seleccionado
            Form3 form3 = new Form3(generoSeleccionado, nombrePelicula, fechaNueva);

            // Mostrar Form3
            form3.Show();

            // Opcional: Cerrar Form2 si ya no se necesita
            this.Hide();
        }

        private void FechaInicio1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
