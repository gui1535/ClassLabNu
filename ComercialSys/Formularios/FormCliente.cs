﻿using ClassLabNu;
using System;
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

            // Lista DataGrid
            ListarDataGrid();
        }

        // Form Load ---------------------------------------------------------------------------------------------------------------

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        /// <summary>
        /// Limpar campos de pesquisas
        /// </summary>
        private void LimpaCampoPesquisa()
        {
            // Limpar campos de pesquisa
            txtIdPesq.Clear();
            txtPesqNome.Clear();
            txtCpfPsq.Clear();
        }
        /// <summary>
        /// Desbloquear campos para inserir/editar cliente
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDesbloquear_Click(object sender, EventArgs e)
        {
            // Verificar se vai habilitar o botao EDITAR ou não
            if (Convert.ToInt32(txtId.Text) > 0)
            {
                // Habilitando / Desabilitando campos
                gpBoxPesq.Enabled = false;
                btnEditar.Enabled = true;
                btnInserir.Enabled = false;
                txtNome.Enabled = true;
                txtEmail.Enabled = true;
                chkAtivo.Enabled = true;

                // Limpar campos de pesquisa
                LimpaCampoPesquisa();
            }
            else if (Convert.ToInt32(txtId.Text) == 0)
            {
                // Habilitando / Desabilitando campos
                gpBoxPesq.Enabled = false;
                btnInserir.Enabled = true;
                txtNome.Enabled = true;
                txtEmail.Enabled = true;
                txtCpf.Enabled = true;
                chkAtivo.Enabled = true;
                chkAtivo.Checked = true;

                // Limpar campos de pesquisa
                LimpaCampoPesquisa();
            }

            btnDesbloquear.Visible = false;
            btnBloquear.Visible = true;
        }

        /// <summary>
        /// Bloquear campos para inserir/editar cliente
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBloquear_Click(object sender, EventArgs e)
        {

            // Habilitando / Desabilitando campos
            gpBoxPesq.Enabled = true;
            btnEditar.Enabled = false;
            btnInserir.Enabled = false;
            txtNome.Enabled = false;
            txtEmail.Enabled = false;
            txtCpf.Enabled = false;
            chkAtivo.Enabled = false;

            btnBloquear.Visible = false;
            btnDesbloquear.Visible = true;
        }

        // DataGrid Clientes ---------------------------------------------------------------------------------------------------------------

        /// <summary>
        /// Listar DataGrid de clientes
        /// </summary>
        private void ListarDataGrid()
        {
            // Limpar Grid
            GridCliente.Rows.Clear();

            // Novo objeto Cliente
            Cliente cliente = new Cliente();

            // Var para Listar clientes
            var lista = cliente.ListarClientes();

            // Listando clientes no DataGrid
            lista.ForEach(i =>
            {

                // Linhas 
                GridCliente.Rows.Add();
                GridCliente.Rows[lista.IndexOf(i)].Cells[colunaId.Index].Value = i.Id; // Text -> ID
                GridCliente.Rows[lista.IndexOf(i)].Cells[colunaNome.Index].Value = i.Nome; // Text -> Nome
                GridCliente.Rows[lista.IndexOf(i)].Cells[colunaEmail.Index].Value = i.Email; // Text -> Email
                GridCliente.Rows[lista.IndexOf(i)].Cells[colunaCpf.Index].Value = i.Cpf; // Text -> CPF
                GridCliente.Rows[lista.IndexOf(i)].Cells[colunaDataCad.Index].Value = i.dataCad; // Text -> DataCad
                GridCliente.Rows[lista.IndexOf(i)].Cells[colunaAtivo.Index].Value = i.Ativo; // Checkbox -> Ativo
            });
        }

        /// <summary>
        /// Listar informações do produto nas TextBox quando o usuario clicar 2 vezes na linha do DataGrid
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GridCliente_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            // Variaveis para objeto Cliente
            Cliente cliente = new Cliente();

            // Valores para o objeto
            cliente.Id = Convert.ToInt32(GridCliente["colunaId", e.RowIndex].Value);
            cliente.Nome = Convert.ToString(GridCliente["colunaNome", e.RowIndex].Value);
            cliente.Email = Convert.ToString(GridCliente["colunaEmail", e.RowIndex].Value);
            cliente.Cpf = Convert.ToString(GridCliente["colunaCpf", e.RowIndex].Value);
            cliente.Ativo = Convert.ToBoolean(GridCliente["colunaAtivo", e.RowIndex].Value);
            cliente.dataCad = Convert.ToString(GridCliente["colunaDataCad", e.RowIndex].Value);

            // Atributos
            txtId.Text = cliente.Id.ToString();
            txtNome.Text = cliente.Nome;
            txtEmail.Text = cliente.Email;
            txtCpf.Text = cliente.Cpf;
            chkAtivo.Checked = cliente.Ativo;
            txtDataCad.Text = cliente.dataCad;
        }


        // Limpar Campos ---------------------------------------------------------------------------------------------------------------

        /// <summary>
        /// Metodo limpar todos campos
        /// </summary>
        private void LimparTodosCampos()
        {
            // Limpa campos
            txtCpf.Clear();
            txtEmail.Clear();
            txtId.Clear();
            txtNome.Clear();
        }


        // Inserir Clientes ---------------------------------------------------------------------------------------------------------------

        /// <summary>
        /// Botao inserir Cliente
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnInserir_Click(object sender, EventArgs e)
        {

            // Objeto Cliente
            ClassLabNu.Cliente c = new ClassLabNu.Cliente(
                txtNome.Text,
                txtCpf.Text,
                txtEmail.Text
                );

            c.Inserir();

            // Se ID for maior que 0
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
                    // Email Invalido
                    MessageBox.Show($"Email invalido do cliente {c.Id}", "SysComercial", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                // Falha ao inserir cliente
                MessageBox.Show("Falha ao inserir cliente", "SysComercial", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            btnBloquear_Click(sender, e);
            ListarDataGrid();
        }

        // Inserir imagem Clientes ---------------------------------------------------------------------------------------------------------------

        /// <summary>
        /// Botao inserir imagem Cliente
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnInserirImg_Click(object sender, EventArgs e)
        {

        }

        // Listar Clientes ---------------------------------------------------------------------------------------------------------------

        /// <summary>
        /// Botao listar Cliente
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnListar_Click_1(object sender, EventArgs e)
        {
            // Listando Clientes
            ListarDataGrid();
        }

        // Editar Clientes ---------------------------------------------------------------------------------------------------------------

        /// <summary>
        /// Botao editar Cliente
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

            // Validação do email
            if (Validacao.EmailValido(txtEmail.Text))
            {
                // Condição se usuario deseja mesmo fazer a alteração
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
                        ListarDataGrid();
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
                // Email Invalido
                MessageBox.Show($"Email do cliente {cliente.Id} invalido", "SysComercial", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            // Bloqueando campos
            btnBloquear_Click(sender, e);
            // Listando DataGrid
            ListarDataGrid();
        }

        // Pesquisar Clientes ---------------------------------------------------------------------------------------------------------------

        /// <summary>
        /// Pesquisar cliente por nome
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtPesqNome_KeyUp(object sender, KeyEventArgs e)
        {
            // Verificando se o valor a pesquisar é vazio
            if (txtPesqNome.Text == "")
            {
            }
            else
            {
                // Objeto Cliente
                Cliente cliente = new Cliente();

                // Metodo Consulta por Nome
                cliente.ConsultarPorNome(Convert.ToString(txtPesqNome.Text));

                // Atributos
                txtId.Text = Convert.ToString(cliente.Id);
                txtNome.Text = cliente.Nome;
                txtEmail.Text = cliente.Email;
                txtCpf.Text = cliente.Cpf;
                chkAtivo.Checked = cliente.Ativo;
                txtDataCad.Text = cliente.dataCad;
            }

            // Limpando as TextBox de pesquisa
            txtIdPesq.Clear();
            txtCpfPsq.Clear();

        }

        /// <summary>
        /// Pesquisar cliente por CPF
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtCpfPsq_KeyUp(object sender, KeyEventArgs e)
        {
            // Verificando se o valor a pesquisar é vazio
            if (txtCpfPsq.Text == "")
            {
            }
            else
            {
                // Objeto Cliente
                Cliente cliente = new Cliente();

                // Metodo Consulta por CPF
                cliente.ConsultarPorCpf(Convert.ToString(txtCpfPsq.Text));

                // Atributos
                txtId.Text = Convert.ToString(cliente.Id);
                txtNome.Text = cliente.Nome;
                txtEmail.Text = cliente.Email;
                txtCpf.Text = cliente.Cpf;
                chkAtivo.Checked = cliente.Ativo;
                txtDataCad.Text = cliente.dataCad;
            }

            // Limpando as TextBox de pesquisa
            txtIdPesq.Clear();
            txtPesqNome.Clear();
        }

        /// <summary>
        /// Pesquisar cliente por ID
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtIdPesq_KeyUp(object sender, KeyEventArgs e)
        {
            // Verificando se o valor a pesquisar é vazio
            if (txtIdPesq.Text == "")
            {
            }
            else
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
                txtDataCad.Text = cliente.dataCad;

                btnInserir.Enabled = false;
            }


        }

        private void chkAtivo_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void chkAtivo_Click(object sender, EventArgs e)
        {
            // Se o usuario clicar no checkbox que esta em false
            if (chkAtivo.Checked == false)
            {
                // Confirmando certeza do usuario
                if (MessageBox.Show("Você tem certeza que deseja inativar o cliente?", "SysComercial", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    chkAtivo.Checked = false;
                }
                else
                {
                    chkAtivo.Checked = true;
                }
            }
            // Se o usuario clicar no checkbox que esta em true
            else if (chkAtivo.Checked == true)
            {
                // Confirmando certeza do usuario
                if (MessageBox.Show("Você tem certeza que deseja ativar o cliente?", "SysComercial", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    chkAtivo.Checked = true;
                }
                else
                {
                    chkAtivo.Checked = false;
                }
            }
        }
    }
}

