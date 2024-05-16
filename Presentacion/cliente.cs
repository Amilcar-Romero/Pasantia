using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using San_jose.Negocio;

namespace San_jose.Presentacion
{
    public partial class cliente : Form
    {
        private DataTable dtClientes; // Variable para almacenar los datos de los clientes
        private Ncliente negocioCliente = new Ncliente();
        private bool modoEdicion = false;
        private int idClienteEditar = 0;

        public cliente()
        {
            InitializeComponent();
            CargarEstados();
        }

        private void cliente_Load(object sender, EventArgs e)
        {
            CargarClientes();
        }

        private void CargarClientes()
        {
            // Cargar los datos de los clientes desde la base de datos al DataTable
            dtClientes = new DataTable();
            this.vistaClientesTableAdapter.Fill(this.minisupDataSet.VistaClientes);
            dtClientes = minisupDataSet.VistaClientes;

            // Vincular el DataTable al DataGridView
            GridCliente.DataSource = dtClientes;
        }

        private void LimpiarCampos()
        {
            // Limpiar los campos del formulario
            TextBoxNombre.Clear();
            TextBoxApellido.Clear();
            TextBoxCI.Clear();
            TextBoxTelefono.Clear();
            TextBoxDireccion.Clear();
            comboEstado.SelectedIndex = -1;
        }

