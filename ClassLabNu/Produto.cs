using System;
using System.Collections.Generic;
using System.Data;
using System.Windows;
using System.Windows.Forms;
using MessageBox = System.Windows.Forms.MessageBox;

namespace ClassLabNu
{
    public class Produto
    {
        // Atributos / Propriedades ----------------------------------------------------

        public int Id { get; set; }
        public string Descricao { get; set; }
        public string Unidade { get; set; }
        public string Codbar { get; set; }
        public double Valor { get; set; }
        public double Desconto { get; set; }
        public bool Descontinuado { get; set; }

        // Construtores ----------------------------------------------------------------

        /// <summary>
        /// Construtor vazio para o Produto
        /// </summary>
        public Produto()
        {
        }

        /// <summary>
        /// Construtor para o Produto
        /// </summary>
        /// <param name="id">INT(11)</param>
        /// <param name="descricao">VARCHAR(100)</param>
        /// <param name="unidade">VARCHAR(14)</param>
        /// <param name="codbar">CHAR(13)</param>
        /// <param name="valor">DOUBLE</param>
        /// <param name="desconto">DOUBLE</param>
        public Produto(int id, string descricao, string unidade, string codbar, double valor, double desconto)
        {
            Id = id;
            this.Descricao = descricao;
            this.Unidade = unidade;
            this.Codbar = codbar;
            this.Valor = valor;
            this.Desconto = desconto;
        }

        /// <summary>
        /// Construtor para o Produto
        /// </summary>
        /// <param name="id">INT(11)</param>
        /// <param name="descricao">VARCHAR(100)</param>
        /// <param name="unidade">VARCHAR(14)</param>
        /// <param name="codbar">CHAR(13)</param>
        /// <param name="valor">DOUBLE</param>
        /// <param name="desconto">DOUBLE</param>
        /// <param name="descontinuado">BIT(1)</param>
        public Produto(int id, string descricao, string unidade, string codbar, double valor, double desconto, bool descontinuado)
        {
            Id = id;
            this.Descricao = descricao;
            this.Unidade = unidade;
            this.Codbar = codbar;
            this.Valor = valor;
            this.Desconto = desconto;
            this.Descontinuado = descontinuado;
        }

        /// <summary>
        /// Construtor para o Produto
        /// </summary>
        /// <param name="id">INT(11)</param>
        /// <param name="descricao">VARCHAR(100)</param>
        /// <param name="unidade">VARCHAR(14)</param>
        /// <param name="codbar">CHAR(13)</param>
        /// <param name="valor">DOUBLE</param>
        public Produto(int id, string descricao, string unidade, string codbar, double valor)
        {
            Id = id;
            this.Descricao = descricao;
            this.Unidade = unidade;
            this.Codbar = codbar;
            this.Valor = valor;
        }

        /// <summary>
        /// Construtor para o Produto
        /// </summary>
        /// <param name="descricao">VARCHAR(100)</param>
        /// <param name="unidade">VARCHAR(14)</param>
        /// <param name="codbar">CHAR(13)</param>
        /// <param name="valor">DOUBLE</param>
        /// <param name="desconto">DOUBLE</param>
        public Produto(string descricao, string unidade, string codbar, double valor, double desconto)
        {
            this.Descricao = descricao;
            this.Unidade = unidade;
            this.Codbar = codbar;
            this.Valor = valor;
            this.Desconto = desconto;
        }


        // Metodos ---------------------------------------------------------------------

