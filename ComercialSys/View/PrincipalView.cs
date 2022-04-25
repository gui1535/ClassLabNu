using ComercialSys.Formularios;
using ComercialSys.View;
using System;
using System.Windows.Forms;

namespace ComercialSys.FormPrincipal
{
    public partial class PrincipalView : Form
    {
        public PrincipalView()
        {
            InitializeComponent();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            // Objeto FormCliente
            ClienteView frmCliente = new ClienteView(this);

            // Definindo Form como MdiParent
            frmCliente.MdiParent = this;

            // Abrir Form
            frmCliente.Show();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Instancia do form Cliente
            ClienteView FormCliente = new ClienteView(this);

            // Exibe Form
            FormCliente.Show();
        }

        private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Instancia do form Cliente
            ProdutoView frmProduto = new ProdutoView(this);

            // Exibe Form
            frmProduto.Show();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Instancia do form Cliente
            UsuarioView frmUsuario = new UsuarioView(this);

            // Exibe Form
            frmUsuario.Show();
        }
    }
}
