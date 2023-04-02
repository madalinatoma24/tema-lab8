using System;
using System.Collections.Generic;
using System.Text;

namespace tema_lab8
{
    class Vagoane
    {
        private double masa;
        private int anFabricatie;

        private VagonClasaIntai vagonClasaIntai;
        private VagonPersoane vagonPersoane;
        private VagonMarfa vagonMarfa;

        public Vagoane(int anFabricatie, double masa)
        {
            this.anFabricatie = anFabricatie;
            this.masa = masa;
        }

        public Vagoane(double masa, int anFabricatie, VagonClasaIntai vagonClasaIntai, VagonPersoane vagonPersoane, VagonMarfa vagonMarfa)
        {
            this.masa = masa;
            this.anFabricatie = anFabricatie;
            this.vagonClasaIntai = vagonClasaIntai;
            this.vagonPersoane = vagonPersoane;
            this.vagonMarfa = vagonMarfa;
        }
    }
}
