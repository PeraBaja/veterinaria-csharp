using System.Dynamic;
using System.ComponentModel.DataAnnotations;

namespace VeterinariaPractica.Modelos {
    class Consulta {
        [Required(ErrorMessage = "Se necesita de un código")]
        public string Código {get; set;} = string.Empty;
        public Vacuna? Vacuna {get; set;}
        public Diagnóstico? Diagnóstico {get; set;}
        public Tratamiento? Tratamiento {get; set;}
        public Mascota? Veterinario {get; set;}
    }
}