using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace comercio_electronico_forms
{
    public partial class FormDireccion : Form
    {
        private static string connectionString = @"Server=localhost\SQLEXPRESS;Database=comercio_electronico;User id=admin;Password=passwordadmin;TrustServerCertificate=True;";

        public FormDireccion()
        {
            InitializeComponent();
            CargarDirecciones();
        }

        private void CargarDirecciones()
        {
            string query = "SELECT id, usuario_id, calle, ciudad, estado, pais, codigo_postal FROM Direccion";
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
                    MessageBox.Show($"Error al cargar direcciones: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btncrear_Click(object sender, EventArgs e)
        {
            string usuarioID = txtusuario_id.Text.Trim();
            string calle = txtcalle.Text.Trim();
            string ciudad = txtciudad.Text.Trim();
            string estado = txtestado.Text.Trim();
            string pais = txtpais.Text.Trim();
            string codigoPostal = txcp.Text.Trim();

            string query = "INSERT INTO Direccion (usuario_id, calle, ciudad, estado, pais, codigo_postal) VALUES (@usuarioID, @calle, @ciudad, @estado, @pais, @codigoPostal)";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@usuarioID", usuarioID);
                command.Parameters.AddWithValue("@calle", calle);
                command.Parameters.AddWithValue("@ciudad", ciudad);
                command.Parameters.AddWithValue("@estado", estado);
                command.Parameters.AddWithValue("@pais", pais);
                command.Parameters.AddWithValue("@codigoPostal", codigoPostal);

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Dirección creada exitosamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarDirecciones();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al crear dirección: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnleer_Click(object sender, EventArgs e)
        {
            CargarDirecciones();
        }

        private void btnactualizar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione una dirección para actualizar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["id"].Value);
            string usuarioID = txtusuario_id.Text.Trim();
            string calle = txtcalle.Text.Trim();
            string ciudad = txtciudad.Text.Trim();
            string estado = txtestado.Text.Trim();
            string pais = txtpais.Text.Trim();
            string codigoPostal = txcp.Text.Trim();

            string query = "UPDATE Direccion SET usuario_id = @usuarioID, calle = @calle, ciudad = @ciudad, estado = @estado, pais = @pais, codigo_postal = @codigoPostal WHERE id = @id";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@usuarioID", usuarioID);
                command.Parameters.AddWithValue("@calle", calle);
                command.Parameters.AddWithValue("@ciudad", ciudad);
                command.Parameters.AddWithValue("@estado", estado);
                command.Parameters.AddWithValue("@pais", pais);
                command.Parameters.AddWithValue("@codigoPostal", codigoPostal);
                command.Parameters.AddWithValue("@id", id);

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Dirección actualizada exitosamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarDirecciones();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al actualizar dirección: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione una dirección para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["id"].Value);

            string query = "DELETE FROM Direccion WHERE id = @id";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@id", id);

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Dirección eliminada exitosamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarDirecciones();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al eliminar dirección: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
