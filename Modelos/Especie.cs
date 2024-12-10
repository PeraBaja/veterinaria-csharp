namespace VeterinariaPractica.Modelos {

    
    class Raza {
        public readonly string nombre;
        public Estado Estado { get; private set; }

        public string detalle;
        public Raza(string nombre, Estado estado, string detalle= "") {
            if (string.IsNullOrEmpty(nombre)) {
                throw new ArgumentException("El nombre no debería estar vacío");
            }
            this.nombre = nombre;
            Estado = estado;
            this.detalle = detalle;
        }
    }
}