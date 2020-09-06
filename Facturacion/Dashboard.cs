﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
namespace Facturacion
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
            abrirFormulario(new PaginaInicio(), "Principal");
            btnProductos.Location = new Point(3, 546);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void iconButton6_Click(object sender, EventArgs e)
        {

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void chart3_Click(object sender, EventArgs e)
        {

        }

        private void iconButton5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void bntMaximize_Click(object sender, EventArgs e)
        {
          
              
                WindowState= FormWindowState.Maximized;
            btnNormal.Visible = true;
            bntMaximize.Visible = false;

        }

        private void btnNormal_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
            btnNormal.Visible = false;
            bntMaximize.Visible = true;

        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            if(panelSidebar.Width== 245)
            {
                panelSidebar.Width = 65;
                lbMantenimiento.Visible = false;
                lbMenu.Visible = false;
                pbProfileMax.Visible = false;
                pbProfileMin.Visible = true;
                lbPerfil.Visible = false;
               
            }
            else{
                panelSidebar.Width = 245;
                lbMantenimiento.Visible = true;
                lbMenu.Visible = true;
                pbProfileMax.Visible = true;
                pbProfileMin.Visible = false;
                lbPerfil.Visible = true;
                
            }
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int IParam);
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

      
        public void SubMenuCompras()
        {
            if (SubmenuCompras.Visible)
            {
                SubmenuCompras.Visible = false;
                btnProductos.Location = new Point(3, 546);
            }
            else
            {
                SubmenuCompras.Visible = true;
                btnProductos.Location = new Point(3, 636);

            }
        }

        private void btnCompras_Click(object sender, EventArgs e)
        {
            SubMenuCompras();
        }

        private void iconBtnSmCompras_Click(object sender, EventArgs e)
        {
            SubMenuCompras();
        }

        private void btnCompras_MouseHover(object sender, EventArgs e)
        {
            //iconBtnSmCompras.BackColor = Color;
        }

        private void abrirFormulario(object formulario,string Titulo)
        {
            if (this.panelPrincipal.Controls.Count>0)
            {
                this.panelPrincipal.Controls.RemoveAt(0);
            }
             Form fh = formulario as Form;
                fh.TopLevel = false;
                fh.Dock = DockStyle.Fill;
                this.panelPrincipal.Controls.Add(fh);
                this.panelPrincipal.Tag = fh;
                fh.Show();
            lblFormulario.Text = Titulo;
            

        }

        private void iconButtonSmProveedores_Click(object sender, EventArgs e)
        {
            abrirFormulario(new Proveedores(), "Proveedores");
        }

        private void btnPrincipal_Click(object sender, EventArgs e)
        {
            abrirFormulario(new PaginaInicio(), "Principal");
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            abrirFormulario(new Productos(), "Productos");
        }
    }
}
