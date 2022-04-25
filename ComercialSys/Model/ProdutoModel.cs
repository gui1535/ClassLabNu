using System;
using System.Collections.Generic;
using System.Data;
using System.Windows;
using System.Windows.Forms;
using MessageBox = System.Windows.Forms.MessageBox;

namespace ComercialSys.Model
{
    public class ProdutoModel
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
        public ProdutoModel()
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
        public ProdutoModel(int id, string descricao, string unidade, string codbar,double desconto,double valor)
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
        /// <param name="descricao">VARCHAR(100)</param>
        /// <param name="unidade">VARCHAR(14)</param>
        /// <param name="codbar">CHAR(13)</param>
        /// <param name="valor">DOUBLE</param>
        /// <param name="desconto">DOUBLE</param>
        /// <param name="descontinuado">BIT(1)</param>
        public ProdutoModel(string descricao, string unidade, string codbar, double valor, double desconto, bool descontinuado)
        {
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
        /// <param name="desconto">DOUBLE</param>
        /// <param name="descontinuado">BIT(1)</param>
        public ProdutoModel(int id, string descricao, string unidade, string codbar, double valor, double desconto, bool descontinuado)
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
        public ProdutoModel(int id, string descricao, string unidade, string codbar, double valor)
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
        public ProdutoModel(string descricao, string unidade, string codbar, double valor, double desconto)
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
                var banco = BancoModel.Abrir();

                // Comandos SQL
                banco.CommandType = CommandType.StoredProcedure;
                banco.CommandText = "inserir_produto";

                // Parametros
                banco.Parameters.AddWithValue("_descricao", Descricao);
                banco.Parameters.AddWithValue("_unidade", Unidade);
                banco.Parameters.AddWithValue("_codbar", Codbar);
                banco.Parameters.AddWithValue("_desconto", Desconto);
                banco.Parameters.AddWithValue("_valor", Valor);
                banco.Parameters.AddWithValue("_descontinuado", Descontinuado);
                Id = Convert.ToInt32(banco.ExecuteScalar());

                // Fecha Conexão
                banco.Connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocorreu um erro {ex}", "SysComercial", (MessageBoxButtons)MessageBoxButton.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Metodo para alterar produto
        /// </summary>
        /// <returns>Bool</returns>
        public bool Alterar()
        {

            // Abrir conexao
            var cmd = BancoModel.Abrir();

            // Comando SQL
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = $"produto_alterar";

            // Parametros
            cmd.Parameters.AddWithValue("_id", Id);
            cmd.Parameters.AddWithValue("_descricao", Descricao);
            cmd.Parameters.AddWithValue("_unidade", Unidade);
            cmd.Parameters.AddWithValue("_desconto", Desconto);
            cmd.Parameters.AddWithValue("_valor", Valor);
            cmd.Parameters.AddWithValue("_descontinuado", Descontinuado);

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

        /// <summary>
        /// Metodo para consultar produtos por ID
        /// </summary>
        /// <param name="_id"></param>
        public List<ProdutoModel> ListarPorId(int _id)
        {
            // Nova lista
            List<ProdutoModel> lista = new List<ProdutoModel>();

            // Abrir conexão
            var banco = BancoModel.Abrir();

            // Comando
            banco.CommandType = CommandType.Text;
            banco.CommandText = $"select * from produtos where idprod = {_id}";

            // Var para Consulta
            var dr = banco.ExecuteReader();

            // Consulta
            while (dr.Read())
            {
                lista.Add(new ProdutoModel(
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

        /// <summary>
        /// Metodo para consultar produto por valor
        /// </summary>
        /// <param name="_valor"></param>
        public List<ProdutoModel> ListarPorValor(double _valor)
        {
            // Nova lista
            List<ProdutoModel> lista = new List<ProdutoModel>();

            // Abrir conexão
            var banco = BancoModel.Abrir();

            // Comando
            banco.CommandType = CommandType.Text;
            banco.CommandText = $"select * from produtos where valor = {_valor}";

            // Var para Consulta
            var dr = banco.ExecuteReader();

            // Consulta
            while (dr.Read())
            {
                lista.Add(new ProdutoModel(
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

        /// <summary>
        /// Metodo para consultar produto por codigo de barras
        /// </summary>
        /// <param name="_codbar"></param>
        public List<ProdutoModel> ListarPorCodbar(string _codbar)
        {
            // Nova lista
            List<ProdutoModel> lista = new List<ProdutoModel>();

            // Abrir conexão
            var banco = BancoModel.Abrir();

            // Comando
            banco.CommandType = CommandType.Text;
            banco.CommandText = $"select * from produtos where codbar = {_codbar}";

            // Var para Consulta
            var dr = banco.ExecuteReader();

            // Consulta
            while (dr.Read())
            {
                lista.Add(new ProdutoModel(
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

        /// <summary>
        /// Metodo para listar todos produtos
        /// </summary>
        /// <param name="i"></param>
        /// <param name="l"></param>
        /// <returns>Lista</returns>
        public List<ProdutoModel> ListarTodos(int i = 0, int l = 0)
        {
            // Nova lista
            List<ProdutoModel> lista = new List<ProdutoModel>();

            // Abrir conexão
            var banco = BancoModel.Abrir();

            // Comando
            banco.CommandType = CommandType.Text;
            if (l > 0)
                banco.CommandText = $"select * from produtos where descontinuado = 1 limit {i} , {l}";
            else
                banco.CommandText = "select * from produtos where descontinuado = 1";

            // Var para Consulta
            var dr = banco.ExecuteReader();

            // Consulta
            while (dr.Read())
            {
                lista.Add(new ProdutoModel(
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
