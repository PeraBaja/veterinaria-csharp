using VeterinariaPractica.Modelos;
namespace VeterinariaPractica.Vistas {
    class VistaVeterinario: IVistable<Veterinario> {        
        public void Mostrar(Veterinario veterinario) {
                Console.WriteLine($"Número de matrícula: {veterinario.NúmeroMatrícula}");
                Console.WriteLine($"Nombre: {veterinario.Nombre}");
                Console.WriteLine($"Email: {veterinario.Email}");
                Console.WriteLine($"Teléfono: {veterinario.Teléfono ?? "-"} | {veterinario.TipoTeléfono}");
                Console.WriteLine($"Dirección: {veterinario.Dirección ?? "-"}");
        }

        public void Listar(List<Veterinario> veterinarios) {
            foreach (Veterinario veterinario in veterinarios){
                Console.WriteLine("------------------------");
                Mostrar(veterinario);
                Console.WriteLine("------------------------");
            }
        }

        public Veterinario PedirDatos() {
            Console.WriteLine("Ingrese el número de matrícula del veterinario");
            string númeroMatricula = Console.ReadLine() ?? "";
            Console.WriteLine("Ingrese el nombre del veterinario");
            string nombre = Console.ReadLine() ?? "";
            Console.WriteLine("Ingrese el email del veterinario");
            string email = Console.ReadLine() ?? "";

            return new Veterinario{
                NúmeroMatrícula = númeroMatricula,
                Nombre = nombre,
                Email = email
                };
        }
    }
}