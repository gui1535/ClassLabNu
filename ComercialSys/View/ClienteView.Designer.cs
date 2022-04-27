using ComercialSys.Controller;
namespace ComercialSys.View
{
    partial class ClienteView
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtId = new MetroFramework.Controls.MetroTextBox();
            this.txtNome = new MetroFramework.Controls.MetroTextBox();
            this.txtCpf = new MetroFramework.Controls.MetroTextBox();
            this.txtEmail = new MetroFramework.Controls.MetroTextBox();
            this.GridCliente = new System.Windows.Forms.DataGridView();
            this.colunaId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colunaObs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colunaNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colunaCpf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colunaEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colunaDataCad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colunaAtivo = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnLimparCampos = new MetroFramework.Controls.MetroButton();
            this.txtObs = new MetroFramework.Controls.MetroTextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.chkAtivo = new System.Windows.Forms.CheckBox();
            this.txtDataCad = new MetroFramework.Controls.MetroDateTime();
            this.btnDesbloquear = new System.Windows.Forms.Button();
            this.btnBloquear = new System.Windows.Forms.Button();
            this.txtIdPesq = new MetroFramework.Controls.MetroTextBox();
            this.txtCpfPsq = new MetroFramework.Controls.MetroTextBox();
            this.gpBoxPesq = new System.Windows.Forms.GroupBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtPesqNome = new MetroFramework.Controls.MetroTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gpboxEnderecos = new System.Windows.Forms.GroupBox();
            this.lbUf = new System.Windows.Forms.Label();
            this.txtUf = new MetroFramework.Controls.MetroTextBox();
            this.btnCancelCep = new System.Windows.Forms.Button();
            this.btnAddCep = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbTipo = new MetroFramework.Controls.MetroComboBox();
            this.txtComplemento = new MetroFramework.Controls.MetroTextBox();
            this.txtBairro = new MetroFramework.Controls.MetroTextBox();
            this.txtEstado = new MetroFramework.Controls.MetroTextBox();
            this.txtCidade = new MetroFramework.Controls.MetroTextBox();
            this.txtLogradouro = new MetroFramework.Controls.MetroTextBox();
            this.txtNumero = new MetroFramework.Controls.MetroTextBox();
            this.txtCep = new MetroFramework.Controls.MetroTextBox();
            this.gpboxNumeros = new System.Windows.Forms.GroupBox();
            this.metroComboBox4 = new MetroFramework.Controls.MetroComboBox();
            this.maskedTextBox4 = new System.Windows.Forms.MaskedTextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.metroComboBox2 = new MetroFramework.Controls.MetroComboBox();
            this.maskedTextBox3 = new System.Windows.Forms.MaskedTextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.metroComboBox1 = new MetroFramework.Controls.MetroComboBox();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.metroComboBox3 = new MetroFramework.Controls.MetroComboBox();
            this.maskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.btnInserir = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnListar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.GridEndereco = new System.Windows.Forms.DataGridView();
            this.colunaCep = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colunaCidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colunaLogradouro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colunaNumero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colunaComplemento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colunaEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colunaTipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colunaBairro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.GridCliente)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.gpBoxPesq.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gpboxEnderecos.SuspendLayout();
            this.gpboxNumeros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridEndereco)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtId
            // 
            // 
            // 
            // 
            this.txtId.CustomButton.Image = null;
            this.txtId.CustomButton.Location = new System.Drawing.Point(46, 2);
            this.txtId.CustomButton.Margin = new System.Windows.Forms.Padding(4);
            this.txtId.CustomButton.Name = "";
            this.txtId.CustomButton.Size = new System.Drawing.Size(19, 19);
            this.txtId.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtId.CustomButton.TabIndex = 1;
            this.txtId.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtId.CustomButton.UseSelectable = true;
            this.txtId.CustomButton.Visible = false;
            this.txtId.Enabled = false;
            this.txtId.Lines = new string[] {
        "0"};
            this.txtId.Location = new System.Drawing.Point(24, 45);
            this.txtId.Margin = new System.Windows.Forms.Padding(4);
            this.txtId.MaxLength = 32767;
            this.txtId.Name = "txtId";
            this.txtId.PasswordChar = '\0';
            this.txtId.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtId.SelectedText = "";
            this.txtId.SelectionLength = 0;
            this.txtId.SelectionStart = 0;
            this.txtId.ShortcutsEnabled = true;
            this.txtId.Size = new System.Drawing.Size(68, 24);
            this.txtId.TabIndex = 1;
            this.txtId.Text = "0";
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
            this.txtNome.CustomButton.Location = new System.Drawing.Point(266, 2);
            this.txtNome.CustomButton.Margin = new System.Windows.Forms.Padding(4);
            this.txtNome.CustomButton.Name = "";
            this.txtNome.CustomButton.Size = new System.Drawing.Size(19, 19);
            this.txtNome.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNome.CustomButton.TabIndex = 1;
            this.txtNome.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNome.CustomButton.UseSelectable = true;
            this.txtNome.CustomButton.Visible = false;
            this.txtNome.Enabled = false;
            this.txtNome.Lines = new string[0];
            this.txtNome.Location = new System.Drawing.Point(24, 97);
            this.txtNome.Margin = new System.Windows.Forms.Padding(4);
            this.txtNome.MaxLength = 60;
            this.txtNome.Name = "txtNome";
            this.txtNome.PasswordChar = '\0';
            this.txtNome.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNome.SelectedText = "";
            this.txtNome.SelectionLength = 0;
            this.txtNome.SelectionStart = 0;
            this.txtNome.ShortcutsEnabled = true;
            this.txtNome.Size = new System.Drawing.Size(288, 24);
            this.txtNome.TabIndex = 1;
            this.txtNome.UseSelectable = true;
            this.txtNome.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNome.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtCpf
            // 
            // 
            // 
            // 
            this.txtCpf.CustomButton.Image = null;
            this.txtCpf.CustomButton.Location = new System.Drawing.Point(136, 2);
            this.txtCpf.CustomButton.Margin = new System.Windows.Forms.Padding(4);
            this.txtCpf.CustomButton.Name = "";
            this.txtCpf.CustomButton.Size = new System.Drawing.Size(19, 19);
            this.txtCpf.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCpf.CustomButton.TabIndex = 1;
            this.txtCpf.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCpf.CustomButton.UseSelectable = true;
            this.txtCpf.CustomButton.Visible = false;
            this.txtCpf.Enabled = false;
            this.txtCpf.Lines = new string[0];
            this.txtCpf.Location = new System.Drawing.Point(320, 97);
            this.txtCpf.Margin = new System.Windows.Forms.Padding(4);
            this.txtCpf.MaxLength = 12;
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.PasswordChar = '\0';
            this.txtCpf.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCpf.SelectedText = "";
            this.txtCpf.SelectionLength = 0;
            this.txtCpf.SelectionStart = 0;
            this.txtCpf.ShortcutsEnabled = true;
            this.txtCpf.Size = new System.Drawing.Size(158, 24);
            this.txtCpf.TabIndex = 2;
            this.txtCpf.UseSelectable = true;
            this.txtCpf.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCpf.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtEmail
            // 
            // 
            // 
            // 
            this.txtEmail.CustomButton.Image = null;
            this.txtEmail.CustomButton.Location = new System.Drawing.Point(305, 2);
            this.txtEmail.CustomButton.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmail.CustomButton.Name = "";
            this.txtEmail.CustomButton.Size = new System.Drawing.Size(19, 19);
            this.txtEmail.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtEmail.CustomButton.TabIndex = 1;
            this.txtEmail.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtEmail.CustomButton.UseSelectable = true;
            this.txtEmail.CustomButton.Visible = false;
            this.txtEmail.Enabled = false;
            this.txtEmail.Lines = new string[0];
            this.txtEmail.Location = new System.Drawing.Point(24, 149);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmail.MaxLength = 60;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PasswordChar = '\0';
            this.txtEmail.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtEmail.SelectedText = "";
            this.txtEmail.SelectionLength = 0;
            this.txtEmail.SelectionStart = 0;
            this.txtEmail.ShortcutsEnabled = true;
            this.txtEmail.Size = new System.Drawing.Size(327, 24);
            this.txtEmail.TabIndex = 3;
            this.txtEmail.UseSelectable = true;
            this.txtEmail.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtEmail.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // GridCliente
            // 
            this.GridCliente.AllowUserToAddRows = false;
            this.GridCliente.AllowUserToDeleteRows = false;
            this.GridCliente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GridCliente.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.GridCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridCliente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colunaId,
            this.colunaObs,
            this.colunaNome,
            this.colunaCpf,
            this.colunaEmail,
            this.colunaDataCad,
            this.colunaAtivo});
            this.GridCliente.GridColor = System.Drawing.Color.Black;
            this.GridCliente.Location = new System.Drawing.Point(4, 23);
            this.GridCliente.Margin = new System.Windows.Forms.Padding(2);
            this.GridCliente.Name = "GridCliente";
            this.GridCliente.ReadOnly = true;
            this.GridCliente.RowHeadersVisible = false;
            this.GridCliente.RowHeadersWidth = 51;
            this.GridCliente.Size = new System.Drawing.Size(581, 223);
            this.GridCliente.TabIndex = 10;
            this.GridCliente.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridCliente_CellDoubleClick);
            // 
            // colunaId
            // 
            this.colunaId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colunaId.HeaderText = "Id";
            this.colunaId.MinimumWidth = 6;
            this.colunaId.Name = "colunaId";
            this.colunaId.ReadOnly = true;
            this.colunaId.Width = 53;
            // 
            // colunaObs
            // 
            this.colunaObs.HeaderText = "Observações";
            this.colunaObs.MinimumWidth = 6;
            this.colunaObs.Name = "colunaObs";
            this.colunaObs.ReadOnly = true;
            this.colunaObs.Visible = false;
            // 
            // colunaNome
            // 
            this.colunaNome.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader;
            this.colunaNome.HeaderText = "Nome";
            this.colunaNome.MinimumWidth = 6;
            this.colunaNome.Name = "colunaNome";
            this.colunaNome.ReadOnly = true;
            this.colunaNome.Width = 6;
            // 
            // colunaCpf
            // 
            this.colunaCpf.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader;
            this.colunaCpf.HeaderText = "CPF";
            this.colunaCpf.MinimumWidth = 6;
            this.colunaCpf.Name = "colunaCpf";
            this.colunaCpf.ReadOnly = true;
            this.colunaCpf.Width = 6;
            // 
            // colunaEmail
            // 
            this.colunaEmail.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colunaEmail.HeaderText = "Email";
            this.colunaEmail.MinimumWidth = 6;
            this.colunaEmail.Name = "colunaEmail";
            this.colunaEmail.ReadOnly = true;
            // 
            // colunaDataCad
            // 
            this.colunaDataCad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colunaDataCad.HeaderText = "DataCad";
            this.colunaDataCad.MinimumWidth = 6;
            this.colunaDataCad.Name = "colunaDataCad";
            this.colunaDataCad.ReadOnly = true;
            this.colunaDataCad.Visible = false;
            // 
            // colunaAtivo
            // 
            this.colunaAtivo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.colunaAtivo.HeaderText = "Ativo";
            this.colunaAtivo.MinimumWidth = 6;
            this.colunaAtivo.Name = "colunaAtivo";
            this.colunaAtivo.ReadOnly = true;
            this.colunaAtivo.Width = 54;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnLimparCampos);
            this.groupBox2.Controls.Add(this.txtObs);
            this.groupBox2.Controls.Add(this.label19);
            this.groupBox2.Controls.Add(this.txtId);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtCpf);
            this.groupBox2.Controls.Add(this.txtNome);
            this.groupBox2.Controls.Add(this.chkAtivo);
            this.groupBox2.Controls.Add(this.txtEmail);
            this.groupBox2.Controls.Add(this.txtDataCad);
            this.groupBox2.Controls.Add(this.btnDesbloquear);
            this.groupBox2.Controls.Add(this.btnBloquear);
            this.groupBox2.Location = new System.Drawing.Point(29, 104);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(488, 258);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cliente";
            // 
            // btnLimparCampos
            // 
            this.btnLimparCampos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimparCampos.Enabled = false;
            this.btnLimparCampos.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnLimparCampos.Location = new System.Drawing.Point(364, 221);
            this.btnLimparCampos.Name = "btnLimparCampos";
            this.btnLimparCampos.Size = new System.Drawing.Size(108, 23);
            this.btnLimparCampos.TabIndex = 37;
            this.btnLimparCampos.Text = "Limpar Campos";
            this.btnLimparCampos.UseSelectable = true;
            this.btnLimparCampos.Click += new System.EventHandler(this.btnLimparCampos_Click);
            // 
            // txtObs
            // 
            // 
            // 
            // 
            this.txtObs.CustomButton.Image = null;
            this.txtObs.CustomButton.Location = new System.Drawing.Point(285, 1);
            this.txtObs.CustomButton.Margin = new System.Windows.Forms.Padding(4);
            this.txtObs.CustomButton.Name = "";
            this.txtObs.CustomButton.Size = new System.Drawing.Size(41, 41);
            this.txtObs.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtObs.CustomButton.TabIndex = 1;
            this.txtObs.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtObs.CustomButton.UseSelectable = true;
            this.txtObs.CustomButton.Visible = false;
            this.txtObs.Enabled = false;
            this.txtObs.Lines = new string[0];
            this.txtObs.Location = new System.Drawing.Point(24, 201);
            this.txtObs.Margin = new System.Windows.Forms.Padding(4);
            this.txtObs.MaxLength = 60;
            this.txtObs.Multiline = true;
            this.txtObs.Name = "txtObs";
            this.txtObs.PasswordChar = '\0';
            this.txtObs.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtObs.SelectedText = "";
            this.txtObs.SelectionLength = 0;
            this.txtObs.SelectionStart = 0;
            this.txtObs.ShortcutsEnabled = true;
            this.txtObs.Size = new System.Drawing.Size(327, 43);
            this.txtObs.TabIndex = 0;
            this.txtObs.UseSelectable = true;
            this.txtObs.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtObs.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(22, 177);
            this.label19.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(109, 20);
            this.label19.TabIndex = 36;
            this.label19.Text = "Observações";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 20);
            this.label1.TabIndex = 29;
            this.label1.Text = "ID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(328, 75);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 20);
            this.label5.TabIndex = 33;
            this.label5.Text = "CPF";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 125);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 20);
            this.label4.TabIndex = 32;
            this.label4.Text = "Email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 73);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 20);
            this.label2.TabIndex = 30;
            this.label2.Text = "Nome";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(120, 17);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 20);
            this.label3.TabIndex = 31;
            this.label3.Text = "Data Cadastro";
            // 
            // chkAtivo
            // 
            this.chkAtivo.AutoSize = true;
            this.chkAtivo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkAtivo.Enabled = false;
            this.chkAtivo.Location = new System.Drawing.Point(370, 39);
            this.chkAtivo.Margin = new System.Windows.Forms.Padding(4);
            this.chkAtivo.Name = "chkAtivo";
            this.chkAtivo.Size = new System.Drawing.Size(70, 24);
            this.chkAtivo.TabIndex = 17;
            this.chkAtivo.Text = "Ativo";
            this.chkAtivo.UseVisualStyleBackColor = true;
            this.chkAtivo.CheckedChanged += new System.EventHandler(this.chkAtivo_CheckedChanged);
            this.chkAtivo.Click += new System.EventHandler(this.chkAtivo_Click);
            // 
            // txtDataCad
            // 
            this.txtDataCad.Enabled = false;
            this.txtDataCad.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtDataCad.Location = new System.Drawing.Point(124, 39);
            this.txtDataCad.Margin = new System.Windows.Forms.Padding(2);
            this.txtDataCad.MinimumSize = new System.Drawing.Size(0, 30);
            this.txtDataCad.Name = "txtDataCad";
            this.txtDataCad.Size = new System.Drawing.Size(201, 30);
            this.txtDataCad.TabIndex = 28;
            // 
            // btnDesbloquear
            // 
            this.btnDesbloquear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDesbloquear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDesbloquear.FlatAppearance.BorderSize = 0;
            this.btnDesbloquear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDesbloquear.Location = new System.Drawing.Point(390, 145);
            this.btnDesbloquear.Margin = new System.Windows.Forms.Padding(2);
            this.btnDesbloquear.Name = "btnDesbloquear";
            this.btnDesbloquear.Size = new System.Drawing.Size(50, 52);
            this.btnDesbloquear.TabIndex = 26;
            this.btnDesbloquear.UseVisualStyleBackColor = true;
            this.btnDesbloquear.Click += new System.EventHandler(this.btnDesbloquear_Click);
            // 
            // btnBloquear
            // 
            this.btnBloquear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBloquear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBloquear.FlatAppearance.BorderSize = 0;
            this.btnBloquear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBloquear.Location = new System.Drawing.Point(390, 145);
            this.btnBloquear.Margin = new System.Windows.Forms.Padding(2);
            this.btnBloquear.Name = "btnBloquear";
            this.btnBloquear.Size = new System.Drawing.Size(50, 52);
            this.btnBloquear.TabIndex = 27;
            this.btnBloquear.UseVisualStyleBackColor = true;
            this.btnBloquear.Click += new System.EventHandler(this.btnBloquear_Click);
            // 
            // txtIdPesq
            // 
            // 
            // 
            // 
            this.txtIdPesq.CustomButton.Image = null;
            this.txtIdPesq.CustomButton.Location = new System.Drawing.Point(52, 2);
            this.txtIdPesq.CustomButton.Margin = new System.Windows.Forms.Padding(4);
            this.txtIdPesq.CustomButton.Name = "";
            this.txtIdPesq.CustomButton.Size = new System.Drawing.Size(19, 19);
            this.txtIdPesq.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtIdPesq.CustomButton.TabIndex = 1;
            this.txtIdPesq.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtIdPesq.CustomButton.UseSelectable = true;
            this.txtIdPesq.CustomButton.Visible = false;
            this.txtIdPesq.Lines = new string[0];
            this.txtIdPesq.Location = new System.Drawing.Point(9, 46);
            this.txtIdPesq.Margin = new System.Windows.Forms.Padding(4);
            this.txtIdPesq.MaxLength = 60;
            this.txtIdPesq.Name = "txtIdPesq";
            this.txtIdPesq.PasswordChar = '\0';
            this.txtIdPesq.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtIdPesq.SelectedText = "";
            this.txtIdPesq.SelectionLength = 0;
            this.txtIdPesq.SelectionStart = 0;
            this.txtIdPesq.ShortcutsEnabled = true;
            this.txtIdPesq.Size = new System.Drawing.Size(74, 24);
            this.txtIdPesq.TabIndex = 12;
            this.txtIdPesq.UseSelectable = true;
            this.txtIdPesq.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtIdPesq.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtIdPesq.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtIdPesq_KeyUp);
            // 
            // txtCpfPsq
            // 
            // 
            // 
            // 
            this.txtCpfPsq.CustomButton.Image = null;
            this.txtCpfPsq.CustomButton.Location = new System.Drawing.Point(108, 2);
            this.txtCpfPsq.CustomButton.Margin = new System.Windows.Forms.Padding(4);
            this.txtCpfPsq.CustomButton.Name = "";
            this.txtCpfPsq.CustomButton.Size = new System.Drawing.Size(19, 19);
            this.txtCpfPsq.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCpfPsq.CustomButton.TabIndex = 1;
            this.txtCpfPsq.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCpfPsq.CustomButton.UseSelectable = true;
            this.txtCpfPsq.CustomButton.Visible = false;
            this.txtCpfPsq.Lines = new string[0];
            this.txtCpfPsq.Location = new System.Drawing.Point(106, 46);
            this.txtCpfPsq.Margin = new System.Windows.Forms.Padding(4);
            this.txtCpfPsq.MaxLength = 60;
            this.txtCpfPsq.Name = "txtCpfPsq";
            this.txtCpfPsq.PasswordChar = '\0';
            this.txtCpfPsq.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCpfPsq.SelectedText = "";
            this.txtCpfPsq.SelectionLength = 0;
            this.txtCpfPsq.SelectionStart = 0;
            this.txtCpfPsq.ShortcutsEnabled = true;
            this.txtCpfPsq.Size = new System.Drawing.Size(130, 24);
            this.txtCpfPsq.TabIndex = 14;
            this.txtCpfPsq.UseSelectable = true;
            this.txtCpfPsq.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCpfPsq.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtCpfPsq.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtCpfPsq_KeyUp);
            // 
            // gpBoxPesq
            // 
            this.gpBoxPesq.Controls.Add(this.label17);
            this.gpBoxPesq.Controls.Add(this.label16);
            this.gpBoxPesq.Controls.Add(this.label15);
            this.gpBoxPesq.Controls.Add(this.txtCpfPsq);
            this.gpBoxPesq.Controls.Add(this.txtPesqNome);
            this.gpBoxPesq.Controls.Add(this.txtIdPesq);
            this.gpBoxPesq.Location = new System.Drawing.Point(29, 7);
            this.gpBoxPesq.Margin = new System.Windows.Forms.Padding(2);
            this.gpBoxPesq.Name = "gpBoxPesq";
            this.gpBoxPesq.Padding = new System.Windows.Forms.Padding(2);
            this.gpBoxPesq.Size = new System.Drawing.Size(488, 93);
            this.gpBoxPesq.TabIndex = 14;
            this.gpBoxPesq.TabStop = false;
            this.gpBoxPesq.Text = "Pesquisar";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(259, 22);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(53, 20);
            this.label17.TabIndex = 35;
            this.label17.Text = "Nome";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(103, 22);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(37, 20);
            this.label16.TabIndex = 34;
            this.label16.Text = "CPF";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(8, 22);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(25, 20);
            this.label15.TabIndex = 33;
            this.label15.Text = "ID";
            // 
            // txtPesqNome
            // 
            // 
            // 
            // 
            this.txtPesqNome.CustomButton.Image = null;
            this.txtPesqNome.CustomButton.Location = new System.Drawing.Point(193, 2);
            this.txtPesqNome.CustomButton.Margin = new System.Windows.Forms.Padding(4);
            this.txtPesqNome.CustomButton.Name = "";
            this.txtPesqNome.CustomButton.Size = new System.Drawing.Size(19, 19);
            this.txtPesqNome.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPesqNome.CustomButton.TabIndex = 1;
            this.txtPesqNome.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPesqNome.CustomButton.UseSelectable = true;
            this.txtPesqNome.CustomButton.Visible = false;
            this.txtPesqNome.Lines = new string[0];
            this.txtPesqNome.Location = new System.Drawing.Point(263, 46);
            this.txtPesqNome.Margin = new System.Windows.Forms.Padding(4);
            this.txtPesqNome.MaxLength = 60;
            this.txtPesqNome.Name = "txtPesqNome";
            this.txtPesqNome.PasswordChar = '\0';
            this.txtPesqNome.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPesqNome.SelectedText = "";
            this.txtPesqNome.SelectionLength = 0;
            this.txtPesqNome.SelectionStart = 0;
            this.txtPesqNome.ShortcutsEnabled = true;
            this.txtPesqNome.Size = new System.Drawing.Size(215, 24);
            this.txtPesqNome.TabIndex = 18;
            this.txtPesqNome.UseSelectable = true;
            this.txtPesqNome.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPesqNome.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtPesqNome.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtPesqNome_KeyUp);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.GridCliente);
            this.groupBox1.Location = new System.Drawing.Point(29, 465);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(589, 250);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Clientes";
            // 
            // gpboxEnderecos
            // 
            this.gpboxEnderecos.Controls.Add(this.lbUf);
            this.gpboxEnderecos.Controls.Add(this.txtUf);
            this.gpboxEnderecos.Controls.Add(this.btnCancelCep);
            this.gpboxEnderecos.Controls.Add(this.btnAddCep);
            this.gpboxEnderecos.Controls.Add(this.label14);
            this.gpboxEnderecos.Controls.Add(this.label13);
            this.gpboxEnderecos.Controls.Add(this.label12);
            this.gpboxEnderecos.Controls.Add(this.label11);
            this.gpboxEnderecos.Controls.Add(this.label10);
            this.gpboxEnderecos.Controls.Add(this.label9);
            this.gpboxEnderecos.Controls.Add(this.label8);
            this.gpboxEnderecos.Controls.Add(this.label7);
            this.gpboxEnderecos.Controls.Add(this.cmbTipo);
            this.gpboxEnderecos.Controls.Add(this.txtComplemento);
            this.gpboxEnderecos.Controls.Add(this.txtBairro);
            this.gpboxEnderecos.Controls.Add(this.txtEstado);
            this.gpboxEnderecos.Controls.Add(this.txtCidade);
            this.gpboxEnderecos.Controls.Add(this.txtLogradouro);
            this.gpboxEnderecos.Controls.Add(this.txtNumero);
            this.gpboxEnderecos.Controls.Add(this.txtCep);
            this.gpboxEnderecos.Enabled = false;
            this.gpboxEnderecos.Location = new System.Drawing.Point(538, 7);
            this.gpboxEnderecos.Margin = new System.Windows.Forms.Padding(2);
            this.gpboxEnderecos.Name = "gpboxEnderecos";
            this.gpboxEnderecos.Padding = new System.Windows.Forms.Padding(2);
            this.gpboxEnderecos.Size = new System.Drawing.Size(608, 253);
            this.gpboxEnderecos.TabIndex = 29;
            this.gpboxEnderecos.TabStop = false;
            this.gpboxEnderecos.Text = "Endereço";
            // 
            // lbUf
            // 
            this.lbUf.AutoSize = true;
            this.lbUf.Location = new System.Drawing.Point(512, 22);
            this.lbUf.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbUf.Name = "lbUf";
            this.lbUf.Size = new System.Drawing.Size(27, 20);
            this.lbUf.TabIndex = 70;
            this.lbUf.Text = "UF";
            // 
            // txtUf
            // 
            // 
            // 
            // 
            this.txtUf.CustomButton.Image = null;
            this.txtUf.CustomButton.Location = new System.Drawing.Point(37, 2);
            this.txtUf.CustomButton.Margin = new System.Windows.Forms.Padding(4);
            this.txtUf.CustomButton.Name = "";
            this.txtUf.CustomButton.Size = new System.Drawing.Size(19, 19);
            this.txtUf.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtUf.CustomButton.TabIndex = 1;
            this.txtUf.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtUf.CustomButton.UseSelectable = true;
            this.txtUf.CustomButton.Visible = false;
            this.txtUf.Lines = new string[0];
            this.txtUf.Location = new System.Drawing.Point(511, 46);
            this.txtUf.Margin = new System.Windows.Forms.Padding(4);
            this.txtUf.MaxLength = 60;
            this.txtUf.Name = "txtUf";
            this.txtUf.PasswordChar = '\0';
            this.txtUf.ReadOnly = true;
            this.txtUf.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtUf.SelectedText = "";
            this.txtUf.SelectionLength = 0;
            this.txtUf.SelectionStart = 0;
            this.txtUf.ShortcutsEnabled = true;
            this.txtUf.Size = new System.Drawing.Size(59, 24);
            this.txtUf.TabIndex = 69;
            this.txtUf.UseSelectable = true;
            this.txtUf.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtUf.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnCancelCep
            // 
            this.btnCancelCep.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCancelCep.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelCep.FlatAppearance.BorderSize = 0;
            this.btnCancelCep.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelCep.Location = new System.Drawing.Point(552, 169);
            this.btnCancelCep.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancelCep.Name = "btnCancelCep";
            this.btnCancelCep.Size = new System.Drawing.Size(48, 49);
            this.btnCancelCep.TabIndex = 68;
            this.btnCancelCep.UseVisualStyleBackColor = true;
            this.btnCancelCep.Click += new System.EventHandler(this.btnCancelCep_Click);
            // 
            // btnAddCep
            // 
            this.btnAddCep.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAddCep.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddCep.FlatAppearance.BorderSize = 0;
            this.btnAddCep.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCep.Location = new System.Drawing.Point(500, 172);
            this.btnAddCep.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddCep.Name = "btnAddCep";
            this.btnAddCep.Size = new System.Drawing.Size(48, 49);
            this.btnAddCep.TabIndex = 67;
            this.btnAddCep.UseVisualStyleBackColor = true;
            this.btnAddCep.Click += new System.EventHandler(this.btnAddCep_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(295, 161);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(37, 20);
            this.label14.TabIndex = 42;
            this.label14.Text = "Tipo";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(18, 167);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(114, 20);
            this.label13.TabIndex = 41;
            this.label13.Text = "Complemento";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(16, 90);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(64, 20);
            this.label12.TabIndex = 40;
            this.label12.Text = "Cidade";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(204, 90);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(51, 20);
            this.label11.TabIndex = 39;
            this.label11.Text = "Bairro";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(439, 90);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 20);
            this.label10.TabIndex = 38;
            this.label10.Text = "Numero";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(352, 21);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 20);
            this.label9.TabIndex = 37;
            this.label9.Text = "Estado";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(103, 21);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 20);
            this.label8.TabIndex = 36;
            this.label8.Text = "Logradouro";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 24);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 20);
            this.label7.TabIndex = 32;
            this.label7.Text = "CEP";
            // 
            // cmbTipo
            // 
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.ItemHeight = 24;
            this.cmbTipo.Items.AddRange(new object[] {
            "Avenida",
            "Campo",
            "Chacara",
            "Condomínio",
            "Estrada",
            "Favela",
            "Praça",
            "Rodovia",
            "Residencial",
            "Rua",
            "Sítio",
            "Viaduto",
            "Viela",
            "Vila"});
            this.cmbTipo.Location = new System.Drawing.Point(299, 183);
            this.cmbTipo.Margin = new System.Windows.Forms.Padding(2);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(197, 30);
            this.cmbTipo.TabIndex = 30;
            this.cmbTipo.UseSelectable = true;
            // 
            // txtComplemento
            // 
            // 
            // 
            // 
            this.txtComplemento.CustomButton.Image = null;
            this.txtComplemento.CustomButton.Location = new System.Drawing.Point(251, 2);
            this.txtComplemento.CustomButton.Margin = new System.Windows.Forms.Padding(4);
            this.txtComplemento.CustomButton.Name = "";
            this.txtComplemento.CustomButton.Size = new System.Drawing.Size(19, 19);
            this.txtComplemento.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtComplemento.CustomButton.TabIndex = 1;
            this.txtComplemento.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtComplemento.CustomButton.UseSelectable = true;
            this.txtComplemento.CustomButton.Visible = false;
            this.txtComplemento.Lines = new string[0];
            this.txtComplemento.Location = new System.Drawing.Point(20, 189);
            this.txtComplemento.Margin = new System.Windows.Forms.Padding(4);
            this.txtComplemento.MaxLength = 60;
            this.txtComplemento.Name = "txtComplemento";
            this.txtComplemento.PasswordChar = '\0';
            this.txtComplemento.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtComplemento.SelectedText = "";
            this.txtComplemento.SelectionLength = 0;
            this.txtComplemento.SelectionStart = 0;
            this.txtComplemento.ShortcutsEnabled = true;
            this.txtComplemento.Size = new System.Drawing.Size(273, 24);
            this.txtComplemento.TabIndex = 35;
            this.txtComplemento.UseSelectable = true;
            this.txtComplemento.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtComplemento.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtBairro
            // 
            // 
            // 
            // 
            this.txtBairro.CustomButton.Image = null;
            this.txtBairro.CustomButton.Location = new System.Drawing.Point(205, 2);
            this.txtBairro.CustomButton.Margin = new System.Windows.Forms.Padding(4);
            this.txtBairro.CustomButton.Name = "";
            this.txtBairro.CustomButton.Size = new System.Drawing.Size(19, 19);
            this.txtBairro.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtBairro.CustomButton.TabIndex = 1;
            this.txtBairro.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtBairro.CustomButton.UseSelectable = true;
            this.txtBairro.CustomButton.Visible = false;
            this.txtBairro.Lines = new string[0];
            this.txtBairro.Location = new System.Drawing.Point(208, 114);
            this.txtBairro.Margin = new System.Windows.Forms.Padding(4);
            this.txtBairro.MaxLength = 60;
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.PasswordChar = '\0';
            this.txtBairro.ReadOnly = true;
            this.txtBairro.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtBairro.SelectedText = "";
            this.txtBairro.SelectionLength = 0;
            this.txtBairro.SelectionStart = 0;
            this.txtBairro.ShortcutsEnabled = true;
            this.txtBairro.Size = new System.Drawing.Size(227, 24);
            this.txtBairro.TabIndex = 33;
            this.txtBairro.UseSelectable = true;
            this.txtBairro.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtBairro.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtEstado
            // 
            // 
            // 
            // 
            this.txtEstado.CustomButton.Image = null;
            this.txtEstado.CustomButton.Location = new System.Drawing.Point(125, 2);
            this.txtEstado.CustomButton.Margin = new System.Windows.Forms.Padding(4);
            this.txtEstado.CustomButton.Name = "";
            this.txtEstado.CustomButton.Size = new System.Drawing.Size(19, 19);
            this.txtEstado.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtEstado.CustomButton.TabIndex = 1;
            this.txtEstado.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtEstado.CustomButton.UseSelectable = true;
            this.txtEstado.CustomButton.Visible = false;
            this.txtEstado.Lines = new string[0];
            this.txtEstado.Location = new System.Drawing.Point(356, 46);
            this.txtEstado.Margin = new System.Windows.Forms.Padding(4);
            this.txtEstado.MaxLength = 60;
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.PasswordChar = '\0';
            this.txtEstado.ReadOnly = true;
            this.txtEstado.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtEstado.SelectedText = "";
            this.txtEstado.SelectionLength = 0;
            this.txtEstado.SelectionStart = 0;
            this.txtEstado.ShortcutsEnabled = true;
            this.txtEstado.Size = new System.Drawing.Size(147, 24);
            this.txtEstado.TabIndex = 32;
            this.txtEstado.UseSelectable = true;
            this.txtEstado.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtEstado.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtCidade
            // 
            // 
            // 
            // 
            this.txtCidade.CustomButton.Image = null;
            this.txtCidade.CustomButton.Location = new System.Drawing.Point(156, 2);
            this.txtCidade.CustomButton.Margin = new System.Windows.Forms.Padding(4);
            this.txtCidade.CustomButton.Name = "";
            this.txtCidade.CustomButton.Size = new System.Drawing.Size(19, 19);
            this.txtCidade.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCidade.CustomButton.TabIndex = 1;
            this.txtCidade.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCidade.CustomButton.UseSelectable = true;
            this.txtCidade.CustomButton.Visible = false;
            this.txtCidade.Lines = new string[0];
            this.txtCidade.Location = new System.Drawing.Point(20, 114);
            this.txtCidade.Margin = new System.Windows.Forms.Padding(4);
            this.txtCidade.MaxLength = 60;
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.PasswordChar = '\0';
            this.txtCidade.ReadOnly = true;
            this.txtCidade.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCidade.SelectedText = "";
            this.txtCidade.SelectionLength = 0;
            this.txtCidade.SelectionStart = 0;
            this.txtCidade.ShortcutsEnabled = true;
            this.txtCidade.Size = new System.Drawing.Size(178, 24);
            this.txtCidade.TabIndex = 31;
            this.txtCidade.UseSelectable = true;
            this.txtCidade.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCidade.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtLogradouro
            // 
            // 
            // 
            // 
            this.txtLogradouro.CustomButton.Image = null;
            this.txtLogradouro.CustomButton.Location = new System.Drawing.Point(219, 2);
            this.txtLogradouro.CustomButton.Margin = new System.Windows.Forms.Padding(4);
            this.txtLogradouro.CustomButton.Name = "";
            this.txtLogradouro.CustomButton.Size = new System.Drawing.Size(19, 19);
            this.txtLogradouro.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtLogradouro.CustomButton.TabIndex = 1;
            this.txtLogradouro.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtLogradouro.CustomButton.UseSelectable = true;
            this.txtLogradouro.CustomButton.Visible = false;
            this.txtLogradouro.Lines = new string[0];
            this.txtLogradouro.Location = new System.Drawing.Point(107, 46);
            this.txtLogradouro.Margin = new System.Windows.Forms.Padding(4);
            this.txtLogradouro.MaxLength = 60;
            this.txtLogradouro.Name = "txtLogradouro";
            this.txtLogradouro.PasswordChar = '\0';
            this.txtLogradouro.ReadOnly = true;
            this.txtLogradouro.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtLogradouro.SelectedText = "";
            this.txtLogradouro.SelectionLength = 0;
            this.txtLogradouro.SelectionStart = 0;
            this.txtLogradouro.ShortcutsEnabled = true;
            this.txtLogradouro.Size = new System.Drawing.Size(241, 24);
            this.txtLogradouro.TabIndex = 30;
            this.txtLogradouro.UseSelectable = true;
            this.txtLogradouro.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtLogradouro.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtNumero
            // 
            // 
            // 
            // 
            this.txtNumero.CustomButton.Image = null;
            this.txtNumero.CustomButton.Location = new System.Drawing.Point(105, 2);
            this.txtNumero.CustomButton.Margin = new System.Windows.Forms.Padding(4);
            this.txtNumero.CustomButton.Name = "";
            this.txtNumero.CustomButton.Size = new System.Drawing.Size(19, 19);
            this.txtNumero.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNumero.CustomButton.TabIndex = 1;
            this.txtNumero.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNumero.CustomButton.UseSelectable = true;
            this.txtNumero.CustomButton.Visible = false;
            this.txtNumero.Lines = new string[0];
            this.txtNumero.Location = new System.Drawing.Point(443, 114);
            this.txtNumero.Margin = new System.Windows.Forms.Padding(4);
            this.txtNumero.MaxLength = 60;
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.PasswordChar = '\0';
            this.txtNumero.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNumero.SelectedText = "";
            this.txtNumero.SelectionLength = 0;
            this.txtNumero.SelectionStart = 0;
            this.txtNumero.ShortcutsEnabled = true;
            this.txtNumero.Size = new System.Drawing.Size(127, 24);
            this.txtNumero.TabIndex = 29;
            this.txtNumero.UseSelectable = true;
            this.txtNumero.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNumero.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtCep
            // 
            // 
            // 
            // 
            this.txtCep.CustomButton.Image = null;
            this.txtCep.CustomButton.Location = new System.Drawing.Point(57, 2);
            this.txtCep.CustomButton.Margin = new System.Windows.Forms.Padding(4);
            this.txtCep.CustomButton.Name = "";
            this.txtCep.CustomButton.Size = new System.Drawing.Size(19, 19);
            this.txtCep.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCep.CustomButton.TabIndex = 1;
            this.txtCep.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCep.CustomButton.UseSelectable = true;
            this.txtCep.CustomButton.Visible = false;
            this.txtCep.Lines = new string[0];
            this.txtCep.Location = new System.Drawing.Point(20, 46);
            this.txtCep.Margin = new System.Windows.Forms.Padding(4);
            this.txtCep.MaxLength = 8;
            this.txtCep.Name = "txtCep";
            this.txtCep.PasswordChar = '\0';
            this.txtCep.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCep.SelectedText = "";
            this.txtCep.SelectionLength = 0;
            this.txtCep.SelectionStart = 0;
            this.txtCep.ShortcutsEnabled = true;
            this.txtCep.Size = new System.Drawing.Size(79, 24);
            this.txtCep.TabIndex = 20;
            this.txtCep.UseSelectable = true;
            this.txtCep.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCep.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtCep.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtCep_KeyUp);
            // 
            // gpboxNumeros
            // 
            this.gpboxNumeros.Controls.Add(this.metroComboBox4);
            this.gpboxNumeros.Controls.Add(this.maskedTextBox4);
            this.gpboxNumeros.Controls.Add(this.label24);
            this.gpboxNumeros.Controls.Add(this.label25);
            this.gpboxNumeros.Controls.Add(this.metroComboBox2);
            this.gpboxNumeros.Controls.Add(this.maskedTextBox3);
            this.gpboxNumeros.Controls.Add(this.label20);
            this.gpboxNumeros.Controls.Add(this.label23);
            this.gpboxNumeros.Controls.Add(this.metroComboBox1);
            this.gpboxNumeros.Controls.Add(this.maskedTextBox1);
            this.gpboxNumeros.Controls.Add(this.label6);
            this.gpboxNumeros.Controls.Add(this.label18);
            this.gpboxNumeros.Controls.Add(this.button2);
            this.gpboxNumeros.Controls.Add(this.button3);
            this.gpboxNumeros.Controls.Add(this.metroComboBox3);
            this.gpboxNumeros.Controls.Add(this.maskedTextBox2);
            this.gpboxNumeros.Controls.Add(this.label21);
            this.gpboxNumeros.Controls.Add(this.label22);
            this.gpboxNumeros.Cursor = System.Windows.Forms.Cursors.Default;
            this.gpboxNumeros.Enabled = false;
            this.gpboxNumeros.Location = new System.Drawing.Point(541, 264);
            this.gpboxNumeros.Margin = new System.Windows.Forms.Padding(2);
            this.gpboxNumeros.Name = "gpboxNumeros";
            this.gpboxNumeros.Padding = new System.Windows.Forms.Padding(2);
            this.gpboxNumeros.Size = new System.Drawing.Size(605, 197);
            this.gpboxNumeros.TabIndex = 29;
            this.gpboxNumeros.TabStop = false;
            this.gpboxNumeros.Text = "Telefone";
            // 
            // metroComboBox4
            // 
            this.metroComboBox4.FormattingEnabled = true;
            this.metroComboBox4.ItemHeight = 24;
            this.metroComboBox4.Items.AddRange(new object[] {
            "Residencial",
            "Comercial",
            "Celular"});
            this.metroComboBox4.Location = new System.Drawing.Point(424, 133);
            this.metroComboBox4.Margin = new System.Windows.Forms.Padding(2);
            this.metroComboBox4.Name = "metroComboBox4";
            this.metroComboBox4.Size = new System.Drawing.Size(100, 30);
            this.metroComboBox4.TabIndex = 87;
            this.metroComboBox4.UseSelectable = true;
            // 
            // maskedTextBox4
            // 
            this.maskedTextBox4.Location = new System.Drawing.Point(307, 139);
            this.maskedTextBox4.Margin = new System.Windows.Forms.Padding(2);
            this.maskedTextBox4.Mask = "(00) 00000-9999";
            this.maskedTextBox4.Name = "maskedTextBox4";
            this.maskedTextBox4.Size = new System.Drawing.Size(90, 26);
            this.maskedTextBox4.TabIndex = 86;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(421, 114);
            this.label24.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(37, 20);
            this.label24.TabIndex = 85;
            this.label24.Text = "Tipo";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(303, 114);
            this.label25.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(71, 20);
            this.label25.TabIndex = 84;
            this.label25.Text = "Telefone";
            // 
            // metroComboBox2
            // 
            this.metroComboBox2.FormattingEnabled = true;
            this.metroComboBox2.ItemHeight = 24;
            this.metroComboBox2.Items.AddRange(new object[] {
            "Residencial",
            "Comercial",
            "Celular"});
            this.metroComboBox2.Location = new System.Drawing.Point(424, 49);
            this.metroComboBox2.Margin = new System.Windows.Forms.Padding(2);
            this.metroComboBox2.Name = "metroComboBox2";
            this.metroComboBox2.Size = new System.Drawing.Size(100, 30);
            this.metroComboBox2.TabIndex = 83;
            this.metroComboBox2.UseSelectable = true;
            // 
            // maskedTextBox3
            // 
            this.maskedTextBox3.Location = new System.Drawing.Point(307, 55);
            this.maskedTextBox3.Margin = new System.Windows.Forms.Padding(2);
            this.maskedTextBox3.Mask = "(00) 00000-9999";
            this.maskedTextBox3.Name = "maskedTextBox3";
            this.maskedTextBox3.Size = new System.Drawing.Size(90, 26);
            this.maskedTextBox3.TabIndex = 82;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(421, 30);
            this.label20.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(37, 20);
            this.label20.TabIndex = 81;
            this.label20.Text = "Tipo";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(303, 30);
            this.label23.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(71, 20);
            this.label23.TabIndex = 80;
            this.label23.Text = "Telefone";
            // 
            // metroComboBox1
            // 
            this.metroComboBox1.FormattingEnabled = true;
            this.metroComboBox1.ItemHeight = 24;
            this.metroComboBox1.Items.AddRange(new object[] {
            "Residencial",
            "Comercial",
            "Celular"});
            this.metroComboBox1.Location = new System.Drawing.Point(148, 127);
            this.metroComboBox1.Margin = new System.Windows.Forms.Padding(2);
            this.metroComboBox1.Name = "metroComboBox1";
            this.metroComboBox1.Size = new System.Drawing.Size(100, 30);
            this.metroComboBox1.TabIndex = 79;
            this.metroComboBox1.UseSelectable = true;
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(31, 133);
            this.maskedTextBox1.Margin = new System.Windows.Forms.Padding(2);
            this.maskedTextBox1.Mask = "(00) 00000-9999";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(90, 26);
            this.maskedTextBox1.TabIndex = 78;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(145, 108);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 20);
            this.label6.TabIndex = 77;
            this.label6.Text = "Tipo";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(27, 108);
            this.label18.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(71, 20);
            this.label18.TabIndex = 76;
            this.label18.Text = "Telefone";
            // 
            // button2
            // 
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(564, 93);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(33, 32);
            this.button2.TabIndex = 69;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(527, 93);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(33, 32);
            this.button3.TabIndex = 69;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // metroComboBox3
            // 
            this.metroComboBox3.FormattingEnabled = true;
            this.metroComboBox3.ItemHeight = 24;
            this.metroComboBox3.Items.AddRange(new object[] {
            "Residencial",
            "Comercial",
            "Celular"});
            this.metroComboBox3.Location = new System.Drawing.Point(148, 42);
            this.metroComboBox3.Margin = new System.Windows.Forms.Padding(2);
            this.metroComboBox3.Name = "metroComboBox3";
            this.metroComboBox3.Size = new System.Drawing.Size(100, 30);
            this.metroComboBox3.TabIndex = 75;
            this.metroComboBox3.UseSelectable = true;
            // 
            // maskedTextBox2
            // 
            this.maskedTextBox2.Location = new System.Drawing.Point(31, 48);
            this.maskedTextBox2.Margin = new System.Windows.Forms.Padding(2);
            this.maskedTextBox2.Mask = "(00) 00000-9999";
            this.maskedTextBox2.Name = "maskedTextBox2";
            this.maskedTextBox2.Size = new System.Drawing.Size(90, 26);
            this.maskedTextBox2.TabIndex = 71;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(145, 23);
            this.label21.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(37, 20);
            this.label21.TabIndex = 70;
            this.label21.Text = "Tipo";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(27, 23);
            this.label22.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(71, 20);
            this.label22.TabIndex = 69;
            this.label22.Text = "Telefone";
            // 
            // btnInserir
            // 
            this.btnInserir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInserir.Enabled = false;
            this.btnInserir.FlatAppearance.BorderSize = 0;
            this.btnInserir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInserir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnInserir.Location = new System.Drawing.Point(95, 366);
            this.btnInserir.Margin = new System.Windows.Forms.Padding(2);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(66, 95);
            this.btnInserir.TabIndex = 67;
            this.btnInserir.Text = "Inserir";
            this.btnInserir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnInserir.UseVisualStyleBackColor = true;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditar.Enabled = false;
            this.btnEditar.FlatAppearance.BorderSize = 0;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEditar.Location = new System.Drawing.Point(244, 366);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(2);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(66, 95);
            this.btnEditar.TabIndex = 68;
            this.btnEditar.Text = "Editar";
            this.btnEditar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnListar
            // 
            this.btnListar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnListar.FlatAppearance.BorderSize = 0;
            this.btnListar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnListar.Location = new System.Drawing.Point(393, 366);
            this.btnListar.Margin = new System.Windows.Forms.Padding(2);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(66, 95);
            this.btnListar.TabIndex = 69;
            this.btnListar.Text = "Listar";
            this.btnListar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click_1);
            // 
            // button1
            // 
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(1231, 2);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(35, 29);
            this.button1.TabIndex = 69;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // GridEndereco
            // 
            this.GridEndereco.AllowUserToAddRows = false;
            this.GridEndereco.AllowUserToDeleteRows = false;
            this.GridEndereco.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GridEndereco.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.GridEndereco.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridEndereco.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colunaCep,
            this.colunaCidade,
            this.colunaLogradouro,
            this.colunaNumero,
            this.colunaComplemento,
            this.colunaEstado,
            this.colunaTipo,
            this.colunaBairro});
            this.GridEndereco.GridColor = System.Drawing.Color.Black;
            this.GridEndereco.Location = new System.Drawing.Point(4, 23);
            this.GridEndereco.Margin = new System.Windows.Forms.Padding(2);
            this.GridEndereco.Name = "GridEndereco";
            this.GridEndereco.ReadOnly = true;
            this.GridEndereco.RowHeadersVisible = false;
            this.GridEndereco.RowHeadersWidth = 51;
            this.GridEndereco.Size = new System.Drawing.Size(493, 223);
            this.GridEndereco.TabIndex = 10;
            this.GridEndereco.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridEndereco_CellDoubleClick);
            // 
            // colunaCep
            // 
            this.colunaCep.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colunaCep.HeaderText = "CEP";
            this.colunaCep.MinimumWidth = 6;
            this.colunaCep.Name = "colunaCep";
            this.colunaCep.ReadOnly = true;
            // 
            // colunaCidade
            // 
            this.colunaCidade.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colunaCidade.HeaderText = "Cidade";
            this.colunaCidade.MinimumWidth = 6;
            this.colunaCidade.Name = "colunaCidade";
            this.colunaCidade.ReadOnly = true;
            // 
            // colunaLogradouro
            // 
            this.colunaLogradouro.HeaderText = "Logradouro";
            this.colunaLogradouro.MinimumWidth = 6;
            this.colunaLogradouro.Name = "colunaLogradouro";
            this.colunaLogradouro.ReadOnly = true;
            this.colunaLogradouro.Visible = false;
            // 
            // colunaNumero
            // 
            this.colunaNumero.HeaderText = "Numero";
            this.colunaNumero.MinimumWidth = 6;
            this.colunaNumero.Name = "colunaNumero";
            this.colunaNumero.ReadOnly = true;
            this.colunaNumero.Visible = false;
            // 
            // colunaComplemento
            // 
            this.colunaComplemento.HeaderText = "Complemento";
            this.colunaComplemento.MinimumWidth = 6;
            this.colunaComplemento.Name = "colunaComplemento";
            this.colunaComplemento.ReadOnly = true;
            this.colunaComplemento.Visible = false;
            // 
            // colunaEstado
            // 
            this.colunaEstado.HeaderText = "Estado";
            this.colunaEstado.MinimumWidth = 6;
            this.colunaEstado.Name = "colunaEstado";
            this.colunaEstado.ReadOnly = true;
            this.colunaEstado.Visible = false;
            // 
            // colunaTipo
            // 
            this.colunaTipo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colunaTipo.HeaderText = "Tipo";
            this.colunaTipo.MinimumWidth = 6;
            this.colunaTipo.Name = "colunaTipo";
            this.colunaTipo.ReadOnly = true;
            // 
            // colunaBairro
            // 
            this.colunaBairro.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colunaBairro.HeaderText = "Bairro";
            this.colunaBairro.MinimumWidth = 6;
            this.colunaBairro.Name = "colunaBairro";
            this.colunaBairro.ReadOnly = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.GridEndereco);
            this.groupBox5.Location = new System.Drawing.Point(641, 465);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox5.Size = new System.Drawing.Size(505, 250);
            this.groupBox5.TabIndex = 22;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Endereços";
            // 
            // ClienteView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1178, 742);
            this.Controls.Add(this.gpboxEnderecos);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.gpboxNumeros);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.gpBoxPesq);
            this.Controls.Add(this.btnInserir);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ClienteView";
            this.Padding = new System.Windows.Forms.Padding(23, 75, 23, 25);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cliente";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridCliente)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.gpBoxPesq.ResumeLayout(false);
            this.gpBoxPesq.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.gpboxEnderecos.ResumeLayout(false);
            this.gpboxEnderecos.PerformLayout();
            this.gpboxNumeros.ResumeLayout(false);
            this.gpboxNumeros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridEndereco)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox txtId;
        private MetroFramework.Controls.MetroTextBox txtNome;
        private MetroFramework.Controls.MetroTextBox txtCpf;
        private MetroFramework.Controls.MetroTextBox txtEmail;
        private System.Windows.Forms.DataGridView GridCliente;
        private System.Windows.Forms.GroupBox groupBox2;
        private MetroFramework.Controls.MetroTextBox txtIdPesq;
        private MetroFramework.Controls.MetroTextBox txtCpfPsq;
        private System.Windows.Forms.GroupBox gpBoxPesq;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkAtivo;
        private MetroFramework.Controls.MetroTextBox txtPesqNome;
        private System.Windows.Forms.Button btnBloquear;
        private System.Windows.Forms.Button btnDesbloquear;
        private MetroFramework.Controls.MetroDateTime txtDataCad;
        private System.Windows.Forms.GroupBox gpboxEnderecos;
        private MetroFramework.Controls.MetroComboBox cmbTipo;
        private MetroFramework.Controls.MetroTextBox txtComplemento;
        private MetroFramework.Controls.MetroTextBox txtBairro;
        private MetroFramework.Controls.MetroTextBox txtEstado;
        private MetroFramework.Controls.MetroTextBox txtCidade;
        private MetroFramework.Controls.MetroTextBox txtLogradouro;
        private MetroFramework.Controls.MetroTextBox txtNumero;
        private MetroFramework.Controls.MetroTextBox txtCep;
        private System.Windows.Forms.GroupBox gpboxNumeros;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private MetroFramework.Controls.MetroTextBox txtObs;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button btnInserir;
        private MetroFramework.Controls.MetroComboBox metroComboBox3;
        private System.Windows.Forms.MaskedTextBox maskedTextBox2;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.Button button1;
        private MetroFramework.Controls.MetroButton btnLimparCampos;
        private System.Windows.Forms.Button btnCancelCep;
        private System.Windows.Forms.Button btnAddCep;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView GridEndereco;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colunaCep;
        private System.Windows.Forms.DataGridViewTextBoxColumn colunaCidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn colunaLogradouro;
        private System.Windows.Forms.DataGridViewTextBoxColumn colunaNumero;
        private System.Windows.Forms.DataGridViewTextBoxColumn colunaComplemento;
        private System.Windows.Forms.DataGridViewTextBoxColumn colunaEstado;
        private System.Windows.Forms.DataGridViewTextBoxColumn colunaTipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colunaBairro;
        private System.Windows.Forms.Label lbUf;
        private MetroFramework.Controls.MetroTextBox txtUf;
        private System.Windows.Forms.DataGridViewTextBoxColumn colunaId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colunaObs;
        private System.Windows.Forms.DataGridViewTextBoxColumn colunaNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn colunaCpf;
        private System.Windows.Forms.DataGridViewTextBoxColumn colunaEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn colunaDataCad;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colunaAtivo;
        private MetroFramework.Controls.MetroComboBox metroComboBox4;
        private System.Windows.Forms.MaskedTextBox maskedTextBox4;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private MetroFramework.Controls.MetroComboBox metroComboBox2;
        private System.Windows.Forms.MaskedTextBox maskedTextBox3;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label23;
        private MetroFramework.Controls.MetroComboBox metroComboBox1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label18;
    }
}

