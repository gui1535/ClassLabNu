using ClassLabNu;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace ComercialSys
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            // Objeto Cliente
            Cliente c = new Cliente(
                txtNome.Text,
                txtCpf.Text,
                txtEmail.Text);

            c.Inserir();

            if (c.Id > 0)
            {
                txtId.Text = c.Id.ToString();
                MessageBox.Show("Cliente inserido com sucesso", "SysComercial", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Falha ao inserir cliente", "SysComercial", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }


        private void lstClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            // Abrir conexão
            var banco = Banco.Abrir();

            banco.CommandType = CommandType.Text;
            banco.CommandText = "select * from clientes";

            var da = new MySqlDataAdapter(banco);

            DataTable dt = new DataTable();

            da.Fill(dt);
            GridCliente.DataSource = dt;
        }
    }
}
