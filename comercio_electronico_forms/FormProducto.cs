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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
namespace comercio_electronico_forms
{
    public partial class FormProducto : Form
    {
        private static string connectionString = @"Server=localhost\SQLEXPRESS;Database=comercio_electronico;User id=admin;Password=passwordadmin;TrustServerCertificate=True;";
        public FormProducto()
        {
            InitializeComponent();
            CargarProductos();
        }
        private void CargarProductos()
        {
            string query = "SELECT id, nombre, descripcion, precio, marca_id, categoria_id FROM Producto";
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
                    MessageBox.Show($"Error al cargar productos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void btncrear_Click(object sender, EventArgs e)
        {
            string nombre = txtnombre.Text.Trim();
            string descripcion = txtdescripcion.Text.Trim();
            if (!decimal.TryParse(txtprecio.Text.Trim(), out decimal precio) ||
                !int.TryParse(txtmarcaid.Text.Trim(), out int marcaId) ||
                !int.TryParse(txtcategoriaid.Text.Trim(), out int categoriaId))
            {
                MessageBox.Show("Por favor, complete todos los campos correctamente.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string query = "INSERT INTO Producto (nombre, descripcion, precio, marca_id, categoria_id) VALUES (@nombre, @descripcion, @precio, @marcaId, @categoriaId)";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@nombre", nombre);
                command.Parameters.AddWithValue("@descripcion", descripcion);
                command.Parameters.AddWithValue("@precio", precio);
                command.Parameters.AddWithValue("@marcaId", marcaId);
                command.Parameters.AddWithValue("@categoriaId", categoriaId);

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Producto creado exitosamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarProductos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al crear producto: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnlee_Click(object sender, EventArgs e)
        {
            CargarProductos();
        }

        private void btnactualizar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un producto para actualizar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["id"].Value);
            string nombre = txtnombre.Text.Trim();
            string descripcion = txtdescripcion.Text.Trim();
            if (!decimal.TryParse(txtprecio.Text.Trim(), out decimal precio) ||
                !int.TryParse(txtmarcaid.Text.Trim(), out int marcaId) ||
                !int.TryParse(txtcategoriaid.Text.Trim(), out int categoriaId))
            {
                MessageBox.Show("Por favor, complete todos los campos correctamente.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string query = "UPDATE Producto SET nombre = @nombre, descripcion = @descripcion, precio = @precio, marca_id = @marcaId, categoria_id = @categoriaId WHERE id = @id";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@nombre", nombre);
                command.Parameters.AddWithValue("@descripcion", descripcion);
                command.Parameters.AddWithValue("@precio", precio);
                command.Parameters.AddWithValue("@marcaId", marcaId);
                command.Parameters.AddWithValue("@categoriaId", categoriaId);
                command.Parameters.AddWithValue("@id", id);

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Producto actualizado exitosamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarProductos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al actualizar producto: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnelininar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un producto para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["id"].Value);
            string query = "DELETE FROM Producto WHERE id = @id";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@id", id);

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Producto eliminado exitosamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarProductos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al eliminar producto: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
