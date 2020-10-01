namespace Facturacion
{
    partial class Dashboard
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnMinize = new System.Windows.Forms.PictureBox();
            this.btnNormal = new System.Windows.Forms.PictureBox();
            this.bntMaximize = new System.Windows.Forms.PictureBox();
            this.btnclose = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnMenu = new System.Windows.Forms.Button();
            this.panelSidebar = new System.Windows.Forms.Panel();
            this.SubmenuCompras = new System.Windows.Forms.Panel();
            this.iconButton4 = new FontAwesome.Sharp.IconButton();
            this.iconButtonSmProveedores = new FontAwesome.Sharp.IconButton();
            this.iconBtnSmComprasRight = new FontAwesome.Sharp.IconButton();
            this.iconBtnSmCompras = new FontAwesome.Sharp.IconButton();
            this.btnProductos = new FontAwesome.Sharp.IconButton();
            this.pbProfileMin = new System.Windows.Forms.PictureBox();
            this.lbPerfil = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.lbMenu = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lbMantenimiento = new System.Windows.Forms.Label();
            this.pbProfileMax = new System.Windows.Forms.PictureBox();
            this.iconButton5 = new FontAwesome.Sharp.IconButton();
            this.bntCompras = new FontAwesome.Sharp.IconButton();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.btnConfiguracion = new FontAwesome.Sharp.IconButton();
            this.btnPrincipal = new FontAwesome.Sharp.IconButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblFormulario = new System.Windows.Forms.Label();
            this.panelPrincipal = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnNormal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bntMaximize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnclose)).BeginInit();
            this.panelSidebar.SuspendLayout();
            this.SubmenuCompras.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbProfileMin)).BeginInit();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbProfileMax)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(87)))), ((int)(((byte)(155)))));
            this.panel1.Controls.Add(this.btnMinize);
            this.panel1.Controls.Add(this.btnNormal);
            this.panel1.Controls.Add(this.bntMaximize);
            this.panel1.Controls.Add(this.btnclose);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1350, 41);
            this.panel1.TabIndex = 2;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // btnMinize
            // 
            this.btnMinize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinize.BackColor = System.Drawing.Color.Transparent;
            this.btnMinize.Image = global::Facturacion.Properties.Resources.minimize;
            this.btnMinize.Location = new System.Drawing.Point(1250, 6);
            this.btnMinize.Margin = new System.Windows.Forms.Padding(2);
            this.btnMinize.Name = "btnMinize";
            this.btnMinize.Size = new System.Drawing.Size(27, 26);
            this.btnMinize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnMinize.TabIndex = 2;
            this.btnMinize.TabStop = false;
            this.btnMinize.Click += new System.EventHandler(this.btnMinize_Click);
            // 
            // btnNormal
            // 
            this.btnNormal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNormal.BackColor = System.Drawing.Color.Transparent;
            this.btnNormal.Image = global::Facturacion.Properties.Resources.maximize;
            this.btnNormal.Location = new System.Drawing.Point(1283, 5);
            this.btnNormal.Margin = new System.Windows.Forms.Padding(2);
            this.btnNormal.Name = "btnNormal";
            this.btnNormal.Size = new System.Drawing.Size(27, 26);
            this.btnNormal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnNormal.TabIndex = 2;
            this.btnNormal.TabStop = false;
            this.btnNormal.Visible = false;
            this.btnNormal.Click += new System.EventHandler(this.btnNormal_Click);
            // 
            // bntMaximize
            // 
            this.bntMaximize.BackColor = System.Drawing.Color.Transparent;
            this.bntMaximize.Image = global::Facturacion.Properties.Resources.maximize;
            this.bntMaximize.Location = new System.Drawing.Point(1283, 7);
            this.bntMaximize.Margin = new System.Windows.Forms.Padding(2);
            this.bntMaximize.Name = "bntMaximize";
            this.bntMaximize.Size = new System.Drawing.Size(27, 26);
            this.bntMaximize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bntMaximize.TabIndex = 2;
            this.bntMaximize.TabStop = false;
            this.bntMaximize.Click += new System.EventHandler(this.bntMaximize_Click);
            // 
            // btnclose
            // 
            this.btnclose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnclose.BackColor = System.Drawing.Color.Transparent;
            this.btnclose.Image = global::Facturacion.Properties.Resources.close;
            this.btnclose.Location = new System.Drawing.Point(1314, 6);
            this.btnclose.Margin = new System.Windows.Forms.Padding(2);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(27, 26);
            this.btnclose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnclose.TabIndex = 2;
            this.btnclose.TabStop = false;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.Transparent;
            this.button1.Location = new System.Drawing.Point(184, 10);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(24, 23);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Ebrima", 14F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(19, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "ADMIN PANEL";
            // 
            // btnMenu
            // 
            this.btnMenu.BackColor = System.Drawing.Color.Transparent;
            this.btnMenu.BackgroundImage = global::Facturacion.Properties.Resources.hamburger;
            this.btnMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMenu.FlatAppearance.BorderSize = 0;
            this.btnMenu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnMenu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenu.Location = new System.Drawing.Point(200, 4);
            this.btnMenu.Margin = new System.Windows.Forms.Padding(2);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(24, 30);
            this.btnMenu.TabIndex = 3;
            this.btnMenu.UseVisualStyleBackColor = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // panelSidebar
            // 
            this.panelSidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(61)))), ((int)(((byte)(98)))));
            this.panelSidebar.Controls.Add(this.btnMenu);
            this.panelSidebar.Controls.Add(this.SubmenuCompras);
            this.panelSidebar.Controls.Add(this.iconBtnSmComprasRight);
            this.panelSidebar.Controls.Add(this.iconBtnSmCompras);
            this.panelSidebar.Controls.Add(this.btnProductos);
            this.panelSidebar.Controls.Add(this.pbProfileMin);
            this.panelSidebar.Controls.Add(this.lbPerfil);
            this.panelSidebar.Controls.Add(this.panel6);
            this.panelSidebar.Controls.Add(this.panel5);
            this.panelSidebar.Controls.Add(this.pbProfileMax);
            this.panelSidebar.Controls.Add(this.iconButton5);
            this.panelSidebar.Controls.Add(this.bntCompras);
            this.panelSidebar.Controls.Add(this.iconButton2);
            this.panelSidebar.Controls.Add(this.btnConfiguracion);
            this.panelSidebar.Controls.Add(this.btnPrincipal);
            this.panelSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSidebar.Location = new System.Drawing.Point(0, 41);
            this.panelSidebar.Margin = new System.Windows.Forms.Padding(2);
            this.panelSidebar.Name = "panelSidebar";
            this.panelSidebar.Size = new System.Drawing.Size(230, 747);
            this.panelSidebar.TabIndex = 3;
            // 
            // SubmenuCompras
            // 
            this.SubmenuCompras.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(61)))), ((int)(((byte)(98)))));
            this.SubmenuCompras.Controls.Add(this.iconButton4);
            this.SubmenuCompras.Controls.Add(this.iconButtonSmProveedores);
            this.SubmenuCompras.Location = new System.Drawing.Point(44, 438);
            this.SubmenuCompras.Margin = new System.Windows.Forms.Padding(2);
            this.SubmenuCompras.Name = "SubmenuCompras";
            this.SubmenuCompras.Size = new System.Drawing.Size(164, 80);
            this.SubmenuCompras.TabIndex = 5;
            this.SubmenuCompras.Visible = false;
            // 
            // iconButton4
            // 
            this.iconButton4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.iconButton4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButton4.FlatAppearance.BorderSize = 0;
            this.iconButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton4.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButton4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton4.ForeColor = System.Drawing.Color.White;
            this.iconButton4.IconChar = FontAwesome.Sharp.IconChar.LongArrowAltRight;
            this.iconButton4.IconColor = System.Drawing.Color.White;
            this.iconButton4.IconSize = 30;
            this.iconButton4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton4.Location = new System.Drawing.Point(4, 38);
            this.iconButton4.Margin = new System.Windows.Forms.Padding(2);
            this.iconButton4.Name = "iconButton4";
            this.iconButton4.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.iconButton4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.iconButton4.Rotation = 0D;
            this.iconButton4.Size = new System.Drawing.Size(154, 36);
            this.iconButton4.TabIndex = 1;
            this.iconButton4.Text = "   Realizar Compra";
            this.iconButton4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton4.UseVisualStyleBackColor = true;
            this.iconButton4.Click += new System.EventHandler(this.iconButton4_Click);
            // 
            // iconButtonSmProveedores
            // 
            this.iconButtonSmProveedores.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.iconButtonSmProveedores.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButtonSmProveedores.FlatAppearance.BorderSize = 0;
            this.iconButtonSmProveedores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonSmProveedores.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButtonSmProveedores.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonSmProveedores.ForeColor = System.Drawing.Color.White;
            this.iconButtonSmProveedores.IconChar = FontAwesome.Sharp.IconChar.LongArrowAltRight;
            this.iconButtonSmProveedores.IconColor = System.Drawing.Color.White;
            this.iconButtonSmProveedores.IconSize = 30;
            this.iconButtonSmProveedores.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonSmProveedores.Location = new System.Drawing.Point(2, 6);
            this.iconButtonSmProveedores.Margin = new System.Windows.Forms.Padding(2);
            this.iconButtonSmProveedores.Name = "iconButtonSmProveedores";
            this.iconButtonSmProveedores.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.iconButtonSmProveedores.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.iconButtonSmProveedores.Rotation = 0D;
            this.iconButtonSmProveedores.Size = new System.Drawing.Size(156, 28);
            this.iconButtonSmProveedores.TabIndex = 1;
            this.iconButtonSmProveedores.Text = "   Proveedores";
            this.iconButtonSmProveedores.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonSmProveedores.UseVisualStyleBackColor = true;
            this.iconButtonSmProveedores.Click += new System.EventHandler(this.iconButtonSmProveedores_Click);
            // 
            // iconBtnSmComprasRight
            // 
            this.iconBtnSmComprasRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(61)))), ((int)(((byte)(98)))));
            this.iconBtnSmComprasRight.FlatAppearance.BorderSize = 0;
            this.iconBtnSmComprasRight.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.iconBtnSmComprasRight.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(89)))), ((int)(((byte)(110)))));
            this.iconBtnSmComprasRight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconBtnSmComprasRight.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconBtnSmComprasRight.IconChar = FontAwesome.Sharp.IconChar.AngleRight;
            this.iconBtnSmComprasRight.IconColor = System.Drawing.Color.White;
            this.iconBtnSmComprasRight.IconSize = 25;
            this.iconBtnSmComprasRight.Location = new System.Drawing.Point(156, 397);
            this.iconBtnSmComprasRight.Margin = new System.Windows.Forms.Padding(2);
            this.iconBtnSmComprasRight.Name = "iconBtnSmComprasRight";
            this.iconBtnSmComprasRight.Rotation = 0D;
            this.iconBtnSmComprasRight.Size = new System.Drawing.Size(28, 36);
            this.iconBtnSmComprasRight.TabIndex = 0;
            this.iconBtnSmComprasRight.UseVisualStyleBackColor = false;
            this.iconBtnSmComprasRight.Click += new System.EventHandler(this.iconBtnSmComprasRight_Click);
            // 
            // iconBtnSmCompras
            // 
            this.iconBtnSmCompras.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(61)))), ((int)(((byte)(98)))));
            this.iconBtnSmCompras.FlatAppearance.BorderSize = 0;
            this.iconBtnSmCompras.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.iconBtnSmCompras.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(89)))), ((int)(((byte)(110)))));
            this.iconBtnSmCompras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconBtnSmCompras.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconBtnSmCompras.IconChar = FontAwesome.Sharp.IconChar.AngleDown;
            this.iconBtnSmCompras.IconColor = System.Drawing.Color.White;
            this.iconBtnSmCompras.IconSize = 25;
            this.iconBtnSmCompras.Location = new System.Drawing.Point(188, 397);
            this.iconBtnSmCompras.Margin = new System.Windows.Forms.Padding(2);
            this.iconBtnSmCompras.Name = "iconBtnSmCompras";
            this.iconBtnSmCompras.Rotation = 0D;
            this.iconBtnSmCompras.Size = new System.Drawing.Size(28, 36);
            this.iconBtnSmCompras.TabIndex = 0;
            this.iconBtnSmCompras.UseVisualStyleBackColor = false;
            this.iconBtnSmCompras.Visible = false;
            this.iconBtnSmCompras.Click += new System.EventHandler(this.iconBtnSmCompras_Click);
            // 
            // btnProductos
            // 
            this.btnProductos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProductos.FlatAppearance.BorderSize = 0;
            this.btnProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProductos.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnProductos.Font = new System.Drawing.Font("Ebrima", 14F);
            this.btnProductos.ForeColor = System.Drawing.Color.White;
            this.btnProductos.IconChar = FontAwesome.Sharp.IconChar.Boxes;
            this.btnProductos.IconColor = System.Drawing.Color.White;
            this.btnProductos.IconSize = 30;
            this.btnProductos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProductos.Location = new System.Drawing.Point(2, 533);
            this.btnProductos.Margin = new System.Windows.Forms.Padding(2);
            this.btnProductos.Name = "btnProductos";
            this.btnProductos.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.btnProductos.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnProductos.Rotation = 0D;
            this.btnProductos.Size = new System.Drawing.Size(211, 41);
            this.btnProductos.TabIndex = 0;
            this.btnProductos.Text = "  Productos";
            this.btnProductos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnProductos.UseVisualStyleBackColor = true;
            this.btnProductos.Click += new System.EventHandler(this.btnProductos_Click);
            // 
            // pbProfileMin
            // 
            this.pbProfileMin.Image = global::Facturacion.Properties.Resources.user;
            this.pbProfileMin.Location = new System.Drawing.Point(18, 95);
            this.pbProfileMin.Margin = new System.Windows.Forms.Padding(2);
            this.pbProfileMin.Name = "pbProfileMin";
            this.pbProfileMin.Size = new System.Drawing.Size(34, 36);
            this.pbProfileMin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbProfileMin.TabIndex = 4;
            this.pbProfileMin.TabStop = false;
            this.pbProfileMin.Visible = false;
            // 
            // lbPerfil
            // 
            this.lbPerfil.AutoSize = true;
            this.lbPerfil.Font = new System.Drawing.Font("Ebrima", 14F);
            this.lbPerfil.ForeColor = System.Drawing.Color.White;
            this.lbPerfil.Location = new System.Drawing.Point(39, 138);
            this.lbPerfil.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbPerfil.Name = "lbPerfil";
            this.lbPerfil.Size = new System.Drawing.Size(132, 25);
            this.lbPerfil.TabIndex = 3;
            this.lbPerfil.Text = "Administrador";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.lbMenu);
            this.panel6.Location = new System.Drawing.Point(0, 165);
            this.panel6.Margin = new System.Windows.Forms.Padding(2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(184, 39);
            this.panel6.TabIndex = 2;
            // 
            // lbMenu
            // 
            this.lbMenu.AutoSize = true;
            this.lbMenu.ForeColor = System.Drawing.Color.White;
            this.lbMenu.Location = new System.Drawing.Point(2, 7);
            this.lbMenu.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbMenu.Name = "lbMenu";
            this.lbMenu.Size = new System.Drawing.Size(34, 13);
            this.lbMenu.TabIndex = 1;
            this.lbMenu.Text = "Menu";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.lbMantenimiento);
            this.panel5.Location = new System.Drawing.Point(0, 299);
            this.panel5.Margin = new System.Windows.Forms.Padding(2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(180, 39);
            this.panel5.TabIndex = 2;
            // 
            // lbMantenimiento
            // 
            this.lbMantenimiento.AutoSize = true;
            this.lbMantenimiento.ForeColor = System.Drawing.Color.White;
            this.lbMantenimiento.Location = new System.Drawing.Point(2, 11);
            this.lbMantenimiento.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbMantenimiento.Name = "lbMantenimiento";
            this.lbMantenimiento.Size = new System.Drawing.Size(76, 13);
            this.lbMantenimiento.TabIndex = 0;
            this.lbMantenimiento.Text = "Mantenimiento";
            // 
            // pbProfileMax
            // 
            this.pbProfileMax.Image = global::Facturacion.Properties.Resources.user;
            this.pbProfileMax.Location = new System.Drawing.Point(61, 37);
            this.pbProfileMax.Margin = new System.Windows.Forms.Padding(2);
            this.pbProfileMax.Name = "pbProfileMax";
            this.pbProfileMax.Size = new System.Drawing.Size(91, 94);
            this.pbProfileMax.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbProfileMax.TabIndex = 1;
            this.pbProfileMax.TabStop = false;
            // 
            // iconButton5
            // 
            this.iconButton5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.iconButton5.FlatAppearance.BorderSize = 0;
            this.iconButton5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton5.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButton5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton5.ForeColor = System.Drawing.Color.White;
            this.iconButton5.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.iconButton5.IconColor = System.Drawing.Color.White;
            this.iconButton5.IconSize = 30;
            this.iconButton5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton5.Location = new System.Drawing.Point(0, 699);
            this.iconButton5.Margin = new System.Windows.Forms.Padding(2);
            this.iconButton5.Name = "iconButton5";
            this.iconButton5.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.iconButton5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.iconButton5.Rotation = 0D;
            this.iconButton5.Size = new System.Drawing.Size(230, 48);
            this.iconButton5.TabIndex = 0;
            this.iconButton5.Text = "   SALIR";
            this.iconButton5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton5.UseVisualStyleBackColor = true;
            this.iconButton5.Click += new System.EventHandler(this.iconButton5_Click);
            // 
            // bntCompras
            // 
            this.bntCompras.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bntCompras.FlatAppearance.BorderSize = 0;
            this.bntCompras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntCompras.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.bntCompras.Font = new System.Drawing.Font("Ebrima", 14F);
            this.bntCompras.ForeColor = System.Drawing.Color.White;
            this.bntCompras.IconChar = FontAwesome.Sharp.IconChar.Truck;
            this.bntCompras.IconColor = System.Drawing.Color.White;
            this.bntCompras.IconSize = 30;
            this.bntCompras.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bntCompras.Location = new System.Drawing.Point(1, 392);
            this.bntCompras.Margin = new System.Windows.Forms.Padding(2);
            this.bntCompras.Name = "bntCompras";
            this.bntCompras.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.bntCompras.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bntCompras.Rotation = 0D;
            this.bntCompras.Size = new System.Drawing.Size(170, 41);
            this.bntCompras.TabIndex = 0;
            this.bntCompras.Text = "  Compras";
            this.bntCompras.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bntCompras.UseVisualStyleBackColor = true;
            this.bntCompras.Click += new System.EventHandler(this.bntCompras_Click);
            // 
            // iconButton2
            // 
            this.iconButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButton2.FlatAppearance.BorderSize = 0;
            this.iconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton2.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButton2.Font = new System.Drawing.Font("Ebrima", 14F);
            this.iconButton2.ForeColor = System.Drawing.Color.White;
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.UserTie;
            this.iconButton2.IconColor = System.Drawing.Color.White;
            this.iconButton2.IconSize = 30;
            this.iconButton2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton2.Location = new System.Drawing.Point(2, 341);
            this.iconButton2.Margin = new System.Windows.Forms.Padding(2);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.iconButton2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.iconButton2.Rotation = 0D;
            this.iconButton2.Size = new System.Drawing.Size(207, 41);
            this.iconButton2.TabIndex = 0;
            this.iconButton2.Text = "  Empleados";
            this.iconButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton2.UseVisualStyleBackColor = true;
            // 
            // btnConfiguracion
            // 
            this.btnConfiguracion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfiguracion.FlatAppearance.BorderSize = 0;
            this.btnConfiguracion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfiguracion.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnConfiguracion.Font = new System.Drawing.Font("Ebrima", 14F);
            this.btnConfiguracion.ForeColor = System.Drawing.Color.White;
            this.btnConfiguracion.IconChar = FontAwesome.Sharp.IconChar.UserCog;
            this.btnConfiguracion.IconColor = System.Drawing.Color.White;
            this.btnConfiguracion.IconSize = 30;
            this.btnConfiguracion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConfiguracion.Location = new System.Drawing.Point(2, 258);
            this.btnConfiguracion.Margin = new System.Windows.Forms.Padding(2);
            this.btnConfiguracion.Name = "btnConfiguracion";
            this.btnConfiguracion.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.btnConfiguracion.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnConfiguracion.Rotation = 0D;
            this.btnConfiguracion.Size = new System.Drawing.Size(212, 41);
            this.btnConfiguracion.TabIndex = 0;
            this.btnConfiguracion.Text = "  Configuración";
            this.btnConfiguracion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnConfiguracion.UseVisualStyleBackColor = true;
            this.btnConfiguracion.Click += new System.EventHandler(this.btnConfiguracion_Click);
            // 
            // btnPrincipal
            // 
            this.btnPrincipal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrincipal.FlatAppearance.BorderSize = 0;
            this.btnPrincipal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrincipal.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnPrincipal.Font = new System.Drawing.Font("Ebrima", 14F);
            this.btnPrincipal.ForeColor = System.Drawing.Color.White;
            this.btnPrincipal.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.btnPrincipal.IconColor = System.Drawing.Color.White;
            this.btnPrincipal.IconSize = 30;
            this.btnPrincipal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrincipal.Location = new System.Drawing.Point(2, 207);
            this.btnPrincipal.Margin = new System.Windows.Forms.Padding(2);
            this.btnPrincipal.Name = "btnPrincipal";
            this.btnPrincipal.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.btnPrincipal.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnPrincipal.Rotation = 0D;
            this.btnPrincipal.Size = new System.Drawing.Size(212, 41);
            this.btnPrincipal.TabIndex = 0;
            this.btnPrincipal.Text = "  Principal";
            this.btnPrincipal.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPrincipal.UseVisualStyleBackColor = true;
            this.btnPrincipal.Click += new System.EventHandler(this.btnPrincipal_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.lblFormulario);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(230, 41);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1120, 41);
            this.panel3.TabIndex = 4;
            // 
            // lblFormulario
            // 
            this.lblFormulario.AutoSize = true;
            this.lblFormulario.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormulario.ForeColor = System.Drawing.Color.Black;
            this.lblFormulario.Location = new System.Drawing.Point(10, 8);
            this.lblFormulario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFormulario.Name = "lblFormulario";
            this.lblFormulario.Size = new System.Drawing.Size(120, 21);
            this.lblFormulario.TabIndex = 0;
            this.lblFormulario.Text = "Pagina Principal";
            // 
            // panelPrincipal
            // 
            this.panelPrincipal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(246)))));
            this.panelPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPrincipal.Location = new System.Drawing.Point(230, 82);
            this.panelPrincipal.Margin = new System.Windows.Forms.Padding(2);
            this.panelPrincipal.Name = "panelPrincipal";
            this.panelPrincipal.Size = new System.Drawing.Size(1120, 706);
            this.panelPrincipal.TabIndex = 5;
            this.panelPrincipal.Paint += new System.Windows.Forms.PaintEventHandler(this.panelPrincipal_Paint);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1350, 788);
            this.Controls.Add(this.panelPrincipal);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panelSidebar);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Dashboard";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnNormal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bntMaximize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnclose)).EndInit();
            this.panelSidebar.ResumeLayout(false);
            this.panelSidebar.PerformLayout();
            this.SubmenuCompras.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbProfileMin)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbProfileMax)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelSidebar;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblFormulario;
        private FontAwesome.Sharp.IconButton btnPrincipal;
        private System.Windows.Forms.PictureBox pbProfileMax;
        private FontAwesome.Sharp.IconButton iconButton5;
        private FontAwesome.Sharp.IconButton btnProductos;
        private FontAwesome.Sharp.IconButton iconButton2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lbMantenimiento;
        private System.Windows.Forms.Panel panel6;
        private FontAwesome.Sharp.IconButton btnConfiguracion;
        private System.Windows.Forms.Label lbPerfil;
        private System.Windows.Forms.PictureBox btnclose;
        private System.Windows.Forms.PictureBox btnMinize;
        private System.Windows.Forms.PictureBox bntMaximize;
        private System.Windows.Forms.Panel panelPrincipal;
        private System.Windows.Forms.PictureBox btnNormal;
        private System.Windows.Forms.Label lbMenu;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.PictureBox pbProfileMin;
        private System.Windows.Forms.Panel SubmenuCompras;
        private FontAwesome.Sharp.IconButton iconButtonSmProveedores;
        private FontAwesome.Sharp.IconButton iconButton4;
        private FontAwesome.Sharp.IconButton iconBtnSmCompras;
        private FontAwesome.Sharp.IconButton iconBtnSmComprasRight;
        private FontAwesome.Sharp.IconButton bntCompras;
    }
}

