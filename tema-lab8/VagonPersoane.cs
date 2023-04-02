using System;

namespace tema_lab8
{
    class VagonPersoane : Vagoane
    {
        private int nrPersoan;

        public VagonPersoane(int nrPersoan, int anFabricatie, double masa ) 
            : base(anFabricatie, masa)
        {
            this.nrPersoan = nrPersoan;
                 
        }

        public int NrLocuri { get { return this.nrPersoan; } }

        public void InchideUsi()
        {
            Console.WriteLine("Inchis usi");
        }

        public void DeschideUsi()
        {
            Console.WriteLine("Deschis usi");
        }
    }
}
