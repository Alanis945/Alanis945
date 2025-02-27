using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen_de_segundo_parcial
{
    public partial class Form2 : Form
    {
        public Form2(string mes, int dia)
        {
            InitializeComponent();

            lblMesDia.Text = $"{mes} {dia}";

            string signo = "";
            string fechasigno = "";

            //  Ruta de la carpeta externa donde están las imágenes
            string rutaImagenes = @"C:\Users\L480\Pictures\sodiacal";  // Cambia esto según tu disco externo

            // asignar signo, fechas y nombre de archivo de imagen
            string nombreImagen = "";
            if ((mes == "MARZO" && dia >= 21) || (mes == "ABRIL" && dia <= 19))
            {
                signo = "ARIES";
                fechasigno = "ARIES: 21 de MARZO al 19 de ABRIL";
                nombreImagen = "aries.jpg";
            }
            else if ((mes == "ABRIL" && dia >= 20) || (mes == "MAYO" && dia <= 20))
            {
                signo = "TAURO";
                fechasigno = "TAURO: 20 de ABRIL al 20 de MAYO";
                nombreImagen = "tauro.jpg";
            }
            else if ((mes == "MAYO" && dia >= 21) || (mes == "JUNIO" && dia <= 20))
            {
                signo = "GÉMINIS";
                fechasigno = "GÉMINIS: 21 de MAYO al 20 de JUNIO";
                nombreImagen = "geminis.jpg";
            }
            else if ((mes == "JUNIO" && dia >= 21) || (mes == "JULIO" && dia <= 22))
            {
                signo = "CÁNCER";
                fechasigno = "CÁNCER: 21 de JUNIO al 22 de JULIO";
                nombreImagen = "cancer.jpg";
            }
            else if ((mes == "JULIO" && dia >= 23) || (mes == "AGOSTO" && dia <= 22))
            {
                signo = "LEO";
                fechasigno = "LEO: 23 de JULIO al 22 de AGOSTO";
                nombreImagen = "leo.jpg";
            }
            else if ((mes == "AGOSTO" && dia >= 23) || (mes == "SEPTIEMBRE" && dia <= 22))
            {
                signo = "VIRGO";
                fechasigno = "VIRGO: 23 de AGOSTO al 22 de SEPTIEMBRE";
                nombreImagen = "virgo.jpg";
            }
            else if ((mes == "SEPTIEMBRE" && dia >= 23) || (mes == "OCTUBRE" && dia <= 22))
            {
                signo = "LIBRA";
                fechasigno = "LIBRA: 23 de SEPTIEMBRE al 22 de OCTUBRE";
                nombreImagen = "libra.jpg";
            }
            else if ((mes == "OCTUBRE" && dia >= 23) || (mes == "NOVIEMBRE" && dia <= 21))
            {
                signo = "ESCORPIO";
                fechasigno = "ESCORPIO: 23 de OCTUBRE al 21 de NOVIEMBRE";
                nombreImagen = "escorpio.jpg";
            }
            else if ((mes == "NOVIEMBRE" && dia >= 22) || (mes == "DICIEMBRE" && dia <= 21))
            {
                signo = "SAGITARIO";
                fechasigno = "SAGITARIO: 22 de NOVIEMBRE al 21 de DICIEMBRE";
                nombreImagen = "sagitario.jpg";
            }
            else if ((mes == "DICIEMBRE" && dia >= 22) || (mes == "ENERO" && dia <= 19))
            {
                signo = "CAPRICORNIO";
                fechasigno = "CAPRICORNIO: 22 de DICIEMBRE al 19 de ENERO";
                nombreImagen = "capricornio.jpg";
            }
            else if ((mes == "ENERO" && dia >= 20) || (mes == "FEBRERO" && dia <= 18))
            {
                signo = "ACUARIO";
                fechasigno = "ACUARIO: 20 de ENERO al 18 de FEBRERO";
                nombreImagen = "aquario.jpg";
            }
            else if ((mes == "FEBRERO" && dia >= 19) || (mes == "MARZO" && dia <= 20))
            {
                signo = "PISCIS";
                fechasigno = "PISCIS: 19 de FEBRERO al 20 de MARZO";
                nombreImagen = "pisis.jpg";
            }

            // Muestra el signo y las fechas en las etiquetas
            lblSigno.Text = signo;
            lblSignoFecha.Text = fechasigno;

            // Verifica si la imagen existe antes de intentar cargarla
            string rutaImagen = Path.Combine(rutaImagenes, nombreImagen);
            if (File.Exists(rutaImagen))
            {
                try
                {
                    imgSigno.Image = new Bitmap(rutaImagen); // Carga directamente la imagen
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al cargar la imagen: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show($"Imagen no encontrada: {rutaImagen}", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
