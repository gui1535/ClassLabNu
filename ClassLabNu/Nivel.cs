namespace ClassLabNu
{
    public class Nivel
    {
        // Atributos -> Campos
        private int id;
        private string nome;
        private string sigla;
        public bool ativo;

        // Propriedades ------------------------------------------------------------------

        public int Id { get { return id; } }
        public string Nome { get { return nome; } private set { nome = value; } }
        public int Sigla { get { return Sigla; } }

        // Metodos Contrutores ------------------------------------------------------------------

        public Nivel()
        {
        }

        public Nivel(string nome, string sigla)
        {
            this.nome = nome;
            this.sigla = sigla;
            ativo = true;
        }

        public Nivel(int id, string nome, string sigla, bool ativo)
        {
            this.id = id;
            this.nome = nome;
            this.sigla = sigla;
            this.ativo = ativo;
        }

        public void InserirNovo()
        {
            // Inserir um novo nível
        }

        
        public bool Alterar(int id, string sigla)
        {/// <summary>
        /// Altera a sigla do nível indicado. Apenas administradores.
        /// </summary>
        /// <param name="id">Identificação do nível</param>
        /// <param name="sigla">Valor literal da nova sigla</param>
        /// <returns>Retorna valor para teste lógico, confirmando a alteração</returns>
            return true;
        }
    }
}
