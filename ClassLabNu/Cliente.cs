using System;
using System.Collections.Generic;
using System.Data;
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
        public DateTime dataCad { get; set; }
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

        public Cliente(int id, string nome, string cpf, string email, DateTime dataCad, bool ativo)
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

        // Metodos ---------------------------------------------------------------------

        public void Inserir()
        {

            try
            {
                // Abre conexão com banco
                var cmd = Banco.Abrir();

                // Comandos SQL
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert clientes values(@id, @nome, @cpf, @email, default, 1)";

                //cmd.CommandText = $"insert clientes(nome, cpf, email, datacad, ativo) values('{cliente.Nome}', '{cliente.Cpf}', '{cliente.Email}', 'default', 'default')";

                // Parametros SQL
                cmd.Parameters.AddWithValue("@id", 0);
                cmd.Parameters.AddWithValue("@nome", Nome);
                cmd.Parameters.AddWithValue("@cpf", Cpf);
                cmd.Parameters.AddWithValue("@email", Email);

                // Executar
                cmd.ExecuteNonQuery();

                // Pega o ultimo ID criado
                cmd.CommandText = "select @@identity";

                // Guarda o ultimo ID na propriedade
                Id = Convert.ToInt32(cmd.ExecuteScalar());

                // Limpar parametros
                cmd.Parameters.Clear();

                // Fecha Conexão
                cmd.Connection.Close();
            }
            catch (Exception)
            {
                MessageBox.Show($"Ocorreu um erro, verifique os valores digitados", "SysComercial", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        public bool Alterar(Cliente cliente)
        {

            // Abre conexão com banco
            var cmd = Banco.Abrir();

            // Comandos SQL
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update clientes set nome = @nome,cpf = @cpf,email = @email where id = @id";

            // Parametros SQL
            cmd.Parameters.AddWithValue("@nome", Nome);
            cmd.Parameters.AddWithValue("@cpf", Cpf);
            cmd.Parameters.AddWithValue("@email", Email);

            // Variavel ExeRetorno recebe o execute do Query
            int QueryRetorno = cmd.ExecuteNonQuery();

            // Limpar parametros
            cmd.Parameters.Clear();

            // Fecha Conexão
            cmd.Connection.Close();


            // Condição para retornar bool
            if (QueryRetorno == 1)
            {
                // Se o valor for 1
                return true;
            }
            else
            {
                // Se o valor nao for 1
                return false;
            }


        }

        public void ConsultarPorId(int _id)
        {
            // Abre conexão com banco
            var cmd = Banco.Abrir();

            // Comandos SQL
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from clientes where id = " + _id;

            // Variavel para consulta
            var dr = cmd.ExecuteReader();

            // Consulta
            while (dr.Read())
            {
                Id = dr.GetInt32(0);
                Nome = dr.GetString(1);
                Cpf = dr.GetString(2);
                Email = dr.GetString(3);
                dataCad = dr.GetDateTime(4);
                Ativo = dr.GetBoolean(5);
            }
        }

        public void ConsultarPorCpf(string _cpf)
        {
            // Abre conexão com banco
            var cmd = Banco.Abrir();

            // Comandos SQL
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "select * from clientes where cpf = " + _cpf;

            // Variavel para consulta
            var dr = cmd.ExecuteReader();

            // Consulta
            while (dr.Read())
            {
                Id = dr.GetInt32(0);
                Nome = dr.GetString(1);
                Cpf = dr.GetString(2);
                Email = dr.GetString(3);
                dataCad = dr.GetDateTime(4);
                Ativo = dr.GetBoolean(5);
            }
        }

        public List<Cliente> ListarClientes(int inicio, int limite)
        {
            // Lista Cliente
            List<Cliente> lista = new List<Cliente>();

            // Abrir conexão com banco
            var cmd = Banco.Abrir();

            // Comandos SQL
            cmd.CommandType = System.Data.CommandType.Text;

            // Enquanto limite for maior que 0
            if (limite > 0)
            {
                cmd.CommandText = $"select * from clientes limit {inicio}, {limite}";
            }
            else
            {
                cmd.CommandText = "select * from clientes";
            }

            // Variavel para consulta
            var dr = cmd.ExecuteReader();

            // Consulta
            while (dr.Read())
            {
                lista.Add(new Cliente(
                    Convert.ToInt32(dr.GetValue(0)),
                    dr.GetString(1),
                    dr.GetString(2),
                    dr.GetString(3),
                    dr.GetDateTime(4),
                    dr.GetBoolean(5)
                    ));
            }

            // Retornando lista
            return lista;
        }
    }
}
