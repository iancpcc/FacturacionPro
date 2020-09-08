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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panelSidebar = new System.Windows.Forms.Panel();
            this.SubmenuCompras = new System.Windows.Forms.Panel();
            this.lbPerfil = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.lbMenu = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lbMantenimiento = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblFormulario = new System.Windows.Forms.Label();
            this.panelPrincipal = new System.Windows.Forms.Panel();
            this.btnProductos = new FontAwesome.Sharp.IconButton();
            this.iconButton4 = new FontAwesome.Sharp.IconButton();
            this.iconButtonSmProveedores = new FontAwesome.Sharp.IconButton();
            this.pbProfileMin = new System.Windows.Forms.PictureBox();
            this.pbProfileMax = new System.Windows.Forms.PictureBox();
            this.iconButton5 = new FontAwesome.Sharp.IconButton();
            this.btnCompras = new FontAwesome.Sharp.IconButton();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.iconButton6 = new FontAwesome.Sharp.IconButton();
            this.btnPrincipal = new FontAwesome.Sharp.IconButton();
            this.btnMenu = new System.Windows.Forms.Button();
            this.btnMinize = new System.Windows.Forms.PictureBox();
            this.btnNormal = new System.Windows.Forms.PictureBox();
            this.bntMaximize = new System.Windows.Forms.PictureBox();
            this.btnclose = new System.Windows.Forms.PictureBox();
            this.iconBtnSmCompras = new FontAwesome.Sharp.IconButton();
            this.iconBtnSmComprasRight = new FontAwesome.Sharp.IconButton();
            this.panel1.SuspendLayout();
            this.panelSidebar.SuspendLayout();
            this.SubmenuCompras.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbProfileMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbProfileMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnNormal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bntMaximize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnclose)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(87)))), ((int)(((byte)(155)))));
            this.panel1.Controls.Add(this.btnMenu);
            this.panel1.Controls.Add(this.btnMinize);
            this.panel1.Controls.Add(this.btnNormal);
            this.panel1.Controls.Add(this.bntMaximize);
            this.panel1.Controls.Add(this.btnclose);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1300, 50);
            this.panel1.TabIndex = 2;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
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
            this.button1.Location = new System.Drawing.Point(245, 12);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(32, 28);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(25, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "ADMIN PANEL";
            // 
            // panelSidebar
            // 
            this.panelSidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.panelSidebar.Controls.Add(this.iconBtnSmComprasRight);
            this.panelSidebar.Controls.Add(this.iconBtnSmCompras);
            this.panelSidebar.Controls.Add(this.btnProductos);
            this.panelSidebar.Controls.Add(this.SubmenuCompras);
            this.panelSidebar.Controls.Add(this.pbProfileMin);
            this.panelSidebar.Controls.Add(this.lbPerfil);
            this.panelSidebar.Controls.Add(this.panel6);
            this.panelSidebar.Controls.Add(this.panel5);
            this.panelSidebar.Controls.Add(this.pbProfileMax);
            this.panelSidebar.Controls.Add(this.iconButton5);
            this.panelSidebar.Controls.Add(this.btnCompras);
            this.panelSidebar.Controls.Add(this.iconButton2);
            this.panelSidebar.Controls.Add(this.iconButton6);
            this.panelSidebar.Controls.Add(this.btnPrincipal);
            this.panelSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSidebar.Location = new System.Drawing.Point(0, 50);
            this.panelSidebar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelSidebar.Name = "panelSidebar";
            this.panelSidebar.Size = new System.Drawing.Size(245, 800);
            this.panelSidebar.TabIndex = 3;
            // 
            // SubmenuCompras
            // 
            this.SubmenuCompras.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.SubmenuCompras.Controls.Add(this.iconButton4);
            this.SubmenuCompras.Controls.Add(this.iconButtonSmProveedores);
            this.SubmenuCompras.Location = new System.Drawing.Point(43, 538);
            this.SubmenuCompras.Name = "SubmenuCompras";
            this.SubmenuCompras.Size = new System.Drawing.Size(202, 93);
            this.SubmenuCompras.TabIndex = 5;
            this.SubmenuCompras.Visible = false;
            // 
            // lbPerfil
            // 
            this.lbPerfil.AutoSize = true;
            this.lbPerfil.ForeColor = System.Drawing.Color.White;
            this.lbPerfil.Location = new System.Drawing.Point(55, 173);
            this.lbPerfil.Name = "lbPerfil";
            this.lbPerfil.Size = new System.Drawing.Size(95, 17);
            this.lbPerfil.TabIndex = 3;
            this.lbPerfil.Text = "Administrador";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.lbMenu);
            this.panel6.Location = new System.Drawing.Point(0, 203);
            this.panel6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(245, 48);
            this.panel6.TabIndex = 2;
            // 
            // lbMenu
            // 
            this.lbMenu.AutoSize = true;
            this.lbMenu.ForeColor = System.Drawing.Color.White;
            this.lbMenu.Location = new System.Drawing.Point(3, 9);
            this.lbMenu.Name = "lbMenu";
            this.lbMenu.Size = new System.Drawing.Size(43, 17);
            this.lbMenu.TabIndex = 1;
            this.lbMenu.Text = "Menu";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.lbMantenimiento);
            this.panel5.Location = new System.Drawing.Point(0, 368);
            this.panel5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(240, 48);
            this.panel5.TabIndex = 2;
            // 
            // lbMantenimiento
            // 
            this.lbMantenimiento.AutoSize = true;
            this.lbMantenimiento.ForeColor = System.Drawing.Color.White;
            this.lbMantenimiento.Location = new System.Drawing.Point(3, 13);
            this.lbMantenimiento.Name = "lbMantenimiento";
            this.lbMantenimiento.Size = new System.Drawing.Size(100, 17);
            this.lbMantenimiento.TabIndex = 0;
            this.lbMantenimiento.Text = "Mantenimiento";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.lblFormulario);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(245, 50);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1055, 50);
            this.panel3.TabIndex = 4;
            // 
            // lblFormulario
            // 
            this.lblFormulario.AutoSize = true;
            this.lblFormulario.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormulario.ForeColor = System.Drawing.Color.Black;
            this.lblFormulario.Location = new System.Drawing.Point(13, 10);
            this.lblFormulario.Name = "lblFormulario";
            this.lblFormulario.Size = new System.Drawing.Size(150, 28);
            this.lblFormulario.TabIndex = 0;
            this.lblFormulario.Text = "Pagina Principal";
            // 
            // panelPrincipal
            // 
            this.panelPrincipal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(246)))));
            this.panelPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPrincipal.Location = new System.Drawing.Point(245, 100);
            this.panelPrincipal.Name = "panelPrincipal";
            this.panelPrincipal.Size = new System.Drawing.Size(1055, 750);
            this.panelPrincipal.TabIndex = 5;
            // 
            // btnProductos
            // 
            this.btnProductos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProductos.FlatAppearance.BorderSize = 0;
            this.btnProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProductos.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnProductos.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProductos.ForeColor = System.Drawing.Color.White;
            this.btnProductos.IconChar = FontAwesome.Sharp.IconChar.Boxes;
            this.btnProductos.IconColor = System.Drawing.Color.White;
            this.btnProductos.IconSize = 30;
            this.btnProductos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProductos.Location = new System.Drawing.Point(3, 636);
            this.btnProductos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnProductos.Name = "btnProductos";
            this.btnProductos.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.btnProductos.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnProductos.Rotation = 0D;
            this.btnProductos.Size = new System.Drawing.Size(239, 50);
            this.btnProductos.TabIndex = 0;
            this.btnProductos.Text = "   Productos";
            this.btnProductos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnProductos.UseVisualStyleBackColor = true;
            //this.btnProductos.Click += new System.EventHandler(this.btnProductos_Click);
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
            this.iconButton4.Location = new System.Drawing.Point(3, 51);
            this.iconButton4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.iconButton4.Name = "iconButton4";
            this.iconButton4.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.iconButton4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.iconButton4.Rotation = 0D;
            this.iconButton4.Size = new System.Drawing.Size(194, 34);
            this.iconButton4.TabIndex = 1;
            this.iconButton4.Text = "   Realizar Compra";
            this.iconButton4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton4.UseVisualStyleBackColor = true;
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
            this.iconButtonSmProveedores.Location = new System.Drawing.Point(3, 8);
            this.iconButtonSmProveedores.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.iconButtonSmProveedores.Name = "iconButtonSmProveedores";
            this.iconButtonSmProveedores.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.iconButtonSmProveedores.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.iconButtonSmProveedores.Rotation = 0D;
            this.iconButtonSmProveedores.Size = new System.Drawing.Size(193, 34);
            this.iconButtonSmProveedores.TabIndex = 1;
            this.iconButtonSmProveedores.Text = "   Proveedores";
            this.iconButtonSmProveedores.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonSmProveedores.UseVisualStyleBackColor = true;
            this.iconButtonSmProveedores.Click += new System.EventHandler(this.iconButtonSmProveedores_Click);
            // 
            // pbProfileMin
            // 
            this.pbProfileMin.Image = global::Facturacion.Properties.Resources.user;
            this.pbProfileMin.Location = new System.Drawing.Point(12, 117);
            this.pbProfileMin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbProfileMin.Name = "pbProfileMin";
            this.pbProfileMin.Size = new System.Drawing.Size(45, 44);
            this.pbProfileMin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbProfileMin.TabIndex = 4;
            this.pbProfileMin.TabStop = false;
            this.pbProfileMin.Visible = false;
            // 
            // pbProfileMax
            // 
            this.pbProfileMax.Image = global::Facturacion.Properties.Resources.user;
            this.pbProfileMax.Location = new System.Drawing.Point(43, 44);
            this.pbProfileMax.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbProfileMax.Name = "pbProfileMax";
            this.pbProfileMax.Size = new System.Drawing.Size(121, 116);
            this.pbProfileMax.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbProfileMax.TabIndex = 1;
            this.pbProfileMax.TabStop = false;
            // 
            // iconButton5
            // 
            this.iconButton5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.iconButton5.FlatAppearance.BorderSize = 0;
            this.iconButton5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton5.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButton5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton5.ForeColor = System.Drawing.Color.White;
            this.iconButton5.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.iconButton5.IconColor = System.Drawing.Color.White;
            this.iconButton5.IconSize = 30;
            this.iconButton5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton5.Location = new System.Drawing.Point(3, 738);
            this.iconButton5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.iconButton5.Name = "iconButton5";
            this.iconButton5.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.iconButton5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.iconButton5.Rotation = 0D;
            this.iconButton5.Size = new System.Drawing.Size(240, 50);
            this.iconButton5.TabIndex = 0;
            this.iconButton5.Text = "   SALIR";
            this.iconButton5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton5.UseVisualStyleBackColor = true;
            this.iconButton5.Click += new System.EventHandler(this.iconButton5_Click);
            // 
            // btnCompras
            // 
            this.btnCompras.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCompras.FlatAppearance.BorderSize = 0;
            this.btnCompras.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.btnCompras.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(89)))), ((int)(((byte)(110)))));
            this.btnCompras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCompras.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnCompras.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCompras.ForeColor = System.Drawing.Color.White;
            this.btnCompras.IconChar = FontAwesome.Sharp.IconChar.Truck;
            this.btnCompras.IconColor = System.Drawing.Color.White;
            this.btnCompras.IconSize = 30;
            this.btnCompras.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCompras.Location = new System.Drawing.Point(3, 483);
            this.btnCompras.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCompras.Name = "btnCompras";
            this.btnCompras.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.btnCompras.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnCompras.Rotation = 0D;
            this.btnCompras.Size = new System.Drawing.Size(202, 50);
            this.btnCompras.TabIndex = 0;
            this.btnCompras.Text = "   Compras";
            this.btnCompras.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCompras.UseVisualStyleBackColor = true;
            this.btnCompras.Click += new System.EventHandler(this.btnCompras_Click);
            this.btnCompras.MouseLeave += new System.EventHandler(this.btnCompras_MouseLeave);
            this.btnCompras.MouseHover += new System.EventHandler(this.btnCompras_MouseHover);
            // 
            // iconButton2
            // 
            this.iconButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButton2.FlatAppearance.BorderSize = 0;
            this.iconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton2.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButton2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton2.ForeColor = System.Drawing.Color.White;
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.UserTie;
            this.iconButton2.IconColor = System.Drawing.Color.White;
            this.iconButton2.IconSize = 30;
            this.iconButton2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton2.Location = new System.Drawing.Point(6, 420);
            this.iconButton2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.iconButton2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.iconButton2.Rotation = 0D;
            this.iconButton2.Size = new System.Drawing.Size(233, 50);
            this.iconButton2.TabIndex = 0;
            this.iconButton2.Text = "   Empleados";
            this.iconButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton2.UseVisualStyleBackColor = true;
            // 
            // iconButton6
            // 
            this.iconButton6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButton6.FlatAppearance.BorderSize = 0;
            this.iconButton6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton6.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButton6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton6.ForeColor = System.Drawing.Color.White;
            this.iconButton6.IconChar = FontAwesome.Sharp.IconChar.UserCog;
            this.iconButton6.IconColor = System.Drawing.Color.White;
            this.iconButton6.IconSize = 30;
            this.iconButton6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton6.Location = new System.Drawing.Point(3, 318);
            this.iconButton6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.iconButton6.Name = "iconButton6";
            this.iconButton6.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.iconButton6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.iconButton6.Rotation = 0D;
            this.iconButton6.Size = new System.Drawing.Size(240, 50);
            this.iconButton6.TabIndex = 0;
            this.iconButton6.Text = "   Configuración";
            this.iconButton6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton6.UseVisualStyleBackColor = true;
            this.iconButton6.Click += new System.EventHandler(this.iconButton6_Click);
            // 
            // btnPrincipal
            // 
            this.btnPrincipal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrincipal.FlatAppearance.BorderSize = 0;
            this.btnPrincipal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrincipal.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnPrincipal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrincipal.ForeColor = System.Drawing.Color.White;
            this.btnPrincipal.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.btnPrincipal.IconColor = System.Drawing.Color.White;
            this.btnPrincipal.IconSize = 30;
            this.btnPrincipal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrincipal.Location = new System.Drawing.Point(3, 255);
            this.btnPrincipal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPrincipal.Name = "btnPrincipal";
            this.btnPrincipal.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.btnPrincipal.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnPrincipal.Rotation = 0D;
            this.btnPrincipal.Size = new System.Drawing.Size(240, 50);
            this.btnPrincipal.TabIndex = 0;
            this.btnPrincipal.Text = "   Principal";
            this.btnPrincipal.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPrincipal.UseVisualStyleBackColor = true;
            this.btnPrincipal.Click += new System.EventHandler(this.btnPrincipal_Click);
            // 
            // btnMenu
            // 
            this.btnMenu.BackColor = System.Drawing.Color.Transparent;
            this.btnMenu.BackgroundImage = global::Facturacion.Properties.Resources.hamburger;
            this.btnMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMenu.FlatAppearance.BorderSize = 0;
            this.btnMenu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnMenu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenu.Location = new System.Drawing.Point(245, 12);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(32, 33);
            this.btnMenu.TabIndex = 3;
            this.btnMenu.UseVisualStyleBackColor = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // btnMinize
            // 
            this.btnMinize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinize.BackColor = System.Drawing.Color.Transparent;
            this.btnMinize.Image = global::Facturacion.Properties.Resources.minimize;
            this.btnMinize.Location = new System.Drawing.Point(1167, 8);
            this.btnMinize.Name = "btnMinize";
            this.btnMinize.Size = new System.Drawing.Size(36, 32);
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
            this.btnNormal.Location = new System.Drawing.Point(1209, 8);
            this.btnNormal.Name = "btnNormal";
            this.btnNormal.Size = new System.Drawing.Size(36, 32);
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
            this.bntMaximize.Location = new System.Drawing.Point(1209, 8);
            this.bntMaximize.Name = "bntMaximize";
            this.bntMaximize.Size = new System.Drawing.Size(36, 32);
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
            this.btnclose.Location = new System.Drawing.Point(1252, 8);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(36, 32);
            this.btnclose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnclose.TabIndex = 2;
            this.btnclose.TabStop = false;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // iconBtnSmCompras
            // 
            this.iconBtnSmCompras.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.iconBtnSmCompras.FlatAppearance.BorderSize = 0;
            this.iconBtnSmCompras.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.iconBtnSmCompras.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(89)))), ((int)(((byte)(110)))));
            this.iconBtnSmCompras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconBtnSmCompras.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconBtnSmCompras.IconChar = FontAwesome.Sharp.IconChar.AngleDown;
            this.iconBtnSmCompras.IconColor = System.Drawing.Color.White;
            this.iconBtnSmCompras.IconSize = 25;
            this.iconBtnSmCompras.Location = new System.Drawing.Point(211, 488);
            this.iconBtnSmCompras.Name = "iconBtnSmCompras";
            this.iconBtnSmCompras.Rotation = 0D;
            this.iconBtnSmCompras.Size = new System.Drawing.Size(28, 44);
            this.iconBtnSmCompras.TabIndex = 0;
            this.iconBtnSmCompras.UseVisualStyleBackColor = false;
            this.iconBtnSmCompras.Visible = false;
            this.iconBtnSmCompras.Click += new System.EventHandler(this.iconBtnSmCompras_Click_1);
            this.iconBtnSmCompras.MouseHover += new System.EventHandler(this.iconBtnSmCompras_MouseHover);
            // 
            // iconBtnSmComprasRight
            // 
            this.iconBtnSmComprasRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.iconBtnSmComprasRight.FlatAppearance.BorderSize = 0;
            this.iconBtnSmComprasRight.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.iconBtnSmComprasRight.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(89)))), ((int)(((byte)(110)))));
            this.iconBtnSmComprasRight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconBtnSmComprasRight.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconBtnSmComprasRight.IconChar = FontAwesome.Sharp.IconChar.AngleRight;
            this.iconBtnSmComprasRight.IconColor = System.Drawing.Color.White;
            this.iconBtnSmComprasRight.IconSize = 25;
            this.iconBtnSmComprasRight.Location = new System.Drawing.Point(177, 490);
            this.iconBtnSmComprasRight.Name = "iconBtnSmComprasRight";
            this.iconBtnSmComprasRight.Rotation = 0D;
            this.iconBtnSmComprasRight.Size = new System.Drawing.Size(28, 44);
            this.iconBtnSmComprasRight.TabIndex = 6;
            this.iconBtnSmComprasRight.UseVisualStyleBackColor = false;
            this.iconBtnSmComprasRight.Click += new System.EventHandler(this.iconBtnSmComprasRight_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1300, 850);
            this.Controls.Add(this.panelPrincipal);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panelSidebar);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Dashboard";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelSidebar.ResumeLayout(false);
            this.panelSidebar.PerformLayout();
            this.SubmenuCompras.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbProfileMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbProfileMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnNormal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bntMaximize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnclose)).EndInit();
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
        private FontAwesome.Sharp.IconButton btnCompras;
        private FontAwesome.Sharp.IconButton iconButton2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lbMantenimiento;
        private System.Windows.Forms.Panel panel6;
        private FontAwesome.Sharp.IconButton iconButton6;
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
    }
}

