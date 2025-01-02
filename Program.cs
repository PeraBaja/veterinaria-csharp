using System;
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
            VistaVeterinario vistaVeterinario = new VistaVeterinario();
            new ControladorVeterinario(vistaVeterinario).Listar();
        }
    }
}