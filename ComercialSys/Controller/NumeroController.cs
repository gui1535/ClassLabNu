using ComercialSys.Model;
using System;

namespace ComercialSys.Controller
{
    public class NumeroController : NumeroModel
    {

        public void AdicionarTelefone
        (
        int _idCli,
        string _numero,
        string _tipo
        )
        {
            Idcli = _idCli;
            Numero = _numero;
            Tipo = _tipo;

            // Atribuindo valor do TextBox para o ClienteID
            int ClienteID = _idCli;

            Idcli = ClienteID;

            // Inserir endereco
            Inserir();
        }
        public void ListaTelefone(int _idcli)
        {
            ListarTelefonesCli(_idcli);
        }

    }
}
