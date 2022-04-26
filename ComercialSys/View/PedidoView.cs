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
            // Listando Usuarios ComboBox
            cmbClientes.DataSource = ClienteModel.ListarClientes().ToArray();
            cmbClientes.DisplayMember = "Nome";
            cmbClientes.ValueMember = "Id";

            // Listando Clientes ComboBox
            cmbUsuarios.DataSource = UsuarioModel.ListarUsuarios().ToArray();
            cmbUsuarios.DisplayMember = "Nome";
            cmbUsuarios.ValueMember = "Id";
        }

        private void txtDescricao_Click(object sender, EventArgs e)
        {

        }

        private void btnCriarPed_Click(object sender, EventArgs e)
         {

            PedidoModel ped = new PedidoModel();

            ped.Inserir(new ClienteModel(Convert.ToInt32(cmbClientes.SelectedValue)), new UsuarioModel(Convert.ToInt32(cmbUsuarios.SelectedValue)));

            // Status aberto
            lbStatusPed.Text = ped.Status == "A" ? "ABERTO" : "";

            // GroupBox
            gpItensPed.Enabled = true;
            gpOperacoes.Enabled = true;
            gpDadosPed.Enabled = false;
            txtIdPed.Text = ped.Id.ToString();
        }
    }
}
