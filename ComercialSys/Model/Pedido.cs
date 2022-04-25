﻿using System;
using System.Collections.Generic;
using System.Data;

namespace ComercialSys.Model
{
    public class Pedido
    {
        // idped	data	status_ped	desconto	idcli_ped	iduser_ped

        // Atributos

        public int Id { get; set; }
        public DateTime DataPed { get; set; }
        public string Status { get; set; }
        public double Desconto { get; set; }
        public Cliente Cliente { get; set; }
        public Usuario Usuario { get; set; }
        public List<ItemPedido> Itens { get; set; }

        // Construtores

        public Pedido()
        {
        }

        public Pedido(DateTime dataPed, string status, double desconto, Cliente cliente, Usuario usuario, List<ItemPedido> itens)
        {
            DataPed = dataPed;
            Status = status;
            this.Desconto = desconto;
            this.Cliente = cliente;
            this.Usuario = usuario;
            this.Itens = itens;
        }
        public Pedido(int id, DateTime dataPed, string status, double desconto, Cliente cliente, Usuario usuario, List<ItemPedido> itens)
        {
            Id = id;
            DataPed = dataPed;
            Status = status;
            this.Desconto = desconto;
            this.Cliente = cliente;
            this.Usuario = usuario;
            this.Itens = itens;
        }

        // Metodos

        public void Inserir()
        {
            // Abre conexão com banco
            var cmd = Banco.Abrir();

            // Comandos SQL
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert pedidos values(@idped, @dataped, @status, @desconto)";

            // Parametros SQL
            cmd.Parameters.AddWithValue("@idped", null);
            cmd.Parameters.AddWithValue("@dataped", DataPed);
            cmd.Parameters.AddWithValue("@status", Status);
            cmd.Parameters.AddWithValue("@desconto", Desconto);
            cmd.ExecuteNonQuery();

            // Pega o ultimo ID criado
            cmd.CommandText = "select @@identity";

            // Guarda o ultimo ID criado no Id
            Id = Convert.ToInt32(cmd.ExecuteScalar());

            // Limpar parametros
            cmd.Parameters.Clear();
        }

        public void Alterar(Pedido pedido)
        {
            try // Faça
            {
                // Abrir conexão com banco
                var cmd = Banco.Abrir();

                // Comandos SQL
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "altera_Pedido";
                cmd.Parameters.AddWithValue("_idped", Id).Direction = ParameterDirection.Input;
                cmd.Parameters.AddWithValue("_dataped", DataPed).Direction = ParameterDirection.Input;
                cmd.Parameters.AddWithValue("_status", Status).Direction = ParameterDirection.Input;
                cmd.Parameters.AddWithValue("_desconto", Desconto).Direction = ParameterDirection.Input;
                cmd.ExecuteNonQuery();

            }
            catch (Exception) // Exception
            {
                throw;
            }
        }

        public void ConsultarPorId(int _id)
        {
            // Abre conexão com banco
            var cmd = Banco.Abrir();

            // Comandos SQL
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "select * from pedidos where id = " + _id;

            // Variavel para consulta
            var dr = cmd.ExecuteReader();

            // Consulta
            while (dr.Read())
            {
                Id = dr.GetInt32(0);
                DataPed = dr.GetDateTime(1);
                Status = dr.GetString(2);
                Desconto = dr.GetDouble(3);
            }
        }

        // ----------------------------------------------------------
        public static List<Pedido> ConsultarPorClienteId(int _id)
        {
            List<Pedido> pedidos = new List<Pedido>();
            return pedidos;
        }

    }
}