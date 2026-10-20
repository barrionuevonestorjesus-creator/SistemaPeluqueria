namespace SistemaPeluqueria
{
    public partial class FormClientes : Form
    {
        public FormClientes()
        {
            InitializeComponent();
            VerificarConexion();
            ConfigurarTabla();
            CargarClientes();
        }

        private void VerificarConexion()
        {
            if (!Conexion.ProbarConexion())
            {
                MessageBox.Show("No se pudo conectar a la base de datos.\n" +
                                "Verificá que MySQL esté corriendo y la contraseña sea correcta.",
                                "Error de conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ConfigurarTabla()
        {
            dgvClientes.AutoGenerateColumns = false;
            dgvClientes.Columns.Clear();

            dgvClientes.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Nombre completo", DataPropertyName = "NombreCompleto", Width = 200 });
            dgvClientes.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "DNI", DataPropertyName = "DNI", Width = 90 });
            dgvClientes.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Teléfono", DataPropertyName = "Telefono", Width = 120 });
            dgvClientes.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Email", DataPropertyName = "Email", Width = 180 });
        }

        private void CargarClientes()
        {
            dgvClientes.DataSource = ClienteDAO.ObtenerTodos();
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
                Cliente nuevo = new Cliente
                {
                    Nombre = txtNombre.Text.Trim(),
                    Apellido = txtApellido.Text.Trim(),
                    DNI = txtDNI.Text.Trim(),
                    Telefono = txtTelefono.Text.Trim(),
                    Email = txtEmail.Text.Trim(),
                    Observaciones = txtObservaciones.Text.Trim()
                };

                ClienteDAO.Guardar(nuevo);
                CargarClientes(); // Refresca la tabla
                LimpiarCampos();

                MessageBox.Show($"Cliente {nuevo.NombreCompleto} guardado.", "Éxito",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void LimpiarCampos()
        {
            txtNombre.Clear();
            txtApellido.Clear();
            txtDNI.Clear();
            txtTelefono.Clear();
            txtEmail.Clear();
            txtObservaciones.Clear();
            txtNombre.Focus();
        }

        private void btnGuardarCliente_Click(object sender, EventArgs e)
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
                    Cliente nuevo = new Cliente
                    {
                        Nombre = txtNombre.Text.Trim(),
                        Apellido = txtApellido.Text.Trim(),
                        DNI = txtDNI.Text.Trim(),
                        Telefono = txtTelefono.Text.Trim(),
                        Email = txtEmail.Text.Trim(),
                        Observaciones = txtObservaciones.Text.Trim()
                    };

                    ClienteDAO.Guardar(nuevo);
                    CargarClientes();
                    LimpiarCampos();

                    MessageBox.Show($"Cliente {nuevo.NombreCompleto} guardado.", "Éxito",
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