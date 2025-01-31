using System.ComponentModel.DataAnnotations;

namespace VeterinariaPractica.Modelos {
    class FichaMédica {
        [Required(ErrorMessage="Se necesita un código")]
        public string Código { get; set;} = string.Empty;
        
        public List<string> CódigosConsultas { get; set;} = [];
        [Required(ErrorMessage ="Se necesita un mail")]
        [EmailAddress(ErrorMessage ="El mail ingresado no es válido")]
        public string EmailVeterinario { get; set;} = string.Empty;  
        
    }

}