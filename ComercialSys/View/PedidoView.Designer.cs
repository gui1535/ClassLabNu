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
            this.cmbUsuarios = new MetroFramework.Controls.MetroComboBox();
            this.GridCliente = new System.Windows.Forms.DataGridView();
            this.cmbClientes = new MetroFramework.Controls.MetroComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.GridCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbUsuarios
            // 
            this.cmbUsuarios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbUsuarios.FormattingEnabled = true;
            this.cmbUsuarios.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cmbUsuarios.ItemHeight = 23;
            this.cmbUsuarios.Location = new System.Drawing.Point(58, 109);
            this.cmbUsuarios.Name = "cmbUsuarios";
            this.cmbUsuarios.Size = new System.Drawing.Size(239, 29);
            this.cmbUsuarios.TabIndex = 1;
            this.cmbUsuarios.UseSelectable = true;
            // 
            // GridCliente
            // 
            this.GridCliente.AllowUserToAddRows = false;
            this.GridCliente.AllowUserToDeleteRows = false;
            this.GridCliente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GridCliente.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.GridCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridCliente.GridColor = System.Drawing.Color.Black;
            this.GridCliente.Location = new System.Drawing.Point(58, 191);
            this.GridCliente.Margin = new System.Windows.Forms.Padding(2);
            this.GridCliente.Name = "GridCliente";
            this.GridCliente.ReadOnly = true;
            this.GridCliente.RowHeadersVisible = false;
            this.GridCliente.RowHeadersWidth = 51;
            this.GridCliente.Size = new System.Drawing.Size(581, 223);
            this.GridCliente.TabIndex = 11;
            // 
            // cmbClientes
            // 
            this.cmbClientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbClientes.FormattingEnabled = true;
            this.cmbClientes.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cmbClientes.ItemHeight = 23;
            this.cmbClientes.Location = new System.Drawing.Point(400, 109);
            this.cmbClientes.Name = "cmbClientes";
            this.cmbClientes.Size = new System.Drawing.Size(239, 29);
            this.cmbClientes.TabIndex = 12;
            this.cmbClientes.UseSelectable = true;
            // 
            // PedidoView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmbClientes);
            this.Controls.Add(this.GridCliente);
            this.Controls.Add(this.cmbUsuarios);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "PedidoView";
            this.Text = "PedidoView";
            this.Load += new System.EventHandler(this.PedidoView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridCliente)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroComboBox cmbUsuarios;
        private System.Windows.Forms.DataGridView GridCliente;
        private MetroFramework.Controls.MetroComboBox cmbClientes;
    }
}