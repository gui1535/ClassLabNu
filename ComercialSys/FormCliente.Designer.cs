namespace ComercialSys
{
    partial class FormCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCliente));
            this.txtId = new MetroFramework.Controls.MetroTextBox();
            this.txtNome = new MetroFramework.Controls.MetroTextBox();
            this.txtCpf = new MetroFramework.Controls.MetroTextBox();
            this.txtEmail = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.GridCliente = new System.Windows.Forms.DataGridView();
            this.colunaId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colunaNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colunaCpf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colunaEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colunaDataCad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colunaAtivo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.btnInserirImg = new MetroFramework.Controls.MetroButton();
            this.btnInserir = new MetroFramework.Controls.MetroButton();
            this.gpBoxImg = new System.Windows.Forms.GroupBox();
            this.txtIdPesq = new MetroFramework.Controls.MetroTextBox();
            this.lbIdPesq = new MetroFramework.Controls.MetroLabel();
            this.txtCpfPsq = new MetroFramework.Controls.MetroTextBox();
            this.lbCpfPesq = new MetroFramework.Controls.MetroLabel();
            this.btnPesqCpf = new System.Windows.Forms.Button();
            this.btnPesqId = new System.Windows.Forms.Button();
            this.gpBoxPesq = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.FileDialogImg = new System.Windows.Forms.OpenFileDialog();
            this.picImgCliente = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.GridCliente)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.gpBoxImg.SuspendLayout();
            this.gpBoxPesq.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picImgCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // txtId
            // 
            // 
            // 
            // 
            this.txtId.CustomButton.Image = null;
            this.txtId.CustomButton.Location = new System.Drawing.Point(42, 1);
            this.txtId.CustomButton.Margin = new System.Windows.Forms.Padding(4);
            this.txtId.CustomButton.Name = "";
            this.txtId.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtId.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtId.CustomButton.TabIndex = 1;
            this.txtId.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtId.CustomButton.UseSelectable = true;
            this.txtId.CustomButton.Visible = false;
            this.txtId.Enabled = false;
            this.txtId.Lines = new string[0];
            this.txtId.Location = new System.Drawing.Point(297, 31);
            this.txtId.Margin = new System.Windows.Forms.Padding(4);
            this.txtId.MaxLength = 32767;
            this.txtId.Name = "txtId";
            this.txtId.PasswordChar = '\0';
            this.txtId.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtId.SelectedText = "";
            this.txtId.SelectionLength = 0;
            this.txtId.SelectionStart = 0;
            this.txtId.ShortcutsEnabled = true;
            this.txtId.Size = new System.Drawing.Size(66, 25);
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
            this.txtNome.CustomButton.Location = new System.Drawing.Point(194, 1);
            this.txtNome.CustomButton.Margin = new System.Windows.Forms.Padding(4);
            this.txtNome.CustomButton.Name = "";
            this.txtNome.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtNome.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNome.CustomButton.TabIndex = 1;
            this.txtNome.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNome.CustomButton.UseSelectable = true;
            this.txtNome.CustomButton.Visible = false;
            this.txtNome.Lines = new string[0];
            this.txtNome.Location = new System.Drawing.Point(297, 75);
            this.txtNome.Margin = new System.Windows.Forms.Padding(4);
            this.txtNome.MaxLength = 60;
            this.txtNome.Name = "txtNome";
            this.txtNome.PasswordChar = '\0';
            this.txtNome.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNome.SelectedText = "";
            this.txtNome.SelectionLength = 0;
            this.txtNome.SelectionStart = 0;
            this.txtNome.ShortcutsEnabled = true;
            this.txtNome.Size = new System.Drawing.Size(218, 25);
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
            this.txtCpf.CustomButton.Location = new System.Drawing.Point(132, 1);
            this.txtCpf.CustomButton.Margin = new System.Windows.Forms.Padding(4);
            this.txtCpf.CustomButton.Name = "";
            this.txtCpf.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtCpf.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCpf.CustomButton.TabIndex = 1;
            this.txtCpf.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCpf.CustomButton.UseSelectable = true;
            this.txtCpf.CustomButton.Visible = false;
            this.txtCpf.Lines = new string[0];
            this.txtCpf.Location = new System.Drawing.Point(297, 163);
            this.txtCpf.Margin = new System.Windows.Forms.Padding(4);
            this.txtCpf.MaxLength = 12;
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.PasswordChar = '\0';
            this.txtCpf.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCpf.SelectedText = "";
            this.txtCpf.SelectionLength = 0;
            this.txtCpf.SelectionStart = 0;
            this.txtCpf.ShortcutsEnabled = true;
            this.txtCpf.Size = new System.Drawing.Size(156, 25);
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
            this.txtEmail.CustomButton.Location = new System.Drawing.Point(194, 1);
            this.txtEmail.CustomButton.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmail.CustomButton.Name = "";
            this.txtEmail.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtEmail.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtEmail.CustomButton.TabIndex = 1;
            this.txtEmail.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtEmail.CustomButton.UseSelectable = true;
            this.txtEmail.CustomButton.Visible = false;
            this.txtEmail.Lines = new string[0];
            this.txtEmail.Location = new System.Drawing.Point(297, 119);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmail.MaxLength = 60;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PasswordChar = '\0';
            this.txtEmail.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtEmail.SelectedText = "";
            this.txtEmail.SelectionLength = 0;
            this.txtEmail.SelectionStart = 0;
            this.txtEmail.ShortcutsEnabled = true;
            this.txtEmail.Size = new System.Drawing.Size(218, 25);
            this.txtEmail.TabIndex = 3;
            this.txtEmail.UseSelectable = true;
            this.txtEmail.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtEmail.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.Location = new System.Drawing.Point(239, 36);
            this.metroLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(24, 20);
            this.metroLabel1.TabIndex = 4;
            this.metroLabel1.Text = "ID";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel2.Location = new System.Drawing.Point(239, 78);
            this.metroLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(50, 20);
            this.metroLabel2.TabIndex = 5;
            this.metroLabel2.Text = "Nome";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel3.Location = new System.Drawing.Point(239, 162);
            this.metroLabel3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(33, 20);
            this.metroLabel3.TabIndex = 6;
            this.metroLabel3.Text = "CPF";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel4.Location = new System.Drawing.Point(239, 120);
            this.metroLabel4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(46, 20);
            this.metroLabel4.TabIndex = 7;
            this.metroLabel4.Text = "Email";
            // 
            // GridCliente
            // 
            this.GridCliente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GridCliente.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.GridCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridCliente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colunaId,
            this.colunaNome,
            this.colunaCpf,
            this.colunaEmail,
            this.colunaDataCad,
            this.colunaAtivo});
            this.GridCliente.GridColor = System.Drawing.Color.Black;
            this.GridCliente.Location = new System.Drawing.Point(6, 31);
            this.GridCliente.Name = "GridCliente";
            this.GridCliente.ReadOnly = true;
            this.GridCliente.RowHeadersWidth = 51;
            this.GridCliente.Size = new System.Drawing.Size(850, 394);
            this.GridCliente.TabIndex = 10;
            this.GridCliente.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridCliente_CellDoubleClick);
            // 
            // colunaId
            // 
            this.colunaId.HeaderText = "Id";
            this.colunaId.MinimumWidth = 6;
            this.colunaId.Name = "colunaId";
            this.colunaId.ReadOnly = true;
            // 
            // colunaNome
            // 
            this.colunaNome.HeaderText = "Nome";
            this.colunaNome.MinimumWidth = 6;
            this.colunaNome.Name = "colunaNome";
            this.colunaNome.ReadOnly = true;
            // 
            // colunaCpf
            // 
            this.colunaCpf.HeaderText = "CPF";
            this.colunaCpf.MinimumWidth = 6;
            this.colunaCpf.Name = "colunaCpf";
            this.colunaCpf.ReadOnly = true;
            // 
            // colunaEmail
            // 
            this.colunaEmail.HeaderText = "Email";
            this.colunaEmail.MinimumWidth = 6;
            this.colunaEmail.Name = "colunaEmail";
            this.colunaEmail.ReadOnly = true;
            // 
            // colunaDataCad
            // 
            this.colunaDataCad.HeaderText = "DataCad";
            this.colunaDataCad.MinimumWidth = 6;
            this.colunaDataCad.Name = "colunaDataCad";
            this.colunaDataCad.ReadOnly = true;
            // 
            // colunaAtivo
            // 
            this.colunaAtivo.HeaderText = "Ativo";
            this.colunaAtivo.MinimumWidth = 6;
            this.colunaAtivo.Name = "colunaAtivo";
            this.colunaAtivo.ReadOnly = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.metroButton1);
            this.groupBox2.Controls.Add(this.btnInserirImg);
            this.groupBox2.Controls.Add(this.btnInserir);
            this.groupBox2.Controls.Add(this.gpBoxImg);
            this.groupBox2.Controls.Add(this.txtCpf);
            this.groupBox2.Controls.Add(this.txtId);
            this.groupBox2.Controls.Add(this.txtNome);
            this.groupBox2.Controls.Add(this.txtEmail);
            this.groupBox2.Controls.Add(this.metroLabel1);
            this.groupBox2.Controls.Add(this.metroLabel4);
            this.groupBox2.Controls.Add(this.metroLabel2);
            this.groupBox2.Controls.Add(this.metroLabel3);
            this.groupBox2.Location = new System.Drawing.Point(20, 222);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(522, 276);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cadastrar";
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(264, 224);
            this.metroButton1.Margin = new System.Windows.Forms.Padding(4);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(96, 30);
            this.metroButton1.TabIndex = 17;
            this.metroButton1.Text = "&Editar";
            this.metroButton1.UseSelectable = true;
            // 
            // btnInserirImg
            // 
            this.btnInserirImg.Location = new System.Drawing.Point(20, 207);
            this.btnInserirImg.Margin = new System.Windows.Forms.Padding(4);
            this.btnInserirImg.Name = "btnInserirImg";
            this.btnInserirImg.Size = new System.Drawing.Size(201, 23);
            this.btnInserirImg.TabIndex = 16;
            this.btnInserirImg.Text = "Inserir Imagem";
            this.btnInserirImg.UseSelectable = true;
            this.btnInserirImg.Click += new System.EventHandler(this.btnInserirImg_Click);
            // 
            // btnInserir
            // 
            this.btnInserir.Location = new System.Drawing.Point(386, 224);
            this.btnInserir.Margin = new System.Windows.Forms.Padding(4);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(96, 30);
            this.btnInserir.TabIndex = 8;
            this.btnInserir.Text = "&Inserir";
            this.btnInserir.UseSelectable = true;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // gpBoxImg
            // 
            this.gpBoxImg.Controls.Add(this.picImgCliente);
            this.gpBoxImg.Location = new System.Drawing.Point(20, 26);
            this.gpBoxImg.Name = "gpBoxImg";
            this.gpBoxImg.Size = new System.Drawing.Size(201, 174);
            this.gpBoxImg.TabIndex = 16;
            this.gpBoxImg.TabStop = false;
            this.gpBoxImg.Text = "Imagem";
            // 
            // txtIdPesq
            // 
            // 
            // 
            // 
            this.txtIdPesq.CustomButton.Image = null;
            this.txtIdPesq.CustomButton.Location = new System.Drawing.Point(60, 1);
            this.txtIdPesq.CustomButton.Margin = new System.Windows.Forms.Padding(4);
            this.txtIdPesq.CustomButton.Name = "";
            this.txtIdPesq.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtIdPesq.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtIdPesq.CustomButton.TabIndex = 1;
            this.txtIdPesq.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtIdPesq.CustomButton.UseSelectable = true;
            this.txtIdPesq.CustomButton.Visible = false;
            this.txtIdPesq.Lines = new string[0];
            this.txtIdPesq.Location = new System.Drawing.Point(60, 29);
            this.txtIdPesq.Margin = new System.Windows.Forms.Padding(4);
            this.txtIdPesq.MaxLength = 60;
            this.txtIdPesq.Name = "txtIdPesq";
            this.txtIdPesq.PasswordChar = '\0';
            this.txtIdPesq.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtIdPesq.SelectedText = "";
            this.txtIdPesq.SelectionLength = 0;
            this.txtIdPesq.SelectionStart = 0;
            this.txtIdPesq.ShortcutsEnabled = true;
            this.txtIdPesq.Size = new System.Drawing.Size(84, 25);
            this.txtIdPesq.TabIndex = 12;
            this.txtIdPesq.UseSelectable = true;
            this.txtIdPesq.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtIdPesq.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lbIdPesq
            // 
            this.lbIdPesq.AutoSize = true;
            this.lbIdPesq.Location = new System.Drawing.Point(19, 34);
            this.lbIdPesq.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbIdPesq.Name = "lbIdPesq";
            this.lbIdPesq.Size = new System.Drawing.Size(22, 20);
            this.lbIdPesq.TabIndex = 13;
            this.lbIdPesq.Text = "ID";
            // 
            // txtCpfPsq
            // 
            // 
            // 
            // 
            this.txtCpfPsq.CustomButton.Image = null;
            this.txtCpfPsq.CustomButton.Location = new System.Drawing.Point(160, 1);
            this.txtCpfPsq.CustomButton.Margin = new System.Windows.Forms.Padding(4);
            this.txtCpfPsq.CustomButton.Name = "";
            this.txtCpfPsq.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtCpfPsq.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCpfPsq.CustomButton.TabIndex = 1;
            this.txtCpfPsq.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCpfPsq.CustomButton.UseSelectable = true;
            this.txtCpfPsq.CustomButton.Visible = false;
            this.txtCpfPsq.Lines = new string[0];
            this.txtCpfPsq.Location = new System.Drawing.Point(60, 71);
            this.txtCpfPsq.Margin = new System.Windows.Forms.Padding(4);
            this.txtCpfPsq.MaxLength = 60;
            this.txtCpfPsq.Name = "txtCpfPsq";
            this.txtCpfPsq.PasswordChar = '\0';
            this.txtCpfPsq.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCpfPsq.SelectedText = "";
            this.txtCpfPsq.SelectionLength = 0;
            this.txtCpfPsq.SelectionStart = 0;
            this.txtCpfPsq.ShortcutsEnabled = true;
            this.txtCpfPsq.Size = new System.Drawing.Size(184, 25);
            this.txtCpfPsq.TabIndex = 14;
            this.txtCpfPsq.UseSelectable = true;
            this.txtCpfPsq.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCpfPsq.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lbCpfPesq
            // 
            this.lbCpfPesq.AutoSize = true;
            this.lbCpfPesq.Location = new System.Drawing.Point(19, 76);
            this.lbCpfPesq.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbCpfPesq.Name = "lbCpfPesq";
            this.lbCpfPesq.Size = new System.Drawing.Size(33, 20);
            this.lbCpfPesq.TabIndex = 15;
            this.lbCpfPesq.Text = "CPF";
            // 
            // btnPesqCpf
            // 
            this.btnPesqCpf.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPesqCpf.BackgroundImage")));
            this.btnPesqCpf.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPesqCpf.FlatAppearance.BorderSize = 0;
            this.btnPesqCpf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesqCpf.Location = new System.Drawing.Point(251, 71);
            this.btnPesqCpf.Name = "btnPesqCpf";
            this.btnPesqCpf.Size = new System.Drawing.Size(44, 25);
            this.btnPesqCpf.TabIndex = 16;
            this.btnPesqCpf.UseVisualStyleBackColor = true;
            this.btnPesqCpf.Click += new System.EventHandler(this.btnPesqCpf_Click);
            // 
            // btnPesqId
            // 
            this.btnPesqId.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPesqId.BackgroundImage")));
            this.btnPesqId.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPesqId.FlatAppearance.BorderSize = 0;
            this.btnPesqId.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesqId.Location = new System.Drawing.Point(151, 29);
            this.btnPesqId.Name = "btnPesqId";
            this.btnPesqId.Size = new System.Drawing.Size(44, 25);
            this.btnPesqId.TabIndex = 17;
            this.btnPesqId.UseVisualStyleBackColor = true;
            this.btnPesqId.Click += new System.EventHandler(this.btnPesqId_Click);
            // 
            // gpBoxPesq
            // 
            this.gpBoxPesq.Controls.Add(this.btnPesqId);
            this.gpBoxPesq.Controls.Add(this.btnPesqCpf);
            this.gpBoxPesq.Controls.Add(this.lbCpfPesq);
            this.gpBoxPesq.Controls.Add(this.txtCpfPsq);
            this.gpBoxPesq.Controls.Add(this.lbIdPesq);
            this.gpBoxPesq.Controls.Add(this.txtIdPesq);
            this.gpBoxPesq.Location = new System.Drawing.Point(20, 82);
            this.gpBoxPesq.Name = "gpBoxPesq";
            this.gpBoxPesq.Size = new System.Drawing.Size(522, 124);
            this.gpBoxPesq.TabIndex = 14;
            this.gpBoxPesq.TabStop = false;
            this.gpBoxPesq.Text = "Pesquisar";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.GridCliente);
            this.groupBox1.Location = new System.Drawing.Point(565, 82);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(862, 431);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Clientes";
            // 
            // FileDialogImg
            // 
            this.FileDialogImg.FileName = "OpenFileDialog";
            // 
            // picImgCliente
            // 
            this.picImgCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picImgCliente.Location = new System.Drawing.Point(6, 26);
            this.picImgCliente.Name = "picImgCliente";
            this.picImgCliente.Size = new System.Drawing.Size(189, 142);
            this.picImgCliente.TabIndex = 18;
            this.picImgCliente.TabStop = false;
            // 
            // FormCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1442, 526);
            this.Controls.Add(this.gpBoxPesq);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormCliente";
            this.Padding = new System.Windows.Forms.Padding(26, 79, 26, 26);
            this.Text = "Cliente";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridCliente)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.gpBoxImg.ResumeLayout(false);
            this.gpBoxPesq.ResumeLayout(false);
            this.gpBoxPesq.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picImgCliente)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox txtId;
        private MetroFramework.Controls.MetroTextBox txtNome;
        private MetroFramework.Controls.MetroTextBox txtCpf;
        private MetroFramework.Controls.MetroTextBox txtEmail;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private System.Windows.Forms.DataGridView GridCliente;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colunaId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colunaNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn colunaCpf;
        private System.Windows.Forms.DataGridViewTextBoxColumn colunaEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn colunaDataCad;
        private System.Windows.Forms.DataGridViewTextBoxColumn colunaAtivo;
        private System.Windows.Forms.GroupBox gpBoxImg;
        private MetroFramework.Controls.MetroButton btnInserirImg;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroButton btnInserir;
        private MetroFramework.Controls.MetroTextBox txtIdPesq;
        private MetroFramework.Controls.MetroLabel lbIdPesq;
        private MetroFramework.Controls.MetroTextBox txtCpfPsq;
        private MetroFramework.Controls.MetroLabel lbCpfPesq;
        private System.Windows.Forms.Button btnPesqCpf;
        private System.Windows.Forms.Button btnPesqId;
        private System.Windows.Forms.GroupBox gpBoxPesq;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.OpenFileDialog FileDialogImg;
        private System.Windows.Forms.PictureBox picImgCliente;
    }
}

