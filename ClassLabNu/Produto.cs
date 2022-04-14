using System;
using System.Collections.Generic;
using System.Data;

namespace ClassLabNu
{
    public class Produto
    {
        // Atributos / Propriedades ----------------------------------------------------

        public int Id { get; set; }
        public string Descricao { get; set; }
        public string Unidade { get; set; }
        public string Codbar { get; set; }
        public double Valor { get; set; }
        public double Desconto { get; set; }
        public bool Descontinuado { get; set; }

        // Construtores ----------------------------------------------------------------

        public Produto()
        {
        }
        public Produto(int id, string descricao, string unidade, string codbar, double valor, double desconto)
        {
            Id = id;
            this.Descricao = descricao;
            this.Unidade = unidade;
            this.Codbar = codbar;
            this.Valor = valor;
            this.Desconto = desconto;
        }

        public Produto(int id, string descricao, string unidade, string codbar, double valor, double desconto, bool descontinuado)
        {
            Id = id;
            this.Descricao = descricao;
            this.Unidade = unidade;
            this.Codbar = codbar;
            this.Valor = valor;
            this.Desconto = desconto;
            this.Descontinuado = descontinuado;
        }

        public Produto(int id, string descricao, string unidade, string codbar, double valor)
        {
            Id = id;
            this.Descricao = descricao;
            this.Unidade = unidade;
            this.Codbar = codbar;
            this.Valor = valor;
        }


        public Produto(string descricao, string unidade, string codbar, double valor, double desconto)
        {
            this.Descricao = descricao;
            this.Unidade = unidade;
            this.Codbar = codbar;
            this.Valor = valor;
            this.Desconto = desconto;
        }


        // Metodos ---------------------------------------------------------------------

        public void Inserir()
        {
            // Abre conexão com banco
            var banco = Banco.Abrir();

            // Comandos SQL
            banco.CommandType = CommandType.StoredProcedure;
            banco.CommandText = "produto_inserir";

            // Parametros
            banco.Parameters.AddWithValue("_descricao", Descricao);
            banco.Parameters.AddWithValue("_unidade", Unidade);
            banco.Parameters.AddWithValue("_codbar", Codbar);
            banco.Parameters.AddWithValue("_desconto", Desconto);
            banco.Parameters.AddWithValue("_valor", Valor);
            Id = Convert.ToInt32(banco.ExecuteScalar());

            // Fecha Conexão
            banco.Connection.Close();
        }

        public void Alterar(Produto Produto)
        {
            
        }

        public void ConsultarPorId(int _id)
        {
            // Abre conexao com banco
            var cmd = Banco.Abrir();

            // Comandos SQL
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = $"select * from produtos where idprod = {_id}";

            // Var para leitura
            var dr = cmd.ExecuteReader();

            // Consulta
            while (dr.Read())
            {
                Id = dr.GetInt32(0);
                Descricao = dr.GetString(1);
                Unidade = dr.GetString(2);
                Codbar = dr.GetString(3);
                Valor = dr.GetInt32(4);
                Desconto = dr.GetInt32(5);
                Descontinuado = dr.GetBoolean(5);
            }
        }

        public void ConsultarPorValor(int _valor)
        {
            // Abre conexao com banco
            var cmd = Banco.Abrir();

            // Comandos SQL
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = $"select * from produtos where valor = {_valor}";

            // Var para leitura
            var dr = cmd.ExecuteReader();

            // Consulta
            while (dr.Read())
            {
                Id = dr.GetInt32(0);
                Descricao = dr.GetString(1);
                Unidade = dr.GetString(2);
                Codbar = dr.GetString(3);
                Valor = dr.GetInt32(4);
                Desconto = dr.GetInt32(5);
                Descontinuado = dr.GetBoolean(5);

            }
        }

        public void ConsultarPorCodbar(string _codbar)
        {

            // Abre conexao com banco
            var cmd = Banco.Abrir();

            // Comandos SQL
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = $"select * from produtos where valor = {_codbar}";

            // Var para leitura
            var dr = cmd.ExecuteReader();

            // Consulta
            while (dr.Read())
            {
                Id = dr.GetInt32(0);
                Descricao = dr.GetString(1);
                Unidade = dr.GetString(2);
                Codbar = dr.GetString(3);
                Valor = dr.GetInt32(4);
                Desconto = dr.GetInt32(5);
                Descontinuado = dr.GetBoolean(5);
            }
        }

        public List<Produto> ListarTodos(int i = 0, int l = 0)
        {
            // Nova lista
            List<Produto> lista = new List<Produto>();

            // Abrir conexão
            var banco = Banco.Abrir();

            // Comando
            banco.CommandType = CommandType.Text;
            if (l > 0)
                banco.CommandText = $"select * from produtos limit {i} , {l}";
            else
                banco.CommandText = "select * from produtos";

            // Var para Consulta
            var dr = banco.ExecuteReader();

            // Consulta
            while (dr.Read())
            {
                lista.Add(new Produto(
                    Convert.ToInt32(dr.GetValue(0)), // ID
                    dr.GetString(1), // Descricao
                    dr.GetString(2), // Unidade
                    dr.GetString(3), // CodBar
                    dr.GetDouble(4), // Valor
                    dr.GetDouble(5), // Desconto
                     dr.GetBoolean(6) // Descontinuado
                    ));
            }

            // Fecha Conexão
            banco.Connection.Close();

            // Retornando lista
            return lista;
        }
    }
}