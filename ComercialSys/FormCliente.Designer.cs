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
            this.colunaAtivo = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chkAtivo = new System.Windows.Forms.CheckBox();
            this.btnInserirImg = new MetroFramework.Controls.MetroButton();
            this.gpBoxImg = new System.Windows.Forms.GroupBox();
            this.picImgCliente = new System.Windows.Forms.PictureBox();
            this.btnEditar = new MetroFramework.Controls.MetroButton();
            this.btnInserir = new MetroFramework.Controls.MetroButton();
            this.txtIdPesq = new MetroFramework.Controls.MetroTextBox();
            this.lbIdPesq = new MetroFramework.Controls.MetroLabel();
            this.txtCpfPsq = new MetroFramework.Controls.MetroTextBox();
            this.lbCpfPesq = new MetroFramework.Controls.MetroLabel();
            this.gpBoxPesq = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.FileDialogImg = new System.Windows.Forms.OpenFileDialog();
            this.btnListar = new MetroFramework.Controls.MetroButton();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.txtPesqNome = new MetroFramework.Controls.MetroTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.GridCliente)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.gpBoxImg.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picImgCliente)).BeginInit();
            this.gpBoxPesq.SuspendLayout();
            this.groupBox1.SuspendLayout();
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
            this.txtId.Location = new System.Drawing.Point(7, 55);
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
            this.txtNome.CustomButton.Location = new System.Drawing.Point(321, 1);
            this.txtNome.CustomButton.Margin = new System.Windows.Forms.Padding(4);
            this.txtNome.CustomButton.Name = "";
            this.txtNome.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtNome.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNome.CustomButton.TabIndex = 1;
            this.txtNome.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNome.CustomButton.UseSelectable = true;
            this.txtNome.CustomButton.Visible = false;
            this.txtNome.Lines = new string[0];
            this.txtNome.Location = new System.Drawing.Point(108, 55);
            this.txtNome.Margin = new System.Windows.Forms.Padding(4);
            this.txtNome.MaxLength = 60;
            this.txtNome.Name = "txtNome";
            this.txtNome.PasswordChar = '\0';
            this.txtNome.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNome.SelectedText = "";
            this.txtNome.SelectionLength = 0;
            this.txtNome.SelectionStart = 0;
            this.txtNome.ShortcutsEnabled = true;
            this.txtNome.Size = new System.Drawing.Size(345, 25);
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
            this.txtCpf.Location = new System.Drawing.Point(297, 119);
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
            this.txtEmail.CustomButton.Location = new System.Drawing.Point(241, 1);
            this.txtEmail.CustomButton.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmail.CustomButton.Name = "";
            this.txtEmail.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtEmail.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtEmail.CustomButton.TabIndex = 1;
            this.txtEmail.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtEmail.CustomButton.UseSelectable = true;
            this.txtEmail.CustomButton.Visible = false;
            this.txtEmail.Lines = new string[0];
            this.txtEmail.Location = new System.Drawing.Point(7, 119);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmail.MaxLength = 60;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PasswordChar = '\0';
            this.txtEmail.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtEmail.SelectedText = "";
            this.txtEmail.SelectionLength = 0;
            this.txtEmail.SelectionStart = 0;
            this.txtEmail.ShortcutsEnabled = true;
            this.txtEmail.Size = new System.Drawing.Size(265, 25);
            this.txtEmail.TabIndex = 3;
            this.txtEmail.UseSelectable = true;
            this.txtEmail.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtEmail.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.Location = new System.Drawing.Point(7, 31);
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
            this.metroLabel2.Location = new System.Drawing.Point(108, 31);
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
            this.metroLabel3.Location = new System.Drawing.Point(297, 95);
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
            this.metroLabel4.Location = new System.Drawing.Point(7, 95);
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
            this.GridCliente.Location = new System.Drawing.Point(7, 26);
            this.GridCliente.Name = "GridCliente";
            this.GridCliente.ReadOnly = true;
            this.GridCliente.RowHeadersWidth = 51;
            this.GridCliente.Size = new System.Drawing.Size(820, 298);
            this.GridCliente.TabIndex = 10;
            this.GridCliente.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridCliente_CellDoubleClick);
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
            // colunaCpf
            // 
            this.colunaCpf.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colunaCpf.Frozen = true;
            this.colunaCpf.HeaderText = "CPF";
            this.colunaCpf.MinimumWidth = 6;
            this.colunaCpf.Name = "colunaCpf";
            this.colunaCpf.ReadOnly = true;
            this.colunaCpf.Width = 128;
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
            // colunaDataCad
            // 
            this.colunaDataCad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colunaDataCad.Frozen = true;
            this.colunaDataCad.HeaderText = "DataCad";
            this.colunaDataCad.MinimumWidth = 6;
            this.colunaDataCad.Name = "colunaDataCad";
            this.colunaDataCad.ReadOnly = true;
            this.colunaDataCad.Width = 128;
            // 
            // colunaAtivo
            // 
            this.colunaAtivo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colunaAtivo.Frozen = true;
            this.colunaAtivo.HeaderText = "Ativo";
            this.colunaAtivo.MinimumWidth = 6;
            this.colunaAtivo.Name = "colunaAtivo";
            this.colunaAtivo.ReadOnly = true;
            this.colunaAtivo.Width = 128;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chkAtivo);
            this.groupBox2.Controls.Add(this.btnInserirImg);
            this.groupBox2.Controls.Add(this.gpBoxImg);
            this.groupBox2.Controls.Add(this.txtCpf);
            this.groupBox2.Controls.Add(this.txtId);
            this.groupBox2.Controls.Add(this.txtNome);
            this.groupBox2.Controls.Add(this.txtEmail);
            this.groupBox2.Controls.Add(this.metroLabel1);
            this.groupBox2.Controls.Add(this.metroLabel4);
            this.groupBox2.Controls.Add(this.metroLabel2);
            this.groupBox2.Controls.Add(this.metroLabel3);
            this.groupBox2.Location = new System.Drawing.Point(29, 68);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(986, 197);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cadastrar";
            // 
            // chkAtivo
            // 
            this.chkAtivo.AutoSize = true;
            this.chkAtivo.Location = new System.Drawing.Point(503, 55);
            this.chkAtivo.Margin = new System.Windows.Forms.Padding(4);
            this.chkAtivo.Name = "chkAtivo";
            this.chkAtivo.Size = new System.Drawing.Size(77, 25);
            this.chkAtivo.TabIndex = 17;
            this.chkAtivo.Text = "Ativo";
            this.chkAtivo.UseVisualStyleBackColor = true;
            // 
            // btnInserirImg
            // 
            this.btnInserirImg.Location = new System.Drawing.Point(720, 159);
            this.btnInserirImg.Margin = new System.Windows.Forms.Padding(4);
            this.btnInserirImg.Name = "btnInserirImg";
            this.btnInserirImg.Size = new System.Drawing.Size(147, 23);
            this.btnInserirImg.TabIndex = 16;
            this.btnInserirImg.Text = "Inserir Imagem";
            this.btnInserirImg.UseSelectable = true;
            this.btnInserirImg.Click += new System.EventHandler(this.btnInserirImg_Click);
            // 
            // gpBoxImg
            // 
            this.gpBoxImg.Controls.Add(this.picImgCliente);
            this.gpBoxImg.Location = new System.Drawing.Point(720, 26);
            this.gpBoxImg.Name = "gpBoxImg";
            this.gpBoxImg.Size = new System.Drawing.Size(147, 132);
            this.gpBoxImg.TabIndex = 16;
            this.gpBoxImg.TabStop = false;
            this.gpBoxImg.Text = "Imagem";
            // 
            // picImgCliente
            // 
            this.picImgCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picImgCliente.Location = new System.Drawing.Point(6, 26);
            this.picImgCliente.Name = "picImgCliente";
            this.picImgCliente.Size = new System.Drawing.Size(135, 100);
            this.picImgCliente.TabIndex = 18;
            this.picImgCliente.TabStop = false;
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(374, 272);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(120, 32);
            this.btnEditar.TabIndex = 17;
            this.btnEditar.Text = "&Editar";
            this.btnEditar.UseSelectable = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnInserir
            // 
            this.btnInserir.Location = new System.Drawing.Point(517, 272);
            this.btnInserir.Margin = new System.Windows.Forms.Padding(4);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(120, 32);
            this.btnInserir.TabIndex = 8;
            this.btnInserir.Text = "&Inserir";
            this.btnInserir.UseSelectable = true;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // txtIdPesq
            // 
            // 
            // 
            // 
            this.txtIdPesq.CustomButton.Image = null;
            this.txtIdPesq.CustomButton.Location = new System.Drawing.Point(35, 1);
            this.txtIdPesq.CustomButton.Margin = new System.Windows.Forms.Padding(4);
            this.txtIdPesq.CustomButton.Name = "";
            this.txtIdPesq.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtIdPesq.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtIdPesq.CustomButton.TabIndex = 1;
            this.txtIdPesq.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtIdPesq.CustomButton.UseSelectable = true;
            this.txtIdPesq.CustomButton.Visible = false;
            this.txtIdPesq.Lines = new string[0];
            this.txtIdPesq.Location = new System.Drawing.Point(19, 58);
            this.txtIdPesq.Margin = new System.Windows.Forms.Padding(4);
            this.txtIdPesq.MaxLength = 60;
            this.txtIdPesq.Name = "txtIdPesq";
            this.txtIdPesq.PasswordChar = '\0';
            this.txtIdPesq.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtIdPesq.SelectedText = "";
            this.txtIdPesq.SelectionLength = 0;
            this.txtIdPesq.SelectionStart = 0;
            this.txtIdPesq.ShortcutsEnabled = true;
            this.txtIdPesq.Size = new System.Drawing.Size(59, 25);
            this.txtIdPesq.TabIndex = 12;
            this.txtIdPesq.UseSelectable = true;
            this.txtIdPesq.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtIdPesq.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtIdPesq.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtIdPesq_KeyUp);
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
            this.txtCpfPsq.CustomButton.Location = new System.Drawing.Point(75, 1);
            this.txtCpfPsq.CustomButton.Margin = new System.Windows.Forms.Padding(4);
            this.txtCpfPsq.CustomButton.Name = "";
            this.txtCpfPsq.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtCpfPsq.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCpfPsq.CustomButton.TabIndex = 1;
            this.txtCpfPsq.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCpfPsq.CustomButton.UseSelectable = true;
            this.txtCpfPsq.CustomButton.Visible = false;
            this.txtCpfPsq.Lines = new string[0];
            this.txtCpfPsq.Location = new System.Drawing.Point(19, 135);
            this.txtCpfPsq.Margin = new System.Windows.Forms.Padding(4);
            this.txtCpfPsq.MaxLength = 60;
            this.txtCpfPsq.Name = "txtCpfPsq";
            this.txtCpfPsq.PasswordChar = '\0';
            this.txtCpfPsq.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCpfPsq.SelectedText = "";
            this.txtCpfPsq.SelectionLength = 0;
            this.txtCpfPsq.SelectionStart = 0;
            this.txtCpfPsq.ShortcutsEnabled = true;
            this.txtCpfPsq.Size = new System.Drawing.Size(99, 25);
            this.txtCpfPsq.TabIndex = 14;
            this.txtCpfPsq.UseSelectable = true;
            this.txtCpfPsq.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCpfPsq.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtCpfPsq.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtCpfPsq_KeyUp);
            // 
            // lbCpfPesq
            // 
            this.lbCpfPesq.AutoSize = true;
            this.lbCpfPesq.Location = new System.Drawing.Point(19, 108);
            this.lbCpfPesq.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbCpfPesq.Name = "lbCpfPesq";
            this.lbCpfPesq.Size = new System.Drawing.Size(33, 20);
            this.lbCpfPesq.TabIndex = 15;
            this.lbCpfPesq.Text = "CPF";
            // 
            // gpBoxPesq
            // 
            this.gpBoxPesq.Controls.Add(this.metroLabel5);
            this.gpBoxPesq.Controls.Add(this.txtPesqNome);
            this.gpBoxPesq.Controls.Add(this.lbCpfPesq);
            this.gpBoxPesq.Controls.Add(this.txtCpfPsq);
            this.gpBoxPesq.Controls.Add(this.lbIdPesq);
            this.gpBoxPesq.Controls.Add(this.txtIdPesq);
            this.gpBoxPesq.Location = new System.Drawing.Point(868, 313);
            this.gpBoxPesq.Name = "gpBoxPesq";
            this.gpBoxPesq.Size = new System.Drawing.Size(147, 253);
            this.gpBoxPesq.TabIndex = 14;
            this.gpBoxPesq.TabStop = false;
            this.gpBoxPesq.Text = "Pesquisar";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.GridCliente);
            this.groupBox1.Location = new System.Drawing.Point(29, 313);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(833, 330);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Clientes";
            // 
            // FileDialogImg
            // 
            this.FileDialogImg.FileName = "OpenFileDialog";
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(660, 272);
            this.btnListar.Margin = new System.Windows.Forms.Padding(4);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(120, 32);
            this.btnListar.TabIndex = 22;
            this.btnListar.Text = "Listar";
            this.btnListar.UseSelectable = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click_1);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(19, 182);
            this.metroLabel5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
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
            this.txtPesqNome.CustomButton.Location = new System.Drawing.Point(75, 1);
            this.txtPesqNome.CustomButton.Margin = new System.Windows.Forms.Padding(4);
            this.txtPesqNome.CustomButton.Name = "";
            this.txtPesqNome.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtPesqNome.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPesqNome.CustomButton.TabIndex = 1;
            this.txtPesqNome.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPesqNome.CustomButton.UseSelectable = true;
            this.txtPesqNome.CustomButton.Visible = false;
            this.txtPesqNome.Lines = new string[0];
            this.txtPesqNome.Location = new System.Drawing.Point(19, 212);
            this.txtPesqNome.Margin = new System.Windows.Forms.Padding(4);
            this.txtPesqNome.MaxLength = 60;
            this.txtPesqNome.Name = "txtPesqNome";
            this.txtPesqNome.PasswordChar = '\0';
            this.txtPesqNome.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPesqNome.SelectedText = "";
            this.txtPesqNome.SelectionLength = 0;
            this.txtPesqNome.SelectionStart = 0;
            this.txtPesqNome.ShortcutsEnabled = true;
            this.txtPesqNome.Size = new System.Drawing.Size(99, 25);
            this.txtPesqNome.TabIndex = 18;
            this.txtPesqNome.UseSelectable = true;
            this.txtPesqNome.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPesqNome.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtPesqNome.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtPesqNome_KeyUp);
            // 
            // FormCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1041, 666);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.gpBoxPesq);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnInserir);
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
            ((System.ComponentModel.ISupportInitialize)(this.picImgCliente)).EndInit();
            this.gpBoxPesq.ResumeLayout(false);
            this.gpBoxPesq.PerformLayout();
            this.groupBox1.ResumeLayout(false);
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
        private System.Windows.Forms.GroupBox gpBoxImg;
        private MetroFramework.Controls.MetroButton btnInserirImg;
        private MetroFramework.Controls.MetroButton btnEditar;
        private MetroFramework.Controls.MetroButton btnInserir;
        private MetroFramework.Controls.MetroTextBox txtIdPesq;
        private MetroFramework.Controls.MetroLabel lbIdPesq;
        private MetroFramework.Controls.MetroTextBox txtCpfPsq;
        private MetroFramework.Controls.MetroLabel lbCpfPesq;
        private System.Windows.Forms.GroupBox gpBoxPesq;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.OpenFileDialog FileDialogImg;
        private System.Windows.Forms.PictureBox picImgCliente;
        private MetroFramework.Controls.MetroButton btnListar;
        private System.Windows.Forms.CheckBox chkAtivo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colunaId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colunaNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn colunaCpf;
        private System.Windows.Forms.DataGridViewTextBoxColumn colunaEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn colunaDataCad;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colunaAtivo;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroTextBox txtPesqNome;
    }
}

