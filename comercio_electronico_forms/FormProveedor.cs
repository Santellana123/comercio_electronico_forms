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
    public partial class FormProveedor : Form
    {
        private static string connectionString = @"Server=localhost\SQLEXPRESS;Database=comercio_electronico;User id=admin;Password=passwordadmin;TrustServerCertificate=True;";
        public FormProveedor()
        {
            InitializeComponent();
        }
        private void CargarProveedores()
        {
            string query = "SELECT id, nombre, contacto, direccion FROM Proveedor";
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
                    MessageBox.Show($"Error al cargar proveedores: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void btncrear_Click(object sender, EventArgs e)
        {
            string nombre = txtnombre.Text.Trim();
            string contacto = txtcontacto.Text.Trim();
            string direccion = txtdireccion.Text.Trim();

            string query = "INSERT INTO Proveedor (nombre, contacto, direccion) VALUES (@nombre, @contacto, @direccion)";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@nombre", nombre);
                command.Parameters.AddWithValue("@contacto", contacto);
                command.Parameters.AddWithValue("@direccion", direccion);

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Proveedor creado exitosamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarProveedores();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al crear proveedor: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnleer_Click(object sender, EventArgs e)
        {
            CargarProveedores();
        }

        private void btnactualizar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un proveedor para actualizar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["id"].Value);
            string nombre = txtnombre.Text.Trim();
            string contacto = txtcontacto.Text.Trim();
            string direccion = txtdireccion.Text.Trim();

            string query = "UPDATE Proveedor SET nombre = @nombre, contacto = @contacto, direccion = @direccion WHERE id = @id";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@nombre", nombre);
                command.Parameters.AddWithValue("@contacto", contacto);
                command.Parameters.AddWithValue("@direccion", direccion);
                command.Parameters.AddWithValue("@id", id);

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Proveedor actualizado exitosamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarProveedores();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al actualizar proveedor: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un proveedor para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["id"].Value);

            string query = "DELETE FROM Proveedor WHERE id = @id";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@id", id);

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Proveedor eliminado exitosamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarProveedores();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al eliminar proveedor: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
