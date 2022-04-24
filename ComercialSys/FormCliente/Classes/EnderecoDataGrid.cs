using ClassLabNu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComercialSys.FormCliente.Classes
{
    public class EnderecoDataGrid : Endereco
    {
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
            Cliente cli,
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
            var lista = ListarEnderecoCli(cli.Id);

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
