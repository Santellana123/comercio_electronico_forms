namespace comercio_electronico_forms
{
    partial class FormPromocion
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
            txtnombre = new TextBox();
            txtdescuento = new TextBox();
            txtinicio = new TextBox();
            txtfin = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(32, 42);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(357, 324);
            dataGridView1.TabIndex = 0;
            // 
            // btncrear
            // 
            btncrear.Location = new Point(446, 42);
            btncrear.Name = "btncrear";
            btncrear.Size = new Size(94, 29);
            btncrear.TabIndex = 1;
            btncrear.Text = "btncrear";
            btncrear.UseVisualStyleBackColor = true;
            btncrear.Click += btncrear_Click;
            // 
            // btnleer
            // 
            btnleer.Location = new Point(591, 42);
            btnleer.Name = "btnleer";
            btnleer.Size = new Size(94, 29);
            btnleer.TabIndex = 2;
            btnleer.Text = "button2";
            btnleer.UseVisualStyleBackColor = true;
            btnleer.Click += btnleer_Click;
            // 
            // btnactualizar
            // 
            btnactualizar.Location = new Point(446, 102);
            btnactualizar.Name = "btnactualizar";
            btnactualizar.Size = new Size(94, 29);
            btnactualizar.TabIndex = 3;
            btnactualizar.Text = "button3";
            btnactualizar.UseVisualStyleBackColor = true;
            btnactualizar.Click += btnactualizar_Click;
            // 
            // btneliminar
            // 
            btneliminar.Location = new Point(591, 102);
            btneliminar.Name = "btneliminar";
            btneliminar.Size = new Size(94, 29);
            btneliminar.TabIndex = 4;
            btneliminar.Text = "button4";
            btneliminar.UseVisualStyleBackColor = true;
            btneliminar.Click += btneliminar_Click;
            // 
            // txtnombre
            // 
            txtnombre.Location = new Point(513, 184);
            txtnombre.Name = "txtnombre";
            txtnombre.Size = new Size(125, 27);
            txtnombre.TabIndex = 5;
            // 
            // txtdescuento
            // 
            txtdescuento.Location = new Point(514, 225);
            txtdescuento.Name = "txtdescuento";
            txtdescuento.Size = new Size(125, 27);
            txtdescuento.TabIndex = 6;
            // 
            // txtinicio
            // 
            txtinicio.Location = new Point(514, 260);
            txtinicio.Name = "txtinicio";
            txtinicio.Size = new Size(125, 27);
            txtinicio.TabIndex = 7;
            // 
            // txtfin
            // 
            txtfin.Location = new Point(513, 293);
            txtfin.Name = "txtfin";
            txtfin.Size = new Size(125, 27);
            txtfin.TabIndex = 8;
            // 
            // FormPromocion
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtfin);
            Controls.Add(txtinicio);
            Controls.Add(txtdescuento);
            Controls.Add(txtnombre);
            Controls.Add(btneliminar);
            Controls.Add(btnactualizar);
            Controls.Add(btnleer);
            Controls.Add(btncrear);
            Controls.Add(dataGridView1);
            Name = "FormPromocion";
            Text = "FormPromocion";
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
        private TextBox txtnombre;
        private TextBox txtdescuento;
        private TextBox txtinicio;
        private TextBox txtfin;
    }
}