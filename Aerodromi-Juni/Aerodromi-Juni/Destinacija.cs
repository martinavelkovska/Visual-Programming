using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aerodromi_Juni
{
    public class Destinacija
    {
        public string Ime { get; set; }
        public int Dolzina { get; set; }
        public int Cena { get; set; }


        public Destinacija() { }
        public Destinacija(string ime, int dolzina, int cena)
        {
            Ime = ime;
            Dolzina = dolzina;
            Cena = cena;
        }

        public override string ToString()
        {
            return $"{Ime} - {Dolzina}km - {Cena} EUR";
        }
    }
}
