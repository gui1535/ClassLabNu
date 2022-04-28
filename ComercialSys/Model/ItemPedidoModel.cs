using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace ComercialSys.Model
{
    public class ItemPedidoModel
    {
        // idped_ip	idprod_ip	valor	quantidade	desconto
        // Atributos
        public int Produto { get; set; }
        public int Pedido { get; set; }
        public double Valor { get; set; }
        public double Quantidade { get; set; }
        public double Desconto { get; set; }


        // Construtores

        public ItemPedidoModel()
        {

        }

        public ItemPedidoModel(int produto, double valor, double quantidade, double desconto)
        {
            this.Produto = produto;
            this.Valor = valor;
            this.Quantidade = quantidade;
            this.Desconto = desconto;
        }
        public ItemPedidoModel(int produto, int pedido, double valor, double quantidade, double desconto)
        {
            this.Produto = produto;
            Pedido = pedido;
            this.Valor = valor;
            this.Quantidade = quantidade;
            this.Desconto = desconto;
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
                banco.CommandText = "itempedido_inserir";

                // Parametros
                banco.Parameters.AddWithValue("_idped", Pedido);
                banco.Parameters.AddWithValue("_idprod", Produto);
                banco.Parameters.AddWithValue("_quantidade", Quantidade);
                banco.Parameters.AddWithValue("_valor", Valor);
                banco.Parameters.AddWithValue("_desconto", Desconto);

                // Leitura
                var dr = banco.ExecuteReader();

                // Fecha Conexão
                banco.Connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "SysComercial", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static List<ItemPedidoModel> ListarItensPedido(int _idPed)
        {
            // Nova lista
            List<ItemPedidoModel> lista = new List<ItemPedidoModel>();

            // Abrir conexão
            var banco = BancoModel.Abrir();

            // Comando
            banco.CommandType = CommandType.Text;
            banco.CommandText = $"select * from itempedido where idped = {_idPed}";

            // Var para Consulta
            var dr = banco.ExecuteReader();

            // Consulta
            while (dr.Read())
            {
                lista.Add(new ItemPedidoModel(
                    Convert.ToInt32(dr.GetValue(0)),
                    dr.GetInt32(1),
                    dr.GetDouble(2),
                    dr.GetDouble(3),
                    dr.GetDouble(4)
                    ));
            }

        // Fecha Conexão
        banco.Connection.Close();

            // Retornando lista
            return lista;
        }
    }
}
