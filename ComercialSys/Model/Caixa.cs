using System;

namespace ClassLabNu
{
    public class Caixa
    {
        // Atributos

        public int Id { get; set; }
        public DateTime Data { get; set; }
        public string Status { get; set; }

        // Construtores

        public Caixa()
        {
        }

        public Caixa(int id, DateTime data)
        {
            Id = id;
            Data = data;
        }

        public Caixa(int id, string status)
        {
            Id = id;
            Status = status;
        }

        // Metodos


    }
}