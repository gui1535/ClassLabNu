using ClassLabNu;
using System.Windows.Forms;

namespace ComercialSys.FormCliente.Classes
{
    public class ClienteDataGrid : Cliente
    {

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
            var lista = ListarClientes();

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
        /// Metodo para Pesquiar clientes por CPF
        /// </summary>
        /// <param name="dt">DataGridView</param>
        /// <param name="clnId">ColunaTextBox</param>
        /// <param name="ClnNome">ColunaTextBox</param>
        /// <param name="ClnEmail">ColunaTextBox</param>
        /// <param name="ClnCpf">ColunaTextBox</param>
        /// <param name="ClnDataCad">ColunaTextBox</param>
        /// <param name="clnAtivo">ColunaCheckBox</param>
        /// <param name="ClnObs">ColunaTextBox</param>
        public void PesquisarClienteCpf
        (
        DataGridView dt,
        string _cpf,
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
            var lista = ListarPorCpf(_cpf);

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

                // Atributos
                Id = i.Id;
                Nome = i.Nome;
                Email = i.Email;
                Cpf = i.Cpf;
                dataCad = i.dataCad;
                Ativo = i.Ativo;
                Obs = i.Obs;

            });
        }

        
    }
}
