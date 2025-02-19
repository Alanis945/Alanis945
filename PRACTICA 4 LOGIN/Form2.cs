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
    public partial class Formulario_2 : Form
    {
        string vSeleccion;
        int vIndice=0;
        public Formulario_2()
        {
            InitializeComponent();
        }

        private void CbBox_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            vSeleccion = Convert.ToString(CbBox.Text);

            int vIndice = dgvDatos.Rows.Add();

            dgvDatos.Rows[vIndice].Cells[0].Value = txtName.Text;
            dgvDatos.Rows[vIndice].Cells[1].Value = txtLast.Text;
            dgvDatos.Rows[vIndice].Cells[2].Value = vSeleccion;

            txtName.Text = "";
            txtLast.Text = "";
            CbBox.Text = "";
        }

        private void dgvDatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnRem_Click(object sender, EventArgs e)
        {
            if(vIndice != -1)
            {
                dgvDatos.Rows.RemoveAt(vIndice);
            }
            else
            {
                MessageBox.Show("Selected Item Incorrect");
            }
        }

        private void dgvDatos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            vIndice = e.RowIndex;
        }

        private void Formulario_2_Load(object sender, EventArgs e)
        {
            CbBox.Items.Add("Mexico");
            CbBox.Items.Add("Estados_Unidos");
            CbBox.Items.Add("Canada");
            CbBox.Items.Add("China");
            CbBox.Items.Add("Rusia");
            CbBox.Items.Add("Alamenia");
        }
    }
}
