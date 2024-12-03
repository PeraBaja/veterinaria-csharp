namespace VeterinariaPractica.Modelos {
    class Estado {
        public DateTime FechaAlta { get; private set; }
        public bool Activo { get; private set;}
        public Estado(bool activo = true, DateTime? fechaAlta = null){
            this.FechaAlta = fechaAlta ?? DateTime.Now;
        }
        public void DarDeAlta() {
            this.FechaAlta = DateTime.Now;
            Activo = true;
        }

        public void DarDeBaja() {
            Activo = false;
        }
    }
}