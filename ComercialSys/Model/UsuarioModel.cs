using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace ComercialSys.Model
{
    // Documentação de classes de projeto -> XML Docs

    public class UsuarioModel
    {

        // Atributos -----------------------------------------------------------------------------

        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public bool Ativo { get; set; }
        public string Nivel { get; set; }
        public byte[] Foto { get; set; }
        // Metodos Construtores ------------------------------------------------------------------

        /// <summary>
        /// Construtor vazio para o Usuario
        /// </summary>
        public UsuarioModel()
        {

        }

        /// <summary>
        /// Construtor para o Usuario
        /// </summary>
        /// <param name="nome">VARCHAR(60)</param>
        /// <param name="email">VARCHAR(60)</param>
        /// <param name="password">VARCHAR(32)</param>
        /// <param name="nivel">VARCHAR(15)</param>
        public UsuarioModel(string nome, string email, string password, string nivel)
        {
            this.Nome = nome;
            this.Email = email;
            this.Password = password;
            this.Ativo = true;
            this.Nivel = nivel;
        }

        /// <summary>
        /// Construtor para o Usuario
        /// </summary>
        /// <param name="id">INT</param>
        /// <param name="nome">VARCHAR(60)</param>
        /// <param name="email">VARCHAR(60)</param>
        /// <param name="password">VARCHAR(32)</param>
        /// <param name="ativo">BIT(1)</param>
        /// <param name="nivel">VARCHAR(15)</param>
        public UsuarioModel(int id, string nome, string email, string password, string nivel, bool ativo, byte[] foto)
        {
            this.Id = id;
            this.Nome = nome;
            this.Email = email;
            this.Password = password;
            this.Ativo = ativo;
            this.Nivel = nivel;
            Foto = foto;
        }
        public UsuarioModel(int id, string nome, string email, string password, string nivel, bool ativo)
        {
            this.Id = id;
            this.Nome = nome;
            this.Email = email;
            this.Password = password;
            this.Ativo = ativo;
            this.Nivel = nivel;
        }

        /// <summary>
        /// Construtor para o Usuario
        /// </summary>
        /// <param name="id">INT</param>
        /// <param name="nome">VARCHAR(60)</param>
        /// <param name="email">VARCHAR(60)</param>
        /// <param name="password">VARCHAR(32)</param>
        /// <param name="nivel">VARCHAR(15)</param>
        public UsuarioModel(int id, string nome, string email, string password, string nivel)
        {
            Id = id;
            Nome = nome;
            Email = email;
            Password = password;
            Nivel = nivel;
        }

        // Metodos da Classe ---------------------------------------------------------------------

        /// <summary>
        /// Metodo para inserir usuario no banco de dados
        /// </summary>
        public void Inserir()
        {
            try
            {
                // Abre conexão com banco
                var banco = BancoModel.Abrir();

                // Comandos SQL
                banco.CommandType = System.Data.CommandType.StoredProcedure;
                banco.CommandText = "usuario_inserir";

                // Parametros
                banco.Parameters.AddWithValue("_nome", Nome);
                banco.Parameters.AddWithValue("_email", Email);
                banco.Parameters.AddWithValue("_senha", Password);
                banco.Parameters.AddWithValue("_idnv", Nivel);
                Id = Convert.ToInt32(banco.ExecuteScalar());

                // Fecha Conexão
                banco.Connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocorreu um erro, verifique os valores digitados {ex}", "SysComercial", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        /// <summary>
        /// Metodo para efetuar login do usuario
        /// </summary>
        /// <param name="email"></param>
        /// <param name="senha"></param>
        /// <returns>Bool</returns>
        public static bool EfetuarLogin(string email, string senha)
        {
            // Realiza validação e devolve verdadeiro ou falso
            return false;
        }

        /// <summary>
        /// Metodo para listar todos usuarios
        /// </summary>
        /// <param name="i"></param>
        /// <param name="l"></param>
        /// <returns></returns>
        public List<UsuarioModel> ListarUsuarios(int i = 0, int l = 0)
        {
            // Nova lista
            List<UsuarioModel> lista = new List<UsuarioModel>();

            // Abrir conexão
            var banco = BancoModel.Abrir();

            // Comando
            banco.CommandType = CommandType.Text;
            if (l > 0)
                banco.CommandText = $"select * from usuarios limit {i} , {l}";
            else
                banco.CommandText = "select * from usuarios";

            // Var para Consulta
            var dr = banco.ExecuteReader();

            // Consulta
            while (dr.Read())
            {
                lista.Add(new UsuarioModel(
                    Convert.ToInt32(dr.GetValue(0)), // ID
                    dr.GetString(1), // Nome
                    dr.GetString(2), // Email
                    dr.GetString(3), // Senha
                    dr.GetString(4), // Nivel
                    dr.GetBoolean(5) // Ativo
                    ));
            }
            // Fecha Conexão
            banco.Connection.Close();

            // Retornando lista
            return lista;
        }

        /// <summary>
        /// Metodo para alterar usuario no banco de dados
        /// </summary>
        /// <returns></returns>
        public bool Alterar()
        {
            // Abrir conexao
            var cmd = BancoModel.Abrir();

            // Comando SQL
            cmd.CommandText = $"update usuarios set nome = '{Nome}', senha = '{Password}', email = '{Email}', ativo = {Ativo}, nivel = '{Nivel}' where iduser = {Id}";
            int ret = cmd.ExecuteNonQuery();

            // Retornando valor
            if (ret == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Metodo para consultar usuario por ID
        /// </summary>
        /// <param name="_id"></param>
        public void ConsultarPorId(int _id)
        {
            // Abre conexao com banco
            var cmd = BancoModel.Abrir();

            // Comandos SQL
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"select * from usuarios where iduser = '{_id}'";

            // Var para leitura
            var dr = cmd.ExecuteReader();

            // Consulta
            while (dr.Read())
            {
                Id = dr.GetInt32(0);
                Nome = dr.GetString(1);
                Email = dr.GetString(2);
                Password = dr.GetString(3);
                Nivel = dr.GetString(4);
                Ativo = dr.GetBoolean(5);


            }
        }

        /// <summary>
        /// Metodo para consultar usuario por Nome
        /// </summary>
        /// <param name="_nome"></param>
        public void ConsultarPorNome(string _nome)
        {
            // Abre conexao com banco
            var cmd = BancoModel.Abrir();

            // Comandos SQL
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"select * from usuarios where nome = '{_nome}'";

            // Var para leitura
            var dr = cmd.ExecuteReader();

            // Consulta
            while (dr.Read())
            {
                Id = dr.GetInt32(0);
                Nome = dr.GetString(1);
                Email = dr.GetString(2);
                Password = dr.GetString(3);
                Nivel = dr.GetString(4);
                Ativo = dr.GetBoolean(5);
            }
        }
    }
}