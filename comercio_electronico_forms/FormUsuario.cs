using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms;
namespace comercio_electronico_forms
{
    public partial class FormUsuario : Form
    {
        private static string connectionString = @"Server=localhost\SQLEXPRESS;Database=comercio_electronico;User id=admin;Password=passwordadmin;TrustServerCertificate=True;";
        public FormUsuario()
        {
            InitializeComponent();
            CargarUsuarios();
        }
        private void CargarUsuarios()
        {
            string query = "SELECT id, nombre, email, permisos, fecha_registro FROM Usuario";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    dataGridView1.DataSource = table;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al cargar usuarios: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void BtnCrear_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text.Trim();
            string email = txtEmail.Text.Trim();
            string contraseña = txtContraseña.Text.Trim();
            int permisos;
            if (string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(contraseña) || !int.TryParse(txtPermisos.Text.Trim(), out permisos))
            {
                MessageBox.Show("Por favor, complete todos los campos correctamente.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string contraseñaCifrada = cifrado.ComputeSHA256(contraseña); // Encriptar la contraseña
            string query = "INSERT INTO Usuario (nombre, email, contraseña, permisos, fecha_registro) VALUES (@nombre, @email, @contraseña, @permisos, GETDATE())";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@nombre", nombre);
                command.Parameters.AddWithValue("@email", email);
                command.Parameters.AddWithValue("@contraseña", contraseñaCifrada);
                command.Parameters.AddWithValue("@permisos", permisos);

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Usuario creado exitosamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarUsuarios(); // Refrescar los datos
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al crear usuario: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void BtnLeer_Click(object sender, EventArgs e)
        {
            CargarUsuarios();
        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un usuario para actualizar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["id"].Value);
            string nombre = txtNombre.Text.Trim();
            string email = txtEmail.Text.Trim();
            string contraseña = txtContraseña.Text.Trim();
            int permisos;

            if (string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(email) || !int.TryParse(txtPermisos.Text.Trim(), out permisos))
            {
                MessageBox.Show("Por favor, complete todos los campos correctamente.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string query = "UPDATE Usuario SET nombre = @nombre, email = @email, permisos = @permisos" +
                           (string.IsNullOrEmpty(contraseña) ? "" : ", contraseña = @contraseña") +
                           " WHERE id = @id";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@nombre", nombre);
                command.Parameters.AddWithValue("@email", email);
                command.Parameters.AddWithValue("@permisos", permisos);
                command.Parameters.AddWithValue("@id", id);
                if (!string.IsNullOrEmpty(contraseña))
                {
                    string contraseñaCifrada = cifrado.ComputeSHA256(contraseña);
                    command.Parameters.AddWithValue("@contraseña", contraseñaCifrada);
                }

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Usuario actualizado exitosamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarUsuarios(); // Refrescar los datos
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al actualizar usuario: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un usuario para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["id"].Value);
            string query = "DELETE FROM Usuario WHERE id = @id";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@id", id);

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Usuario eliminado exitosamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarUsuarios(); // Refrescar los datos
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al eliminar usuario: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
    
}
