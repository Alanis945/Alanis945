using System; // Espacio de nombres para funciones básicas de .NET
using System.Collections.Generic; // Soporte para colecciones genéricas
using System.ComponentModel; // Para componentes y diseño en WinForms
using System.Data; // Funciones básicas de manejo de datos
using System.Drawing; // Manejo de gráficos y colores
using System.Linq; // Funciones LINQ para consultas
using System.Text; // Manejo de texto y codificaciones
using System.Threading.Tasks; // Soporte para programación asíncrona
using System.Data.SqlClient; // Conexión y manejo de SQL Server
using System.IO; // Operaciones de entrada/salida (archivos)
using System.Windows.Forms; // Componentes para Windows Forms
using System.Drawing.Drawing2D; // Funcionalidades avanzadas de dibujo

namespace PokeAlanis94
{
    public partial class Form1 : Form
    {
        // Cadena de conexión a la base de datos SQL Server
        string connectionString = "Server=ALANIS\\SQLEXPRESS;Database=Pókemon94;Integrated Security=True";
        int maxPokemon; // Variable para almacenar el número máximo de Pokémon en la base de datos
        public Form1()
        {
            InitializeComponent(); // Inicializa los componentes visuales del formulario
            maxPokemon = ObtenerMaximoPokemon(); // Se asigna el número máximo de Pokémon obtenido de la base de datos
        }
        // Función para obtener el número máximo de Pokémon desde la base de datos
        private int ObtenerMaximoPokemon()
        {
            int maximo = 0; // Inicializa la variable que contendrá el número máximo
            try
            {
                // Se crea una conexión a la base de datos utilizando la cadena de conexión
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open(); // Abre la conexión con SQL Server
                    // Consulta SQL para obtener el número máximo de Pokémon (campo nDexNa)
                    string query = "SELECT MAX(nDexNa) FROM dbo.Pokemon94";
                    SqlCommand cmd = new SqlCommand(query, conn);  // Crea el comando SQL
                    // Ejecuta la consulta y asigna el resultado convertido a entero a 'maximo'
                    maximo = Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
            catch (Exception ex)
            {
                LogError(ex); // Registra el error en un archivo log
                // Muestra un mensaje actualizado de error, indicando el detalle del fallo
                MessageBox.Show("Error: No se pudo obtener el número máximo de Pokémon. Detalle: " + ex.Message,
                                "Error en la Base de Datos",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Error);
            }
            return maximo;// Retorna el valor máximo obtenido
        }
        // Recorre los controles del formulario y asigna el evento 'NumericButton_Click'
        // a los botones que tengan el Tag "numeric".
        private void AsignarEventosNumericos()
        {
            // Itera sobre todos los controles del formulario
            foreach (Control ctrl in this.Controls)
            {
                // Verifica si el control es un botón y si su propiedad Tag es "numeric"
                if (ctrl is Button btn && btn.Tag != null && btn.Tag.ToString() == "numeric")
                {
                    // Asigna el evento Click al método NumericButton_Click
                    btn.Click += new EventHandler(NumericButton_Click);
                }
            }
        }
        // Evento para los botones numéricos: añade el número (texto del botón)
        // al final del contenido del TextBox (txtNomNum).
        private void NumericButton_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button; // Convierte el objeto sender a un botón
            if (btn != null)
            {
                // Agrega el texto del botón al contenido del TextBox
                txtNomNum.Text += btn.Text;
            }
        }
        // Carga la información del Pokémon según el número proporcionado.
        private void CargarInformacionPokemon(string numeroPokemon)
        {
            try
            {
                // Abre la conexión a la base de datos
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    // Consulta SQL para obtener la información del Pokémon según su número (nDexNa)
                    string query = "SELECT Nombre, Descripcion, Habilidad_01, Habiilidad_02, Habilidad_Oulta, Tipo_01, Tipo_02 FROM dbo.Pokemon94 WHERE nDexNa = @Numero";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    // Asigna el valor del parámetro @Numero
                    cmd.Parameters.AddWithValue("@Numero", numeroPokemon);

                    SqlDataReader reader = cmd.ExecuteReader();// Ejecuta la consulta y obtiene los datos

                    if (reader.HasRows)
                    {
                        // Si se encontraron datos, los recorre
                        while (reader.Read())
                        {
                            // Lee y asigna cada dato del Pokémon a variables
                            string nombre = reader["Nombre"].ToString();
                            string descripcion = reader["Descripcion"].ToString();
                            string habilidad01 = reader["Habilidad_01"].ToString();
                            string habilidad02 = reader["Habiilidad_02"].ToString();
                            string habilidadOculta = reader["Habilidad_Oulta"].ToString();
                            string tipo01 = reader["Tipo_01"].ToString();
                            string tipo02 = reader["Tipo_02"].ToString();

                            // Actualiza los Labels del formulario con la información del Pokémon
                            lblDescripcion.Text = descripcion;
                            lblHabilidad1.Text = $"Hab.01: {habilidad01}";
                            lblHabilidad2.Text = $"Hab.02: {habilidad02}";
                            lblHabilidad3.Text = $"Hab. Oculta: {habilidadOculta}";
                            lblTipo1.Text = $"Tipo 01: {tipo01}";
                            lblTipo2.Text = $"Tipo 02: {tipo02}";

                            // Hace visible el panel que muestra la descripción
                            panelDescripcion.Visible = true;

                            // Construye la ruta completa de la imagen del Pokémon en el escritorio
                            string imagenPath = @"C:\Users\L480\Desktop\POKEMON_94\" + numeroPokemon.PadLeft(3, '0') + ".png";
                            if (File.Exists(imagenPath))
                            {
                                // Si la imagen existe, la carga en el PictureBox
                                pbPokemon.Image = Image.FromFile(imagenPath);
                            }
                            else
                            {
                                // Si no existe la imagen específica, carga una imagen predeterminada (NP.png)(Significa Nuevo Pokemon.png)
                                string imagenDefault = @"C:\Users\L480\Desktop\POKEMON_94\NP.png";
                                if (File.Exists(imagenDefault))
                                {
                                    pbPokemon.Image = Image.FromFile(imagenDefault);
                                }
                                else
                                {
                                    // Muestra un mensaje actualizado en caso de que tampoco se encuentre la imagen predeterminada
                                    MessageBox.Show("Error: La imagen predeterminada (NP.png) no se encontró.",
                                                    "Imagen No Encontrada", 
                                                     MessageBoxButtons.OK, 
                                                     MessageBoxIcon.Warning);
                                }
                            }

                            // Actualiza el TextBox para mostrar el nombre y el número del Pokémon
                            txtNomNum.Text = nombre + " #" + numeroPokemon;

                            // Si se puede convertir el número, actualiza la navegación
                            if (int.TryParse(numeroPokemon, out int num))
                                ActualizarNavegacion(num);
                        }
                    }
                    else
                    {
                        // Muestra un mensaje actualizado si no se encontró ningún Pokémon con ese número
                        MessageBox.Show($"No se Encontró el Pokémon con el Número {numeroPokemon}.",
                                         "Búsqueda de Pokémon",
                                          MessageBoxButtons.OK,
                                          MessageBoxIcon.Information);
                    }

                    reader.Close();// Cierra el lector de datos
                }
            }
            catch (Exception ex)
            {
                LogError(ex);// Registra el error
                // Muestra un mensaje actualizado de error al cargar la información
                MessageBox.Show("Error: " + ex.Message,
                                "Error de Carga",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Error);
            }
        }
        // Registra errores en un archivo log ubicado en el directorio de la aplicación.
        private void LogError(Exception ex)
        {
            try
            {
                // Construye la ruta del archivo log utilizando el directorio de inicio de la aplicación
                string logFilePath = Path.Combine(Application.StartupPath, "error.log");
                // Crea la entrada de log con fecha, hora y detalle del error
                string logEntry = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + " - " + ex.ToString() + Environment.NewLine;
                // Agrega la entrada al archivo log
                File.AppendAllText(logFilePath, logEntry);
            }
            catch
            {
                // Si falla el registro del error, se ignora para no interrumpir la ejecución
            }
        }
        // Actualiza el estado (habilitado/deshabilitado) de los botones de navegación según el número actual del Pokémon.
        private void ActualizarNavegacion(int currentNum)
        {
            // Se habilitan o deshabilitan los botones según el rango (1 a maxPokemon)
            btnIzquierda.Enabled = currentNum > 1;
            btnArriba.Enabled = currentNum > 1;
            btnDerrecha.Enabled = currentNum < maxPokemon;
            btnAbajo.Enabled = currentNum < maxPokemon;
        }

