namespace ComercialSys
{
    partial class FormPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            this.mtClientes = new MetroFramework.Controls.MetroTile();
            this.mtUsuarios = new MetroFramework.Controls.MetroTile();
            this.mtProdutos = new MetroFramework.Controls.MetroTile();
            this.mtPedidos = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // mtClientes
            // 
            this.mtClientes.ActiveControl = null;
            this.mtClientes.Location = new System.Drawing.Point(34, 61);
            this.mtClientes.Name = "mtClientes";
            this.mtClientes.Size = new System.Drawing.Size(71, 47);
            this.mtClientes.TabIndex = 2;
            this.mtClientes.Text = "Clientes";
            this.mtClientes.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.mtClientes.TileImage = ((System.Drawing.Image)(resources.GetObject("mtClientes.TileImage")));
            this.mtClientes.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.mtClientes.UseSelectable = true;
            this.mtClientes.UseTileImage = true;
            this.mtClientes.Click += new System.EventHandler(this.mtClientes_Click);
            // 
            // mtUsuarios
            // 
            this.mtUsuarios.ActiveControl = null;
            this.mtUsuarios.Location = new System.Drawing.Point(147, 61);
            this.mtUsuarios.Name = "mtUsuarios";
            this.mtUsuarios.Size = new System.Drawing.Size(71, 47);
            this.mtUsuarios.TabIndex = 3;
            this.mtUsuarios.Text = "Usuarios";
            this.mtUsuarios.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.mtUsuarios.TileImage = ((System.Drawing.Image)(resources.GetObject("mtUsuarios.TileImage")));
            this.mtUsuarios.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.mtUsuarios.UseSelectable = true;
            this.mtUsuarios.UseTileImage = true;
            // 
            // mtProdutos
            // 
            this.mtProdutos.ActiveControl = null;
            this.mtProdutos.Location = new System.Drawing.Point(260, 61);
            this.mtProdutos.Name = "mtProdutos";
            this.mtProdutos.Size = new System.Drawing.Size(71, 47);
            this.mtProdutos.TabIndex = 4;
            this.mtProdutos.Text = "Produtos";
            this.mtProdutos.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.mtProdutos.TileImage = ((System.Drawing.Image)(resources.GetObject("mtProdutos.TileImage")));
            this.mtProdutos.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.mtProdutos.UseSelectable = true;
            this.mtProdutos.UseTileImage = true;
            // 
            // mtPedidos
            // 
            this.mtPedidos.ActiveControl = null;
            this.mtPedidos.Location = new System.Drawing.Point(373, 61);
            this.mtPedidos.Name = "mtPedidos";
            this.mtPedidos.Size = new System.Drawing.Size(71, 47);
            this.mtPedidos.TabIndex = 5;
            this.mtPedidos.Text = "Pedidos";
            this.mtPedidos.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.mtPedidos.TileImage = ((System.Drawing.Image)(resources.GetObject("mtPedidos.TileImage")));
            this.mtPedidos.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.mtPedidos.UseSelectable = true;
            this.mtPedidos.UseTileImage = true;
            // 
            // FormPrincipal
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1376, 712);
            this.Controls.Add(this.mtPedidos);
            this.Controls.Add(this.mtClientes);
            this.Controls.Add(this.mtProdutos);
            this.Controls.Add(this.mtUsuarios);
            this.IsMdiContainer = true;
            this.Name = "FormPrincipal";
            this.Padding = new System.Windows.Forms.Padding(10, 120, 10, 10);
            this.Text = "SysComercial";
            this.TransparencyKey = System.Drawing.Color.Empty;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile mtClientes;
        private MetroFramework.Controls.MetroTile mtUsuarios;
        private MetroFramework.Controls.MetroTile mtProdutos;
        private MetroFramework.Controls.MetroTile mtPedidos;
    }
}