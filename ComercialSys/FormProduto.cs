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

            // Listando Produtos
            ListarProdutos();
        }

        private void ListarProdutos()
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
                GridProdutos.Rows[lista.IndexOf(i)].Cells[colunaId.Index].Value = i.Id; // ID
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

        private void btnListar_Click(object sender, EventArgs e)
        {
            // Listando produtos
            ListarProdutos();
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            // Objeto Produto
            Produto p = new Produto(
                 txtNome.Text,
                 txtunidade.Text,
                 txtCodBar.Text,
                 Convert.ToDouble(txtValor.Text),
                 Convert.ToDouble(txtDesconto.Text)
                 );
            p.Inserir(); ;
        }

        private void GridProdutos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Variaveis para objeto Produto
            int id;
            string unidade, codbar, nome;
            double valor, desconto;

            // Valores para variaveis
            id = Convert.ToInt32(GridProdutos["colunaId", e.RowIndex].Value);
            nome = Convert.ToString(GridProdutos["colunaNome", e.RowIndex].Value);
            unidade = Convert.ToString(GridProdutos["colunaUnidade", e.RowIndex].Value);
            codbar = Convert.ToString(GridProdutos["colunaCodBar", e.RowIndex].Value);
            valor = Convert.ToInt32(GridProdutos["colunaValor", e.RowIndex].Value);
            desconto = Convert.ToInt32(GridProdutos["colunaDesconto", e.RowIndex].Value);


            // Objeto Produto
            Produto produto = new Produto(id, nome, unidade, codbar, valor, desconto);

            // Atributos
            txtId.Text = produto.Id.ToString();
            txtNome.Text = produto.Descricao;
            txtunidade.Text = produto.Unidade;
            txtCodBar.Text = produto.Codbar;
            txtValor.Text = produto.Valor.ToString();
            txtDesconto.Text = produto.Desconto.ToString();
        }

        private void btnPesqId_Click(object sender, EventArgs e)
        {
            // Objeto Cliente
            Produto produto = new Produto();

            // Metodo Consulta por ID
            produto.ConsultarPorId(int.Parse(txtIdPesq.Text));

            // Atributos
            txtId.Text = produto.Id.ToString();
            txtNome.Text = produto.Descricao;
            txtunidade.Text = produto.Unidade;
            txtCodBar.Text = produto.Codbar;
            txtValor.Text = produto.Valor.ToString();
            txtDesconto.Text = produto.Desconto.ToString();
        }

        private void btnPesqValor_Click(object sender, EventArgs e)
        {
            // Objeto Cliente
            Produto produto = new Produto();

            // Metodo Consulta por ID
            produto.ConsultarPorValor(int.Parse(txtValorPesq.Text));

            // Atributos
            txtId.Text = produto.Id.ToString();
            txtNome.Text = produto.Descricao;
            txtunidade.Text = produto.Unidade;
            txtCodBar.Text = produto.Codbar;
            txtValor.Text = produto.Valor.ToString();
            txtDesconto.Text = produto.Desconto.ToString();
        }

        private void btnPesqCodBar_Click(object sender, EventArgs e)
        {
            // Objeto Cliente
            Produto produto = new Produto();

            // Metodo Consulta por ID
            produto.ConsultarPorCodbar(Convert.ToString(txtCodBarPesq.Text));

            // Atributos
            txtId.Text = produto.Id.ToString();
            txtNome.Text = produto.Descricao;
            txtunidade.Text = produto.Unidade;
            txtCodBar.Text = produto.Codbar;
            txtValor.Text = Convert.ToString(produto.Valor);
            txtDesconto.Text = Convert.ToString(produto.Desconto.ToString());
        }

        private void FormProduto_Load(object sender, EventArgs e)
        {

        }
    }
}
