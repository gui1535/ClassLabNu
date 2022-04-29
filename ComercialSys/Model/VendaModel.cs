using System;

namespace ComercialSys.Model
{
    public class VendaModel
    {

        // Atributos

        public int Id { get; set; }
        public string Data { get; set; }
        public string Status { get; set; }
        public double Desconto { get; set; }

        // Construtores

        public VendaModel()
        {
        }

        public VendaModel(int id, string data, string status)
        {
            Id = id;
            Data = data;
            Status = status;
        }

        public VendaModel(string data, double desconto)
        {
            Data = data;
            Desconto = desconto;
        }
    }
}
