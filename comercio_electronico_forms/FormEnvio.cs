using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace comercio_electronico_forms
{
    public partial class FormEnvio : Form
    {
        private static string connectionString = @"Server=localhost\SQLEXPRESS;Database=comercio_electronico;User id=admin;Password=passwordadmin;TrustServerCertificate=True;";

        public FormEnvio()
        {
            InitializeComponent();
            CargarEnvios();
        }

        private void CargarEnvios()
        {
            string query = "SELECT id, orden_id, metodo_envio_id, fecha_envio, fecha_entrega FROM Envio";
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
                    MessageBox.Show($"Error al cargar envíos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btncrear_Click(object sender, EventArgs e)
        {
            string orden = txtOrdenID.Text.Trim();
            string metodo = txtmetodoEnvio.Text.Trim();
          

            string query = "INSERT INTO Envio (orden_id, metodo_envio_id, fecha_envio, fecha_entrega) VALUES (@ordenId, @metodoEnvioId, @fechaEnvio, @fechaEntrega)";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@ordenId", orden);
                command.Parameters.AddWithValue("@metodoEnvioId", metodo);
              
                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Envío creado exitosamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarEnvios();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al crear envío: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnleer_Click(object sender, EventArgs e)
        {
            CargarEnvios();
        }

        private void btnactualizar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un envío para actualizar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["id"].Value);
            string orden = txtOrdenID.Text.Trim();
            string metodo = txtmetodoEnvio.Text.Trim();
         

            string query = "UPDATE Envio SET orden_id = @ordenId, metodo_envio_id = @metodoEnvioId, fecha_envio = @fechaEnvio, fecha_entrega = @fechaEntrega WHERE id = @id";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@ordenId", orden);
                command.Parameters.AddWithValue("@metodoEnvioId", metodo);
               
                command.Parameters.AddWithValue("@id", id);

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Envío actualizado exitosamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarEnvios();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al actualizar envío: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un envío para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["id"].Value);

            string query = "DELETE FROM Envio WHERE id = @id";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@id", id);

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Envío eliminado exitosamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarEnvios();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al eliminar envío: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