        /// <summary>
        /// Metodo para inserir produto no banco de dados
        /// </summary>
        public void Inserir()
        {
            try
            {
                // Abre conexão com banco
                var banco = Banco.Abrir();

                // Comandos SQL
                banco.CommandType = CommandType.StoredProcedure;
                banco.CommandText = "produto_inserir";

                // Parametros
                banco.Parameters.AddWithValue("_descricao", Descricao);
                banco.Parameters.AddWithValue("_unidade", Unidade);
                banco.Parameters.AddWithValue("_codbar", Codbar);
                banco.Parameters.AddWithValue("_desconto", Desconto);
                banco.Parameters.AddWithValue("_valor", Valor);
                Id = Convert.ToInt32(banco.ExecuteScalar());

                // Fecha Conexão
                banco.Connection.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro, verifique os valores digitados", "SysComercial", (MessageBoxButtons)MessageBoxButton.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Metodo para alterar produto
        /// </summary>
        /// <returns>Bool</returns>
        public bool Alterar()
        {
            return true;
        }

        /// <summary>
        /// Metodo para consultar produtos por ID
        /// </summary>
        /// <param name="_id"></param>
        public void ConsultarPorId(int _id)
        {
            // Abre conexao com banco
            var cmd = Banco.Abrir();

            // Comandos SQL
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = $"select * from produtos where idprod = {_id}";

            // Var para leitura
            var dr = cmd.ExecuteReader();

            // Consulta
            while (dr.Read())
            {
                Id = dr.GetInt32(0);
                Descricao = dr.GetString(1);
                Unidade = dr.GetString(2);
                Codbar = dr.GetString(3);
                Valor = dr.GetInt32(4);
                Desconto = dr.GetInt32(5);
                Descontinuado = dr.GetBoolean(6);
            }
        }

        /// <summary>
        /// Metodo para consultar produto por valor
        /// </summary>
        /// <param name="_valor"></param>
        public void ConsultarPorValor(double _valor)
        {
            // Abre conexao com banco
            var cmd = Banco.Abrir();

            // Comandos SQL
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = $"select * from produtos where valor = {_valor}";

            // Var para leitura
            var dr = cmd.ExecuteReader();

            // Consulta
            while (dr.Read())
            {
                Id = dr.GetInt32(0);
                Descricao = dr.GetString(1);
                Unidade = dr.GetString(2);
                Codbar = dr.GetString(3);
                Valor = dr.GetDouble(4);
                Desconto = dr.GetDouble(5);
                Descontinuado = dr.GetBoolean(6);
            }
        }

        /// <summary>
        /// Metodo para consultar produto por codigo de barras
        /// </summary>
        /// <param name="_codbar"></param>
        public void ConsultarPorCodbar(string _codbar)
        {

            // Abre conexao com banco
            var cmd = Banco.Abrir();

            // Comandos SQL
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = $"select * from produtos where valor = {_codbar}";

            // Var para leitura
            var dr = cmd.ExecuteReader();

            // Consulta
            while (dr.Read())
            {
                Id = dr.GetInt32(0);
                Descricao = dr.GetString(1);
                Unidade = dr.GetString(2);
                Codbar = dr.GetString(3);
                Valor = dr.GetDouble(4);
                Desconto = dr.GetDouble(5);
                Descontinuado = dr.GetBoolean(5);
            }
        }

        /// <summary>
        /// Metodo para listar todos produtos
        /// </summary>
        /// <param name="i"></param>
        /// <param name="l"></param>
        /// <returns>Lista</returns>
        public List<Produto> ListarTodos(int i = 0, int l = 0)
        {
            // Nova lista
            List<Produto> lista = new List<Produto>();

            // Abrir conexão
            var banco = Banco.Abrir();

            // Comando
            banco.CommandType = CommandType.Text;
            if (l > 0)
                banco.CommandText = $"select * from produtos limit {i} , {l}";
            else
                banco.CommandText = "select * from produtos";

            // Var para Consulta
            var dr = banco.ExecuteReader();

            // Consulta
            while (dr.Read())
            {
                lista.Add(new Produto(
                    Convert.ToInt32(dr.GetValue(0)), // ID
                    dr.GetString(1), // Descricao
                    dr.GetString(2), // Unidade
                    dr.GetString(3), // CodBar
                    dr.GetDouble(4), // Valor
                    dr.GetDouble(5), // Desconto
                     dr.GetBoolean(6) // Descontinuado
                    ));
            }

            // Fecha Conexão
            banco.Connection.Close();

            // Retornando lista
            return lista;
        }
    }
}
