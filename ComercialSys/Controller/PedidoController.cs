using ComercialSys.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComercialSys.Controller
{
    public class PedidoController
    {
        public string IdPedido { get; set; }
        public string DataPedido { get; set; }
        public string StatusPedido { get; set; }

        /// <summary>
        /// Metodo para criar um pedido
        /// </summary>
        /// <param name="cmbCli">ComboBox</param>
        /// <param name="cmbUser">ComboBox</param>
        public void CriarPedido(ComboBox cmbCli, ComboBox cmbUser)
        {
            // Objeto Pedido
            PedidoModel ped = new PedidoModel();

            // Valores do ComboBox
            ped.Cliente = new ClienteModel(Convert.ToInt32(cmbCli.SelectedValue));
            ped.Usuario = new UsuarioModel(Convert.ToInt32(cmbUser.SelectedValue));

            // Inserindo Pedido
            ped.Inserir();

            // Valores para propriedades
            IdPedido = ped.Id.ToString();
            DataPedido = ped.DataPed;
            StatusPedido = ped.Status == "A" ? "ABERTO" : "";
        }
    }
}
