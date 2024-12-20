namespace VeterinariaPractica.Modelos {
    class Tratamiento {
        public readonly string código;
        string _observación = "";
        public string Observación { get => _observación; set {
            if(string.IsNullOrEmpty(value)) {
                throw new ArgumentException("El código no debe estar vacío");
            }
            _observación = Observación;
        }}
        public Tratamiento(string código, string observación) {
            if(string.IsNullOrEmpty(código)) {
                    throw new ArgumentException("El código no debe estar vacío");
            }
            if(string.IsNullOrEmpty(observación)) {
                throw new ArgumentException("El código no debe estar vacío");
            }
            this.código = código;
            Observación = observación;
        }
    }
}