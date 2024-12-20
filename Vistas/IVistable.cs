using Microsoft.VisualBasic;

namespace VeterinariaPractica.Vistas {
    public interface IVistable<T> {
        public void Mostrar(string código);

        public void Listar();

        public T PedirDatos();
    }
}