        // Habilita o deshabilita los botones según si el número actual es mayor que 1 o menor que el máximo
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            txtNomNum.Text = "";// Limpia el contenido del TextBox
        }
        // Evento del botón Seleccionar: valida el número ingresado y carga la información del Pokémon correspondiente.
        private void BtnSeleccionar_Click(object sender, EventArgs e)
        {
            // Elimina espacios en blanco al inicio y al final del texto ingresado
            string numeroPokemon = txtNomNum.Text.Trim();
            // Verifica que el número ingresado sea válido y esté dentro del rango permitido
            if (int.TryParse(numeroPokemon, out int num) && num >= 1 && num <= maxPokemon)
            {
                // Formatea el número a tres dígitos y carga la información del Pokémon
                CargarInformacionPokemon(numeroPokemon.PadLeft(3, '0'));
            }
            else
            {
                // Muestra un mensaje actualizado si el número ingresado es inválido o fuera de rango
                MessageBox.Show($"El número ingresado ({numeroPokemon}) no existe en la base de datos.",
                                 "Selección de Pokémon",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Information);
            }
        }
        // Evento del botón Agregar: abre un formulario para agregar un nuevo Pokémon (función en desarrollo).
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            // Crea una instancia del formulario Form2 para agregar un Pokémon
            Form2 nuevoPokemon = new Form2();

            // Muestra el formulario de forma modal (sin cerrar el formulario actual)
            nuevoPokemon.ShowDialog();
        }
        // Evento del botón Sonido: indica que la función está en desarrollo.
        private void btnSonido_Click(object sender, EventArgs e)
        {
            // Muestra un mensaje actualizado indicando que la función de sonido aún está en desarrollo
            MessageBox.Show("Función de Sonido en Desarrollo.",
                            "Función en Desarrollo",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
        }
        // Eventos de navegación: estos métodos cambian el Pokémon actual según la dirección del botón presionado.
        private void btnDerecha_Click(object sender, EventArgs e)
        {
            CambiarPokemon(1); // Incrementa en 1 el número del Pokémon
        }
        private void btnIzquierda_Click(object sender, EventArgs e)
        {
            CambiarPokemon(-1); // Decrementa en 1 el número del Pokémon
        }
        private void btnArriba_Click(object sender, EventArgs e)
        {
            CambiarPokemon(-1);  // Decrementa en 1 el número del Pokémon
        }
        private void btnAbajo_Click(object sender, EventArgs e)
        {
            CambiarPokemon(1); // Incrementa en 1 el número del Pokémon
        }
        // Cambia el Pokémon actual basándose en un incremento (positivo o negativo).
        private void CambiarPokemon(int incremento)
        {
            // Obtiene el contenido actual del TextBox
            string current = txtNomNum.Text;
            if (!string.IsNullOrEmpty(current))
            {
                // Separa el texto usando '#' para extraer el número del Pokémon
                string[] parts = current.Split('#');
                if (parts.Length == 2 && int.TryParse(parts[1], out int currentNum))
                {
                    int nuevoNumero = currentNum + incremento;// Calcula el nuevo número
                    // Asegura que el nuevo número esté dentro de los límites válidos
                    if (nuevoNumero < 1) nuevoNumero = 1;
                    if (nuevoNumero > maxPokemon) nuevoNumero = maxPokemon;
                    // Carga la información del Pokémon correspondiente al nuevo número
                    CargarInformacionPokemon(nuevoNumero.ToString().PadLeft(3, '0'));
                }
            }
        }
        // Evento del botón Mostrar Info: extrae el número del Pokémon del TextBox y carga su información.
        private void BtnMostrarInfo_Click(object sender, EventArgs e)
        {
            // Obtiene el texto actual del TextBox
            string texto = txtNomNum.Text;

            if (!string.IsNullOrEmpty(texto) && texto.Contains("#"))
            {
                // Separa el texto para obtener el número que sigue al símbolo '#'
                string[] partes = texto.Split('#');
                if (partes.Length == 2)
                {
                    string numeroPokemon = partes[1].Trim();
                    // Valida que el número extraído sea correcto y esté en el rango permitido
                    if (int.TryParse(numeroPokemon, out int num) && num >= 1 && num <= maxPokemon)
                    {
                        CargarInformacionPokemon(numeroPokemon.PadLeft(3, '0'));
                    }
                    else
                    {
                        // Muestra un mensaje actualizado si el número es inválido
                        MessageBox.Show("Error: El número del Pokémon ingresado no es válido.",
                                        "Número Inválido",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Warning);
                    }
                }
            }
            else
            {
                // Muestra un mensaje si no se ha seleccionado ningún Pokémon antes de solicitar la información
                MessageBox.Show("Por favor, seleccione un Pokémon antes de intentar mostrar la información.",
                               "Selección de Pokémon",
                               MessageBoxButtons.OK,
                               MessageBoxIcon.Information);
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
        }
    }
}
