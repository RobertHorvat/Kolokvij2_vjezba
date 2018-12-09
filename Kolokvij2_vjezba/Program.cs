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

            Console.WriteLine(a.VratiListuPjesama());
            Console.WriteLine(a.VratiNaziv());
            Console.WriteLine(a.VratiZanr());
            Console.WriteLine(a.vratiTrajanje());
            a.ObrisiPjesmu(2);

            Console.WriteLine(a.VratiListuPjesama());
            Console.ReadKey();
        }
    }
}
