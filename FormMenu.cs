using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SistemaPeluqueria
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
            this.Text = "Sistema de Gestión - Peluquería";
            this.Size = new Size(500, 400);
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            FormClientes formClientes = new FormClientes();
            formClientes.Show();
        }

        private void btnServicios_Click(object sender, EventArgs e)
        {
            FormServicios formServicios = new FormServicios();
            formServicios.Show();
        }

        private void btnTurnos_Click(object sender, EventArgs e)
        {
            FormTurnos formTurnos = new FormTurnos();
            formTurnos.Show();
        }

        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            FormEmpleados formEmpleados = new FormEmpleados();
            formEmpleados.Show();
        }

        private void btnCaja_Click(object sender, EventArgs e)
        {
            FormCaja formCaja = new FormCaja();
            formCaja.Show();
        }

        private void btnStock_Click(object sender, EventArgs e)
        {
            FormStock formStock = new FormStock();
            formStock.Show();
        }

    }
}