namespace comercio_electronico_forms
{
    partial class FormVendedor
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
            dataGridView1 = new DataGridView();
            btncrear = new Button();
            btnleer = new Button();
            btnactualizar = new Button();
            btneliminar = new Button();
            txtUsuarioid = new TextBox();
            txtnombre_tienda = new TextBox();
            txtreputacion = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 55);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(434, 283);
            dataGridView1.TabIndex = 0;
            // 
            // btncrear
            // 
            btncrear.Location = new Point(509, 60);
            btncrear.Name = "btncrear";
            btncrear.Size = new Size(94, 29);
            btncrear.TabIndex = 1;
            btncrear.Text = "button1";
            btncrear.UseVisualStyleBackColor = true;
            btncrear.Click += btncrear_Click;
            // 
            // btnleer
            // 
            btnleer.Location = new Point(653, 60);
            btnleer.Name = "btnleer";
            btnleer.Size = new Size(94, 29);
            btnleer.TabIndex = 2;
            btnleer.Text = "button2";
            btnleer.UseVisualStyleBackColor = true;
            btnleer.Click += btnleer_Click;
            // 
            // btnactualizar
            // 
            btnactualizar.Location = new Point(506, 121);
            btnactualizar.Name = "btnactualizar";
            btnactualizar.Size = new Size(94, 29);
            btnactualizar.TabIndex = 3;
            btnactualizar.Text = "button3";
            btnactualizar.UseVisualStyleBackColor = true;
            btnactualizar.Click += btnactualizar_Click;
            // 
            // btneliminar
            // 
            btneliminar.Location = new Point(653, 121);
            btneliminar.Name = "btneliminar";
            btneliminar.Size = new Size(94, 29);
            btneliminar.TabIndex = 4;
            btneliminar.Text = "button4";
            btneliminar.UseVisualStyleBackColor = true;
            btneliminar.Click += btneliminar_Click;
            // 
            // txtUsuarioid
            // 
            txtUsuarioid.Location = new Point(572, 191);
            txtUsuarioid.Name = "txtUsuarioid";
            txtUsuarioid.Size = new Size(125, 27);
            txtUsuarioid.TabIndex = 5;
            // 
            // txtnombre_tienda
            // 
            txtnombre_tienda.Location = new Point(572, 224);
            txtnombre_tienda.Name = "txtnombre_tienda";
            txtnombre_tienda.Size = new Size(125, 27);
            txtnombre_tienda.TabIndex = 6;
            // 
            // txtreputacion
            // 
            txtreputacion.Location = new Point(572, 267);
            txtreputacion.Name = "txtreputacion";
            txtreputacion.Size = new Size(125, 27);
            txtreputacion.TabIndex = 7;
            // 
            // FormVendedor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtreputacion);
            Controls.Add(txtnombre_tienda);
            Controls.Add(txtUsuarioid);
            Controls.Add(btneliminar);
            Controls.Add(btnactualizar);
            Controls.Add(btnleer);
            Controls.Add(btncrear);
            Controls.Add(dataGridView1);
            Name = "FormVendedor";
            Text = "FormVendedor";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button btncrear;
        private Button btnleer;
        private Button btnactualizar;
        private Button btneliminar;
        private TextBox txtUsuarioid;
        private TextBox txtnombre_tienda;
        private TextBox txtreputacion;
    }
}