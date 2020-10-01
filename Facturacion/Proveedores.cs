using Facturacion.ModalesProveedores;
using Facturacion.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Facturacion.Metodos;
using Facturacion.Servicio;
using Facturacion.Servicio.Proveedores;

namespace Facturacion
{
    public partial class Proveedores : Form
    {
        ProveedoresServicios servicios= new ProveedoresServicios();
        public Proveedores()
        {
            InitializeComponent();


            gvProveedores.Rows.Clear();
            gvProveedores.DataSource = this.servicios.ListadoProveedores();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            ModificarDatosModal();
        }

        public void ModificarDatosModal()
        {

            ModificarProveedor fr = new ModificarProveedor();
            if (gvProveedores.SelectedRows.Count > 0)
            {
                fr.txtId.Text = gvProveedores.CurrentRow.Cells[0].Value.ToString();
                fr.txtRUC.Text = gvProveedores.CurrentRow.Cells[1].Value.ToString();
                fr.txtNombre.Text = gvProveedores.CurrentRow.Cells[2].Value.ToString();
                fr.txtDireccion.Text = gvProveedores.CurrentRow.Cells[3].Value.ToString();
                fr.txtTelefono.Text = gvProveedores.CurrentRow.Cells[4].Value.ToString();
                fr.ShowDialog();
            }
            else
            {
                MessageBox.Show("Debe seleccionar al menos un dato");
            }

        }
        public void EliminarDatosModal()
        {
            EliminarProveedores fr = new EliminarProveedores();
            if (gvProveedores.SelectedRows.Count > 0)
            {
                fr.txtId.Text = gvProveedores.CurrentRow.Cells[0].Value.ToString();
                fr.txtRUC.Text = gvProveedores.CurrentRow.Cells[1].Value.ToString();
                fr.txtNombre.Text = gvProveedores.CurrentRow.Cells[2].Value.ToString();
                fr.txtDireccion.Text = gvProveedores.CurrentRow.Cells[3].Value.ToString();
                fr.txtTelefono.Text = gvProveedores.CurrentRow.Cells[4].Value.ToString();
                fr.ShowDialog();
            }
            else
            {
                MessageBox.Show("Debe seleccionar al menos un dato");
            }

        }


        private void btnAgregar_Click(object sender, EventArgs e)
        {
            NuevoProveedor fr = new NuevoProveedor();
            fr.ShowDialog();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            EliminarDatosModal();
        }

       
    }



   
}
