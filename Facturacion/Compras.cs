using Facturacion.ModalesCompras;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Facturacion
{
    public partial class Compras : Form
    {
        public Compras()
        {
            InitializeComponent();
        }

        private void Compras_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ModalClientes mc = new ModalClientes();
            mc.ShowDialog();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            ModalProductos mp = new ModalProductos();
                mp.ShowDialog();
        }
    }
}
