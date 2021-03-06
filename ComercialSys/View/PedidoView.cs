using ComercialSys.Controller;
using ComercialSys.Model;
using System;
using System.IO;
using System.Windows.Forms;

namespace ComercialSys.View
{
    public partial class PedidoView : Form
    {
        public PedidoView(Form parent)
        {
            InitializeComponent();

            MdiParent = parent;
        }

        private void PedidoView_Load(object sender, EventArgs e)
        {
            // Listando cliente no ComboBox
            ClienteController.ListClienteBox(cmbClientes);

            // Listando usuarios no ComboBox
            UsuarioController.ListUserBox(cmbUsuarios);
        }

        private void txtDescricao_Click(object sender, EventArgs e)
        {

        }

        private void btnCriarPed_Click(object sender, EventArgs e)
        {
            PedidoController ped = new PedidoController();

            ped.CriarPedido(cmbClientes, cmbUsuarios);

            // Valores para TextBox
            txtIdPed.Text = ped.Id.ToString();
            txtDataPed.Text = ped.DataPed;
            lbStatusPed.Text = ped.Status;

            // GroupBox
            gpItensPed.Enabled = true;
            gpOperacoes.Enabled = true;
            gpDadosPed.Enabled = false;
        }

        private void btnInserirPed_Click(object sender, EventArgs e)
        {
            // Controller
            ItemPedidoController IPC = new ItemPedidoController();

            // Inserindo item
            IPC.InserirItem(Convert.ToInt32(txtIdPed.Text), txtCodbar.Text, Convert.ToDouble(txtValor.Text), Convert.ToDouble(txtDesconto.Text));

            ListaDataGrid();
        }

        private void txtCodbar_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                // Verificando se o valor a pesquisar é vazio
                if (txtCodbar.Text.Length > 12)
                {
                    // Instancia do Controlador
                    ProdutoController PC = new ProdutoController();

                    // Consultando o ID do codbar para prencher TextBox
                    PC.ConsultaCodBar(txtCodbar.Text);

                    // Prenchendo TextBox
                    txtCodbar.Text = PC.Codbar;
                    txtDesconto.Text = PC.Desconto.ToString();
                    txtDescricao.Text = PC.Descricao;
                    txtValor.Text = PC.Valor.ToString();

                    MemoryStream mstream = new MemoryStream(ProdutoModel.PesquisaFotoCodBar(txtCodbar.Text));
                    picImage.Image = System.Drawing.Image.FromStream(mstream);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "SysComercial", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void ListaDataGrid()
        {
            ItemPedidoController IPC = new ItemPedidoController();

            // Instancia do Controlador
            ProdutoController PC = new ProdutoController();

            // Consultando o ID do codbar para prencher TextBox
            PC.ConsultaCodBar(txtCodbar.Text);

            IPC.ListarItem(Convert.ToInt32(txtIdPed.Text), PC.Id, GridItensPedido, colunaPedido, colunaProduto, colunaValor, colunaQuantidade, colunaDesconto);
            

            calculaTotal();
        }

        private void calculaTotal()
        {

            decimal total = 0;

            foreach (DataGridViewRow row in GridItensPedido.Rows)
            {
                total += Convert.ToDecimal(row.Cells["colunaValor"].Value) - Convert.ToDecimal(row.Cells["colunaDesconto"].Value);
            }

            txtValorFinal.Text = Convert.ToDouble(total).ToString("C");
        }

        private void btnFecharPed_Click(object sender, EventArgs e)
        {

        }
    }
}