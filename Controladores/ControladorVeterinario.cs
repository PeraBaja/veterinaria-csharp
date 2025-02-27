

using System.Text;
using System.Text.Encodings.Web;
using System.Text.Json;
using VeterinariaPractica.Modelos;
using VeterinariaPractica.Vistas;

namespace VeterinariaPractica.Controladores {
    class ControladorVeterinario: ControladorBase<Veterinario> {
        List<Veterinario> _veterinarios = new List<Veterinario>();
        public ControladorVeterinario(VistaVeterinario vista): base(vista) {
            _vista = vista;
            CargarDesdeJson();
        }
        
        public override void Agregar() {
            Veterinario veterinario = _vista.PedirDatos();
            _veterinarios.Add(veterinario);
            GuardarEnJson();
        }
        public override void Listar() {
            _vista.Listar(_veterinarios);
        }
        public Veterinario Seleccionar() {
            string email = _vista.PedirEmail();
            return _veterinarios.Find(veterinario => veterinario.Email == email);
        }
        public override void Eliminar() { 
            Veterinario veterinarioSeleccionado = Seleccionar();
            _veterinarios.Remove(veterinarioSeleccionado);
        }

        public void CargarDesdeJson() {
            if (!File.Exists("Archivos/veterinarios.json")) return;

            string contenidoJson = File.ReadAllText("Archivos/veterinarios.json", Encoding.UTF8);
            Console.WriteLine("json content: '" + contenidoJson + "'");
            if (string.IsNullOrEmpty(contenidoJson)){
                _veterinarios = [];
            }
            else{
                _veterinarios = JsonSerializer.Deserialize<List<Veterinario>>(contenidoJson, new JsonSerializerOptions() { 
                    WriteIndented = true, 
                    Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping
                    }) ?? [];
            }
            
        } 
        public void GuardarEnJson() {
            File.WriteAllText(
                "Archivos/veterinarios.json", 
                JsonSerializer.Serialize(_veterinarios, new JsonSerializerOptions() { 
                    WriteIndented = true, 
                    Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping
                    }),
                    Encoding.UTF8
            );
        }
    }
}