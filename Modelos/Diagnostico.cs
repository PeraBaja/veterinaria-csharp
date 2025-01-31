using System.ComponentModel.DataAnnotations;

namespace VeterinariaPractica.Modelos {
    class Diagnóstico {
        [Required(ErrorMessage = "Se necesita un código")]
        public string Código { get; set;} = string.Empty;
        [Required(ErrorMessage = "Se necesita una observación ")]
        [MaxLength(300, ErrorMessage = "La observacion debe ser menor a 300 caracteres")]
        public string Observación { get; set; } = string.Empty;
    }
}