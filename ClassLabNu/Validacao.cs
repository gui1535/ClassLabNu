using System;

namespace ClassLabNu
{
    public static class Validacao
    {
        public static string Numero { get; set; }

        // Validar email
        public static bool EmailValido(string email)
        {
            try
            {
                var enderecoEmail = new System.Net.Mail.MailAddress(email);
                return enderecoEmail.Address == email;
            }
            catch
            {
                return false;
            }
        }
    }
}
