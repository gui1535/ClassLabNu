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
            // frmCliente.MdiParent = this;

            // Abrir Form
            frmCliente.Show();
        }

        private void mtClientes_Click(object sender, EventArgs e)
        {
            FormCliente frmCliente = new FormCliente(this);
            frmCliente.Show();
        }
    }
}
