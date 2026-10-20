namespace SistemaPeluqueria
{
    partial class FormMenu
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
            btnClientes = new Button();
            btnServicios = new Button();
            btnTurnos = new Button();
            btnEmpleados = new Button();
            btnCaja = new Button();
            btnStock = new Button();
            SuspendLayout();
            // 
            // btnClientes
            // 
            btnClientes.Location = new Point(80, 100);
            btnClientes.Name = "btnClientes";
            btnClientes.Size = new Size(180, 55);
            btnClientes.TabIndex = 0;
            btnClientes.Text = "Clientes";
            btnClientes.UseVisualStyleBackColor = true;
            btnClientes.Click += btnClientes_Click;
            // 
            // btnServicios
            // 
            btnServicios.Location = new Point(80, 170);
            btnServicios.Name = "btnServicios";
            btnServicios.Size = new Size(180, 55);
            btnServicios.TabIndex = 1;
            btnServicios.Text = "Servicios";
            btnServicios.UseVisualStyleBackColor = true;
            btnServicios.Click += btnServicios_Click;
            // 
            // btnTurnos
            // 
            btnTurnos.Location = new Point(80, 240);
            btnTurnos.Name = "btnTurnos";
            btnTurnos.Size = new Size(180, 55);
            btnTurnos.TabIndex = 2;
            btnTurnos.Text = "Turnos";
            btnTurnos.UseVisualStyleBackColor = true;
            btnTurnos.Click += btnTurnos_Click;
            // 
            // btnEmpleados
            // 
            btnEmpleados.Location = new Point(290, 100);
            btnEmpleados.Name = "btnEmpleados";
            btnEmpleados.Size = new Size(180, 55);
            btnEmpleados.TabIndex = 3;
            btnEmpleados.Text = "Empleados";
            btnEmpleados.UseVisualStyleBackColor = true;
            btnEmpleados.Click += btnEmpleados_Click;
            // 
            // btnCaja
            // 
            btnCaja.Location = new Point(290, 170);
            btnCaja.Name = "btnCaja";
            btnCaja.Size = new Size(180, 55);
            btnCaja.TabIndex = 4;
            btnCaja.Text = "Caja";
            btnCaja.UseVisualStyleBackColor = true;
            btnCaja.Click += btnCaja_Click;
            // 
            // btnStock
            // 
            btnStock.Location = new Point(290, 240);
            btnStock.Name = "btnStock";
            btnStock.Size = new Size(180, 55);
            btnStock.TabIndex = 5;
            btnStock.Text = "Stock";
            btnStock.UseVisualStyleBackColor = true;
            btnStock.Click += btnStock_Click;
            // 
            // FormMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(582, 373);
            Controls.Add(btnStock);
            Controls.Add(btnCaja);
            Controls.Add(btnEmpleados);
            Controls.Add(btnTurnos);
            Controls.Add(btnServicios);
            Controls.Add(btnClientes);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormMenu";
            Text = "FormMenu";
            ResumeLayout(false);
        }

        #endregion

        private Button btnClientes;
        private Button btnServicios;
        private Button btnTurnos;
        private Button btnEmpleados;
        private Button btnCaja;
        private Button btnStock;
    }
}