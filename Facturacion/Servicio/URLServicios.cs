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
        String urlProveedores = "http://localhost:8081/ApiRestfulFacturacion/public/api/proveedores";
        //Configuración
        
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
