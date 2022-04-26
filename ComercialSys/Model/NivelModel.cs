using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace ComercialSys.Model
{
    public class NivelModel
    {
        // Atributos -> Campos
        public int Id { set; get; }
        public string Nome { set; get; }
        public string Sigla { set; get; }

        // Metodos Contrutores ------------------------------------------------------------------

        public NivelModel()
        {
        }

        public NivelModel(string nome, string sigla)
        {
            this.Nome = nome;
            this.Sigla = sigla;
        }

        public NivelModel(int id, string nome, string sigla)
        {
            this.Id = id;
            this.Nome = nome;
            this.Sigla = sigla;
        }
        public NivelModel(string nome, string sigla, int id)
        {
            this.Nome = nome;
            this.Sigla = sigla;
            this.Id = id;
        }

        public void Inserir()
        {
            try
            {
                // Abre conexão com banco
                var banco = BancoModel.Abrir();

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
            var cmd = BancoModel.Abrir();

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
        public static List<NivelModel> ListarNivel()
        {
            // Nova lista
            List<NivelModel> lista = new List<NivelModel>();

            // Abrir conexão
            var banco = BancoModel.Abrir();

            // Comando
            banco.CommandType = CommandType.Text;
            banco.CommandText = "select * from nivel";

            // Var para Consulta
            var dr = banco.ExecuteReader();

            // Consulta
            while (dr.Read())
            {
                lista.Add(new NivelModel(
                    dr.GetInt32(0),
                    dr.GetString(1),
                    dr.GetString(2)
                    ));
            }

            // Retornando lista
            return lista;
        }
    }
}