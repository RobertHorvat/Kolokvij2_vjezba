using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolokvij2_vjezba
{
    public class PjesmaNaAlbumu
    {
        private int RedniBrojPjesme;
        private string naziv;
        private long trajanje;
        private Izvodac izvodac;

        public PjesmaNaAlbumu(int RedniBrojPjesme,string naziv,long trajanje,Izvodac izvodac)
        {
            this.RedniBrojPjesme = RedniBrojPjesme;
            this.naziv = naziv;
            this.trajanje = trajanje;
            this.izvodac = izvodac;
        }

        public override string ToString()
        {
            return RedniBrojPjesme.ToString()+ ". " + naziv+ "\n"+trajanje+ "\n"+izvodac;
        }

        public long VratiTrajanje()
        {
            return trajanje;
        }

        public int VratiRedniBroj()
        {
            return RedniBrojPjesme;
        }
}
}
