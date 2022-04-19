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

        /// <summary>
        /// Limpar campos de pesquisas
        /// </summary>
        private void LimpaCampoPesquisa()
        {
            // Limpar campos de pesquisa
            txtIdPesq.Clear();
            txtValorPesq.Clear();
            txtCodBarPesq.Clear();
        }

        /// <summary>
        /// Bloquear campos para inserir/editar cliente
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBloquear_Click(object sender, EventArgs e)
        {
            // Habilitando / Desabilitando campos
            gpBoxPesq.Enabled = true;
            btnEditar.Enabled = false;
            btnInserir.Enabled = false;
            txtNome.Enabled = false;
            txtValor.Enabled = false;
            txtCodBar.Enabled = false;
            txtunidade.Enabled = false;
            txtDesconto.Enabled = false;
            chkDescontinuado.Enabled = false;

            // Limpando TextBox
            txtId.Text = "0";
            txtNome.Clear();
            txtValor.Text = "0";
            txtCodBar.Clear();
            txtunidade.Text = "0";
            txtDesconto.Text = "0";

            btnBloquear.Visible = false;
            btnDesbloquear.Visible = true;
        }

        /// <summary>
        /// Desbloquear campos para inserir/editar produto
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDesbloquear_Click(object sender, EventArgs e)
        {
            // Verificar se vai habilitar o botao EDITAR ou não
            if (Convert.ToInt32(txtId.Text) > 0)
            {
                // Habilitando / Desabilitando campos
                gpBoxPesq.Enabled = false;
                btnEditar.Enabled = true;
                btnInserir.Enabled = false;
                txtNome.Enabled = true;
                txtValor.Enabled = true;
                txtCodBar.Enabled = true;
                txtunidade.Enabled = true;
                txtDesconto.Enabled = true;
                chkDescontinuado.Enabled = true;

                // Limpar campos de pesquisa
                LimpaCampoPesquisa();
            }
            else if (Convert.ToInt32(txtId.Text) == 0)
            {
                // Habilitando / Desabilitando campos
                gpBoxPesq.Enabled = false;
                btnEditar.Enabled = false;
                btnInserir.Enabled = true;
                txtNome.Enabled = true;
                txtValor.Enabled = true;
                txtCodBar.Enabled = true;
                txtunidade.Enabled = true;
                txtDesconto.Enabled = true;
                chkDescontinuado.Enabled = true;
                chkDescontinuado.Checked = true;

                // Limpar campos de pesquisa
                LimpaCampoPesquisa();
            }

            btnDesbloquear.Visible = false;
            btnBloquear.Visible = true;
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
            Produto PAtributos = new Produto();

            // Valores para variaveis
            PAtributos.Id = Convert.ToInt32(GridProdutos["colunaId", e.RowIndex].Value);
            PAtributos.Descricao = Convert.ToString(GridProdutos["colunaNome", e.RowIndex].Value);
            PAtributos.Unidade = Convert.ToString(GridProdutos["colunaUnidade", e.RowIndex].Value);
            PAtributos.Codbar = Convert.ToString(GridProdutos["colunaCodBar", e.RowIndex].Value);
            PAtributos.Valor = Convert.ToInt32(GridProdutos["colunaValor", e.RowIndex].Value);
            PAtributos.Desconto = Convert.ToInt32(GridProdutos["colunaDesconto", e.RowIndex].Value);
            PAtributos.Descontinuado = Convert.ToBoolean(GridProdutos["ColunaDescontinuado", e.RowIndex].Value);

            // Atributos
            txtId.Text = PAtributos.Id.ToString();
            txtNome.Text = PAtributos.Descricao;
            txtunidade.Text = PAtributos.Unidade;
            txtCodBar.Text = PAtributos.Codbar;
            txtValor.Text = PAtributos.Valor.ToString();
            txtDesconto.Text = PAtributos.Desconto.ToString();
            chkDescontinuado.Checked = PAtributos.Descontinuado;
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
            try
            {
                // Objeto Produto
                Produto produto = new Produto(
                     txtNome.Text,
                     txtunidade.Text,
                     txtCodBar.Text,
                     Convert.ToDouble(txtValor.Text),
                     Convert.ToDouble(txtDesconto.Text),
                     Convert.ToBoolean(chkDescontinuado.Checked)
                     );

                // Inserindo produtoo
                produto.Inserir();

                MessageBox.Show($"Produto {produto.Id} inserido com sucesso", "SysComercial", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Bloqueando campos
                btnBloquear_Click(sender, e);

                //Listando DataGrid
                ListarProdutos();
            }
            catch (Exception)
            {

                throw;
            }


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
                ListarProdutos();
            }
            else
            {
                // Limpar Grid
                GridProdutos.Rows.Clear();

                // Novo objeto Cliente
                Produto produto = new Produto();

                // Var para Listar clientes
                var lista = produto.ListarPorId(int.Parse(txtIdPesq.Text));
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
                });

                // Atributos
                txtId.Text = produto.Id.ToString();
                txtNome.Text = produto.Descricao;
                txtunidade.Text = produto.Unidade;
                txtCodBar.Text = produto.Codbar;
                txtValor.Text = produto.Valor.ToString();
                txtDesconto.Text = produto.Desconto.ToString();
            }
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
                ListarProdutos();
            }
            else
            {
                // Limpar Grid
                GridProdutos.Rows.Clear();

                // Novo objeto Cliente
                Produto produto = new Produto();

                // Var para Listar clientes
                var lista = produto.ListarPorCodbar(Convert.ToString(txtCodBarPesq.Text));
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

                });

                // Atributos
                txtId.Text = produto.Id.ToString();
                txtNome.Text = produto.Descricao;
                txtunidade.Text = produto.Unidade;
                txtCodBar.Text = produto.Codbar;
                txtValor.Text = produto.Valor.ToString();
                txtDesconto.Text = produto.Desconto.ToString();
            }
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
                ListarProdutos();
            }
            else
            {
                // Limpar Grid
                GridProdutos.Rows.Clear();

                // Novo objeto Cliente
                Produto produto = new Produto();

                // Var para Listar clientes
                var lista = produto.ListarPorValor(Convert.ToDouble(txtValorPesq.Text));
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
                });

                // Atributos
                txtId.Text = produto.Id.ToString();
                txtNome.Text = produto.Descricao;
                txtunidade.Text = produto.Unidade;
                txtCodBar.Text = produto.Codbar;
                txtValor.Text = produto.Valor.ToString();
                txtDesconto.Text = produto.Desconto.ToString();
            }
        }

        private void chkDescontinuado_click(object sender, EventArgs e)
        {
            // Se o usuario clicar no checkbox que esta em false
            if (chkDescontinuado.Checked == false)
            {
                // Confirmando certeza do usuario
                if (MessageBox.Show("Você tem certeza que deseja descontinuar o produto?", "SysComercial", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    chkDescontinuado.Checked = false;
                }
                else
                {
                    chkDescontinuado.Checked = true;
                }
            }
            // Se o usuario clicar no checkbox que esta em true
            else if (chkDescontinuado.Checked == true)
            {
                // Confirmando certeza do usuario
                if (MessageBox.Show("Você tem certeza que deseja continuar o produto?", "SysComercial", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    chkDescontinuado.Checked = true;
                }
                else
                {
                    chkDescontinuado.Checked = false;
                }
            }
        }
    }
}
