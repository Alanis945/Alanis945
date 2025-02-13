namespace Practica_02
{
    public partial class Form1 : Form
    {
        Decimal cel;

        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cel = (Convert.ToDecimal(txtFahrenheit.Text) - 32) * 5 / 9;
            lblFahrenheit.Text = cel.ToString();
        }

        private void txtCelsius_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtFahrenheit_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void butcon1_Click(object sender, EventArgs e)
        {
            cel = (Convert.ToDecimal(txtCelsius.Text) * 9 / 5) + 32;
            lblCelsius.Text = cel.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
