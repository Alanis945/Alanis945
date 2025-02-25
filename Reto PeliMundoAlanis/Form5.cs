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
    public partial class Form5 : Form
    {
        public string NombrePelicula { get; set; }
        public string GeneroPelicula { get; set; }
        public string DiasRetraso { get; set; }
        public double CostoRenta { get; set; }
        public double InteresRetraso { get; set; }
        public double CostoTotal { get; set; }
        public Form5()
        {
            InitializeComponent();
        }
        private void Form5_Load(object sender, EventArgs e)
        {
            // Mostrar la información en los Labels
            lblPelicula2.Text = NombrePelicula;
            lblGenero2.Text = GeneroPelicula;
            lblRenta.Text = $"${CostoRenta}";

            lblDiaRetraso.Text = DiasRetraso;
            lblInteres.Text = $"${InteresRetraso}";
            lblCostoTotal.Text = $"${CostoTotal}";
            // Cargar la imagen según el género
            CargarImagenPorGenero();
        }
        private void CargarImagenPorGenero()
        {
            // Especifica la ruta de las imágenes según el género
            string rutaImagen = "";

            switch (GeneroPelicula)
            {
                case "Terror":
                    rutaImagen = "C:\\Users\\L480\\Pictures\\Screenshots\\TERROR2.png";  // Ruta local
                    break;
                case "Infantil":
                    rutaImagen = "C:\\Users\\L480\\Pictures\\Screenshots\\INFANTIL2.png";
                    break;
                case "Romance":
                    rutaImagen = "C:\\Users\\L480\\Pictures\\Screenshots\\ROMANCE2.png";
                    break;
                default:
                    ptbImagen2.Image = null; // Si no coincide, no muestra imagen
                    return;
            }

            // Verificar si el archivo existe antes de asignarlo
            if (File.Exists(rutaImagen))
            {
                ptbImagen2.Image = Image.FromFile(rutaImagen);
            }
            else
            {
                MessageBox.Show("No se encontró la imagen en la ruta: " + rutaImagen);
            }
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            // Crear una instancia de Form1
            Form1 form1 = new Form1();

            // Mostrar Form1
            form1.Show();

            // Cerrar Form5
            this.Close();
        }
    }
}
