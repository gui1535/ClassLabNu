using System;
using System.Collections.Generic;

namespace ClassLabNu
{
    public class Cliente
    {
        // Atributos  ------------------------------------------------------------------

        private int id;
        private string nome;
        private string cpf;
        private string email;
        private DateTime dataCad;
        private bool ativo;

        // Propriedades ----------------------------------------------------------------

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        public string Cpf
        {
            get{ return cpf; }
            set { cpf = value; }
        }
        public DateTime DataCad
        {
            get { return dataCad; }
            set { dataCad = value; }
        }
        public bool Ativo
        {
            get { return ativo; }
            set { ativo = value; }
        }

        // Construtores ----------------------------------------------------------------

        public Cliente()
        {
        }

        public Cliente(int id, string nome, string cpf)
        {
            Id = id;
            Nome = nome;
            Cpf = cpf;
            // DataCad = DateTime.Now;
            // ativo = true;
        }

        public Cliente(int id, string nome, string cpf, string email, DateTime dataCad, bool ativo)
        {
            this.Id = id;
            this.Nome = nome;
            this.Cpf = cpf;
            this.email = email;
            this.DataCad = dataCad;
            this.Ativo = ativo;
        }
        // Metodos ---------------------------------------------------------------------
        public void Inserir(Cliente cliente)
        {

        }

        public bool Alterar(Cliente cliente)
        {
            return true;
        }

        public static Cliente ConsultarPorId(int _id)
        {
            Cliente cliente = new Cliente();
            return cliente;
        }

        public static Cliente ConsultarPorCpf(string _cpf)
        {
            Cliente cliente = new Cliente();
            Cliente cliente2 = new Cliente();   
            return cliente;
        }

        public static List<Cliente> Listar()
        {
            List<Cliente> clientes = new List<Cliente>();
            return clientes;
        }
    }
}
