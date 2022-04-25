﻿using System;

namespace ComercialSys.Model
{
    public class VendaModel
    {

        // Atributos

        public int Id { get; set; }
        public DateTime Data { get; set; }
        public string Status { get; set; }
        public double Desconto { get; set; }

        // Construtores

        public VendaModel()
        {
        }

        public VendaModel(int id, DateTime data, string status)
        {
            Id = id;
            Data = data;
            Status = status;
        }

        public VendaModel(DateTime data, double desconto)
        {
            Data = data;
            Desconto = desconto;
        }
    }
}