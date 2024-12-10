using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace comercio_electronico_forms
{
    public partial class FormReembolso : Form
    {
        private static string connectionString = @"Server=localhost\SQLEXPRESS;Database=comercio_electronico;User id=admin;Password=passwordadmin;TrustServerCertificate=True;";

        public FormReembolso()
        {
            InitializeComponent();
            CargarReembolsos();
        }

        private void CargarReembolsos()
        {
            string query = "SELECT id, orden_id, motivo, monto FROM Reembolso";
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
                    MessageBox.Show($"Error al cargar reembolsos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btncrear_Click(object sender, EventArgs e)
        {
            string ordenID = txtOrdenid.Text.Trim();
            string motivo = txtmotivo.Text.Trim();
            string monto = txtmonto.Text.Trim();

            string query = "INSERT INTO Reembolso (orden_id, motivo, monto) VALUES (@ordenId, @motivo, @monto)";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@ordenId", ordenID);
                command.Parameters.AddWithValue("@motivo", motivo);
                command.Parameters.AddWithValue("@monto", monto);

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Reembolso creado exitosamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarReembolsos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al crear reembolso: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnleer_Click(object sender, EventArgs e)
        {
            CargarReembolsos();
        }

        private void btnactualizar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un reembolso para actualizar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["id"].Value);
            string ordenID = txtOrdenid.Text.Trim();
            string motivo = txtmotivo.Text.Trim();
            string monto = txtmonto.Text.Trim();

            string query = "UPDATE Reembolso SET orden_id = @ordenId, motivo = @motivo, monto = @monto WHERE id = @id";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@ordenId", ordenID);
                command.Parameters.AddWithValue("@motivo", motivo);
                command.Parameters.AddWithValue("@monto", monto);
                command.Parameters.AddWithValue("@id", id);

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Reembolso actualizado exitosamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarReembolsos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al actualizar reembolso: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un reembolso para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["id"].Value);

            string query = "DELETE FROM Reembolso WHERE id = @id";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@id", id);

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Reembolso eliminado exitosamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarReembolsos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al eliminar reembolso: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
