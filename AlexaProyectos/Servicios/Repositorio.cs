using AlexaProyectos.models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace AlexaProyectos.Servicios
{
    public class Repositorio
    {
        public async Task<Retorno> postRegistro(Scan scan)
        {

            Send send = new Send();
            send.AnaCapitulo = scan.capitulo;
            send.AnaLote = scan.lote;
            send.CodigoProyecto = scan.proyecto;
            var jsonObj = JsonConvert.SerializeObject(send);
            using (HttpClient client = new HttpClient())
            {
                
                StringContent content = new StringContent(jsonObj.ToString(), Encoding.UTF8, "application/json");
                var request = new HttpRequestMessage()
                {
                    RequestUri = new Uri("https://affinity.somee.com/ApiAlexa/api/Remex"),
                    Method = HttpMethod.Post,
                    Content = content
                };
                var response = await client.SendAsync(request).ConfigureAwait(false);
                string dataResult = response.Content.ReadAsStringAsync().Result;
                Retorno result = JsonConvert.DeserializeObject<Retorno>(dataResult);
                return result;
            }

        }
    }
}
