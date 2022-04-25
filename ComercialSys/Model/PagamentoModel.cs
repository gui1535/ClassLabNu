namespace ComercialSys.Model
{
    public class PagamentoModel
    {
        // Atributos
        public int Id { get; set; }
        public double Valor { get; set; }

        // Construtores
        public PagamentoModel()
        {
        }

        public PagamentoModel(int id, double valor)
        {
            Id = id;
            Valor = valor;
        }

        public PagamentoModel(double valor)
        {
            Valor = valor;
        }

        // Metodos


    }
}
