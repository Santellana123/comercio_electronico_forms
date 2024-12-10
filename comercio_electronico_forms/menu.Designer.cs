namespace comercio_electronico_forms
{
    partial class menu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            BtnUsuarios = new Button();
            btnProductos = new Button();
            btnSalir = new Button();
            txtProveedor = new Button();
            btnOrden = new Button();
            button1 = new Button();
            btnEnvio = new Button();
            btnReembolso = new Button();
            btndireccion = new Button();
            btnpromocion = new Button();
            btnPago = new Button();
            SuspendLayout();
            // 
            // BtnUsuarios
            // 
            BtnUsuarios.Location = new Point(239, 70);
            BtnUsuarios.Name = "BtnUsuarios";
            BtnUsuarios.Size = new Size(94, 29);
            BtnUsuarios.TabIndex = 0;
            BtnUsuarios.Text = "usuarios";
            BtnUsuarios.UseVisualStyleBackColor = true;
            BtnUsuarios.Click += BtnUsuarios_Click;
            // 
            // btnProductos
            // 
            btnProductos.Location = new Point(423, 70);
            btnProductos.Name = "btnProductos";
            btnProductos.Size = new Size(94, 29);
            btnProductos.TabIndex = 1;
            btnProductos.Text = "productos";
            btnProductos.UseVisualStyleBackColor = true;
            btnProductos.Click += btnProductos_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(319, 327);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(94, 29);
            btnSalir.TabIndex = 2;
            btnSalir.Text = "salir";
            btnSalir.UseVisualStyleBackColor = true;
            // 
            // txtProveedor
            // 
            txtProveedor.Location = new Point(239, 105);
            txtProveedor.Name = "txtProveedor";
            txtProveedor.Size = new Size(94, 29);
            txtProveedor.TabIndex = 3;
            txtProveedor.Text = "Proveedor";
            txtProveedor.UseVisualStyleBackColor = true;
            txtProveedor.Click += txtProveedor_Click;
            // 
            // btnOrden
            // 
            btnOrden.Location = new Point(423, 107);
            btnOrden.Name = "btnOrden";
            btnOrden.Size = new Size(94, 27);
            btnOrden.TabIndex = 4;
            btnOrden.Text = "orden";
            btnOrden.UseVisualStyleBackColor = true;
            btnOrden.Click += btnOrden_Click;
            // 
            // button1
            // 
            button1.Location = new Point(239, 140);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 5;
            button1.Text = "vendedores";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btnEnvio
            // 
            btnEnvio.Location = new Point(423, 140);
            btnEnvio.Name = "btnEnvio";
            btnEnvio.Size = new Size(94, 29);
            btnEnvio.TabIndex = 6;
            btnEnvio.Text = "Envio";
            btnEnvio.UseVisualStyleBackColor = true;
            btnEnvio.Click += btnEnvio_Click;
            // 
            // btnReembolso
            // 
            btnReembolso.Location = new Point(241, 184);
            btnReembolso.Name = "btnReembolso";
            btnReembolso.Size = new Size(94, 29);
            btnReembolso.TabIndex = 7;
            btnReembolso.Text = "Reembolso";
            btnReembolso.UseVisualStyleBackColor = true;
            btnReembolso.Click += btnReembolso_Click;
            // 
            // btndireccion
            // 
            btndireccion.Location = new Point(426, 177);
            btndireccion.Name = "btndireccion";
            btndireccion.Size = new Size(94, 29);
            btndireccion.TabIndex = 8;
            btndireccion.Text = "direcion";
            btndireccion.UseVisualStyleBackColor = true;
            btndireccion.Click += btndireccion_Click;
            // 
            // btnpromocion
            // 
            btnpromocion.Location = new Point(223, 231);
            btnpromocion.Name = "btnpromocion";
            btnpromocion.Size = new Size(94, 29);
            btnpromocion.TabIndex = 9;
            btnpromocion.Text = "Promocion";
            btnpromocion.UseVisualStyleBackColor = true;
            btnpromocion.Click += btnpromocion_Click;
            // 
            // btnPago
            // 
            btnPago.Location = new Point(427, 231);
            btnPago.Name = "btnPago";
            btnPago.Size = new Size(94, 50);
            btnPago.TabIndex = 10;
            btnPago.Text = "Metodo de pago";
            btnPago.UseVisualStyleBackColor = true;
            btnPago.Click += btnPago_Click;
            // 
            // menu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnPago);
            Controls.Add(btnpromocion);
            Controls.Add(btndireccion);
            Controls.Add(btnReembolso);
            Controls.Add(btnEnvio);
            Controls.Add(button1);
            Controls.Add(btnOrden);
            Controls.Add(txtProveedor);
            Controls.Add(btnSalir);
            Controls.Add(btnProductos);
            Controls.Add(BtnUsuarios);
            Name = "menu";
            Text = "menu";
            ResumeLayout(false);
        }

        #endregion

        private Button BtnUsuarios;
        private Button btnProductos;
        private Button btnSalir;
        private Button txtProveedor;
        private Button btnOrden;
        private Button button1;
        private Button btnEnvio;
        private Button btnReembolso;
        private Button btndireccion;
        private Button btnpromocion;
        private Button btnPago;
    }
}