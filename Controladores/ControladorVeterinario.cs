

using System.Text.Json;
using System.Text.Json.Serialization;
using VeterinariaPractica.Modelos;
using VeterinariaPractica.Vistas;

namespace VeterinariaPractica.Controladores {
    class ControladorVeterinario: ControladorBase {
        VistaVeterinario _vista;
        List<Veterinario> _veterinarios = new List<Veterinario>();
        public ControladorVeterinario(VistaVeterinario vista): base(vista){
            _vista = vista;
            CargarDesdeJson();
        }
        
        public override void Agregar() {
            Veterinario veterinario = _vista.PedirDatos();
            _veterinarios.Add(veterinario);
            GuardarEnJson();
        }
        public override void Listar()
        {
            _vista.Listar(_veterinarios);
        }

        public void CargarDesdeJson() {
            string jsonContent = File.ReadAllText("Archivos/veterinarios.json");
            _veterinarios = JsonSerializer.Deserialize<List<Veterinario>>(jsonContent) ?? [];
        } 
        public void GuardarEnJson() {
            File.WriteAllText(
                "Archivos/veterinarios.json", 
                JsonSerializer.Serialize(_veterinarios, new JsonSerializerOptions() { WriteIndented = true })
            );
        }
    }
}