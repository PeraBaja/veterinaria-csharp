using System.Net.Mail;
namespace VeterinariaPractica.Utilidades {
    static class Validaciones {
        public static bool EsEmailValido(string value) {
            try{
                MailAddress email = new MailAddress(value);
            }
            catch {
                return false;
            }
            return true;
        }
    }
}