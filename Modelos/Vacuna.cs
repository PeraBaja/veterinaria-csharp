using System.ComponentModel.DataAnnotations;

namespace VeterinariaPractica.Modelos {
    class Vacuna {
        [Required(ErrorMessage = "Especifique el precio de la vacuna")]
        public ulong Centavos { get; set;} = 0;
        public string Nombre { get; set;} = string.Empty;
    }
}