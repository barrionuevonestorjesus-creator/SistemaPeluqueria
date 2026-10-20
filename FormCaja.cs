using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SistemaPeluqueria
{
    public partial class FormCaja : Form
    {
        private List<DetalleComprobante> detalleActual = new List<DetalleComprobante>();

        public FormCaja()
        {
            InitializeComponent();
            this.Text = "Caja / Facturación";
            CargarCombos();
            CargarHistorialHoy();

            cmbMedioPago.Items.AddRange(new string[] { "Efectivo", "Tarjeta", "Transferencia", "Billetera virtual" });
            cmbMedioPago.SelectedIndex = 0;
        }

        private void CargarCombos()
        {
            cmbCliente.DisplayMember = "NombreCompleto";
            cmbCliente.ValueMember = "Id";
            cmbCliente.DataSource = ClienteDAO.ObtenerTodos();

            cmbServicio.DisplayMember = "Nombre";
            cmbServicio.ValueMember = "Id";
            cmbServicio.DataSource = ServicioDAO.ObtenerTodos();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (cmbServicio.SelectedItem == null) return;

            var servicio = (Servicio)cmbServicio.SelectedItem;

            detalleActual.Add(new DetalleComprobante
            {
                Descripcion = servicio.Nombre,
                Precio = servicio.Precio
            });

            ActualizarTablaDetalle();
        }

        private void ActualizarTablaDetalle()
        {
            dgvDetalle.DataSource = null;
            dgvDetalle.DataSource = detalleActual;

            decimal total = 0;
            foreach (var d in detalleActual)
                total += d.Precio;

            lblTotal.Text = $"Total: ${total:N2}";
        }

        private void btnCobrar_Click(object sender, EventArgs e)
        {
            if (cmbCliente.SelectedValue == null)
            {
                MessageBox.Show("Seleccioná un cliente.", "Atención",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (detalleActual.Count == 0)
            {
                MessageBox.Show("Agregá al menos un servicio.", "Atención",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            decimal total = 0;
            foreach (var d in detalleActual)
                total += d.Precio;

            try
            {
                Comprobante comprobante = new Comprobante
                {
                    ClienteId = (int)cmbCliente.SelectedValue,
                    Total = total,
                    MedioPago = cmbMedioPago.Text
                };

                CajaDAO.CrearComprobante(comprobante, detalleActual);

                MessageBox.Show($"Cobro registrado por ${total:N2}", "Éxito",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                detalleActual.Clear();
                ActualizarTablaDetalle();
                CargarHistorialHoy();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cobrar: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarHistorialHoy()
        {
            dgvHistorial.DataSource = CajaDAO.ObtenerHoy();

            decimal totalHoy = CajaDAO.TotalHoy();
            this.Text = $"Caja / Facturación — Total hoy: ${totalHoy:N2}";
        }
    }
}