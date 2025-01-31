using System.Runtime.InteropServices.Swift;
using VeterinariaPractica.Modelos;
using VeterinariaPractica.Vistas;

namespace VeterinariaPractica.Controladores {
    abstract class ControladorBase<T> {
        protected IVistable<T> _vista;
        public ControladorBase(IVistable<T> vista) {
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