using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace ComercialSys.Model
{
    public class PedidoModel
    {
        // Atributos

        public int Id { get; set; }
        public string DataPed { get; set; }
        public string Status { get; set; }
        public double Desconto { get; set; }
        public ClienteModel Cliente { get; set; }
        public UsuarioModel Usuario { get; set; }
        public List<ItemPedidoModel> Itens { get; set; }

        // Construtores

        public PedidoModel()
        {
        }

        public PedidoModel(string dataPed, string status, double desconto, ClienteModel cliente, UsuarioModel usuario, List<ItemPedidoModel> itens)
        {
            this.DataPed = dataPed;
            this.Status = status;
            this.Desconto = desconto;
            this.Cliente = cliente;
            this.Usuario = usuario;
            this.Itens = itens;
        }
        public PedidoModel(int id, string dataPed, string status, double desconto, ClienteModel cliente, UsuarioModel usuario, List<ItemPedidoModel> itens)
        {
            Id = id;
            DataPed = dataPed;
            Status = status;
            this.Desconto = desconto;
            this.Cliente = cliente;
            this.Usuario = usuario;
            this.Itens = itens;
        }

        // Metodos

        public void Inserir()
        {
            try
            {
                // Abre conexão com banco
                var banco = BancoModel.Abrir();

                // Comandos SQL
                banco.CommandType = CommandType.StoredProcedure;
                banco.CommandText = "pedido_inserir";

                // Parametros
                banco.Parameters.AddWithValue("_idcli", Cliente.Id);
                banco.Parameters.AddWithValue("_iduser", Usuario.Id);

                // Leitura
                var dr = banco.ExecuteReader();

                // Consulta
                dr.Read();

                Id = dr.GetInt32(0);
                Status = Convert.ToString(dr.GetString(1));
                DataPed = Convert.ToString(dr.GetString(2));


                // Fecha Conexão
                banco.Connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "SysComercial", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Alterar()
        {
            try // Faça
            {
                // Abrir conexão com banco
                var cmd = BancoModel.Abrir();

                // Comandos SQL
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "altera_Pedido";
                cmd.Parameters.AddWithValue("_idped", Id);
                cmd.Parameters.AddWithValue("_status", Status);
                cmd.Parameters.AddWithValue("_desconto", Desconto);
                cmd.ExecuteNonQuery();
            }
            catch (Exception) // Exception
            {
                throw;
            }
        }

        public void ConsultarPorId(int _id)
        {
            // Abre conexão com banco
            var cmd = BancoModel.Abrir();

            // Comandos SQL
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "select * from pedidos where id = " + _id;

            // Variavel para consulta
            var dr = cmd.ExecuteReader();

            // Consulta
            while (dr.Read())
            {
                Id = dr.GetInt32(0);
                DataPed = dr.GetString(1);
                Status = dr.GetString(2);
                Desconto = dr.GetDouble(3);
            }
        }

        public static List<PedidoModel> ConsultarPorClienteId(int _id)
        {
            List<PedidoModel> pedidos = new List<PedidoModel>();
            return pedidos;
        }

    }
}