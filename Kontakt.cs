using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SparaLasaKontakt_ovn4_2
{
    class Kontakt
    {
        string efternamn;
        string epost;
        string telefonnr;

        public Kontakt(string förnamn, string efternamn, string epost, string telefonnr)
        {
            this.Förnamn = förnamn;
            this.Efternamn = efternamn;
            this.Epost = epost;
            this.Telefonnr = telefonnr;
        }

        public string Förnamn { get; set; }
        public string Efternamn { get; set; }
        public string Epost { get; set; }
        public string Telefonnr { get; set; }

        public override string ToString()
        {
            return Förnamn + " " + Efternamn;
        }
    }
}
