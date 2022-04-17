using ClassLabNu;
using System;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace ComercialSys.Formularios
{
    public partial class FormUsuario : MetroFramework.Forms.MetroForm
    {
        public FormUsuario(Form parent)
        {
            InitializeComponent();

            //MdiParent
            MdiParent = parent;

            // Listar usuarios
            ListarDataGrid();
        }

        // Liberar Campos -----------------------------------------------------------------------------------------------------------

        /// <summary>
        /// Metodo para liberar todos os campos
        /// </summary>
        private void LiberarCampos()
        {
            txtNome.Enabled = true;
            txtEmail.Enabled = true;
            txtSenha.Enabled = true;
            cmbNivel.Enabled = true;
            chkAtivo.Enabled = true;
        }

        /// <summary>
        /// Botao para liberar campos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBloqAbrt_Click(object sender, EventArgs e)
        {
            btnBloq.Visible = false;
            btnDesbloq.Visible = true;
            btnEditar.Enabled = false;
            btnInserir.Enabled = false;
            btnInserirImg.Enabled = false;
            BloquearCampos();
        }

        // Bloquear Campos -----------------------------------------------------------------------------------------------------------

        /// <summary>
        /// Metodo para bloquear campos
        /// </summary>
        private void BloquearCampos()
        {
            txtNome.Enabled = false;
            txtEmail.Enabled = false;
            txtSenha.Enabled = false;
            cmbNivel.Enabled = false;
            chkAtivo.Enabled = false;
        }

        /// <summary>
        /// Botao para bloquear campos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBloq_Click(object sender, EventArgs e)
        {
            btnDesbloq.Visible = false;
            btnBloq.Visible = true;
            btnEditar.Enabled = true;
            btnInserir.Enabled = true;
            btnInserirImg.Enabled = true;
            LiberarCampos();
        }

        // Form Load ---------------------------------------------------------------------------------------------------------------

        private void FormUsuario_Load(object sender, EventArgs e)
        {
        }

        // DataGrid Usuarios ---------------------------------------------------------------------------------------------------------------

        /// <summary>
        /// Listar DataGrid de usuarios
        /// </summary>
        private void ListarDataGrid()
        {
            // Limpar Grid
            GridUsuarios.Rows.Clear();

            // Novo objeto Usuario
            Usuario usuario = new Usuario();

            // Var para Listar usuario
            var lista = usuario.ListarUsuarios();

            // Listando usuarios no DataGrid
            lista.ForEach(i =>
            {
                // Linhas 
                GridUsuarios.Rows.Add();
                GridUsuarios.Rows[lista.IndexOf(i)].Cells[colunaId.Index].Value = i.Id; // Text -> ID
                GridUsuarios.Rows[lista.IndexOf(i)].Cells[colunaNome.Index].Value = i.Nome; // Text -> Nome
                GridUsuarios.Rows[lista.IndexOf(i)].Cells[colunaEmail.Index].Value = i.Email; // Text -> Email
                GridUsuarios.Rows[lista.IndexOf(i)].Cells[colunaSenhaInv.Index].Value = i.Password; // Text Invisivel -> Password
                GridUsuarios.Rows[lista.IndexOf(i)].Cells[colunaNivel.Index].Value = i.Nivel; // Text -> Nivel
                GridUsuarios.Rows[lista.IndexOf(i)].Cells[colunaAtivo.Index].Value = i.Ativo; // Checkbox -> Ativo

            });
            BloquearCampos();
        }

        /// <summary>
        /// Listar informações do Usuario nas TextBox quando o usuario clicar 2 vezes na linha do DataGrid
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GridUsuarios_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Variaveis para objeto Cliente
            Usuario u = new Usuario();

            // Valores para o objeto
            u.Id = Convert.ToInt32(GridUsuarios["colunaId", e.RowIndex].Value);
            u.Nome = Convert.ToString(GridUsuarios["colunaNome", e.RowIndex].Value);
            u.Email = Convert.ToString(GridUsuarios["colunaEmail", e.RowIndex].Value);
            u.Password = Convert.ToString(GridUsuarios["colunaSenhaInv", e.RowIndex].Value);
            u.Ativo = Convert.ToBoolean(GridUsuarios["colunaAtivo", e.RowIndex].Value);
            u.Nivel = Convert.ToString(GridUsuarios["colunaNivel", e.RowIndex].Value);

            // Atributos
            txtId.Text = u.Id.ToString();
            txtNome.Text = u.Nome;
            txtEmail.Text = u.Email;
            txtSenha.Text = u.Password;
            cmbNivel.Text = u.Nivel;
            chkAtivo.Checked = u.Ativo;
        }

        // Limpar Campos ---------------------------------------------------------------------------------------------------------------

        /// <summary>
        /// Metodo limpar todos campos
        /// </summary>
        private void LimparTodosCampos()
        {
            // Limpa campos
            txtId.Clear();
            txtNome.Clear();
            txtEmail.Clear();
            txtSenha.Clear();
        }

        // Inserir Usuarios ---------------------------------------------------------------------------------------------------------------

        /// <summary>
        /// Botao inserir Cliente
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnInserir_Click(object sender, EventArgs e)
        {
            byte[] imgByte;

            // Armazenar Bytes
            FileStream fstream = new FileStream(txtDir.Text, FileMode.Open, FileAccess.Read);

            // Leitura de bytes
            BinaryReader br = new BinaryReader(fstream);
            imgByte = br.ReadBytes((int)fstream.Length);

            // Objeto Usuario
            Usuario u = new Usuario(
                txtNome.Text,
                txtEmail.Text,
                txtSenha.Text,
                cmbNivel.Text,
                imgByte
                );

            u.Inserir();

            // Se ID for maior que 0
            if (u.Id > 0)
            {
                // Verificação se email é valido
                if (Validacao.EmailValido(txtEmail.Text))
                {
                    txtId.Text = u.Id.ToString();
                    MessageBox.Show($"Usuario {u.Id} inserido com sucesso", "SysComercial", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Atualizar DataGridView
                    ListarDataGrid();
                }
                else
                {
                    // Email Invalido
                    MessageBox.Show($"Email invalido do usuario {u.Id}", "SysComercial", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                // Falha ao inserir cliente
                MessageBox.Show("Falha ao inserir usuario", "SysComercial", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            BloquearCampos();


        }

        // Inserir imagem Clientes ---------------------------------------------------------------------------------------------------------------

        /// <summary>
        /// Botao inserir imagem Cliente
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnInserirImg_Click(object sender, EventArgs e)
        {
            // Instancia do File Dialog
            OpenFileDialog dialog = new OpenFileDialog();

            // Filtrar arquivos JPG / PNG / AllFiles
            dialog.Filter = "JPG Files(*.jpg)|*.jpg|PNG Files(*.png)|*.png|AllFiles(*.*)|*.*";

            // Se o resultado do dialog quando estiver aberto for igual a OK
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                // Variavel para pegar o diretorio da foto
                string diretorioFoto = dialog.FileName.ToString();

                // Salvando diretorio no TextBox
                txtDir.Text = diretorioFoto;

                // Salva foto na PictureBox
                picImg.ImageLocation = diretorioFoto;

            }
        }

        // Listar Usuarios ---------------------------------------------------------------------------------------------------------------

        /// <summary>
        /// Botao listar usuarios
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnListar_Click(object sender, EventArgs e)
        {
            // Listando Clientes
            ListarDataGrid();

        }

        // Editar Usuarios ---------------------------------------------------------------------------------------------------------------

        private void btnEditar_Click(object sender, EventArgs e)
        {
            // Objeto Cliente
            Usuario usuario = new Usuario();

            // Atributos do objeto
            usuario.Id = int.Parse(txtId.Text);
            usuario.Nome = txtNome.Text;
            usuario.Password = txtSenha.Text;
            usuario.Email = txtEmail.Text;
            usuario.Nivel = cmbNivel.Text;
            usuario.Ativo = chkAtivo.Checked;

            // Validação do email
            if (Validacao.EmailValido(txtEmail.Text))
            {
                // Condição se usuario deseja mesmo fazer a alteração
                if (MessageBox.Show("Você tem certeza que deseja alterar?", "SysComercial", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    // Condição
                    if (usuario.Alterar()) // Se cliente alterar for igual a TRUE
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
                        MessageBox.Show("Falha ao alterar o usuario!", "SysComercial", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                // Email Invalido
                MessageBox.Show($"Email do usuario {usuario.Id} invalido", "SysComercial", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            BloquearCampos();
        }

        // Pesquisar Usuarios ---------------------------------------------------------------------------------------------------------------

        /// <summary>
        /// Pesquisar usuario por nome
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtIdPesq_KeyUp(object sender, KeyEventArgs e)
        {
            // Abre conexao com banco
            var cmd = Banco.Abrir();

            // Comandos SQL
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"select * from usuarios where iduser = '{txtIdPesq.Text}'";

            try
            {
                // Var para leitura
                var meuReader = cmd.ExecuteReader();



                while (meuReader.Read())
                {

                    string nome = meuReader.GetString("nome");

                    txtNome.Text = nome.ToString();
                    byte[] imagem = (byte[])(meuReader["foto"]);


                    if ((imagem == null))
                    {
                        picImg.Image = null;
                    }
                    else
                    {
                        // Objeto responsavel por guardar quantidades de bytes na memoria
                        MemoryStream mstream = new MemoryStream(imagem);

                        // Colocar imagem que ta dentro do mstream
                        picImg.Image = System.Drawing.Image.FromStream(mstream);
                    }
                }

            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message.ToString());
            }
        }

        private void txtPesqNome_KeyUp(object sender, KeyEventArgs e)
        {
            // Verificando se o valor a pesquisar é vazio
            if (txtPesqNome.Text == "")
            {
            }
            else
            {
                // Objeto Cliente
                Usuario usuario = new Usuario();

                // Metodo Consulta por Nome
                usuario.ConsultarPorNome(Convert.ToString(txtPesqNome.Text));

                // Atributos
                txtId.Text = Convert.ToString(usuario.Id);
                txtNome.Text = usuario.Nome;
                txtEmail.Text = usuario.Email;
                txtSenha.Text = usuario.Password;
                cmbNivel.Text = usuario.Nivel;
                chkAtivo.Checked = usuario.Ativo;
            }

            // Limpando as TextBox de pesquisa
            txtIdPesq.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}