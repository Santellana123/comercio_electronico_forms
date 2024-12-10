namespace comercio_electronico_forms
{
    partial class FormUsuario
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
            BtnCrear = new Button();
            BtnLeer = new Button();
            BtnActualizar = new Button();
            BtnEliminar = new Button();
            dataGridView1 = new DataGridView();
            txtNombre = new TextBox();
            txtEmail = new TextBox();
            txtContraseña = new TextBox();
            txtPermisos = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // BtnCrear
            // 
            BtnCrear.Location = new Point(544, 32);
            BtnCrear.Name = "BtnCrear";
            BtnCrear.Size = new Size(94, 29);
            BtnCrear.TabIndex = 0;
            BtnCrear.Text = "Crear";
            BtnCrear.UseVisualStyleBackColor = true;
            BtnCrear.Click += BtnCrear_Click;
            // 
            // BtnLeer
            // 
            BtnLeer.Location = new Point(694, 32);
            BtnLeer.Name = "BtnLeer";
            BtnLeer.Size = new Size(94, 29);
            BtnLeer.TabIndex = 1;
            BtnLeer.Text = "leer";
            BtnLeer.UseVisualStyleBackColor = true;
            BtnLeer.Click += BtnLeer_Click;
            // 
            // BtnActualizar
            // 
            BtnActualizar.Location = new Point(544, 79);
            BtnActualizar.Name = "BtnActualizar";
            BtnActualizar.Size = new Size(94, 29);
            BtnActualizar.TabIndex = 2;
            BtnActualizar.Text = "actualizar";
            BtnActualizar.UseVisualStyleBackColor = true;
            BtnActualizar.Click += BtnActualizar_Click;
            // 
            // BtnEliminar
            // 
            BtnEliminar.Location = new Point(694, 79);
            BtnEliminar.Name = "BtnEliminar";
            BtnEliminar.Size = new Size(94, 29);
            BtnEliminar.TabIndex = 3;
            BtnEliminar.Text = "eliminar";
            BtnEliminar.UseVisualStyleBackColor = true;
            BtnEliminar.Click += BtnEliminar_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(26, 23);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(489, 378);
            dataGridView1.TabIndex = 4;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(613, 158);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(125, 27);
            txtNombre.TabIndex = 5;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(613, 191);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(125, 27);
            txtEmail.TabIndex = 6;
            // 
            // txtContraseña
            // 
            txtContraseña.Location = new Point(613, 224);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.Size = new Size(125, 27);
            txtContraseña.TabIndex = 7;
            // 
            // txtPermisos
            // 
            txtPermisos.Location = new Point(613, 257);
            txtPermisos.Name = "txtPermisos";
            txtPermisos.Size = new Size(125, 27);
            txtPermisos.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(526, 165);
            label1.Name = "label1";
            label1.Size = new Size(61, 20);
            label1.TabIndex = 9;
            label1.Text = "nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(526, 198);
            label2.Name = "label2";
            label2.Size = new Size(46, 20);
            label2.TabIndex = 10;
            label2.Text = "email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(526, 227);
            label3.Name = "label3";
            label3.Size = new Size(81, 20);
            label3.TabIndex = 11;
            label3.Text = "contraseña";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(526, 264);
            label4.Name = "label4";
            label4.Size = new Size(69, 20);
            label4.TabIndex = 12;
            label4.Text = "permisos";
            // 
            // FormUsuario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtPermisos);
            Controls.Add(txtContraseña);
            Controls.Add(txtEmail);
            Controls.Add(txtNombre);
            Controls.Add(dataGridView1);
            Controls.Add(BtnEliminar);
            Controls.Add(BtnActualizar);
            Controls.Add(BtnLeer);
            Controls.Add(BtnCrear);
            Name = "FormUsuario";
            Text = "FormUsuario";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnCrear;
        private Button BtnLeer;
        private Button BtnActualizar;
        private Button BtnEliminar;
        private DataGridView dataGridView1;
        private TextBox txtNombre;
        private TextBox txtEmail;
        private TextBox txtContraseña;
        private TextBox txtPermisos;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}