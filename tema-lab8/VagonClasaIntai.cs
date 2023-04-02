using System;

namespace tema_lab8
{
    class VagonClasaIntai: VagonPersoane
    {
        public VagonClasaIntai(int nrPersoan, int anFabricatie, double masa=1000) : 
            base(nrPersoan, anFabricatie, masa)
        {
        }

        public void PornireAc() 
        {
            Console.WriteLine("AC pornit");
        }

        public void OprireAc()
        {
            Console.WriteLine("AC oprit");
        }
    }
}
