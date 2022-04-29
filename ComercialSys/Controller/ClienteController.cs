using ComercialSys.Model;
using System;
using System.Windows.Forms;

namespace ComercialSys.Controller
{
    public class ClienteController : ClienteModel
    {
        /// <summary>
        /// Metodo para Listar clientes
        /// </summary>
        /// <param name="dt">DataGridView</param>
        /// <param name="clnId">ColunaTextBox</param>
        /// <param name="ClnNome">ColunaTextBox</param>
        /// <param name="ClnEmail">ColunaTextBox</param>
        /// <param name="ClnCpf">ColunaTextBox</param>
        /// <param name="ClnDataCad">ColunaTextBox</param>
        /// <param name="clnAtivo">ColunaCheckBox</param>
        /// <param name="ClnObs">ColunaTextBox</param>
        public static void ListarCliente
            (
            DataGridView dt,
            DataGridViewTextBoxColumn clnId,
            DataGridViewTextBoxColumn ClnNome,
            DataGridViewTextBoxColumn ClnEmail,
            DataGridViewTextBoxColumn ClnCpf,
            DataGridViewTextBoxColumn ClnDataCad,
            DataGridViewCheckBoxColumn clnAtivo,
            DataGridViewTextBoxColumn ClnObs
            )
        {
            // Limpar Grid
            dt.Rows.Clear();

            // Var para Listar clientes
            var lista = ListarClientes();

            // Listando clientes no DataGrid
            lista.ForEach(i =>
            {
                // Linhas 
                dt.Rows.Add();
                dt.Rows[lista.IndexOf(i)].Cells[clnId.Index].Value = i.Id; // Text -> ID
                dt.Rows[lista.IndexOf(i)].Cells[ClnNome.Index].Value = i.Nome; // Text -> Nome
                dt.Rows[lista.IndexOf(i)].Cells[ClnEmail.Index].Value = i.Email; // Text -> Email
                dt.Rows[lista.IndexOf(i)].Cells[ClnCpf.Index].Value = i.Cpf; // Text -> CPF
                dt.Rows[lista.IndexOf(i)].Cells[ClnDataCad.Index].Value = i.dataCad; // Text -> DataCad
                dt.Rows[lista.IndexOf(i)].Cells[clnAtivo.Index].Value = i.Ativo; // Checkbox -> Ativo
                dt.Rows[lista.IndexOf(i)].Cells[ClnObs.Index].Value = i.Obs; // Text -> Observações
            });
        }

        /// <summary>
        /// Metodo privado para atribuir valores para as propriedades
        /// </summary>
        /// <param name="cli">Cliente</param>
        private void PreencherPropriedades(ClienteModel cli)
        {
            Id = cli.Id;
            Nome = cli.Nome;
            dataCad = cli.dataCad;
            Email = cli.Email;
            Cpf = cli.Cpf;
            Ativo = cli.Ativo;
            Obs = cli.Obs;
        }

        /// <summary>
        /// metodo privado quando for feita uma ação de double click no DataGridView
        /// </summary>
        /// <param name="dt"></param>
        /// <param name="e"></param>
        public void GridCliente_DoubleClick
        (
        DataGridView dt,
        DataGridViewCellEventArgs e
        )
        {
            ClienteModel cli = new ClienteModel();

            cli.Id = Convert.ToInt32(dt[$"colunaId", e.RowIndex].Value);
            cli.Nome = Convert.ToString(dt[$"colunaNome", e.RowIndex].Value);
            cli.Email = Convert.ToString(dt[$"colunaEmail", e.RowIndex].Value);
            cli.Cpf = Convert.ToString(dt[$"colunaCpf", e.RowIndex].Value);
            cli.dataCad = Convert.ToString(dt[$"colunaDataCad", e.RowIndex].Value);
            cli.Ativo = Convert.ToBoolean(dt[$"colunaAtivo", e.RowIndex].Value);
            cli.Obs = Convert.ToString(dt[$"colunaObs", e.RowIndex].Value);

            Id = cli.Id;
            Nome = cli.Nome;
            Email = cli.Email;
            Cpf = cli.Cpf;
            dataCad = cli.dataCad;
            Ativo = cli.Ativo;
            Obs = cli.Obs;

        }

