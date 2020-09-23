using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Facturacion.Metodos
{
    public class ClaseMetodos
    {
        public string RetornarListado(string url)
        {
            WebRequest Orequest = WebRequest.Create(url);
            WebResponse Oresponse = Orequest.GetResponse();
            StreamReader sr = new StreamReader(Oresponse.GetResponseStream());
            return sr.ReadToEnd().Trim();

        }
        public string devolverEstado(int estadoRecuperado)
        {
            String estado = "";
            if (estadoRecuperado == 0)
            {
                estado = "Inactivo";
            }
            else
            {
                estado = "Activo";
            }
            return estado;
        }
    }
}
