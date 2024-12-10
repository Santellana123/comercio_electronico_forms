using System.Text;
using Microsoft.Data.SqlClient;
using System.Security.Cryptography;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
namespace comercio_electronico_forms
{
    public partial class Form1 : Form
    {
        private static string connectionString = @"Server=localhost\SQLEXPRESS;Database=comercio_electronico;User id=admin;Password=passwordadmin;TrustServerCertificate=True;";
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            string username = TbUsuario.Text.Trim();
            string password = TbContraseña.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Por favor, ingrese usuario y contraseña.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (VerifyCredentials(username, password))
            {
                MessageBox.Show("¡Login exitoso!", "Bienvenido", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Abrir el siguiente formulario
                menu menuForm = new menu();
                menuForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos.", "Error de autenticación", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private bool VerifyCredentials(string username, string password)
        {
            string hashedPassword = cifrado.ComputeSHA256(password);

            string query = "SELECT COUNT(1) FROM usuario WHERE nombre = @username AND contraseña = @password";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.Add(new SqlParameter("@username", username));
                command.Parameters.Add(new SqlParameter("@password", hashedPassword));

                try
                {
                    connection.Open();
                    int count = Convert.ToInt32(command.ExecuteScalar());
                    return count == 1;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al conectar con la base de datos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
        }

    }
}
