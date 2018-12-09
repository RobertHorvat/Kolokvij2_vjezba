using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolokvij2_vjezba
{
    public class Izvodac
    {
        private string naziv;
        private int godina;

        public Izvodac(string naziv,int godina)
        {
            this.naziv = naziv;
            this.godina = godina;
        }

        public override string ToString()
        {
            return base.ToString()+": "+naziv+" Godine: "+godina.ToString();
        }

    }
}
