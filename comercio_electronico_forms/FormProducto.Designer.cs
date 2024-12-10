namespace comercio_electronico_forms
{
    partial class FormProducto
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
            btncrear = new Button();
            btnlee = new Button();
            btnactualizar = new Button();
            btnelininar = new Button();
            dataGridView1 = new DataGridView();
            txtnombre = new TextBox();
            txtdescripcion = new TextBox();
            txtprecio = new TextBox();
            txtmarcaid = new TextBox();
            txtcategoriaid = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btncrear
            // 
            btncrear.Location = new Point(581, 47);
            btncrear.Name = "btncrear";
            btncrear.Size = new Size(94, 29);
            btncrear.TabIndex = 0;
            btncrear.Text = "Crear";
            btncrear.UseVisualStyleBackColor = true;
            btncrear.Click += btncrear_Click;
            // 
            // btnlee
            // 
            btnlee.Location = new Point(681, 47);
            btnlee.Name = "btnlee";
            btnlee.Size = new Size(94, 29);
            btnlee.TabIndex = 1;
            btnlee.Text = "button2";
            btnlee.UseVisualStyleBackColor = true;
            btnlee.Click += btnlee_Click;
            // 
            // btnactualizar
            // 
            btnactualizar.Location = new Point(581, 121);
            btnactualizar.Name = "btnactualizar";
            btnactualizar.Size = new Size(94, 29);
            btnactualizar.TabIndex = 2;
            btnactualizar.Text = "button3";
            btnactualizar.UseVisualStyleBackColor = true;
            btnactualizar.Click += btnactualizar_Click;
            // 
            // btnelininar
            // 
            btnelininar.Location = new Point(681, 121);
            btnelininar.Name = "btnelininar";
            btnelininar.Size = new Size(94, 29);
            btnelininar.TabIndex = 3;
            btnelininar.Text = "button4";
            btnelininar.UseVisualStyleBackColor = true;
            btnelininar.Click += btnelininar_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(38, 47);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(499, 333);
            dataGridView1.TabIndex = 4;
            // 
            // txtnombre
            // 
            txtnombre.Location = new Point(600, 174);
            txtnombre.Name = "txtnombre";
            txtnombre.Size = new Size(125, 27);
            txtnombre.TabIndex = 5;
            // 
            // txtdescripcion
            // 
            txtdescripcion.Location = new Point(601, 207);
            txtdescripcion.Name = "txtdescripcion";
            txtdescripcion.Size = new Size(125, 27);
            txtdescripcion.TabIndex = 6;
            // 
            // txtprecio
            // 
            txtprecio.Location = new Point(600, 240);
            txtprecio.Name = "txtprecio";
            txtprecio.Size = new Size(125, 27);
            txtprecio.TabIndex = 7;
            // 
            // txtmarcaid
            // 
            txtmarcaid.Location = new Point(601, 273);
            txtmarcaid.Name = "txtmarcaid";
            txtmarcaid.Size = new Size(125, 27);
            txtmarcaid.TabIndex = 8;
            // 
            // txtcategoriaid
            // 
            txtcategoriaid.Location = new Point(600, 323);
            txtcategoriaid.Name = "txtcategoriaid";
            txtcategoriaid.Size = new Size(125, 27);
            txtcategoriaid.TabIndex = 9;
            // 
            // FormProducto
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtcategoriaid);
            Controls.Add(txtmarcaid);
            Controls.Add(txtprecio);
            Controls.Add(txtdescripcion);
            Controls.Add(txtnombre);
            Controls.Add(dataGridView1);
            Controls.Add(btnelininar);
            Controls.Add(btnactualizar);
            Controls.Add(btnlee);
            Controls.Add(btncrear);
            Name = "FormProducto";
            Text = "FormProducto";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btncrear;
        private Button btnlee;
        private Button btnactualizar;
        private Button btnelininar;
        private DataGridView dataGridView1;
        private TextBox txtnombre;
        private TextBox txtdescripcion;
        private TextBox txtprecio;
        private TextBox txtmarcaid;
        private TextBox txtcategoriaid;
    }
}