using System;
using System.Data;

namespace ClassLabNu
{
    // Documentação de classes de projeto -> XML Docs

    public class Usuario
    {

        // Atributos -----------------------------------------------------------------------------

        public int Id { get; set; }
        public string Nome { get; }
        public string Email { get; set; }
        public string Password { get;  }
        public bool Ativo { get; set; }
        public Nivel Nivel { get; }

        // Metodos Construtores ------------------------------------------------------------------

        public Usuario()
        {

        }

        public Usuario(string nome, string email, string password, Nivel nivel)
        {
            this.Nome = nome;
            this.Email = email;
            this.Password = password;
            this.Ativo = true;
            this.Nivel = nivel;
        }

        public Usuario(int id, string nome, string email, string password, bool ativo, Nivel nivel)
        {
            this.Id = id;
            this.Nome = nome;
            this.Email = email;
            this.Password = password;
            this.Ativo = ativo;
            this.Nivel = nivel;
        }

        // Metodos da Classe ---------------------------------------------------------------------
        public void Inserir()
        {
            // Abre conexão com banco
            var cmd = Banco.Abrir();

            // Comandos SQL
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert Usuarios values(@id, @nome, @email, @senha)";

            // Parametros SQL
            cmd.Parameters.AddWithValue("@id", null);
            cmd.Parameters.AddWithValue("@nome", Nome);
            cmd.Parameters.AddWithValue("@email", Email);
            cmd.Parameters.AddWithValue("@telefone", Password);
            cmd.Parameters.AddWithValue("@senha", Nivel);
            cmd.ExecuteNonQuery();

            // Pega o ultimo ID criado
            cmd.CommandText = "select @@identity";

            // Guarda o ultimo ID criado no Id
            Id = Convert.ToInt32(cmd.ExecuteScalar());

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