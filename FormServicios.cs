using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SistemaPeluqueria
{
    public partial class FormServicios : Form
    {
        public FormServicios()
        {
            InitializeComponent();
            this.Text = "Servicios";
            ConfigurarTabla();
            CargarServicios();
        }

        private void ConfigurarTabla()
        {
            dgvServicios.AutoGenerateColumns = false;
            dgvServicios.Columns.Clear();

            dgvServicios.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Nombre", DataPropertyName = "Nombre", Width = 150 });
            dgvServicios.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Categoría", DataPropertyName = "Categoria", Width = 100 });
            dgvServicios.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Precio", DataPropertyName = "Precio", Width = 80 });
            dgvServicios.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Duración (min)", DataPropertyName = "DuracionMinutos", Width = 100 });
            dgvServicios.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Descripción", DataPropertyName = "Descripcion", Width = 200 });
        }

        private void CargarServicios()
        {
            dgvServicios.DataSource = ServicioDAO.ObtenerTodos();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(txtPrecio.Text))
            {
                MessageBox.Show("Nombre y precio son obligatorios.", "Atención",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(txtPrecio.Text, out decimal precio))
            {
                MessageBox.Show("El precio debe ser un número válido.", "Atención",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int duracion = 0;
            if (!string.IsNullOrWhiteSpace(txtDuracion.Text))
                int.TryParse(txtDuracion.Text, out duracion);

            try
            {
                Servicio nuevo = new Servicio
                {
                    Nombre = txtNombre.Text.Trim(),
                    Descripcion = txtDescripcion.Text.Trim(),
                    Precio = precio,
                    DuracionMinutos = duracion,
                    Categoria = txtCategoria.Text.Trim()
                };

                ServicioDAO.Guardar(nuevo);
                CargarServicios();
                LimpiarCampos();

                MessageBox.Show($"Servicio '{nuevo.Nombre}' guardado.", "Éxito",
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
            txtDescripcion.Clear();
            txtPrecio.Clear();
            txtDuracion.Clear();
            txtCategoria.Clear();
            txtNombre.Focus();
        }
    }
}
