using System.Runtime.InteropServices.Swift;
using VeterinariaPractica.Modelos;
using VeterinariaPractica.Vistas;

namespace VeterinariaPractica.Controladores {
    abstract class ControladorBase {
        IVistable<Veterinario> _vista;
        public ControladorBase(IVistable<Veterinario> vista) {
            _vista = vista;
        }
        public virtual void Agregar() {

        }
        public virtual void Eliminar() {
            
        }
        public virtual void Modificar() {
            
        }
        public virtual void Listar() {
            
        }
    }
}