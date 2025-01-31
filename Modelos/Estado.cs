namespace VeterinariaPractica.Modelos {
    class Estado {
        public DateTime FechaAlta { get; set; } = DateTime.Now;
        public bool Activo { get; set;} = true;
        
        public void DarDeAlta() {
            this.FechaAlta = DateTime.Now;
            Activo = true;
        }

        public void DarDeBaja() {
            Activo = false;
        }
    }
}