using ComercialSys.Controller;
using Newtonsoft.Json;
using System.Data;
using System.Net;
using System.Net.Http;

namespace ComercialSys.Model
{
    public static class ViaCepModel
    {
        public static CepController RetornaCep { get; set; }

        public static CepController ConsultaCep(string _cep)
        {

            ServicePointManager.Expect100Continue = true;
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;

            // String para a URL
            string strURL = string.Format($"https://viacep.com.br/ws/{_cep}/json/");


            // HTTP client
            using (HttpClient client = new HttpClient())
            {
                // Result
                var rsp = client.GetAsync(strURL).Result;

                // Verificando Status
                if (rsp.IsSuccessStatusCode)
                {
                    var result = rsp.Content.ReadAsStringAsync().Result;

                    // Desirialize do objeto
                    CepController RetornaCep = JsonConvert.DeserializeObject<CepController>(result);
                }
            }
            return RetornaCep;

        }
    }
}

