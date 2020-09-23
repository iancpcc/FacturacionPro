using System;
using Facturacion.Entidades;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
namespace Facturacion.ModalesProveedores
{

    public partial class NuevoProveedor : Form
    {
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int IParam);
        public NuevoProveedor()
        {
            InitializeComponent();
            cbEstado.SelectedIndex = -1;
        }

        private void TopBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void IpClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (Controles())
            {
                GuardarProveedor();
            }
        }

        public void GuardarProveedor()
        {
            Proveedor p = new Proveedor(
            0,
            txtNombre.Text,
            txtRUC.Text,
            txtTelefono.Text,
            txtDireccion.Text,
            cbEstado.SelectedItem.ToString()
            );
        }

        public bool Controles()
        {
            if (txtNombre.Text.Length == 0 || txtRUC.Text.Length == 0 
                || txtTelefono.Text.Length == 0 || txtDireccion.Text.Length == 0 || cbEstado.SelectedIndex == -1)
            {
                MessageBox.Show("Campos Vacíos");
                return false;
            }
            
            return true;


        }
    }
}
