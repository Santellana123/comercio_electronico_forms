namespace comercio_electronico_forms
{
    partial class FormMetodoPago
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
            txtusuarioid = new TextBox();
            txttipo = new TextBox();
            txtnumtarjeta = new TextBox();
            txtfechavencimiento = new TextBox();
            txtcvv = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(22, 43);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(417, 311);
            dataGridView1.TabIndex = 0;
            // 
            // btncrear
            // 
            btncrear.Location = new Point(493, 64);
            btncrear.Name = "btncrear";
            btncrear.Size = new Size(94, 29);
            btncrear.TabIndex = 1;
            btncrear.Text = "button1";
            btncrear.UseVisualStyleBackColor = true;
            btncrear.Click += btncrear_Click;
            // 
            // btnleer
            // 
            btnleer.Location = new Point(620, 64);
            btnleer.Name = "btnleer";
            btnleer.Size = new Size(94, 29);
            btnleer.TabIndex = 2;
            btnleer.Text = "button2";
            btnleer.UseVisualStyleBackColor = true;
            btnleer.Click += btnleer_Click;
            // 
            // btnactualizar
            // 
            btnactualizar.Location = new Point(493, 99);
            btnactualizar.Name = "btnactualizar";
            btnactualizar.Size = new Size(94, 29);
            btnactualizar.TabIndex = 3;
            btnactualizar.Text = "button3";
            btnactualizar.UseVisualStyleBackColor = true;
            btnactualizar.Click += btnactualizar_Click;
            // 
            // btneliminar
            // 
            btneliminar.Location = new Point(620, 99);
            btneliminar.Name = "btneliminar";
            btneliminar.Size = new Size(94, 29);
            btneliminar.TabIndex = 4;
            btneliminar.Text = "button4";
            btneliminar.UseVisualStyleBackColor = true;
            btneliminar.Click += btneliminar_Click;
            // 
            // txtusuarioid
            // 
            txtusuarioid.Location = new Point(522, 163);
            txtusuarioid.Name = "txtusuarioid";
            txtusuarioid.Size = new Size(125, 27);
            txtusuarioid.TabIndex = 5;
            // 
            // txttipo
            // 
            txttipo.Location = new Point(522, 207);
            txttipo.Name = "txttipo";
            txttipo.Size = new Size(125, 27);
            txttipo.TabIndex = 6;
            // 
            // txtnumtarjeta
            // 
            txtnumtarjeta.Location = new Point(522, 251);
            txtnumtarjeta.Name = "txtnumtarjeta";
            txtnumtarjeta.Size = new Size(125, 27);
            txtnumtarjeta.TabIndex = 7;
            // 
            // txtfechavencimiento
            // 
            txtfechavencimiento.Location = new Point(522, 294);
            txtfechavencimiento.Name = "txtfechavencimiento";
            txtfechavencimiento.Size = new Size(125, 27);
            txtfechavencimiento.TabIndex = 8;
            // 
            // txtcvv
            // 
            txtcvv.Location = new Point(522, 338);
            txtcvv.Name = "txtcvv";
            txtcvv.Size = new Size(125, 27);
            txtcvv.TabIndex = 9;
            // 
            // FormMetodoPago
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtcvv);
            Controls.Add(txtfechavencimiento);
            Controls.Add(txtnumtarjeta);
            Controls.Add(txttipo);
            Controls.Add(txtusuarioid);
            Controls.Add(btneliminar);
            Controls.Add(btnactualizar);
            Controls.Add(btnleer);
            Controls.Add(btncrear);
            Controls.Add(dataGridView1);
            Name = "FormMetodoPago";
            Text = "FormMetodoPago";
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
        private TextBox txtusuarioid;
        private TextBox txttipo;
        private TextBox txtnumtarjeta;
        private TextBox txtfechavencimiento;
        private TextBox txtcvv;
    }
}