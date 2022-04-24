using ComercialSys.FormCliente;
using ComercialSys.FormCliente.Classes;
using ComercialSys.Formularios;
using System;
using System.Windows.Forms;

namespace ComercialSys.FormPrincipal
{
    public partial class ViewPrincipal : Form
    {
        public ViewPrincipal()
        {
            InitializeComponent();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            // Objeto FormCliente
            ViewCliente frmCliente = new ViewCliente(this);

            // Definindo Form como MdiParent
            frmCliente.MdiParent = this;

            // Abrir Form
            frmCliente.Show();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Instancia do form Cliente
            ViewCliente FormCliente = new ViewCliente(this);

            // Exibe Form
            FormCliente.Show();
        }

        private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Instancia do form Cliente
            ViewProduto frmProduto = new ViewProduto(this);

            // Exibe Form
            frmProduto.Show();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Instancia do form Cliente
            ViewUsuario frmUsuario = new ViewUsuario(this);

            // Exibe Form
            frmUsuario.Show();
        }
    }
}
