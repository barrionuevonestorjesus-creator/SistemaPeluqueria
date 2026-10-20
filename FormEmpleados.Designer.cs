namespace SistemaPeluqueria
{
    partial class FormEmpleados
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
            txtNombre = new TextBox();
            txtApellido = new TextBox();
            txtDNI = new TextBox();
            txtTelefono = new TextBox();
            txtEmail = new TextBox();
            txtEspecialidad = new TextBox();
            btnGuardar = new Button();
            dgvEmpleados = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvEmpleados).BeginInit();
            SuspendLayout();
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(151, 45);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(162, 27);
            txtNombre.TabIndex = 0;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(151, 101);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(162, 27);
            txtApellido.TabIndex = 1;
            // 
            // txtDNI
            // 
            txtDNI.Location = new Point(151, 167);
            txtDNI.Name = "txtDNI";
            txtDNI.Size = new Size(162, 27);
            txtDNI.TabIndex = 2;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(151, 234);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(162, 27);
            txtTelefono.TabIndex = 3;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(151, 297);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(162, 27);
            txtEmail.TabIndex = 4;
            // 
            // txtEspecialidad
            // 
            txtEspecialidad.Location = new Point(151, 365);
            txtEspecialidad.Name = "txtEspecialidad";
            txtEspecialidad.Size = new Size(162, 27);
            txtEspecialidad.TabIndex = 5;
            // 
            // btnGuardar
            // 
            btnGuardar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnGuardar.Location = new Point(694, 409);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(94, 29);
            btnGuardar.TabIndex = 6;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // dgvEmpleados
            // 
            dgvEmpleados.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvEmpleados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEmpleados.Location = new Point(346, 45);
            dgvEmpleados.Name = "dgvEmpleados";
            dgvEmpleados.RowHeadersWidth = 51;
            dgvEmpleados.Size = new Size(442, 335);
            dgvEmpleados.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 52);
            label1.Name = "label1";
            label1.Size = new Size(64, 20);
            label1.TabIndex = 8;
            label1.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 108);
            label2.Name = "label2";
            label2.Size = new Size(66, 20);
            label2.TabIndex = 9;
            label2.Text = "Apellido";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 174);
            label3.Name = "label3";
            label3.Size = new Size(35, 20);
            label3.TabIndex = 10;
            label3.Text = "DNI";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 241);
            label4.Name = "label4";
            label4.Size = new Size(67, 20);
            label4.TabIndex = 11;
            label4.Text = "Telefono";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 304);
            label5.Name = "label5";
            label5.Size = new Size(46, 20);
            label5.TabIndex = 12;
            label5.Text = "Email";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 372);
            label6.Name = "label6";
            label6.Size = new Size(93, 20);
            label6.TabIndex = 13;
            label6.Text = "Especialidad";
            // 
            // FormEmpleados
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgvEmpleados);
            Controls.Add(btnGuardar);
            Controls.Add(txtEspecialidad);
            Controls.Add(txtEmail);
            Controls.Add(txtTelefono);
            Controls.Add(txtDNI);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            Name = "FormEmpleados";
            Text = "FormEmpleados";
            ((System.ComponentModel.ISupportInitialize)dgvEmpleados).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNombre;
        private TextBox txtApellido;
        private TextBox txtDNI;
        private TextBox txtTelefono;
        private TextBox txtEmail;
        private TextBox txtEspecialidad;
        private Button btnGuardar;
        private DataGridView dgvEmpleados;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}