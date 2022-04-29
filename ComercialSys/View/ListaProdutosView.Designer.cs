namespace ComercialSys.View
{
    partial class ListaProdutosView
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
            this.gpBoxPesq = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCodBarPesq = new MetroFramework.Controls.MetroTextBox();
            this.txtValorPesq = new MetroFramework.Controls.MetroTextBox();
            this.txtIdPesq = new MetroFramework.Controls.MetroTextBox();
            this.GridProdutos = new System.Windows.Forms.DataGridView();
            this.colunaId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colunaNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colunaUnidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colunaCodBar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colunaDesconto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colunaValor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColunaDescontinuado = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gpBoxPesq.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridProdutos)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpBoxPesq
            // 
            this.gpBoxPesq.Controls.Add(this.label9);
            this.gpBoxPesq.Controls.Add(this.label8);
            this.gpBoxPesq.Controls.Add(this.label7);
            this.gpBoxPesq.Controls.Add(this.txtCodBarPesq);
            this.gpBoxPesq.Controls.Add(this.txtValorPesq);
            this.gpBoxPesq.Controls.Add(this.txtIdPesq);
            this.gpBoxPesq.Location = new System.Drawing.Point(118, 28);
            this.gpBoxPesq.Margin = new System.Windows.Forms.Padding(4);
            this.gpBoxPesq.Name = "gpBoxPesq";
            this.gpBoxPesq.Padding = new System.Windows.Forms.Padding(4);
            this.gpBoxPesq.Size = new System.Drawing.Size(574, 92);
            this.gpBoxPesq.TabIndex = 19;
            this.gpBoxPesq.TabStop = false;
            this.gpBoxPesq.Text = "Pesquisar";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 9.5F);
            this.label9.Location = new System.Drawing.Point(296, 18);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 17);
            this.label9.TabIndex = 37;
            this.label9.Text = "Cod. Barras";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 9.5F);
            this.label8.Location = new System.Drawing.Point(161, 21);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 17);
            this.label8.TabIndex = 37;
            this.label8.Text = "Valor";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9.5F);
            this.label7.Location = new System.Drawing.Point(54, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(21, 17);
            this.label7.TabIndex = 37;
            this.label7.Text = "ID";
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
            this.txtCodBarPesq.Location = new System.Drawing.Point(298, 40);
            this.txtCodBarPesq.Margin = new System.Windows.Forms.Padding(5);
            this.txtCodBarPesq.MaxLength = 60;
            this.txtCodBarPesq.Name = "txtCodBarPesq";
            this.txtCodBarPesq.PasswordChar = '\0';
            this.txtCodBarPesq.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCodBarPesq.SelectedText = "";
            this.txtCodBarPesq.SelectionLength = 0;
            this.txtCodBarPesq.SelectionStart = 0;
            this.txtCodBarPesq.ShortcutsEnabled = true;
            this.txtCodBarPesq.Size = new System.Drawing.Size(230, 33);
            this.txtCodBarPesq.TabIndex = 18;
            this.txtCodBarPesq.UseSelectable = true;
            this.txtCodBarPesq.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCodBarPesq.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
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
            this.txtValorPesq.Location = new System.Drawing.Point(142, 40);
            this.txtValorPesq.Margin = new System.Windows.Forms.Padding(5);
            this.txtValorPesq.MaxLength = 60;
            this.txtValorPesq.Name = "txtValorPesq";
            this.txtValorPesq.PasswordChar = '\0';
            this.txtValorPesq.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtValorPesq.SelectedText = "";
            this.txtValorPesq.SelectionLength = 0;
            this.txtValorPesq.SelectionStart = 0;
            this.txtValorPesq.ShortcutsEnabled = true;
            this.txtValorPesq.Size = new System.Drawing.Size(140, 33);
            this.txtValorPesq.TabIndex = 14;
            this.txtValorPesq.UseSelectable = true;
            this.txtValorPesq.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtValorPesq.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
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
            this.txtIdPesq.Location = new System.Drawing.Point(56, 40);
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
            this.GridProdutos.Location = new System.Drawing.Point(8, 21);
            this.GridProdutos.Margin = new System.Windows.Forms.Padding(4);
            this.GridProdutos.Name = "GridProdutos";
            this.GridProdutos.ReadOnly = true;
            this.GridProdutos.RowHeadersVisible = false;
            this.GridProdutos.RowHeadersWidth = 51;
            this.GridProdutos.Size = new System.Drawing.Size(792, 354);
            this.GridProdutos.TabIndex = 18;
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.GridProdutos);
            this.groupBox1.Location = new System.Drawing.Point(12, 128);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(816, 383);
            this.groupBox1.TabIndex = 38;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Produtos";
            // 
            // ListaProdutosView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 521);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gpBoxPesq);
            this.Name = "ListaProdutosView";
            this.Text = "ListaProdutos";
            this.gpBoxPesq.ResumeLayout(false);
            this.gpBoxPesq.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridProdutos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpBoxPesq;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private MetroFramework.Controls.MetroTextBox txtCodBarPesq;
        private MetroFramework.Controls.MetroTextBox txtValorPesq;
        private MetroFramework.Controls.MetroTextBox txtIdPesq;
        private System.Windows.Forms.DataGridView GridProdutos;
        private System.Windows.Forms.DataGridViewTextBoxColumn colunaId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colunaNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn colunaUnidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn colunaCodBar;
        private System.Windows.Forms.DataGridViewTextBoxColumn colunaDesconto;
        private System.Windows.Forms.DataGridViewTextBoxColumn colunaValor;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ColunaDescontinuado;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}