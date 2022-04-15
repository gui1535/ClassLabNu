using ClassLabNu;
using System;
using System.Drawing;
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
                GridCliente.Rows[lista.IndexOf(i)].Cells[colunaAtivo.Index].Value = i.Ativo; // Checkbox Ativo


            });
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void LimparTodosCampos()
        {
            txtCpf.Clear();
            txtEmail.Clear();
            txtId.Clear();
            txtNome.Clear();
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {

            // Objeto Cliente
            ClassLabNu.Cliente c = new ClassLabNu.Cliente(
                txtNome.Text,
                txtCpf.Text,
                txtEmail.Text
                );

            c.Inserir();

            if (c.Id > 0)
            {
                // Verificação se email é valido
                if (Validacao.EmailValido(txtEmail.Text))
                {
                    txtId.Text = c.Id.ToString();
                    MessageBox.Show($"Cliente {c.Id} inserido com sucesso", "SysComercial", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show($"Email invalido do cliente {c.Id}", "SysComercial", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("Falha ao inserir cliente", "SysComercial", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
            chkAtivo.Checked = cliente.Ativo;

            // Limpando as TextBox de pesquisa
            txtIdPesq.Clear();
            txtCpfPsq.Clear();

        }

        private void GridCliente_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Variaveis para objeto Cliente
            Cliente c = new Cliente();

            // Valores para o objeto
            c.Id = Convert.ToInt32(GridCliente["colunaId", e.RowIndex].Value);
            c.Nome = Convert.ToString(GridCliente["colunaNome", e.RowIndex].Value);
            c.Email = Convert.ToString(GridCliente["colunaEmail", e.RowIndex].Value);
            c.Cpf = Convert.ToString(GridCliente["colunaCpf", e.RowIndex].Value);
            c.Ativo = Convert.ToBoolean(GridCliente["colunaAtivo", e.RowIndex].Value);

            // Atributos
            txtId.Text = c.Id.ToString();
            txtNome.Text = c.Nome;
            txtEmail.Text = c.Email;
            txtCpf.Text = c.Cpf;
            chkAtivo.Checked = c.Ativo;
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
            chkAtivo.Checked = cliente.Ativo;

            // Limpando as TextBox de pesquisa
            txtIdPesq.Clear();
            txtCpfPsq.Clear();
        }

        private void btnInserirImg_Click(object sender, EventArgs e)
        {
            try
            {
                FileDialogImg.Filter = "Fotos (*.jpg;*.png;) | *.jpg;*.png";

                if (FileDialogImg.ShowDialog() == DialogResult.OK)
                {
                    picImgCliente.Image = new Bitmap(FileDialogImg.FileName);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Erro ao carregar imagem", "SysComercial", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnListar_Click_1(object sender, EventArgs e)
        {
            // Listando Clientes
            ListarDataGrid();
        }


        private void btnEditar_Click(object sender, EventArgs e)
        {
            // Objeto Cliente
            Cliente cliente = new Cliente();

            // Atributos do objeto
            cliente.Id = int.Parse(txtId.Text);
            cliente.Nome = txtNome.Text;
            cliente.Cpf = txtCpf.Text;
            cliente.Email = txtEmail.Text;
            cliente.Ativo = chkAtivo.Checked;

            if (Validacao.EmailValido(txtEmail.Text))
            {
                if (MessageBox.Show("Você tem certeza que deseja alterar?", "SysComercial", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    // Condição
                    if (cliente.Alterar()) // Se cliente alterar for igual a TRUE
                    {
                        // Mensagem Box
                        MessageBox.Show("Cliente alterado com sucesso!", "SysComercial", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Limpa todos campos
                        LimparTodosCampos();

                        // Lista denovo
                        btnListar_Click_1(sender, e);
                    }
                    else // Senão
                    {
                        // Mensagem Box
                        MessageBox.Show("Falha ao alterar o cliente!", "SysComercial", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show($"Email do cliente {cliente.Id} invalido", "SysComercial", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}

