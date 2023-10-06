using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aerodromi_Juni
{
    public class Aerodrom
    {
        public string Grad {get; set;}
        public string Ime { get; set;}

        public string Kratenka { get; set;}

        public List<Destinacija> destinacii;

          public Aerodrom() { }
        public Aerodrom(string grad, string ime, string kratenka)
        {
            Grad = grad;
            Ime = ime;
            Kratenka = kratenka;
            destinacii = new List<Destinacija>();

        }

        public void addDestination(Destinacija destinacija)
        {
            destinacii.Add(destinacija);
        }

        public override string ToString()
        {
            return $"{Kratenka} - {Ime} - {Grad}";
        }
    }
}
