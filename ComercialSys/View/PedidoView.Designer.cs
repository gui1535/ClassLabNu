namespace ComercialSys.View
{
    partial class PedidoView
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
            this.GridCliente = new System.Windows.Forms.DataGridView();
            this.gpDadosPed = new System.Windows.Forms.GroupBox();
            this.btnCriarPed = new MetroFramework.Controls.MetroButton();
            this.label4 = new System.Windows.Forms.Label();
            this.txtIdPed = new MetroFramework.Controls.MetroTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDataPed = new MetroFramework.Controls.MetroTextBox();
            this.gpItensPed = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtDescricao = new MetroFramework.Controls.MetroTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDesconto = new MetroFramework.Controls.MetroTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCodbar = new MetroFramework.Controls.MetroTextBox();
            this.txtValor = new MetroFramework.Controls.MetroTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnInserirPed = new MetroFramework.Controls.MetroButton();
            this.gpOperacoes = new System.Windows.Forms.GroupBox();
            this.btnFecharPed = new MetroFramework.Controls.MetroButton();
            this.metroButton3 = new MetroFramework.Controls.MetroButton();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.label6 = new System.Windows.Forms.Label();
            this.txtValorFPed = new MetroFramework.Controls.MetroTextBox();
            this.lbStatusPed = new System.Windows.Forms.Label();
            this.cmbUsuarios = new System.Windows.Forms.ComboBox();
            this.cmbClientes = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.GridCliente)).BeginInit();
            this.gpDadosPed.SuspendLayout();
            this.gpItensPed.SuspendLayout();
            this.gpOperacoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // GridCliente
            // 
            this.GridCliente.AllowUserToAddRows = false;
            this.GridCliente.AllowUserToDeleteRows = false;
            this.GridCliente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GridCliente.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.GridCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridCliente.GridColor = System.Drawing.Color.Black;
            this.GridCliente.Location = new System.Drawing.Point(7, 112);
            this.GridCliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GridCliente.Name = "GridCliente";
            this.GridCliente.ReadOnly = true;
            this.GridCliente.RowHeadersVisible = false;
            this.GridCliente.RowHeadersWidth = 51;
            this.GridCliente.Size = new System.Drawing.Size(796, 287);
            this.GridCliente.TabIndex = 11;
            // 
            // gpDadosPed
            // 
            this.gpDadosPed.Controls.Add(this.cmbClientes);
            this.gpDadosPed.Controls.Add(this.cmbUsuarios);
            this.gpDadosPed.Controls.Add(this.btnCriarPed);
            this.gpDadosPed.Controls.Add(this.label4);
            this.gpDadosPed.Controls.Add(this.txtIdPed);
            this.gpDadosPed.Controls.Add(this.label3);
            this.gpDadosPed.Controls.Add(this.label2);
            this.gpDadosPed.Controls.Add(this.label1);
            this.gpDadosPed.Controls.Add(this.txtDataPed);
            this.gpDadosPed.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpDadosPed.Location = new System.Drawing.Point(29, 33);
            this.gpDadosPed.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gpDadosPed.Name = "gpDadosPed";
            this.gpDadosPed.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gpDadosPed.Size = new System.Drawing.Size(809, 182);
            this.gpDadosPed.TabIndex = 13;
            this.gpDadosPed.TabStop = false;
            this.gpDadosPed.Text = "Dados do Pedido";
            // 
            // btnCriarPed
            // 
            this.btnCriarPed.Location = new System.Drawing.Point(635, 119);
            this.btnCriarPed.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCriarPed.Name = "btnCriarPed";
            this.btnCriarPed.Size = new System.Drawing.Size(145, 33);
            this.btnCriarPed.TabIndex = 19;
            this.btnCriarPed.Text = "Criar";
            this.btnCriarPed.UseSelectable = true;
            this.btnCriarPed.Click += new System.EventHandler(this.btnCriarPed_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(631, 34);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 21);
            this.label4.TabIndex = 18;
            this.label4.Text = "ID PEDIDO";
            // 
            // txtIdPed
            // 
            // 
            // 
            // 
            this.txtIdPed.CustomButton.Image = null;
            this.txtIdPed.CustomButton.Location = new System.Drawing.Point(159, 2);
            this.txtIdPed.CustomButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtIdPed.CustomButton.Name = "";
            this.txtIdPed.CustomButton.Size = new System.Drawing.Size(31, 28);
            this.txtIdPed.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtIdPed.CustomButton.TabIndex = 1;
            this.txtIdPed.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtIdPed.CustomButton.UseSelectable = true;
            this.txtIdPed.CustomButton.Visible = false;
            this.txtIdPed.Lines = new string[0];
            this.txtIdPed.Location = new System.Drawing.Point(635, 59);
            this.txtIdPed.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtIdPed.MaxLength = 32767;
            this.txtIdPed.Name = "txtIdPed";
            this.txtIdPed.PasswordChar = '\0';
            this.txtIdPed.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtIdPed.SelectedText = "";
            this.txtIdPed.SelectionLength = 0;
            this.txtIdPed.SelectionStart = 0;
            this.txtIdPed.ShortcutsEnabled = true;
            this.txtIdPed.Size = new System.Drawing.Size(145, 28);
            this.txtIdPed.TabIndex = 17;
            this.txtIdPed.UseSelectable = true;
            this.txtIdPed.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtIdPed.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 100);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 21);
            this.label3.TabIndex = 16;
            this.label3.Text = "Nome Usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 32);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 21);
            this.label2.TabIndex = 15;
            this.label2.Text = "Nome cliente";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(401, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 21);
            this.label1.TabIndex = 14;
            this.label1.Text = "Data";
            // 
            // txtDataPed
            // 
            // 
            // 
            // 
            this.txtDataPed.CustomButton.Image = null;
            this.txtDataPed.CustomButton.Location = new System.Drawing.Point(205, 2);
            this.txtDataPed.CustomButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDataPed.CustomButton.Name = "";
            this.txtDataPed.CustomButton.Size = new System.Drawing.Size(31, 28);
            this.txtDataPed.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDataPed.CustomButton.TabIndex = 1;
            this.txtDataPed.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDataPed.CustomButton.UseSelectable = true;
            this.txtDataPed.CustomButton.Visible = false;
            this.txtDataPed.Enabled = false;
            this.txtDataPed.Lines = new string[0];
            this.txtDataPed.Location = new System.Drawing.Point(405, 59);
            this.txtDataPed.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDataPed.MaxLength = 32767;
            this.txtDataPed.Name = "txtDataPed";
            this.txtDataPed.PasswordChar = '\0';
            this.txtDataPed.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDataPed.SelectedText = "";
            this.txtDataPed.SelectionLength = 0;
            this.txtDataPed.SelectionStart = 0;
            this.txtDataPed.ShortcutsEnabled = true;
            this.txtDataPed.Size = new System.Drawing.Size(180, 28);
            this.txtDataPed.TabIndex = 13;
            this.txtDataPed.UseSelectable = true;
            this.txtDataPed.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDataPed.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // gpItensPed
            // 
            this.gpItensPed.Controls.Add(this.label9);
            this.gpItensPed.Controls.Add(this.txtDescricao);
            this.gpItensPed.Controls.Add(this.label8);
            this.gpItensPed.Controls.Add(this.txtDesconto);
            this.gpItensPed.Controls.Add(this.label7);
            this.gpItensPed.Controls.Add(this.txtCodbar);
            this.gpItensPed.Controls.Add(this.txtValor);
            this.gpItensPed.Controls.Add(this.label5);
            this.gpItensPed.Controls.Add(this.btnInserirPed);
            this.gpItensPed.Controls.Add(this.GridCliente);
            this.gpItensPed.Enabled = false;
            this.gpItensPed.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpItensPed.Location = new System.Drawing.Point(29, 234);
            this.gpItensPed.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gpItensPed.Name = "gpItensPed";
            this.gpItensPed.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gpItensPed.Size = new System.Drawing.Size(809, 411);
            this.gpItensPed.TabIndex = 20;
            this.gpItensPed.TabStop = false;
            this.gpItensPed.Text = "Dados do Pedido";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(200, 31);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(94, 21);
            this.label9.TabIndex = 25;
            this.label9.Text = "Descricao";
            // 
            // txtDescricao
            // 
            // 
            // 
            // 
            this.txtDescricao.CustomButton.Image = null;
            this.txtDescricao.CustomButton.Location = new System.Drawing.Point(147, 2);
            this.txtDescricao.CustomButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDescricao.CustomButton.Name = "";
            this.txtDescricao.CustomButton.Size = new System.Drawing.Size(31, 28);
            this.txtDescricao.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDescricao.CustomButton.TabIndex = 1;
            this.txtDescricao.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDescricao.CustomButton.UseSelectable = true;
            this.txtDescricao.CustomButton.Visible = false;
            this.txtDescricao.Lines = new string[0];
            this.txtDescricao.Location = new System.Drawing.Point(204, 55);
            this.txtDescricao.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDescricao.MaxLength = 32767;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.PasswordChar = '\0';
            this.txtDescricao.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDescricao.SelectedText = "";
            this.txtDescricao.SelectionLength = 0;
            this.txtDescricao.SelectionStart = 0;
            this.txtDescricao.ShortcutsEnabled = true;
            this.txtDescricao.Size = new System.Drawing.Size(136, 28);
            this.txtDescricao.TabIndex = 24;
            this.txtDescricao.UseSelectable = true;
            this.txtDescricao.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDescricao.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtDescricao.Click += new System.EventHandler(this.txtDescricao_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(529, 31);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 21);
            this.label8.TabIndex = 23;
            this.label8.Text = "Desconto";
            // 
            // txtDesconto
            // 
            // 
            // 
            // 
            this.txtDesconto.CustomButton.Image = null;
            this.txtDesconto.CustomButton.Location = new System.Drawing.Point(147, 2);
            this.txtDesconto.CustomButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDesconto.CustomButton.Name = "";
            this.txtDesconto.CustomButton.Size = new System.Drawing.Size(31, 28);
            this.txtDesconto.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDesconto.CustomButton.TabIndex = 1;
            this.txtDesconto.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDesconto.CustomButton.UseSelectable = true;
            this.txtDesconto.CustomButton.Visible = false;
            this.txtDesconto.Lines = new string[0];
            this.txtDesconto.Location = new System.Drawing.Point(533, 55);
            this.txtDesconto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDesconto.MaxLength = 32767;
            this.txtDesconto.Name = "txtDesconto";
            this.txtDesconto.PasswordChar = '\0';
            this.txtDesconto.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDesconto.SelectedText = "";
            this.txtDesconto.SelectionLength = 0;
            this.txtDesconto.SelectionStart = 0;
            this.txtDesconto.ShortcutsEnabled = true;
            this.txtDesconto.Size = new System.Drawing.Size(136, 28);
            this.txtDesconto.TabIndex = 22;
            this.txtDesconto.UseSelectable = true;
            this.txtDesconto.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDesconto.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(359, 31);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 21);
            this.label7.TabIndex = 21;
            this.label7.Text = "Valor";
            // 
            // txtCodbar
            // 
            // 
            // 
            // 
            this.txtCodbar.CustomButton.Image = null;
            this.txtCodbar.CustomButton.Location = new System.Drawing.Point(147, 2);
            this.txtCodbar.CustomButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCodbar.CustomButton.Name = "";
            this.txtCodbar.CustomButton.Size = new System.Drawing.Size(31, 28);
            this.txtCodbar.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCodbar.CustomButton.TabIndex = 1;
            this.txtCodbar.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCodbar.CustomButton.UseSelectable = true;
            this.txtCodbar.CustomButton.Visible = false;
            this.txtCodbar.Lines = new string[0];
            this.txtCodbar.Location = new System.Drawing.Point(21, 55);
            this.txtCodbar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCodbar.MaxLength = 32767;
            this.txtCodbar.Name = "txtCodbar";
            this.txtCodbar.PasswordChar = '\0';
            this.txtCodbar.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCodbar.SelectedText = "";
            this.txtCodbar.SelectionLength = 0;
            this.txtCodbar.SelectionStart = 0;
            this.txtCodbar.ShortcutsEnabled = true;
            this.txtCodbar.Size = new System.Drawing.Size(136, 28);
            this.txtCodbar.TabIndex = 20;
            this.txtCodbar.UseSelectable = true;
            this.txtCodbar.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCodbar.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtValor
            // 
            // 
            // 
            // 
            this.txtValor.CustomButton.Image = null;
            this.txtValor.CustomButton.Location = new System.Drawing.Point(147, 2);
            this.txtValor.CustomButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtValor.CustomButton.Name = "";
            this.txtValor.CustomButton.Size = new System.Drawing.Size(31, 28);
            this.txtValor.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtValor.CustomButton.TabIndex = 1;
            this.txtValor.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtValor.CustomButton.UseSelectable = true;
            this.txtValor.CustomButton.Visible = false;
            this.txtValor.Lines = new string[0];
            this.txtValor.Location = new System.Drawing.Point(363, 55);
            this.txtValor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtValor.MaxLength = 32767;
            this.txtValor.Name = "txtValor";
            this.txtValor.PasswordChar = '\0';
            this.txtValor.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtValor.SelectedText = "";
            this.txtValor.SelectionLength = 0;
            this.txtValor.SelectionStart = 0;
            this.txtValor.ShortcutsEnabled = true;
            this.txtValor.Size = new System.Drawing.Size(136, 28);
            this.txtValor.TabIndex = 20;
            this.txtValor.UseSelectable = true;
            this.txtValor.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtValor.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(17, 31);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 21);
            this.label5.TabIndex = 20;
            this.label5.Text = "Cod. Barras";
            // 
            // btnInserirPed
            // 
            this.btnInserirPed.Location = new System.Drawing.Point(700, 50);
            this.btnInserirPed.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnInserirPed.Name = "btnInserirPed";
            this.btnInserirPed.Size = new System.Drawing.Size(100, 33);
            this.btnInserirPed.TabIndex = 21;
            this.btnInserirPed.Text = "Inserir";
            this.btnInserirPed.UseSelectable = true;
            this.btnInserirPed.Click += new System.EventHandler(this.btnInserirPed_Click);
            // 
            // gpOperacoes
            // 
            this.gpOperacoes.Controls.Add(this.btnFecharPed);
            this.gpOperacoes.Controls.Add(this.metroButton3);
            this.gpOperacoes.Controls.Add(this.metroButton2);
            this.gpOperacoes.Enabled = false;
            this.gpOperacoes.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpOperacoes.Location = new System.Drawing.Point(847, 234);
            this.gpOperacoes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gpOperacoes.Name = "gpOperacoes";
            this.gpOperacoes.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gpOperacoes.Size = new System.Drawing.Size(204, 310);
            this.gpOperacoes.TabIndex = 21;
            this.gpOperacoes.TabStop = false;
            this.gpOperacoes.Text = "Operações";
            // 
            // btnFecharPed
            // 
            this.btnFecharPed.Location = new System.Drawing.Point(8, 241);
            this.btnFecharPed.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnFecharPed.Name = "btnFecharPed";
            this.btnFecharPed.Size = new System.Drawing.Size(177, 44);
            this.btnFecharPed.TabIndex = 22;
            this.btnFecharPed.Text = "Fechar Pedido";
            this.btnFecharPed.UseSelectable = true;
            // 
            // metroButton3
            // 
            this.metroButton3.Location = new System.Drawing.Point(8, 140);
            this.metroButton3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.metroButton3.Name = "metroButton3";
            this.metroButton3.Size = new System.Drawing.Size(177, 44);
            this.metroButton3.TabIndex = 21;
            this.metroButton3.Text = "metroButton3";
            this.metroButton3.UseSelectable = true;
            // 
            // metroButton2
            // 
            this.metroButton2.Location = new System.Drawing.Point(8, 39);
            this.metroButton2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(177, 44);
            this.metroButton2.TabIndex = 20;
            this.metroButton2.Text = "metroButton2";
            this.metroButton2.UseSelectable = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(860, 576);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 21);
            this.label6.TabIndex = 21;
            this.label6.Text = "VALOR TOTAL";
            // 
            // txtValorFPed
            // 
            // 
            // 
            // 
            this.txtValorFPed.CustomButton.Image = null;
            this.txtValorFPed.CustomButton.Location = new System.Drawing.Point(220, 2);
            this.txtValorFPed.CustomButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtValorFPed.CustomButton.Name = "";
            this.txtValorFPed.CustomButton.Size = new System.Drawing.Size(31, 28);
            this.txtValorFPed.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtValorFPed.CustomButton.TabIndex = 1;
            this.txtValorFPed.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtValorFPed.CustomButton.UseSelectable = true;
            this.txtValorFPed.CustomButton.Visible = false;
            this.txtValorFPed.Enabled = false;
            this.txtValorFPed.Lines = new string[0];
            this.txtValorFPed.Location = new System.Drawing.Point(860, 604);
            this.txtValorFPed.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtValorFPed.MaxLength = 32767;
            this.txtValorFPed.Name = "txtValorFPed";
            this.txtValorFPed.PasswordChar = '\0';
            this.txtValorFPed.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtValorFPed.SelectedText = "";
            this.txtValorFPed.SelectionLength = 0;
            this.txtValorFPed.SelectionStart = 0;
            this.txtValorFPed.ShortcutsEnabled = true;
            this.txtValorFPed.Size = new System.Drawing.Size(191, 28);
            this.txtValorFPed.TabIndex = 20;
            this.txtValorFPed.UseSelectable = true;
            this.txtValorFPed.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtValorFPed.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lbStatusPed
            // 
            this.lbStatusPed.AutoSize = true;
            this.lbStatusPed.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStatusPed.Location = new System.Drawing.Point(856, 90);
            this.lbStatusPed.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbStatusPed.Name = "lbStatusPed";
            this.lbStatusPed.Size = new System.Drawing.Size(0, 32);
            this.lbStatusPed.TabIndex = 20;
            // 
            // cmbUsuarios
            // 
            this.cmbUsuarios.FormattingEnabled = true;
            this.cmbUsuarios.Location = new System.Drawing.Point(21, 144);
            this.cmbUsuarios.Name = "cmbUsuarios";
            this.cmbUsuarios.Size = new System.Drawing.Size(317, 31);
            this.cmbUsuarios.TabIndex = 20;
            // 
            // cmbClientes
            // 
            this.cmbClientes.FormattingEnabled = true;
            this.cmbClientes.Location = new System.Drawing.Point(21, 56);
            this.cmbClientes.Name = "cmbClientes";
            this.cmbClientes.Size = new System.Drawing.Size(317, 31);
            this.cmbClientes.TabIndex = 21;
            // 
            // PedidoView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1144, 726);
            this.Controls.Add(this.lbStatusPed);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.gpOperacoes);
            this.Controls.Add(this.txtValorFPed);
            this.Controls.Add(this.gpItensPed);
            this.Controls.Add(this.gpDadosPed);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "PedidoView";
            this.Text = "PedidoView";
            this.Load += new System.EventHandler(this.PedidoView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridCliente)).EndInit();
            this.gpDadosPed.ResumeLayout(false);
            this.gpDadosPed.PerformLayout();
            this.gpItensPed.ResumeLayout(false);
            this.gpItensPed.PerformLayout();
            this.gpOperacoes.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView GridCliente;
        private System.Windows.Forms.GroupBox gpDadosPed;
        private MetroFramework.Controls.MetroButton btnCriarPed;
        private System.Windows.Forms.Label label4;
        private MetroFramework.Controls.MetroTextBox txtIdPed;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroTextBox txtDataPed;
        private System.Windows.Forms.GroupBox gpItensPed;
        private System.Windows.Forms.GroupBox gpOperacoes;
        private MetroFramework.Controls.MetroButton btnFecharPed;
        private MetroFramework.Controls.MetroButton metroButton3;
        private MetroFramework.Controls.MetroButton metroButton2;
        private MetroFramework.Controls.MetroButton btnInserirPed;
        private System.Windows.Forms.Label label9;
        private MetroFramework.Controls.MetroTextBox txtDescricao;
        private System.Windows.Forms.Label label8;
        private MetroFramework.Controls.MetroTextBox txtDesconto;
        private System.Windows.Forms.Label label7;
        private MetroFramework.Controls.MetroTextBox txtCodbar;
        private MetroFramework.Controls.MetroTextBox txtValor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private MetroFramework.Controls.MetroTextBox txtValorFPed;
        private System.Windows.Forms.Label lbStatusPed;
        private System.Windows.Forms.ComboBox cmbClientes;
        private System.Windows.Forms.ComboBox cmbUsuarios;
    }
}