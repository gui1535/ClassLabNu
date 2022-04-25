using ComercialSys.Model;
using System;
using System.Windows.Forms;

namespace ComercialSys.Controller
{
    public class EnderecoController
    {
        public int MyProperty { get; set; }

        /// <summary>
        /// Metodo para listar endereços do cliente
        /// </summary>
        /// <param name="dt">DataGridView</param>
        /// <param name="clnCep">ColunaTextBox</param>
        /// <param name="ClnCidade">ColunaTextBox</param>
        /// <param name="ClnTipo">ColunaTextBox</param>
        /// <param name="ClnBairro">ColunaTextBox</param>
        /// <param name="ClnLogradouro">ColunaTextBox</param>
        /// <param name="ClnEstado">ColunaTextBox</param>
        /// <param name="ClnNumero">ColunaTextBox</param>
        /// <param name="ClnComplemento">ColunaTextBox</param>
        public void ListarEndereco
            (
            DataGridView dt,
            ClienteController cli,
            DataGridViewTextBoxColumn clnCep,
            DataGridViewTextBoxColumn ClnCidade,
            DataGridViewTextBoxColumn ClnTipo,
            DataGridViewTextBoxColumn ClnBairro,
            DataGridViewTextBoxColumn ClnLogradouro,
            DataGridViewTextBoxColumn ClnEstado,
            DataGridViewTextBoxColumn ClnNumero,
            DataGridViewTextBoxColumn ClnComplemento
            )
        {
            // Limpar Grid
            dt.Rows.Clear();

            // Var para Listar enderecos
            Endereco end = new Endereco();

            var lista = end.ListarEnderecoCli(Convert.ToInt32(cli.IdCli));

            // Listando enderecos no DataGrid
            lista.ForEach(i =>
            {
                // Linhas 
                dt.Rows.Add();
                dt.Rows[lista.IndexOf(i)].Cells[clnCep.Index].Value = i.Cep; // Text -> Cep
                dt.Rows[lista.IndexOf(i)].Cells[ClnCidade.Index].Value = i.Cidade; // Text -> Cidade
                dt.Rows[lista.IndexOf(i)].Cells[ClnTipo.Index].Value = i.Tipo; // Text -> Tipo
                dt.Rows[lista.IndexOf(i)].Cells[ClnBairro.Index].Value = i.Bairro; // Text -> Bairro
                dt.Rows[lista.IndexOf(i)].Cells[ClnLogradouro.Index].Value = i.Logradouro; // Text -> Logradouro
                dt.Rows[lista.IndexOf(i)].Cells[ClnEstado.Index].Value = i.Estado; // Text -> Estado
                dt.Rows[lista.IndexOf(i)].Cells[ClnNumero.Index].Value = i.Numero; // Text -> Numero
                dt.Rows[lista.IndexOf(i)].Cells[ClnComplemento.Index].Value = i.Complemento; // Text -> Complemento
            });
        }

        public void AdicionarEndereco(int _idCli, string _logradouro, string _cep, string _numero, string _cidade, string _bairro, string _estado, string _uf, string _tipo, string _complemento)
        {
            try
            {
                // Passando valores ao objeto endereco
                Endereco end = new Endereco();

                end.Logradouro = _logradouro;
                end.Cep = _cep;
                end.Numero = _numero;
                end.Cidade = _cidade;
                end.Bairro = _bairro;
                end.Estado = _estado;
                end.Uf = _uf;
                end.Tipo = _tipo;
                end.Complemento = _complemento;

                // Atribuindo valor do TextBox para o ClienteID
                int ClienteID = _idCli;

                end.IdCli = ClienteID;

                // Inserir endereco
                end.Inserir();

                // Mensagem sucesso
                MessageBox.Show("Endereço inserido com sucesso", "SysComercial", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                // Mensagem de erro
                MessageBox.Show("Erro ao inserir endereço", "SysComercial", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void GridEndereco_DoubleClick
        (
        DataGridView dt,
        DataGridViewCellEventArgs e
        )
        {
            // Variaveis para objeto Endereco
            Endereco end = new Endereco();

            // Valores para o objeto
            end.Cep = Convert.ToString(dt[$"colunaCep", e.RowIndex].Value);
            end.Cidade = Convert.ToString(dt[$"colunaCidade", e.RowIndex].Value);
            end.Tipo = Convert.ToString(dt[$"colunaTipo", e.RowIndex].Value);
            end.Bairro = Convert.ToString(dt[$"colunaBairro", e.RowIndex].Value);
            end.Logradouro = Convert.ToString(dt[$"colunaLogradouro", e.RowIndex].Value);
            end.Estado = Convert.ToString(dt[$"colunaEstado", e.RowIndex].Value);
            end.Numero = Convert.ToString(dt[$"colunaNumero", e.RowIndex].Value);
            end.Complemento = Convert.ToString(dt[$"colunaComplemento", e.RowIndex].Value);

        }
    }
}