        /// <summary>
        /// Metodo para pesquiar clientes por CPF
        /// </summary>
        /// <param name="dt">DataGridView</param>
        /// <param name="_cpf">string</param>
        /// <param name="clnId">ColunaTextBox</param>
        /// <param name="ClnNome">ColunaTextBox</param>
        /// <param name="ClnEmail">ColunaTextBox</param>
        /// <param name="ClnCpf">ColunaTextBox</param>
        /// <param name="ClnDataCad">ColunaTextBox</param>
        /// <param name="clnAtivo">ColunaCheckBox</param>
        /// <param name="ClnObs">ColunaTextBox</param>
        public void PesquisarClienteCpf
        (
        DataGridView dt,
        string _cpf,
        DataGridViewTextBoxColumn clnId,
        DataGridViewTextBoxColumn ClnNome,
        DataGridViewTextBoxColumn ClnEmail,
        DataGridViewTextBoxColumn ClnCpf,
        DataGridViewTextBoxColumn ClnDataCad,
        DataGridViewCheckBoxColumn clnAtivo,
        DataGridViewTextBoxColumn ClnObs
            )
        {
            ClienteModel cli = new ClienteModel();

            // Limpar Grid
            dt.Rows.Clear();

            // Var para Listar clientes
            var lista = ListarPorCpf(_cpf);

            // Listando clientes no DataGrid
            lista.ForEach(i =>
            {
                // Linhas 
                dt.Rows.Add();
                dt.Rows[lista.IndexOf(i)].Cells[clnId.Index].Value = i.Id; // Text -> ID
                dt.Rows[lista.IndexOf(i)].Cells[ClnNome.Index].Value = i.Nome; // Text -> Nome
                dt.Rows[lista.IndexOf(i)].Cells[ClnEmail.Index].Value = i.Email; // Text -> Email
                dt.Rows[lista.IndexOf(i)].Cells[ClnCpf.Index].Value = i.Cpf; // Text -> CPF
                dt.Rows[lista.IndexOf(i)].Cells[ClnDataCad.Index].Value = i.dataCad; // Text -> DataCad
                dt.Rows[lista.IndexOf(i)].Cells[clnAtivo.Index].Value = i.Ativo; // Checkbox -> Ativo
                dt.Rows[lista.IndexOf(i)].Cells[ClnObs.Index].Value = i.Obs; // Text -> Observações

                PreencherPropriedades(cli);

            });
        }


        /// <summary>
        /// Metodo para pesquiar clientes por ID
        /// </summary>
        /// <param name="dt">DataGridView</param>
        /// <param name="_id">int</param>
        /// <param name="cli">ColunaTextBox</param>
        /// <param name="clnId">ColunaTextBox</param>
        /// <param name="ClnNome">ColunaTextBox</param>
        /// <param name="ClnEmail">ColunaTextBox</param>
        /// <param name="ClnCpf">ColunaTextBox</param>
        /// <param name="ClnDataCad">ColunaTextBox</param>
        /// <param name="clnAtivo">ColunaCheckBox</param>
        /// <param name="ClnObs">ColunaTextBox</param>
        public void PesquisarClienteId
        (
        DataGridView dt,
        int _id,
        DataGridViewTextBoxColumn clnId,
        DataGridViewTextBoxColumn ClnNome,
        DataGridViewTextBoxColumn ClnEmail,
        DataGridViewTextBoxColumn ClnCpf,
        DataGridViewTextBoxColumn ClnDataCad,
        DataGridViewCheckBoxColumn clnAtivo,
        DataGridViewTextBoxColumn ClnObs
            )
        {
            ClienteModel cli = new ClienteModel();

            // Limpar Grid
            dt.Rows.Clear();

            // Var para Listar clientes
            var lista = ListarPorId(_id);

            // Listando clientes no DataGrid
            lista.ForEach(i =>
            {
                // Linhas 
                dt.Rows.Add();
                dt.Rows[lista.IndexOf(i)].Cells[clnId.Index].Value = i.Id; // Text -> ID
                dt.Rows[lista.IndexOf(i)].Cells[ClnNome.Index].Value = i.Nome; // Text -> Nome
                dt.Rows[lista.IndexOf(i)].Cells[ClnEmail.Index].Value = i.Email; // Text -> Email
                dt.Rows[lista.IndexOf(i)].Cells[ClnCpf.Index].Value = i.Cpf; // Text -> CPF
                dt.Rows[lista.IndexOf(i)].Cells[ClnDataCad.Index].Value = i.dataCad; // Text -> DataCad
                dt.Rows[lista.IndexOf(i)].Cells[clnAtivo.Index].Value = i.Ativo; // Checkbox -> Ativo
                dt.Rows[lista.IndexOf(i)].Cells[ClnObs.Index].Value = i.Obs; // Text -> Observações

                PreencherPropriedades(cli);

            });
        }

