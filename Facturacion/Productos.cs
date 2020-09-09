using Facturacion.ModalesProductos;
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
    public partial class Productos : Form
    {
        public Productos()
        {
            InitializeComponent();
            gvProductos.Rows.Clear();
            gvProductos.DataSource = llenarProductos();
        }

        private List<Producto> llenarProductos()
        {
            List<Producto> lista = new List<Producto>();
            lista.Add(new Producto(1, "Fideo Catedral", "099112AA", 12, 500,"Paca", "Activo"));
            lista.Add(new Producto(2, "Fideo Paca", "099112AA", 12, 500, "Duran", "Activo"));
            return lista;
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
    public class Producto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Codigo { get; set; }
        public float Precio { get; set; }
        public int Stock { get; set; }
        public string Proveedor { get; set; }
        public string Estado { get; set; }
        public Producto(int id, string nombre,string codigo,float precio, int stock,string proveedor,string estado)
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
