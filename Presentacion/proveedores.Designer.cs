namespace San_jose.Presentacion
{
    partial class proveedores
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(proveedores));
            this.vistaClientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.minisupDataSet = new San_jose.minisupDataSet();
            this.vistaClientesTableAdapter = new San_jose.minisupDataSetTableAdapters.VistaClientesTableAdapter();
            this.TextBoxBuscar = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel5 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.TextBoxDireccion = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.TextBoxTelefono = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.TextBoxCorreo = new Guna.UI2.WinForms.Guna2TextBox();
            this.TextBoxnit = new Guna.UI2.WinForms.Guna2TextBox();
            this.TextBoxNombre = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.Gridproveedor = new Guna.UI2.WinForms.Guna2DataGridView();
            this.idproveedorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreproveedorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nitproveedorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.correoproveedorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonoproveedorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Editar = new System.Windows.Forms.DataGridViewImageColumn();
            this.vistaProveedoresBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.minisupDataSet1 = new San_jose.minisupDataSet1();
            this.btnCancelar = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnAgregar = new Guna.UI2.WinForms.Guna2GradientButton();
            this.comboEstado = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lbproveedor = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lbproducto = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.vistaProveedoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vistaProveedoresTableAdapter = new San_jose.minisupDataSet1TableAdapters.VistaProveedoresTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.vistaClientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minisupDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Gridproveedor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vistaProveedoresBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minisupDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vistaProveedoresBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // vistaClientesBindingSource
            // 
            this.vistaClientesBindingSource.DataMember = "VistaClientes";
            this.vistaClientesBindingSource.DataSource = this.minisupDataSet;
            // 
            // minisupDataSet
            // 
            this.minisupDataSet.DataSetName = "minisupDataSet";
            this.minisupDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vistaClientesTableAdapter
            // 
            this.vistaClientesTableAdapter.ClearBeforeFill = true;
            // 
            // TextBoxBuscar
            // 
            this.TextBoxBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxBuscar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.TextBoxBuscar.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxBuscar.DefaultText = "";
            this.TextBoxBuscar.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBoxBuscar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBoxBuscar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxBuscar.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxBuscar.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBoxBuscar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBoxBuscar.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBoxBuscar.Location = new System.Drawing.Point(242, 239);
            this.TextBoxBuscar.Name = "TextBoxBuscar";
            this.TextBoxBuscar.PasswordChar = '\0';
            this.TextBoxBuscar.PlaceholderText = "";
            this.TextBoxBuscar.SelectedText = "";
            this.TextBoxBuscar.Size = new System.Drawing.Size(364, 33);
            this.TextBoxBuscar.TabIndex = 44;
            this.TextBoxBuscar.TextChanged += new System.EventHandler(this.TextBoxBuscar_TextChanged);
            // 
            // guna2HtmlLabel5
            // 
            this.guna2HtmlLabel5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2HtmlLabel5.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel5.ForeColor = System.Drawing.Color.Black;
            this.guna2HtmlLabel5.Location = new System.Drawing.Point(106, 246);
            this.guna2HtmlLabel5.Name = "guna2HtmlLabel5";
            this.guna2HtmlLabel5.Size = new System.Drawing.Size(132, 18);
            this.guna2HtmlLabel5.TabIndex = 43;
            this.guna2HtmlLabel5.Text = "Buscar Proveedor:";
            // 
            // TextBoxDireccion
            // 
            this.TextBoxDireccion.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TextBoxDireccion.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.TextBoxDireccion.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxDireccion.DefaultText = "";
            this.TextBoxDireccion.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBoxDireccion.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBoxDireccion.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxDireccion.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxDireccion.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBoxDireccion.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBoxDireccion.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBoxDireccion.Location = new System.Drawing.Point(106, 155);
            this.TextBoxDireccion.Name = "TextBoxDireccion";
            this.TextBoxDireccion.PasswordChar = '\0';
            this.TextBoxDireccion.PlaceholderText = "";
            this.TextBoxDireccion.SelectedText = "";
            this.TextBoxDireccion.Size = new System.Drawing.Size(348, 37);
            this.TextBoxDireccion.TabIndex = 42;
            // 
            // guna2HtmlLabel4
            // 
            this.guna2HtmlLabel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel4.ForeColor = System.Drawing.Color.Black;
            this.guna2HtmlLabel4.Location = new System.Drawing.Point(106, 132);
            this.guna2HtmlLabel4.Name = "guna2HtmlLabel4";
            this.guna2HtmlLabel4.Size = new System.Drawing.Size(73, 18);
            this.guna2HtmlLabel4.TabIndex = 41;
            this.guna2HtmlLabel4.Text = "Direccion:";
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel3.ForeColor = System.Drawing.Color.Black;
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(472, 132);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(56, 18);
            this.guna2HtmlLabel3.TabIndex = 40;
            this.guna2HtmlLabel3.Text = "Estado:";
            // 
            // TextBoxTelefono
            // 
            this.TextBoxTelefono.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TextBoxTelefono.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.TextBoxTelefono.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxTelefono.DefaultText = "";
            this.TextBoxTelefono.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBoxTelefono.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBoxTelefono.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxTelefono.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxTelefono.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBoxTelefono.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBoxTelefono.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBoxTelefono.Location = new System.Drawing.Point(472, 84);
            this.TextBoxTelefono.Name = "TextBoxTelefono";
            this.TextBoxTelefono.PasswordChar = '\0';
            this.TextBoxTelefono.PlaceholderText = "";
            this.TextBoxTelefono.SelectedText = "";
            this.TextBoxTelefono.Size = new System.Drawing.Size(105, 24);
            this.TextBoxTelefono.TabIndex = 39;
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.ForeColor = System.Drawing.Color.Black;
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(472, 51);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(69, 18);
            this.guna2HtmlLabel2.TabIndex = 38;
            this.guna2HtmlLabel2.Text = "Telefono:";
            // 
            // TextBoxCorreo
            // 
            this.TextBoxCorreo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TextBoxCorreo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.TextBoxCorreo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxCorreo.DefaultText = "";
            this.TextBoxCorreo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBoxCorreo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBoxCorreo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxCorreo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxCorreo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBoxCorreo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBoxCorreo.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBoxCorreo.Location = new System.Drawing.Point(350, 84);
            this.TextBoxCorreo.Name = "TextBoxCorreo";
            this.TextBoxCorreo.PasswordChar = '\0';
            this.TextBoxCorreo.PlaceholderText = "";
            this.TextBoxCorreo.SelectedText = "";
            this.TextBoxCorreo.Size = new System.Drawing.Size(105, 24);
            this.TextBoxCorreo.TabIndex = 37;
            // 
            // TextBoxnit
            // 
            this.TextBoxnit.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TextBoxnit.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.TextBoxnit.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxnit.DefaultText = "";
            this.TextBoxnit.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBoxnit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBoxnit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxnit.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxnit.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBoxnit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBoxnit.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBoxnit.Location = new System.Drawing.Point(227, 84);
            this.TextBoxnit.Name = "TextBoxnit";
            this.TextBoxnit.PasswordChar = '\0';
            this.TextBoxnit.PlaceholderText = "";
            this.TextBoxnit.SelectedText = "";
            this.TextBoxnit.Size = new System.Drawing.Size(105, 24);
            this.TextBoxnit.TabIndex = 36;
            // 
            // TextBoxNombre
            // 
            this.TextBoxNombre.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TextBoxNombre.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.TextBoxNombre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxNombre.DefaultText = "";
            this.TextBoxNombre.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBoxNombre.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBoxNombre.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxNombre.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxNombre.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBoxNombre.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBoxNombre.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBoxNombre.Location = new System.Drawing.Point(106, 84);
            this.TextBoxNombre.Name = "TextBoxNombre";
            this.TextBoxNombre.PasswordChar = '\0';
            this.TextBoxNombre.PlaceholderText = "";
            this.TextBoxNombre.SelectedText = "";
            this.TextBoxNombre.Size = new System.Drawing.Size(105, 24);
            this.TextBoxNombre.TabIndex = 35;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.Black;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(382, 52);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(50, 18);
            this.guna2HtmlLabel1.TabIndex = 34;
            this.guna2HtmlLabel1.Text = "Correo";
            // 
            // Gridproveedor
            // 
            this.Gridproveedor.AllowUserToAddRows = false;
            this.Gridproveedor.AllowUserToDeleteRows = false;
            this.Gridproveedor.AllowUserToResizeColumns = false;
            this.Gridproveedor.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.Gridproveedor.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.Gridproveedor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Gridproveedor.AutoGenerateColumns = false;
            this.Gridproveedor.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.Gridproveedor.BackgroundColor = System.Drawing.Color.Silver;
            this.Gridproveedor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Gridproveedor.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.Gridproveedor.ColumnHeadersHeight = 22;
            this.Gridproveedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.Gridproveedor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idproveedorDataGridViewTextBoxColumn,
            this.nombreproveedorDataGridViewTextBoxColumn,
            this.nitproveedorDataGridViewTextBoxColumn,
            this.correoproveedorDataGridViewTextBoxColumn,
            this.telefonoproveedorDataGridViewTextBoxColumn,
            this.direccionDataGridViewTextBoxColumn,
            this.estadoDataGridViewTextBoxColumn,
            this.Editar});
            this.Gridproveedor.DataSource = this.vistaProveedoresBindingSource1;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Gridproveedor.DefaultCellStyle = dataGridViewCellStyle3;
            this.Gridproveedor.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.Gridproveedor.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.Gridproveedor.ImeMode = System.Windows.Forms.ImeMode.On;
            this.Gridproveedor.Location = new System.Drawing.Point(58, 288);
            this.Gridproveedor.MultiSelect = false;
            this.Gridproveedor.Name = "Gridproveedor";
            this.Gridproveedor.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Gridproveedor.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.Gridproveedor.RowHeadersVisible = false;
            this.Gridproveedor.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.Gridproveedor.Size = new System.Drawing.Size(725, 280);
            this.Gridproveedor.StandardTab = true;
            this.Gridproveedor.TabIndex = 33;
            this.Gridproveedor.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.Gridproveedor.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.Gridproveedor.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.Gridproveedor.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.Gridproveedor.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.Gridproveedor.ThemeStyle.BackColor = System.Drawing.Color.Silver;
            this.Gridproveedor.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.Gridproveedor.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.Gridproveedor.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.Gridproveedor.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gridproveedor.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.Gridproveedor.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.Gridproveedor.ThemeStyle.HeaderStyle.Height = 22;
            this.Gridproveedor.ThemeStyle.ReadOnly = true;
            this.Gridproveedor.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.Gridproveedor.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.Gridproveedor.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gridproveedor.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.Gridproveedor.ThemeStyle.RowsStyle.Height = 22;
            this.Gridproveedor.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.Gridproveedor.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.Gridproveedor.VirtualMode = true;
            this.Gridproveedor.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Gridproveedor_CellContentClick);
            // 
            // idproveedorDataGridViewTextBoxColumn
            // 
            this.idproveedorDataGridViewTextBoxColumn.DataPropertyName = "id_proveedor";
            this.idproveedorDataGridViewTextBoxColumn.HeaderText = "ID";
            this.idproveedorDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idproveedorDataGridViewTextBoxColumn.Name = "idproveedorDataGridViewTextBoxColumn";
            this.idproveedorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombreproveedorDataGridViewTextBoxColumn
            // 
            this.nombreproveedorDataGridViewTextBoxColumn.DataPropertyName = "nombre_proveedor";
            this.nombreproveedorDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreproveedorDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nombreproveedorDataGridViewTextBoxColumn.Name = "nombreproveedorDataGridViewTextBoxColumn";
            this.nombreproveedorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nitproveedorDataGridViewTextBoxColumn
            // 
            this.nitproveedorDataGridViewTextBoxColumn.DataPropertyName = "nit_proveedor";
            this.nitproveedorDataGridViewTextBoxColumn.HeaderText = "Nit";
            this.nitproveedorDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nitproveedorDataGridViewTextBoxColumn.Name = "nitproveedorDataGridViewTextBoxColumn";
            this.nitproveedorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // correoproveedorDataGridViewTextBoxColumn
            // 
            this.correoproveedorDataGridViewTextBoxColumn.DataPropertyName = "correo_proveedor";
            this.correoproveedorDataGridViewTextBoxColumn.HeaderText = "Correo";
            this.correoproveedorDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.correoproveedorDataGridViewTextBoxColumn.Name = "correoproveedorDataGridViewTextBoxColumn";
            this.correoproveedorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // telefonoproveedorDataGridViewTextBoxColumn
            // 
            this.telefonoproveedorDataGridViewTextBoxColumn.DataPropertyName = "telefono_proveedor";
            this.telefonoproveedorDataGridViewTextBoxColumn.HeaderText = "Telefono";
            this.telefonoproveedorDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.telefonoproveedorDataGridViewTextBoxColumn.Name = "telefonoproveedorDataGridViewTextBoxColumn";
            this.telefonoproveedorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // direccionDataGridViewTextBoxColumn
            // 
            this.direccionDataGridViewTextBoxColumn.DataPropertyName = "direccion";
            this.direccionDataGridViewTextBoxColumn.HeaderText = "Direccion";
            this.direccionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.direccionDataGridViewTextBoxColumn.Name = "direccionDataGridViewTextBoxColumn";
            this.direccionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // estadoDataGridViewTextBoxColumn
            // 
            this.estadoDataGridViewTextBoxColumn.DataPropertyName = "estado";
            this.estadoDataGridViewTextBoxColumn.HeaderText = "Estado";
            this.estadoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.estadoDataGridViewTextBoxColumn.Name = "estadoDataGridViewTextBoxColumn";
            this.estadoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Editar
            // 
            this.Editar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Editar.HeaderText = "Editar";
            this.Editar.Image = ((System.Drawing.Image)(resources.GetObject("Editar.Image")));
            this.Editar.MinimumWidth = 8;
            this.Editar.Name = "Editar";
            this.Editar.ReadOnly = true;
            this.Editar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Editar.ToolTipText = "Editar";
            this.Editar.Width = 41;
            // 
            // vistaProveedoresBindingSource1
            // 
            this.vistaProveedoresBindingSource1.DataMember = "VistaProveedores";
            this.vistaProveedoresBindingSource1.DataSource = this.minisupDataSet1;
            // 
            // minisupDataSet1
            // 
            this.minisupDataSet1.DataSetName = "minisupDataSet1";
            this.minisupDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCancelar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCancelar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCancelar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCancelar.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCancelar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCancelar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(614, 145);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(96, 40);
            this.btnCancelar.TabIndex = 32;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAgregar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAgregar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAgregar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAgregar.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAgregar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAgregar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnAgregar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAgregar.ForeColor = System.Drawing.Color.White;
            this.btnAgregar.Location = new System.Drawing.Point(614, 84);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(96, 41);
            this.btnAgregar.TabIndex = 31;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // comboEstado
            // 
            this.comboEstado.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.comboEstado.BackColor = System.Drawing.Color.Transparent;
            this.comboEstado.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.comboEstado.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboEstado.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboEstado.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboEstado.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.comboEstado.ForeColor = System.Drawing.Color.Black;
            this.comboEstado.ItemHeight = 30;
            this.comboEstado.Location = new System.Drawing.Point(472, 155);
            this.comboEstado.Name = "comboEstado";
            this.comboEstado.Size = new System.Drawing.Size(106, 36);
            this.comboEstado.TabIndex = 30;
            // 
            // lbproveedor
            // 
            this.lbproveedor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lbproveedor.BackColor = System.Drawing.Color.Transparent;
            this.lbproveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbproveedor.ForeColor = System.Drawing.Color.Black;
            this.lbproveedor.Location = new System.Drawing.Point(270, 52);
            this.lbproveedor.Name = "lbproveedor";
            this.lbproveedor.Size = new System.Drawing.Size(22, 18);
            this.lbproveedor.TabIndex = 29;
            this.lbproveedor.Text = "Nit";
            // 
            // lbproducto
            // 
            this.lbproducto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lbproducto.BackColor = System.Drawing.Color.Transparent;
            this.lbproducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbproducto.ForeColor = System.Drawing.Color.Black;
            this.lbproducto.Location = new System.Drawing.Point(106, 52);
            this.lbproducto.Name = "lbproducto";
            this.lbproducto.Size = new System.Drawing.Size(62, 18);
            this.lbproducto.TabIndex = 28;
            this.lbproducto.Text = "Nombre:";
            // 
            // vistaProveedoresBindingSource
            // 
            this.vistaProveedoresBindingSource.DataMember = "VistaProveedores";
            this.vistaProveedoresBindingSource.DataSource = this.minisupDataSet1;
            // 
            // vistaProveedoresTableAdapter
            // 
            this.vistaProveedoresTableAdapter.ClearBeforeFill = true;
            // 
            // proveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(869, 616);
            this.Controls.Add(this.TextBoxBuscar);
            this.Controls.Add(this.guna2HtmlLabel5);
            this.Controls.Add(this.TextBoxDireccion);
            this.Controls.Add(this.guna2HtmlLabel4);
            this.Controls.Add(this.guna2HtmlLabel3);
            this.Controls.Add(this.TextBoxTelefono);
            this.Controls.Add(this.guna2HtmlLabel2);
            this.Controls.Add(this.TextBoxCorreo);
            this.Controls.Add(this.TextBoxnit);
            this.Controls.Add(this.TextBoxNombre);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.Gridproveedor);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.comboEstado);
            this.Controls.Add(this.lbproveedor);
            this.Controls.Add(this.lbproducto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "proveedores";
            this.Text = "proveedores";
            this.Load += new System.EventHandler(this.proveedores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vistaClientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minisupDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Gridproveedor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vistaProveedoresBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minisupDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vistaProveedoresBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private minisupDataSet minisupDataSet;
        private System.Windows.Forms.BindingSource vistaClientesBindingSource;
        private minisupDataSetTableAdapters.VistaClientesTableAdapter vistaClientesTableAdapter;
        private Guna.UI2.WinForms.Guna2TextBox TextBoxBuscar;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel5;
        private Guna.UI2.WinForms.Guna2TextBox TextBoxDireccion;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel4;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2TextBox TextBoxTelefono;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2TextBox TextBoxCorreo;
        private Guna.UI2.WinForms.Guna2TextBox TextBoxnit;
        private Guna.UI2.WinForms.Guna2TextBox TextBoxNombre;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2DataGridView Gridproveedor;
        private Guna.UI2.WinForms.Guna2GradientButton btnCancelar;
        private Guna.UI2.WinForms.Guna2GradientButton btnAgregar;
        private Guna.UI2.WinForms.Guna2ComboBox comboEstado;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbproveedor;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbproducto;
        private minisupDataSet1 minisupDataSet1;
        private System.Windows.Forms.BindingSource vistaProveedoresBindingSource;
        private minisupDataSet1TableAdapters.VistaProveedoresTableAdapter vistaProveedoresTableAdapter;
        private System.Windows.Forms.BindingSource vistaProveedoresBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idproveedorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreproveedorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nitproveedorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn correoproveedorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonoproveedorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn Editar;
    }
}