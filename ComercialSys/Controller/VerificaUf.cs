using ComercialSys.Model;
using System.Windows.Forms;

namespace ComercialSys.Controller
{
    public static class VerificaUf
    {
        public static string Estado { get; set; }

        public static string VerificarUf()
        {
            if (JsonCepResult.Uf.Equals("SP"))
            {
                Estado = "São Paulo";
            }
            else if (JsonCepResult.Uf.Equals("RJ"))
            {
                Estado = "Rio de Janeiro";
            }
            else if (JsonCepResult.Uf.Equals("AC"))
            {
                Estado = "Acre";
            }
            else if (JsonCepResult.Uf.Equals("AL"))
            {
                Estado = "Alagoas";
            }
            else if (JsonCepResult.Uf.Equals("AP"))
            {
                Estado = "Amapá";
            }
            else if (JsonCepResult.Uf.Equals("AM"))
            {
                Estado = "Amazonas";
            }
            else if (JsonCepResult.Uf.Equals("BA"))
            {
                Estado = "Bahia";
            }
            else if (JsonCepResult.Uf.Equals("CE"))
            {
                Estado = "Ceará";
            }
            else if (JsonCepResult.Uf.Equals("DF"))
            {
                Estado = "Distrito Federal";
            }
            else if (JsonCepResult.Uf.Equals("ES"))
            {
                Estado = "Espirito Santo";
            }
            else if (JsonCepResult.Uf.Equals("GO"))
            {
                Estado = "Góias";
            }
            else if (JsonCepResult.Uf.Equals("MA"))
            {
                Estado = "Maranhão";
            }
            else if (JsonCepResult.Uf.Equals("MT"))
            {
                Estado = "Mato Grosso";
            }
            else if (JsonCepResult.Uf.Equals("MS"))
            {
                Estado = "Mato Grosso do Sul";
            }
            else if (JsonCepResult.Uf.Equals("MG"))
            {
                Estado = "Minas Gerais";
            }
            else if (JsonCepResult.Uf.Equals("PA"))
            {
                Estado = "Pará";
            }
            else if (JsonCepResult.Uf.Equals("PB"))
            {
                Estado = "Paraíba";
            }
            else if (JsonCepResult.Uf.Equals("PR"))
            {
                Estado = "Paraná";
            }
            else if (JsonCepResult.Uf.Equals("PE"))
            {
                Estado = "Pernambuco";
            }
            else if (JsonCepResult.Uf.Equals("PI"))
            {
                Estado = "Piauí";
            }
            else if (JsonCepResult.Uf.Equals("RN"))
            {
                Estado = "Rio Grande do Norte";
            }
            else if (JsonCepResult.Uf.Equals("RS"))
            {
                Estado = "Rio Grande do Sul";
            }
            else if (JsonCepResult.Uf.Equals("RO"))
            {
                Estado = "Rondônia";
            }
            else if (JsonCepResult.Uf.Equals("RR"))
            {
                Estado = "Roraima";
            }
            else if (JsonCepResult.Uf.Equals("SC"))
            {
                Estado = "Santa Catarina";
            }
            else if (JsonCepResult.Uf.Equals("SE"))
            {
                Estado = "Sergipe";
            }
            else if (JsonCepResult.Uf.Equals("TO"))
            {
                Estado = "Tocantins";
            }

            return Estado;
        }

    }
}
