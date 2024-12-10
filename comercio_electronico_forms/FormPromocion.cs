using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace comercio_electronico_forms
{
    public partial class FormPromocion : Form
    {
        private static string connectionString = @"Server=localhost\SQLEXPRESS;Database=comercio_electronico;User id=admin;Password=passwordadmin;TrustServerCertificate=True;";

        public FormPromocion()
        {
            InitializeComponent();
            CargarPromociones();
        }

        private void CargarPromociones()
        {
            string query = "SELECT id, nombre, descuento, fecha_inicio, fecha_fin FROM Promocion";
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
                    MessageBox.Show($"Error al cargar promociones: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btncrear_Click(object sender, EventArgs e)
        {
            string nombre = txtnombre.Text.Trim();
            string descuento = txtdescuento.Text.Trim();
            string fechaInicio = txtinicio.Text.Trim();
            string fechaFin = txtfin.Text.Trim();

            string query = "INSERT INTO Promocion (nombre, descuento, fecha_inicio, fecha_fin) VALUES (@nombre, @descuento, @fechaInicio, @fechaFin)";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@nombre", nombre);
                command.Parameters.AddWithValue("@descuento", descuento);
                command.Parameters.AddWithValue("@fechaInicio", fechaInicio);
                command.Parameters.AddWithValue("@fechaFin", fechaFin);

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Promoción creada exitosamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarPromociones();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al crear promoción: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnleer_Click(object sender, EventArgs e)
        {
            CargarPromociones();
        }

        private void btnactualizar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione una promoción para actualizar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["id"].Value);
            string nombre = txtnombre.Text.Trim();
            string descuento = txtdescuento.Text.Trim();
            string fechaInicio = txtinicio.Text.Trim();
            string fechaFin = txtfin.Text.Trim();

            string query = "UPDATE Promocion SET nombre = @nombre, descuento = @descuento, fecha_inicio = @fechaInicio, fecha_fin = @fechaFin WHERE id = @id";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@nombre", nombre);
                command.Parameters.AddWithValue("@descuento", descuento);
                command.Parameters.AddWithValue("@fechaInicio", fechaInicio);
                command.Parameters.AddWithValue("@fechaFin", fechaFin);
                command.Parameters.AddWithValue("@id", id);

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Promoción actualizada exitosamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarPromociones();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al actualizar promoción: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione una promoción para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["id"].Value);

            string query = "DELETE FROM Promocion WHERE id = @id";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@id", id);

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Promoción eliminada exitosamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarPromociones();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al eliminar promoción: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}

