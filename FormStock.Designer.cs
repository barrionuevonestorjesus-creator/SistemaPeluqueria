namespace SistemaPeluqueria
{
    partial class FormStock
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
            txtCategoria = new TextBox();
            txtStockActual = new TextBox();
            txtStockMinimo = new TextBox();
            txtUnidad = new TextBox();
            txtPrecioCompra = new TextBox();
            txtProveedor = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            btnGuardar = new Button();
            dgvProductos = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
            SuspendLayout();
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(181, 51);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(125, 27);
            txtNombre.TabIndex = 0;
            // 
            // txtCategoria
            // 
            txtCategoria.Location = new Point(181, 106);
            txtCategoria.Name = "txtCategoria";
            txtCategoria.Size = new Size(125, 27);
            txtCategoria.TabIndex = 1;
            // 
            // txtStockActual
            // 
            txtStockActual.Location = new Point(181, 161);
            txtStockActual.Name = "txtStockActual";
            txtStockActual.Size = new Size(125, 27);
            txtStockActual.TabIndex = 2;
            // 
            // txtStockMinimo
            // 
            txtStockMinimo.Location = new Point(181, 213);
            txtStockMinimo.Name = "txtStockMinimo";
            txtStockMinimo.Size = new Size(125, 27);
            txtStockMinimo.TabIndex = 3;
            // 
            // txtUnidad
            // 
            txtUnidad.Location = new Point(181, 264);
            txtUnidad.Name = "txtUnidad";
            txtUnidad.Size = new Size(125, 27);
            txtUnidad.TabIndex = 4;
            // 
            // txtPrecioCompra
            // 
            txtPrecioCompra.Location = new Point(181, 316);
            txtPrecioCompra.Name = "txtPrecioCompra";
            txtPrecioCompra.Size = new Size(125, 27);
            txtPrecioCompra.TabIndex = 5;
            // 
            // txtProveedor
            // 
            txtProveedor.Location = new Point(181, 371);
            txtProveedor.Name = "txtProveedor";
            txtProveedor.Size = new Size(125, 27);
            txtProveedor.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(31, 58);
            label1.Name = "label1";
            label1.Size = new Size(64, 20);
            label1.TabIndex = 7;
            label1.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(31, 113);
            label2.Name = "label2";
            label2.Size = new Size(74, 20);
            label2.TabIndex = 8;
            label2.Text = "Categoría";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(31, 168);
            label3.Name = "label3";
            label3.Size = new Size(91, 20);
            label3.TabIndex = 9;
            label3.Text = "Stock Actual";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(31, 220);
            label4.Name = "label4";
            label4.Size = new Size(100, 20);
            label4.TabIndex = 10;
            label4.Text = "Stock Mínimo";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(31, 271);
            label5.Name = "label5";
            label5.Size = new Size(57, 20);
            label5.TabIndex = 11;
            label5.Text = "Unidad";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(31, 323);
            label6.Name = "label6";
            label6.Size = new Size(107, 20);
            label6.TabIndex = 12;
            label6.Text = "Precio Compra";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(31, 378);
            label7.Name = "label7";
            label7.Size = new Size(77, 20);
            label7.TabIndex = 13;
            label7.Text = "Proveedor";
            // 
            // btnGuardar
            // 
            btnGuardar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnGuardar.Location = new Point(694, 409);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(94, 29);
            btnGuardar.TabIndex = 14;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // dgvProductos
            // 
            dgvProductos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductos.Location = new Point(350, 51);
            dgvProductos.Name = "dgvProductos";
            dgvProductos.RowHeadersWidth = 51;
            dgvProductos.Size = new Size(438, 347);
            dgvProductos.TabIndex = 15;
            // 
            // FormStock
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvProductos);
            Controls.Add(btnGuardar);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtProveedor);
            Controls.Add(txtPrecioCompra);
            Controls.Add(txtUnidad);
            Controls.Add(txtStockMinimo);
            Controls.Add(txtStockActual);
            Controls.Add(txtCategoria);
            Controls.Add(txtNombre);
            Name = "FormStock";
            Text = "FormStock";
            ((System.ComponentModel.ISupportInitialize)dgvProductos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNombre;
        private TextBox txtCategoria;
        private TextBox txtStockActual;
        private TextBox txtStockMinimo;
        private TextBox txtUnidad;
        private TextBox txtPrecioCompra;
        private TextBox txtProveedor;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Button btnGuardar;
        private DataGridView dgvProductos;
    }
}