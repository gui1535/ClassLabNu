using System;
using System.Collections.Generic;
using System.Data;

namespace ClassLabNu
{
    public class Produto
    {
        // Atributos / Propriedades ----------------------------------------------------

        private int id;
        private string descricao;
        private double unidade;
        private string codbar;
        private double valor;
        private double desconto;
        private bool descontinuado;

        // Propriedades ----------------------------------------------------------------

        public int Id { get => id; }
        public string Descricao { get => descricao; }
        public double Unidade { get => unidade; }
        public string Codbar { get => codbar; }
        public double Valor { get => valor; }
        public double Desconto { get => desconto; }
        public bool Descontinuado { get => descontinuado; }

        // Construtores ----------------------------------------------------------------

        public Produto()
        {
        }

        public Produto(int id, string descricao, double unidade, string codbar, double valor, double desconto, bool descontinuado)
        {
            this.id = id;
            this.descricao = descricao;
            this.unidade = unidade;
            this.codbar = codbar;
            this.valor = valor;
            this.desconto = desconto;
            this.descontinuado = descontinuado;
        }

        public Produto(int id, string descricao, int unidade, string codbar, double valor)
        {
            this.id = id;
            this.descricao = descricao;
            this.unidade = unidade;
            this.codbar = codbar;
            this.valor = valor;
        }

        // Metodos ---------------------------------------------------------------------

        public void Inserir()
        {
            // Abre conexão com banco
            var cmd = Banco.Abrir();

            // Comandos SQL
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert produtos values(@id, @descricao, @unidade, @codbar, @valor, @desconto, @descontinuado)";

            // Parametros SQL
            cmd.Parameters.AddWithValue("@id", null);
            cmd.Parameters.AddWithValue("@descricao", Descricao);
            cmd.Parameters.AddWithValue("@unidade", Unidade);
            cmd.Parameters.AddWithValue("@codbar", Codbar);
            cmd.Parameters.AddWithValue("@valor", Valor);
            cmd.Parameters.AddWithValue("@desconto", Desconto);
            cmd.Parameters.AddWithValue("@descontinuado", Descontinuado);
            cmd.ExecuteNonQuery();

            // Pega o ultimo ID criado
            cmd.CommandText = "select @@identity";

            // Guarda o ultimo ID criado no Id
            id = Convert.ToInt32(cmd.ExecuteScalar());

            // Limpar parametros
            cmd.Parameters.Clear();
        }

        public void Alterar(Produto Produto)
        {
            try // Faça
            {
                // Abrir conexão com banco
                var cmd = Banco.Abrir();

                // Comandos SQL
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "altera_Produto";
                cmd.Parameters.AddWithValue("_id", Id).Direction = ParameterDirection.Input;
                cmd.Parameters.AddWithValue("_descricao", Descricao).Direction = ParameterDirection.Input;
                cmd.Parameters.AddWithValue("_unidade", Unidade).Direction = ParameterDirection.Input;
                cmd.Parameters.AddWithValue("_codbar", Codbar).Direction = ParameterDirection.Input;
                cmd.Parameters.AddWithValue("_valor", Valor).Direction = ParameterDirection.Input;
                cmd.Parameters.AddWithValue("_desconto", Desconto).Direction = ParameterDirection.Input;
                cmd.Parameters.AddWithValue("_descontinuado", Descontinuado).Direction = ParameterDirection.Input;
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
            cmd.CommandText = "select * from produtos where id = " + _id;

            // Variavel para consulta
            var dr = cmd.ExecuteReader();

            // Consulta
            while (dr.Read())
            {
                id = dr.GetInt32(0);
                descricao = dr.GetString(1);
                unidade = dr.GetDouble(2);
                codbar = dr.GetString(3);
                valor = dr.GetDouble(4);
                desconto = dr.GetDouble(5);
                descontinuado = dr.GetBoolean(6);
            }
        }

        public void ConsultarPorValor(int _valor)
        {
            // Abre conexão com banco
            var cmd = Banco.Abrir();

            // Comandos SQL
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "select * from produtos where valor = " + _valor;

            // Variavel para consulta
            var dr = cmd.ExecuteReader();

            // Consulta
            while (dr.Read())
            {
                id = dr.GetInt32(0);
                descricao = dr.GetString(1);
                unidade = dr.GetDouble(2);
                codbar = dr.GetString(3);
                valor = dr.GetDouble(4);
                desconto = dr.GetDouble(5);
                descontinuado = dr.GetBoolean(6);
            }
        }

        public List<Produto> ConsultarPorDescricao(string _descricao)
        {
        }

        public void ConsultarPorCodbar(int _codbar)
        {
            // Abre conexão com banco
            var cmd = Banco.Abrir();

            // Comandos SQL
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "select * from produtos where codbar = " + _codbar;

            // Variavel para consulta
            var dr = cmd.ExecuteReader();

            // Consulta
            while (dr.Read())
            {
                id = dr.GetInt32(0);
                descricao = dr.GetString(1);
                unidade = dr.GetDouble(2);
                codbar = dr.GetString(3);
                valor = dr.GetDouble(4);
                desconto = dr.GetDouble(5);
                descontinuado = dr.GetBoolean(6);
            }
        }

        public List<Produto> ListarTodos(int limite, int inicio)
        {
            // Lista Cliente
            List<Produto> produtos = new List<Produto>();

            // Abrir conexão com banco
            var cmd = Banco.Abrir();

            // Comandos SQL
            cmd.CommandType = System.Data.CommandType.Text;

            // Enquanto limite for maior que 0
            if (limite > 0)
            {
                cmd.CommandText = $"select * from produtos limit {inicio}, {limite}";
            }
            else
            {
                cmd.CommandText = "select * from produtos";
            }

            // Variavel para consulta
            var dr = cmd.ExecuteReader();

            // Consulta
            while (dr.Read())
            {
                produtos.Add(new Produto(
                Convert.ToInt32(dr.GetValue(0)),
                dr.GetString(1),
                dr.GetDouble(2),
                dr.GetString(3),
                dr.GetDouble(4),
                dr.GetDouble(5),
                dr.GetBoolean(6)
                    ));
            }
            return produtos;
        }
    }
}