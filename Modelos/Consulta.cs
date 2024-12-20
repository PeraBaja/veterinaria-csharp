using System.Dynamic;

namespace VeterinariaPractica.Modelos {
    class Consulta {
        public Vacuna? Vacuna {get; private set;}
        public Diagnóstico Diagnóstico {get; private set;}
        public Tratamiento Tratamiento {get; private set;}
        public Veterinario Veterinario {get; private set;}
        public Consulta(string código, Diagnóstico diagnóstico, Tratamiento tratamiento, Veterinario veterinario) {
            if(string.IsNullOrEmpty(código)) {
                    throw new ArgumentException("El código no debe estar vacío");
            }
            Diagnóstico = diagnóstico;
            Tratamiento = tratamiento;
            Veterinario = veterinario;
        }
    }
}