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

            ClienteModel c = new ClienteModel();
            var lista = c.ListarClientes();

            cmbUsuarios.DataSource = lista.ToArray();
            cmbUsuarios.DisplayMember = "Nome";
            cmbUsuarios.ValueMember = "Id";



            //cmbUsuarios.DataSource = dt;
            //cmbUsuarios.ValueMember = "iduser";
            //cmbUsuarios.DisplayMember = "nome";
        }
    }
}
