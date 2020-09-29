using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facturacion.Servicio
{
    public class URLServicios
    {


        //Productos
        String urlProductos = "http://localhost:8081/ApiRestfulFacturacion/public/api/productos";
        //Proveedores
        public string urlProveedores = "http://backendfacturacion.herokuapp.com/public/api/proveedores";

        //

        public string devolverURLProductos()
        {
            return urlProductos;
        }
        public string devolverURLProveedores()
        {
            return urlProveedores;
        }

    }
}
