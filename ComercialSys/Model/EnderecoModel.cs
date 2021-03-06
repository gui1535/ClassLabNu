using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace ComercialSys.Model
{
    public class EnderecoModel
    {
        // Atributos / Propriedades ------------------------------------------------------------------------------
        public int IdCli { get; set; }
        public string Logradouro { get; set; }
        public string Cep { get; set; }
        public string Numero { set; get; }
        public string Cidade { get; set; }
        public string Bairro { get; set; }
        public string Estado { get; set; }
        public string Uf { get; set; }
        public string Tipo { get; set; }
        public string Complemento { get; set; }

        // Construtores -------------------------------------------------------------------------------------------
        public EnderecoModel()
        {
        }

        public EnderecoModel(int idCli, string logradouro, string cep, string numero, string cidade, string bairro, string estado, string tipo, string complemento)
        {
            IdCli = idCli;
            Logradouro = logradouro;
            Cep = cep;
            Numero = numero;
            Cidade = cidade;
            Bairro = bairro;
            Estado = estado;
            Tipo = tipo;
            Complemento = complemento;
        }
        public EnderecoModel(int idCli, string logradouro, string cep, string numero, string cidade, string bairro, string estado, string tipo, string complemento, string uf)
        {
            IdCli = idCli;
            Logradouro = logradouro;
            Cep = cep;
            Numero = numero;
            Cidade = cidade;
            Bairro = bairro;
            Estado = estado;
            Tipo = tipo;
            Complemento = complemento;
            Uf = uf;
        }

        public EnderecoModel(string logradouro, string cep, string numero, string cidade, string bairro, string estado, string tipo, string complemento)
        {
            Logradouro = logradouro;
            Cep = cep;
            Numero = numero;
            Cidade = cidade;
            Bairro = bairro;
            Estado = estado;
            Tipo = tipo;
            Complemento = complemento;
        }
        public EnderecoModel(string logradouro, string cep, string numero, string cidade, string bairro, string estado, string tipo, string complemento, string uf)
        {
            Logradouro = logradouro;
            Cep = cep;
            Numero = numero;
            Cidade = cidade;
            Bairro = bairro;
            Estado = estado;
            Tipo = tipo;
            Complemento = complemento;
            Uf = uf;
        }

        public EnderecoModel(string logradouro, string cep, string numero, string cidade, string bairro, string estado, string tipo)
        {
            Logradouro = logradouro;
            Cep = cep;
            Numero = numero;
            Cidade = cidade;
            Bairro = bairro;
            Estado = estado;
            Tipo = tipo;
        }

        /// <summary>
        /// Metodo para inserir endereco
        /// </summary>
        public void Inserir()
        {
            // Tratar erro
            try
            {
                // Abre conexão com banco
                var banco = BancoModel.Abrir();

                // Comandos SQL
                banco.CommandType = CommandType.StoredProcedure;
                banco.CommandText = "endereco_inserir";

                // Parametros
                banco.Parameters.AddWithValue("_idcli", IdCli);
                banco.Parameters.AddWithValue("_logradouro", Logradouro);
                banco.Parameters.AddWithValue("_cep", Cep);
                banco.Parameters.AddWithValue("_numero", Numero);
                banco.Parameters.AddWithValue("_cidade", Cidade);
                banco.Parameters.AddWithValue("_bairro", Bairro);
                banco.Parameters.AddWithValue("_estado", Estado);
                banco.Parameters.AddWithValue("_uf", Uf);
                banco.Parameters.AddWithValue("_tipo", Tipo);
                banco.Parameters.AddWithValue("_complemento", Complemento);

                banco.ExecuteScalar();

                // Fecha Conexão
                banco.Connection.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "SysComercial", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public List<EnderecoModel> ListarEnderecoCli(int _idCli)
        {
            // Nova lista
            List<EnderecoModel> lista = new List<EnderecoModel>();

            // Abrir conexão
            var banco = BancoModel.Abrir();

            // Comando
            banco.CommandType = CommandType.Text;
            banco.CommandText = $"select * from enderecos where idcli = {_idCli}";


            // Var para Consulta
            var dr = banco.ExecuteReader();

            // Consulta
            while (dr.Read())
            {
                lista.Add(new EnderecoModel(
                    Convert.ToInt32(dr.GetValue(0)),
                    dr.GetString(1),
                    dr.GetString(2),
                    dr.GetString(3),
                    dr.GetString(4),
                    dr.GetString(5),
                    dr.GetString(6),
                    dr.GetString(7),
                    dr.GetString(8)
                    ));
            }

            // Fecha Conexão
            banco.Connection.Close();

            // Retornando lista
            return lista;
        }

    }
}

