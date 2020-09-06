using Facturacion.ModalesProveedores;
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
    public partial class Proveedores : Form
    {
        public Proveedores()
        {
            InitializeComponent();


            gvProveedores.Rows.Clear();
            gvProveedores.DataSource = llenarProveedores();
            
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
                fr.txtNombre.Text = gvProveedores.CurrentRow.Cells[1].Value.ToString();
                fr.txtRUC.Text = gvProveedores.CurrentRow.Cells[2].Value.ToString();
                fr.txtTelefono.Text = gvProveedores.CurrentRow.Cells[3].Value.ToString();
                fr.txtDireccion.Text = gvProveedores.CurrentRow.Cells[4].Value.ToString();
                fr.cbEstado.Text = gvProveedores.CurrentRow.Cells[5].Value.ToString();
                fr.ShowDialog();
            }
            else
            {
                MessageBox.Show("Debe seleccionar almenos un dato");
            }

        }
        public void EliminarDatosModal()
        {
            EliminarProveedores fr = new EliminarProveedores();
            if (gvProveedores.SelectedRows.Count > 0)
            {
                fr.txtId.Text = gvProveedores.CurrentRow.Cells[0].Value.ToString();
                fr.txtNombre.Text = gvProveedores.CurrentRow.Cells[1].Value.ToString();
                fr.txtRUC.Text = gvProveedores.CurrentRow.Cells[2].Value.ToString();
                fr.txtTelefono.Text = gvProveedores.CurrentRow.Cells[3].Value.ToString();
                fr.txtDireccion.Text = gvProveedores.CurrentRow.Cells[4].Value.ToString();
                fr.txtEstado.Text = gvProveedores.CurrentRow.Cells[5].Value.ToString();
                fr.ShowDialog();
            }
            else
            {
                MessageBox.Show("Debe seleccionar almenos un dato");
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

        public List<Proveedor> llenarProveedores()
        {

            List<Proveedor> lista = new List<Proveedor>();
            lista.Add(new Proveedor(1,"Christian","1804898755","0983084104","Ambato","Activo"));
            lista.Add(new Proveedor(2,"Pedro","1804898755","0983084104","Quito","Activo"));
            lista.Add(new Proveedor(3,"Alberto","1804898755","0983084104","Guayaquil","Inactivo"));
            return lista;
        }
    }



    public class Proveedor
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string RUC { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }
        public string Estado { get; set; }

        public Proveedor(int id, string nombre, string rUC, string telefono, string direccion, string estado)
        {
            Id = id;
            Nombre = nombre;
            RUC = rUC;
            Telefono = telefono;
            Direccion = direccion;
            Estado = estado;
        }
    }
}
