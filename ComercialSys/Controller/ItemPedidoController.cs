using ComercialSys.Model;
using System;
using System.Windows.Forms;

namespace ComercialSys.Controller
{
    public class ItemPedidoController : ItemPedidoModel
    {

        public void InserirItem(int _id, string _codbar, double _valor, double _desconto)
        {

            Valor = Convert.ToDouble(_valor);
            Desconto = Convert.ToDouble(_desconto);

            ProdutoController PC = new ProdutoController();
            PC.ConsultaCodBar(_codbar.Trim());

            Pedido = Convert.ToInt32(_id);
            Produto = PC.Id;

            Inserir();
        }

        public static void ListarItem
        (
        int _idped,
        int _idprod,
        DataGridView dt,
        DataGridViewTextBoxColumn CnlPed,
        DataGridViewTextBoxColumn ClnProd,
        DataGridViewTextBoxColumn ClnQuantidade,
        DataGridViewTextBoxColumn ClnValor,
        DataGridViewTextBoxColumn ClnDesconto
        )
        {
            // Limpar Grid
            dt.Rows.Clear();

            // Var para Listar clientes
            var lista = ListarItensPedido(_idped, _idprod);

            // Listando clientes no DataGrid
            lista.ForEach(i =>
            {
                // Linhas 
                dt.Rows.Add();
                dt.Rows[lista.IndexOf(i)].Cells[CnlPed.Index].Value = i.Pedido; // Text -> Pedido
                dt.Rows[lista.IndexOf(i)].Cells[ClnProd.Index].Value = i.Produto; // Text -> Produto
                dt.Rows[lista.IndexOf(i)].Cells[ClnQuantidade.Index].Value = i.Quantidade; // Text -> Quantidade
                dt.Rows[lista.IndexOf(i)].Cells[ClnValor.Index].Value = i.Valor; // Text -> Valor
                dt.Rows[lista.IndexOf(i)].Cells[ClnDesconto.Index].Value = i.Desconto; // Text -> Desconto
            });
        }
    }
}
