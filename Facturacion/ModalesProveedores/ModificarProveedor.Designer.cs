namespace Facturacion.ModalesProveedores
{
    partial class ModificarProveedor
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
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGurdar = new System.Windows.Forms.Button();
            this.topBar = new System.Windows.Forms.Panel();
            this.IpClose = new FontAwesome.Sharp.IconPictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtRUC = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.cbEstado = new System.Windows.Forms.ComboBox();
            this.topBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IpClose)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(87)))), ((int)(((byte)(155)))));
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(240, 275);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(110, 41);
            this.btnCancelar.TabIndex = 15;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGurdar
            // 
            this.btnGurdar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(87)))), ((int)(((byte)(155)))));
            this.btnGurdar.FlatAppearance.BorderSize = 0;
            this.btnGurdar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGurdar.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGurdar.ForeColor = System.Drawing.Color.White;
            this.btnGurdar.Location = new System.Drawing.Point(115, 275);
            this.btnGurdar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnGurdar.Name = "btnGurdar";
            this.btnGurdar.Size = new System.Drawing.Size(110, 41);
            this.btnGurdar.TabIndex = 16;
            this.btnGurdar.Text = "Guardar";
            this.btnGurdar.UseVisualStyleBackColor = false;
            this.btnGurdar.Click += new System.EventHandler(this.btnGurdar_Click);
            // 
            // topBar
            // 
            this.topBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(87)))), ((int)(((byte)(155)))));
            this.topBar.Controls.Add(this.IpClose);
            this.topBar.Controls.Add(this.label3);
            this.topBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.topBar.Location = new System.Drawing.Point(0, 0);
            this.topBar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.topBar.Name = "topBar";
            this.topBar.Size = new System.Drawing.Size(450, 32);
            this.topBar.TabIndex = 10;
            this.topBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.topBar_MouseDown);
            // 
            // IpClose
            // 
            this.IpClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(87)))), ((int)(((byte)(155)))));
            this.IpClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.IpClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.IpClose.IconChar = FontAwesome.Sharp.IconChar.WindowClose;
            this.IpClose.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.IpClose.Location = new System.Drawing.Point(416, 0);
            this.IpClose.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.IpClose.Name = "IpClose";
            this.IpClose.Size = new System.Drawing.Size(32, 32);
            this.IpClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.IpClose.TabIndex = 0;
            this.IpClose.TabStop = false;
            this.IpClose.Click += new System.EventHandler(this.IpClose_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(186, 3);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 21);
            this.label3.TabIndex = 0;
            this.label3.Text = "Editar Proveedor";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(53, 212);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 21);
            this.label5.TabIndex = 5;
            this.label5.Text = "Estado";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(53, 150);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 21);
            this.label6.TabIndex = 6;
            this.label6.Text = " RUC";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(53, 181);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 21);
            this.label4.TabIndex = 7;
            this.label4.Text = "Dirección";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(53, 119);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 21);
            this.label2.TabIndex = 8;
            this.label2.Text = "Teléfono";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(53, 88);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 21);
            this.label1.TabIndex = 9;
            this.label1.Text = "Nombre";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(153, 181);
            this.txtDireccion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtDireccion.Multiline = true;
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(208, 27);
            this.txtDireccion.TabIndex = 17;
            // 
            // txtRUC
            // 
            this.txtRUC.Location = new System.Drawing.Point(153, 150);
            this.txtRUC.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtRUC.Multiline = true;
            this.txtRUC.Name = "txtRUC";
            this.txtRUC.Size = new System.Drawing.Size(208, 27);
            this.txtRUC.TabIndex = 18;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(153, 119);
            this.txtTelefono.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTelefono.Multiline = true;
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(208, 27);
            this.txtTelefono.TabIndex = 19;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(153, 88);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNombre.Multiline = true;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(208, 27);
            this.txtNombre.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(53, 57);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(27, 21);
            this.label7.TabIndex = 9;
            this.label7.Text = " Id";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(153, 57);
            this.txtId.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtId.Multiline = true;
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(208, 27);
            this.txtId.TabIndex = 20;
            // 
            // cbEstado
            // 
            this.cbEstado.FormattingEnabled = true;
            this.cbEstado.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.cbEstado.Location = new System.Drawing.Point(153, 212);
            this.cbEstado.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbEstado.Name = "cbEstado";
            this.cbEstado.Size = new System.Drawing.Size(208, 21);
            this.cbEstado.TabIndex = 21;
            // 
            // ModificarProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(450, 341);
            this.Controls.Add(this.cbEstado);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.txtRUC);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGurdar);
            this.Controls.Add(this.topBar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ModificarProveedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ModificarEmpleado";
            this.topBar.ResumeLayout(false);
            this.topBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IpClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGurdar;
        private System.Windows.Forms.Panel topBar;
        private FontAwesome.Sharp.IconPictureBox IpClose;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtDireccion;
        public System.Windows.Forms.TextBox txtRUC;
        public System.Windows.Forms.TextBox txtTelefono;
        public System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox txtId;
        public System.Windows.Forms.ComboBox cbEstado;
    }
}