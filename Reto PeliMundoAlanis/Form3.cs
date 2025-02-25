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
    public partial class Form3 : Form
    {
        public Form3( String Genero, String nombrePelicula, DateTime fechaNueva)

        {
            InitializeComponent();

            // Asignar el nombre de la película al Label
            lblNomPeli1.Text = nombrePelicula;
            // Aquí se muestra el género recibido en un Label
            lblGenero1.Text = Genero;
            // Mostrar la fecha nueva en el Label. Puedes darle el formato que desees.
            lblFechaFinal1.Text = fechaNueva.ToShortDateString();  // Muestra la fecha en formato corto
            // Variables para el precio y la imagen
            string precio = "";
            string rutaImagen = "";


            if (Genero == "Terror")
            {
                precio = "$100";
                // Cambia esta ruta por la ubicación real de la imagen de Terror
                rutaImagen = "C:\\Users\\L480\\Pictures\\Screenshots\\TERROR2.png";
                lblAtencion.Text = "📌 Importante: Se aplicarán cargos por intereses en caso de retraso en la devolución:\r\n🔹 Retraso de 1 a 5 días:\r\n       10% de interés sobre el costo de la renta.\r\n🔹 Retraso de 6 a 9 días:\r\n       20% de interés sobre el costo de la renta.\r\n🔹 Retraso de 10 días o más:\r\n       30% de interés sobre el costo de la renta.\r\nPara evitar cargos adicionales, te recomendamos devolver la película en la fecha establecida.\r\n Si tienes dudas o necesitas más información, no dudes en contactarnos.\r\n¡Disfruta tu película! 🎥🍿";
            }
            else if (Genero == "Infantil")
            {
                precio = "$80";
                // Cambia esta ruta por la ubicación real de la imagen Infantil
                rutaImagen = "C:\\Users\\L480\\Pictures\\Screenshots\\INFANTIL2.png";
                lblAtencion.Text = "📌 Importante: Se aplicarán cargos por intereses en caso de retraso en la devolución:\r\n🔹 Retraso de 1 a 5 días:\r\n       15% de interés sobre el costo de la renta.\r\n🔹 Retraso de 6 a 9 días:\r\n       25% de interés sobre el costo de la renta.\r\n🔹 Retraso de 10 días o más:\r\n       35% de interés sobre el costo de la renta.\r\nPara evitar cargos adicionales, te recomendamos devolver la película en la fecha establecida.\r\n Si tienes dudas o necesitas más información, no dudes en contactarnos.\r\n¡Disfruta tu película! 🎥🍿";
            }
            else if (Genero == "Romance")
            {
                precio = "$90";
                // Cambia esta ruta por la ubicación real de la imagen de Romance
                rutaImagen = "C:\\Users\\L480\\Pictures\\Screenshots\\ROMANCE2.png";
                lblAtencion.Text = "📌 Importante: Se aplicarán cargos por intereses en caso de retraso en la devolución:\r\n🔹 Retraso de 1 a 5 días:\r\n       17% de interés sobre el costo de la renta.\r\n🔹 Retraso de 6 a 9 días:\r\n       27% de interés sobre el costo de la renta.\r\n🔹 Retraso de 10 días o más:\r\n       37% de interés sobre el costo de la renta.\r\nPara evitar cargos adicionales, te recomendamos devolver la película en la fecha establecida.\r\n Si tienes dudas o necesitas más información, no dudes en contactarnos.\r\n¡Disfruta tu película! 🎥🍿\r\n";
            }

            // Mostrar el precio en el Label
            lblCosto1.Text = precio;

            // Cargar la imagen en el PictureBox, verificando que la ruta exista
            if (File.Exists(rutaImagen))
            {
                ImagenTRI.Image = Image.FromFile(rutaImagen);
                // Opcional: Ajustar la imagen para que se adapte al PictureBox
                ImagenTRI.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else
            {
                MessageBox.Show("Imagen no encontrada: " + rutaImagen);
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblGenero_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void lblNomPeli1_Click(object sender, EventArgs e)
        {

        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            // Crear una instancia de Form1
            Form1 form1 = new Form1();

            // Mostrar Form1
            form1.Show();

            // Cerrar Form3
            this.Close();
        }
    }
}
