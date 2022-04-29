using ComercialSys.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComercialSys.Controller
{
    public class UsuarioController
    {

        public static void ListUserBox(ComboBox cmb)
        {
            // Listando Clientes ComboBox
            cmb.DataSource = UsuarioModel.ListarUsuarios().ToArray();
            cmb.DisplayMember = "Nome";
            cmb.ValueMember = "Id";

            // Tipo de DropDown
            cmb.DropDownStyle = ComboBoxStyle.DropDownList;
        }
    }
}
