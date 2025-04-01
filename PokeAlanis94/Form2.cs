using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PokeAlanis94
{
    public partial class Form2 : Form
    {
        // Cadena de conexión a la base de datos.
        private string connectionString = @"Server=ALANIS\SQLEXPRESS;Database=Pókemon94;Integrated Security=True";

        // Constructor del formulario.
        public Form2()
        {
            InitializeComponent(); // Inicializa los componentes del formulario.
        }
        private void txtHabilidad02_TextChanged(object sender, EventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        // Evento que se activa al hacer clic en el botón "Agregar Nuevo".
        private void btnAgregarNuevo_Click(object sender, EventArgs e)
        {
            // Validar y asignar valores para cada campo.
            // Si el campo está vacío o solo contiene espacios, se asigna el valor "Ninguna".
            string nombre = string.IsNullOrWhiteSpace(txtNombre.Text) ? "Ninguna" : txtNombre.Text.Trim();
            string descripcion = string.IsNullOrWhiteSpace(txtDescripcion.Text) ? "Ninguna" : txtDescripcion.Text.Trim();
            string habilidad01 = string.IsNullOrWhiteSpace(txtHabilidad01.Text) ? "Ninguna" : txtHabilidad01.Text.Trim();
            string habilidad02 = string.IsNullOrWhiteSpace(txtHabilidad02.Text) ? "Ninguna" : txtHabilidad02.Text.Trim();
            string habilidadOculta = string.IsNullOrWhiteSpace(txtHabilidadOculta.Text) ? "Ninguna" : txtHabilidadOculta.Text.Trim();
            string tipo01 = string.IsNullOrWhiteSpace(txtTipo01.Text) ? "Ninguna" : txtTipo01.Text.Trim();
            string tipo02 = string.IsNullOrWhiteSpace(txtTipo02.Text) ? "Ninguna" : txtTipo02.Text.Trim();

            // Se obtiene el siguiente número de Pokédex, basado en el valor máximo actual en la tabla.
            int siguienteNumero = ObtenerSiguienteNumeroPokemon();

            try
            {
                // Crear y abrir una conexión a la base de datos.
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    // Definir la consulta SQL para insertar un nuevo registro en la tabla.
                    // Se utilizan parámetros para evitar inyección SQL.
                    string query = @"INSERT INTO dbo.Pokemon94 
                                    (nDexNa, Nombre, Descripcion, Habilidad_01, Habilidad_02, Habilidad_Oculta, Tipo_01, Tipo_02)
                                    VALUES
                                    (@nDexNa, @nombre, @descripcion, @hab1, @hab2, @habOculta, @tipo1, @tipo2)";

                    // Crear el comando SQL y asociarlo a la conexión.
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        // Agregar parámetros y asignarles los valores validados.
                        cmd.Parameters.AddWithValue("@nDexNa", siguienteNumero);
                        cmd.Parameters.AddWithValue("@nombre", nombre);
                        cmd.Parameters.AddWithValue("@descripcion", descripcion);
                        cmd.Parameters.AddWithValue("@hab1", habilidad01);
                        cmd.Parameters.AddWithValue("@hab2", habilidad02);
                        cmd.Parameters.AddWithValue("@habOculta", habilidadOculta);
                        cmd.Parameters.AddWithValue("@tipo1", tipo01);
                        cmd.Parameters.AddWithValue("@tipo2", tipo02);

                        // Ejecutar la consulta de inserción.
                        cmd.ExecuteNonQuery();
                    }
                }

                // Mostrar mensaje de éxito al usuario indicando el número del nuevo Pokémon.
                MessageBox.Show($"¡Pokémon #{siguienteNumero} agregado exitosamente!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Establecer el resultado del diálogo como OK y cerrar el formulario.
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                // En caso de error, mostrar un mensaje de error con la descripción del mismo.
                MessageBox.Show("Error al agregar el Pokémon: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Método que obtiene el siguiente número de Pokédex.
        // Busca el valor máximo actual de nDexNa en la tabla y le suma 1.
        // Si la tabla está vacía o hay error, se asume 151 como valor base.
        private int ObtenerSiguienteNumeroPokemon()
        {
            int maxNumero = 151; // Valor predeterminado.
            try
            {
                // Crear y abrir la conexión a la base de datos.
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    // Consulta para obtener el valor máximo de nDexNa.
                    // ISNULL se usa para retornar 151 si la tabla está vacía.
                    string query = "SELECT ISNULL(MAX(nDexNa), 151) AS MaxNum FROM dbo.Pokemon94";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        // Ejecutar la consulta y obtener el resultado.
                        object result = cmd.ExecuteScalar();
                        if (result != null)
                        {
                            maxNumero = Convert.ToInt32(result);
                        }
                    }
                }
            }
            catch
            {
                // En caso de error, se utiliza 151 como valor base.
                maxNumero = 151;
            }

            // Retornar el siguiente número de Pokédex (el máximo actual más uno).
            return maxNumero + 1;
        }
    }
}