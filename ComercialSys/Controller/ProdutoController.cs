using ComercialSys.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComercialSys.Controller
{
    public class ProdutoController : ProdutoModel
    {

        public void ConsultaCodBar(string _codbar)
        {
            ProdutoModel prod = ConsultarPorCodBar(_codbar.Trim());

            Id = prod.Id;
            Codbar = prod.Codbar;
            Desconto = prod.Desconto;
            Descricao = prod.Descricao;
            Valor = prod.Valor;
        }
    }
}
