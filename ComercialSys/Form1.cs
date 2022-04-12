using ClassLabNu;
using System;
namespace ComercialSys
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            // Objeto Cliente
            Cliente c = new Cliente(
                txtNome.Text,
                txtCpf.Text,
                txtEmail.Text);

            c.Inserir();

            txtId.Text = c.Id.ToString();

            txtNome.Clear();
            txtCpf.Clear();
            txtEmail.Clear();

        }
    }
}
