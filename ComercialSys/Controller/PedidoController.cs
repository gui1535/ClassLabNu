using ComercialSys.Model;
using System;
using System.Windows.Forms;

namespace ComercialSys.Controller
{
    public class PedidoController : PedidoModel
    {
        /// <summary>
        /// Metodo para criar um pedido
        /// </summary>
        /// <param name="cmbCli">ComboBox</param>
        /// <param name="cmbUser">ComboBox</param>
        public void CriarPedido(ComboBox cmbCli, ComboBox cmbUser)
         {

            // Valores do ComboBox
            Cliente = new ClienteModel(Convert.ToInt32(cmbCli.SelectedValue));
            Usuario = new UsuarioModel(Convert.ToInt32(cmbUser.SelectedValue));

            // Inserindo Pedido
            Inserir();

            // Valores para propriedades
            Id = Convert.ToInt32(Id);
            DataPed = DataPed;
            Status = Status == "A" ? "ABERTO" : "";
        }
    }
}