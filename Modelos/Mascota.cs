

using System.ComponentModel.DataAnnotations;

namespace VeterinariaPractica.Modelos {
    class Mascota {
        
        public string Código { get; set; } = string.Empty;
        public Especie? Especie { get; set; }
        public string Nombre { get; set; } = string.Empty;

        [EmailAddress(ErrorMessage = "El email del dueño ingresado no es válido")]
        public string? EmailDueño {get; set;} = string.Empty;
    }
}