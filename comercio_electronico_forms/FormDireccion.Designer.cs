namespace comercio_electronico_forms
{
    partial class FormDireccion
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
            txtusuario_id = new TextBox();
            txtcalle = new TextBox();
            txtciudad = new TextBox();
            txtestado = new TextBox();
            txtpais = new TextBox();
            txcp = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 44);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(446, 348);
            dataGridView1.TabIndex = 0;
            // 
            // btncrear
            // 
            btncrear.Location = new Point(498, 49);
            btncrear.Name = "btncrear";
            btncrear.Size = new Size(94, 29);
            btncrear.TabIndex = 1;
            btncrear.Text = "button1";
            btncrear.UseVisualStyleBackColor = true;
            btncrear.Click += btncrear_Click;
            // 
            // btnleer
            // 
            btnleer.Location = new Point(625, 49);
            btnleer.Name = "btnleer";
            btnleer.Size = new Size(94, 29);
            btnleer.TabIndex = 2;
            btnleer.Text = "button2";
            btnleer.UseVisualStyleBackColor = true;
            btnleer.Click += btnleer_Click;
            // 
            // btnactualizar
            // 
            btnactualizar.Location = new Point(498, 121);
            btnactualizar.Name = "btnactualizar";
            btnactualizar.Size = new Size(94, 29);
            btnactualizar.TabIndex = 3;
            btnactualizar.Text = "button3";
            btnactualizar.UseVisualStyleBackColor = true;
            btnactualizar.Click += btnactualizar_Click;
            // 
            // btneliminar
            // 
            btneliminar.Location = new Point(625, 121);
            btneliminar.Name = "btneliminar";
            btneliminar.Size = new Size(94, 29);
            btneliminar.TabIndex = 4;
            btneliminar.Text = "button4";
            btneliminar.UseVisualStyleBackColor = true;
            btneliminar.Click += btneliminar_Click;
            // 
            // txtusuario_id
            // 
            txtusuario_id.Location = new Point(545, 195);
            txtusuario_id.Name = "txtusuario_id";
            txtusuario_id.Size = new Size(125, 27);
            txtusuario_id.TabIndex = 5;
            // 
            // txtcalle
            // 
            txtcalle.Location = new Point(545, 228);
            txtcalle.Name = "txtcalle";
            txtcalle.Size = new Size(125, 27);
            txtcalle.TabIndex = 6;
            // 
            // txtciudad
            // 
            txtciudad.Location = new Point(545, 261);
            txtciudad.Name = "txtciudad";
            txtciudad.Size = new Size(125, 27);
            txtciudad.TabIndex = 7;
            // 
            // txtestado
            // 
            txtestado.Location = new Point(545, 294);
            txtestado.Name = "txtestado";
            txtestado.Size = new Size(125, 27);
            txtestado.TabIndex = 8;
            // 
            // txtpais
            // 
            txtpais.Location = new Point(545, 334);
            txtpais.Name = "txtpais";
            txtpais.Size = new Size(125, 27);
            txtpais.TabIndex = 9;
            // 
            // txcp
            // 
            txcp.Location = new Point(545, 365);
            txcp.Name = "txcp";
            txcp.Size = new Size(125, 27);
            txcp.TabIndex = 10;
            // 
            // FormDireccion
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txcp);
            Controls.Add(txtpais);
            Controls.Add(txtestado);
            Controls.Add(txtciudad);
            Controls.Add(txtcalle);
            Controls.Add(txtusuario_id);
            Controls.Add(btneliminar);
            Controls.Add(btnactualizar);
            Controls.Add(btnleer);
            Controls.Add(btncrear);
            Controls.Add(dataGridView1);
            Name = "FormDireccion";
            Text = "FormDireccion";
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
        private TextBox txtusuario_id;
        private TextBox txtcalle;
        private TextBox txtciudad;
        private TextBox txtestado;
        private TextBox txtpais;
        private TextBox txcp;
    }
}