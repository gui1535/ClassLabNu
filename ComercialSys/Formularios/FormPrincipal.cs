using ComercialSys.Formularios;
using System;

namespace ComercialSys
{
    public partial class FormPrincipal : MetroFramework.Forms.MetroForm
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            // Objeto FormCliente
            FormCliente frmCliente = new FormCliente(this);

            // Definindo Form como MdiParent
            frmCliente.MdiParent = this;

            // Abrir Form
            frmCliente.Show();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Instancia do form Cliente
            FormCliente frmCliente = new FormCliente(this);

            // Exibe Form
            frmCliente.Show();
        }

        private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Instancia do form Cliente
            FormProduto frmProduto = new FormProduto(this);

            // Exibe Form
            frmProduto.Show();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Instancia do form Cliente
            FormUsuario frmUsuario = new FormUsuario(this);

            // Exibe Form
            frmUsuario.Show();
        }
    }
}
