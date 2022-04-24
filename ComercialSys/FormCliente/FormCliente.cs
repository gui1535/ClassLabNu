using ClassLabNu;
using ComercialSys.Formularios.FormCliente;
using System;
using System.Windows.Forms;

namespace ComercialSys
{
    public partial class FormCliente : Form
    {
        public FormCliente(Form parent)
        {
            InitializeComponent();

            //MdiParent
            MdiParent = parent;

            // Lista DataGrid
            ListarDataGrid();
        }

        public FormCliente()
        {
        }

        // Form Load ---------------------------------------------------------------------------------------------------------------

        private void Form1_Load(object sender, EventArgs e)
        {
            string usuario = System.Environment.UserName;

            this.Text += usuario;
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

                // GroupBox
                gpBoxPesq.Enabled = false;
                gpboxNumeros.Enabled = true;
                gpboxEnderecos.Enabled = true;

                // Botao
                btnEditar.Enabled = true;
                btnInserir.Enabled = false;
                btnLimparCampos.Enabled = true;

                // TextBox
                txtObs.Enabled = true;
                txtNome.Enabled = true;
                txtEmail.Enabled = true;

                //CheckBox
                chkAtivo.Enabled = true;

                // Limpar campos de pesquisa
                LimpaCampoPesquisa();
            }
            else if (Convert.ToInt32(txtId.Text) == 0)
            {

                // GroupBox
                gpBoxPesq.Enabled = false;
                gpboxEnderecos.Enabled = false;
                gpboxNumeros.Enabled = false;

                // Botao
                btnInserir.Enabled = true;
                btnLimparCampos.Enabled = true;

                // TextBox
                txtNome.Enabled = true;
                txtEmail.Enabled = true;
                txtCpf.Enabled = true;
                txtObs.Enabled = true;

                //CheckBox
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

            // GroupBox
            gpBoxPesq.Enabled = true;
            gpboxEnderecos.Enabled = false;
            gpboxNumeros.Enabled = false;

            // Botao
            btnEditar.Enabled = false;
            btnInserir.Enabled = false;
            btnLimparCampos.Enabled = false;

            // TextBox
            txtNome.Enabled = false;
            txtEmail.Enabled = false;
            txtCpf.Enabled = false;
            txtObs.Enabled = false;

            // CheckBox
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
            // Instancia DataGrid Cliente
            ClienteDataGrid dt = new ClienteDataGrid();

            // Listando Clientes
            dt.ListarCliente(GridCliente, colunaId, colunaNome, colunaEmail, colunaCpf, colunaDataCad, colunaAtivo, colunaObs);
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
            cliente.Obs = Convert.ToString(GridCliente["colunaObs", e.RowIndex].Value);

            if ((Convert.ToInt32(txtId.Text) == 0) || (txtId.Text == null))
            {

            }
            else
            {
                // Limpar Grid
                GridEndereco.Rows.Clear();

                // Objeto Endereco
                Endereco end = new Endereco();

                // Var para Listar enderecos
                var lista = end.ListarEnderecoCli(cliente.Id);

                // Listando enderecos no DataGrid
                lista.ForEach(i =>
                {
                    // Linhas 
                    GridEndereco.Rows.Add();
                    GridEndereco.Rows[lista.IndexOf(i)].Cells[colunaCep.Index].Value = i.Cep; // Text -> Cep
                    GridEndereco.Rows[lista.IndexOf(i)].Cells[colunaCidade.Index].Value = i.Cidade; // Text -> Cidade
                    GridEndereco.Rows[lista.IndexOf(i)].Cells[colunaTipo.Index].Value = i.Tipo; // Text -> Tipo
                    GridEndereco.Rows[lista.IndexOf(i)].Cells[colunaBairro.Index].Value = i.Bairro; // Text -> Bairro
                    GridEndereco.Rows[lista.IndexOf(i)].Cells[colunaLogradouro.Index].Value = i.Logradouro; // Text -> Logradouro
                    GridEndereco.Rows[lista.IndexOf(i)].Cells[colunaEstado.Index].Value = i.Estado; // Text -> Estado
                    GridEndereco.Rows[lista.IndexOf(i)].Cells[colunaNumero.Index].Value = i.Numero; // Text -> Numero
                    GridEndereco.Rows[lista.IndexOf(i)].Cells[colunaComplemento.Index].Value = i.Complemento; // Text -> Complemento

                });
            }

            // Atributos
            txtId.Text = cliente.Id.ToString();
            txtNome.Text = cliente.Nome;
            txtEmail.Text = cliente.Email;
            txtCpf.Text = cliente.Cpf;
            chkAtivo.Checked = cliente.Ativo;
            txtDataCad.Text = cliente.dataCad;
            txtObs.Text = cliente.Obs;

            btnBloquear_Click(sender, e);
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
            txtObs.Clear();
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
                txtEmail.Text,
                txtObs.Text
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
            ListarDataGrid();
            btnDesbloquear_Click(sender, e);
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
            cliente.Obs = txtObs.Text;

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
                ListarDataGrid();

                // Limpando TextBox
                txtId.Text = "0";
                txtNome.Clear();
                txtEmail.Clear();
                txtCpf.Clear();
            }
            else
            {
                // Limpando TextBox Pesquisa
                txtIdPesq.Clear();
                txtCpfPsq.Clear();

                // Limpar Grid
                GridCliente.Rows.Clear();

                // Novo objeto Cliente
                Cliente cliente = new Cliente();

                // Var para Listar clientes
                var lista = cliente.ListarPorNome(txtPesqNome.Text);
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
                                                                                                 // Atributos
                    txtId.Text = i.Id.ToString();
                    txtNome.Text = i.Nome;
                    txtDataCad.Text = i.dataCad;
                    txtEmail.Text = i.Email;
                    txtCpf.Text = i.Cpf;
                    chkAtivo.Checked = i.Ativo;
                });
            }

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
                ListarDataGrid();

                // Limpando TextBox
                txtId.Text = "0";
                txtNome.Clear();
                txtEmail.Clear();
                txtCpf.Clear();
            }
            else
            {
                // Limpando TextBox Pesquisa
                txtIdPesq.Clear();
                txtPesqNome.Clear();

                // Limpar Grid
                GridCliente.Rows.Clear();

                // Novo objeto Cliente
                Cliente cliente = new Cliente();

                // Var para Listar clientes
                var lista = cliente.ListarPorCpf(txtCpfPsq.Text);
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
                                                                                                 // Atributos
                    txtId.Text = i.Id.ToString();
                    txtNome.Text = i.Nome;
                    txtDataCad.Text = i.dataCad;
                    txtEmail.Text = i.Email;
                    txtCpf.Text = i.Cpf;
                    chkAtivo.Checked = i.Ativo;
                });
            }
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
                ListarDataGrid();

                // Limpando TextBox
                txtId.Text = "0";
                txtNome.Clear();
                txtEmail.Clear();
                txtCpf.Clear();
            }
            else
            {
                // Limpando TextBox Pesquisa
                txtCpfPsq.Clear();
                txtPesqNome.Clear();

                // Limpar Grid
                GridCliente.Rows.Clear();

                // Novo objeto Cliente
                Cliente cliente = new Cliente();

                // Var para Listar clientes
                var lista = cliente.ListarPorId(int.Parse(txtIdPesq.Text));
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
                                                                                                 // Atributos
                    txtId.Text = i.Id.ToString();
                    txtNome.Text = i.Nome;
                    txtDataCad.Text = i.dataCad;
                    txtEmail.Text = i.Email;
                    txtCpf.Text = i.Cpf;
                    chkAtivo.Checked = i.Ativo;
                });
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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtCep_KeyUp(object sender, KeyEventArgs e)
        {
            // Verificando para pesquisar só se tiver 8 valores
            if (txtCep.Text.Length == 8)
            {
                Cep.ConsultarCep(txtCep.Text.Trim());
                txtLogradouro.Text = JsonCepResult.Logradouro;
                txtBairro.Text = JsonCepResult.Bairro;
                txtCidade.Text = JsonCepResult.Localidade;
                txtComplemento.Text = JsonCepResult.Complemento;
                txtUf.Text = JsonCepResult.Uf;
                txtEstado.Text = VerificaUf.VerificarUf();
            }
        }
        private void btnCancelCep_Click(object sender, EventArgs e)
        {
            txtCep.Text = String.Empty;
            txtUf.Text = String.Empty;
            txtEstado.Text = String.Empty;
            txtLogradouro.Text = String.Empty;
            txtCidade.Text = String.Empty;
            txtBairro.Text = String.Empty;
            txtComplemento.Text = String.Empty;
            cmbTipo.Text = String.Empty;
        }

        private void btnAddCep_Click(object sender, EventArgs e)
        {
            try
            {
                // Passando valores ao objeto endereco
                Endereco end = new Endereco();

                end.Logradouro = txtLogradouro.Text;
                end.Cep = txtCep.Text;
                end.Numero = txtNumero.Text;
                end.Cidade = txtCidade.Text;
                end.Bairro = txtBairro.Text;
                end.Estado = txtEstado.Text;
                end.Uf = txtUf.Text;
                end.Tipo = cmbTipo.Text;
                end.Complemento = txtComplemento.Text;

                // Atribuindo valor do TextBox para o ClienteID
                int ClienteID = int.Parse(txtId.Text);

                end.IdCli = ClienteID;

                // Inserir endereco
                end.Inserir();

                // Mensagem sucesso
                MessageBox.Show("Endereço inserido com sucesso", "SysComercial", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                // Mensagem de erro
                MessageBox.Show("Erro ao inserir endereço", "SysComercial", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLimparCampos_Click(object sender, EventArgs e)
        {
            txtNome.Text = String.Empty;
            txtCpf.Text = String.Empty;
            txtEmail.Text = String.Empty;
            txtObs.Text = String.Empty;
            chkAtivo.Checked = true;
            txtId.Text = "0";
            txtDataCad.Text = String.Empty;
            gpboxEnderecos.Enabled = false;
            gpboxNumeros.Enabled = false;

            btnBloquear_Click(sender, e);
        }

        private void GridEndereco_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Variaveis para objeto Endereco
            Endereco end = new Endereco();

            // Valores para o objeto
            end.Cep = Convert.ToString(GridEndereco["colunaCep", e.RowIndex].Value);
            end.Cidade = Convert.ToString(GridEndereco["colunaCidade", e.RowIndex].Value);
            end.Tipo = Convert.ToString(GridEndereco["colunaTipo", e.RowIndex].Value);
            end.Bairro = Convert.ToString(GridEndereco["colunaBairro", e.RowIndex].Value);
            end.Logradouro = Convert.ToString(GridEndereco["colunaLogradouro", e.RowIndex].Value);
            end.Estado = Convert.ToString(GridEndereco["colunaEstado", e.RowIndex].Value);
            end.Numero = Convert.ToString(GridEndereco["colunaNumero", e.RowIndex].Value);
            end.Complemento = Convert.ToString(GridEndereco["colunaComplemento", e.RowIndex].Value);

            // Atribuindo valores
            txtCep.Text = end.Cep;
            txtCidade.Text = end.Cidade;
            cmbTipo.Text = end.Tipo;
            txtBairro.Text = end.Bairro;
            txtLogradouro.Text = end.Logradouro;
            txtEstado.Text = end.Estado;
            txtNumero.Text = end.Numero;
            txtComplemento.Text = end.Complemento;
        }
    }
}