using Newtonsoft.Json.Linq;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Facturacion.Metodos
{
    public class ClaseMetodos
    {
        public string retornarListado(string url)
        {
            Console.WriteLine(url);
            WebRequest Orequest = WebRequest.Create(url);
            WebResponse Oresponse = Orequest.GetResponse();
            StreamReader sr = new StreamReader(Oresponse.GetResponseStream());
            return sr.ReadToEnd().Trim();

        }

        public List<Object> llenarGridView(string url)
        {
            
            List<Object> lista = new List<Object>();
            string respuesta = retornarListado(url);
            Console.Write(respuesta);
            return lista;
        }

        public dynamic obtenerInstancias(string url)
        {
            var request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "GET";
            request.ContentType = "application/json";
            request.Accept = "application/json";
            try
            {
                using (WebResponse response = request.GetResponse())
                {
                    
                    using (Stream strReader = response.GetResponseStream())
                    {
                        if (strReader == null) return null;

                        using (StreamReader objReader = new StreamReader(strReader))
                        {
                            //Convierte a string la Respuesta
                            string stringBody = objReader.ReadToEnd();
                            //Permite acceder a los atributos del string
                            dynamic dynamicBody = JObject.Parse(stringBody);
                            if(dynamicBody.status == "ok") 
                            {
                                return dynamicBody.data;
                            }
                            else 
                            {
                                //Mensaje de error en el lado de Servidor
                                MessageBox.Show("Código: "+dynamicBody.code+".\nMensaje: "+dynamicBody.message+".");
                                return null;
                            }
                        }
                    }
                }
            }
            catch (WebException ex)
            {
                if (ex.Status == WebExceptionStatus.ProtocolError && ex.Response != null)
                {
                    var resp = (HttpWebResponse)ex.Response;
                    if (resp.StatusCode == HttpStatusCode.NotFound)
                    {
                        MessageBox.Show("Error: 500 \nMensaje: No se puede establecer conexión con el Servidor", "Error con el Servidor", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return null;
                    }
                    else
                    {
                        Stream strReader = ex.Response.GetResponseStream();
                        StreamReader objReader = new StreamReader(strReader);
                        string stringBody = objReader.ReadToEnd();

                        dynamic dynamicBody = JObject.Parse(stringBody);

                        MessageBox.Show("Error: " + dynamicBody.code + "\nMensaje: " + dynamicBody.message + ".", "Error con el Servidor", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return null;
                    }
                }
                else
                {
                    MessageBox.Show("Mensaje: Error con el Host", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
                }
            }
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
