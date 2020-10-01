using Facturacion.ModalesProductos;
using Facturacion.Metodos;
using Facturacion.Servicio;
using Facturacion.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Windows.Forms;
using Facturacion.Servicio.Productos;

namespace Facturacion
{
    public partial class Productos : Form
    {

        ProductosServicios servicios = new ProductosServicios();

        public Productos()
        {
            InitializeComponent();
            cargarListadoProductos();
        }
      

        public void cargarListadoProductos() {

            gvProductos.Rows.Clear();
            gvProductos.DataSource = servicios.ListadoProductos();
            
        }


       

      
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            NuevoProducto fr = new NuevoProducto();
            fr.ShowDialog();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            ModificarDatosModal();
        }
        public void ModificarDatosModal()
        {

            ModificarProducto fr = new ModificarProducto();
            if (gvProductos.SelectedRows.Count > 0)
            {
                fr.txtId.Text = gvProductos.CurrentRow.Cells[0].Value.ToString();
                fr.txtNombre.Text = gvProductos.CurrentRow.Cells[1].Value.ToString();
                fr.txtCodigo.Text = gvProductos.CurrentRow.Cells[2].Value.ToString();
                fr.txtPrecio.Text = gvProductos.CurrentRow.Cells[3].Value.ToString();
                fr.txtStock.Text = gvProductos.CurrentRow.Cells[4].Value.ToString();
                fr.cbProveedor.Text = gvProductos.CurrentRow.Cells[5].Value.ToString();
                fr.cbEstado.Text = gvProductos.CurrentRow.Cells[6].Value.ToString();
                fr.ShowDialog();
            }
            else
            {
                MessageBox.Show("Debe seleccionar al menos un dato");
            }

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            EliminarDatosModal();
        }
        public void EliminarDatosModal()
        {
            EliminarProducto fr = new EliminarProducto();
            if (gvProductos.SelectedRows.Count > 0)
            {
                fr.txtId.Text = gvProductos.CurrentRow.Cells[0].Value.ToString();
                fr.txtNombre.Text = gvProductos.CurrentRow.Cells[1].Value.ToString();
                fr.txtCodigo.Text = gvProductos.CurrentRow.Cells[2].Value.ToString();
                fr.txtPrecio.Text = gvProductos.CurrentRow.Cells[3].Value.ToString();
                fr.txtStock.Text = gvProductos.CurrentRow.Cells[4].Value.ToString();
                fr.cbProveedor.Text = gvProductos.CurrentRow.Cells[5].Value.ToString();
                fr.txtEstado.Text = gvProductos.CurrentRow.Cells[6].Value.ToString();
                fr.ShowDialog();
            }
            else
            {
                MessageBox.Show("Debe seleccionar al menos un dato");
            }
            

        }
    }
   
    public class ProductoVista
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Codigo { get; set; }
        public float Precio { get; set; }
        public int Stock { get; set; }
        public string Proveedor { get; set; }
        public string Estado { get; set; }
        public ProductoVista()
        {

        }
        public ProductoVista(int id, string nombre, string codigo, float precio, int stock, string proveedor, string estado)
        {
            Id = id;
            Nombre = nombre;
            Codigo = codigo;
            Precio = precio;
            Stock = stock;
            Proveedor = proveedor;
            Estado = estado;
        }

    }
}
