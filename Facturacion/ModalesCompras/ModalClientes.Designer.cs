namespace Facturacion.ModalesCompras
{
    partial class ModalClientes
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.topBar = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.gvClientes = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.IpClose = new FontAwesome.Sharp.IconPictureBox();
            this.topBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IpClose)).BeginInit();
            this.SuspendLayout();
            // 
            // topBar
            // 
            this.topBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(87)))), ((int)(((byte)(155)))));
            this.topBar.Controls.Add(this.IpClose);
            this.topBar.Controls.Add(this.label3);
            this.topBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.topBar.Location = new System.Drawing.Point(0, 0);
            this.topBar.Margin = new System.Windows.Forms.Padding(2);
            this.topBar.Name = "topBar";
            this.topBar.Size = new System.Drawing.Size(810, 42);
            this.topBar.TabIndex = 29;
            this.topBar.Paint += new System.Windows.Forms.PaintEventHandler(this.topBar_Paint);
            this.topBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.topBar_MouseDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(377, 9);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 21);
            this.label3.TabIndex = 0;
            this.label3.Text = "Clientes";
            // 
            // gvClientes
            // 
            this.gvClientes.AllowUserToResizeColumns = false;
            this.gvClientes.AllowUserToResizeRows = false;
            this.gvClientes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gvClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvClientes.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(99)))), ((int)(((byte)(130)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvClientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.gvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvClientes.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(163)))), ((int)(((byte)(188)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gvClientes.DefaultCellStyle = dataGridViewCellStyle6;
            this.gvClientes.EnableHeadersVisualStyles = false;
            this.gvClientes.GridColor = System.Drawing.Color.Silver;
            this.gvClientes.Location = new System.Drawing.Point(21, 131);
            this.gvClientes.Margin = new System.Windows.Forms.Padding(2);
            this.gvClientes.Name = "gvClientes";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(204)))), ((int)(((byte)(221)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvClientes.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.gvClientes.RowHeadersVisible = false;
            this.gvClientes.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(204)))), ((int)(((byte)(221)))));
            this.gvClientes.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.gvClientes.RowTemplate.Height = 24;
            this.gvClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvClientes.Size = new System.Drawing.Size(778, 389);
            this.gvClientes.TabIndex = 30;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(23, 67);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBox1.Size = new System.Drawing.Size(558, 40);
            this.textBox1.TabIndex = 32;
            this.textBox1.Text = "Buscar...";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(87)))), ((int)(((byte)(155)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(604, 67);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(195, 40);
            this.button1.TabIndex = 31;
            this.button1.Text = " Buscar";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // IpClose
            // 
            this.IpClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(87)))), ((int)(((byte)(155)))));
            this.IpClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.IpClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.IpClose.IconChar = FontAwesome.Sharp.IconChar.WindowClose;
            this.IpClose.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.IpClose.IconSize = 28;
            this.IpClose.Location = new System.Drawing.Point(765, 2);
            this.IpClose.Margin = new System.Windows.Forms.Padding(2);
            this.IpClose.Name = "IpClose";
            this.IpClose.Size = new System.Drawing.Size(32, 28);
            this.IpClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.IpClose.TabIndex = 0;
            this.IpClose.TabStop = false;
            this.IpClose.Click += new System.EventHandler(this.IpClose_Click);
            // 
            // ModalClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(810, 545);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.gvClientes);
            this.Controls.Add(this.topBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ModalClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ModalClientes";
            this.topBar.ResumeLayout(false);
            this.topBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IpClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel topBar;
        private FontAwesome.Sharp.IconPictureBox IpClose;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView gvClientes;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
    }
}