namespace comercio_electronico_forms
{
    partial class FormularioOrden
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
            txtestado_id = new TextBox();
            txtfecha = new TextBox();
            txttotal = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 39);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(417, 351);
            dataGridView1.TabIndex = 0;
            // 
            // btncrear
            // 
            btncrear.Location = new Point(474, 52);
            btncrear.Name = "btncrear";
            btncrear.Size = new Size(94, 29);
            btncrear.TabIndex = 1;
            btncrear.Text = "button1";
            btncrear.UseVisualStyleBackColor = true;
            btncrear.Click += btncrear_Click;
            // 
            // btnleer
            // 
            btnleer.Location = new Point(668, 52);
            btnleer.Name = "btnleer";
            btnleer.Size = new Size(94, 29);
            btnleer.TabIndex = 2;
            btnleer.Text = "button2";
            btnleer.UseVisualStyleBackColor = true;
            btnleer.Click += btnleer_Click;
            // 
            // btnactualizar
            // 
            btnactualizar.Location = new Point(474, 116);
            btnactualizar.Name = "btnactualizar";
            btnactualizar.Size = new Size(94, 29);
            btnactualizar.TabIndex = 3;
            btnactualizar.Text = "button3";
            btnactualizar.UseVisualStyleBackColor = true;
            btnactualizar.Click += btnactualizar_Click;
            // 
            // btneliminar
            // 
            btneliminar.Location = new Point(668, 116);
            btneliminar.Name = "btneliminar";
            btneliminar.Size = new Size(94, 29);
            btneliminar.TabIndex = 4;
            btneliminar.Text = "button4";
            btneliminar.UseVisualStyleBackColor = true;
            btneliminar.Click += btneliminar_Click;
            // 
            // txtusuario_id
            // 
            txtusuario_id.Location = new Point(567, 184);
            txtusuario_id.Name = "txtusuario_id";
            txtusuario_id.Size = new Size(125, 27);
            txtusuario_id.TabIndex = 5;
            // 
            // txtestado_id
            // 
            txtestado_id.Location = new Point(567, 227);
            txtestado_id.Name = "txtestado_id";
            txtestado_id.Size = new Size(125, 27);
            txtestado_id.TabIndex = 6;
            // 
            // txtfecha
            // 
            txtfecha.Location = new Point(567, 274);
            txtfecha.Name = "txtfecha";
            txtfecha.Size = new Size(125, 27);
            txtfecha.TabIndex = 7;
            // 
            // txttotal
            // 
            txttotal.Location = new Point(567, 307);
            txttotal.Name = "txttotal";
            txttotal.Size = new Size(125, 27);
            txttotal.TabIndex = 8;
            // 
            // FormularioOrden
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txttotal);
            Controls.Add(txtfecha);
            Controls.Add(txtestado_id);
            Controls.Add(txtusuario_id);
            Controls.Add(btneliminar);
            Controls.Add(btnactualizar);
            Controls.Add(btnleer);
            Controls.Add(btncrear);
            Controls.Add(dataGridView1);
            Name = "FormularioOrden";
            Text = "FormularioOrden";
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
        private TextBox txtestado_id;
        private TextBox txtfecha;
        private TextBox txttotal;
    }
}