using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComercialSys.Model
{
    public class NumeroModel
    {
        public int Idcli { get; set; }
        public string Numero { get; set; }
        public string Tipo { get; set; }

        public NumeroModel(int idcli, string numero, string tipo)
        {
            Idcli = idcli;
            Numero = numero;
            Tipo = tipo;
        }
        public NumeroModel() { }

        public void Inserir()
        {
            try
            {
                // Abre conexão com banco
                var banco = BancoModel.Abrir();

                // Comandos SQL
                banco.CommandType = CommandType.StoredProcedure;
                banco.CommandText = "inserir_telefone";

                // Parametros
                banco.Parameters.AddWithValue("_idcli", Idcli);
                banco.Parameters.AddWithValue("_numero", Numero);
                banco.Parameters.AddWithValue("_tipo", Tipo);

                banco.ExecuteScalar();

                // Fecha Conexão
                banco.Connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocorreu um erro, verifique os valores digitados {ex}", "SysComercial", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        public void ListarTelefonesCli(int _idCli)
        {
            // Abre conexão com banco
            var cmd = BancoModel.Abrir();

            // Comandos SQL
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "select * from telefone where idcli = " + _idCli;

            // Variavel para consulta
            var dr = cmd.ExecuteReader();

            // Consulta
            while (dr.Read())
            {
                Idcli = dr.GetInt32(0);
                Numero = dr.GetString(1);
                Tipo = dr.GetString(2);
            }
        }




    }
}