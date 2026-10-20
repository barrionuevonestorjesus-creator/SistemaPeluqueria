using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SistemaPeluqueria
{
    public partial class FormTurnos : Form
    {
        public FormTurnos()
        {
            InitializeComponent();
            this.Text = "Turnos";
            ConfigurarTabla();
            CargarCombos();
            CargarTurnos();
        }

        private void ConfigurarTabla()
        {
            dgvTurnos.AutoGenerateColumns = false;
            dgvTurnos.Columns.Clear();

            dgvTurnos.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Fecha y hora", DataPropertyName = "FechaHora", Width = 130 });
            dgvTurnos.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Cliente", DataPropertyName = "ClienteNombre", Width = 150 });
            dgvTurnos.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Servicio", DataPropertyName = "ServicioNombre", Width = 130 });
            dgvTurnos.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Empleado", DataPropertyName = "EmpleadoNombre", Width = 130 });
            dgvTurnos.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Estado", DataPropertyName = "Estado", Width = 90 });
            dgvTurnos.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Notas", DataPropertyName = "Notas", Width = 150 });
        }

        private void CargarCombos()
        {
            cmbCliente.DisplayMember = "NombreCompleto";
            cmbCliente.ValueMember = "Id";
            cmbCliente.DataSource = ClienteDAO.ObtenerTodos();

            cmbEmpleado.DisplayMember = "NombreCompleto";
            cmbEmpleado.ValueMember = "Id";
            cmbEmpleado.DataSource = EmpleadoDAO.ObtenerTodos();

            cmbServicio.DisplayMember = "Nombre";
            cmbServicio.ValueMember = "Id";
            cmbServicio.DataSource = ServicioDAO.ObtenerTodos();
        }

        private void CargarTurnos()
        {
            dgvTurnos.DataSource = TurnoDAO.ObtenerTodos();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (cmbCliente.SelectedValue == null || cmbServicio.SelectedValue == null)
            {
                MessageBox.Show("Cliente y servicio son obligatorios.", "Atención",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                DateTime fechaHora = dtpFecha.Value.Date + dtpHora.Value.TimeOfDay;

                Turno nuevo = new Turno
                {
                    ClienteId = (int)cmbCliente.SelectedValue,
                    EmpleadoId = cmbEmpleado.SelectedValue != null ? (int)cmbEmpleado.SelectedValue : 0,
                    ServicioId = (int)cmbServicio.SelectedValue,
                    FechaHora = fechaHora,
                    Estado = "Pendiente",
                    Notas = txtNotas.Text.Trim()
                };

                TurnoDAO.Guardar(nuevo);
                CargarTurnos();
                txtNotas.Clear();

                MessageBox.Show("Turno guardado correctamente.", "Éxito",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
