using ComercialSys.Controller;
using ComercialSys.Model;
using System;
using System.Data;
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
            txtIdPed.Text = ped.IdPedido;
            txtDataPed.Text = ped.DataPedido;
            lbStatusPed.Text = ped.StatusPedido;

            // GroupBox
            gpItensPed.Enabled = true;
            gpOperacoes.Enabled = true;
            gpDadosPed.Enabled = false;
        }

        private void btnInserirPed_Click(object sender, EventArgs e)
        {
            ItemPedidoModel c = new ItemPedidoModel();

        }
    }
}
