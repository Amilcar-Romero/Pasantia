namespace San_jose.Presentacion
{
    partial class cliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cliente));
            this.lbproducto = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lbproveedor = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel5 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.comboEstado = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnagregarCliente = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnCancelarCliente = new Guna.UI2.WinForms.Guna2GradientButton();
            this.GridCliente = new Guna.UI2.WinForms.Guna2DataGridView();
            this.id_cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre_cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellido_cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carnet_cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefono_cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.correo_cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Editar = new System.Windows.Forms.DataGridViewImageColumn();
            this.vistaClientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.minisupDataSet = new San_jose.minisupDataSet();
            this.TextBoxNombre = new Guna.UI2.WinForms.Guna2TextBox();
            this.TextBoxApellido = new Guna.UI2.WinForms.Guna2TextBox();
            this.TextBoxCI = new Guna.UI2.WinForms.Guna2TextBox();
            this.TextBoxTelefono = new Guna.UI2.WinForms.Guna2TextBox();
            this.TextBoxDireccion = new Guna.UI2.WinForms.Guna2TextBox();
            this.TextBoxBuscar = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.vistaClientesTableAdapter = new San_jose.minisupDataSetTableAdapters.VistaClientesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.GridCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vistaClientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minisupDataSet)).BeginInit();
            this.guna2GroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbproducto
            // 
            this.lbproducto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lbproducto.BackColor = System.Drawing.Color.Transparent;
            this.lbproducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbproducto.ForeColor = System.Drawing.Color.Black;
            this.lbproducto.Location = new System.Drawing.Point(106, 73);
            this.lbproducto.Name = "lbproducto";
            this.lbproducto.Size = new System.Drawing.Size(62, 18);
            this.lbproducto.TabIndex = 8;
            this.lbproducto.Text = "Nombre:";
            this.lbproducto.Click += new System.EventHandler(this.lbproducto_Click);
            // 
            // lbproveedor
            // 
            this.lbproveedor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lbproveedor.BackColor = System.Drawing.Color.Transparent;
            this.lbproveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbproveedor.ForeColor = System.Drawing.Color.Black;
            this.lbproveedor.Location = new System.Drawing.Point(226, 73);
            this.lbproveedor.Name = "lbproveedor";
            this.lbproveedor.Size = new System.Drawing.Size(65, 18);
            this.lbproveedor.TabIndex = 9;
            this.lbproveedor.Text = "Apellido:";
            this.lbproveedor.Click += new System.EventHandler(this.lbproveedor_Click);
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.Black;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(349, 73);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(25, 18);
            this.guna2HtmlLabel1.TabIndex = 17;
            this.guna2HtmlLabel1.Text = "C.I:";
            this.guna2HtmlLabel1.Click += new System.EventHandler(this.guna2HtmlLabel1_Click);
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.ForeColor = System.Drawing.Color.Black;
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(472, 72);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(69, 18);
            this.guna2HtmlLabel2.TabIndex = 21;
            this.guna2HtmlLabel2.Text = "Telefono:";
            this.guna2HtmlLabel2.Click += new System.EventHandler(this.guna2HtmlLabel2_Click);
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel3.ForeColor = System.Drawing.Color.Black;
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(472, 153);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(56, 18);
            this.guna2HtmlLabel3.TabIndex = 23;
            this.guna2HtmlLabel3.Text = "Estado:";
            this.guna2HtmlLabel3.Click += new System.EventHandler(this.guna2HtmlLabel3_Click);
            // 
            // guna2HtmlLabel4
            // 
            this.guna2HtmlLabel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel4.ForeColor = System.Drawing.Color.Black;
            this.guna2HtmlLabel4.Location = new System.Drawing.Point(106, 153);
            this.guna2HtmlLabel4.Name = "guna2HtmlLabel4";
            this.guna2HtmlLabel4.Size = new System.Drawing.Size(73, 18);
            this.guna2HtmlLabel4.TabIndex = 24;
            this.guna2HtmlLabel4.Text = "Direccion:";
            this.guna2HtmlLabel4.Click += new System.EventHandler(this.guna2HtmlLabel4_Click);
            // 
            // guna2HtmlLabel5
            // 
            this.guna2HtmlLabel5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2HtmlLabel5.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel5.ForeColor = System.Drawing.Color.Black;
            this.guna2HtmlLabel5.Location = new System.Drawing.Point(106, 267);
            this.guna2HtmlLabel5.Name = "guna2HtmlLabel5";
            this.guna2HtmlLabel5.Size = new System.Drawing.Size(107, 18);
            this.guna2HtmlLabel5.TabIndex = 26;
            this.guna2HtmlLabel5.Text = "Buscar Cliente:";
            this.guna2HtmlLabel5.Click += new System.EventHandler(this.guna2HtmlLabel5_Click);
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
            this.comboEstado.Location = new System.Drawing.Point(472, 176);
            this.comboEstado.Name = "comboEstado";
            this.comboEstado.Size = new System.Drawing.Size(106, 36);
            this.comboEstado.TabIndex = 11;
            this.comboEstado.SelectedIndexChanged += new System.EventHandler(this.comboEstado_SelectedIndexChanged);
            // 
            // btnagregarCliente
            // 
            this.btnagregarCliente.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnagregarCliente.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnagregarCliente.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnagregarCliente.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnagregarCliente.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnagregarCliente.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnagregarCliente.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnagregarCliente.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnagregarCliente.ForeColor = System.Drawing.Color.White;
            this.btnagregarCliente.Location = new System.Drawing.Point(614, 105);
            this.btnagregarCliente.Name = "btnagregarCliente";
            this.btnagregarCliente.Size = new System.Drawing.Size(96, 41);
            this.btnagregarCliente.TabIndex = 12;
            this.btnagregarCliente.Text = "Agregar Cliente";
            this.btnagregarCliente.Click += new System.EventHandler(this.btnagregarCliente_Click);
            // 
            // btnCancelarCliente
            // 
            this.btnCancelarCliente.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCancelarCliente.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCancelarCliente.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCancelarCliente.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCancelarCliente.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCancelarCliente.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCancelarCliente.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnCancelarCliente.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCancelarCliente.ForeColor = System.Drawing.Color.White;
            this.btnCancelarCliente.Location = new System.Drawing.Point(614, 166);
            this.btnCancelarCliente.Name = "btnCancelarCliente";
            this.btnCancelarCliente.Size = new System.Drawing.Size(96, 40);
            this.btnCancelarCliente.TabIndex = 13;
            this.btnCancelarCliente.Text = "Cancelar";
            this.btnCancelarCliente.Click += new System.EventHandler(this.btnCancelarCliente_Click);
            // 
            // GridCliente
            // 
            this.GridCliente.AllowUserToDeleteRows = false;
            this.GridCliente.AllowUserToResizeColumns = false;
            this.GridCliente.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.GridCliente.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.GridCliente.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GridCliente.AutoGenerateColumns = false;
            this.GridCliente.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.GridCliente.BackgroundColor = System.Drawing.Color.Silver;
            this.GridCliente.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridCliente.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.GridCliente.ColumnHeadersHeight = 22;
            this.GridCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.GridCliente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_cliente,
            this.nombre_cliente,
            this.apellido_cliente,
            this.carnet_cliente,
            this.telefono_cliente,
            this.correo_cliente,
            this.estado,
            this.Editar});
            this.GridCliente.DataSource = this.vistaClientesBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GridCliente.DefaultCellStyle = dataGridViewCellStyle3;
            this.GridCliente.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.GridCliente.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.GridCliente.ImeMode = System.Windows.Forms.ImeMode.On;
            this.GridCliente.Location = new System.Drawing.Point(65, 300);
            this.GridCliente.MultiSelect = false;
            this.GridCliente.Name = "GridCliente";
            this.GridCliente.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridCliente.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.GridCliente.RowHeadersVisible = false;
            this.GridCliente.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.GridCliente.Size = new System.Drawing.Size(749, 287);
            this.GridCliente.StandardTab = true;
            this.GridCliente.TabIndex = 14;
            this.GridCliente.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.GridCliente.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.GridCliente.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.GridCliente.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.GridCliente.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.GridCliente.ThemeStyle.BackColor = System.Drawing.Color.Silver;
            this.GridCliente.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.GridCliente.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.GridCliente.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.GridCliente.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GridCliente.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.GridCliente.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.GridCliente.ThemeStyle.HeaderStyle.Height = 22;
            this.GridCliente.ThemeStyle.ReadOnly = true;
            this.GridCliente.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.GridCliente.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.GridCliente.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GridCliente.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.GridCliente.ThemeStyle.RowsStyle.Height = 22;
            this.GridCliente.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.GridCliente.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.GridCliente.VirtualMode = true;
            this.GridCliente.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridCliente_CellContentClick_1);
            // 
            // id_cliente
            // 
            this.id_cliente.DataPropertyName = "id_cliente";
            this.id_cliente.HeaderText = "id_cliente";
            this.id_cliente.MinimumWidth = 6;
            this.id_cliente.Name = "id_cliente";
            this.id_cliente.ReadOnly = true;
            // 
            // nombre_cliente
            // 
            this.nombre_cliente.DataPropertyName = "nombre_cliente";
            this.nombre_cliente.HeaderText = "nombre_cliente";
            this.nombre_cliente.MinimumWidth = 6;
            this.nombre_cliente.Name = "nombre_cliente";
            this.nombre_cliente.ReadOnly = true;
            // 
            // apellido_cliente
            // 
            this.apellido_cliente.DataPropertyName = "apellido_cliente";
            this.apellido_cliente.HeaderText = "apellido_cliente";
            this.apellido_cliente.MinimumWidth = 6;
            this.apellido_cliente.Name = "apellido_cliente";
            this.apellido_cliente.ReadOnly = true;
            // 
            // carnet_cliente
            // 
            this.carnet_cliente.DataPropertyName = "carnet_cliente";
            this.carnet_cliente.HeaderText = "carnet_cliente";
            this.carnet_cliente.MinimumWidth = 6;
            this.carnet_cliente.Name = "carnet_cliente";
            this.carnet_cliente.ReadOnly = true;
            // 
            // telefono_cliente
            // 
            this.telefono_cliente.DataPropertyName = "telefono_cliente";
            this.telefono_cliente.HeaderText = "telefono_cliente";
            this.telefono_cliente.MinimumWidth = 6;
            this.telefono_cliente.Name = "telefono_cliente";
            this.telefono_cliente.ReadOnly = true;
            // 
            // correo_cliente
            // 
            this.correo_cliente.DataPropertyName = "correo_cliente";
            this.correo_cliente.HeaderText = "correo_cliente";
            this.correo_cliente.MinimumWidth = 6;
            this.correo_cliente.Name = "correo_cliente";
            this.correo_cliente.ReadOnly = true;
            // 
            // estado
            // 
            this.estado.DataPropertyName = "estado";
            this.estado.HeaderText = "estado";
            this.estado.MinimumWidth = 6;
            this.estado.Name = "estado";
            this.estado.ReadOnly = true;
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
            this.TextBoxNombre.Location = new System.Drawing.Point(106, 105);
            this.TextBoxNombre.Name = "TextBoxNombre";
            this.TextBoxNombre.PasswordChar = '\0';
            this.TextBoxNombre.PlaceholderText = "";
            this.TextBoxNombre.SelectedText = "";
            this.TextBoxNombre.Size = new System.Drawing.Size(105, 24);
            this.TextBoxNombre.TabIndex = 18;
            this.TextBoxNombre.TextChanged += new System.EventHandler(this.TextBoxNombre_TextChanged);
            // 
            // TextBoxApellido
            // 
            this.TextBoxApellido.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TextBoxApellido.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.TextBoxApellido.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxApellido.DefaultText = "";
            this.TextBoxApellido.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBoxApellido.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBoxApellido.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxApellido.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxApellido.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBoxApellido.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBoxApellido.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBoxApellido.Location = new System.Drawing.Point(226, 106);
            this.TextBoxApellido.Name = "TextBoxApellido";
            this.TextBoxApellido.PasswordChar = '\0';
            this.TextBoxApellido.PlaceholderText = "";
            this.TextBoxApellido.SelectedText = "";
            this.TextBoxApellido.Size = new System.Drawing.Size(105, 24);
            this.TextBoxApellido.TabIndex = 19;
            this.TextBoxApellido.TextChanged += new System.EventHandler(this.TextBoxApellido_TextChanged);
            // 
            // TextBoxCI
            // 
            this.TextBoxCI.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TextBoxCI.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.TextBoxCI.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxCI.DefaultText = "";
            this.TextBoxCI.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBoxCI.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBoxCI.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxCI.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxCI.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBoxCI.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBoxCI.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBoxCI.Location = new System.Drawing.Point(349, 106);
            this.TextBoxCI.Name = "TextBoxCI";
            this.TextBoxCI.PasswordChar = '\0';
            this.TextBoxCI.PlaceholderText = "";
            this.TextBoxCI.SelectedText = "";
            this.TextBoxCI.Size = new System.Drawing.Size(105, 24);
            this.TextBoxCI.TabIndex = 20;
            this.TextBoxCI.TextChanged += new System.EventHandler(this.TextBoxCI_TextChanged);
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
            this.TextBoxTelefono.Location = new System.Drawing.Point(472, 105);
            this.TextBoxTelefono.Name = "TextBoxTelefono";
            this.TextBoxTelefono.PasswordChar = '\0';
            this.TextBoxTelefono.PlaceholderText = "";
            this.TextBoxTelefono.SelectedText = "";
            this.TextBoxTelefono.Size = new System.Drawing.Size(105, 24);
            this.TextBoxTelefono.TabIndex = 22;
            this.TextBoxTelefono.TextChanged += new System.EventHandler(this.TextBoxTelefono_TextChanged);
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
            this.TextBoxDireccion.Location = new System.Drawing.Point(106, 176);
            this.TextBoxDireccion.Name = "TextBoxDireccion";
            this.TextBoxDireccion.PasswordChar = '\0';
            this.TextBoxDireccion.PlaceholderText = "";
            this.TextBoxDireccion.SelectedText = "";
            this.TextBoxDireccion.Size = new System.Drawing.Size(350, 37);
            this.TextBoxDireccion.TabIndex = 25;
            this.TextBoxDireccion.TextChanged += new System.EventHandler(this.TextBoxDireccion_TextChanged);
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
            this.TextBoxBuscar.Location = new System.Drawing.Point(241, 260);
            this.TextBoxBuscar.Name = "TextBoxBuscar";
            this.TextBoxBuscar.PasswordChar = '\0';
            this.TextBoxBuscar.PlaceholderText = "";
            this.TextBoxBuscar.SelectedText = "";
            this.TextBoxBuscar.Size = new System.Drawing.Size(364, 33);
            this.TextBoxBuscar.TabIndex = 27;
            this.TextBoxBuscar.TextChanged += new System.EventHandler(this.TextBoxBuscar_TextChanged);
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.BorderColor = System.Drawing.Color.Silver;
            this.guna2GroupBox1.Controls.Add(this.TextBoxBuscar);
            this.guna2GroupBox1.Controls.Add(this.guna2HtmlLabel5);
            this.guna2GroupBox1.Controls.Add(this.TextBoxDireccion);
            this.guna2GroupBox1.Controls.Add(this.guna2HtmlLabel4);
            this.guna2GroupBox1.Controls.Add(this.guna2HtmlLabel3);
            this.guna2GroupBox1.Controls.Add(this.TextBoxTelefono);
            this.guna2GroupBox1.Controls.Add(this.guna2HtmlLabel2);
            this.guna2GroupBox1.Controls.Add(this.TextBoxCI);
            this.guna2GroupBox1.Controls.Add(this.TextBoxApellido);
            this.guna2GroupBox1.Controls.Add(this.TextBoxNombre);
            this.guna2GroupBox1.Controls.Add(this.guna2HtmlLabel1);
            this.guna2GroupBox1.Controls.Add(this.GridCliente);
            this.guna2GroupBox1.Controls.Add(this.btnCancelarCliente);
            this.guna2GroupBox1.Controls.Add(this.btnagregarCliente);
            this.guna2GroupBox1.Controls.Add(this.comboEstado);
            this.guna2GroupBox1.Controls.Add(this.lbproveedor);
            this.guna2GroupBox1.Controls.Add(this.lbproducto);
            this.guna2GroupBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.guna2GroupBox1.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.guna2GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2GroupBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.Black;
            this.guna2GroupBox1.Location = new System.Drawing.Point(0, 0);
            this.guna2GroupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.Size = new System.Drawing.Size(859, 609);
            this.guna2GroupBox1.TabIndex = 28;
            this.guna2GroupBox1.Text = "GESTION DE CLIENTES";
            this.guna2GroupBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // vistaClientesTableAdapter
            // 
            this.vistaClientesTableAdapter.ClearBeforeFill = true;
            // 
            // cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(859, 609);
            this.Controls.Add(this.guna2GroupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.ImeMode = System.Windows.Forms.ImeMode.On;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "cliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "cliente";
            this.Load += new System.EventHandler(this.cliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vistaClientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minisupDataSet)).EndInit();
            this.guna2GroupBox1.ResumeLayout(false);
            this.guna2GroupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2HtmlLabel lbproducto;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbproveedor;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel4;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel5;
        private Guna.UI2.WinForms.Guna2ComboBox comboEstado;
        private Guna.UI2.WinForms.Guna2GradientButton btnagregarCliente;
        private Guna.UI2.WinForms.Guna2GradientButton btnCancelarCliente;
        private Guna.UI2.WinForms.Guna2DataGridView GridCliente;
        private Guna.UI2.WinForms.Guna2TextBox TextBoxNombre;
        private Guna.UI2.WinForms.Guna2TextBox TextBoxApellido;
        private Guna.UI2.WinForms.Guna2TextBox TextBoxCI;
        private Guna.UI2.WinForms.Guna2TextBox TextBoxTelefono;
        private Guna.UI2.WinForms.Guna2TextBox TextBoxDireccion;
        private Guna.UI2.WinForms.Guna2TextBox TextBoxBuscar;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private minisupDataSet minisupDataSet;
        private System.Windows.Forms.BindingSource vistaClientesBindingSource;
        private minisupDataSetTableAdapters.VistaClientesTableAdapter vistaClientesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre_cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellido_cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn carnet_cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefono_cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn correo_cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado;
        private System.Windows.Forms.DataGridViewImageColumn Editar;
    }
}