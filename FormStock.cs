using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SistemaPeluqueria
{
    public partial class FormStock : Form
    {
        public FormStock()
        {
            InitializeComponent();
            this.Text = "Stock / Inventario";
            ConfigurarTabla();
            CargarProductos();
        }

        private void ConfigurarTabla()
        {
            dgvProductos.AutoGenerateColumns = false;
            dgvProductos.Columns.Clear();

            dgvProductos.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Nombre", DataPropertyName = "Nombre", Width = 150 });
            dgvProductos.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Categoría", DataPropertyName = "Categoria", Width = 100 });
            dgvProductos.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Stock", DataPropertyName = "StockActual", Width = 70 });
            dgvProductos.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Mínimo", DataPropertyName = "StockMinimo", Width = 70 });
            dgvProductos.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Unidad", DataPropertyName = "UnidadMedida", Width = 80 });
            dgvProductos.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Proveedor", DataPropertyName = "Proveedor", Width = 130 });
        }

        private void CargarProductos()
        {
            var productos = ProductoDAO.ObtenerTodos();
            dgvProductos.DataSource = productos;

            foreach (DataGridViewRow row in dgvProductos.Rows)
            {
                var producto = (Producto)row.DataBoundItem;
                if (producto.BajoStock)
                    row.DefaultCellStyle.BackColor = Color.LightCoral;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("El nombre es obligatorio.", "Atención",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(txtStockActual.Text, out decimal stockActual))
                stockActual = 0;

            if (!decimal.TryParse(txtStockMinimo.Text, out decimal stockMinimo))
                stockMinimo = 5;

            if (!decimal.TryParse(txtPrecioCompra.Text, out decimal precio))
                precio = 0;

            try
            {
                Producto nuevo = new Producto
                {
                    Nombre = txtNombre.Text.Trim(),
                    Categoria = txtCategoria.Text.Trim(),
                    StockActual = stockActual,
                    StockMinimo = stockMinimo,
                    UnidadMedida = string.IsNullOrWhiteSpace(txtUnidad.Text) ? "unidad" : txtUnidad.Text.Trim(),
                    PrecioCompra = precio,
                    Proveedor = txtProveedor.Text.Trim()
                };

                ProductoDAO.Guardar(nuevo);
                CargarProductos();
                LimpiarCampos();

                MessageBox.Show($"Producto '{nuevo.Nombre}' guardado.", "Éxito",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LimpiarCampos()
        {
            txtNombre.Clear();
            txtCategoria.Clear();
            txtStockActual.Clear();
            txtStockMinimo.Clear();
            txtUnidad.Clear();
            txtPrecioCompra.Clear();
            txtProveedor.Clear();
            txtNombre.Focus();
        }
    }
}