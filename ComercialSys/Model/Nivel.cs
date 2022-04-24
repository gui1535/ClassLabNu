using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace ClassLabNu
{
    public class Nivel
    {
        // Atributos -> Campos
        private int Id { set; get; }
        private string Nome { set; get; }
        private string Sigla { set; get; }

        // Metodos Contrutores ------------------------------------------------------------------

        public Nivel()
        {
        }

        public Nivel(string nome, string sigla)
        {
            this.Nome = nome;
            this.Sigla = sigla;
        }

        public Nivel(int id, string nome, string sigla)
        {
            this.Id = id;
            this.Nome = nome;
            this.Sigla = sigla;
        }

        public void Inserir()
        {
            try
            {
                // Abre conexão com banco
                var banco = Banco.Abrir();

                // Comandos SQL
                banco.CommandType = System.Data.CommandType.StoredProcedure;
                banco.CommandText = "nivel_inserir";

                // Parametros
                banco.Parameters.AddWithValue("_nome", Nome);
                banco.Parameters.AddWithValue("_sigla", Sigla);
                Id = Convert.ToInt32(banco.ExecuteScalar());

                // Fecha Conexão
                banco.Connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocorreu um erro {ex}", "SysComercial", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        /// <summary>
        /// Altera a sigla do nível indicado. Apenas administradores.
        /// </summary>
        /// <param name="id">Identificação do nível</param>
        /// <param name="sigla">Valor literal da nova sigla</param>
        /// <returns>Retorna valor para teste lógico, confirmando a alteração</returns>
        public bool Alterar()
        {
            // Abrir conexao
            var cmd = Banco.Abrir();

            // Comando SQL
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = $"nivel_alterar";

            // Parametros
            cmd.Parameters.AddWithValue("_id", Id);
            cmd.Parameters.AddWithValue("_nome", Nome);
            cmd.Parameters.AddWithValue("_sigla", Sigla);

            // Variavel para receber retorno
            int retorna = cmd.ExecuteNonQuery();

            cmd.Connection.Close();

            // Retornando valor
            if (retorna == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static MySqlDataReader ConsultarNivel()
        {
            // Abre conexao com banco
            var cmd = Banco.Abrir();

            // Comandos SQL
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"SELECT * FROM nivel";

            return cmd.ExecuteReader();
        }
    }
}