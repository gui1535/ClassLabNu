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

        // Ao carregar Form ---------------------------------------------------------------------------------------------------------------

        private void FormProduto_Load(object sender, EventArgs e)
        {

        }

        // Listar Produtos ---------------------------------------------------------------------------------------------------------------

        /// <summary>
        /// Metodo para listar produtos no DataGrid
        /// </summary>
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

        /// <summary>
        /// Listar informações do produto nas TextBox quando o usuario clicar 2 vezes na linha do DataGrid
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Botão para listar todos produtos no DataGrid
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnListar_Click(object sender, EventArgs e)
        {
            // Listando produtos
            ListarProdutos();
        }

        // Inserir Produtos ---------------------------------------------------------------------------------------------------------------

        /// <summary>
        /// Botão para inserir produtos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        // Pesquisar Produtos ---------------------------------------------------------------------------------------------------------------
        
        /// <summary>
        /// Pesquisar produtos por ID
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtIdPesq_KeyUp(object sender, KeyEventArgs e)
        {
            // Verificando se o valor a pesquisar é vazio
            if (txtIdPesq.Text == "")
            {
            }
            else
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

            // Limpar Campos
            txtCodBarPesq.Clear();
            txtValorPesq.Clear();
        }

        /// <summary>
        /// Pesquisar produtos por codigo de barras
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtCodBarPesq_KeyUp(object sender, KeyEventArgs e)
        {
            // Verificando se o valor a pesquisar é vazio
            if (txtCodBarPesq.Text == "")
            {
            }
            else
            {
                // Objeto Cliente
                Produto produto = new Produto();

                // Metodo Consulta por CodBar
                produto.ConsultarPorCodbar(Convert.ToString(txtCodBarPesq.Text));

                // Atributos
                txtId.Text = produto.Id.ToString();
                txtNome.Text = produto.Descricao;
                txtunidade.Text = produto.Unidade;
                txtCodBar.Text = produto.Codbar;
                txtValor.Text = Convert.ToString(produto.Valor);
                txtDesconto.Text = Convert.ToString(produto.Desconto.ToString());
            }

            // Limpar Campos
            txtIdPesq.Clear();
            txtValorPesq.Clear();
        }

        /// <summary>
        /// Pesquisar produtos por valor
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtValorPesq_KeyUp(object sender, KeyEventArgs e)
        {
            // Verificando se o valor a pesquisar é vazio
            if (txtValorPesq.Text == "")
            {
            }
            else
            {
                // Objeto Cliente
                Produto produto = new Produto();

                // Metodo Consulta por Valor
                produto.ConsultarPorValor(Convert.ToDouble(txtValorPesq.Text));

                // Atributos
                txtId.Text = produto.Id.ToString();
                txtNome.Text = produto.Descricao;
                txtunidade.Text = produto.Unidade;
                txtCodBar.Text = produto.Codbar;
                txtValor.Text = produto.Valor.ToString();
                txtDesconto.Text = produto.Desconto.ToString();
            }

            // Limpar Campos
            txtIdPesq.Clear();
            txtCodBarPesq.Clear();
        }
    }
}
