using Newtonsoft.Json;

namespace ClassLabNu
{
    public class JsonCepResult
    {

        [JsonProperty(PropertyName = "cep")]
        public static string Cep { get; set; }


        [JsonProperty(PropertyName = "logradouro")]
        public static string Logradouro { get; set; }


        [JsonProperty(PropertyName = "complemento")]
        public static string Complemento { get; set; }


        [JsonProperty(PropertyName = "bairro")]
        public static string Bairro { get; set; }


        [JsonProperty(PropertyName = "localidade")]
        public static string Localidade { get; set; }


        [JsonProperty(PropertyName = "uf")]
        public static string Uf { get; set; }


        [JsonProperty(PropertyName = "ibge")]
        public static string Ibge { get; set; }


        [JsonProperty(PropertyName = "gia")]
        public static string Gia { get; set; }


        [JsonProperty(PropertyName = "ddd")]
        public static int Ddd { get; set; }

        [JsonProperty(PropertyName = "siafi")]
        public static int Siafi { get; set; }
    }
}
