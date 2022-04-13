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

        private void btnListar_Click(object sender, EventArgs e)
        {
            // Limpar Grid
            GridCliente.Rows.Clear();

            // Novo objeto Cliente
            Cliente cliente = new Cliente();

            // Var para Listar clientes
            var lista = cliente.ListarClientes();
            lista.ForEach(i =>
            {

                // Linhas 
                GridCliente.Rows.Add();
                GridCliente.Rows[lista.IndexOf(i)].Cells[colunaId.Index].Value = i.Id; // ID
                GridCliente.Rows[lista.IndexOf(i)].Cells[colunaNome.Index].Value = i.Nome; // Nome
                GridCliente.Rows[lista.IndexOf(i)].Cells[colunaEmail.Index].Value = i.Email; // Email
                GridCliente.Rows[lista.IndexOf(i)].Cells[colunaCpf.Index].Value = i.Cpf; // CPF
                GridCliente.Rows[lista.IndexOf(i)].Cells[colunaDataCad.Index].Value = i.dataCad; // DataCad

                // Verificação para Ativo ou Inativo
                if ((i.Ativo == true))
                {

                    // Se Ativo for igual a 'True' -> 1
                    GridCliente.Rows[lista.IndexOf(i)].Cells[colunaAtivo.Index].Value = "Ativo"; // Ativo

                }
                else if (i.Ativo == false)
                {

                    // Se Ativo for igual a 'False' -> 0
                    GridCliente.Rows[lista.IndexOf(i)].Cells[colunaAtivo.Index].Value = "Inativo"; // Inativo

                }

            });



        }

        private void btnPesquisarId_Click(object sender, EventArgs e)
        {
            // Abre conexão com banco
            var banco = Banco.Abrir();

            // Comandos SQL
            banco.CommandType = CommandType.Text;
            banco.CommandText = $"select * from clientes where idcli ='{txtIdPesq.Text}'";

            var da = new MySqlDataAdapter(banco);

            DataTable dt = new DataTable();

            da.Fill(dt);
            GridCliente.DataSource = dt;
        }

        private void btnPesqCpf_Click(object sender, EventArgs e)
        {
            // Abre conexão com banco
            var banco = Banco.Abrir();

            // Comandos SQL
            banco.CommandType = CommandType.Text;
            banco.CommandText = $"select * from clientes where cpf ='{txtCpfPsq.Text}'";

            var da = new MySqlDataAdapter(banco);

            DataTable dt = new DataTable();

            da.Fill(dt);
            GridCliente.DataSource = dt;
        }
    }
}
