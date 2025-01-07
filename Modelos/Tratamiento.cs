
using System.ComponentModel.DataAnnotations;

namespace VeterinariaPractica.Modelos {
    class Tratamiento {

        [Required(ErrorMessage = "Se necesita un código")]
        public string Código { get; set; } = "";

        [Required(ErrorMessage = "Se necesita una observación")]
        [MaxLength(300, ErrorMessage = "La observacion debe ser menor a 300 caracteres")]
        public string Observación { get; set; } = "";
    }
}