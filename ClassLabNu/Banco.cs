using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows;
using System.Windows.Forms;

namespace ClassLabNu
{
    // Classe para conectar com o banco de dados
    public static class Banco
    {
        // Metodo Conexão
        public static MySqlCommand Abrir()
        {
            // Objeto para comando SQL
            MySqlCommand cmdSQL = new MySqlCommand();

            // String de conexão
            string stringDeConexao = @"server=localhost;database=comercialdb0191;user id=root;password=; port=3306";

            // Conectando
            MySqlConnection conexao = new MySqlConnection(stringDeConexao);

            // Exceção
            try // Faça
            {
                // Se o status de conexão for diferente do que aberto
                if (conexao.State != ConnectionState.Open)
                {
                    conexao.Open();
                    cmdSQL.Connection = conexao;
                }
            }
            catch (Exception) // Caso aconteça erro
            {
                throw;
            }

            // Retornando objeto de comandos SQL
            return cmdSQL;
        }

    }
}
