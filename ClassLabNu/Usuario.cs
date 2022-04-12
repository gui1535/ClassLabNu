using System;
using System.Collections.Generic;

namespace ClassLabNu
{
    // Documentação de classes de projeto -> XML Docs

    public class Usuario
    {

        // Atributos -----------------------------------------------------------------------------

        public int Id { get; set; }
        public string Nome { get; }
        public string Email { get; set; }
        public string Password { get; }
        public bool Ativo { get; set; }
        public int Nivel { get; }

        // Metodos Construtores ------------------------------------------------------------------

        public Usuario()
        {

        }

        public Usuario(string nome, string email, string password, int nivel)
        {
            this.Nome = nome;
            this.Email = email;
            this.Password = password;
            this.Ativo = true;
            this.Nivel = nivel;
        }

        public Usuario(int id, string nome, string email, string password, bool ativo, int nivel)
        {
            this.Id = id;
            this.Nome = nome;
            this.Email = email;
            this.Password = password;
            this.Ativo = ativo;
            this.Nivel = nivel;
        }

        public Usuario(int id, string nome, string email, string password, int nivel)
        {
            Id = id;
            Nome = nome;
            Email = email;
            Password = password;
            Nivel = nivel;
        }



        // Metodos da Classe ---------------------------------------------------------------------
        public void Inserir()
        {
            /*
            // Abre conexão com banco
            var cmd = Banco.Abrir();
            // --------------------------------------------------------------------//
            // Comandos SQL
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert Usuarios values(@id, @nome, @email, @senha)";
            // ---------------------------------------------------------------------//
            // Parametros SQL
            cmd.Parameters.AddWithValue("@id", null);
            cmd.Parameters.AddWithValue("@nome", Nome);
            cmd.Parameters.AddWithValue("@email", Email);
            cmd.Parameters.AddWithValue("@senha", Password);
            cmd.Parameters.AddWithValue("@senha", Nivel);
            cmd.ExecuteNonQuery();
            // --------------------------------------------------------------------//
            // Pega o ultimo ID criado
            cmd.CommandText = "select @@identity";
            // --------------------------------------------------------------------//
            // Guarda o ultimo ID criado no Id
            Id = Convert.ToInt32(cmd.ExecuteScalar());
            // --------------------------------------------------------------------//
            // Limpar parametros
            cmd.Parameters.Clear();
            */

            // Abrindo conexão
            var banco = Banco.Abrir();

            // Inserindo dados
            banco.CommandText = $"INSERT usuarios VALUES (null,'{Nome}', '{Email}', '{Password}', '{Nivel}');";
            banco.ExecuteNonQuery();

            // Pega o ultimo ID criado
            banco.CommandText = @"select @@identity";

            // Retorna o ID nas propridades
            Id = Convert.ToInt32(banco.ExecuteScalar());
        }

        public static bool EfetuarLogin(string email, string senha)
        {
            // Realiza validação e devolve verdadeiro ou falso
            return false;
        }

        public static List<Usuario> ListarTodos()
        {
            // Listar usuario
            List<Usuario> usuarios = new List<Usuario>();

            // Abrindo conexão
            var banco = Banco.Abrir();

            // Comando SQL
            banco.CommandText = "SELECT * FROM usuarios";

            // Var para consultar
            var ConsultaDados = banco.ExecuteReader();

            // Consulta
            while (ConsultaDados.Read())
            {
                usuarios.Add(new Usuario(
                        ConsultaDados.GetInt32("id"),
                        ConsultaDados.GetString("nome"),
                        ConsultaDados.GetString("email"),
                        ConsultaDados.GetString("password"),
                        ConsultaDados.GetBoolean("ativo"),
                        ConsultaDados.GetInt32("nivel")
                    ));
            }
            return usuarios;
        }
    }
}