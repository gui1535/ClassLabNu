using ComercialSys.Controller;
using System;
using System.Windows.Forms;

namespace ComercialSys.View
{
    public partial class ClienteView : Form
    {
        public ClienteView(Form parent)
        {
            InitializeComponent();

            //MdiParent
            MdiParent = parent;

            // Lista DataGrid
            ListarDataGrid();
        }

        public ClienteView()
        {
        }
        // Form Load ---------------------------------------------------------------------------------------------------------------

        private void Form1_Load(object sender, EventArgs e)
        {
            string usuario = Environment.UserName;

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

            // Listando Clientes
            ClienteController.ListarCliente(GridCliente, colunaId, colunaNome, colunaEmail, colunaCpf, colunaDataCad, colunaAtivo, colunaObs);
        }

        /// <summary>
        /// Listar informações do produto nas TextBox quando o usuario clicar 2 vezes na linha do DataGrid
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GridCliente_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ClienteController clienteC = new ClienteController();

            clienteC.GridCliente_DoubleClick(GridCliente, e);

            // Instancia
            EnderecoController dt = new EnderecoController();

            // Listando enderecos dos clientes
            dt.ListarEndereco(GridEndereco, clienteC, colunaCep, colunaCidade, colunaTipo, colunaBairro, colunaLogradouro, colunaEstado, colunaNumero, colunaComplemento);

            // Atributos
            txtId.Text = clienteC.IdCli.ToString();
            txtNome.Text = clienteC.NomeCli;
            txtEmail.Text = clienteC.EmailCli;
            txtCpf.Text = clienteC.CpfCli;
            chkAtivo.Checked = clienteC.AtivoCli;
            txtDataCad.Text = clienteC.DatacadCli;
            txtObs.Text = clienteC.ObsCli;

            btnBloquear_Click(sender, e);
        }

        // Inserir Clientes ---------------------------------------------------------------------------------------------------------------

        private void btnInserir_Click(object sender, EventArgs e)
        {
            // Objeto
            ClienteController cli = new ClienteController();

            // Valores para o controlador
            cli.InserirCliente(Convert.ToInt32(txtId.Text), txtNome.Text, txtCpf.Text, txtEmail.Text, txtObs.Text);

            txtId.Text = cli.IdCli;

            // Listar DataGrid
            ListarDataGrid();

            // Desbloquear campos
            btnDesbloquear_Click(sender, e);
        }

        // Inserir imagem Clientes ---------------------------------------------------------------------------------------------------------------

        /// <param name="e"></param>
        private void btnInserirImg_Click(object sender, EventArgs e)
        {

        }

        // Listar Clientes ---------------------------------------------------------------------------------------------------------------

        private void btnListar_Click_1(object sender, EventArgs e)
        {
            // Listando Clientes
            ListarDataGrid();
        }

        // Editar Clientes ---------------------------------------------------------------------------------------------------------------

        private void btnEditar_Click(object sender, EventArgs e)
        {
            // Objeto
            ClienteController cli = new ClienteController();

            // Valores para o controlador
            cli.EditarCliente(Convert.ToInt32(txtId.Text), txtNome.Text, txtCpf.Text, txtEmail.Text, chkAtivo.Checked, txtObs.Text);

            // Listando DataGrid
            ListarDataGrid();
        }

        // Pesquisar Clientes ---------------------------------------------------------------------------------------------------------------

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

                // Instancia DataGrid Cliente
                ClienteController dt = new ClienteController();

                // Listando Clientes
                dt.PesquisarClienteNome(GridCliente, txtPesqNome.Text, colunaId, colunaNome, colunaEmail, colunaCpf, colunaDataCad, colunaAtivo, colunaObs);

                // Atribuindo valores
                dt.IdCli = txtId.Text;
                dt.CpfCli = txtCpf.Text;
                dt.EmailCli = txtEmail.Text;
                dt.NomeCli = txtNome.Text;
                dt.AtivoCli = chkAtivo.Checked;
                dt.DatacadCli = txtDataCad.Text;
            }

        }

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


                // Instancia DataGrid Cliente
                ClienteController dt = new ClienteController();

                // Listando Clientes
                dt.PesquisarClienteCpf(GridCliente, txtCpfPsq.Text, colunaId, colunaNome, colunaEmail, colunaCpf, colunaDataCad, colunaAtivo, colunaObs);

                // Atribuindo valores
                dt.IdCli = txtId.Text;
                dt.CpfCli = txtCpf.Text;
                dt.EmailCli = txtEmail.Text;
                dt.NomeCli = txtNome.Text;
                dt.AtivoCli = chkAtivo.Checked;
                dt.DatacadCli = txtDataCad.Text;

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

                // Instancia DataGrid Cliente
                ClienteController dt = new ClienteController();

                // Listando Clientes
                dt.PesquisarClienteId(GridCliente, int.Parse(txtIdPesq.Text), colunaId, colunaNome, colunaEmail, colunaCpf, colunaDataCad, colunaAtivo, colunaObs);

                // Atribuindo valores
                dt.IdCli = txtId.Text;
                dt.CpfCli = txtCpf.Text;
                dt.EmailCli = txtEmail.Text;
                dt.NomeCli = txtNome.Text;
                dt.AtivoCli = chkAtivo.Checked;
                dt.DatacadCli = txtDataCad.Text;
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
                // Consultando Cep
                CepController.ConsultarCep(txtCep.Text);

                // Atribuindo valores
                txtLogradouro.Text = CepController.Logradouro;
                txtEstado.Text = CepController.Estado;
                txtUf.Text = CepController.Uf;
                txtCidade.Text = CepController.Localidade;
                txtBairro.Text = CepController.Bairro;
                txtComplemento.Text = CepController.Complemento;
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
            // Controller
            EnderecoController endC = new EnderecoController();

            // Atribuindo valores
            endC.AdicionarEndereco(Convert.ToInt32(txtId.Text), txtLogradouro.Text, txtCep.Text, txtNumero.Text, txtCidade.Text, txtBairro.Text, txtEstado.Text, txtUf.Text, cmbTipo.Text, txtComplemento.Text);
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
            // Controller
            EnderecoController endC = new EnderecoController();

            endC.GridEndereco_DoubleClick(GridEndereco, e);

            // Atributos
            txtCep.Text = endC.CepCli.Trim();
            txtLogradouro.Text = endC.LogradouroCli;
            txtEstado.Text = endC.EstadoCli;
            txtUf.Text = endC.UfCli;
            txtCidade.Text = endC.CidadeCli;
            txtNumero.Text = endC.NumeroCli;
            txtBairro.Text = endC.BairroCli;
            txtComplemento.Text = endC.ComplementoCli;
            cmbTipo.Text = endC.TipoCli;
        }
    }
}