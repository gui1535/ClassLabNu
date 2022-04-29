namespace ComercialSys
{
    partial class ProdutoView
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
            this.gpBoxCadastrar = new System.Windows.Forms.GroupBox();
            this.chkDescontinuado = new System.Windows.Forms.CheckBox();
            this.btnDesbloquear = new System.Windows.Forms.Button();
            this.btnBloquear = new System.Windows.Forms.Button();
            this.txtValor = new MetroFramework.Controls.MetroTextBox();
            this.txtDesconto = new MetroFramework.Controls.MetroTextBox();
            this.txtunidade = new MetroFramework.Controls.MetroTextBox();
            this.txtId = new MetroFramework.Controls.MetroTextBox();
            this.txtNome = new MetroFramework.Controls.MetroTextBox();
            this.txtCodBar = new MetroFramework.Controls.MetroTextBox();
            this.btnListar = new MetroFramework.Controls.MetroButton();
            this.btnInserir = new MetroFramework.Controls.MetroButton();
            this.GridProdutos = new System.Windows.Forms.DataGridView();
            this.colunaId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colunaNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colunaUnidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colunaCodBar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colunaDesconto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colunaValor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColunaDescontinuado = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.txtIdPesq = new MetroFramework.Controls.MetroTextBox();
            this.txtValorPesq = new MetroFramework.Controls.MetroTextBox();
            this.txtCodBarPesq = new MetroFramework.Controls.MetroTextBox();
            this.gpBoxPesq = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnEditar = new MetroFramework.Controls.MetroButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.gpBoxCadastrar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridProdutos)).BeginInit();
            this.gpBoxPesq.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpBoxCadastrar
            // 
            this.gpBoxCadastrar.Controls.Add(this.label6);
            this.gpBoxCadastrar.Controls.Add(this.label5);
            this.gpBoxCadastrar.Controls.Add(this.label4);
            this.gpBoxCadastrar.Controls.Add(this.label3);
            this.gpBoxCadastrar.Controls.Add(this.label2);
            this.gpBoxCadastrar.Controls.Add(this.label1);
            this.gpBoxCadastrar.Controls.Add(this.chkDescontinuado);
            this.gpBoxCadastrar.Controls.Add(this.btnDesbloquear);
            this.gpBoxCadastrar.Controls.Add(this.btnBloquear);
            this.gpBoxCadastrar.Controls.Add(this.txtValor);
            this.gpBoxCadastrar.Controls.Add(this.txtDesconto);
            this.gpBoxCadastrar.Controls.Add(this.txtunidade);
            this.gpBoxCadastrar.Controls.Add(this.txtId);
            this.gpBoxCadastrar.Controls.Add(this.txtNome);
            this.gpBoxCadastrar.Controls.Add(this.txtCodBar);
            this.gpBoxCadastrar.Location = new System.Drawing.Point(24, 28);
            this.gpBoxCadastrar.Margin = new System.Windows.Forms.Padding(4);
            this.gpBoxCadastrar.Name = "gpBoxCadastrar";
            this.gpBoxCadastrar.Padding = new System.Windows.Forms.Padding(4);
            this.gpBoxCadastrar.Size = new System.Drawing.Size(683, 191);
            this.gpBoxCadastrar.TabIndex = 18;
            this.gpBoxCadastrar.TabStop = false;
            this.gpBoxCadastrar.Text = "Cadastrar";
            // 
            // chkDescontinuado
            // 
            this.chkDescontinuado.AutoSize = true;
            this.chkDescontinuado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkDescontinuado.Enabled = false;
            this.chkDescontinuado.Location = new System.Drawing.Point(536, 44);
            this.chkDescontinuado.Margin = new System.Windows.Forms.Padding(4);
            this.chkDescontinuado.Name = "chkDescontinuado";
            this.chkDescontinuado.Size = new System.Drawing.Size(92, 20);
            this.chkDescontinuado.TabIndex = 30;
            this.chkDescontinuado.Text = "Continuado";
            this.chkDescontinuado.UseVisualStyleBackColor = true;
            this.chkDescontinuado.Click += new System.EventHandler(this.chkDescontinuado_click);
            // 
            // btnDesbloquear
            // 
            this.btnDesbloquear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDesbloquear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDesbloquear.FlatAppearance.BorderSize = 0;
            this.btnDesbloquear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDesbloquear.Location = new System.Drawing.Point(590, 110);
            this.btnDesbloquear.Name = "btnDesbloquear";
            this.btnDesbloquear.Size = new System.Drawing.Size(44, 49);
            this.btnDesbloquear.TabIndex = 28;
            this.btnDesbloquear.UseVisualStyleBackColor = true;
            this.btnDesbloquear.Click += new System.EventHandler(this.btnDesbloquear_Click);
            // 
            // btnBloquear
            // 
            this.btnBloquear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBloquear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBloquear.FlatAppearance.BorderSize = 0;
            this.btnBloquear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBloquear.Location = new System.Drawing.Point(590, 110);
            this.btnBloquear.Name = "btnBloquear";
            this.btnBloquear.Size = new System.Drawing.Size(44, 49);
            this.btnBloquear.TabIndex = 29;
            this.btnBloquear.UseVisualStyleBackColor = true;
            this.btnBloquear.Click += new System.EventHandler(this.btnBloquear_Click);
            // 
            // txtValor
            // 
            // 
            // 
            // 
            this.txtValor.CustomButton.Image = null;
            this.txtValor.CustomButton.Location = new System.Drawing.Point(125, 1);
            this.txtValor.CustomButton.Margin = new System.Windows.Forms.Padding(5);
            this.txtValor.CustomButton.Name = "";
            this.txtValor.CustomButton.Size = new System.Drawing.Size(31, 31);
            this.txtValor.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtValor.CustomButton.TabIndex = 1;
            this.txtValor.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtValor.CustomButton.UseSelectable = true;
            this.txtValor.CustomButton.Visible = false;
            this.txtValor.Enabled = false;
            this.txtValor.Lines = new string[] {
        "0"};
            this.txtValor.Location = new System.Drawing.Point(370, 44);
            this.txtValor.Margin = new System.Windows.Forms.Padding(5);
            this.txtValor.MaxLength = 60;
            this.txtValor.Name = "txtValor";
            this.txtValor.PasswordChar = '\0';
            this.txtValor.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtValor.SelectedText = "";
            this.txtValor.SelectionLength = 0;
            this.txtValor.SelectionStart = 0;
            this.txtValor.ShortcutsEnabled = true;
            this.txtValor.Size = new System.Drawing.Size(157, 33);
            this.txtValor.TabIndex = 14;
            this.txtValor.Text = "0";
            this.txtValor.UseSelectable = true;
            this.txtValor.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtValor.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtDesconto
            // 
            // 
            // 
            // 
            this.txtDesconto.CustomButton.Image = null;
            this.txtDesconto.CustomButton.Location = new System.Drawing.Point(125, 1);
            this.txtDesconto.CustomButton.Margin = new System.Windows.Forms.Padding(5);
            this.txtDesconto.CustomButton.Name = "";
            this.txtDesconto.CustomButton.Size = new System.Drawing.Size(31, 31);
            this.txtDesconto.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDesconto.CustomButton.TabIndex = 1;
            this.txtDesconto.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDesconto.CustomButton.UseSelectable = true;
            this.txtDesconto.CustomButton.Visible = false;
            this.txtDesconto.Enabled = false;
            this.txtDesconto.Lines = new string[] {
        "0"};
            this.txtDesconto.Location = new System.Drawing.Point(370, 114);
            this.txtDesconto.Margin = new System.Windows.Forms.Padding(5);
            this.txtDesconto.MaxLength = 60;
            this.txtDesconto.Name = "txtDesconto";
            this.txtDesconto.PasswordChar = '\0';
            this.txtDesconto.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDesconto.SelectedText = "";
            this.txtDesconto.SelectionLength = 0;
            this.txtDesconto.SelectionStart = 0;
            this.txtDesconto.ShortcutsEnabled = true;
            this.txtDesconto.Size = new System.Drawing.Size(157, 33);
            this.txtDesconto.TabIndex = 12;
            this.txtDesconto.Text = "0";
            this.txtDesconto.UseSelectable = true;
            this.txtDesconto.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDesconto.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtunidade
            // 
            // 
            // 
            // 
            this.txtunidade.CustomButton.Image = null;
            this.txtunidade.CustomButton.Location = new System.Drawing.Point(88, 1);
            this.txtunidade.CustomButton.Margin = new System.Windows.Forms.Padding(5);
            this.txtunidade.CustomButton.Name = "";
            this.txtunidade.CustomButton.Size = new System.Drawing.Size(31, 31);
            this.txtunidade.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtunidade.CustomButton.TabIndex = 1;
            this.txtunidade.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtunidade.CustomButton.UseSelectable = true;
            this.txtunidade.CustomButton.Visible = false;
            this.txtunidade.Enabled = false;
            this.txtunidade.Lines = new string[] {
        "0"};
            this.txtunidade.Location = new System.Drawing.Point(225, 114);
            this.txtunidade.Margin = new System.Windows.Forms.Padding(5);
            this.txtunidade.MaxLength = 60;
            this.txtunidade.Name = "txtunidade";
            this.txtunidade.PasswordChar = '\0';
            this.txtunidade.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtunidade.SelectedText = "";
            this.txtunidade.SelectionLength = 0;
            this.txtunidade.SelectionStart = 0;
            this.txtunidade.ShortcutsEnabled = true;
            this.txtunidade.Size = new System.Drawing.Size(120, 33);
            this.txtunidade.TabIndex = 2;
            this.txtunidade.Text = "0";
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
            this.txtId.CustomButton.Location = new System.Drawing.Point(44, 1);
            this.txtId.CustomButton.Margin = new System.Windows.Forms.Padding(5);
            this.txtId.CustomButton.Name = "";
            this.txtId.CustomButton.Size = new System.Drawing.Size(31, 31);
            this.txtId.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtId.CustomButton.TabIndex = 1;
            this.txtId.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtId.CustomButton.UseSelectable = true;
            this.txtId.CustomButton.Visible = false;
            this.txtId.Enabled = false;
            this.txtId.Lines = new string[] {
        "0"};
            this.txtId.Location = new System.Drawing.Point(11, 44);
            this.txtId.Margin = new System.Windows.Forms.Padding(5);
            this.txtId.MaxLength = 32767;
            this.txtId.Name = "txtId";
            this.txtId.PasswordChar = '\0';
            this.txtId.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtId.SelectedText = "";
            this.txtId.SelectionLength = 0;
            this.txtId.SelectionStart = 0;
            this.txtId.ShortcutsEnabled = true;
            this.txtId.Size = new System.Drawing.Size(76, 33);
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
            this.txtNome.CustomButton.Location = new System.Drawing.Point(204, 1);
            this.txtNome.CustomButton.Margin = new System.Windows.Forms.Padding(5);
            this.txtNome.CustomButton.Name = "";
            this.txtNome.CustomButton.Size = new System.Drawing.Size(31, 31);
            this.txtNome.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNome.CustomButton.TabIndex = 1;
            this.txtNome.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNome.CustomButton.UseSelectable = true;
            this.txtNome.CustomButton.Visible = false;
            this.txtNome.Enabled = false;
            this.txtNome.Lines = new string[0];
            this.txtNome.Location = new System.Drawing.Point(109, 44);
            this.txtNome.Margin = new System.Windows.Forms.Padding(5);
            this.txtNome.MaxLength = 60;
            this.txtNome.Name = "txtNome";
            this.txtNome.PasswordChar = '\0';
            this.txtNome.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNome.SelectedText = "";
            this.txtNome.SelectionLength = 0;
            this.txtNome.SelectionStart = 0;
            this.txtNome.ShortcutsEnabled = true;
            this.txtNome.Size = new System.Drawing.Size(236, 33);
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
            this.txtCodBar.CustomButton.Location = new System.Drawing.Point(162, 1);
            this.txtCodBar.CustomButton.Margin = new System.Windows.Forms.Padding(5);
            this.txtCodBar.CustomButton.Name = "";
            this.txtCodBar.CustomButton.Size = new System.Drawing.Size(31, 31);
            this.txtCodBar.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCodBar.CustomButton.TabIndex = 1;
            this.txtCodBar.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCodBar.CustomButton.UseSelectable = true;
            this.txtCodBar.CustomButton.Visible = false;
            this.txtCodBar.Enabled = false;
            this.txtCodBar.Lines = new string[0];
            this.txtCodBar.Location = new System.Drawing.Point(11, 114);
            this.txtCodBar.Margin = new System.Windows.Forms.Padding(5);
            this.txtCodBar.MaxLength = 13;
            this.txtCodBar.Name = "txtCodBar";
            this.txtCodBar.PasswordChar = '\0';
            this.txtCodBar.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCodBar.SelectedText = "";
            this.txtCodBar.SelectionLength = 0;
            this.txtCodBar.SelectionStart = 0;
            this.txtCodBar.ShortcutsEnabled = true;
            this.txtCodBar.Size = new System.Drawing.Size(194, 33);
            this.txtCodBar.TabIndex = 3;
            this.txtCodBar.UseSelectable = true;
            this.txtCodBar.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCodBar.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(664, 227);
            this.btnListar.Margin = new System.Windows.Forms.Padding(4);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(120, 32);
            this.btnListar.TabIndex = 11;
            this.btnListar.Text = "Listar";
            this.btnListar.UseSelectable = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // btnInserir
            // 
            this.btnInserir.Enabled = false;
            this.btnInserir.Location = new System.Drawing.Point(520, 227);
            this.btnInserir.Margin = new System.Windows.Forms.Padding(5);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(120, 32);
            this.btnInserir.TabIndex = 8;
            this.btnInserir.Text = "&Inserir";
            this.btnInserir.UseSelectable = true;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // GridProdutos
            // 
            this.GridProdutos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GridProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridProdutos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colunaId,
            this.colunaNome,
            this.colunaUnidade,
            this.colunaCodBar,
            this.colunaDesconto,
            this.colunaValor,
            this.ColunaDescontinuado});
            this.GridProdutos.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.GridProdutos.Location = new System.Drawing.Point(8, 24);
            this.GridProdutos.Margin = new System.Windows.Forms.Padding(4);
            this.GridProdutos.Name = "GridProdutos";
            this.GridProdutos.ReadOnly = true;
            this.GridProdutos.RowHeadersVisible = false;
            this.GridProdutos.RowHeadersWidth = 51;
            this.GridProdutos.Size = new System.Drawing.Size(899, 324);
            this.GridProdutos.TabIndex = 16;
            this.GridProdutos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridProdutos_CellDoubleClick);
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
            // colunaUnidade
            // 
            this.colunaUnidade.HeaderText = "Unidade";
            this.colunaUnidade.MinimumWidth = 6;
            this.colunaUnidade.Name = "colunaUnidade";
            this.colunaUnidade.ReadOnly = true;
            // 
            // colunaCodBar
            // 
            this.colunaCodBar.HeaderText = "Cod. Barras";
            this.colunaCodBar.MinimumWidth = 6;
            this.colunaCodBar.Name = "colunaCodBar";
            this.colunaCodBar.ReadOnly = true;
            // 
            // colunaDesconto
            // 
            this.colunaDesconto.HeaderText = "Desconto";
            this.colunaDesconto.MinimumWidth = 6;
            this.colunaDesconto.Name = "colunaDesconto";
            this.colunaDesconto.ReadOnly = true;
            // 
            // colunaValor
            // 
            this.colunaValor.HeaderText = "Valor";
            this.colunaValor.MinimumWidth = 6;
            this.colunaValor.Name = "colunaValor";
            this.colunaValor.ReadOnly = true;
            // 
            // ColunaDescontinuado
            // 
            this.ColunaDescontinuado.HeaderText = "Continuado";
            this.ColunaDescontinuado.MinimumWidth = 6;
            this.ColunaDescontinuado.Name = "ColunaDescontinuado";
            this.ColunaDescontinuado.ReadOnly = true;
            this.ColunaDescontinuado.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColunaDescontinuado.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // txtIdPesq
            // 
            // 
            // 
            // 
            this.txtIdPesq.CustomButton.Image = null;
            this.txtIdPesq.CustomButton.Location = new System.Drawing.Point(38, 1);
            this.txtIdPesq.CustomButton.Margin = new System.Windows.Forms.Padding(5);
            this.txtIdPesq.CustomButton.Name = "";
            this.txtIdPesq.CustomButton.Size = new System.Drawing.Size(31, 31);
            this.txtIdPesq.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtIdPesq.CustomButton.TabIndex = 1;
            this.txtIdPesq.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtIdPesq.CustomButton.UseSelectable = true;
            this.txtIdPesq.CustomButton.Visible = false;
            this.txtIdPesq.Lines = new string[0];
            this.txtIdPesq.Location = new System.Drawing.Point(9, 44);
            this.txtIdPesq.Margin = new System.Windows.Forms.Padding(5);
            this.txtIdPesq.MaxLength = 60;
            this.txtIdPesq.Name = "txtIdPesq";
            this.txtIdPesq.PasswordChar = '\0';
            this.txtIdPesq.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtIdPesq.SelectedText = "";
            this.txtIdPesq.SelectionLength = 0;
            this.txtIdPesq.SelectionStart = 0;
            this.txtIdPesq.ShortcutsEnabled = true;
            this.txtIdPesq.Size = new System.Drawing.Size(70, 33);
            this.txtIdPesq.TabIndex = 12;
            this.txtIdPesq.UseSelectable = true;
            this.txtIdPesq.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtIdPesq.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtIdPesq.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtIdPesq_KeyUp);
            // 
            // txtValorPesq
            // 
            // 
            // 
            // 
            this.txtValorPesq.CustomButton.Image = null;
            this.txtValorPesq.CustomButton.Location = new System.Drawing.Point(60, 1);
            this.txtValorPesq.CustomButton.Margin = new System.Windows.Forms.Padding(5);
            this.txtValorPesq.CustomButton.Name = "";
            this.txtValorPesq.CustomButton.Size = new System.Drawing.Size(31, 31);
            this.txtValorPesq.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtValorPesq.CustomButton.TabIndex = 1;
            this.txtValorPesq.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtValorPesq.CustomButton.UseSelectable = true;
            this.txtValorPesq.CustomButton.Visible = false;
            this.txtValorPesq.Lines = new string[0];
            this.txtValorPesq.Location = new System.Drawing.Point(117, 44);
            this.txtValorPesq.Margin = new System.Windows.Forms.Padding(5);
            this.txtValorPesq.MaxLength = 60;
            this.txtValorPesq.Name = "txtValorPesq";
            this.txtValorPesq.PasswordChar = '\0';
            this.txtValorPesq.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtValorPesq.SelectedText = "";
            this.txtValorPesq.SelectionLength = 0;
            this.txtValorPesq.SelectionStart = 0;
            this.txtValorPesq.ShortcutsEnabled = true;
            this.txtValorPesq.Size = new System.Drawing.Size(92, 33);
            this.txtValorPesq.TabIndex = 14;
            this.txtValorPesq.UseSelectable = true;
            this.txtValorPesq.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtValorPesq.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtValorPesq.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtValorPesq_KeyUp);
            // 
            // txtCodBarPesq
            // 
            // 
            // 
            // 
            this.txtCodBarPesq.CustomButton.Image = null;
            this.txtCodBarPesq.CustomButton.Location = new System.Drawing.Point(168, 1);
            this.txtCodBarPesq.CustomButton.Margin = new System.Windows.Forms.Padding(5);
            this.txtCodBarPesq.CustomButton.Name = "";
            this.txtCodBarPesq.CustomButton.Size = new System.Drawing.Size(31, 31);
            this.txtCodBarPesq.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCodBarPesq.CustomButton.TabIndex = 1;
            this.txtCodBarPesq.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCodBarPesq.CustomButton.UseSelectable = true;
            this.txtCodBarPesq.CustomButton.Visible = false;
            this.txtCodBarPesq.Lines = new string[0];
            this.txtCodBarPesq.Location = new System.Drawing.Point(9, 114);
            this.txtCodBarPesq.Margin = new System.Windows.Forms.Padding(5);
            this.txtCodBarPesq.MaxLength = 60;
            this.txtCodBarPesq.Name = "txtCodBarPesq";
            this.txtCodBarPesq.PasswordChar = '\0';
            this.txtCodBarPesq.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCodBarPesq.SelectedText = "";
            this.txtCodBarPesq.SelectionLength = 0;
            this.txtCodBarPesq.SelectionStart = 0;
            this.txtCodBarPesq.ShortcutsEnabled = true;
            this.txtCodBarPesq.Size = new System.Drawing.Size(200, 33);
            this.txtCodBarPesq.TabIndex = 18;
            this.txtCodBarPesq.UseSelectable = true;
            this.txtCodBarPesq.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCodBarPesq.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtCodBarPesq.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtCodBarPesq_KeyUp);
            // 
            // gpBoxPesq
            // 
            this.gpBoxPesq.Controls.Add(this.label9);
            this.gpBoxPesq.Controls.Add(this.label8);
            this.gpBoxPesq.Controls.Add(this.label7);
            this.gpBoxPesq.Controls.Add(this.txtCodBarPesq);
            this.gpBoxPesq.Controls.Add(this.txtValorPesq);
            this.gpBoxPesq.Controls.Add(this.txtIdPesq);
            this.gpBoxPesq.Location = new System.Drawing.Point(715, 28);
            this.gpBoxPesq.Margin = new System.Windows.Forms.Padding(4);
            this.gpBoxPesq.Name = "gpBoxPesq";
            this.gpBoxPesq.Padding = new System.Windows.Forms.Padding(4);
            this.gpBoxPesq.Size = new System.Drawing.Size(224, 191);
            this.gpBoxPesq.TabIndex = 17;
            this.gpBoxPesq.TabStop = false;
            this.gpBoxPesq.Text = "Pesquisar";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.GridProdutos);
            this.groupBox1.Location = new System.Drawing.Point(23, 260);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(915, 356);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Produtos";
            // 
            // btnEditar
            // 
            this.btnEditar.Enabled = false;
            this.btnEditar.Location = new System.Drawing.Point(375, 227);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(120, 32);
            this.btnEditar.TabIndex = 22;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseSelectable = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.5F);
            this.label1.Location = new System.Drawing.Point(8, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 17);
            this.label1.TabIndex = 31;
            this.label1.Text = "Cod. Barras";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.5F);
            this.label2.Location = new System.Drawing.Point(8, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 17);
            this.label2.TabIndex = 32;
            this.label2.Text = "ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.5F);
            this.label3.Location = new System.Drawing.Point(106, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 17);
            this.label3.TabIndex = 33;
            this.label3.Text = "Nome";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.5F);
            this.label4.Location = new System.Drawing.Point(222, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 17);
            this.label4.TabIndex = 34;
            this.label4.Text = "Unidade";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.5F);
            this.label5.Location = new System.Drawing.Point(367, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 17);
            this.label5.TabIndex = 35;
            this.label5.Text = "Desconto";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9.5F);
            this.label6.Location = new System.Drawing.Point(367, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 17);
            this.label6.TabIndex = 36;
            this.label6.Text = "Valor";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9.5F);
            this.label7.Location = new System.Drawing.Point(7, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(21, 17);
            this.label7.TabIndex = 37;
            this.label7.Text = "ID";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 9.5F);
            this.label8.Location = new System.Drawing.Point(114, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 17);
            this.label8.TabIndex = 37;
            this.label8.Text = "Valor";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 9.5F);
            this.label9.Location = new System.Drawing.Point(6, 92);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 17);
            this.label9.TabIndex = 37;
            this.label9.Text = "Cod. Barras";
            // 
            // ProdutoView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(956, 629);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gpBoxCadastrar);
            this.Controls.Add(this.gpBoxPesq);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.btnInserir);
            this.Font = new System.Drawing.Font("Century Gothic", 8F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ProdutoView";
            this.Padding = new System.Windows.Forms.Padding(27, 79, 27, 27);
            this.Text = "Produto";
            this.Load += new System.EventHandler(this.FormProduto_Load);
            this.gpBoxCadastrar.ResumeLayout(false);
            this.gpBoxCadastrar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridProdutos)).EndInit();
            this.gpBoxPesq.ResumeLayout(false);
            this.gpBoxPesq.PerformLayout();
            this.groupBox1.ResumeLayout(false);
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
        private System.Windows.Forms.DataGridView GridProdutos;
        private MetroFramework.Controls.MetroTextBox txtDesconto;
        private MetroFramework.Controls.MetroTextBox txtValor;
        private MetroFramework.Controls.MetroTextBox txtIdPesq;
        private MetroFramework.Controls.MetroTextBox txtValorPesq;
        private MetroFramework.Controls.MetroTextBox txtCodBarPesq;
        private System.Windows.Forms.GroupBox gpBoxPesq;
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroButton btnEditar;
        private System.Windows.Forms.Button btnDesbloquear;
        private System.Windows.Forms.Button btnBloquear;
        private System.Windows.Forms.CheckBox chkDescontinuado;
        private System.Windows.Forms.DataGridViewTextBoxColumn colunaId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colunaNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn colunaUnidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn colunaCodBar;
        private System.Windows.Forms.DataGridViewTextBoxColumn colunaDesconto;
        private System.Windows.Forms.DataGridViewTextBoxColumn colunaValor;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ColunaDescontinuado;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
    }
}