        /// <summary>
        /// Metodo para pesquiar clientes por ID
        /// </summary>
        /// <param name="dt">DataGridView</param>
        /// <param name="_nome">string</param>
        /// <param name="cli">ColunaTextBox</param>
        /// <param name="clnId">ColunaTextBox</param>
        /// <param name="ClnNome">ColunaTextBox</param>
        /// <param name="ClnEmail">ColunaTextBox</param>
        /// <param name="ClnCpf">ColunaTextBox</param>
        /// <param name="ClnDataCad">ColunaTextBox</param>
        /// <param name="clnAtivo">ColunaCheckBox</param>
        /// <param name="ClnObs">ColunaTextBox</param>
        public void PesquisarClienteNome
        (
        DataGridView dt,
        string _nome,
        DataGridViewTextBoxColumn clnId,
        DataGridViewTextBoxColumn ClnNome,
        DataGridViewTextBoxColumn ClnEmail,
        DataGridViewTextBoxColumn ClnCpf,
        DataGridViewTextBoxColumn ClnDataCad,
        DataGridViewCheckBoxColumn clnAtivo,
        DataGridViewTextBoxColumn ClnObs
            )
        {
            ClienteModel cli = new ClienteModel();

            // Limpar Grid
            dt.Rows.Clear();

            // Var para Listar clientes
            var lista = ListarPorNome(_nome);

            // Listando clientes no DataGrid
            lista.ForEach(i =>
            {
                // Linhas 
                dt.Rows.Add();
                dt.Rows[lista.IndexOf(i)].Cells[clnId.Index].Value = i.Id; // Text -> ID
                dt.Rows[lista.IndexOf(i)].Cells[ClnNome.Index].Value = i.Nome; // Text -> Nome
                dt.Rows[lista.IndexOf(i)].Cells[ClnEmail.Index].Value = i.Email; // Text -> Email
                dt.Rows[lista.IndexOf(i)].Cells[ClnCpf.Index].Value = i.Cpf; // Text -> CPF
                dt.Rows[lista.IndexOf(i)].Cells[ClnDataCad.Index].Value = i.dataCad; // Text -> DataCad
                dt.Rows[lista.IndexOf(i)].Cells[clnAtivo.Index].Value = i.Ativo; // Checkbox -> Ativo
                dt.Rows[lista.IndexOf(i)].Cells[ClnObs.Index].Value = i.Obs; // Text -> Observações

                PreencherPropriedades(cli);

            });
        }

        /// <summary>
        /// Metodo para inserir cliente
        /// </summary>
        /// <param name="_id">Int</param>
        /// <param name="_nome">String</param>
        /// <param name="_cpf">String</param>
        /// <param name="_email">String</param>
        /// <param name="_obs">String</param>
        public void InserirCliente(int _id, string _nome, string _cpf, string _email, string _obs)
        {
            // Objeto Cliente
            Id = _id;
            Nome = _nome;
            Cpf = _cpf;
            Email = _email;
            Obs = _obs;

            // Inserindo Cliente
            Inserir();

            // Se ID for maior que 0
            if (Id > 0)
            {
                // Verificação se email é valido
                if (ValidacaoController.EmailValido(_email))
                {
                    MessageBox.Show($"Cliente {Id} inserido com sucesso", "SysComercial", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    // Email Invalido
                    MessageBox.Show($"Email invalido", "SysComercial", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                // Falha ao inserir cliente
                MessageBox.Show("Falha ao inserir cliente", "SysComercial", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            

        }

        /// <summary>
        /// Metodo para editar cliente
        /// </summary>
        /// <param name="_id">Int</param>
        /// <param name="_nome">String</param>
        /// <param name="_cpf">String</param>
        /// <param name="_email">String</param>
        /// <param name="_ativo">Boolean</param>
        /// <param name="_obs">String</param>
        public  void EditarCliente(int _id, string _nome, string _cpf, string _email, bool _ativo, string _obs)
        {
            // Atributos do objeto
            Id = _id;
            Nome = _nome;
            Cpf = _cpf;
            Email = _email;
            Ativo = _ativo;
            Obs = _obs;

            // Validação do email
            if (ValidacaoController.EmailValido(_email))
            {
                // Condição se usuario deseja mesmo fazer a alteração
                if (MessageBox.Show("Você tem certeza que deseja alterar?", "SysComercial", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    // Condição
                    if (Alterar()) // Se cliente alterar for igual a TRUE
                    {
                        // Mensagem Box
                        MessageBox.Show("Cliente alterado com sucesso!", "SysComercial", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                MessageBox.Show($"Email invalido", "SysComercial", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        public static void ListClienteBox(ComboBox cmb)
        {
            // Listando Clientes ComboBox
            cmb.DataSource = ClienteModel.ListarClientes().ToArray();
            cmb.DisplayMember = "Nome";
            cmb.ValueMember = "Id";

            // Tipo de DropDown
            cmb.DropDownStyle = ComboBoxStyle.DropDownList;
        }
    }
}
