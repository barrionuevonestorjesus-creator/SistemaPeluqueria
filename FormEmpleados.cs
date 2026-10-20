using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SistemaPeluqueria
{
    public partial class FormEmpleados : Form
    {
        public FormEmpleados()
        {
            InitializeComponent();
            this.Text = "Empleados";
            ConfigurarTabla();
            CargarEmpleados();
        }

        private void ConfigurarTabla()
        {
            dgvEmpleados.AutoGenerateColumns = false;
            dgvEmpleados.Columns.Clear();

            dgvEmpleados.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Nombre completo", DataPropertyName = "NombreCompleto", Width = 180 });
            dgvEmpleados.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "DNI", DataPropertyName = "DNI", Width = 90 });
            dgvEmpleados.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Teléfono", DataPropertyName = "Telefono", Width = 110 });
            dgvEmpleados.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Email", DataPropertyName = "Email", Width = 160 });
            dgvEmpleados.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Especialidad", DataPropertyName = "Especialidad", Width = 120 });
        }

        private void CargarEmpleados()
        {
            dgvEmpleados.DataSource = EmpleadoDAO.ObtenerTodos();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(txtApellido.Text))
            {
                MessageBox.Show("Nombre y apellido son obligatorios.", "Atención",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                Empleado nuevo = new Empleado
                {
                    Nombre = txtNombre.Text.Trim(),
                    Apellido = txtApellido.Text.Trim(),
                    DNI = txtDNI.Text.Trim(),
                    Telefono = txtTelefono.Text.Trim(),
                    Email = txtEmail.Text.Trim(),
                    Especialidad = txtEspecialidad.Text.Trim(),
                    FechaIngreso = DateTime.Today
                };

                EmpleadoDAO.Guardar(nuevo);
                CargarEmpleados();
                LimpiarCampos();

                MessageBox.Show($"Empleado {nuevo.NombreCompleto} guardado.", "Éxito",
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
            txtApellido.Clear();
            txtDNI.Clear();
            txtTelefono.Clear();
            txtEmail.Clear();
            txtEspecialidad.Clear();
            txtNombre.Focus();
        }
    }
}