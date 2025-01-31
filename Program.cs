using System.Text;
using VeterinariaPractica.Controladores;
using VeterinariaPractica.Modelos;
using VeterinariaPractica.Vistas;
namespace VeterinariaPractica // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (!Directory.Exists("Archivos")) {
                Directory.CreateDirectory("Archivos");
            }
            Console.OutputEncoding = Encoding.UTF8;
            VistaVeterinario vistaVeterinario = new VistaVeterinario();

            ControladorVeterinario controladorVeterinario = new ControladorVeterinario(vistaVeterinario);
            controladorVeterinario.Agregar();
            controladorVeterinario.Listar();
        }
    }
}