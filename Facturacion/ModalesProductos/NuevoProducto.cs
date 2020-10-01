using System;
using Facturacion.Servicio;
using Facturacion.Metodos;
using Facturacion.Entidades;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Web.Script.Serialization;
using System.Net;
using System.IO;
using Facturacion.Servicio.Productos;

namespace Facturacion.ModalesProductos
{
    public partial class NuevoProducto : Form
    {
        ClaseMetodos metodos = new ClaseMetodos();
        ProductosServicios servicios = new ProductosServicios();
        string respuesta;
        string urlProductos, urlProveedores;

        public NuevoProducto()
        {
            InitializeComponent();
            cargarProveedores();
        }

        private void cargarProveedores()
        {
            List<Proveedor> listadoJSON = new List<Proveedor>();
            List<Proveedor> listadoRecuperado = new List<Proveedor>();
            


            respuesta = metodos.retornarListado(urlProveedores);
            JavaScriptSerializer cadena = new JavaScriptSerializer();
            listadoJSON = (List<Proveedor>)cadena.Deserialize(respuesta, typeof(List<Proveedor>));

            foreach (var item in listadoJSON)
            {

                Proveedor nuevo = new Proveedor();
                nuevo.Id = item.Id;
                nuevo.Nombre = item.Nombre;
                listadoRecuperado.Add(nuevo);

            }

            cbProveedor.DataSource = listadoRecuperado;
            cbProveedor.ValueMember ="Id";
            cbProveedor.DisplayMember = "Nombre";
        }

            private void IpClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void NuevoProducto_Load(object sender, EventArgs e)
        {
          
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            insertarCategoria();
            this.Close(); 
        }

        private void insertarCategoria()
        {


            var request = (HttpWebRequest)WebRequest.Create(urlProductos);

            request.Method = "POST";
            request.ContentType = "application/json";
            request.Accept = "application/json";

            using (var streamWriter = new StreamWriter(request.GetRequestStream()))
            {
                string json = new JavaScriptSerializer().Serialize(new
                {
                    CODIGO = txtCodigo.Text,
                    NOMBRE = txtNombre.Text,
                    PRECIO = txtPrecio.Text,
                    STOCK = float.Parse(txtStock.Text),
                    IDPROVEEDOR = 1

                });

                


        streamWriter.Write(json);
                streamWriter.Flush();
                streamWriter.Close();
            }

            try
            {
                using (WebResponse response = request.GetResponse())
                {
                    using (Stream strReader = response.GetResponseStream())
                    {
                        if (strReader == null) return;
                        using (StreamReader objReader = new StreamReader(strReader))
                        {
                            string responseBody = objReader.ReadToEnd();
                            // Do something with responseBody
                            Console.WriteLine(responseBody);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                LabelMensaje.Text = "Producto no registrado";
            }
        }
    }
}
