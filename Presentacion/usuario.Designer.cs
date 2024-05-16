namespace San_jose.Presentacion
{
    partial class usuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(usuario));
            this.TextBoxBuscar = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel5 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.TextBoxContraseña = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.TextBoxCorreo = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.TextBoxCI = new Guna.UI2.WinForms.Guna2TextBox();
            this.TextBoxApellido = new Guna.UI2.WinForms.Guna2TextBox();
            this.TextBoxNombre = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.GridUsuario = new Guna.UI2.WinForms.Guna2DataGridView();
            this.idusuarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreusuarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidousuarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carnetusuarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.correousuarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre_rol_usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Editar = new System.Windows.Forms.DataGridViewImageColumn();
            this.vistaUsuariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.minisupDataSet2 = new San_jose.minisupDataSet2();
            this.btnCancelar = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnagregar = new Guna.UI2.WinForms.Guna2GradientButton();
            this.ComboRol = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lbproveedor = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lbproducto = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.vistaUsuariosTableAdapter = new San_jose.minisupDataSet2TableAdapters.VistaUsuariosTableAdapter();
            this.guna2HtmlLabel6 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.ComboEstado = new Guna.UI2.WinForms.Guna2ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.GridUsuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vistaUsuariosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minisupDataSet2)).BeginInit();
            this.SuspendLayout();
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
            this.TextBoxBuscar.Location = new System.Drawing.Point(247, 246);
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
            this.guna2HtmlLabel5.Location = new System.Drawing.Point(112, 253);
            this.guna2HtmlLabel5.Name = "guna2HtmlLabel5";
            this.guna2HtmlLabel5.Size = new System.Drawing.Size(109, 18);
            this.guna2HtmlLabel5.TabIndex = 43;
            this.guna2HtmlLabel5.Text = "Buscar Usuario";
            // 
            // TextBoxContraseña
            // 
            this.TextBoxContraseña.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TextBoxContraseña.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.TextBoxContraseña.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxContraseña.DefaultText = "";
            this.TextBoxContraseña.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBoxContraseña.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBoxContraseña.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxContraseña.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxContraseña.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBoxContraseña.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBoxContraseña.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBoxContraseña.Location = new System.Drawing.Point(112, 162);
            this.TextBoxContraseña.Name = "TextBoxContraseña";
            this.TextBoxContraseña.PasswordChar = '\0';
            this.TextBoxContraseña.PlaceholderText = "";
            this.TextBoxContraseña.SelectedText = "";
            this.TextBoxContraseña.Size = new System.Drawing.Size(197, 37);
            this.TextBoxContraseña.TabIndex = 42;
            // 
            // guna2HtmlLabel4
            // 
            this.guna2HtmlLabel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel4.ForeColor = System.Drawing.Color.Black;
            this.guna2HtmlLabel4.Location = new System.Drawing.Point(112, 139);
            this.guna2HtmlLabel4.Name = "guna2HtmlLabel4";
            this.guna2HtmlLabel4.Size = new System.Drawing.Size(82, 18);
            this.guna2HtmlLabel4.TabIndex = 41;
            this.guna2HtmlLabel4.Text = "Contraseña";
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel3.ForeColor = System.Drawing.Color.Black;
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(478, 139);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(27, 18);
            this.guna2HtmlLabel3.TabIndex = 40;
            this.guna2HtmlLabel3.Text = "Rol";
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
            this.TextBoxCorreo.Location = new System.Drawing.Point(478, 91);
            this.TextBoxCorreo.Name = "TextBoxCorreo";
            this.TextBoxCorreo.PasswordChar = '\0';
            this.TextBoxCorreo.PlaceholderText = "";
            this.TextBoxCorreo.SelectedText = "";
            this.TextBoxCorreo.Size = new System.Drawing.Size(133, 24);
            this.TextBoxCorreo.TabIndex = 39;
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.ForeColor = System.Drawing.Color.Black;
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(478, 58);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(48, 18);
            this.guna2HtmlLabel2.TabIndex = 38;
            this.guna2HtmlLabel2.Text = "correo";
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
            this.TextBoxCI.Location = new System.Drawing.Point(355, 92);
            this.TextBoxCI.Name = "TextBoxCI";
            this.TextBoxCI.PasswordChar = '\0';
            this.TextBoxCI.PlaceholderText = "";
            this.TextBoxCI.SelectedText = "";
            this.TextBoxCI.Size = new System.Drawing.Size(105, 24);
            this.TextBoxCI.TabIndex = 37;
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
            this.TextBoxApellido.Location = new System.Drawing.Point(232, 92);
            this.TextBoxApellido.Name = "TextBoxApellido";
            this.TextBoxApellido.PasswordChar = '\0';
            this.TextBoxApellido.PlaceholderText = "";
            this.TextBoxApellido.SelectedText = "";
            this.TextBoxApellido.Size = new System.Drawing.Size(105, 24);
            this.TextBoxApellido.TabIndex = 36;
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
            this.TextBoxNombre.Location = new System.Drawing.Point(112, 91);
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
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(355, 59);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(25, 18);
            this.guna2HtmlLabel1.TabIndex = 34;
            this.guna2HtmlLabel1.Text = "C.I:";
            // 
            // GridUsuario
            // 
            this.GridUsuario.AllowUserToDeleteRows = false;
            this.GridUsuario.AllowUserToResizeColumns = false;
            this.GridUsuario.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.GridUsuario.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.GridUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GridUsuario.AutoGenerateColumns = false;
            this.GridUsuario.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.GridUsuario.BackgroundColor = System.Drawing.Color.Silver;
            this.GridUsuario.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridUsuario.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.GridUsuario.ColumnHeadersHeight = 22;
            this.GridUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.GridUsuario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idusuarioDataGridViewTextBoxColumn,
            this.nombreusuarioDataGridViewTextBoxColumn,
            this.apellidousuarioDataGridViewTextBoxColumn,
            this.carnetusuarioDataGridViewTextBoxColumn,
            this.correousuarioDataGridViewTextBoxColumn,
            this.estadoDataGridViewTextBoxColumn,
            this.nombre_rol_usuario,
            this.Editar});
            this.GridUsuario.DataSource = this.vistaUsuariosBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GridUsuario.DefaultCellStyle = dataGridViewCellStyle3;
            this.GridUsuario.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.GridUsuario.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.GridUsuario.ImeMode = System.Windows.Forms.ImeMode.On;
            this.GridUsuario.Location = new System.Drawing.Point(33, 298);
            this.GridUsuario.MultiSelect = false;
            this.GridUsuario.Name = "GridUsuario";
            this.GridUsuario.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridUsuario.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.GridUsuario.RowHeadersVisible = false;
            this.GridUsuario.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.GridUsuario.Size = new System.Drawing.Size(782, 287);
            this.GridUsuario.StandardTab = true;
            this.GridUsuario.TabIndex = 33;
            this.GridUsuario.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.GridUsuario.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.GridUsuario.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.GridUsuario.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.GridUsuario.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.GridUsuario.ThemeStyle.BackColor = System.Drawing.Color.Silver;
            this.GridUsuario.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.GridUsuario.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.GridUsuario.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.GridUsuario.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GridUsuario.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.GridUsuario.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.GridUsuario.ThemeStyle.HeaderStyle.Height = 22;
            this.GridUsuario.ThemeStyle.ReadOnly = true;
            this.GridUsuario.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.GridUsuario.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.GridUsuario.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GridUsuario.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.GridUsuario.ThemeStyle.RowsStyle.Height = 22;
            this.GridUsuario.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.GridUsuario.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.GridUsuario.VirtualMode = true;
            this.GridUsuario.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridUsuario_CellContentClick);
            // 
            // idusuarioDataGridViewTextBoxColumn
            // 
            this.idusuarioDataGridViewTextBoxColumn.DataPropertyName = "id_usuario";
            this.idusuarioDataGridViewTextBoxColumn.HeaderText = "id_usuario";
            this.idusuarioDataGridViewTextBoxColumn.Name = "idusuarioDataGridViewTextBoxColumn";
            this.idusuarioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombreusuarioDataGridViewTextBoxColumn
            // 
            this.nombreusuarioDataGridViewTextBoxColumn.DataPropertyName = "nombre_usuario";
            this.nombreusuarioDataGridViewTextBoxColumn.HeaderText = "nombre_usuario";
            this.nombreusuarioDataGridViewTextBoxColumn.Name = "nombreusuarioDataGridViewTextBoxColumn";
            this.nombreusuarioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // apellidousuarioDataGridViewTextBoxColumn
            // 
            this.apellidousuarioDataGridViewTextBoxColumn.DataPropertyName = "apellido_usuario";
            this.apellidousuarioDataGridViewTextBoxColumn.HeaderText = "apellido_usuario";
            this.apellidousuarioDataGridViewTextBoxColumn.Name = "apellidousuarioDataGridViewTextBoxColumn";
            this.apellidousuarioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // carnetusuarioDataGridViewTextBoxColumn
            // 
            this.carnetusuarioDataGridViewTextBoxColumn.DataPropertyName = "carnet_usuario";
            this.carnetusuarioDataGridViewTextBoxColumn.HeaderText = "carnet_usuario";
            this.carnetusuarioDataGridViewTextBoxColumn.Name = "carnetusuarioDataGridViewTextBoxColumn";
            this.carnetusuarioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // correousuarioDataGridViewTextBoxColumn
            // 
            this.correousuarioDataGridViewTextBoxColumn.DataPropertyName = "correo_usuario";
            this.correousuarioDataGridViewTextBoxColumn.HeaderText = "correo_usuario";
            this.correousuarioDataGridViewTextBoxColumn.Name = "correousuarioDataGridViewTextBoxColumn";
            this.correousuarioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // estadoDataGridViewTextBoxColumn
            // 
            this.estadoDataGridViewTextBoxColumn.DataPropertyName = "estado";
            this.estadoDataGridViewTextBoxColumn.HeaderText = "estado";
            this.estadoDataGridViewTextBoxColumn.Name = "estadoDataGridViewTextBoxColumn";
            this.estadoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombre_rol_usuario
            // 
            this.nombre_rol_usuario.DataPropertyName = "nombre_rol_usuario";
            this.nombre_rol_usuario.HeaderText = "nombre_rol_usuario";
            this.nombre_rol_usuario.Name = "nombre_rol_usuario";
            this.nombre_rol_usuario.ReadOnly = true;
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
            // vistaUsuariosBindingSource
            // 
            this.vistaUsuariosBindingSource.DataMember = "VistaUsuarios";
            this.vistaUsuariosBindingSource.DataSource = this.minisupDataSet2;
            // 
            // minisupDataSet2
            // 
            this.minisupDataSet2.DataSetName = "minisupDataSet2";
            this.minisupDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.btnCancelar.Location = new System.Drawing.Point(620, 152);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(96, 40);
            this.btnCancelar.TabIndex = 32;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnagregar
            // 
            this.btnagregar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnagregar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnagregar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnagregar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnagregar.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnagregar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnagregar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnagregar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnagregar.ForeColor = System.Drawing.Color.White;
            this.btnagregar.Location = new System.Drawing.Point(620, 91);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(96, 41);
            this.btnagregar.TabIndex = 31;
            this.btnagregar.Text = "Agregar ";
            this.btnagregar.Click += new System.EventHandler(this.btnagregar_Click);
            // 
            // ComboRol
            // 
            this.ComboRol.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ComboRol.BackColor = System.Drawing.Color.Transparent;
            this.ComboRol.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ComboRol.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ComboRol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboRol.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ComboRol.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ComboRol.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ComboRol.ForeColor = System.Drawing.Color.Black;
            this.ComboRol.ItemHeight = 30;
            this.ComboRol.Location = new System.Drawing.Point(478, 162);
            this.ComboRol.Name = "ComboRol";
            this.ComboRol.Size = new System.Drawing.Size(133, 36);
            this.ComboRol.TabIndex = 30;
            this.ComboRol.SelectedIndexChanged += new System.EventHandler(this.ComboRol_SelectedIndexChanged);
            // 
            // lbproveedor
            // 
            this.lbproveedor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lbproveedor.BackColor = System.Drawing.Color.Transparent;
            this.lbproveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbproveedor.ForeColor = System.Drawing.Color.Black;
            this.lbproveedor.Location = new System.Drawing.Point(232, 59);
            this.lbproveedor.Name = "lbproveedor";
            this.lbproveedor.Size = new System.Drawing.Size(65, 18);
            this.lbproveedor.TabIndex = 29;
            this.lbproveedor.Text = "Apellido:";
            // 
            // lbproducto
            // 
            this.lbproducto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lbproducto.BackColor = System.Drawing.Color.Transparent;
            this.lbproducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbproducto.ForeColor = System.Drawing.Color.Black;
            this.lbproducto.Location = new System.Drawing.Point(112, 59);
            this.lbproducto.Name = "lbproducto";
            this.lbproducto.Size = new System.Drawing.Size(62, 18);
            this.lbproducto.TabIndex = 28;
            this.lbproducto.Text = "Nombre:";
            // 
            // vistaUsuariosTableAdapter
            // 
            this.vistaUsuariosTableAdapter.ClearBeforeFill = true;
            // 
            // guna2HtmlLabel6
            // 
            this.guna2HtmlLabel6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.guna2HtmlLabel6.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel6.ForeColor = System.Drawing.Color.Black;
            this.guna2HtmlLabel6.Location = new System.Drawing.Point(327, 140);
            this.guna2HtmlLabel6.Name = "guna2HtmlLabel6";
            this.guna2HtmlLabel6.Size = new System.Drawing.Size(52, 18);
            this.guna2HtmlLabel6.TabIndex = 46;
            this.guna2HtmlLabel6.Text = "Estado";
            // 
            // ComboEstado
            // 
            this.ComboEstado.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ComboEstado.BackColor = System.Drawing.Color.Transparent;
            this.ComboEstado.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ComboEstado.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ComboEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboEstado.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ComboEstado.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ComboEstado.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ComboEstado.ForeColor = System.Drawing.Color.Black;
            this.ComboEstado.ItemHeight = 30;
            this.ComboEstado.Location = new System.Drawing.Point(327, 163);
            this.ComboEstado.Name = "ComboEstado";
            this.ComboEstado.Size = new System.Drawing.Size(133, 36);
            this.ComboEstado.TabIndex = 45;
            // 
            // usuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(880, 630);
            this.Controls.Add(this.guna2HtmlLabel6);
            this.Controls.Add(this.ComboEstado);
            this.Controls.Add(this.TextBoxBuscar);
            this.Controls.Add(this.guna2HtmlLabel5);
            this.Controls.Add(this.TextBoxContraseña);
            this.Controls.Add(this.guna2HtmlLabel4);
            this.Controls.Add(this.guna2HtmlLabel3);
            this.Controls.Add(this.TextBoxCorreo);
            this.Controls.Add(this.guna2HtmlLabel2);
            this.Controls.Add(this.TextBoxCI);
            this.Controls.Add(this.TextBoxApellido);
            this.Controls.Add(this.TextBoxNombre);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.GridUsuario);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnagregar);
            this.Controls.Add(this.ComboRol);
            this.Controls.Add(this.lbproveedor);
            this.Controls.Add(this.lbproducto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "usuario";
            this.Text = "usuario";
            this.Load += new System.EventHandler(this.usuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridUsuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vistaUsuariosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minisupDataSet2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox TextBoxBuscar;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel5;
        private Guna.UI2.WinForms.Guna2TextBox TextBoxContraseña;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel4;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2TextBox TextBoxCorreo;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2TextBox TextBoxCI;
        private Guna.UI2.WinForms.Guna2TextBox TextBoxApellido;
        private Guna.UI2.WinForms.Guna2TextBox TextBoxNombre;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2DataGridView GridUsuario;
        private Guna.UI2.WinForms.Guna2GradientButton btnCancelar;
        private Guna.UI2.WinForms.Guna2GradientButton btnagregar;
        private Guna.UI2.WinForms.Guna2ComboBox ComboRol;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbproveedor;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbproducto;
        private minisupDataSet2 minisupDataSet2;
        private System.Windows.Forms.BindingSource vistaUsuariosBindingSource;
        private minisupDataSet2TableAdapters.VistaUsuariosTableAdapter vistaUsuariosTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idusuarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreusuarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidousuarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn carnetusuarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn correousuarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre_rol_usuario;
        private System.Windows.Forms.DataGridViewImageColumn Editar;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel6;
        private Guna.UI2.WinForms.Guna2ComboBox ComboEstado;
    }
}