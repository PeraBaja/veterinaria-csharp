
using System.ComponentModel.DataAnnotations;

namespace VeterinariaPractica.Modelos {
    class Persona {
        [Required(ErrorMessage = "Se necesita un mail")]
        [EmailAddress(ErrorMessage = "El email ingresado no es válido")]
        public string Email { get; set; } = string.Empty;
        public TipoTeléfono TipoTeléfono { get; set; }
        
        [Required(ErrorMessage = "Se necesita un nombre")]
        public string Nombre { get; set; } = string.Empty;

        [Required(ErrorMessage = "Se necesita un estado")]
        public Estado Estado { get; set; } = new Estado();

        [Phone(ErrorMessage = "El teléfono ingresado no es válido")]
        public string Teléfono { get; set; } = string.Empty;

        [RegularExpression(@"^\d+\s[A-z]+\s[A-z]+", ErrorMessage = "La dirección ingresada no es válida")]
        public string Dirección { get; set; } = string.Empty;
    }
    class Dueño : Persona {
        public List<Mascota> Mascotas { get; private set; } = [];
    } 

    class Veterinario : Persona {
        [Required(ErrorMessage = "Se necesita un número de matrícula")]
        public string NúmeroMatrícula { get; set;} = string.Empty;
    }

}