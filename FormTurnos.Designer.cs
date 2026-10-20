namespace SistemaPeluqueria
{
    partial class FormTurnos
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
            cmbCliente = new ComboBox();
            cmbEmpleado = new ComboBox();
            cmbServicio = new ComboBox();
            dtpFecha = new DateTimePicker();
            dtpHora = new DateTimePicker();
            txtNotas = new TextBox();
            btnGuardar = new Button();
            dgvTurnos = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvTurnos).BeginInit();
            SuspendLayout();
            // 
            // cmbCliente
            // 
            cmbCliente.FormattingEnabled = true;
            cmbCliente.Location = new Point(126, 31);
            cmbCliente.Name = "cmbCliente";
            cmbCliente.Size = new Size(151, 28);
            cmbCliente.TabIndex = 0;
            // 
            // cmbEmpleado
            // 
            cmbEmpleado.FormattingEnabled = true;
            cmbEmpleado.Location = new Point(126, 95);
            cmbEmpleado.Name = "cmbEmpleado";
            cmbEmpleado.Size = new Size(151, 28);
            cmbEmpleado.TabIndex = 1;
            // 
            // cmbServicio
            // 
            cmbServicio.FormattingEnabled = true;
            cmbServicio.Location = new Point(126, 165);
            cmbServicio.Name = "cmbServicio";
            cmbServicio.Size = new Size(151, 28);
            cmbServicio.TabIndex = 2;
            // 
            // dtpFecha
            // 
            dtpFecha.Location = new Point(126, 236);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(250, 27);
            dtpFecha.TabIndex = 3;
            // 
            // dtpHora
            // 
            dtpHora.Format = DateTimePickerFormat.Time;
            dtpHora.Location = new Point(126, 301);
            dtpHora.Name = "dtpHora";
            dtpHora.ShowUpDown = true;
            dtpHora.Size = new Size(250, 27);
            dtpHora.TabIndex = 4;
            // 
            // txtNotas
            // 
            txtNotas.Location = new Point(126, 375);
            txtNotas.Name = "txtNotas";
            txtNotas.Size = new Size(125, 27);
            txtNotas.TabIndex = 5;
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
            // dgvTurnos
            // 
            dgvTurnos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvTurnos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTurnos.Location = new Point(382, 12);
            dgvTurnos.Name = "dgvTurnos";
            dgvTurnos.RowHeadersWidth = 51;
            dgvTurnos.Size = new Size(406, 371);
            dgvTurnos.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 39);
            label1.Name = "label1";
            label1.Size = new Size(55, 20);
            label1.TabIndex = 8;
            label1.Text = "Cliente";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 103);
            label2.Name = "label2";
            label2.Size = new Size(77, 20);
            label2.TabIndex = 9;
            label2.Text = "Empleado";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 173);
            label3.Name = "label3";
            label3.Size = new Size(61, 20);
            label3.TabIndex = 10;
            label3.Text = "Servicio";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 243);
            label4.Name = "label4";
            label4.Size = new Size(47, 20);
            label4.TabIndex = 11;
            label4.Text = "Fecha";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 308);
            label5.Name = "label5";
            label5.Size = new Size(42, 20);
            label5.TabIndex = 12;
            label5.Text = "Hora";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 382);
            label6.Name = "label6";
            label6.Size = new Size(48, 20);
            label6.TabIndex = 13;
            label6.Text = "Notas";
            // 
            // FormTurnos
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
            Controls.Add(dgvTurnos);
            Controls.Add(btnGuardar);
            Controls.Add(txtNotas);
            Controls.Add(dtpHora);
            Controls.Add(dtpFecha);
            Controls.Add(cmbServicio);
            Controls.Add(cmbEmpleado);
            Controls.Add(cmbCliente);
            Name = "FormTurnos";
            Text = "FormTurnos";
            ((System.ComponentModel.ISupportInitialize)dgvTurnos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbCliente;
        private ComboBox cmbEmpleado;
        private ComboBox cmbServicio;
        private DateTimePicker dtpFecha;
        private DateTimePicker dtpHora;
        private TextBox txtNotas;
        private Button btnGuardar;
        private DataGridView dgvTurnos;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}