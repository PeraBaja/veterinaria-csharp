using VeterinariaPractica.Modelos;
namespace VeterinariaPractica.Vistas {
    class VistaMascota: IVistable<Mascota> {        
        public void Mostrar(Mascota mascota) {
                Console.WriteLine($"Nombre: {mascota.Nombre}");
                Console.WriteLine($"Especie: {mascota.Especie}");
                Console.WriteLine($"Email dueño: {mascota.EmailDueño ?? "-"}");
                Console.WriteLine($"Código: {mascota.Código ?? "-"}");
        }

        public void Listar(List<Mascota> mascotas) {
            foreach (Mascota mascota in mascotas){
                Console.WriteLine("------------------------");
                Mostrar(mascota);
                Console.WriteLine("------------------------");
            }
        }

        public Mascota PedirDatos() {
            Console.WriteLine("Ingrese el nombre de la mascota");
            string nombre = Console.ReadLine() ?? "";

            return new Mascota{
                Nombre = nombre
                };
        }
    }
}