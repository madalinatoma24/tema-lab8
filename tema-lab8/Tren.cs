using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace tema_lab8
{
    class Tren
    {
        private string nume;
        private List<Vagoane> vagoane = new List<Vagoane>();
        private Locomotiva locomotiva;

        public Tren(string nume, Locomotiva locomotiva)
        {
            this.nume = nume;
            this.locomotiva = locomotiva;
        }

        public int NrLocuri {
            get {
                int nrLocuri = 0;
                foreach (Vagoane vagon in vagoane)
                {
                    if (vagon is VagonPersoane)
                    {
                        VagonPersoane vagonPersoane = vagon as VagonPersoane;
                        nrLocuri += vagonPersoane.NrLocuri;
                    }
                }
                return nrLocuri;
            }
        }
        public void AdaugaVagon(Vagoane vagon)
        {
            vagoane.Add(vagon);
        }

        public void PleacaDinGara()
        {
            foreach(Vagoane vagon in vagoane)
            {
                if(vagon is VagonPersoane)
                {
                    VagonPersoane vagonPersoane = vagon as VagonPersoane;
                    vagonPersoane.InchideUsi();
                }
            }
            locomotiva.Pornire();

        }
        public void OpresteDinGara()
        {

            locomotiva.Oprire();
            foreach (Vagoane vagon in vagoane)
            {
                if (vagon is VagonClasaIntai)
                {
                    VagonClasaIntai vagonClasaIntai = vagon as VagonClasaIntai;
                    vagonClasaIntai.PornireAc();
                }
                else if(vagon is VagonPersoane)
                {
                    VagonPersoane vagonPersoane = vagon as VagonPersoane;
                    vagonPersoane.DeschideUsi();
                } else if (vagon is VagonMarfa)
                {
                    VagonMarfa vagonMarfa = vagon as VagonMarfa;
                    vagonMarfa.getTipMarfa();
                }
            }
        }
    }
}
