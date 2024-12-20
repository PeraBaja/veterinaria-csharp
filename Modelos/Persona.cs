
using System.Text.RegularExpressions;
using VeterinariaPractica.Utilidades;
namespace VeterinariaPractica.Modelos {
    class Persona {
        string _nombre = "";
        public readonly string email;
        string _telefono = "";
        string _direccion = "";
        public TipoTelefono tipoTelefono;
        public string Nombre { get => _nombre; set {
        if (string.IsNullOrEmpty(value)) {
            throw new ArgumentException("El nombre debe ser mayor a 6 caracteres.");
        }
            _nombre = value;
        }}

        public Estado Estado { get; private set; }
        string Telefono { get => _telefono; set {
            string patron = @"^\+?\d{1,4}?[-.\s]?\(?\d{1,3}?\)?[-.\s]?\d{3}[-.\s]?\d{4,6}$";
            if (!Regex.IsMatch(value, patron)) {
                throw new ArgumentException("El telefono ingresado no es válido");
            }
            _telefono = value;
        }}
        string Direccion { get => _direccion; set {
              string patron = @"^\d+\s[A-z]+\s[A-z]+";
              if (!Regex.IsMatch(value, patron)) {
                throw new ArgumentException("El telefono ingresado no es válido");
            }
            _direccion = value;
        }}
        public Persona(string nombre, string email, Estado estado) {  
            if (!Validaciones.EsEmailValido(email)){
                throw new ArgumentException("El mail ingresado no es válido.");
            }
            this.email = email;
            Nombre = nombre;
            Estado = estado;
        }
    }
    class Dueño : Persona {
        public List<Mascota> Mascotas { get; private set; } 
        public Dueño(string nombre, string email, Estado estado)
        : base(nombre, email, estado){
            Mascotas = new List<Mascota>();
        }
    } 

    class Veterinario : Persona {
        public readonly string númeroMatricula;
         public Veterinario(string númeroMatricula, string nombre, string email, Estado estado)
        : base(nombre, email, estado){
            this.númeroMatricula = númeroMatricula;
        }
    }

}