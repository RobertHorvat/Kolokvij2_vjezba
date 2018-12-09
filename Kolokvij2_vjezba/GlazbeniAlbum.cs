using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolokvij2_vjezba
{
    public class GlazbeniAlbum
    {
        private string naziv;
        private Izvodac izvodac;
        private Zanr zanr;
        private List<PjesmaNaAlbumu> album = new List<PjesmaNaAlbumu>();

        public GlazbeniAlbum(string naziv,Izvodac izvodac,Zanr zanr)
        {
            this.naziv = naziv;
            this.izvodac = izvodac;
            this.zanr = zanr;
        }

        public string VratiNaziv()
        {
            return naziv;
        }

        public Izvodac VratiIzvodaca()
        {
            return izvodac;
        }

        public Zanr VratiZanr()
        {
            return zanr;
        }

        public List<PjesmaNaAlbumu> VratiListuPjesama()
        {
            return album;
            
        }

        public void DodajPjesmu(int RedniBroj,string Naziv,long Trajanje)
        {
            PjesmaNaAlbumu p = new PjesmaNaAlbumu(RedniBroj,Naziv,Trajanje,izvodac);
            album.Add(p);
        }

        public void ObrisiPjesmu(int redni)
        {
            foreach (PjesmaNaAlbumu p in album.ToList())
            {
                if (p.VratiRedniBroj() == redni)
                    album.Remove(p);
            }
        }

        public long vratiTrajanje()
        {
            long trajanje = 0;
            foreach (PjesmaNaAlbumu p in album.ToList())
            {
                trajanje += p.VratiTrajanje();
            }
            return trajanje;

        }
    }
}
