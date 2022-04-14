using System;
using System.Collections.Generic;
using System.Data;

namespace ClassLabNu
{
    public class Produto
    {
        // Atributos / Propriedades ----------------------------------------------------

        private int Id;
        private string descricao;
        private string unidade;
        private string codbar;
        private double valor;
        private double desconto;
        private bool descontinuado;

        // Propriedades ----------------------------------------------------------------

        public int id { get => Id; }
        public string Descricao { get => descricao; }
        public string Unidade { get => unidade; }
        public string Codbar { get => codbar; }
        public double Valor { get => valor; }
        public double Desconto { get => desconto; }
        public bool Descontinuado { get => descontinuado; }

        // Construtores ----------------------------------------------------------------

        public Produto()
        {
        }

        public Produto(int id, string descricao, string unidade, string codbar, double valor, double desconto, bool descontinuado)
        {
            id = Id;
            this.descricao = descricao;
            this.unidade = unidade;
            this.codbar = codbar;
            this.valor = valor;
            this.desconto = desconto;
            this.descontinuado = descontinuado;
        }

        public Produto(int id, string descricao, string unidade, string codbar, double valor)
        {
            id = this.id;
            this.descricao = descricao;
            this.unidade = unidade;
            this.codbar = codbar;
            this.valor = valor;
        }


        public Produto(string descricao, string unidade, string codbar, double valor, double desconto)
        {
            this.descricao = descricao;
            this.unidade = unidade;
            this.codbar = codbar;
            this.valor = valor;
            this.desconto = desconto;
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
            banco.Parameters.AddWithValue("_valor", Valor);
            banco.Parameters.AddWithValue("_desconto", Desconto);
            Id = Convert.ToInt32(banco.ExecuteScalar());

            // Fecha Conexão
            banco.Connection.Close();

        }

        public void Alterar(Produto Produto)
        {
            
        }

        public void ConsultarPorId(int _id)
        {
           
        }

        public void ConsultarPorValor(int _valor)
        {
        }

        public List<Produto> ConsultarPorDescricao(string _descricao)
        {
            List <Produto> lista = new List<Produto>();
            return lista;
        }

        public void ConsultarPorCodbar(int _codbar)
        {
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