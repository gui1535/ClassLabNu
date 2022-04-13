using ClassLabNu;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace ComercialSys
{
    public partial class FormCliente : MetroFramework.Forms.MetroForm
    {
        public FormCliente(Form parent)
        {
            InitializeComponent();

            // MdiParent
            MdiParent = parent;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            // Objeto Cliente
            ClassLabNu.Cliente c = new ClassLabNu.Cliente(
                txtNome.Text,
                txtCpf.Text,
                txtEmail.Text);

            c.Inserir();

            if (c.Id > 0)
            {
                // Verificação se email é valido
                if (Validacao.EmailValido(txtEmail.Text))
                {
                    txtId.Text = c.Id.ToString();
                    MessageBox.Show("Cliente inserido com sucesso", "SysComercial", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Email invalido", "SysComercial", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("Falha ao inserir cliente", "SysComercial", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }
        private void lstClientes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            // Abrir conexão
            var banco = Banco.Abrir();

            banco.CommandType = CommandType.Text;
            banco.CommandText = "select * from clientes";

            var da = new MySqlDataAdapter(banco);

            DataTable dt = new DataTable();

            da.Fill(dt);
            GridCliente.DataSource = dt;
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            // Abre conexão com banco
            var cmd = Banco.Abrir();

            // Comandos SQL
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"select * from clientes where idcli ='{txtIdPesq.Text}'";

            var da = new MySqlDataAdapter(cmd);

            DataTable dt = new DataTable();

            da.Fill(dt);
            GridCliente.DataSource = dt;

        }
    }
}
