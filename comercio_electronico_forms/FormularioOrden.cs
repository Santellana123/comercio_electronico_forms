using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace comercio_electronico_forms
{
    public partial class FormularioOrden : Form
    {
        private static string connectionString = @"Server=localhost\SQLEXPRESS;Database=comercio_electronico;User id=admin;Password=passwordadmin;TrustServerCertificate=True;";

        public FormularioOrden()
        {
            InitializeComponent();
            CargarOrdenes();
        }

        private void CargarOrdenes()
        {
            string query = "SELECT id, usuario_id, estado_id, fecha, total FROM Orden";
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
                    MessageBox.Show($"Error al cargar órdenes: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btncrear_Click(object sender, EventArgs e)
        {
            string usuarioID = txtusuario_id.Text.Trim();
            string estadoID = txtestado_id.Text.Trim();
            string fecha = txtfecha.Text.Trim();
            string total = txttotal.Text.Trim();

            string query = "INSERT INTO Orden (usuario_id, estado_id, fecha, total) VALUES (@usuarioID, @estadoID, @fecha, @total)";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@usuarioID", usuarioID);
                command.Parameters.AddWithValue("@estadoID", estadoID);
                command.Parameters.AddWithValue("@fecha", DateTime.Parse(fecha));
                command.Parameters.AddWithValue("@total", Decimal.Parse(total));

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Orden creada exitosamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarOrdenes();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al crear orden: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnleer_Click(object sender, EventArgs e)
        {
            CargarOrdenes();
        }

        private void btnactualizar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione una orden para actualizar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["id"].Value);
            string usuarioID = txtusuario_id.Text.Trim();
            string estadoID = txtestado_id.Text.Trim();
            string fecha = txtfecha.Text.Trim();
            string total = txttotal.Text.Trim();

            string query = "UPDATE Orden SET usuario_id = @usuarioID, estado_id = @estadoID, fecha = @fecha, total = @total WHERE id = @id";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@usuarioID", usuarioID);
                command.Parameters.AddWithValue("@estadoID", estadoID);
                command.Parameters.AddWithValue("@fecha", DateTime.Parse(fecha));
                command.Parameters.AddWithValue("@total", Decimal.Parse(total));
                command.Parameters.AddWithValue("@id", id);

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Orden actualizada exitosamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarOrdenes();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al actualizar orden: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione una orden para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["id"].Value);

            string query = "DELETE FROM Orden WHERE id = @id";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@id", id);

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Orden eliminada exitosamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarOrdenes();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al eliminar orden: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
