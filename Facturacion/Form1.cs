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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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

            CerrarSistema();
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            CerrarSistema();
        }

        private void btnMinize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void bntMaximize_Click(object sender, EventArgs e)
        {


            WindowState = FormWindowState.Maximized;
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
            if (panelSidebar.Width == 245)
            {
                panelSidebar.Width = 65;
                lbMantenimiento.Visible = false;
                lbMenu.Visible = false;
                pbProfileMax.Visible = false;
                pbProfileMin.Visible = true;
                lbPerfil.Visible = false;

            }
            else
            {
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

        private void CerrarSistema() {
            Login login = new Login();
            login.Show();
            this.Hide();

        }
    }
}
