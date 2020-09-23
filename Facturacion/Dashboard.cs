using System;
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
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int IParam);


        public Dashboard()
        {
            InitializeComponent();
            abrirFormulario(new PaginaInicio(), "Principal");
            //Ubicacion de iconos y botones Modulo Compras Chris
            btnProductos.Location = new Point(2,438);
            iconBtnSmComprasRight.Location = new Point(211, 488);
            //
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

            WindowState = FormWindowState.Maximized;
            //this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            //this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            btnNormal.Visible = true;
            bntMaximize.Visible = false;

        }

        private void btnNormal_Click(object sender, EventArgs e)
        {
            
            //Rectangle workingRectangle = Screen.PrimaryScreen.WorkingArea;
            //this.Size = new Size(
            //workingRectangle.Width - 580, workingRectangle.Height - 180);
            //this.Location = new Point(250,160);
            WindowState = FormWindowState.Normal;
            btnNormal.Visible = false;
            bntMaximize.Visible = true;

        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            if(panelSidebar.Width== 220)
            {
                panelSidebar.Width =55;
                lbMantenimiento.Visible = false;
                lbMenu.Visible = false;
                pbProfileMax.Visible = false;
                pbProfileMin.Visible = true;
                lbPerfil.Visible = false;
               
            }
            else{
                panelSidebar.Width = 220;
                lbMantenimiento.Visible = true;
                lbMenu.Visible = true;
                pbProfileMax.Visible = true;
                pbProfileMin.Visible = false;
                lbPerfil.Visible = true;
                
            }
        }
        
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
                btnProductos.Location = new Point(2, 438);
                iconBtnSmCompras.Visible = false;
                iconBtnSmComprasRight.Visible = true;
                iconBtnSmComprasRight.Location = new Point(211, 488);

            }
            else
            {
                SubmenuCompras.Visible = true;
                btnProductos.Location = new Point(2, 518);
                iconBtnSmCompras.Visible = true;
                iconBtnSmComprasRight.Visible = false;

               

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
            this.iconBtnSmCompras.MouseHover += new System.EventHandler(this.iconBtnSmCompras_MouseHover);
            //iconBtnSmCompras.BackColor = Color.FromArgb(68, 89, 110);
            //btnCompras.BackColor = Color.FromArgb(68,89, 110);
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

        private void btnCompras_MouseLeave(object sender, EventArgs e)
        {
            btnCompras.BackColor = Color.FromArgb(52, 73, 94);
            iconBtnSmCompras.BackColor = Color.FromArgb(52, 73, 94);
        }

        private void iconBtnSmCompras_MouseHover(object sender, EventArgs e)
        {

        }

        private void iconBtnSmComprasRight_Click(object sender, EventArgs e)
        {
            SubMenuCompras();
        }

        private void iconBtnSmCompras_Click_1(object sender, EventArgs e)
        {
            SubMenuCompras();
        }

        private void btnConfiguracion_Click(object sender, EventArgs e)
        {
            abrirFormulario(new ConfiguracionPerfil(), "Configuración");
            
        }

        private void panelPrincipal_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
