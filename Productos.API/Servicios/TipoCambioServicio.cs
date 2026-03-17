using Abstracciones.Interfaces.Reglas;
using Abstracciones.Interfaces.Servicios;
using Abstracciones.Modelos.Servicios.TipoCambio;
using System.Text.Json;
using System.Net.Http.Headers;


namespace Servicios
{
    public class TipoCambioServicio : ITipoCambioServicio
    {
        private readonly IConfiguracion _configuracion;
        private readonly IHttpClientFactory _httpClient;

        public TipoCambioServicio(IConfiguracion configuracion, IHttpClientFactory httpClient)
        {
            _configuracion = configuracion;
            _httpClient = httpClient;
        }


        public async Task<decimal> Obtener()
        {
            var endPoint = _configuracion.ObtenerValor("ApiEndPointTipoCambio:UrlBase");
            var token = _configuracion.ObtenerValor("ApiEndPointTipoCambio:Token");
            var cliente = _httpClient.CreateClient();
            cliente.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
            var fecha = DateTime.Now.ToString("yyyy/MM/dd");
            var url = $"{endPoint}?fechaInicio={fecha}&fechaFin={fecha}&idioma=ES";
            var respuesta = await cliente.GetAsync(url);
            respuesta.EnsureSuccessStatusCode();
            var resultado = await respuesta.Content.ReadAsStringAsync();
            var opciones = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
            var datos = JsonSerializer.Deserialize<TipoCambio.BCCRResponse>(resultado, opciones);
            return datos.datos[0].indicadores[0].series[0].valorDatoPorPeriodo;

        }

    }
}
