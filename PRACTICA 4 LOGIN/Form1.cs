using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRACTICA_4_LOGIN
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BtnSING_Click(object sender, EventArgs e)
        {
            if(txtUser.Text=="Alanis" && txtPass.Text=="1234")
            {
                Formulario_2 index2 = new Formulario_2();
                index2.Show();
                this.Hide();
                //Mosntrar from 2
            }
            else
            {
                MessageBox.Show("Login Failde");
                //MessageBox
            }
        }
    }
}
