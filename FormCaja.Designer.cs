namespace SistemaPeluqueria
{
    partial class FormCaja
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
            cmbMedioPago = new ComboBox();
            cmbCliente = new ComboBox();
            cmbServicio = new ComboBox();
            btnAgregar = new Button();
            btnCobrar = new Button();
            dgvDetalle = new DataGridView();
            dgvHistorial = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            lblTotal = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvDetalle).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvHistorial).BeginInit();
            SuspendLayout();
            // 
            // cmbMedioPago
            // 
            cmbMedioPago.FormattingEnabled = true;
            cmbMedioPago.Location = new Point(141, 206);
            cmbMedioPago.Name = "cmbMedioPago";
            cmbMedioPago.Size = new Size(151, 28);
            cmbMedioPago.TabIndex = 0;
            // 
            // cmbCliente
            // 
            cmbCliente.FormattingEnabled = true;
            cmbCliente.Location = new Point(141, 47);
            cmbCliente.Name = "cmbCliente";
            cmbCliente.Size = new Size(151, 28);
            cmbCliente.TabIndex = 1;
            // 
            // cmbServicio
            // 
            cmbServicio.FormattingEnabled = true;
            cmbServicio.Location = new Point(141, 129);
            cmbServicio.Name = "cmbServicio";
            cmbServicio.Size = new Size(151, 28);
            cmbServicio.TabIndex = 2;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(12, 409);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(94, 29);
            btnAgregar.TabIndex = 3;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnCobrar
            // 
            btnCobrar.Location = new Point(141, 409);
            btnCobrar.Name = "btnCobrar";
            btnCobrar.Size = new Size(94, 29);
            btnCobrar.TabIndex = 4;
            btnCobrar.Text = "Cobrar";
            btnCobrar.UseVisualStyleBackColor = true;
            btnCobrar.Click += btnCobrar_Click;
            // 
            // dgvDetalle
            // 
            dgvDetalle.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDetalle.Location = new Point(418, 12);
            dgvDetalle.Name = "dgvDetalle";
            dgvDetalle.RowHeadersWidth = 51;
            dgvDetalle.Size = new Size(370, 200);
            dgvDetalle.TabIndex = 5;
            // 
            // dgvHistorial
            // 
            dgvHistorial.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHistorial.Location = new Point(418, 239);
            dgvHistorial.Name = "dgvHistorial";
            dgvHistorial.RowHeadersWidth = 51;
            dgvHistorial.Size = new Size(370, 199);
            dgvHistorial.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 55);
            label1.Name = "label1";
            label1.Size = new Size(55, 20);
            label1.TabIndex = 7;
            label1.Text = "Cliente";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 137);
            label2.Name = "label2";
            label2.Size = new Size(61, 20);
            label2.TabIndex = 8;
            label2.Text = "Servicio";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 214);
            label3.Name = "label3";
            label3.Size = new Size(110, 20);
            label3.TabIndex = 9;
            label3.Text = "Medio de Pago";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 281);
            label4.Name = "label4";
            label4.Size = new Size(42, 20);
            label4.TabIndex = 10;
            label4.Text = "Total";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(141, 281);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(0, 20);
            lblTotal.TabIndex = 11;
            // 
            // FormCaja
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblTotal);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgvHistorial);
            Controls.Add(dgvDetalle);
            Controls.Add(btnCobrar);
            Controls.Add(btnAgregar);
            Controls.Add(cmbServicio);
            Controls.Add(cmbCliente);
            Controls.Add(cmbMedioPago);
            Name = "FormCaja";
            Text = "FormCaja";
            ((System.ComponentModel.ISupportInitialize)dgvDetalle).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvHistorial).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbMedioPago;
        private ComboBox cmbCliente;
        private ComboBox cmbServicio;
        private Button btnAgregar;
        private Button btnCobrar;
        private DataGridView dgvDetalle;
        private DataGridView dgvHistorial;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label lblTotal;
    }
}