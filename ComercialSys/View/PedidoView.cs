using ComercialSys.Controller;
using ComercialSys.Model;
using System;
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
        }

        private void txtCodbar_KeyUp(object sender, KeyEventArgs e)
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
            }
        }


        private void ListaDataGrid()
        {
            ItemPedidoController IPC = new ItemPedidoController();

            IPC.ListarItem(Convert.ToInt32(txtIdPed.Text), );

                        int _idped,
        int _idprod,
        DataGridView dt,
        DataGridViewTextBoxColumn CnlPed,
        DataGridViewTextBoxColumn ClnProd,
        DataGridViewTextBoxColumn ClnQuantidade,
        DataGridViewTextBoxColumn ClnValor,
        DataGridViewTextBoxColumn ClnDesconto
        }
    }
}