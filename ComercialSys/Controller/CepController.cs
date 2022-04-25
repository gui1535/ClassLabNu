using ComercialSys.Model;
using Newtonsoft.Json;

namespace ComercialSys.Controller
{
    public class CepController
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

        public static string Estado { get; set; }


        public static void ConsultarCep(string _cep)
        {
            // Consultar Cep
            ViaCepModel.ConsultaCep(_cep.ToString().Trim());
             
            // Verificando Uf
            VerificarUf();
        }
        private static string VerificarUf()
        {
            if (Uf.Equals("SP"))
            {
                Estado = "São Paulo";
            }
            else if (Uf.Equals("RJ"))
            {
                Estado = "Rio de Janeiro";
            }
            else if (Uf.Equals("AC"))
            {
                Estado = "Acre";
            }
            else if (Uf.Equals("AL"))
            {
                Estado = "Alagoas";
            }
            else if (Uf.Equals("AP"))
            {
                Estado = "Amapá";
            }
            else if (Uf.Equals("AM"))
            {
                Estado = "Amazonas";
            }
            else if (Uf.Equals("BA"))
            {
                Estado = "Bahia";
            }
            else if (Uf.Equals("CE"))
            {
                Estado = "Ceará";
            }
            else if (Uf.Equals("DF"))
            {
                Estado = "Distrito Federal";
            }
            else if (Uf.Equals("ES"))
            {
                Estado = "Espirito Santo";
            }
            else if (Uf.Equals("GO"))
            {
                Estado = "Góias";
            }
            else if (Uf.Equals("MA"))
            {
                Estado = "Maranhão";
            }
            else if (Uf.Equals("MT"))
            {
                Estado = "Mato Grosso";
            }
            else if (Uf.Equals("MS"))
            {
                Estado = "Mato Grosso do Sul";
            }
            else if (Uf.Equals("MG"))
            {
                Estado = "Minas Gerais";
            }
            else if (Uf.Equals("PA"))
            {
                Estado = "Pará";
            }
            else if (Uf.Equals("PB"))
            {
                Estado = "Paraíba";
            }
            else if (Uf.Equals("PR"))
            {
                Estado = "Paraná";
            }
            else if (Uf.Equals("PE"))
            {
                Estado = "Pernambuco";
            }
            else if (Uf.Equals("PI"))
            {
                Estado = "Piauí";
            }
            else if (Uf.Equals("RN"))
            {
                Estado = "Rio Grande do Norte";
            }
            else if (Uf.Equals("RS"))
            {
                Estado = "Rio Grande do Sul";
            }
            else if (Uf.Equals("RO"))
            {
                Estado = "Rondônia";
            }
            else if (Uf.Equals("RR"))
            {
                Estado = "Roraima";
            }
            else if (Uf.Equals("SC"))
            {
                Estado = "Santa Catarina";
            }
            else if (Uf.Equals("SE"))
            {
                Estado = "Sergipe";
            }
            else if (Uf.Equals("TO"))
            {
                Estado = "Tocantins";
            }

            return Estado;
        }

    }
}
