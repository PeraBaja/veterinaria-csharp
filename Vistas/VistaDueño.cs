using VeterinariaPractica.Modelos;
namespace VeterinariaPractica.Vistas {
    class VistaDueño: IVistable<Dueño> {        
        public void Mostrar(Dueño dueño) {
                Console.WriteLine($"Nombre: {dueño.Nombre}");
                Console.WriteLine($"Email: {dueño.Email}");
                Console.WriteLine($"Teléfono: {dueño.Teléfono ?? "-"} | {dueño.TipoTeléfono}");
                Console.WriteLine($"Dirección: {dueño.Dirección ?? "-"}");
                Console.WriteLine("Mascotas: ");
                foreach(Mascota mascota in dueño.Mascotas) {
                    Console.WriteLine($"\tNombre: {mascota.Nombre} | Código: {mascota.Código}");
                }
        }

        public void Listar(List<Dueño> dueños) {
            foreach (Dueño Dueño in dueños){
                Console.WriteLine("------------------------");
                Mostrar(Dueño);
                Console.WriteLine("------------------------");
            }
        }

        public Dueño PedirDatos() {
            Console.WriteLine("Ingrese su nombre:");
            string nombre = Console.ReadLine() ?? "";
            Console.WriteLine("Ingrese su email:");
            string email = Console.ReadLine() ?? "";

            return new Dueño{
                Nombre = nombre,
                Email = email
                };
        }
    }
}