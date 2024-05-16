using San_jose.Negocio;
using San_jose.Presentacion;
using System;
using System.Windows.Forms;

namespace San_jose
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();


        }

        private void dashboard_Click(object sender, EventArgs e)
        {
            MostrarFormulario(new dashboard());
        }

        private void venta_Click(object sender, EventArgs e)
        {
            MostrarFormulario(new venta());
        }

        private void compra_Click(object sender, EventArgs e)
        {
            MostrarFormulario(new compra());
        }

        private void proveedor_Click(object sender, EventArgs e)
        {
            MostrarFormulario(new proveedores());
        }

        private void MostrarFormulario(Form formulario)
        {
            // Limpiar el contenido actual del panel contenedor
            contenedordeForm.Controls.Clear();

            // Configurar el formulario para que se ajuste al tamaño del panel contenedor
            formulario.TopLevel = false;
            formulario.Dock = DockStyle.Fill;

            // Agregar el formulario al panel contenedor
            contenedordeForm.Controls.Add(formulario);

            // Mostrar el formulario
            formulario.Show();
        }

        private void contenedordeForm_Paint(object sender, PaintEventArgs e)
        {
            // No es necesario implementar nada aquí si el panel solo se utilizará para mostrar formularios.
        }

        private void maximizar_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }

        private void guna2ImageButton3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void cliente_Click(object sender, EventArgs e)
        {
            MostrarFormulario(new cliente());

        }

        private void controlesCerrarMaximizar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2GradientButton4_Click(object sender, EventArgs e)
        {
            MostrarFormulario(new cliente());
        }

        private void btnUsuario_Click(object sender, EventArgs e)
        {
            MostrarFormulario(new usuario());

        }

        private void guna2CustomGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnproducto_Click(object sender, EventArgs e)
        {
            MostrarFormulario(new producto());

        }

        private void lblUserlogin_Click(object sender, EventArgs e)
        {

        }
    }
    }