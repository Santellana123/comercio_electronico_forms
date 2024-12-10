using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace comercio_electronico_forms
{
    public partial class FormMetodoPago : Form
    {
        private static string connectionString = @"Server=localhost\SQLEXPRESS;Database=comercio_electronico;User id=admin;Password=passwordadmin;TrustServerCertificate=True;";

        public FormMetodoPago()
        {
            InitializeComponent();
            CargarMetodosPago();
        }

        private void CargarMetodosPago()
        {
            string query = "SELECT id, usuario_id, tipo, numero_tarjeta, fecha_vencimiento, cvv FROM MetodoPago";
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
                    MessageBox.Show($"Error al cargar métodos de pago: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btncrear_Click(object sender, EventArgs e)
        {
            string usuarioId = txtusuarioid.Text.Trim();
            string tipo = txttipo.Text.Trim();
            string numeroTarjeta = txtnumtarjeta.Text.Trim();
            string fechaVencimiento = txtfechavencimiento.Text.Trim();
            string cvv = txtcvv.Text.Trim();

            string query = "INSERT INTO MetodoPago (usuario_id, tipo, numero_tarjeta, fecha_vencimiento, cvv) VALUES (@usuarioId, @tipo, @numeroTarjeta, @fechaVencimiento, @cvv)";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@usuarioId", usuarioId);
                command.Parameters.AddWithValue("@tipo", tipo);
                command.Parameters.AddWithValue("@numeroTarjeta", numeroTarjeta);
                command.Parameters.AddWithValue("@fechaVencimiento", fechaVencimiento);
                command.Parameters.AddWithValue("@cvv", cvv);

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Método de pago creado exitosamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarMetodosPago();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al crear método de pago: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnleer_Click(object sender, EventArgs e)
        {
            CargarMetodosPago();
        }

        private void btnactualizar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un método de pago para actualizar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["id"].Value);
            string tipo = txttipo.Text.Trim();
            string numeroTarjeta = txtnumtarjeta.Text.Trim();
            string fechaVencimiento = txtfechavencimiento.Text.Trim();
            string cvv = txtcvv.Text.Trim();

            string query = "UPDATE MetodoPago SET tipo = @tipo, numero_tarjeta = @numeroTarjeta, fecha_vencimiento = @fechaVencimiento, cvv = @cvv WHERE id = @id";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@tipo", tipo);
                command.Parameters.AddWithValue("@numeroTarjeta", numeroTarjeta);
                command.Parameters.AddWithValue("@fechaVencimiento", fechaVencimiento);
                command.Parameters.AddWithValue("@cvv", cvv);
                command.Parameters.AddWithValue("@id", id);

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Método de pago actualizado exitosamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarMetodosPago();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al actualizar método de pago: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un método de pago para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["id"].Value);

            string query = "DELETE FROM MetodoPago WHERE id = @id";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@id", id);

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Método de pago eliminado exitosamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarMetodosPago();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al eliminar método de pago: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
