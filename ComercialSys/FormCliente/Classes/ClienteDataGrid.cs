using ClassLabNu;
using System.Windows.Forms;

namespace ComercialSys.Formularios.FormCliente
{
    public class ClienteDataGrid
    {
        Cliente cliente = new Cliente();

        /// <summary>
        /// Metodo para Listar clientes
        /// </summary>
        /// <param name="dt">DataGridView</param>
        /// <param name="clnId">ColunaTextBox</param>
        /// <param name="ClnNome">ColunaTextBox</param>
        /// <param name="ClnEmail">ColunaTextBox</param>
        /// <param name="ClnCpf">ColunaTextBox</param>
        /// <param name="ClnDataCad">ColunaTextBox</param>
        /// <param name="clnAtivo">ColunaCheckBox</param>
        /// <param name="ClnObs">ColunaTextBox</param>
        public void ListarCliente
            (
            DataGridView dt,
            DataGridViewTextBoxColumn clnId,
            DataGridViewTextBoxColumn ClnNome,
            DataGridViewTextBoxColumn ClnEmail,
            DataGridViewTextBoxColumn ClnCpf,
            DataGridViewTextBoxColumn ClnDataCad,
            DataGridViewCheckBoxColumn clnAtivo,
            DataGridViewTextBoxColumn ClnObs
            )
        {

            // Limpar Grid
            dt.Rows.Clear();

            // Var para Listar clientes
            var lista = cliente.ListarClientes();

            // Listando clientes no DataGrid
            lista.ForEach(i =>
            {
                // Linhas 
                dt.Rows.Add();
                dt.Rows[lista.IndexOf(i)].Cells[clnId.Index].Value = i.Id; // Text -> ID
                dt.Rows[lista.IndexOf(i)].Cells[ClnNome.Index].Value = i.Nome; // Text -> Nome
                dt.Rows[lista.IndexOf(i)].Cells[ClnEmail.Index].Value = i.Email; // Text -> Email
                dt.Rows[lista.IndexOf(i)].Cells[ClnCpf.Index].Value = i.Cpf; // Text -> CPF
                dt.Rows[lista.IndexOf(i)].Cells[ClnDataCad.Index].Value = i.dataCad; // Text -> DataCad
                dt.Rows[lista.IndexOf(i)].Cells[clnAtivo.Index].Value = i.Ativo; // Checkbox -> Ativo
                dt.Rows[lista.IndexOf(i)].Cells[ClnObs.Index].Value = i.Obs; // Text -> Observações
            });
        }
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

            // Objeto Endereco
            Endereco end = new Endereco();

            // Var para Listar enderecos
            var lista = end.ListarEnderecoCli(cliente.Id);

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
    }
}
