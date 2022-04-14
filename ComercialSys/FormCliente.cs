using ClassLabNu;
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

            //MdiParent
            MdiParent = parent;

            ListarDataGrid();
        }

        private void ListarDataGrid()
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
            ListarDataGrid();
        }
        private void btnPesqId_Click(object sender, EventArgs e)
        {
            // Objeto Cliente
            Cliente cliente = new Cliente();

            // Metodo Consulta por ID
            cliente.ConsultarPorId(int.Parse(txtIdPesq.Text));

            // Atributos
            txtId.Text = Convert.ToString(cliente.Id);
            txtNome.Text = cliente.Nome;
            txtEmail.Text = cliente.Email;
            txtCpf.Text = cliente.Cpf;

            // Limpando as TextBox de pesquisa
            txtIdPesq.Clear();
            txtCpfPsq.Clear();
        }

        private void GridCliente_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Variaveis para objeto Cliente
            int id;
            string nome, email, cpf;

            // Valores para variaveis
            id = Convert.ToInt32(GridCliente["colunaId", e.RowIndex].Value);
            nome = Convert.ToString(GridCliente["colunaNome", e.RowIndex].Value);
            email = Convert.ToString(GridCliente["colunaEmail", e.RowIndex].Value);
            cpf = Convert.ToString(GridCliente["colunaCpf", e.RowIndex].Value);

            // Objeto Cliente
            Cliente cliente = new Cliente(id, nome, email, cpf);

            // Atributos
            txtId.Text = cliente.Id.ToString();
            txtNome.Text = cliente.Nome;
            txtEmail.Text = cliente.Email;
            txtCpf.Text = cliente.Cpf;
        }

        private void btnPesqCpf_Click(object sender, EventArgs e)
        {
            // Objeto Cliente
            Cliente cliente = new Cliente();

            // Metodo Consulta por ID
            cliente.ConsultarPorCpf(Convert.ToString(txtCpfPsq.Text));

            // Atributos
            txtId.Text = Convert.ToString(cliente.Id);
            txtNome.Text = cliente.Nome;
            txtEmail.Text = cliente.Email;
            txtCpf.Text = cliente.Cpf;

            // Limpando as TextBox de pesquisa
            txtIdPesq.Clear();
            txtCpfPsq.Clear();
        }

        private void btnInserirImg_Click(object sender, EventArgs e)
        {
            // Instancia do open file dialog
            OpenFileDialog dialog = new OpenFileDialog();

            // Filtrar arquivos de imagem
            dialog.Filter = "JPG Files(*.jpg)|*.jpg|PNG Files(*.png)|*.png|AllFiles(*.*)|*.*";

            // Condição
            if (dialog.ShowDialog() == DialogResult.OK) // Se o dialogo for aberto e reconhecer que o usuario clicou em OK
            {

            }
        }
    }
}

