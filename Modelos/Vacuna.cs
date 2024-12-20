using System.Numerics;

namespace VeterinariaPractica.Modelos {
    class Vacuna {
        public ulong centavos;

        string _nombre = "";
        public string Nombre { get => _nombre; set {
            if(string.IsNullOrEmpty(value)) {
                throw new ArgumentException("El nombre no debe estar vacío");
            }
            _nombre = value;
        }}
        public Vacuna(string código, string nombre, ulong centavos) {
            if(string.IsNullOrEmpty(código)) {
                throw new ArgumentException("El código no debe estar vacío");
            }
            Nombre = nombre;
            this.centavos = centavos;
        }
    }
}