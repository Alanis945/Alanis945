using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_03
{
    public partial class Form1 : Form
    {
        int vResultado;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            vResultado = Convert.ToInt32(txtNum1.Text) + Convert.ToInt32(txtNum2.Text);
            lblResult.Text = vResultado.ToString();
            lblSigno.Text = "+";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnResta_Click(object sender, EventArgs e)
        {
            vResultado = Convert.ToInt32(txtNum1.Text) - Convert.ToInt32(txtNum2.Text);
            lblResult.Text = vResultado.ToString();
            lblSigno.Text = "-";
        }

        private void btnMulti_Click(object sender, EventArgs e)
        {
            vResultado = Convert.ToInt32(txtNum1.Text) * Convert.ToInt32(txtNum2.Text);
            lblResult.Text = vResultado.ToString();
            lblSigno.Text = "x";
        }

        private void btnDivi_Click(object sender, EventArgs e)
        {
            vResultado = Convert.ToInt32(txtNum1.Text) / Convert.ToInt32(txtNum2.Text);
            lblResult.Text = vResultado.ToString();
            lblSigno.Text = "/";
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNum1.Text = "";
            txtNum2.Text = "";
            lblResult.Text = "000";
            lblSigno.Text = "|";
        }
    }
}
