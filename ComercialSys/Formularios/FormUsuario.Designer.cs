namespace ComercialSys.Formularios
{
    partial class FormUsuario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUsuario));
            this.btnListar = new MetroFramework.Controls.MetroButton();
            this.btnEditar = new MetroFramework.Controls.MetroButton();
            this.gpBoxPesq = new System.Windows.Forms.GroupBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.txtPesqNome = new MetroFramework.Controls.MetroTextBox();
            this.lbIdPesq = new MetroFramework.Controls.MetroLabel();
            this.txtIdPesq = new MetroFramework.Controls.MetroTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.GridUsuarios = new System.Windows.Forms.DataGridView();
            this.colunaId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colunaNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colunaEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colunaSenha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colunaNivel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colunaAtivo = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnInserir = new MetroFramework.Controls.MetroButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chkAtivo = new System.Windows.Forms.CheckBox();
            this.btnBloq = new System.Windows.Forms.Button();
            this.btnDesbloq = new System.Windows.Forms.Button();
            this.cmbNivel = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.btnInserirImg = new MetroFramework.Controls.MetroButton();
            this.gpBoxImg = new System.Windows.Forms.GroupBox();
            this.picImg = new System.Windows.Forms.PictureBox();
            this.txtSenha = new MetroFramework.Controls.MetroTextBox();
            this.txtId = new MetroFramework.Controls.MetroTextBox();
            this.txtNome = new MetroFramework.Controls.MetroTextBox();
            this.txtEmail = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.FileDialogImg = new System.Windows.Forms.OpenFileDialog();
            this.txtDir = new MetroFramework.Controls.MetroTextBox();
            this.gpBoxPesq.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridUsuarios)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.gpBoxImg.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picImg)).BeginInit();
            this.SuspendLayout();
            // 
            // btnListar
            // 
            this.btnListar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnListar.Location = new System.Drawing.Point(829, 315);
            this.btnListar.Margin = new System.Windows.Forms.Padding(5);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(150, 40);
            this.btnListar.TabIndex = 28;
            this.btnListar.Text = "Listar";
            this.btnListar.UseSelectable = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditar.Enabled = false;
            this.btnEditar.Location = new System.Drawing.Point(471, 315);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(5);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(150, 40);
            this.btnEditar.TabIndex = 26;
            this.btnEditar.Text = "&Editar";
            this.btnEditar.UseSelectable = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // gpBoxPesq
            // 
            this.gpBoxPesq.Controls.Add(this.metroLabel5);
            this.gpBoxPesq.Controls.Add(this.txtPesqNome);
            this.gpBoxPesq.Controls.Add(this.lbIdPesq);
            this.gpBoxPesq.Controls.Add(this.txtIdPesq);
            this.gpBoxPesq.Location = new System.Drawing.Point(1078, 356);
            this.gpBoxPesq.Margin = new System.Windows.Forms.Padding(4);
            this.gpBoxPesq.Name = "gpBoxPesq";
            this.gpBoxPesq.Padding = new System.Windows.Forms.Padding(4);
            this.gpBoxPesq.Size = new System.Drawing.Size(184, 226);
            this.gpBoxPesq.TabIndex = 24;
            this.gpBoxPesq.TabStop = false;
            this.gpBoxPesq.Text = "Pesquisar";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(24, 126);
            this.metroLabel5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(48, 20);
            this.metroLabel5.TabIndex = 19;
            this.metroLabel5.Text = "Nome";
            // 
            // txtPesqNome
            // 
            // 
            // 
            // 
            this.txtPesqNome.CustomButton.Image = null;
            this.txtPesqNome.CustomButton.Location = new System.Drawing.Point(94, 1);
            this.txtPesqNome.CustomButton.Margin = new System.Windows.Forms.Padding(5);
            this.txtPesqNome.CustomButton.Name = "";
            this.txtPesqNome.CustomButton.Size = new System.Drawing.Size(29, 29);
            this.txtPesqNome.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPesqNome.CustomButton.TabIndex = 1;
            this.txtPesqNome.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPesqNome.CustomButton.UseSelectable = true;
            this.txtPesqNome.CustomButton.Visible = false;
            this.txtPesqNome.Lines = new string[0];
            this.txtPesqNome.Location = new System.Drawing.Point(24, 163);
            this.txtPesqNome.Margin = new System.Windows.Forms.Padding(5);
            this.txtPesqNome.MaxLength = 60;
            this.txtPesqNome.Name = "txtPesqNome";
            this.txtPesqNome.PasswordChar = '\0';
            this.txtPesqNome.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPesqNome.SelectedText = "";
            this.txtPesqNome.SelectionLength = 0;
            this.txtPesqNome.SelectionStart = 0;
            this.txtPesqNome.ShortcutsEnabled = true;
            this.txtPesqNome.Size = new System.Drawing.Size(124, 31);
            this.txtPesqNome.TabIndex = 18;
            this.txtPesqNome.UseSelectable = true;
            this.txtPesqNome.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPesqNome.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtPesqNome.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtPesqNome_KeyUp);
            // 
            // lbIdPesq
            // 
            this.lbIdPesq.AutoSize = true;
            this.lbIdPesq.Location = new System.Drawing.Point(24, 42);
            this.lbIdPesq.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbIdPesq.Name = "lbIdPesq";
            this.lbIdPesq.Size = new System.Drawing.Size(22, 20);
            this.lbIdPesq.TabIndex = 13;
            this.lbIdPesq.Text = "ID";
            // 
            // txtIdPesq
            // 
            // 
            // 
            // 
            this.txtIdPesq.CustomButton.Image = null;
            this.txtIdPesq.CustomButton.Location = new System.Drawing.Point(44, 1);
            this.txtIdPesq.CustomButton.Margin = new System.Windows.Forms.Padding(5);
            this.txtIdPesq.CustomButton.Name = "";
            this.txtIdPesq.CustomButton.Size = new System.Drawing.Size(29, 29);
            this.txtIdPesq.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtIdPesq.CustomButton.TabIndex = 1;
            this.txtIdPesq.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtIdPesq.CustomButton.UseSelectable = true;
            this.txtIdPesq.CustomButton.Visible = false;
            this.txtIdPesq.Lines = new string[0];
            this.txtIdPesq.Location = new System.Drawing.Point(24, 72);
            this.txtIdPesq.Margin = new System.Windows.Forms.Padding(5);
            this.txtIdPesq.MaxLength = 60;
            this.txtIdPesq.Name = "txtIdPesq";
            this.txtIdPesq.PasswordChar = '\0';
            this.txtIdPesq.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtIdPesq.SelectedText = "";
            this.txtIdPesq.SelectionLength = 0;
            this.txtIdPesq.SelectionStart = 0;
            this.txtIdPesq.ShortcutsEnabled = true;
            this.txtIdPesq.Size = new System.Drawing.Size(74, 31);
            this.txtIdPesq.TabIndex = 12;
            this.txtIdPesq.UseSelectable = true;
            this.txtIdPesq.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtIdPesq.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtIdPesq.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtIdPesq_KeyUp);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.GridUsuarios);
            this.groupBox1.Location = new System.Drawing.Point(29, 356);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1041, 344);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Usuarios";
            // 
            // GridUsuarios
            // 
            this.GridUsuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GridUsuarios.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.GridUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridUsuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colunaId,
            this.colunaNome,
            this.colunaEmail,
            this.colunaSenha,
            this.colunaNivel,
            this.colunaAtivo});
            this.GridUsuarios.GridColor = System.Drawing.Color.Black;
            this.GridUsuarios.Location = new System.Drawing.Point(9, 32);
            this.GridUsuarios.Margin = new System.Windows.Forms.Padding(4);
            this.GridUsuarios.Name = "GridUsuarios";
            this.GridUsuarios.ReadOnly = true;
            this.GridUsuarios.RowHeadersWidth = 51;
            this.GridUsuarios.Size = new System.Drawing.Size(1025, 304);
            this.GridUsuarios.TabIndex = 10;
            this.GridUsuarios.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridUsuarios_CellDoubleClick);
            // 
            // colunaId
            // 
            this.colunaId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colunaId.Frozen = true;
            this.colunaId.HeaderText = "Id";
            this.colunaId.MinimumWidth = 6;
            this.colunaId.Name = "colunaId";
            this.colunaId.ReadOnly = true;
            this.colunaId.Width = 128;
            // 
            // colunaNome
            // 
            this.colunaNome.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colunaNome.Frozen = true;
            this.colunaNome.HeaderText = "Nome";
            this.colunaNome.MinimumWidth = 6;
            this.colunaNome.Name = "colunaNome";
            this.colunaNome.ReadOnly = true;
            this.colunaNome.Width = 128;
            // 
            // colunaEmail
            // 
            this.colunaEmail.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colunaEmail.Frozen = true;
            this.colunaEmail.HeaderText = "Email";
            this.colunaEmail.MinimumWidth = 6;
            this.colunaEmail.Name = "colunaEmail";
            this.colunaEmail.ReadOnly = true;
            this.colunaEmail.Width = 127;
            // 
            // colunaSenha
            // 
            this.colunaSenha.HeaderText = "Senha";
            this.colunaSenha.MinimumWidth = 6;
            this.colunaSenha.Name = "colunaSenha";
            this.colunaSenha.ReadOnly = true;
            // 
            // colunaNivel
            // 
            this.colunaNivel.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colunaNivel.HeaderText = "Nivel";
            this.colunaNivel.MinimumWidth = 6;
            this.colunaNivel.Name = "colunaNivel";
            this.colunaNivel.ReadOnly = true;
            this.colunaNivel.Width = 128;
            // 
            // colunaAtivo
            // 
            this.colunaAtivo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colunaAtivo.HeaderText = "Ativo";
            this.colunaAtivo.MinimumWidth = 6;
            this.colunaAtivo.Name = "colunaAtivo";
            this.colunaAtivo.ReadOnly = true;
            this.colunaAtivo.Width = 128;
            // 
            // btnInserir
            // 
            this.btnInserir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInserir.Enabled = false;
            this.btnInserir.Location = new System.Drawing.Point(650, 315);
            this.btnInserir.Margin = new System.Windows.Forms.Padding(5);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(150, 40);
            this.btnInserir.TabIndex = 23;
            this.btnInserir.Text = "&Inserir";
            this.btnInserir.UseSelectable = true;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtDir);
            this.groupBox2.Controls.Add(this.chkAtivo);
            this.groupBox2.Controls.Add(this.btnBloq);
            this.groupBox2.Controls.Add(this.btnDesbloq);
            this.groupBox2.Controls.Add(this.cmbNivel);
            this.groupBox2.Controls.Add(this.metroLabel6);
            this.groupBox2.Controls.Add(this.btnInserirImg);
            this.groupBox2.Controls.Add(this.gpBoxImg);
            this.groupBox2.Controls.Add(this.txtSenha);
            this.groupBox2.Controls.Add(this.txtId);
            this.groupBox2.Controls.Add(this.txtNome);
            this.groupBox2.Controls.Add(this.txtEmail);
            this.groupBox2.Controls.Add(this.metroLabel1);
            this.groupBox2.Controls.Add(this.metroLabel4);
            this.groupBox2.Controls.Add(this.metroLabel2);
            this.groupBox2.Controls.Add(this.metroLabel3);
            this.groupBox2.Location = new System.Drawing.Point(29, 63);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(1232, 243);
            this.groupBox2.TabIndex = 25;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cadastrar";
            // 
            // chkAtivo
            // 
            this.chkAtivo.AutoSize = true;
            this.chkAtivo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkAtivo.Enabled = false;
            this.chkAtivo.Location = new System.Drawing.Point(610, 64);
            this.chkAtivo.Margin = new System.Windows.Forms.Padding(5);
            this.chkAtivo.Name = "chkAtivo";
            this.chkAtivo.Size = new System.Drawing.Size(77, 25);
            this.chkAtivo.TabIndex = 22;
            this.chkAtivo.Text = "Ativo";
            this.chkAtivo.UseVisualStyleBackColor = true;
            // 
            // btnBloq
            // 
            this.btnBloq.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBloq.BackgroundImage")));
            this.btnBloq.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBloq.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBloq.FlatAppearance.BorderSize = 0;
            this.btnBloq.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBloq.Location = new System.Drawing.Point(800, 173);
            this.btnBloq.Margin = new System.Windows.Forms.Padding(4);
            this.btnBloq.Name = "btnBloq";
            this.btnBloq.Size = new System.Drawing.Size(48, 52);
            this.btnBloq.TabIndex = 21;
            this.btnBloq.UseVisualStyleBackColor = true;
            this.btnBloq.Visible = false;
            this.btnBloq.Click += new System.EventHandler(this.btnBloqAbrt_Click);
            // 
            // btnDesbloq
            // 
            this.btnDesbloq.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDesbloq.BackgroundImage")));
            this.btnDesbloq.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDesbloq.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDesbloq.FlatAppearance.BorderSize = 0;
            this.btnDesbloq.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDesbloq.Location = new System.Drawing.Point(800, 173);
            this.btnDesbloq.Margin = new System.Windows.Forms.Padding(4);
            this.btnDesbloq.Name = "btnDesbloq";
            this.btnDesbloq.Size = new System.Drawing.Size(48, 52);
            this.btnDesbloq.TabIndex = 20;
            this.btnDesbloq.UseVisualStyleBackColor = true;
            this.btnDesbloq.Click += new System.EventHandler(this.btnBloq_Click);
            // 
            // cmbNivel
            // 
            this.cmbNivel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbNivel.Enabled = false;
            this.cmbNivel.FormattingEnabled = true;
            this.cmbNivel.ItemHeight = 24;
            this.cmbNivel.Items.AddRange(new object[] {
            "Caixa",
            "Vendedor",
            "Gerente"});
            this.cmbNivel.Location = new System.Drawing.Point(609, 141);
            this.cmbNivel.Margin = new System.Windows.Forms.Padding(4);
            this.cmbNivel.Name = "cmbNivel";
            this.cmbNivel.Size = new System.Drawing.Size(150, 30);
            this.cmbNivel.TabIndex = 19;
            this.cmbNivel.UseSelectable = true;
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel6.Location = new System.Drawing.Point(609, 112);
            this.metroLabel6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(43, 20);
            this.metroLabel6.TabIndex = 18;
            this.metroLabel6.Text = "Nivel";
            // 
            // btnInserirImg
            // 
            this.btnInserirImg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInserirImg.Location = new System.Drawing.Point(900, 206);
            this.btnInserirImg.Margin = new System.Windows.Forms.Padding(5);
            this.btnInserirImg.Name = "btnInserirImg";
            this.btnInserirImg.Size = new System.Drawing.Size(184, 28);
            this.btnInserirImg.TabIndex = 16;
            this.btnInserirImg.Text = "Inserir Imagem";
            this.btnInserirImg.UseSelectable = true;
            this.btnInserirImg.Click += new System.EventHandler(this.btnInserirImg_Click);
            // 
            // gpBoxImg
            // 
            this.gpBoxImg.Controls.Add(this.picImg);
            this.gpBoxImg.Location = new System.Drawing.Point(900, 15);
            this.gpBoxImg.Margin = new System.Windows.Forms.Padding(4);
            this.gpBoxImg.Name = "gpBoxImg";
            this.gpBoxImg.Padding = new System.Windows.Forms.Padding(4);
            this.gpBoxImg.Size = new System.Drawing.Size(184, 163);
            this.gpBoxImg.TabIndex = 16;
            this.gpBoxImg.TabStop = false;
            this.gpBoxImg.Text = "Imagem";
            // 
            // picImg
            // 
            this.picImg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picImg.InitialImage = ((System.Drawing.Image)(resources.GetObject("picImg.InitialImage")));
            this.picImg.Location = new System.Drawing.Point(8, 32);
            this.picImg.Margin = new System.Windows.Forms.Padding(4);
            this.picImg.Name = "picImg";
            this.picImg.Size = new System.Drawing.Size(169, 124);
            this.picImg.TabIndex = 18;
            this.picImg.TabStop = false;
            // 
            // txtSenha
            // 
            // 
            // 
            // 
            this.txtSenha.CustomButton.Image = null;
            this.txtSenha.CustomButton.Location = new System.Drawing.Point(165, 1);
            this.txtSenha.CustomButton.Margin = new System.Windows.Forms.Padding(5);
            this.txtSenha.CustomButton.Name = "";
            this.txtSenha.CustomButton.Size = new System.Drawing.Size(29, 29);
            this.txtSenha.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSenha.CustomButton.TabIndex = 1;
            this.txtSenha.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSenha.CustomButton.UseSelectable = true;
            this.txtSenha.CustomButton.Visible = false;
            this.txtSenha.Enabled = false;
            this.txtSenha.Lines = new string[0];
            this.txtSenha.Location = new System.Drawing.Point(372, 147);
            this.txtSenha.Margin = new System.Windows.Forms.Padding(5);
            this.txtSenha.MaxLength = 12;
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSenha.SelectedText = "";
            this.txtSenha.SelectionLength = 0;
            this.txtSenha.SelectionStart = 0;
            this.txtSenha.ShortcutsEnabled = true;
            this.txtSenha.Size = new System.Drawing.Size(195, 31);
            this.txtSenha.TabIndex = 2;
            this.txtSenha.UseSelectable = true;
            this.txtSenha.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSenha.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtId
            // 
            // 
            // 
            // 
            this.txtId.CustomButton.Image = null;
            this.txtId.CustomButton.Location = new System.Drawing.Point(52, 1);
            this.txtId.CustomButton.Margin = new System.Windows.Forms.Padding(5);
            this.txtId.CustomButton.Name = "";
            this.txtId.CustomButton.Size = new System.Drawing.Size(29, 29);
            this.txtId.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtId.CustomButton.TabIndex = 1;
            this.txtId.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtId.CustomButton.UseSelectable = true;
            this.txtId.CustomButton.Visible = false;
            this.txtId.Enabled = false;
            this.txtId.Lines = new string[0];
            this.txtId.Location = new System.Drawing.Point(9, 68);
            this.txtId.Margin = new System.Windows.Forms.Padding(5);
            this.txtId.MaxLength = 32767;
            this.txtId.Name = "txtId";
            this.txtId.PasswordChar = '\0';
            this.txtId.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtId.SelectedText = "";
            this.txtId.SelectionLength = 0;
            this.txtId.SelectionStart = 0;
            this.txtId.ShortcutsEnabled = true;
            this.txtId.Size = new System.Drawing.Size(82, 31);
            this.txtId.TabIndex = 1;
            this.txtId.UseSelectable = true;
            this.txtId.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtId.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtNome
            // 
            // 
            // 
            // 
            this.txtNome.CustomButton.Image = null;
            this.txtNome.CustomButton.Location = new System.Drawing.Point(401, 1);
            this.txtNome.CustomButton.Margin = new System.Windows.Forms.Padding(5);
            this.txtNome.CustomButton.Name = "";
            this.txtNome.CustomButton.Size = new System.Drawing.Size(29, 29);
            this.txtNome.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNome.CustomButton.TabIndex = 1;
            this.txtNome.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNome.CustomButton.UseSelectable = true;
            this.txtNome.CustomButton.Visible = false;
            this.txtNome.Enabled = false;
            this.txtNome.Lines = new string[0];
            this.txtNome.Location = new System.Drawing.Point(135, 68);
            this.txtNome.Margin = new System.Windows.Forms.Padding(5);
            this.txtNome.MaxLength = 60;
            this.txtNome.Name = "txtNome";
            this.txtNome.PasswordChar = '\0';
            this.txtNome.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNome.SelectedText = "";
            this.txtNome.SelectionLength = 0;
            this.txtNome.SelectionStart = 0;
            this.txtNome.ShortcutsEnabled = true;
            this.txtNome.Size = new System.Drawing.Size(431, 31);
            this.txtNome.TabIndex = 1;
            this.txtNome.UseSelectable = true;
            this.txtNome.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNome.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtEmail
            // 
            // 
            // 
            // 
            this.txtEmail.CustomButton.Image = null;
            this.txtEmail.CustomButton.Location = new System.Drawing.Point(301, 1);
            this.txtEmail.CustomButton.Margin = new System.Windows.Forms.Padding(5);
            this.txtEmail.CustomButton.Name = "";
            this.txtEmail.CustomButton.Size = new System.Drawing.Size(29, 29);
            this.txtEmail.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtEmail.CustomButton.TabIndex = 1;
            this.txtEmail.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtEmail.CustomButton.UseSelectable = true;
            this.txtEmail.CustomButton.Visible = false;
            this.txtEmail.Enabled = false;
            this.txtEmail.Lines = new string[0];
            this.txtEmail.Location = new System.Drawing.Point(9, 147);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(5);
            this.txtEmail.MaxLength = 60;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PasswordChar = '\0';
            this.txtEmail.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtEmail.SelectedText = "";
            this.txtEmail.SelectionLength = 0;
            this.txtEmail.SelectionStart = 0;
            this.txtEmail.ShortcutsEnabled = true;
            this.txtEmail.Size = new System.Drawing.Size(331, 31);
            this.txtEmail.TabIndex = 3;
            this.txtEmail.UseSelectable = true;
            this.txtEmail.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtEmail.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.Location = new System.Drawing.Point(9, 38);
            this.metroLabel1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(24, 20);
            this.metroLabel1.TabIndex = 4;
            this.metroLabel1.Text = "ID";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel4.Location = new System.Drawing.Point(9, 117);
            this.metroLabel4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(46, 20);
            this.metroLabel4.TabIndex = 7;
            this.metroLabel4.Text = "Email";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel2.Location = new System.Drawing.Point(135, 38);
            this.metroLabel2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(50, 20);
            this.metroLabel2.TabIndex = 5;
            this.metroLabel2.Text = "Nome";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel3.Location = new System.Drawing.Point(371, 117);
            this.metroLabel3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(49, 20);
            this.metroLabel3.TabIndex = 6;
            this.metroLabel3.Text = "Senha";
            // 
            // FileDialogImg
            // 
            this.FileDialogImg.FileName = "Imagem";
            // 
            // txtDir
            // 
            // 
            // 
            // 
            this.txtDir.CustomButton.Image = null;
            this.txtDir.CustomButton.Location = new System.Drawing.Point(166, 1);
            this.txtDir.CustomButton.Margin = new System.Windows.Forms.Padding(5);
            this.txtDir.CustomButton.Name = "";
            this.txtDir.CustomButton.Size = new System.Drawing.Size(17, 17);
            this.txtDir.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDir.CustomButton.TabIndex = 1;
            this.txtDir.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDir.CustomButton.UseSelectable = true;
            this.txtDir.CustomButton.Visible = false;
            this.txtDir.Enabled = false;
            this.txtDir.Lines = new string[0];
            this.txtDir.Location = new System.Drawing.Point(900, 180);
            this.txtDir.Margin = new System.Windows.Forms.Padding(5);
            this.txtDir.MaxLength = 60;
            this.txtDir.Multiline = true;
            this.txtDir.Name = "txtDir";
            this.txtDir.PasswordChar = '\0';
            this.txtDir.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDir.SelectedText = "";
            this.txtDir.SelectionLength = 0;
            this.txtDir.SelectionStart = 0;
            this.txtDir.ShortcutsEnabled = true;
            this.txtDir.Size = new System.Drawing.Size(184, 19);
            this.txtDir.TabIndex = 20;
            this.txtDir.UseSelectable = true;
            this.txtDir.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDir.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // FormUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1286, 708);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.gpBoxPesq);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnInserir);
            this.Controls.Add(this.groupBox2);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormUsuario";
            this.Padding = new System.Windows.Forms.Padding(25, 79, 25, 26);
            this.Text = "Usuario";
            this.Load += new System.EventHandler(this.FormUsuario_Load);
            this.gpBoxPesq.ResumeLayout(false);
            this.gpBoxPesq.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridUsuarios)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.gpBoxImg.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picImg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton btnListar;
        private MetroFramework.Controls.MetroButton btnEditar;
        private System.Windows.Forms.GroupBox gpBoxPesq;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroTextBox txtPesqNome;
        private MetroFramework.Controls.MetroLabel lbIdPesq;
        private MetroFramework.Controls.MetroTextBox txtIdPesq;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView GridUsuarios;
        private MetroFramework.Controls.MetroButton btnInserir;
        private System.Windows.Forms.GroupBox groupBox2;
        private MetroFramework.Controls.MetroButton btnInserirImg;
        private System.Windows.Forms.GroupBox gpBoxImg;
        private System.Windows.Forms.PictureBox picImg;
        private MetroFramework.Controls.MetroTextBox txtSenha;
        private MetroFramework.Controls.MetroTextBox txtId;
        private MetroFramework.Controls.MetroTextBox txtNome;
        private MetroFramework.Controls.MetroTextBox txtEmail;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroComboBox cmbNivel;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private System.Windows.Forms.DataGridViewTextBoxColumn colunaId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colunaNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn colunaEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn colunaSenha;
        private System.Windows.Forms.DataGridViewTextBoxColumn colunaNivel;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colunaAtivo;
        private System.Windows.Forms.OpenFileDialog FileDialogImg;
        private System.Windows.Forms.Button btnDesbloq;
        private System.Windows.Forms.Button btnBloq;
        private System.Windows.Forms.CheckBox chkAtivo;
        private MetroFramework.Controls.MetroTextBox txtDir;
    }
}