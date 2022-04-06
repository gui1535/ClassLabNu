namespace ClassLabNu
{
    // Documentação de classes de projeto -> XML Docs

    public class Usuario
    {

        // Atributos -----------------------------------------------------------------------------

        private int id;
        private string nome;
        private string email;
        private string password;
        private bool ativo;

        // Propriedades --------------------------------------------------------------------------

        public int Id
        {
            get { return id; }
        }
        public string Nome
        {
            get { return nome; }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        public string Password
        {
            get { return password; }
        }
        public bool Ativo
        {
            get { return ativo; }
            set { ativo = value; }
        }


        // Metodos Construtores ------------------------------------------------------------------

        public Usuario()
        {

        }
        public Usuario(string nome, string email, string password)
        {
            this.nome = nome;
            this.email = email;
            this.password = password;
            this.ativo = true;
        }

        public Usuario(int id, string nome, string email, string password, bool ativo)
        {
            this.id = id;
            this.nome = nome;
            this.email = email;
            this.password = password;
            this.ativo = ativo;
        }



        // Metodos da Classe ---------------------------------------------------------------------
        public int Inserir()
        {
            // Chamadas de banco de guarda registro
            return id;
        }
        public static bool EfetuarLogin(string email, string senha)
        {
            // Realiza validação e devolve verdadeiro ou falso
            return false;
        }

    }
}