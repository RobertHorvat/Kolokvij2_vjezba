using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolokvij2_vjezba
{
    class Program
    {
        static void Main(string[] args)
        {
            GlazbeniAlbum a = new GlazbeniAlbum("Pratim te",new Izvodac("Tose Proeski",2004),Zanr.Pop);
            a.DodajPjesmu(1, "Pratim Te", 240);
            a.DodajPjesmu(2, "Vezi Me Za Sebe", 230);
            a.DodajPjesmu(3, "Cija Si", 250);
            a.DodajPjesmu(4, "Ko Ti To Grize Obraze", 300);

            foreach (PjesmaNaAlbumu p in a.VratiListuPjesama())
                Console.WriteLine(p);

            Console.WriteLine("Naziv albuma: {0}",a.VratiNaziv());
            Console.WriteLine("Naziv Zanra: {0}",a.VratiZanr());
            Console.WriteLine("Ukupno trajanje albuma: {0} sekundi",a.vratiTrajanje());
            a.ObrisiPjesmu(2);

            foreach (PjesmaNaAlbumu p in a.VratiListuPjesama())
                Console.WriteLine(p);
            Console.ReadKey();
        }
    }
}
