using System;
using System.Collections.Generic;
using System.Text;

namespace tema_lab8
{
    class VagonMarfa: Vagoane
    {
       public enum TipMarfa
        {
            cereale,
            carbuni,
            otel
        }
        private TipMarfa tipMarfa;
        private int capacitate;

        public VagonMarfa(TipMarfa tipMarfa, int capacitate, int anFabricatie, double masa = 100):
            base(anFabricatie, masa)
        {
            this.tipMarfa = tipMarfa;
            this.capacitate = capacitate;
        }

        public void getTipMarfa()
        {
            Console.WriteLine($"Tip marfa: {tipMarfa}");
        }
    }
}
