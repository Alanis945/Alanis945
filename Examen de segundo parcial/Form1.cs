using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen_de_segundo_parcial
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // Llenar ComboBox con días (1-31)
            for (int i = 1; i <= 31; i++)
            {
                cbDia.Items.Add(i); // aqui declaro los dias del mes (1 al 31 al comboBox)
            }
            cbDia.SelectedIndex = 0; //aqui agrego Dia1 predeterminado
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            //Variable para aclara el mes y el dia selecionados
            string mes = "";
            int dia = Convert.ToInt32(cbDia.SelectedItem); // aqui acomodo el dia del combobox

            // aqui salecionaran el radiobutton del mes de nacimiento 
            if (rbEnero.Checked) mes = "ENERO";
            else if (rbFebrero.Checked) mes = "FEBRERO";
            else if (rbMarzo.Checked) mes = "MARZO";
            else if (rbAbril.Checked) mes = "ABRIL";
            else if (rbMayo.Checked) mes = "MAYO";
            else if (rbJunio.Checked) mes = "JUNIO";
            else if (rbJulio.Checked) mes = "JULIO";
            else if (rbAgosto.Checked) mes = "AGOSTO";
            else if (rbSeptiembre.Checked) mes = "SEPTIEMBRE";
            else if (rbOctubre.Checked) mes = "OCTUBRE";
            else if (rbNoviembre.Checked) mes = "NOVIEMBRE";
            else if (rbDiciembre.Checked) mes = "DICIEMBRE";

            // Creo la instancia para pasar informacion al form2
            Form2 form2 = new Form2(mes, dia);
            form2.Show(); // aqui muestro la informacion 

            this.Hide(); // aqui oculto el form 1 
        }
    }
}
