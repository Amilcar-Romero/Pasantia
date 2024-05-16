using System;
using System.Data;
using System.Windows.Forms;
using San_jose.Negocio;

namespace San_jose.Presentacion
{
    public partial class usuario : Form
    {
        private DataTable dtUsuarios; // Variable para almacenar los datos de los usuarios
        private Nusuario negocioUsuario = new Nusuario();
        private bool modoEdicion = false;
        private int idUsuarioEditar = 0;

        public usuario()
        {
            InitializeComponent();
            CargarEstados();
            CargarRoles();
        }

        private void usuario_Load(object sender, EventArgs e)
        {
            CargarUsuarios();
        }

        private void CargarUsuarios()
        {
            // Cargar los datos de los usuarios desde la base de datos al DataTable
            dtUsuarios = new DataTable();
            this.vistaUsuariosTableAdapter.Fill(this.minisupDataSet2.VistaUsuarios);
            dtUsuarios = minisupDataSet2.VistaUsuarios;

            // Vincular el DataTable al DataGridView
            GridUsuario.DataSource = dtUsuarios;
        }

        private void LimpiarCampos()
        {
            // Limpiar los campos del formulario
            TextBoxNombre.Clear();
            TextBoxApellido.Clear();
            TextBoxCI.Clear();
            TextBoxCorreo.Clear();
            TextBoxContraseña.Clear();
            ComboRol.SelectedIndex = -1;
            ComboEstado.SelectedIndex = -1;
        }

        private bool ValidarCampos()
        {
            // Validar que todos los campos estén llenos
            if (string.IsNullOrWhiteSpace(TextBoxNombre.Text) ||
                string.IsNullOrWhiteSpace(TextBoxApellido.Text) ||
                string.IsNullOrWhiteSpace(TextBoxCI.Text) ||
                string.IsNullOrWhiteSpace(TextBoxCorreo.Text) ||
                string.IsNullOrWhiteSpace(TextBoxContraseña.Text) ||
                ComboRol.SelectedIndex == -1 ||
                ComboEstado.SelectedIndex == -1)
            {
                MessageBox.Show("Todos los campos son obligatorios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos())
                return;

            string nombre = TextBoxNombre.Text;
            string apellido = TextBoxApellido.Text;
            string ci = TextBoxCI.Text;
            string correo = TextBoxCorreo.Text;
            string contraseña = TextBoxContraseña.Text;
            int idRol = ComboRol.SelectedIndex + 1; // Sumar 1 para obtener el ID correcto del rol seleccionado
            bool estado = ComboEstado.SelectedIndex == 0 ? true : false;

            if (modoEdicion)
            {
                // Actualizar usuario
                if (negocioUsuario.ActualizarUsuario(idUsuarioEditar, nombre, apellido, ci, correo, contraseña, idRol, estado))
                {
                    MessageBox.Show("Usuario actualizado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarCampos();
                    modoEdicion = false;
                    btnagregar.Text = "Agregar";
                    idUsuarioEditar = 0;
                }
                else
                {
                    MessageBox.Show("Error al actualizar usuario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                // Agregar nuevo usuario
                if (negocioUsuario.AgregarUsuario(nombre, apellido, ci, correo, contraseña, idRol, estado))
                {
                    MessageBox.Show("Usuario agregado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarCampos();
                }
                else
                {
                    MessageBox.Show("Error al agregar usuario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            // Recargar los usuarios en el DataGridView
            CargarUsuarios();
        }

        private void TextBoxBuscar_TextChanged(object sender, EventArgs e)
        {
            string textoBuscar = TextBoxBuscar.Text.Trim();
            if (string.IsNullOrEmpty(textoBuscar))
            {
                // Si el campo de búsqueda está vacío, cargar todos los usuarios
                GridUsuario.DataSource = dtUsuarios;
            }
            else
            {
                // Filtrar los usuarios según el texto de búsqueda
                var usuariosFiltrados = dtUsuarios.AsEnumerable()
                    .Where(row => row.Field<string>("nombre_usuario").ToLower().Contains(textoBuscar.ToLower()) ||
                                  row.Field<string>("carnet_usuario").Contains(textoBuscar) ||
                                  row.Field<string>("nombre_rol_usuario").ToLower().Contains(textoBuscar.ToLower()))
                    .CopyToDataTable();
                GridUsuario.DataSource = usuariosFiltrados;
            }
        }

        private void CargarEstados()
        {
            // Agregar las opciones "Activo" e "Inactivo" al ComboBox de estado
            ComboEstado.Items.Add("Activo");
            ComboEstado.Items.Add("Inactivo");
        }

        private void CargarRoles()
        {
            // Obtener todos los roles disponibles
            var roles = negocioUsuario.ObtenerTodosRoles();

            // Agregar los roles al ComboBox de roles
            if (roles != null)
            {
                foreach (var rol in roles)
                {
                    ComboRol.Items.Add(rol);
                }
            }
        }

        private void GridUsuario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verificar si se hizo clic en la columna de "Editar"
            if (e.ColumnIndex == GridUsuario.Columns["Editar"].Index && e.RowIndex >= 0)
            {
                modoEdicion = true;
                idUsuarioEditar = Convert.ToInt32(GridUsuario.Rows[e.RowIndex].Cells["idusuarioDataGridViewTextBoxColumn"].Value);

                // Obtener los datos del usuario seleccionado y cargarlos en los campos del formulario
                TextBoxNombre.Text = GridUsuario.Rows[e.RowIndex].Cells["nombreusuarioDataGridViewTextBoxColumn"].Value.ToString();
                TextBoxApellido.Text = GridUsuario.Rows[e.RowIndex].Cells["apellidousuarioDataGridViewTextBoxColumn"].Value.ToString();
                TextBoxCI.Text = GridUsuario.Rows[e.RowIndex].Cells["carnetusuarioDataGridViewTextBoxColumn"].Value.ToString();
                TextBoxCorreo.Text = GridUsuario.Rows[e.RowIndex].Cells["correousuarioDataGridViewTextBoxColumn"].Value.ToString();
                ComboRol.SelectedItem = GridUsuario.Rows[e.RowIndex].Cells["nombre_rol_usuario"].Value.ToString();
                if (GridUsuario.Rows[e.RowIndex].Cells["estadoDataGridViewTextBoxColumn"].Value.ToString() == "Activo")
                {
                    ComboEstado.SelectedIndex = 0; // Activo
                }
                else
                {
                    ComboEstado.SelectedIndex = 1; // Inactivo
                }

                btnagregar.Text = "Editar";
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            modoEdicion = false;
            btnagregar.Text = "Agregar";
            idUsuarioEditar = 0;
        }

        private void ComboRol_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
