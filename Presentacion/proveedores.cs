using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using San_jose.Negocio;

namespace San_jose.Presentacion
{
    public partial class proveedores : Form
    {
        private DataTable dtProveedores; // Variable para almacenar los datos de los proveedores
        private Nproveedor negocioProveedor = new Nproveedor();
        private bool modoEdicion = false;
        private int idProveedorEditar = 0;

        public proveedores()
        {
            InitializeComponent();
            CargarEstados();
        }

        private void proveedores_Load(object sender, EventArgs e)
        {
            CargarProveedores();
        }

        private void CargarProveedores()
        {
            // Cargar los datos de los proveedores desde la base de datos al DataTable
            dtProveedores = new DataTable();
            this.vistaProveedoresTableAdapter.Fill(this.minisupDataSet1.VistaProveedores);
            dtProveedores = minisupDataSet1.VistaProveedores;

            // Vincular el DataTable al DataGridView
            Gridproveedor.DataSource = dtProveedores;
        }

        private void LimpiarCampos()
        {
            // Limpiar los campos del formulario
            TextBoxNombre.Clear();
            TextBoxnit.Clear();
            TextBoxCorreo.Clear();
            TextBoxTelefono.Clear();
            TextBoxDireccion.Clear();
            comboEstado.SelectedIndex = -1;
        }

        private bool ValidarCampos()
        {
            // Validar que todos los campos estén llenos
            if (string.IsNullOrWhiteSpace(TextBoxNombre.Text) ||
                string.IsNullOrWhiteSpace(TextBoxnit.Text) ||
                string.IsNullOrWhiteSpace(TextBoxCorreo.Text) ||
                string.IsNullOrWhiteSpace(TextBoxTelefono.Text) ||
                string.IsNullOrWhiteSpace(TextBoxDireccion.Text) ||
                comboEstado.SelectedIndex == -1)
            {
                MessageBox.Show("Todos los campos son obligatorios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos())
                return;

            string nombre = TextBoxNombre.Text;
            string nit = TextBoxnit.Text;
            string correo = TextBoxCorreo.Text;
            string telefono = TextBoxTelefono.Text;
            string direccion = TextBoxDireccion.Text;
            bool estado = comboEstado.SelectedIndex == 0 ? true : false;

            if (modoEdicion)
            {
                // Actualizar proveedor
                if (negocioProveedor.ActualizarProveedor(idProveedorEditar, nombre, nit, correo, telefono, direccion, estado))
                {
                    MessageBox.Show("Proveedor actualizado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarCampos();
                    modoEdicion = false;
                    btnAgregar.Text = "Agregar";
                    idProveedorEditar = 0;
                }
                else
                {
                    MessageBox.Show("Error al actualizar proveedor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                // Agregar nuevo proveedor
                if (negocioProveedor.AgregarProveedor(nombre, nit, correo, telefono, direccion, estado))
                {
                    MessageBox.Show("Proveedor agregado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarCampos();
                }
                else
                {
                    MessageBox.Show("Error al agregar proveedor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            // Recargar los proveedores en el DataGridView
            CargarProveedores();
        }

        private void TextBoxBuscar_TextChanged(object sender, EventArgs e)
        {
            string textoBuscar = TextBoxBuscar.Text.Trim();
            if (string.IsNullOrEmpty(textoBuscar))
            {
                // Si el campo de búsqueda está vacío, cargar todos los proveedores
                Gridproveedor.DataSource = dtProveedores;
            }
            else
            {
                // Filtrar los proveedores según el texto de búsqueda
                var proveedoresFiltrados = dtProveedores.AsEnumerable()
                    .Where(row => row.Field<string>("nombre_proveedor").ToLower().Contains(textoBuscar.ToLower()) ||
                                  row.Field<string>("nit_proveedor").Contains(textoBuscar))
                    .CopyToDataTable();
                Gridproveedor.DataSource = proveedoresFiltrados;
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

        private void Gridproveedor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verificar si se hizo clic en la columna de "Editar"
            if (e.ColumnIndex == Gridproveedor.Columns["Editar"].Index && e.RowIndex >= 0)
            {
                modoEdicion = true;
                idProveedorEditar = Convert.ToInt32(Gridproveedor.Rows[e.RowIndex].Cells["idproveedorDataGridViewTextBoxColumn"].Value);

                // Obtener los datos del proveedor seleccionado y cargarlos en los campos del formulario
                TextBoxNombre.Text = Gridproveedor.Rows[e.RowIndex].Cells["nombreproveedorDataGridViewTextBoxColumn"].Value.ToString();
                TextBoxnit.Text = Gridproveedor.Rows[e.RowIndex].Cells["nitproveedorDataGridViewTextBoxColumn"].Value.ToString();
                TextBoxCorreo.Text = Gridproveedor.Rows[e.RowIndex].Cells["correoproveedorDataGridViewTextBoxColumn"].Value.ToString();
                TextBoxTelefono.Text = Gridproveedor.Rows[e.RowIndex].Cells["telefonoproveedorDataGridViewTextBoxColumn"].Value.ToString();
                TextBoxDireccion.Text = Gridproveedor.Rows[e.RowIndex].Cells["direccionDataGridViewTextBoxColumn"].Value.ToString();
                if (Gridproveedor.Rows[e.RowIndex].Cells["estadoDataGridViewTextBoxColumn"].Value.ToString() == "Activo")
                {
                    comboEstado.SelectedIndex = 0; // Activo
                }
                else
                {
                    comboEstado.SelectedIndex = 1; // Inactivo
                }

                btnAgregar.Text = "Editar";
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            modoEdicion = false;
            btnAgregar.Text = "Agregar";
            idProveedorEditar = 0;
        }
    }
}
