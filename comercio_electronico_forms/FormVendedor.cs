using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace comercio_electronico_forms
{
    public partial class FormVendedor : Form
    {
        private static string connectionString = @"Server=localhost\SQLEXPRESS;Database=comercio_electronico;User id=admin;Password=passwordadmin;TrustServerCertificate=True;";

        public FormVendedor()
        {
            InitializeComponent();
            CargarVendedores();
        }

        private void CargarVendedores()
        {
            string query = "SELECT id, usuario_id, nombre_tienda, reputacion FROM Vendedor";
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
                    MessageBox.Show($"Error al cargar vendedores: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btncrear_Click(object sender, EventArgs e)
        {
            string usuarioId = txtUsuarioid.Text.Trim();
            string nombreT = txtnombre_tienda.Text.Trim();
            string reputacion = txtreputacion.Text.Trim();

            string query = "INSERT INTO Vendedor (usuario_id, nombre_tienda, reputacion) VALUES (@usuarioId, @nombreT, @reputacion)";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@usuarioId", usuarioId);
                command.Parameters.AddWithValue("@nombreT", nombreT);
                command.Parameters.AddWithValue("@reputacion", Decimal.Parse(reputacion));

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Vendedor creado exitosamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarVendedores();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al crear vendedor: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnleer_Click(object sender, EventArgs e)
        {
            CargarVendedores();
        }

        private void btnactualizar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un vendedor para actualizar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["id"].Value);
            string usuarioId = txtUsuarioid.Text.Trim();
            string nombreT = txtnombre_tienda.Text.Trim();
            string reputacion = txtreputacion.Text.Trim();

            string query = "UPDATE Vendedor SET usuario_id = @usuarioId, nombre_tienda = @nombreT, reputacion = @reputacion WHERE id = @id";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@usuarioId", usuarioId);
                command.Parameters.AddWithValue("@nombreT", nombreT);
                command.Parameters.AddWithValue("@reputacion", Decimal.Parse(reputacion));
                command.Parameters.AddWithValue("@id", id);

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Vendedor actualizado exitosamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarVendedores();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al actualizar vendedor: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un vendedor para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["id"].Value);

            string query = "DELETE FROM Vendedor WHERE id = @id";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@id", id);

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Vendedor eliminado exitosamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarVendedores();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al eliminar vendedor: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
