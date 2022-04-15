using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace ClassLabNu
{
    public class Cliente
    {
        // Atributos  ------------------------------------------------------------------

        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Email { get; set; }
        public string dataCad { get; set; }
        public bool Ativo { get; set; }

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
        public Cliente(int id)
        {
            Id = id;

        }

        public Cliente(int id, string nome, string cpf, string email, string dataCad, bool ativo)
        {
            this.Id = id;
            this.Nome = nome;
            this.Cpf = cpf;
            this.Email = email;
            this.dataCad = dataCad;
            this.Ativo = ativo;
        }
     


        public Cliente(string nome, string cpf, string email)
        {
            Nome = nome;
            Cpf = cpf;
            Email = email;
        }
        public Cliente(int id, string nome, string cpf, string email)
        {
            Id = id;
            Nome = nome;
            Cpf = cpf;
            Email = email;
        }

        // Metodos ---------------------------------------------------------------------

        public void Inserir()
        {

            try
            {
                // Abre conexão com banco
                var banco = Banco.Abrir();

                // Comandos SQL
                banco.CommandType = System.Data.CommandType.StoredProcedure;
                banco.CommandText = "cliente_inserir";

                // Parametros
                banco.Parameters.AddWithValue("_nome", Nome);
                banco.Parameters.AddWithValue("_cpf", Cpf);
                banco.Parameters.AddWithValue("_email", Email);
                Id = Convert.ToInt32(banco.ExecuteScalar());

                // Fecha Conexão
                banco.Connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocorreu um erro, verifique os valores digitados {ex}", "SysComercial", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        public void Alterar(Cliente cliente)
        {
            //
        }

        public void ConsultarPorId(int _id)
        {
            // Abre conexao com banco
            var cmd = Banco.Abrir();

            // Comandos SQL
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = $"select * from clientes where idcli = {_id}";

            // Var para leitura
            var dr = cmd.ExecuteReader();

            // Consulta
            while (dr.Read())
            {
                Id = dr.GetInt32(0);
                Nome = dr.GetString(1);
                Cpf = dr.GetString(2);
                Email = dr.GetString(3);
                dataCad = dr.GetString(4);
                Ativo = dr.GetBoolean(5);
            }



        }

        public void ConsultarPorCpf(string _cpf)
        {
            // Abre conexao com banco
            var cmd = Banco.Abrir();

            // Comandos SQL
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = $"select * from clientes where cpf = {_cpf}";

            // Var para leitura
            var dr = cmd.ExecuteReader();

            // Consulta
            while (dr.Read())
            {
                Id = dr.GetInt32(0);
                Nome = dr.GetString(1);
                Cpf = dr.GetString(2);
                Email = dr.GetString(3);
                dataCad = dr.GetString(4);
                Ativo = dr.GetBoolean(5);
            }
        }

        public void ConsultarPorNome(string _nome)
        {
            // Abre conexao com banco
            var cmd = Banco.Abrir();

            // Comandos SQL
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = $"select * from clientes where nome = {_nome}";

            // Var para leitura
            var dr = cmd.ExecuteReader();

            // Consulta
            while (dr.Read())
            {
                Id = dr.GetInt32(0);
                Nome = dr.GetString(1);
                Cpf = dr.GetString(2);
                Email = dr.GetString(3);
                dataCad = dr.GetString(4);
                Ativo = dr.GetBoolean(5);
            }
        }

        public List<Cliente> ListarClientes(int i = 0, int l = 0)
        {
            // Nova lista
            List<Cliente> lista = new List<Cliente>();

            // Abrir conexão
            var banco = Banco.Abrir();

            // Comando
            banco.CommandType = CommandType.Text;
            if (l > 0)
                banco.CommandText = $"select * from clientes limit {i} , {l}";
            else
                banco.CommandText = "select * from clientes";

            // Var para Consulta
            var dr = banco.ExecuteReader();

            // Consulta
            while (dr.Read())
            {
                lista.Add(new Cliente(
                    Convert.ToInt32(dr.GetValue(0)), // ID
                    dr.GetString(1), // Nome
                    dr.GetString(2), // Cpf
                    dr.GetString(3), // Email
                    dr.GetString(4), // Datacad
                    dr.GetBoolean(5) // Ativo
                    ));
            }

            // Fecha Conexão
            banco.Connection.Close();

            // Retornando lista
            return lista;
        }
    }
}
