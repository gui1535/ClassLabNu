using System;
using System.Collections.Generic;

namespace ClassLabNu
{
    public class Pedido
    {
        // idped	data	status_ped	desconto	idcli_ped	iduser_ped

        // Atributos

        private readonly int Id;
        private readonly DateTime DataPed;
        private readonly string Status;
        private readonly double desconto;
        private readonly Cliente cliente;
        private readonly Usuario usuario;
        private readonly List<ItemPedido> itens;

        // Construtores

        public Pedido()
        {
        }

        public Pedido(DateTime dataPed, string status, double desconto, Cliente cliente, Usuario usuario, List<ItemPedido> itens)
        {
            DataPed = dataPed;
            Status = status;
            this.desconto = desconto;
            this.cliente = cliente;
            this.usuario = usuario;
            this.itens = itens;
        }
        public Pedido(int id, DateTime dataPed, string status, double desconto, Cliente cliente, Usuario usuario, List<ItemPedido> itens)
        {
            Id = id;
            DataPed = dataPed;
            Status = status;
            this.desconto = desconto;
            this.cliente = cliente;
            this.usuario = usuario;
            this.itens = itens;
        }

        // Metodos

        public void Inserir()
        {

        }

        public bool Alterar(Pedido pedido)
        {
            return false;
        }

        public static Pedido ConsultarPorId(int _id)
        {
            Pedido pedido = new Pedido();
            // Conecta o banco e realiza consulta por Id do pedido
            return pedido;
        }

        public static List<Pedido> ConsultarPorClienteId(int _id)
        {
            List<Pedido> pedidos = new List<Pedido>();
            return pedidos;
        }

    }
}