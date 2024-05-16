namespace San_jose
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panelPrincipal = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.contenedordeForm = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.controlesCerrarMaximizar = new Guna.UI2.WinForms.Guna2Panel();
            this.salir = new Guna.UI2.WinForms.Guna2ImageButton();
            this.guna2ImageButton3 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.maximizar = new Guna.UI2.WinForms.Guna2ImageButton();
            this.guna2CustomGradientPanel1 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.btnUsuario = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.proveedor = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2GradientButton4 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.compra = new Guna.UI2.WinForms.Guna2GradientButton();
            this.venta = new Guna.UI2.WinForms.Guna2GradientButton();
            this.dashboard = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnproducto = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2ImageButton1 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.lblUserlogin = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.panelPrincipal.SuspendLayout();
            this.controlesCerrarMaximizar.SuspendLayout();
            this.guna2CustomGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelPrincipal
            // 
            this.panelPrincipal.BackColor = System.Drawing.Color.White;
            this.panelPrincipal.BorderColor = System.Drawing.Color.Cyan;
            this.panelPrincipal.Controls.Add(this.contenedordeForm);
            this.panelPrincipal.Controls.Add(this.controlesCerrarMaximizar);
            this.panelPrincipal.Controls.Add(this.guna2CustomGradientPanel1);
            this.panelPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPrincipal.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panelPrincipal.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panelPrincipal.Location = new System.Drawing.Point(0, 0);
            this.panelPrincipal.Name = "panelPrincipal";
            this.panelPrincipal.Size = new System.Drawing.Size(1635, 864);
            this.panelPrincipal.TabIndex = 1;
            // 
            // contenedordeForm
            // 
            this.contenedordeForm.AutoSize = true;
            this.contenedordeForm.BackColor = System.Drawing.Color.Gray;
            this.contenedordeForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contenedordeForm.FillColor = System.Drawing.Color.DarkGray;
            this.contenedordeForm.Location = new System.Drawing.Point(249, 45);
            this.contenedordeForm.Name = "contenedordeForm";
            this.contenedordeForm.Size = new System.Drawing.Size(1386, 819);
            this.contenedordeForm.TabIndex = 2;
            this.contenedordeForm.Paint += new System.Windows.Forms.PaintEventHandler(this.contenedordeForm_Paint);
            // 
            // controlesCerrarMaximizar
            // 
            this.controlesCerrarMaximizar.BackColor = System.Drawing.Color.White;
            this.controlesCerrarMaximizar.Controls.Add(this.lblUserlogin);
            this.controlesCerrarMaximizar.Controls.Add(this.guna2ImageButton1);
            this.controlesCerrarMaximizar.Controls.Add(this.salir);
            this.controlesCerrarMaximizar.Controls.Add(this.guna2ImageButton3);
            this.controlesCerrarMaximizar.Controls.Add(this.maximizar);
            this.controlesCerrarMaximizar.Dock = System.Windows.Forms.DockStyle.Top;
            this.controlesCerrarMaximizar.Location = new System.Drawing.Point(249, 0);
            this.controlesCerrarMaximizar.Name = "controlesCerrarMaximizar";
            this.controlesCerrarMaximizar.Size = new System.Drawing.Size(1386, 45);
            this.controlesCerrarMaximizar.TabIndex = 1;
            // 
            // salir
            // 
            this.salir.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.salir.BackColor = System.Drawing.Color.Transparent;
            this.salir.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.salir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.salir.HoverState.ImageSize = new System.Drawing.Size(0, 0);
            this.salir.Image = ((System.Drawing.Image)(resources.GetObject("salir.Image")));
            this.salir.ImageOffset = new System.Drawing.Point(0, 0);
            this.salir.ImageRotate = 0F;
            this.salir.ImageSize = new System.Drawing.Size(20, 20);
            this.salir.Location = new System.Drawing.Point(1338, 6);
            this.salir.Name = "salir";
            this.salir.PressedState.ImageSize = new System.Drawing.Size(0, 0);
            this.salir.Size = new System.Drawing.Size(46, 36);
            this.salir.TabIndex = 4;
            this.salir.Click += new System.EventHandler(this.salir_Click);
            // 
            // guna2ImageButton3
            // 
            this.guna2ImageButton3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.guna2ImageButton3.BackColor = System.Drawing.Color.Transparent;
            this.guna2ImageButton3.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2ImageButton3.HoverState.ImageSize = new System.Drawing.Size(0, 0);
            this.guna2ImageButton3.Image = ((System.Drawing.Image)(resources.GetObject("guna2ImageButton3.Image")));
            this.guna2ImageButton3.ImageOffset = new System.Drawing.Point(0, 0);
            this.guna2ImageButton3.ImageRotate = 0F;
            this.guna2ImageButton3.ImageSize = new System.Drawing.Size(20, 20);
            this.guna2ImageButton3.Location = new System.Drawing.Point(1256, 6);
            this.guna2ImageButton3.Name = "guna2ImageButton3";
            this.guna2ImageButton3.PressedState.ImageSize = new System.Drawing.Size(0, 0);
            this.guna2ImageButton3.Size = new System.Drawing.Size(46, 36);
            this.guna2ImageButton3.TabIndex = 3;
            this.guna2ImageButton3.Click += new System.EventHandler(this.guna2ImageButton3_Click);
            // 
            // maximizar
            // 
            this.maximizar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.maximizar.BackColor = System.Drawing.Color.Transparent;
            this.maximizar.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.maximizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.maximizar.HoverState.ImageSize = new System.Drawing.Size(0, 0);
            this.maximizar.Image = ((System.Drawing.Image)(resources.GetObject("maximizar.Image")));
            this.maximizar.ImageOffset = new System.Drawing.Point(0, 0);
            this.maximizar.ImageRotate = 0F;
            this.maximizar.ImageSize = new System.Drawing.Size(20, 20);
            this.maximizar.Location = new System.Drawing.Point(1302, 8);
            this.maximizar.Name = "maximizar";
            this.maximizar.PressedState.ImageSize = new System.Drawing.Size(0, 0);
            this.maximizar.Size = new System.Drawing.Size(46, 36);
            this.maximizar.TabIndex = 2;
            this.maximizar.Click += new System.EventHandler(this.maximizar_Click);
            // 
            // guna2CustomGradientPanel1
            // 
            this.guna2CustomGradientPanel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.guna2CustomGradientPanel1.Controls.Add(this.btnproducto);
            this.guna2CustomGradientPanel1.Controls.Add(this.btnUsuario);
            this.guna2CustomGradientPanel1.Controls.Add(this.guna2PictureBox1);
            this.guna2CustomGradientPanel1.Controls.Add(this.proveedor);
            this.guna2CustomGradientPanel1.Controls.Add(this.guna2GradientButton4);
            this.guna2CustomGradientPanel1.Controls.Add(this.compra);
            this.guna2CustomGradientPanel1.Controls.Add(this.venta);
            this.guna2CustomGradientPanel1.Controls.Add(this.dashboard);
            this.guna2CustomGradientPanel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2CustomGradientPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.guna2CustomGradientPanel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.guna2CustomGradientPanel1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.guna2CustomGradientPanel1.FillColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.guna2CustomGradientPanel1.FillColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.guna2CustomGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.guna2CustomGradientPanel1.Name = "guna2CustomGradientPanel1";
            this.guna2CustomGradientPanel1.Size = new System.Drawing.Size(249, 864);
            this.guna2CustomGradientPanel1.TabIndex = 0;
            this.guna2CustomGradientPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2CustomGradientPanel1_Paint);
            // 
            // btnUsuario
            // 
            this.btnUsuario.BackColor = System.Drawing.Color.Transparent;
            this.btnUsuario.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnUsuario.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnUsuario.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUsuario.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUsuario.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnUsuario.FillColor = System.Drawing.Color.Transparent;
            this.btnUsuario.FillColor2 = System.Drawing.Color.Transparent;
            this.btnUsuario.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsuario.ForeColor = System.Drawing.Color.White;
            this.btnUsuario.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnUsuario.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnUsuario.HoverState.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsuario.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnUsuario.Image = ((System.Drawing.Image)(resources.GetObject("btnUsuario.Image")));
            this.btnUsuario.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnUsuario.ImageSize = new System.Drawing.Size(40, 40);
            this.btnUsuario.Location = new System.Drawing.Point(1, 554);
            this.btnUsuario.Name = "btnUsuario";
            this.btnUsuario.Size = new System.Drawing.Size(215, 45);
            this.btnUsuario.TabIndex = 6;
            this.btnUsuario.Text = "Empleados";
            this.btnUsuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnUsuario.Click += new System.EventHandler(this.btnUsuario_Click);
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(30, 45);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(196, 176);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 1;
            this.guna2PictureBox1.TabStop = false;
            // 
            // proveedor
            // 
            this.proveedor.BackColor = System.Drawing.Color.Transparent;
            this.proveedor.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.proveedor.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.proveedor.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.proveedor.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.proveedor.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.proveedor.FillColor = System.Drawing.Color.Transparent;
            this.proveedor.FillColor2 = System.Drawing.Color.Transparent;
            this.proveedor.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.proveedor.ForeColor = System.Drawing.Color.White;
            this.proveedor.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.proveedor.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.proveedor.HoverState.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.proveedor.HoverState.ForeColor = System.Drawing.Color.White;
            this.proveedor.Image = ((System.Drawing.Image)(resources.GetObject("proveedor.Image")));
            this.proveedor.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.proveedor.ImageSize = new System.Drawing.Size(40, 40);
            this.proveedor.Location = new System.Drawing.Point(3, 492);
            this.proveedor.Name = "proveedor";
            this.proveedor.Size = new System.Drawing.Size(223, 45);
            this.proveedor.TabIndex = 5;
            this.proveedor.Text = "Proveedores";
            this.proveedor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.proveedor.Click += new System.EventHandler(this.proveedor_Click);
            // 
            // guna2GradientButton4
            // 
            this.guna2GradientButton4.BackColor = System.Drawing.Color.Transparent;
            this.guna2GradientButton4.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientButton4.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientButton4.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientButton4.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientButton4.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2GradientButton4.FillColor = System.Drawing.Color.Transparent;
            this.guna2GradientButton4.FillColor2 = System.Drawing.Color.Transparent;
            this.guna2GradientButton4.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GradientButton4.ForeColor = System.Drawing.Color.White;
            this.guna2GradientButton4.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.guna2GradientButton4.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.guna2GradientButton4.HoverState.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GradientButton4.HoverState.ForeColor = System.Drawing.Color.White;
            this.guna2GradientButton4.Image = ((System.Drawing.Image)(resources.GetObject("guna2GradientButton4.Image")));
            this.guna2GradientButton4.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2GradientButton4.ImageSize = new System.Drawing.Size(40, 40);
            this.guna2GradientButton4.Location = new System.Drawing.Point(3, 441);
            this.guna2GradientButton4.Name = "guna2GradientButton4";
            this.guna2GradientButton4.Padding = new System.Windows.Forms.Padding(0, 0, 26, 0);
            this.guna2GradientButton4.Size = new System.Drawing.Size(223, 45);
            this.guna2GradientButton4.TabIndex = 4;
            this.guna2GradientButton4.Text = "Clientes";
            this.guna2GradientButton4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.guna2GradientButton4.Click += new System.EventHandler(this.guna2GradientButton4_Click);
            // 
            // compra
            // 
            this.compra.BackColor = System.Drawing.Color.Transparent;
            this.compra.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.compra.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.compra.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.compra.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.compra.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.compra.FillColor = System.Drawing.Color.Transparent;
            this.compra.FillColor2 = System.Drawing.Color.Transparent;
            this.compra.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.compra.ForeColor = System.Drawing.Color.White;
            this.compra.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.compra.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.compra.HoverState.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.compra.HoverState.ForeColor = System.Drawing.Color.White;
            this.compra.Image = ((System.Drawing.Image)(resources.GetObject("compra.Image")));
            this.compra.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.compra.ImageSize = new System.Drawing.Size(40, 40);
            this.compra.Location = new System.Drawing.Point(3, 390);
            this.compra.Name = "compra";
            this.compra.Padding = new System.Windows.Forms.Padding(0, 0, 26, 0);
            this.compra.Size = new System.Drawing.Size(223, 45);
            this.compra.TabIndex = 3;
            this.compra.Text = "Comprar";
            this.compra.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.compra.Click += new System.EventHandler(this.compra_Click);
            // 
            // venta
            // 
            this.venta.BackColor = System.Drawing.Color.Transparent;
            this.venta.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.venta.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.venta.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.venta.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.venta.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.venta.FillColor = System.Drawing.Color.Transparent;
            this.venta.FillColor2 = System.Drawing.Color.Transparent;
            this.venta.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.venta.ForeColor = System.Drawing.Color.White;
            this.venta.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.venta.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.venta.HoverState.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.venta.HoverState.ForeColor = System.Drawing.Color.White;
            this.venta.Image = ((System.Drawing.Image)(resources.GetObject("venta.Image")));
            this.venta.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.venta.ImageSize = new System.Drawing.Size(40, 40);
            this.venta.Location = new System.Drawing.Point(3, 336);
            this.venta.Name = "venta";
            this.venta.Padding = new System.Windows.Forms.Padding(0, 0, 30, 0);
            this.venta.Size = new System.Drawing.Size(223, 45);
            this.venta.TabIndex = 2;
            this.venta.Text = "Vender";
            this.venta.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.venta.Click += new System.EventHandler(this.venta_Click);
            // 
            // dashboard
            // 
            this.dashboard.BackColor = System.Drawing.Color.Transparent;
            this.dashboard.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.dashboard.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.dashboard.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.dashboard.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.dashboard.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.dashboard.FillColor = System.Drawing.Color.Transparent;
            this.dashboard.FillColor2 = System.Drawing.Color.Transparent;
            this.dashboard.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashboard.ForeColor = System.Drawing.Color.White;
            this.dashboard.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dashboard.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dashboard.HoverState.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashboard.HoverState.ForeColor = System.Drawing.Color.White;
            this.dashboard.Image = ((System.Drawing.Image)(resources.GetObject("dashboard.Image")));
            this.dashboard.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.dashboard.ImageSize = new System.Drawing.Size(40, 40);
            this.dashboard.Location = new System.Drawing.Point(3, 285);
            this.dashboard.Name = "dashboard";
            this.dashboard.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.dashboard.Size = new System.Drawing.Size(223, 45);
            this.dashboard.TabIndex = 1;
            this.dashboard.Text = "Dashboard";
            this.dashboard.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.dashboard.Click += new System.EventHandler(this.dashboard_Click);
            // 
            // btnproducto
            // 
            this.btnproducto.BackColor = System.Drawing.Color.Transparent;
            this.btnproducto.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnproducto.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnproducto.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnproducto.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnproducto.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnproducto.FillColor = System.Drawing.Color.Transparent;
            this.btnproducto.FillColor2 = System.Drawing.Color.Transparent;
            this.btnproducto.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnproducto.ForeColor = System.Drawing.Color.White;
            this.btnproducto.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnproducto.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnproducto.HoverState.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnproducto.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnproducto.Image = ((System.Drawing.Image)(resources.GetObject("btnproducto.Image")));
            this.btnproducto.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnproducto.ImageSize = new System.Drawing.Size(40, 40);
            this.btnproducto.Location = new System.Drawing.Point(0, 605);
            this.btnproducto.Name = "btnproducto";
            this.btnproducto.Size = new System.Drawing.Size(226, 45);
            this.btnproducto.TabIndex = 7;
            this.btnproducto.Text = "Productos";
            this.btnproducto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnproducto.Click += new System.EventHandler(this.btnproducto_Click);
            // 
            // guna2ImageButton1
            // 
            this.guna2ImageButton1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.guna2ImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ImageButton1.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2ImageButton1.HoverState.ImageSize = new System.Drawing.Size(0, 0);
            this.guna2ImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("guna2ImageButton1.Image")));
            this.guna2ImageButton1.ImageOffset = new System.Drawing.Point(0, 0);
            this.guna2ImageButton1.ImageRotate = 0F;
            this.guna2ImageButton1.ImageSize = new System.Drawing.Size(30, 30);
            this.guna2ImageButton1.Location = new System.Drawing.Point(0, 9);
            this.guna2ImageButton1.Name = "guna2ImageButton1";
            this.guna2ImageButton1.PressedState.ImageSize = new System.Drawing.Size(0, 0);
            this.guna2ImageButton1.Size = new System.Drawing.Size(46, 33);
            this.guna2ImageButton1.TabIndex = 5;
            // 
            // lblUserlogin
            // 
            this.lblUserlogin.BackColor = System.Drawing.Color.Transparent;
            this.lblUserlogin.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserlogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblUserlogin.Location = new System.Drawing.Point(43, 21);
            this.lblUserlogin.Name = "lblUserlogin";
            this.lblUserlogin.Size = new System.Drawing.Size(151, 18);
            this.lblUserlogin.TabIndex = 0;
            this.lblUserlogin.Text = "Hola: Roider Millares";
            this.lblUserlogin.Click += new System.EventHandler(this.lblUserlogin_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1635, 864);
            this.ControlBox = false;
            this.Controls.Add(this.panelPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "San-Jose";
            this.panelPrincipal.ResumeLayout(false);
            this.panelPrincipal.PerformLayout();
            this.controlesCerrarMaximizar.ResumeLayout(false);
            this.controlesCerrarMaximizar.PerformLayout();
            this.guna2CustomGradientPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2CustomGradientPanel panelPrincipal;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2GradientButton dashboard;
        private Guna.UI2.WinForms.Guna2GradientButton proveedor;
        private Guna.UI2.WinForms.Guna2GradientButton guna2GradientButton4;
        private Guna.UI2.WinForms.Guna2GradientButton compra;
        private Guna.UI2.WinForms.Guna2GradientButton venta;
        private Guna.UI2.WinForms.Guna2Panel controlesCerrarMaximizar;
        private Guna.UI2.WinForms.Guna2ImageButton maximizar;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton3;
        private Guna.UI2.WinForms.Guna2ImageButton salir;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel contenedordeForm;
        private Guna.UI2.WinForms.Guna2GradientButton btnUsuario;
        private Guna.UI2.WinForms.Guna2GradientButton btnproducto;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblUserlogin;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton1;
    }
}

