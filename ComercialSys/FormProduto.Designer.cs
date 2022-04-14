namespace ComercialSys
{
    partial class FormProduto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormProduto));
            this.gpBoxCadastrar = new System.Windows.Forms.GroupBox();
            this.txtValor = new MetroFramework.Controls.MetroTextBox();
            this.lbValor = new MetroFramework.Controls.MetroLabel();
            this.txtDesconto = new MetroFramework.Controls.MetroTextBox();
            this.lbDesconto = new MetroFramework.Controls.MetroLabel();
            this.txtunidade = new MetroFramework.Controls.MetroTextBox();
            this.txtId = new MetroFramework.Controls.MetroTextBox();
            this.btnListar = new MetroFramework.Controls.MetroButton();
            this.txtNome = new MetroFramework.Controls.MetroTextBox();
            this.txtCodBar = new MetroFramework.Controls.MetroTextBox();
            this.btnInserir = new MetroFramework.Controls.MetroButton();
            this.lbId = new MetroFramework.Controls.MetroLabel();
            this.lbCodBar = new MetroFramework.Controls.MetroLabel();
            this.lbNome = new MetroFramework.Controls.MetroLabel();
            this.lbUnidade = new MetroFramework.Controls.MetroLabel();
            this.gpBoxPesq = new System.Windows.Forms.GroupBox();
            this.btnPesqCodBar = new System.Windows.Forms.Button();
            this.lbCodBarPesq = new MetroFramework.Controls.MetroLabel();
            this.txtCodBarPesq = new MetroFramework.Controls.MetroTextBox();
            this.btnPesqId = new System.Windows.Forms.Button();
            this.btnPesqValor = new System.Windows.Forms.Button();
            this.lbValorPesq = new MetroFramework.Controls.MetroLabel();
            this.txtValorPesq = new MetroFramework.Controls.MetroTextBox();
            this.lbIdPesq = new MetroFramework.Controls.MetroLabel();
            this.txtIdPesq = new MetroFramework.Controls.MetroTextBox();
            this.GridProdutos = new System.Windows.Forms.DataGridView();
            this.colunaId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colunaNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colunaUnidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colunaCodBar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colunaDesconto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colunaValor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColunaDescontinuado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gpBoxCadastrar.SuspendLayout();
            this.gpBoxPesq.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridProdutos)).BeginInit();
            this.SuspendLayout();
            // 
            // gpBoxCadastrar
            // 
            this.gpBoxCadastrar.Controls.Add(this.txtValor);
            this.gpBoxCadastrar.Controls.Add(this.lbValor);
            this.gpBoxCadastrar.Controls.Add(this.txtDesconto);
            this.gpBoxCadastrar.Controls.Add(this.lbDesconto);
            this.gpBoxCadastrar.Controls.Add(this.txtunidade);
            this.gpBoxCadastrar.Controls.Add(this.txtId);
            this.gpBoxCadastrar.Controls.Add(this.btnListar);
            this.gpBoxCadastrar.Controls.Add(this.txtNome);
            this.gpBoxCadastrar.Controls.Add(this.txtCodBar);
            this.gpBoxCadastrar.Controls.Add(this.btnInserir);
            this.gpBoxCadastrar.Controls.Add(this.lbId);
            this.gpBoxCadastrar.Controls.Add(this.lbCodBar);
            this.gpBoxCadastrar.Controls.Add(this.lbNome);
            this.gpBoxCadastrar.Controls.Add(this.lbUnidade);
            this.gpBoxCadastrar.Location = new System.Drawing.Point(47, 110);
            this.gpBoxCadastrar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gpBoxCadastrar.Name = "gpBoxCadastrar";
            this.gpBoxCadastrar.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gpBoxCadastrar.Size = new System.Drawing.Size(512, 484);
            this.gpBoxCadastrar.TabIndex = 18;
            this.gpBoxCadastrar.TabStop = false;
            this.gpBoxCadastrar.Text = "Cadastrar";
            // 
            // txtValor
            // 
            // 
            // 
            // 
            this.txtValor.CustomButton.Image = null;
            this.txtValor.CustomButton.Location = new System.Drawing.Point(319, 1);
            this.txtValor.CustomButton.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtValor.CustomButton.Name = "";
            this.txtValor.CustomButton.Size = new System.Drawing.Size(39, 36);
            this.txtValor.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtValor.CustomButton.TabIndex = 1;
            this.txtValor.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtValor.CustomButton.UseSelectable = true;
            this.txtValor.CustomButton.Visible = false;
            this.txtValor.Lines = new string[0];
            this.txtValor.Location = new System.Drawing.Point(153, 342);
            this.txtValor.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtValor.MaxLength = 60;
            this.txtValor.Name = "txtValor";
            this.txtValor.PasswordChar = '\0';
            this.txtValor.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtValor.SelectedText = "";
            this.txtValor.SelectionLength = 0;
            this.txtValor.SelectionStart = 0;
            this.txtValor.ShortcutsEnabled = true;
            this.txtValor.Size = new System.Drawing.Size(269, 31);
            this.txtValor.TabIndex = 14;
            this.txtValor.UseSelectable = true;
            this.txtValor.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtValor.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lbValor
            // 
            this.lbValor.AutoSize = true;
            this.lbValor.Location = new System.Drawing.Point(23, 350);
            this.lbValor.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbValor.Name = "lbValor";
            this.lbValor.Size = new System.Drawing.Size(39, 20);
            this.lbValor.TabIndex = 15;
            this.lbValor.Text = "Valor";
            // 
            // txtDesconto
            // 
            // 
            // 
            // 
            this.txtDesconto.CustomButton.Image = null;
            this.txtDesconto.CustomButton.Location = new System.Drawing.Point(319, 1);
            this.txtDesconto.CustomButton.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtDesconto.CustomButton.Name = "";
            this.txtDesconto.CustomButton.Size = new System.Drawing.Size(39, 36);
            this.txtDesconto.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDesconto.CustomButton.TabIndex = 1;
            this.txtDesconto.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDesconto.CustomButton.UseSelectable = true;
            this.txtDesconto.CustomButton.Visible = false;
            this.txtDesconto.Lines = new string[0];
            this.txtDesconto.Location = new System.Drawing.Point(153, 288);
            this.txtDesconto.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtDesconto.MaxLength = 60;
            this.txtDesconto.Name = "txtDesconto";
            this.txtDesconto.PasswordChar = '\0';
            this.txtDesconto.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDesconto.SelectedText = "";
            this.txtDesconto.SelectionLength = 0;
            this.txtDesconto.SelectionStart = 0;
            this.txtDesconto.ShortcutsEnabled = true;
            this.txtDesconto.Size = new System.Drawing.Size(269, 31);
            this.txtDesconto.TabIndex = 12;
            this.txtDesconto.UseSelectable = true;
            this.txtDesconto.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDesconto.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lbDesconto
            // 
            this.lbDesconto.AutoSize = true;
            this.lbDesconto.Location = new System.Drawing.Point(23, 295);
            this.lbDesconto.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbDesconto.Name = "lbDesconto";
            this.lbDesconto.Size = new System.Drawing.Size(68, 20);
            this.lbDesconto.TabIndex = 13;
            this.lbDesconto.Text = "Desconto";
            // 
            // txtunidade
            // 
            // 
            // 
            // 
            this.txtunidade.CustomButton.Image = null;
            this.txtunidade.CustomButton.Location = new System.Drawing.Point(319, 1);
            this.txtunidade.CustomButton.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtunidade.CustomButton.Name = "";
            this.txtunidade.CustomButton.Size = new System.Drawing.Size(39, 36);
            this.txtunidade.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtunidade.CustomButton.TabIndex = 1;
            this.txtunidade.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtunidade.CustomButton.UseSelectable = true;
            this.txtunidade.CustomButton.Visible = false;
            this.txtunidade.Lines = new string[0];
            this.txtunidade.Location = new System.Drawing.Point(153, 167);
            this.txtunidade.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtunidade.MaxLength = 60;
            this.txtunidade.Name = "txtunidade";
            this.txtunidade.PasswordChar = '\0';
            this.txtunidade.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtunidade.SelectedText = "";
            this.txtunidade.SelectionLength = 0;
            this.txtunidade.SelectionStart = 0;
            this.txtunidade.ShortcutsEnabled = true;
            this.txtunidade.Size = new System.Drawing.Size(269, 31);
            this.txtunidade.TabIndex = 2;
            this.txtunidade.UseSelectable = true;
            this.txtunidade.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtunidade.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtId
            // 
            // 
            // 
            // 
            this.txtId.CustomButton.Image = null;
            this.txtId.CustomButton.Location = new System.Drawing.Point(89, 1);
            this.txtId.CustomButton.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtId.CustomButton.Name = "";
            this.txtId.CustomButton.Size = new System.Drawing.Size(39, 36);
            this.txtId.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtId.CustomButton.TabIndex = 1;
            this.txtId.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtId.CustomButton.UseSelectable = true;
            this.txtId.CustomButton.Visible = false;
            this.txtId.Enabled = false;
            this.txtId.Lines = new string[0];
            this.txtId.Location = new System.Drawing.Point(153, 52);
            this.txtId.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtId.MaxLength = 32767;
            this.txtId.Name = "txtId";
            this.txtId.PasswordChar = '\0';
            this.txtId.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtId.SelectedText = "";
            this.txtId.SelectionLength = 0;
            this.txtId.SelectionStart = 0;
            this.txtId.ShortcutsEnabled = true;
            this.txtId.Size = new System.Drawing.Size(97, 31);
            this.txtId.TabIndex = 1;
            this.txtId.UseSelectable = true;
            this.txtId.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtId.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(277, 407);
            this.btnListar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(215, 47);
            this.btnListar.TabIndex = 11;
            this.btnListar.Text = "Listar";
            this.btnListar.UseSelectable = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // txtNome
            // 
            // 
            // 
            // 
            this.txtNome.CustomButton.Image = null;
            this.txtNome.CustomButton.Location = new System.Drawing.Point(412, 1);
            this.txtNome.CustomButton.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtNome.CustomButton.Name = "";
            this.txtNome.CustomButton.Size = new System.Drawing.Size(39, 36);
            this.txtNome.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNome.CustomButton.TabIndex = 1;
            this.txtNome.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNome.CustomButton.UseSelectable = true;
            this.txtNome.CustomButton.Visible = false;
            this.txtNome.Lines = new string[0];
            this.txtNome.Location = new System.Drawing.Point(153, 107);
            this.txtNome.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtNome.MaxLength = 60;
            this.txtNome.Name = "txtNome";
            this.txtNome.PasswordChar = '\0';
            this.txtNome.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNome.SelectedText = "";
            this.txtNome.SelectionLength = 0;
            this.txtNome.SelectionStart = 0;
            this.txtNome.ShortcutsEnabled = true;
            this.txtNome.Size = new System.Drawing.Size(339, 31);
            this.txtNome.TabIndex = 1;
            this.txtNome.UseSelectable = true;
            this.txtNome.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNome.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtCodBar
            // 
            // 
            // 
            // 
            this.txtCodBar.CustomButton.Image = null;
            this.txtCodBar.CustomButton.Location = new System.Drawing.Point(319, 1);
            this.txtCodBar.CustomButton.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtCodBar.CustomButton.Name = "";
            this.txtCodBar.CustomButton.Size = new System.Drawing.Size(39, 36);
            this.txtCodBar.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCodBar.CustomButton.TabIndex = 1;
            this.txtCodBar.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCodBar.CustomButton.UseSelectable = true;
            this.txtCodBar.CustomButton.Visible = false;
            this.txtCodBar.Lines = new string[0];
            this.txtCodBar.Location = new System.Drawing.Point(153, 229);
            this.txtCodBar.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtCodBar.MaxLength = 13;
            this.txtCodBar.Name = "txtCodBar";
            this.txtCodBar.PasswordChar = '\0';
            this.txtCodBar.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCodBar.SelectedText = "";
            this.txtCodBar.SelectionLength = 0;
            this.txtCodBar.SelectionStart = 0;
            this.txtCodBar.ShortcutsEnabled = true;
            this.txtCodBar.Size = new System.Drawing.Size(269, 31);
            this.txtCodBar.TabIndex = 3;
            this.txtCodBar.UseSelectable = true;
            this.txtCodBar.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCodBar.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnInserir
            // 
            this.btnInserir.Location = new System.Drawing.Point(21, 407);
            this.btnInserir.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(215, 47);
            this.btnInserir.TabIndex = 8;
            this.btnInserir.Text = "&Inserir";
            this.btnInserir.UseSelectable = true;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // lbId
            // 
            this.lbId.AutoSize = true;
            this.lbId.Location = new System.Drawing.Point(21, 52);
            this.lbId.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbId.Name = "lbId";
            this.lbId.Size = new System.Drawing.Size(22, 20);
            this.lbId.TabIndex = 4;
            this.lbId.Text = "ID";
            // 
            // lbCodBar
            // 
            this.lbCodBar.AutoSize = true;
            this.lbCodBar.Location = new System.Drawing.Point(21, 236);
            this.lbCodBar.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbCodBar.Name = "lbCodBar";
            this.lbCodBar.Size = new System.Drawing.Size(79, 20);
            this.lbCodBar.TabIndex = 7;
            this.lbCodBar.Text = "Cod. Barras";
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.Location = new System.Drawing.Point(21, 114);
            this.lbNome.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(48, 20);
            this.lbNome.TabIndex = 5;
            this.lbNome.Text = "Nome";
            // 
            // lbUnidade
            // 
            this.lbUnidade.AutoSize = true;
            this.lbUnidade.Location = new System.Drawing.Point(21, 175);
            this.lbUnidade.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbUnidade.Name = "lbUnidade";
            this.lbUnidade.Size = new System.Drawing.Size(61, 20);
            this.lbUnidade.TabIndex = 6;
            this.lbUnidade.Text = "Unidade";
            // 
            // gpBoxPesq
            // 
            this.gpBoxPesq.Controls.Add(this.btnPesqCodBar);
            this.gpBoxPesq.Controls.Add(this.lbCodBarPesq);
            this.gpBoxPesq.Controls.Add(this.txtCodBarPesq);
            this.gpBoxPesq.Controls.Add(this.btnPesqId);
            this.gpBoxPesq.Controls.Add(this.btnPesqValor);
            this.gpBoxPesq.Controls.Add(this.lbValorPesq);
            this.gpBoxPesq.Controls.Add(this.txtValorPesq);
            this.gpBoxPesq.Controls.Add(this.lbIdPesq);
            this.gpBoxPesq.Controls.Add(this.txtIdPesq);
            this.gpBoxPesq.Location = new System.Drawing.Point(624, 57);
            this.gpBoxPesq.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gpBoxPesq.Name = "gpBoxPesq";
            this.gpBoxPesq.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gpBoxPesq.Size = new System.Drawing.Size(937, 121);
            this.gpBoxPesq.TabIndex = 17;
            this.gpBoxPesq.TabStop = false;
            this.gpBoxPesq.Text = "Pesquisar";
            // 
            // btnPesqCodBar
            // 
            this.btnPesqCodBar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPesqCodBar.BackgroundImage")));
            this.btnPesqCodBar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPesqCodBar.FlatAppearance.BorderSize = 0;
            this.btnPesqCodBar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesqCodBar.Location = new System.Drawing.Point(575, 28);
            this.btnPesqCodBar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPesqCodBar.Name = "btnPesqCodBar";
            this.btnPesqCodBar.Size = new System.Drawing.Size(59, 31);
            this.btnPesqCodBar.TabIndex = 20;
            this.btnPesqCodBar.UseVisualStyleBackColor = true;
            this.btnPesqCodBar.Click += new System.EventHandler(this.btnPesqCodBar_Click);
            // 
            // lbCodBarPesq
            // 
            this.lbCodBarPesq.AutoSize = true;
            this.lbCodBarPesq.Location = new System.Drawing.Point(339, 34);
            this.lbCodBarPesq.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbCodBarPesq.Name = "lbCodBarPesq";
            this.lbCodBarPesq.Size = new System.Drawing.Size(79, 20);
            this.lbCodBarPesq.TabIndex = 19;
            this.lbCodBarPesq.Text = "Cod. Barras";
            // 
            // txtCodBarPesq
            // 
            // 
            // 
            // 
            this.txtCodBarPesq.CustomButton.Image = null;
            this.txtCodBarPesq.CustomButton.Location = new System.Drawing.Point(109, 1);
            this.txtCodBarPesq.CustomButton.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtCodBarPesq.CustomButton.Name = "";
            this.txtCodBarPesq.CustomButton.Size = new System.Drawing.Size(39, 36);
            this.txtCodBarPesq.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCodBarPesq.CustomButton.TabIndex = 1;
            this.txtCodBarPesq.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCodBarPesq.CustomButton.UseSelectable = true;
            this.txtCodBarPesq.CustomButton.Visible = false;
            this.txtCodBarPesq.Lines = new string[0];
            this.txtCodBarPesq.Location = new System.Drawing.Point(453, 28);
            this.txtCodBarPesq.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtCodBarPesq.MaxLength = 60;
            this.txtCodBarPesq.Name = "txtCodBarPesq";
            this.txtCodBarPesq.PasswordChar = '\0';
            this.txtCodBarPesq.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCodBarPesq.SelectedText = "";
            this.txtCodBarPesq.SelectionLength = 0;
            this.txtCodBarPesq.SelectionStart = 0;
            this.txtCodBarPesq.ShortcutsEnabled = true;
            this.txtCodBarPesq.Size = new System.Drawing.Size(112, 31);
            this.txtCodBarPesq.TabIndex = 18;
            this.txtCodBarPesq.UseSelectable = true;
            this.txtCodBarPesq.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCodBarPesq.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnPesqId
            // 
            this.btnPesqId.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPesqId.BackgroundImage")));
            this.btnPesqId.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPesqId.FlatAppearance.BorderSize = 0;
            this.btnPesqId.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesqId.Location = new System.Drawing.Point(231, 30);
            this.btnPesqId.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPesqId.Name = "btnPesqId";
            this.btnPesqId.Size = new System.Drawing.Size(59, 31);
            this.btnPesqId.TabIndex = 17;
            this.btnPesqId.UseVisualStyleBackColor = true;
            this.btnPesqId.Click += new System.EventHandler(this.btnPesqId_Click);
            // 
            // btnPesqValor
            // 
            this.btnPesqValor.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPesqValor.BackgroundImage")));
            this.btnPesqValor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPesqValor.FlatAppearance.BorderSize = 0;
            this.btnPesqValor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesqValor.Location = new System.Drawing.Point(231, 70);
            this.btnPesqValor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPesqValor.Name = "btnPesqValor";
            this.btnPesqValor.Size = new System.Drawing.Size(59, 31);
            this.btnPesqValor.TabIndex = 16;
            this.btnPesqValor.UseVisualStyleBackColor = true;
            this.btnPesqValor.Click += new System.EventHandler(this.btnPesqValor_Click);
            // 
            // lbValorPesq
            // 
            this.lbValorPesq.AutoSize = true;
            this.lbValorPesq.Location = new System.Drawing.Point(21, 76);
            this.lbValorPesq.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbValorPesq.Name = "lbValorPesq";
            this.lbValorPesq.Size = new System.Drawing.Size(39, 20);
            this.lbValorPesq.TabIndex = 15;
            this.lbValorPesq.Text = "Valor";
            // 
            // txtValorPesq
            // 
            // 
            // 
            // 
            this.txtValorPesq.CustomButton.Image = null;
            this.txtValorPesq.CustomButton.Location = new System.Drawing.Point(109, 1);
            this.txtValorPesq.CustomButton.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtValorPesq.CustomButton.Name = "";
            this.txtValorPesq.CustomButton.Size = new System.Drawing.Size(39, 36);
            this.txtValorPesq.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtValorPesq.CustomButton.TabIndex = 1;
            this.txtValorPesq.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtValorPesq.CustomButton.UseSelectable = true;
            this.txtValorPesq.CustomButton.Visible = false;
            this.txtValorPesq.Lines = new string[0];
            this.txtValorPesq.Location = new System.Drawing.Point(109, 70);
            this.txtValorPesq.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtValorPesq.MaxLength = 60;
            this.txtValorPesq.Name = "txtValorPesq";
            this.txtValorPesq.PasswordChar = '\0';
            this.txtValorPesq.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtValorPesq.SelectedText = "";
            this.txtValorPesq.SelectionLength = 0;
            this.txtValorPesq.SelectionStart = 0;
            this.txtValorPesq.ShortcutsEnabled = true;
            this.txtValorPesq.Size = new System.Drawing.Size(112, 31);
            this.txtValorPesq.TabIndex = 14;
            this.txtValorPesq.UseSelectable = true;
            this.txtValorPesq.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtValorPesq.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lbIdPesq
            // 
            this.lbIdPesq.AutoSize = true;
            this.lbIdPesq.Location = new System.Drawing.Point(21, 36);
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
            this.txtIdPesq.CustomButton.Location = new System.Drawing.Point(109, 1);
            this.txtIdPesq.CustomButton.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtIdPesq.CustomButton.Name = "";
            this.txtIdPesq.CustomButton.Size = new System.Drawing.Size(39, 36);
            this.txtIdPesq.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtIdPesq.CustomButton.TabIndex = 1;
            this.txtIdPesq.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtIdPesq.CustomButton.UseSelectable = true;
            this.txtIdPesq.CustomButton.Visible = false;
            this.txtIdPesq.Lines = new string[0];
            this.txtIdPesq.Location = new System.Drawing.Point(109, 30);
            this.txtIdPesq.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtIdPesq.MaxLength = 60;
            this.txtIdPesq.Name = "txtIdPesq";
            this.txtIdPesq.PasswordChar = '\0';
            this.txtIdPesq.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtIdPesq.SelectedText = "";
            this.txtIdPesq.SelectionLength = 0;
            this.txtIdPesq.SelectionStart = 0;
            this.txtIdPesq.ShortcutsEnabled = true;
            this.txtIdPesq.Size = new System.Drawing.Size(112, 31);
            this.txtIdPesq.TabIndex = 12;
            this.txtIdPesq.UseSelectable = true;
            this.txtIdPesq.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtIdPesq.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // GridProdutos
            // 
            this.GridProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridProdutos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colunaId,
            this.colunaNome,
            this.colunaUnidade,
            this.colunaCodBar,
            this.colunaDesconto,
            this.colunaValor,
            this.ColunaDescontinuado});
            this.GridProdutos.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.GridProdutos.Location = new System.Drawing.Point(624, 177);
            this.GridProdutos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GridProdutos.Name = "GridProdutos";
            this.GridProdutos.ReadOnly = true;
            this.GridProdutos.RowHeadersWidth = 51;
            this.GridProdutos.Size = new System.Drawing.Size(937, 386);
            this.GridProdutos.TabIndex = 16;
            this.GridProdutos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridProdutos_CellDoubleClick);
            // 
            // colunaId
            // 
            this.colunaId.HeaderText = "Id";
            this.colunaId.MinimumWidth = 6;
            this.colunaId.Name = "colunaId";
            this.colunaId.ReadOnly = true;
            this.colunaId.Width = 125;
            // 
            // colunaNome
            // 
            this.colunaNome.HeaderText = "Nome";
            this.colunaNome.MinimumWidth = 6;
            this.colunaNome.Name = "colunaNome";
            this.colunaNome.ReadOnly = true;
            this.colunaNome.Width = 125;
            // 
            // colunaUnidade
            // 
            this.colunaUnidade.HeaderText = "Unidade";
            this.colunaUnidade.MinimumWidth = 6;
            this.colunaUnidade.Name = "colunaUnidade";
            this.colunaUnidade.ReadOnly = true;
            this.colunaUnidade.Width = 125;
            // 
            // colunaCodBar
            // 
            this.colunaCodBar.HeaderText = "Cod. Barras";
            this.colunaCodBar.MinimumWidth = 6;
            this.colunaCodBar.Name = "colunaCodBar";
            this.colunaCodBar.ReadOnly = true;
            this.colunaCodBar.Width = 125;
            // 
            // colunaDesconto
            // 
            this.colunaDesconto.HeaderText = "Desconto";
            this.colunaDesconto.MinimumWidth = 6;
            this.colunaDesconto.Name = "colunaDesconto";
            this.colunaDesconto.ReadOnly = true;
            this.colunaDesconto.Width = 125;
            // 
            // colunaValor
            // 
            this.colunaValor.HeaderText = "Valor";
            this.colunaValor.MinimumWidth = 6;
            this.colunaValor.Name = "colunaValor";
            this.colunaValor.ReadOnly = true;
            this.colunaValor.Width = 125;
            // 
            // ColunaDescontinuado
            // 
            this.ColunaDescontinuado.HeaderText = "Situação";
            this.ColunaDescontinuado.MinimumWidth = 6;
            this.ColunaDescontinuado.Name = "ColunaDescontinuado";
            this.ColunaDescontinuado.ReadOnly = true;
            this.ColunaDescontinuado.Width = 125;
            // 
            // FormProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1740, 822);
            this.Controls.Add(this.gpBoxCadastrar);
            this.Controls.Add(this.gpBoxPesq);
            this.Controls.Add(this.GridProdutos);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormProduto";
            this.Padding = new System.Windows.Forms.Padding(27, 74, 27, 25);
            this.Text = "Produto";
            this.Load += new System.EventHandler(this.FormProduto_Load);
            this.gpBoxCadastrar.ResumeLayout(false);
            this.gpBoxCadastrar.PerformLayout();
            this.gpBoxPesq.ResumeLayout(false);
            this.gpBoxPesq.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridProdutos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpBoxCadastrar;
        private MetroFramework.Controls.MetroTextBox txtunidade;
        private MetroFramework.Controls.MetroTextBox txtId;
        private MetroFramework.Controls.MetroButton btnListar;
        private MetroFramework.Controls.MetroTextBox txtNome;
        private MetroFramework.Controls.MetroTextBox txtCodBar;
        private MetroFramework.Controls.MetroButton btnInserir;
        private MetroFramework.Controls.MetroLabel lbId;
        private MetroFramework.Controls.MetroLabel lbCodBar;
        private MetroFramework.Controls.MetroLabel lbNome;
        private MetroFramework.Controls.MetroLabel lbUnidade;
        private System.Windows.Forms.GroupBox gpBoxPesq;
        private System.Windows.Forms.Button btnPesqId;
        private System.Windows.Forms.Button btnPesqValor;
        private MetroFramework.Controls.MetroLabel lbValorPesq;
        private MetroFramework.Controls.MetroTextBox txtValorPesq;
        private MetroFramework.Controls.MetroLabel lbIdPesq;
        private MetroFramework.Controls.MetroTextBox txtIdPesq;
        private System.Windows.Forms.DataGridView GridProdutos;
        private MetroFramework.Controls.MetroTextBox txtDesconto;
        private MetroFramework.Controls.MetroLabel lbDesconto;
        private MetroFramework.Controls.MetroTextBox txtValor;
        private MetroFramework.Controls.MetroLabel lbValor;
        private System.Windows.Forms.Button btnPesqCodBar;
        private MetroFramework.Controls.MetroLabel lbCodBarPesq;
        private MetroFramework.Controls.MetroTextBox txtCodBarPesq;
        private System.Windows.Forms.DataGridViewTextBoxColumn colunaId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colunaNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn colunaUnidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn colunaCodBar;
        private System.Windows.Forms.DataGridViewTextBoxColumn colunaDesconto;
        private System.Windows.Forms.DataGridViewTextBoxColumn colunaValor;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColunaDescontinuado;
    }
}