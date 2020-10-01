using Facturacion.Entidades;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
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

        //Petición GET sin parámetros
        //Retorna un array con los items 
        public dynamic getRequest(string url)
        {
            var request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "GET";
            request.ContentType = "application/json";
            request.Accept = "application/json; charset=utf-8";
                        //request.Accept = "application/json";
            try
            {
                using (var response = request.GetResponse())
                using (var reader = new StreamReader(response.GetResponseStream()))
                {
                    var result = reader.ReadToEnd();

                    if (string.IsNullOrEmpty(result))
                    {
                        return null;
                    }

                    dynamic dynamicBody = JObject.Parse(result);
                  
                    if (dynamicBody.status == "ok")
                    {    //Retorn el array de datos
                      
                        return dynamicBody.data;
                    }
                    else
                    {
                        //Mensaje de error en el lado de Servidor
                        MessageBox.Show("Código: " + dynamicBody.code + ".\nMensaje: " + dynamicBody.message + ".", "Error con el Servidor", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return null;
                    }



                }
            }
            catch (WebException ex)
            {
                return MostrarError(ex);
            }
        }

        public dynamic sendRequest(string url,Object user)
        {
         
                var httpWebRequest = (HttpWebRequest)WebRequest.Create(url);
                httpWebRequest.ContentType = "application/json; charset=utf-8";
                httpWebRequest.Method = "POST";
                httpWebRequest.Accept = "application/json; charset=utf-8";
            try
            {
                using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
                {
                    string loginjson = new JavaScriptSerializer().Serialize(user);

                    streamWriter.Write(loginjson);
                    streamWriter.Flush();
                    streamWriter.Close();

                    var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                    using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                    {
                        var result = streamReader.ReadToEnd();
                        if (string.IsNullOrEmpty(result))
                        {
                            return null;
                        }

                        dynamic dynamicBody = JObject.Parse(result);

                        if (dynamicBody.status == "ok")
                        {    //Retorn el array de datos

                            return dynamicBody.data;
                        }
                        
                        else
                        {
                            //Mensaje de error en el lado de Servidor
                            MessageBox.Show("Código: " + dynamicBody.code + ".\nMensaje: " + dynamicBody.message + ".", "Error con el Servidor", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return null;
                        }
                    }
                }


    }
            catch (WebException ex)
            {
                MostrarError(ex);
                return null;
            }

        }

        private dynamic MostrarError(WebException ex)
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
