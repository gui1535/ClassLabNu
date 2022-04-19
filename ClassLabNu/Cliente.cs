using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace ClassLabNu
{
    public class Cliente
    {
        // Atributos  ------------------------------------------------------------------

        public int Id { get; set; } // Id do Cliente
        public string Nome { get; set; } // Nome do Cliente
        public string Cpf { get; set; } // CPF d Cliente
        public string Email { get; set; } // Email do Cliente
        public string dataCad { get; set; } // Data de cadastro do Cliente
        public bool Ativo { get; set; } // Cliente Ativo

        // Construtores ----------------------------------------------------------------

        /// <summary>
        /// Construtor vazio para o Cliente
        /// </summary>
        public Cliente()
        {
        }

        /// <summary>
        /// Construtor para o Cliente
        /// </summary>
        /// <param name="id">INT(11)</param>
        /// <param name="nome">VARCHAR(60)</param>
        /// <param name="cpf">CHAR(11)</param>
        public Cliente(int id, string nome, string cpf)
        {
            Id = id;
            Nome = nome;
            Cpf = cpf;
        }

        /// <summary>
        /// Construtor para o Cliente
        /// </summary>
        /// <param name="id">INT</param>
        public Cliente(int id)
        {
            Id = id;

        }

        /// <summary>
        /// Construtor para o Cliente
        /// </summary>
        /// <param name="id">INT</param>
        /// <param name="nome">VARCHAR(60)</param>
        /// <param name="cpf">CHAR(11)</param>
        /// <param name="email">VARCHAR(60)</param>
        /// <param name="dataCad">VARCHAR(60)</param>
        /// <param name="ativo">BIT(1)</param>
        public Cliente(int id, string nome, string cpf, string email, string dataCad, bool ativo)
        {
            this.Id = id;
            this.Nome = nome;
            this.Cpf = cpf;
            this.Email = email;
            this.dataCad = dataCad;
            this.Ativo = ativo;
        }

        /// <summary>
        /// Construtor para o Cliente
        /// </summary>
        /// <param name="nome">VARCHAR(60)</param>
        /// <param name="cpf">CHAR(11)</param>
        /// <param name="email">VARCHAR(60)</param>
        /// <param name="ativo">BIT(1)</param>
        public Cliente(string nome, string cpf, string email, bool ativo)
        {
            this.Nome = nome;
            this.Cpf = cpf;
            this.Email = email;
            this.Ativo = ativo;
        }

        /// <summary>
        /// Construtor para o Cliente
        /// </summary>
        /// <param name="nome">VARCHAR(60)</param>
        /// <param name="cpf">CHAR(11)</param>
        /// <param name="email">VARCHAR(60)</param>
        public Cliente(string nome, string cpf, string email)
        {
            Nome = nome;
            Cpf = cpf;
            Email = email;
        }

        /// <summary>
        /// Construtor para o Cliente
        /// </summary>
        /// <param name="id">INT</param>
        /// <param name="nome">VARCHAR(60)</param>
        /// <param name="cpf">CHAR(11)</param>
        /// <param name="email">VARCHAR(60)</param>
        public Cliente(int id, string nome, string cpf, string email)
        {
            Id = id;
            Nome = nome;
            Cpf = cpf;
            Email = email;
        }

        // Metodos ---------------------------------------------------------------------

        /// <summary>
        /// Metodo para inserir cliente no banco de dados
        /// </summary>
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
                MessageBox.Show($"Ocorreu um erro {ex}", "SysComercial", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        /// <summary>
        /// Metodo para alterar cliente no banco de dados
        /// </summary>
        /// <returns>Bool</returns>
        public bool Alterar()
        {

            // Abrir conexao
            var cmd = Banco.Abrir();

            // Comando SQL
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = $"cliente_alterar";

            // Parametros
            cmd.Parameters.AddWithValue("_id", Id);
            cmd.Parameters.AddWithValue("_nome", Nome);
            cmd.Parameters.AddWithValue("_email", Email);
            cmd.Parameters.AddWithValue("_ativo", Ativo);

            // Variavel para receber retorno
            int retorna = cmd.ExecuteNonQuery();

            cmd.Connection.Close();

            // Retornando valor
            if (retorna == 1)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        /// <summary>
        /// Metodo para consultar cliente por ID
        /// </summary>
        /// <param name="_id">int</param>
        public void ConsultarPorId(int _id)
        {

            // Abre conexao com banco
            var cmd = Banco.Abrir();

            // Comandos SQL
            cmd.CommandType = CommandType.Text;
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

        /// <summary>
        /// Metodo para consultar cliente por CPF
        /// </summary>
        /// <param name="_cpf">string</param>
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

        /// <summary>
        /// Metodo para consultar cliente por Nome
        /// </summary>
        /// <param name="_nome">string</param>
        public void ConsultarPorNome(string _nome)
        {
            // Abre conexao com banco
            var cmd = Banco.Abrir();

            // Comandos SQL
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = $"select * from clientes where nome = '{_nome}'";

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

        /// <summary>
        /// Metodo para listar clientes do banco de dados
        /// </summary>
        /// <param name="i">int</param>
        /// <param name="l">int</param>
        /// <returns>Lista</returns>
        public List<Cliente> ListarClientes(int i = 0, int l = 0)
        {
            // Nova lista
            List<Cliente> lista = new List<Cliente>();

            // Abrir conexão
            var banco = Banco.Abrir();

            // Comando
            banco.CommandType = CommandType.Text;
            if (l > 0)
                banco.CommandText = $"select * from clientes where ativo = 1 limit {i}, {l}";
            else
                banco.CommandText = "select * from clientes where ativo = 1";

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

        /// <summary>
        /// Desativar cliente
        /// </summary>
        /// <param name="_id">int</param>
        public void Desativar(int _id)
        {
            // Abrir conexao
            var cmd = Banco.Abrir();

            // Comandos SQL
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"update clientes set ativo = 0 where idcli = {_id}";

            // Leitura
            cmd.ExecuteReader();

            // Fecha conexao
            cmd.Connection.Close();

        }
    }
}
