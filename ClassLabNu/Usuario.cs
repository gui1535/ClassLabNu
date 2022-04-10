using System;
using System.Data;

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
        private Nivel nivel;

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
        public Nivel Nivel
        {
            get { return nivel; }
        }

        // Metodos Construtores ------------------------------------------------------------------

        public Usuario()
        {

        }

        public Usuario(string nome, string email, string password, Nivel nivel)
        {
            this.nome = nome;
            this.email = email;
            this.password = password;
            this.ativo = true;
            this.nivel = nivel;
        }

        public Usuario(int id, string nome, string email, string password, bool ativo, Nivel nivel)
        {
            this.id = id;
            this.nome = nome;
            this.email = email;
            this.password = password;
            this.ativo = ativo;
            this.nivel = nivel;
        }

        // Metodos da Classe ---------------------------------------------------------------------
        public void Inserir()
        {
            // Abre conexão com banco
            var cmd = Banco.Abrir();

            // Comandos SQL
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert usuarios values(@id, @nome, @email, @senha, @nivel)";

            // Parametros SQL
            cmd.Parameters.AddWithValue("@id", null);
            cmd.Parameters.AddWithValue("@nome", Nome);
            cmd.Parameters.AddWithValue("@email", Email);
            cmd.Parameters.AddWithValue("@telefone", Password);
            cmd.Parameters.AddWithValue("@senha", Nivel);
            cmd.ExecuteNonQuery();

            // Pega o ultimo ID criado
            cmd.CommandText = "select @@identity";

            // Guarda o ultimo ID criado no id
            id = Convert.ToInt32(cmd.ExecuteScalar());

            // Limpar parametros
            cmd.Parameters.Clear();
        }

        public static bool EfetuarLogin(string email, string senha)
        {
            // Realiza validação e devolve verdadeiro ou falso
            return false;
        }
    }
}