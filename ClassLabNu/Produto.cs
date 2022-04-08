using System.Collections.Generic;

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
        public string Codbar { get => codbar;  }
        public double Valor { get => valor; }
        public double Desconto { get => desconto; }
        public bool Descontinuado { get => descontinuado; }

        // Construtores ----------------------------------------------------------------

        public Produto()
        {
        }

        public Produto(int id, string descricao, int unidade, string codbar, double valor, double desconto, bool descontinuado)
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

        }

        public bool Alterar(Produto Produto)
        {
            return true;
        }

        public  Produto ConsultarPorId(int _id)
        {
            Produto produto = new Produto();
            return produto;
        }

        public  Produto ConsultarPorValor(int _valor)
        {
            Produto produto = new Produto();
            return produto;
        }

        public  List<Produto> ConsultarPorDescricao(string _descricao)
        {
            List<Produto> produtos = new List<Produto>();
            return produtos;
        }

        public  Produto ConsultarPorCodbar(int _codbar)
        {
            Produto produto = new Produto();
            return produto;
        }

        public static List<Produto> ListarTodos()
        {
            List<Produto> produto = new List<Produto>();
            return produto;
        }
    }
}