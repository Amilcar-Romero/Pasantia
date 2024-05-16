using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace San_jose.Presentacion
{
    public partial class producto : Form
    {
        public producto()
        {
            InitializeComponent();
        }

        private void producto_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'minisupDataSet4.VistaProductosConPrecios' Puede moverla o quitarla según sea necesario.
            this.vistaProductosConPreciosTableAdapter.Fill(this.minisupDataSet4.VistaProductosConPrecios);

        }

        private void producto_Load_1(object sender, EventArgs e)
        {

        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnNuevaCategoria_Click(object sender, EventArgs e)
        {

        }
    }
}
