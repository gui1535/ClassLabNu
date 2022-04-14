using ClassLabNu;
using System;
using System.Windows.Forms;

namespace ComercialSys
{
    public partial class FormProduto : MetroFramework.Forms.MetroForm
    {
        public FormProduto(Form parent)
        {
            InitializeComponent();

            //MdiParent
            MdiParent = parent;
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            // Limpar Grid
            GridProdutos.Rows.Clear();

            // Novo objeto Cliente
            Produto produto = new Produto();

            // Var para Listar clientes
            var lista = produto.ListarTodos();
            lista.ForEach(i =>
            {

                // Linhas 
                GridProdutos.Rows.Add();
                GridProdutos.Rows[lista.IndexOf(i)].Cells[colunaId.Index].Value = i.id; // ID
                GridProdutos.Rows[lista.IndexOf(i)].Cells[colunaNome.Index].Value = i.Descricao; // Descricao
                GridProdutos.Rows[lista.IndexOf(i)].Cells[colunaUnidade.Index].Value = i.Unidade; // Unidade
                GridProdutos.Rows[lista.IndexOf(i)].Cells[colunaCodBar.Index].Value = i.Codbar; // CodBar
                GridProdutos.Rows[lista.IndexOf(i)].Cells[colunaValor.Index].Value = i.Valor; // Valor
                GridProdutos.Rows[lista.IndexOf(i)].Cells[colunaDesconto.Index].Value = i.Desconto; // Desconto
                GridProdutos.Rows[lista.IndexOf(i)].Cells[ColunaDescontinuado.Index].Value = i.Descontinuado; // Descontinuado


                // Verificação para Ativo ou Inativo
                if ((i.Descontinuado == true))
                {

                    // Se Ativo for igual a 'True' -> 1
                    GridProdutos.Rows[lista.IndexOf(i)].Cells[ColunaDescontinuado.Index].Value = "Continuado"; // Descontinuado

                }
                else if (i.Descontinuado == false)
                {

                    // Se Ativo for igual a 'False' -> 0
                    GridProdutos.Rows[lista.IndexOf(i)].Cells[ColunaDescontinuado.Index].Value = "Descontinuado"; // Descontinuado

                }

            });


        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            // Objeto Cliente
            Produto p = new Produto(
                 txtNome.Text,
                 txtunidade.Text,
                 txtCodBar.Text,
                 Convert.ToDouble(txtValor.Text),
                 Convert.ToDouble(txtDesconto.Text)
                 );
            p.Inserir();
        }
    }
}
