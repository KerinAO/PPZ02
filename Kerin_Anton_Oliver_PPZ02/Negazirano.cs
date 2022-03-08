using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kerin_Anton_Oliver_PPZ02
{
    internal class Negazirano
    {
        String naziv, kolicina, pakiranje;
        double cijena;

        public override string ToString()
        {
            string ispis = "Naziv: " + this.naziv + "\nKolicina: " + this.kolicina + "\nPakiranje: " + this.pakiranje + "\nCijena: " + this.cijena + " kn";
            return ispis;
        }

        public Negazirano(string naziv, string kolicina, string pakiranje, double cijena)
        {
            this.Naziv = naziv;
            this.Kolicina = kolicina;
            this.Pakiranje = pakiranje;
            this.Cijena = cijena;
        }

        public string Naziv { get => naziv; set => naziv = value; }
        public string Kolicina { get => kolicina; set => kolicina = value; }
        public string Pakiranje { get => pakiranje; set => pakiranje = value; }
        public double Cijena { get => cijena; set => cijena = value; }
    }
}
