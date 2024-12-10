using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace comercio_electronico_forms
{
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }

        private void BtnUsuarios_Click(object sender, EventArgs e)
        {
            FormUsuario f = new FormUsuario();
            f.Show();
            this.Hide();
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            FormProducto p = new FormProducto();
            p.Show();
            this.Hide();
        }

        private void txtProveedor_Click(object sender, EventArgs e)
        {
            FormProveedor f = new FormProveedor();
            f.Show();
            this.Hide();
        }

        private void btnOrden_Click(object sender, EventArgs e)
        {
            FormularioOrden f = new FormularioOrden();
            f.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormVendedor f = new FormVendedor();
            f.Show();
            this.Hide();
        }

        private void btnEnvio_Click(object sender, EventArgs e)
        {
            FormEnvio f = new FormEnvio();
            f.Show();
            this.Hide();
        }

        private void btnReembolso_Click(object sender, EventArgs e)
        {
            FormReembolso f = new FormReembolso();
            f.Show();
            this.Hide();
        }

        private void btndireccion_Click(object sender, EventArgs e)
        {
            FormDireccion f = new FormDireccion();
            f.Show();
            this.Hide();
        }

        private void btnpromocion_Click(object sender, EventArgs e)
        {
            FormPromocion f = new FormPromocion();
            f.Show();
            this.Hide();
        }

        private void btnPago_Click(object sender, EventArgs e)
        {
            FormMetodoPago f = new FormMetodoPago();
            f.Show();
            this.Hide();
        }
    }
}
