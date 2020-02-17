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
            send.AnaCapitulo = scan.capitulo.ToString();
            send.AnaLote = scan.lote.ToString();
            send.CodigoProyecto = scan.proyecto.ToString();
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
        public async Task<Retorno> postLineas(Retorno scan)
        {

            LineasParteTrabajo send = new LineasParteTrabajo();
            send.AnaCapitulo = scan.capitulo.ToString();
            send.AnaLote = scan.lote.ToString();
            send.CodigoProyecto = scan.proyecto.ToString();
            send.CodigoEmpresa = 1;
            send.EjercicioParteTrabajo = DateTime.Now.Year;
            send.SerieParteTrabajo = " ";
            send.TipoCodificado = 1;
            send.CodigoArticulo = scan.articulo;
            send.DescripcionArticulo = scan.DescripcionArticulo;
            Decimal uni = Decimal.Parse(scan.unidad);
            send.Unidades = uni;
            send.CodigoAlmacen = scan.almacen;
            send.Fecha = DateTime.Now;
            send.FechaRegistro = DateTime.Now;
            send.FactorConversion_ = scan.FactorConversion_;
            send.PrecioVenta = scan.PrecioVenta;
            send.PrecioCoste = scan.PrecioCoste;
            send.Unidades2_ = uni * scan.FactorConversion_;
            var jsonObj = JsonConvert.SerializeObject(send);
            using (HttpClient client = new HttpClient())
            {

                StringContent content = new StringContent(jsonObj.ToString(), Encoding.UTF8, "application/json");
                var request = new HttpRequestMessage()
                {
                    RequestUri = new Uri("https://affinity.somee.com/ApiAlexa/api/LineasParteTrabajoes"),
                    Method = HttpMethod.Post,
                    Content = content
                };
                var response = await client.SendAsync(request).ConfigureAwait(false);
                string dataResult = response.Content.ReadAsStringAsync().Result;
                Retorno result = JsonConvert.DeserializeObject<Retorno>(dataResult);
                return result;
            }

        }
        public async Task<Retorno> getArticulo(Scan scan)
        {

            Scan send = new Scan();
            send.codigo = scan.articulo;
            
            var jsonObj = JsonConvert.SerializeObject(send);
            using (HttpClient client = new HttpClient())
            {

                StringContent content = new StringContent(jsonObj.ToString(), Encoding.UTF8, "application/json");
                var request = new HttpRequestMessage()
                {
                    RequestUri = new Uri("https://affinity.somee.com/ApiAlexa/api/ArticuloSearch"),
                    Method = HttpMethod.Post,
                    Content = content
                };
                var response = await client.SendAsync(request).ConfigureAwait(false);
                string dataResult = response.Content.ReadAsStringAsync().Result;
                Retorno result = JsonConvert.DeserializeObject<Retorno>(dataResult);
                return result;
            }

        }
        public async Task<Retorno> getCoste(Scan scan)
        {

            Scan send = new Scan();
            send.CodigoAlmacens = scan.almacen;
            send.CodigoArticulos = scan.articulo;
            var jsonObj = JsonConvert.SerializeObject(send);
            using (HttpClient client = new HttpClient())
            {

                StringContent content = new StringContent(jsonObj.ToString(), Encoding.UTF8, "application/json");
                var request = new HttpRequestMessage()
                {
                    RequestUri = new Uri("https://affinity.somee.com/ApiAlexa/api/Coste"),
                    Method = HttpMethod.Post,
                    Content = content
                };
                var response = await client.SendAsync(request).ConfigureAwait(false);
                string dataResult = response.Content.ReadAsStringAsync().Result;
                Retorno result = JsonConvert.DeserializeObject<Retorno>(dataResult);
                return result;
            }

        }
        public Alamacenes getAlmacenes()
        {
            try
            {
                Alamacenes almacenes;
                var URLWebAPI = "https://affinity.somee.com/ApiAlexa/api/Almacenes";
                using (var Client = new System.Net.Http.HttpClient())
                {
                    var JSON = Client.GetStringAsync(URLWebAPI);
                    almacenes = Newtonsoft.Json.JsonConvert.DeserializeObject<Alamacenes>(JSON.Result);
                }

                return almacenes;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
