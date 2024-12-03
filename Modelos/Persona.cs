using System.Net.Mail;

namespace VeterinariaPractica.Modelos {
    class Persona {
        string _nombre;
        string _email;
        string _telefono;
        string _direccion;
        public TipoTelefono TipoTelefono;
        public string Nombre { get => _nombre; set {
        if (value.Length < 6 ) {
            throw new ArgumentException("El nombre debe ser mayor a 6 caracteres.");
        }
            _nombre = value;
        }}
        
        public string Email { get => _email; set {
            try{
                MailAddress mail = new MailAddress(value);
            }
            catch {
                throw new ArgumentException("El mail ingresado no es válido.");
            }
            finally {
                _email = value;
            }
        }}
        public Estado Estado { get; private set; }
        string Telefono { get => _telefono; set {value}}
        string Direccion { get => _direccion; set {value}}
        public Persona(string nombre, TipoTelefono tipoTelefono, string email, Estado estado, string telefono = "", string direccion = "") {
            Nombre = nombre;
            TipoTelefono = tipoTelefono;
            Email = email;
            Estado = estado;
            Telefono = telefono;
            Direccion = direccion;
        }
    }
}