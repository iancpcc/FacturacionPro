namespace Facturacion
{
    partial class ConfiguracionPerfil
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnPass = new FontAwesome.Sharp.IconButton();
            this.btnPerfil = new FontAwesome.Sharp.IconButton();
            this.panelConfiguracion = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.btnPass);
            this.panel1.Controls.Add(this.btnPerfil);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(212, 140);
            this.panel1.TabIndex = 0;
            // 
            // btnPass
            // 
            this.btnPass.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnPass.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnPass.FlatAppearance.BorderSize = 0;
            this.btnPass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPass.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPass.ForeColor = System.Drawing.Color.Black;
            this.btnPass.IconChar = FontAwesome.Sharp.IconChar.Key;
            this.btnPass.IconColor = System.Drawing.Color.Black;
            this.btnPass.IconSize = 25;
            this.btnPass.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPass.Location = new System.Drawing.Point(6, 69);
            this.btnPass.Name = "btnPass";
            this.btnPass.Rotation = 0D;
            this.btnPass.Size = new System.Drawing.Size(189, 47);
            this.btnPass.TabIndex = 2;
            this.btnPass.Text = "    Contraseña";
            this.btnPass.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPass.UseVisualStyleBackColor = false;
            this.btnPass.Click += new System.EventHandler(this.btnPass_Click);
            // 
            // btnPerfil
            // 
            this.btnPerfil.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnPerfil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnPerfil.FlatAppearance.BorderSize = 0;
            this.btnPerfil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPerfil.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnPerfil.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPerfil.ForeColor = System.Drawing.Color.Black;
            this.btnPerfil.IconChar = FontAwesome.Sharp.IconChar.UserCircle;
            this.btnPerfil.IconColor = System.Drawing.Color.Black;
            this.btnPerfil.IconSize = 25;
            this.btnPerfil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPerfil.Location = new System.Drawing.Point(6, 3);
            this.btnPerfil.Name = "btnPerfil";
            this.btnPerfil.Rotation = 0D;
            this.btnPerfil.Size = new System.Drawing.Size(192, 47);
            this.btnPerfil.TabIndex = 2;
            this.btnPerfil.Text = "    Perfil";
            this.btnPerfil.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPerfil.UseVisualStyleBackColor = false;
            this.btnPerfil.Click += new System.EventHandler(this.btnPerfil_Click);
            // 
            // panelConfiguracion
            // 
            this.panelConfiguracion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelConfiguracion.Location = new System.Drawing.Point(241, 12);
            this.panelConfiguracion.Name = "panelConfiguracion";
            this.panelConfiguracion.Size = new System.Drawing.Size(1036, 660);
            this.panelConfiguracion.TabIndex = 1;
            // 
            // ConfiguracionPerfil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1300, 720);
            this.Controls.Add(this.panelConfiguracion);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ConfiguracionPerfil";
            this.Text = "Configuracion";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton btnPass;
        private FontAwesome.Sharp.IconButton btnPerfil;
        private System.Windows.Forms.Panel panelConfiguracion;
    }
}