        private bool ValidarCampos()
        {
            // Validar que todos los campos estén llenos
            if (string.IsNullOrWhiteSpace(TextBoxNombre.Text) ||
                string.IsNullOrWhiteSpace(TextBoxApellido.Text) ||
                string.IsNullOrWhiteSpace(TextBoxCI.Text) ||
                string.IsNullOrWhiteSpace(TextBoxTelefono.Text) ||
                string.IsNullOrWhiteSpace(TextBoxDireccion.Text) ||
                comboEstado.SelectedIndex == -1)
            {
                MessageBox.Show("Todos los campos son obligatorios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void btnagregarCliente_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos())
                return;

            string nombre = TextBoxNombre.Text;
            string apellido = TextBoxApellido.Text;
            string ci = TextBoxCI.Text;
            string telefono = TextBoxTelefono.Text;
            string direccion = TextBoxDireccion.Text;
            bool estado = comboEstado.SelectedIndex == 0 ? true : false;

            if (modoEdicion)
            {
                // Actualizar cliente
                if (negocioCliente.ActualizarCliente(idClienteEditar, nombre, apellido, ci, telefono, direccion, estado))
                {
                    MessageBox.Show("Cliente actualizado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarCampos();
                    modoEdicion = false;
                    btnagregarCliente.Text = "Agregar";
                    idClienteEditar = 0;
                }
                else
                {
                    MessageBox.Show("Error al actualizar cliente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                // Agregar nuevo cliente
                if (negocioCliente.AgregarCliente(nombre, apellido, ci, telefono, direccion, estado))
                {
                    MessageBox.Show("Cliente agregado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarCampos();
                }
                else
                {
                    MessageBox.Show("Error al agregar cliente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            // Recargar los clientes en el DataGridView
            CargarClientes();
        }

        private void btnCancelarCliente_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            modoEdicion = false;
            btnagregarCliente.Text = "Agregar";
            idClienteEditar = 0;
        }

        private void TextBoxBuscar_TextChanged(object sender, EventArgs e)
        {
            string textoBuscar = TextBoxBuscar.Text.Trim();
            if (string.IsNullOrEmpty(textoBuscar))
            {
                // Si el campo de búsqueda está vacío, cargar todos los clientes
                GridCliente.DataSource = dtClientes;
            }
            else
            {
                // Filtrar los clientes según el texto de búsqueda
                var clientesFiltrados = dtClientes.AsEnumerable()
                    .Where(row => row.Field<string>("nombre_cliente").ToLower().Contains(textoBuscar.ToLower()) ||
                                  row.Field<string>("apellido_cliente").ToLower().Contains(textoBuscar.ToLower()) ||
                                  row.Field<string>("carnet_cliente").Contains(textoBuscar))
                    .CopyToDataTable();
                GridCliente.DataSource = clientesFiltrados;
            }
        }

        private void GridCliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verificar si se hizo clic en la columna de "Editar"
            if (e.ColumnIndex == GridCliente.Columns["Editar"].Index && e.RowIndex >= 0)
            {
                modoEdicion = true;
                idClienteEditar = Convert.ToInt32(GridCliente.Rows[e.RowIndex].Cells["id_cliente"].Value);

                // Obtener los datos del cliente seleccionado y cargarlos en los campos del formulario
                TextBoxNombre.Text = GridCliente.Rows[e.RowIndex].Cells["nombre_cliente"].Value.ToString();
                TextBoxApellido.Text = GridCliente.Rows[e.RowIndex].Cells["apellido_cliente"].Value.ToString();
                TextBoxCI.Text = GridCliente.Rows[e.RowIndex].Cells["carnet_cliente"].Value.ToString();
                TextBoxTelefono.Text = GridCliente.Rows[e.RowIndex].Cells["telefono_cliente"].Value.ToString();
                TextBoxDireccion.Text = GridCliente.Rows[e.RowIndex].Cells["correo_cliente"].Value.ToString();
                comboEstado.SelectedIndex = Convert.ToBoolean(GridCliente.Rows[e.RowIndex].Cells["estado"].Value) ? 0 : 1;

                btnagregarCliente.Text = "Editar";
            }
        }

        private void CargarEstados()
        {
            // Limpiar los items previos del ComboBox
            comboEstado.Items.Clear();

            // Agregar las opciones "Activo" e "Inactivo" al ComboBox
            comboEstado.Items.Add("Activo");
            comboEstado.Items.Add("Inactivo");

            // Seleccionar por defecto la opción "Activo"
            comboEstado.SelectedIndex = 0;
        }

        private void GridCliente_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            // Verificar si se hizo clic en la columna de "Editar"
            if (e.ColumnIndex == GridCliente.Columns["Editar"].Index && e.RowIndex >= 0)
            {
                modoEdicion = true;
                idClienteEditar = Convert.ToInt32(GridCliente.Rows[e.RowIndex].Cells["id_cliente"].Value);

                // Obtener los datos del cliente seleccionado y cargarlos en los campos del formulario
                TextBoxNombre.Text = GridCliente.Rows[e.RowIndex].Cells["nombre_cliente"].Value.ToString();
                TextBoxApellido.Text = GridCliente.Rows[e.RowIndex].Cells["apellido_cliente"].Value.ToString();
                TextBoxCI.Text = GridCliente.Rows[e.RowIndex].Cells["carnet_cliente"].Value.ToString();
                TextBoxTelefono.Text = GridCliente.Rows[e.RowIndex].Cells["telefono_cliente"].Value.ToString();
                TextBoxDireccion.Text = GridCliente.Rows[e.RowIndex].Cells["correo_cliente"].Value.ToString();
                if (GridCliente.Rows[e.RowIndex].Cells["estado"].Value.ToString() == "Activo")
                {
                    comboEstado.SelectedIndex = 0; // Activo
                }
                else
                {
                    comboEstado.SelectedIndex = 1; // Inactivo
                }

                btnagregarCliente.Text = "Editar";
            }
        }

        private void guna2HtmlLabel5_Click(object sender, EventArgs e)
        {

        }

        private void TextBoxDireccion_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel4_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel3_Click(object sender, EventArgs e)
        {

        }

        private void TextBoxTelefono_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel2_Click(object sender, EventArgs e)
        {

        }

        private void TextBoxCI_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBoxApellido_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBoxNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void comboEstado_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lbproveedor_Click(object sender, EventArgs e)
        {

        }

        private void lbproducto_Click(object sender, EventArgs e)
        {

        }
    }
}
