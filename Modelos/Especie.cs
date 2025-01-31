using System.ComponentModel.DataAnnotations;

namespace VeterinariaPractica.Modelos {

    
    class Especie {
        [Required(ErrorMessage = "Se necesita el nombre coloquial de la especie")]
        public string NombreColoquial { get; set; } = string.Empty;
        public string NombreCientífico { get; set; } = string.Empty;
        public Estado Estado { get; set; } = new Estado();
    }
}