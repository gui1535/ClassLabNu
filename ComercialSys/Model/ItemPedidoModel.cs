using System;
using System.Data;
using System.Windows.Forms;

namespace ComercialSys.Model
{
    public class ItemPedidoModel
    {
        // idped_ip	idprod_ip	valor	quantidade	desconto
        // Atributos
        public ProdutoModel Produto { get; set; }
        public PedidoModel Pedido { get; set; }
        public double Valor { get; set; }
        public double Quantidade { get; set; }
        public double Desconto { get; set; }


        // Construtores

        public ItemPedidoModel()
        {

        }

        public ItemPedidoModel(ProdutoModel produto, double valor, double quantidade, double desconto)
        {
            this.Produto = produto;
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
                banco.Parameters.AddWithValue("_idped", Pedido.Id);
                banco.Parameters.AddWithValue("_idprod", Produto.Id);
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

        public void Alterar(ItemPedidoModel item)
        {

        }
    }
}
