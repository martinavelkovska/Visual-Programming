using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussesSept
{
    public class Bus
    {
       public string Name { get; set; }

        public int Registracija { get; set; }

        public List<Linija> linii { get; set; }
        public Boolean lokalen;

       public Bus(string name, int registracija, bool lokalen)
        {
            Name = name;
            Registracija = registracija;
            this.lokalen = lokalen;
            this.linii = new List<Linija>();
        }

        public void addDestination(Linija linija)
        {
            this.linii.Add(linija);
        }
        public override string ToString()
        {
            string l = lokalen ? "L" : "M";
            return $"{Name} - {Registracija} - {l}";
        }
    }
}
