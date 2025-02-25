using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Reto_PeliMundoAlanis
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // Agregar opciones al ComboBox de género
            cmbGenero2.Items.Add("Terror");
            cmbGenero2.Items.Add("Infantil");
            cmbGenero2.Items.Add("Romance");

            // Agregar opciones al ComboBox de días de retraso
            cmbRetraso2.Items.Add("0 días");
            cmbRetraso2.Items.Add("1 a 5 días");
            cmbRetraso2.Items.Add("6 a 9 días");
            cmbRetraso2.Items.Add("Más de 10 días");

            // Opcional: Seleccionar un valor por defecto
            cmbGenero2.SelectedIndex = 0;
            cmbRetraso2.SelectedIndex = 0;
        }
          
        private void btnRegresar_Click(object sender, EventArgs e)
        {
            // Crear una instancia de Form5
            Form5 form5 = new Form5();

            // Pasar la información de Form4 a Form5
            form5.NombrePelicula = txtNombre2.Text;
            form5.GeneroPelicula = cmbGenero2.SelectedItem.ToString();
            form5.DiasRetraso = cmbRetraso2.SelectedItem.ToString();

            // Calcular el costo de la renta
            double costoRenta = CalcularCostoRenta(form5.GeneroPelicula);
            form5.CostoRenta = costoRenta;

            double interes = 0;

            if (form5.DiasRetraso != "0 días") // Si no es 0 días, calcular interés
            {
                interes = CalcularInteres(form5.GeneroPelicula, form5.DiasRetraso, costoRenta);
            }

            // Si es 0 días, no se aplica interés
            form5.InteresRetraso = interes;

            // Calcular el costo total
            form5.CostoTotal = (form5.DiasRetraso == "0 días") ? costoRenta : costoRenta + interes;

            // Mostrar Form5
            form5.Show();
            // Cerrar Form4
            this.Close();
        }
        private double CalcularCostoRenta(string genero)
        {
            switch (genero)
            {
                case "Terror": return 100;
                case "Infantil": return 80;
                case "Romance": return 90;
                default: return 0;
            }
        }

        private double CalcularInteres(string genero, string diasRetraso, double costoRenta)
        {
            double interes = 0;

            switch (genero)
            {
                case "Terror":
                    if (diasRetraso == "1 a 5 días") interes = costoRenta * 0.10;
                    else if (diasRetraso == "6 a 9 días") interes = costoRenta * 0.20;
                    else if (diasRetraso == "Más de 10 días") interes = costoRenta * 0.30;
                    break;

                case "Romance":
                    if (diasRetraso == "1 a 5 días") interes = costoRenta * 0.15;
                    else if (diasRetraso == "6 a 9 días") interes = costoRenta * 0.25;
                    else if (diasRetraso == "Más de 10 días") interes = costoRenta * 0.35;
                    break;

                case "Infantil":
                    if (diasRetraso == "1 a 5 días") interes = costoRenta * 0.17;
                    else if (diasRetraso == "6 a 9 días") interes = costoRenta * 0.27;
                    else if (diasRetraso == "Más de 10 días") interes = costoRenta * 0.37;
                    break;
            }

            return interes;
        }
        private void cmbGenero2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
