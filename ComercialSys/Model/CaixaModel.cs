using System;

namespace ComercialSys.Model
{
    public class CaixaModel
    {
        // Atributos

        public int Id { get; set; }
        public DateTime Data { get; set; }
        public string Status { get; set; }

        // Construtores

        public CaixaModel()
        {
        }

        public CaixaModel(int id, DateTime data)
        {
            Id = id;
            Data = data;
        }

        public CaixaModel(int id, string status)
        {
            Id = id;
            Status = status;
        }

        // Metodos


    }
}