using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practica_5_sistema_de_calificaciones
{
    public partial class Form1 : Form
    {
        Decimal CalFin;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // traslada el nombre del estudiante 
            lblNombre.Text = txtNom.Text;
            txtNom.Text = "";

        try
        { 
            // Convertir el contenido de cada TextBox a decimal
            decimal cal1 = Convert.ToDecimal(txt1.Text);
            decimal cal2 = Convert.ToDecimal(txt2.Text);
            decimal cal3 = Convert.ToDecimal(txt3.Text);

            // Calcular la calificacion final
            decimal CalFin = (cal1 + cal2 + cal3) / 3;

            // Se muestra el resultado con un decimal (F1 formatea a 1 cifra decimal)
            lblCalF.Text = CalFin.ToString("F1");
            lblNumeroFinal.Text = CalFin.ToString("F1");

            // Mostrar si Aprovo o Reprobo
            if (CalFin >= 7.0m) // Aprobado si es mayor o Igual a 7.0
            {
                lblAR.Text = "¡¡Aprobo!! "; //Aprobo
                    //Par cambiar el color de la letra utilizaremos ForeColor
                lblAR.ForeColor = Color.Green;  // Texto en Verde para Aprobar
                lblCalF.ForeColor = Color.Green; // Texto en Verde para el Promedio Alto
                lblNumeroFinal.ForeColor = Color.Green; //Texto en Verde para la Calificacion Final
            }
            else
            {
                lblAR.Text = "¡¡Reprobo!! "; //Reprobo
                lblAR.ForeColor = Color.Red;   // Texto en Rojo para Reprobar
                lblCalF.ForeColor = Color.Red; // Texto en Rojo para el Promedio Bajo
                lblNumeroFinal.ForeColor = Color.Red; //Texto en Rojo para la Calificacion Final
            }

                // Clasificar según el promedio y cambiar el color del label de categoría
                if (CalFin >= 9.5m)
                {
                    lblEstatus.Text = "Exento ";
                    lblEstatus.ForeColor = Color.Green; // Verde para Exento
                }
                else if (CalFin >= 7.0m && CalFin <= 9.4m)
                {
                    lblEstatus.Text = "Ordinario ";
                    lblEstatus.ForeColor = Color.Yellow; // Amarillo para Ordinario
                }
                else if (CalFin >= 5.0m && CalFin <= 6.9m)
                {
                    lblEstatus.Text = "Extraordinario ";
                    lblEstatus.ForeColor = Color.Orange; // Naranja para Extraordinario
                }
                else if (CalFin < 5.0m)
                {
                    lblEstatus.Text = "Especial";
                    lblEstatus.ForeColor = Color.Red;    // Rojo para Especial
                }
                //uso el sufijo m para especificar que el número es decimal y evitar problemas de conversión de tipos.
            }
            catch (Exception ex)
    {
        // En caso de que ingresen mal el dato les aparecera Error, se muestra el mensaje en lblAR
        lblAR.Text = "Error" + ex.Message;
        lblAR.ForeColor = Color.Black; // Color por defecto para errores
        lblCalF.ForeColor = Color.Black; // Color por defecto para el promedio
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
