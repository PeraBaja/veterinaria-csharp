

namespace VeterinariaPractica.Modelos {
    class Mascota {
        
        public readonly string codigo;
        public Raza ?Raza { get; private set; }
        public Dueño Dueño { get; private set; }
        string _nombre;
        string _especie;
        public string Nombre { get => _nombre;  set {
            if(string.IsNullOrEmpty(value)){
                throw new ArgumentException("La mascota debe tener un nombre");
            }
            _nombre = value;
        } }
        public string Especie { get => _especie;  set {
            if (string.IsNullOrEmpty(value)) {
                throw new ArgumentException("Se debe de indicar una especie");
            }
            _especie = value;
        } }
        public Mascota(string codigo, string nombre, Dueño dueño, string especie, Estado estado) {
            if(string.IsNullOrEmpty(codigo)) {
                throw new ArgumentException("El codigo no debe estar vacío");
            }
            if(string.IsNullOrEmpty(nombre)){
                throw new ArgumentException("La mascota debe tener un nombre");
            }
            if(string.IsNullOrEmpty(especie)){
                throw new ArgumentException("Se debe de indicar una especie");
            }
            this.codigo = codigo;
            Dueño = dueño;
            _nombre = nombre;
            _especie = especie;
        }
    }
}