using System.Numerics;

namespace VeterinariaPractica.Modelos {
    class Vacuna {
        public ulong centavos;
        public string tipoVacuna = "";
        public Vacuna(string codigo, string tipoVacuna, ulong centavos) {
            this.centavos = centavos;
        }
    }
}