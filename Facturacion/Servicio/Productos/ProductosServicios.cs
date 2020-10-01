using Facturacion.Entidades;
using Facturacion.Metodos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace Facturacion.Servicio.Productos
{
    class ProductosServicios
    {
        URLServicios servicios = new URLServicios();
        ClaseMetodos metodos = new ClaseMetodos();

        public List<Producto> ListadoProductos()
        {

            try
            {
                List<Producto> listadoJSON = new List<Producto>();

                dynamic respuesta = metodos.getRequest($"{servicios.uRL}/productos");
                if (respuesta==null)
                {
                    return listadoJSON;
                }
                foreach (var producto in respuesta.productos)
                {
                    listadoJSON.Add(new Producto(Convert.ToInt32(producto.id), Convert.ToString(producto.nombre), 
                        Convert.ToString(producto.codigo), Convert.ToDouble(producto.precio), 
                        Convert.ToInt32(producto.stock), Convert.ToInt32(producto.idproveedor),
                        Convert.ToInt32(producto.estado)));
                }
                return listadoJSON;
            }
            catch (Exception)
            {

                throw;
            }
           

        }
    }
}
