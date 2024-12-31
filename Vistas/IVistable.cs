using Microsoft.VisualBasic;

namespace VeterinariaPractica.Vistas {
    public interface IVistable<T> {
        public void Mostrar(T objeto);

        public void Listar(List<T> objetos);

        public T PedirDatos();
    }
}