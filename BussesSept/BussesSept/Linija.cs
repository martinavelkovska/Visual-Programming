using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace BussesSept
{
    public class Linija
    {
        public string Destinacija { get; set; }

        public int Cas;

        public int Minuta;

        public int Cena;

        

        public Linija(string Destinacija, int cas, int minuta, int cena) {
        this.Destinacija = Destinacija;
        this.Cas = cas;
        this.Minuta = minuta;
        this.Cena = cena;


        }

        public override string ToString()
        {
            return $"{Cas} : {Minuta} - {Destinacija} - {Cena} Ден.";
        }
    }
}
