using System.Collections.Generic;

namespace ClassLabNu
{
    public class Produto
    {
        // Atributos / Propriedades ----------------------------------------------------

        private readonly int id;
        private readonly string descricao;
        private readonly int unidade;
        private readonly string codbar;
        private readonly double valor;
        private readonly double desconto;

        // Construtores ----------------------------------------------------------------

        public Produto()
        {
        }

        public Produto(int id, string descricao, int unidade, string codbar, double valor, double desconto)
        {
            this.id = id;
            this.descricao = descricao;
            this.unidade = unidade;
            this.codbar = codbar;
            this.valor = valor;
            this.desconto = desconto;
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

        public static Produto ConsultarPorId(int _id)
        {
            Produto produto = new Produto();
            return produto;
        }

        public static Produto ConsultarPorValor(int _valor)
        {
            Produto produto = new Produto();
            return produto;
        }

        public static Produto ConsultarPorDescricao(string _descricao)
        {
            Produto produto = new Produto();
            return produto;
        }

        public static Produto ConsultarPorCodbar(int _codbar)
        {
            Produto produto = new Produto();
            return produto;
        }
        
        public static List<Produto> Listar()
        {
            List<Produto> produto = new List<Produto>();
            return produto;
        }
    }
}