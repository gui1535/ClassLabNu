namespace ComercialSys.Model
{
    public class Pagamento
    {
        // Atributos
        public int Id { get; set; }
        public double Valor { get; set; }

        // Construtores
        public Pagamento()
        {
        }

        public Pagamento(int id, double valor)
        {
            Id = id;
            Valor = valor;
        }

        public Pagamento(double valor)
        {
            Valor = valor;
        }

        // Metodos


    }
}
